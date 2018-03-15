Imports System.IO
Imports ImageMagick
Imports MathNet
Imports MathNet.Numerics.Statistics.Statistics









Public Class Form1

    Private imgStream As MemoryStream

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim fpth As String
        Dim folname As String
        Dim flname As String
        Dim fcount As Integer


        ofd.ShowDialog()
        fpth = ofd.FileName
        filepath.Text = fpth
        flname = fpth.Substring(0, fpth.LastIndexOf("\"))
        folname = fpth.Substring(fpth.LastIndexOf("\") + 1)
        fcount = Directory.GetFiles(flname, folname).Length
        filecountlabel.Text = "Found " & fcount & " files"



    End Sub

    Private Sub filepath_TextChanged(sender As Object, e As EventArgs) Handles filepath.TextChanged

        Dim fpth As String
        Dim folname As String
        Dim flname As String
        Dim fcount As Integer
        On Error GoTo erhand
        fpth = filepath.Text
        flname = fpth.Substring(0, fpth.LastIndexOf("\"))
        folname = fpth.Substring(fpth.LastIndexOf("\") + 1)
        fcount = Directory.GetFiles(flname, folname).Length
        filecountlabel.Text = "Found " & fcount & " files"

        Exit Sub
erhand:
        Exit Sub


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If imgCount > 0 Then
            If MsgBox("There's already a set of images in memory. Are you sure you want to replace them?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        End If

        'save this as the most recent location.
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\TifyVBNET\Settings", "MRL", filepath.Text)


        Dim fpth As String
        Dim folname As String
        Dim flname As String
        Dim fcount() As String
        Dim n As Integer
        Dim bv As UShort()

        Dim stp As New Stopwatch
        Dim fPixel As IPixelCollection
        Dim prTVal As Double
        Dim quad(3) As Double

        CheckBox1.Checked = False
        displaytimer.Enabled = False
        Application.DoEvents()

        fpth = filepath.Text
        flname = fpth.Substring(0, fpth.LastIndexOf("\"))
        folname = fpth.Substring(fpth.LastIndexOf("\") + 1)
        fcount = Directory.GetFiles(flname, folname)


        tsProgress.Maximum = fcount.Length - 1
        toolstripobj.Text = "Loading image"

        ReDim imagef(fcount.Length)
        ReDim imagefinfo(fcount.Length)
        GC.SuppressFinalize(imagef)

        ReDim statUniqueColour(fcount.Length)
        ReDim statEntropy(fcount.Length)
        ReDim statKurtosis(fcount.Length)
        ReDim statMaximum(fcount.Length)
        ReDim statMean(fcount.Length)
        ReDim statSkewness(fcount.Length)
        ReDim statDeviation(fcount.Length)
        ReDim statIntDensity(fcount.Length)
        ReDim statPixelRamp(fcount.Length)
        ReDim statQID(fcount.Length)
        ReDim imagepath(fcount.Length)
        ReDim statSumSquared(fcount.Length)
        ReDim imgScore(fcount.Length)
        ReDim calcScore(fcount.Length)
        ReDim imgIncluded(fcount.Length)
        imgCount = fcount.Length
        cImageVal.Maximum = imgCount - 1

        'statCount is the number of statistics that are analysed for the image. 

        threshMin.Maximum = 65535
        threshMax.Maximum = 65535
        lowthreshslider.Maximum = 65535
        upperthreshslider.Maximum = 65535
        lowthreshslider.SmallChange = 100
        upperthreshslider.SmallChange = 100
        lowthreshslider.LargeChange = 500
        upperthreshslider.LargeChange = 500



        For Each imgfilepath In fcount
            stp.Start()
            imagepath(n) = imgfilepath
            imagef(n) = New MagickImage(imgfilepath)
            imagef(n).Grayscale(PixelIntensityMethod.Average)
            imagefinfo(n) = New MagickImageInfo(imgfilepath)
            imgScore(n) = -1
            imgIncluded(n) = True

            If imagef(n).Depth = 8 Then
                threshMin.Maximum = 255
                threshMax.Maximum = 255
                lowthreshslider.Maximum = 255
                upperthreshslider.Maximum = 255
                lowthreshslider.SmallChange = 1
                upperthreshslider.SmallChange = 1
                lowthreshslider.LargeChange = 5
                upperthreshslider.LargeChange = 5
            End If

            Using imgStream As New MemoryStream
                imgStream.SetLength(0)
                imagef(n).Write(imgStream)
                PictureBox1.Refresh()
                PictureBox1.Image = Image.FromStream(imgStream)
            End Using

            'statUniqueColour(n) = imagef(n).UniqueColors
            statEntropy(n) = imagef(n).Statistics.Composite.Entropy
            statUniqueColour(n) = imagef(n).TotalColors
            statKurtosis(n) = imagef(n).Statistics.Composite.Kurtosis
            statMaximum(n) = imagef(n).Statistics.Composite.Maximum
            statMean(n) = imagef(n).Statistics.Composite.Mean
            statSkewness(n) = imagef(n).Statistics.Composite.Skewness
            statDeviation(n) = imagef(n).Statistics.Composite.StandardDeviation
            statSumSquared(n) = imagef(n).Statistics.Composite.SumSquared
            statIntDensity(n) = imagef(n).Statistics.Composite.Mean * (imagef(n).Width * imagef(n).Height)
            fPixel = imagef(n).GetPixels
            prTVal = 0

            'calculate iterative statistics. efficient to cycle once, calculate many!
            For x = 3 To imagef(n).Width - 1 Step 3
                For y = 3 To imagef(n).Height - 1 Step 3

                    bv = fPixel.GetValue(x, y)

                    'pixel ramp collection
                    prTVal = prTVal + (fPixel.GetValue(x, y).GetValue(0) - fPixel.GetValue(x - 3, y - 3).GetValue(0))

                    'quadrant intensity values
                    If x <= imagef(n).Width / 2 And y <= imagef(n).Height / 2 Then quad(0) = quad(0) + fPixel.GetValue(x, y).GetValue(0)
                    If x <= imagef(n).Width / 2 And y > imagef(n).Height / 2 Then quad(1) = quad(1) + fPixel.GetValue(x, y).GetValue(0)
                    If x > imagef(n).Width / 2 And y <= imagef(n).Height / 2 Then quad(2) = quad(2) + fPixel.GetValue(x, y).GetValue(0)
                    If x > imagef(n).Width / 2 And y > imagef(n).Height / 2 Then quad(3) = quad(3) + fPixel.GetValue(x, y).GetValue(0)


                Next
            Next

            statPixelRamp(n) = prTVal
            statQID(n) = quad.StandardDeviation

            quad(0) = 0
            quad(1) = 0
            quad(2) = 0
            quad(3) = 0

            If ListBox1.Items.Count = 0 Then
                For xx = 0 To 12
                    ListBox1.Items.Add("-")
                Next xx
            End If

            updateStatistics(n)

            tsProgress.Value = n

            stp.Stop()
            toolstripobj.Text = "Loading image " & n & " of " & fcount.Length - 1 & " (" & stp.ElapsedMilliseconds & "ms)"
            stp.Reset()
            Application.DoEvents()

            n = n + 1
        Next

        GC.KeepAlive(imagef)

    End Sub


    Private Sub displaytimer_Tick(sender As Object, e As EventArgs) Handles displaytimer.Tick
        If imgCount > 0 Then
            If cImageVal.Value = cImageVal.Maximum Then
                cImageVal.Value = 0
                Exit Sub
            End If
            cImageVal.Value = cImageVal.Value + 1
        End If

    End Sub

    Private Sub cImageVal_ValueChanged(sender As Object, e As EventArgs) Handles cImageVal.ValueChanged

        Using imgStream As New MemoryStream
            imgStream.SetLength(0)
            imagef(cImageVal.Value).Write(imgStream)
            PictureBox1.Refresh()
            PictureBox1.Image = Image.FromStream(imgStream)
        End Using

        updateStatistics()
        toolstripobj.Text = cImageVal.Value & "/" & cImageVal.Maximum
        If imgIncluded(cImageVal.Value) = False Then
            incCheck.Checked = False
            incCheck.BackColor = Color.FromArgb(255, 192, 192)
        Else
            incCheck.Checked = True
            incCheck.BackColor = Color.FromArgb(192, 255, 192)

        End If



    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dtis As Boolean
        dtis = displaytimer.Enabled
        displaytimer.Enabled = False

        'check that everything is OK 
        If Val(noiseradius.Text) = 0 And (denoise.Checked Or despeckle.Checked) Then
            MsgBox("You cannot denoise an image with the order set to 0", MsgBoxStyle.Critical)
            Exit Sub
        End If


        pleasewaitpanel.Visible = True
        Application.DoEvents()
        imagef(cImageVal.Value).Read(imagepath(cImageVal.Value))


        If despeckle.Checked Then imagef(cImageVal.Value).Despeckle()
        If denoise.Checked Then imagef(cImageVal.Value).ReduceNoise(Val(noiseradius.Text))
        imagef(cImageVal.Value).Level(CUShort(threshMin.Value), CUShort(threshMax.Value))

        Dim ovImg As MagickImage
        Dim Bmphandle As Bitmap
        If lutlist.SelectedIndex > 0 Then
            Bmphandle = My.Resources.imgResource.ResourceManager.GetObject(lutlist.Text)
            ovImg = New MagickImage(Bmphandle)
            imagef(cImageVal.Value).Clut(ovImg)
        End If





        Using imgStream As New MemoryStream
            imagef(cImageVal.Value).Write(imgStream)
            PictureBox1.Refresh()
            PictureBox1.Image = Image.FromStream(imgStream)
        End Using

        pleasewaitpanel.Visible = False
        displaytimer.Enabled = dtis

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dtis As Boolean
        dtis = displaytimer.Enabled
        displaytimer.Enabled = False

        Dim n As Integer
        If Val(noiseradius.Text) = 0 And (denoise.Checked Or despeckle.Checked) Then
            MsgBox("You cannot denoise an image with the order set to 0", MsgBoxStyle.Critical)
            displaytimer.Enabled = True
            Exit Sub
        End If

        pleasewaitpanel.Visible = True
        Application.DoEvents()
        Dim ovImg As MagickImage
        Dim Bmphandle As Bitmap

        For n = 0 To imgCount - 1
            imagef(n).Read(imagepath(n))
            imagef(n).Level(CUShort(threshMin.Value), CUShort(threshMax.Value))
            If despeckle.Checked Then imagef(n).Despeckle()
            If denoise.Checked Then imagef(n).ReduceNoise(Val(noiseradius.Text))

            Application.DoEvents()
            toolstripobj.Text = "Applying changes to frame " & n
            tsProgress.Value = n

            If lutlist.SelectedIndex > 0 Then
                Bmphandle = My.Resources.imgResource.ResourceManager.GetObject(lutlist.Text)
                ovImg = New MagickImage(Bmphandle)
                imagef(n).Clut(ovImg)
            End If


        Next

        Using imgStream As New MemoryStream
            imagef(cImageVal.Value).Write(imgStream)
            PictureBox1.Refresh()
            PictureBox1.Image = Image.FromStream(imgStream)
        End Using

        pleasewaitpanel.Visible = False
        displaytimer.Enabled = dtis


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If sender.checked = True Then
            displaytimer.Enabled = True
        Else
            displaytimer.Enabled = False
        End If
    End Sub

    Private Sub frameinterval_TextChanged(sender As Object, e As EventArgs) Handles frameinterval.TextChanged
        If Val(sender.text) > 1 Then
            displaytimer.Interval = Val(sender.text)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim runTimeResourceSet As Object
        Dim dictEntry As DictionaryEntry
        lutlist.Items.Add("")
        lutlist.Sorted = True

        filepath.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\TifyVBNET\Settings", "MRL", "")

        runTimeResourceSet = My.Resources.imgResource.ResourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, True, True)
        For Each dictEntry In runTimeResourceSet
            If (dictEntry.Value.GetType() Is GetType(Bitmap)) Then
                lutlist.Items.Add(dictEntry.Key)
            End If
        Next



    End Sub

    Private Sub scoreFrame(sender As Object, e As EventArgs) Handles scoref0.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click


        imgScore(cImageVal.Value) = Val(sender.text)
        If CheckBox2.Checked = True Then
            If cImageVal.Value = cImageVal.Maximum Then cImageVal.Value = 0 Else cImageVal.Value = cImageVal.Value + 1
        End If

        updateStatistics()

    End Sub

    Private Sub lowthreshslider_Scroll(sender As Object, e As EventArgs) Handles lowthreshslider.Scroll
        threshMin.value = sender.value

    End Sub

    Private Sub upperthreshslider_Scroll(sender As Object, e As EventArgs) Handles upperthreshslider.Scroll
        threshMax.Value = sender.value
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click

        If imgScore.Count(Function(x) x <> -1) < 12 Then
            If MsgBox("You've counted " & imgScore.Count(Function(x) x <> -1) & " frames; For reliability, in most cases, you should assess more frames. Do you wish to continue?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        End If
        statwait.Visible = True
        statwait.Refresh()
        Application.DoEvents()
        RunMLR()
        statwait.Visible = False

    End Sub
    Private Function RunMLR() As Double

        Dim stp As String
        Dim tmpfile1 As String
        Dim tmpfile2 As String
        Dim vstr As String
        Dim rsp As Boolean
        Dim txtResp As String
        Dim txtRespL() As String
        Dim tmparray() As String
        Dim nlFlag As String
        Dim adjR2 As Double


        'Use PSPP to perform statistics
        tmpfile1 = Application.StartupPath & "\pspp\command.cmd"
        tmpfile2 = Application.StartupPath & "\pspp\data.csv"
        If IO.File.Exists(tmpfile1) Then IO.File.Delete(tmpfile1)
        If IO.File.Exists(tmpfile2) Then IO.File.Delete(tmpfile2)


        Debug.Print("CMD>" & tmpfile1)
        Debug.Print("DATA>" & tmpfile2)


        IO.File.AppendAllText(tmpfile1, "SET FORMAT F30.14." & vbCrLf)
        IO.File.AppendAllText(tmpfile1, "GET DATA /TYPE=TXT" & vbCrLf)
        IO.File.AppendAllText(tmpfile1, "   /FILE='" & tmpfile2 & "'" & vbCrLf)
                IO.File.AppendAllText(tmpfile1, "   /ARRANGEMENT=DELIMITED" & vbCrLf)
        IO.File.AppendAllText(tmpfile1, "   /DELIMITERS=','" & vbCrLf)
        IO.File.AppendAllText(tmpfile1, "   /FIRSTCASE=1" & vbCrLf)

        IO.File.AppendAllText(tmpfile1, "   /VARIABLES=")
        vstr = ""

        If enDeviation.Text = "Y" Then IO.File.AppendAllText(tmpfile1, "sDev F6.4" & vbCrLf) : vstr = vstr & "sDev "
        If enEntropy.Text = "Y" Then IO.File.AppendAllText(tmpfile1, "sEnt F6.5" & vbCrLf) : vstr = vstr & "sEnt "
        If enIntDen.Text = "Y" Then IO.File.AppendAllText(tmpfile1, "sIntDen F14.1" & vbCrLf) : vstr = vstr & "sIntDen "
        If enKurtosis.Text = "Y" Then IO.File.AppendAllText(tmpfile1, "sKurt F5.4" & vbCrLf) : vstr = vstr & "sKurt "
        If enMaximum.Text = "Y" Then IO.File.AppendAllText(tmpfile1, "sMax F5" & vbCrLf) : vstr = vstr & "sMax "
        If enMean.Text = "Y" Then IO.File.AppendAllText(tmpfile1, "sMean F6.4" & vbCrLf) : vstr = vstr & "sMean "
        If enQID.Text = "Y" Then IO.File.AppendAllText(tmpfile1, "sQID F6.5" & vbCrLf) : vstr = vstr & "sQID "
        If enSkewness.Text = "Y" Then IO.File.AppendAllText(tmpfile1, "sSkew F10.9" & vbCrLf) : vstr = vstr & "sSkew "
        If enSumSquared.Text = "Y" Then IO.File.AppendAllText(tmpfile1, "sSumSq F8.5" & vbCrLf) : vstr = vstr & "sSumSq "
        If enUniqueColours.Text = "Y" Then IO.File.AppendAllText(tmpfile1, "sUnique F5" & vbCrLf) : vstr = vstr & "sUnique "
        If enPixelRamp.Text = "Y" Then IO.File.AppendAllText(tmpfile1, "sPixelR F10.5" & vbCrLf) : vstr = vstr & "sPixelR "

        IO.File.AppendAllText(tmpfile1, "quality F18.9." & vbCrLf)
        IO.File.AppendAllText(tmpfile1, "REGRESSION /VARIABLES=" & vstr & "/STATISTICS coeff r /DEPENDENT quality.")

        Debug.Print(tmpfile1)
        Debug.Print(tmpfile2)

        For n = 0 To imgCount - 1
            stp = ""

            If enDeviation.Text = "Y" Then stp = stp & statDeviation(n) & ","
            If enEntropy.Text = "Y" Then stp = stp & statEntropy(n) & ","
            If enIntDen.Text = "Y" Then stp = stp & statIntDensity(n) & ","
            If enKurtosis.Text = "Y" Then stp = stp & statKurtosis(n) & ","
            If enMaximum.Text = "Y" Then stp = stp & statMaximum(n) & ","
            If enMean.Text = "Y" Then stp = stp & statMean(n) & ","
            If enQID.Text = "Y" Then stp = stp & statQID(n) & ","
            If enSkewness.Text = "Y" Then stp = stp & statSkewness(n) & ","
            If enSumSquared.Text = "Y" Then stp = stp & statSumSquared(n) & ","
            If enUniqueColours.Text = "Y" Then stp = stp & statUniqueColour(n) & ","
            If enPixelRamp.Text = "Y" Then stp = stp & statPixelRamp(n) & ","
            stp = stp & imgScore(n)
            If imgScore(n) > -1 Then
                IO.File.AppendAllText(tmpfile2, stp & vbCrLf)
            End If

        Next

        Dim proc = New Process()
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.RedirectStandardError = True
        proc.StartInfo.RedirectStandardOutput = True
        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.FileName = Application.StartupPath & "\pspp\pspp.exe"
        proc.StartInfo.Arguments = "-O format=csv " & Chr(34) & tmpfile1 & Chr(34)
        proc.StartInfo.WorkingDirectory = Application.StartupPath & "\pspp"
        proc.Start()
        statwait.Refresh()
        Application.DoEvents()

        rsp = proc.WaitForExit(5000)
        If rsp = False Then
            MsgBox("PSPP did not respond in a timely fashion. Please ensure the application is accessible to Tify.", MsgBoxStyle.Critical)
            RunMLR = -1
            Exit Function
        End If
        txtResp = proc.StandardOutput.ReadToEnd()
        proc.Close()
        Debug.Print(txtResp)
        txtRespL = Split(txtResp, Environment.NewLine)

        'process the incoming data
        nlFlag = ""
        For Each ltxt As String In txtRespL

            If ltxt.Length = 0 Then Continue For

            If InStr(ltxt, "Adjusted R Square") > 0 Then nlFlag = "rsquared" : Continue For

            If nlFlag = "rsquared" Then
                tmparray = Split(ltxt, ",")
                Label33.Text = "Adjusted R2: " & CDbl(tmparray(3))
                adjR2 = CDbl(tmparray(3))
                nlFlag = "coeff"
            End If

            If nlFlag = "coeff" And InStr(ltxt, "(Constant)") > 0 Then
                tmparray = Split(ltxt, ",")
                coeffConstant.Text = CDbl(tmparray(2))
                If coeffConstant.Text = "NaN" Then coeffConstant.Text = "0"

            End If

            If nlFlag = "coeff" And InStr(ltxt, "sDev") > 0 Then
                tmparray = Split(ltxt, ",")
                coeffDeviation.Text = CDbl(tmparray(2))
                If coeffDeviation.Text = "NaN" Then coeffDeviation.Text = "0"
                sigDeviation.Text = CDbl(tmparray(6))
                If sigDeviation.Text = "NaN" Then sigDeviation.Text = "1"
            End If

            If nlFlag = "coeff" And InStr(ltxt, "sEnt") > 0 Then
                tmparray = Split(ltxt, ",")
                coeffEntropy.Text = CDbl(tmparray(2))
                If coeffEntropy.Text = "NaN" Then coeffEntropy.Text = "0"
                sigEntropy.Text = CDbl(tmparray(6))
                If sigEntropy.Text = "NaN" Then sigEntropy.Text = "1"
            End If

            If nlFlag = "coeff" And InStr(ltxt, "sIntDen") > 0 Then
                tmparray = Split(ltxt, ",")
                coeffIntDen.Text = CDbl(tmparray(2))
                If coeffIntDen.Text = "NaN" Then coeffIntDen.Text = "0"
                sigIntDen.Text = CDbl(tmparray(6))
                If sigIntDen.Text = "NaN" Then sigIntDen.Text = "1"
            End If

            If nlFlag = "coeff" And InStr(ltxt, "sKurt") > 0 Then
                tmparray = Split(ltxt, ",")
                coeffKurtosis.Text = CDbl(tmparray(2))
                If coeffKurtosis.Text = "NaN" Then coeffKurtosis.Text = "0"
                sigKurtosis.Text = CDbl(tmparray(6))
                If sigKurtosis.Text = "NaN" Then sigKurtosis.Text = "1"
            End If

            If nlFlag = "coeff" And InStr(ltxt, "sMax") > 0 Then
                tmparray = Split(ltxt, ",")
                coeffMaximum.Text = CDbl(tmparray(2))
                If coeffMaximum.Text = "NaN" Then coeffMaximum.Text = "0"
                sigMaximum.Text = CDbl(tmparray(6))
                If sigMaximum.Text = "NaN" Then sigMaximum.Text = "1"
            End If

            If nlFlag = "coeff" And InStr(ltxt, "sMean") > 0 Then
                tmparray = Split(ltxt, ",")
                coeffMean.Text = CDbl(tmparray(2))
                If coeffMean.Text = "NaN" Then coeffMean.Text = "0"
                sigMean.Text = CDbl(tmparray(6))
                If sigMean.Text = "NaN" Then sigMean.Text = "1"
            End If

            If nlFlag = "coeff" And InStr(ltxt, "sQID") > 0 Then
                tmparray = Split(ltxt, ",")
                coeffQID.Text = CDbl(tmparray(2))
                If coeffQID.Text = "NaN" Then coeffQID.Text = "0"
                sigQID.Text = CDbl(tmparray(6))
                If sigQID.Text = "NaN" Then sigQID.Text = "1"
            End If

            If nlFlag = "coeff" And InStr(ltxt, "sSkew") > 0 Then
                tmparray = Split(ltxt, ",")
                coeffSkewness.Text = CDbl(tmparray(2))
                If coeffSkewness.Text = "NaN" Then coeffSkewness.Text = "0"
                sigSkewness.Text = CDbl(tmparray(6))
                If sigSkewness.Text = "NaN" Then sigSkewness.Text = "1"
            End If

            If nlFlag = "coeff" And InStr(ltxt, "sSumSq") > 0 Then
                tmparray = Split(ltxt, ",")
                coeffSumSquared.Text = CDbl(tmparray(2))
                If coeffSumSquared.Text = "NaN" Then coeffSumSquared.Text = "0"
                sigSumSquared.Text = CDbl(tmparray(6))
                If sigSumSquared.Text = "NaN" Then sigSumSquared.Text = "1"
            End If

            If nlFlag = "coeff" And InStr(ltxt, "sUnique") > 0 Then
                tmparray = Split(ltxt, ",")
                coeffUniqueColours.Text = CDbl(tmparray(2))
                If coeffUniqueColours.Text = "NaN" Then coeffUniqueColours.Text = "0"
                sigUniqueColours.Text = CDbl(tmparray(6))
                If sigUniqueColours.Text = "NaN" Then sigUniqueColours.Text = "1"
            End If

            If nlFlag = "coeff" And InStr(ltxt, "sPixelR") > 0 Then
                tmparray = Split(ltxt, ",")
                coeffPixelRamp.Text = CDbl(tmparray(2))
                If coeffPixelRamp.Text = "NaN" Then coeffPixelRamp.Text = "0"
                sigPixelRamp.Text = CDbl(tmparray(6))
                If sigPixelRamp.Text = "NaN" Then sigPixelRamp.Text = "1"
            End If

            Application.DoEvents()

        Next

        RunMLR = adjR2



    End Function
    Private Sub enUniqueColours_Click(sender As Object, e As EventArgs) Handles enUniqueColours.Click, enDeviation.Click, enEntropy.Click,
        enIntDen.Click, enKurtosis.Click, enMaximum.Click, enMean.Click, enQID.Click, enSkewness.Click, enSumSquared.Click, enPixelRamp.Click

        If sender.text = "Y" Then sender.text = "N" Else sender.text = "Y"

        If sender.name = "enUniqueColours" Then coeffUniqueColours.Text = "-" : sigUniqueColours.Text = "-"
        If sender.name = "enDeviation" Then coeffDeviation.Text = "-" : sigDeviation.Text = "-"
        If sender.name = "enEntropy" Then coeffEntropy.Text = "-" : sigEntropy.Text = "-"
        If sender.name = "enIntDen" Then coeffIntDen.Text = "-" : sigIntDen.Text = "-"
        If sender.name = "enKurtosis" Then coeffKurtosis.Text = "-" : sigKurtosis.Text = "-"
        If sender.name = "enMaximum" Then coeffMaximum.Text = "-" : sigMaximum.Text = "-"
        If sender.name = "enMean" Then coeffMean.Text = "-" : sigMean.Text = "-"
        If sender.name = "enQID" Then coeffQID.Text = "-" : sigQID.Text = "-"
        If sender.name = "enSkewness" Then coeffSkewness.Text = "-" : sigSkewness.Text = "-"
        If sender.name = "enSumSquared" Then coeffSumSquared.Text = "-" : sigSumSquared.Text = "-"
        If sender.name = "enPixelRamp" Then coeffPixelRamp.Text = "-" : sigPixelRamp.Text = "-"






    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'perform the step wise MLR
        Dim sninc As Integer
        Dim rsv As Double
        Dim nrsv As Double
        Dim maxP As Double
        Dim maxPobj As String

        sninc = 0

        For Each objHnd In Me.TabPage3.Controls("TableLayoutPanel1").Controls

            If objHnd.name.substring(0, 2) = "en" Then
                If objHnd.text = "N" Then sninc = sninc + 1
            End If

        Next

        If sninc > 0 Then
            If MsgBox("A number of statistics are marked as being excluded. If you continue with the stepwise regression, these statistics will be ignored from the start. Do you want to continue?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        End If


        statwait.Visible = True

        'do the stepwise regression. 
        'Step 1 - do the initial run. 
beginSLoop:
        rsv = RunMLR()
        maxP = 0.05
        maxPobj = ""
        Application.DoEvents()

        'Step 2 - check if there are p-values above 0.05.
        For Each objHnd In Me.TabPage3.Controls("TableLayoutPanel1").Controls
            If objHnd.name.substring(0, 3) = "sig" And objHnd.text <> "-" Then
                If CDbl(objHnd.text) > maxP Then
                    maxP = objHnd.text
                    maxPobj = objHnd.name
                End If
            End If
        Next

        If maxP > 0.05 Then
            'there is a stat to take out.
            Me.TabPage3.Controls("TableLayoutPanel1").Controls(maxPobj.Replace("sig", "en")).Text = "N"
            're-run the MLR. 
            If maxPobj.Replace("sig", "en") = "enUniqueColours" Then coeffUniqueColours.Text = "-" : sigUniqueColours.Text = "-"
            If maxPobj.Replace("sig", "en") = "enDeviation" Then coeffDeviation.Text = "-" : sigDeviation.Text = "-"
            If maxPobj.Replace("sig", "en") = "enEntropy" Then coeffEntropy.Text = "-" : sigEntropy.Text = "-"
            If maxPobj.Replace("sig", "en") = "enIntDen" Then coeffIntDen.Text = "-" : sigIntDen.Text = "-"
            If maxPobj.Replace("sig", "en") = "enKurtosis" Then coeffKurtosis.Text = "-" : sigKurtosis.Text = "-"
            If maxPobj.Replace("sig", "en") = "enMaximum" Then coeffMaximum.Text = "-" : sigMaximum.Text = "-"
            If maxPobj.Replace("sig", "en") = "enMean" Then coeffMean.Text = "-" : sigMean.Text = "-"
            If maxPobj.Replace("sig", "en") = "enQID" Then coeffQID.Text = "-" : sigQID.Text = "-"
            If maxPobj.Replace("sig", "en") = "enSkewness" Then coeffSkewness.Text = "-" : sigSkewness.Text = "-"
            If maxPobj.Replace("sig", "en") = "enSumSquared" Then coeffSumSquared.Text = "-" : sigSumSquared.Text = "-"
            If maxPobj.Replace("sig", "en") = "enPixelRamp" Then coeffPixelRamp.Text = "-" : sigPixelRamp.Text = "-"

            Application.DoEvents()
            nrsv = RunMLR()
            If nrsv <= rsv Then
                'worsened the model. put it back and stop.
                Debug.Print(">>>>>>>>>" & Me.TabPage3.Controls("TableLayoutPanel1").Controls(maxPobj).Name)
                Me.TabPage3.Controls("TableLayoutPanel1").Controls(maxPobj.Replace("sig", "en")).Text = "Y"
                RunMLR()
                MsgBox("Automatic stepwise regression finished. Please examine the model and R2, as the routine finished suboptimally.", MsgBoxStyle.Information)
                GoTo exitSLoop
            End If

            'go back and go again.
            GoTo beginSLoop



        End If

        'There's no more stats above 0.05.
        MsgBox("Automatic stepwise regression finished.", MsgBoxStyle.Information)


exitSLoop:
        statwait.Visible = False


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim rtot As Double
        statwait.Visible = True
        statwait.Refresh()
        Application.doevents

        For n = 0 To imgCount - 1

            rtot = CDbl(coeffConstant.Text)

            For Each objHnd In Me.TabPage3.Controls("TableLayoutPanel1").Controls
                If objHnd.name.substring(0, 2) = "en" And objHnd.text = "Y" Then

                    If objHnd.name = enEntropy.Name Then rtot = rtot + (statEntropy(n) * CDbl(coeffEntropy.Text))
                    If objHnd.name = enDeviation.Name Then rtot = rtot + (statDeviation(n) * CDbl(coeffDeviation.Text))
                    If objHnd.name = enIntDen.Name Then rtot = rtot + (statIntDensity(n) * CDbl(coeffIntDen.Text))
                    If objHnd.name = enKurtosis.Name Then rtot = rtot + (statKurtosis(n) * CDbl(coeffKurtosis.Text))
                    If objHnd.name = enMaximum.Name Then rtot = rtot + (statMaximum(n) * CDbl(coeffMaximum.Text))
                    If objHnd.name = enMean.Name Then rtot = rtot + (statMean(n) * CDbl(coeffMean.Text))
                    If objHnd.name = enPixelRamp.Name Then rtot = rtot + (statPixelRamp(n) * CDbl(coeffPixelRamp.Text))
                    If objHnd.name = enQID.Name Then rtot = rtot + (statQID(n) * CDbl(coeffQID.Text))
                    If objHnd.name = enSumSquared.Name Then rtot = rtot + (statSumSquared(n) * CDbl(coeffSumSquared.Text))
                    If objHnd.name = enSkewness.Name Then rtot = rtot + (statSkewness(n) * CDbl(coeffSkewness.Text))
                    If objHnd.name = enUniqueColours.Name Then rtot = rtot + (statUniqueColour(n) * CDbl(coeffUniqueColours.Text))

                End If

                toolstripobj.Text = "Processing frame " & n
                tsProgress.Value = n

            Next

            calcScore(n) = rtot

        Next

        statwait.Visible = False

        updateStatistics
    End Sub

    Private Sub updateStatistics(Optional imgval As Integer = -1)
        Dim sts As Integer
        Dim prv As Integer

        If imgval > -1 Then
            sts = imgval
        Else
            sts = cImageVal.Value
        End If

        prv = ListBox1.TopIndex


        ListBox1.Items.Item(0) = "Unique colours: " & statUniqueColour(sts)
        ListBox1.Items.Item(1) = "Entropy: " & statEntropy(sts)
        ListBox1.Items.Item(2) = "Kurtosis: " & statKurtosis(sts)
        ListBox1.Items.Item(3) = "Maximum: " & statMaximum(sts)
        ListBox1.Items.Item(4) = "Mean: " & statMean(sts)
        ListBox1.Items.Item(5) = "Skewness: " & statSkewness(sts)
        ListBox1.Items.Item(6) = "Deviation: " & statDeviation(sts)
        ListBox1.Items.Item(7) = "Integrated Density: " & statIntDensity(sts)
        ListBox1.Items.Item(8) = "Pixel ramp: " & statPixelRamp(sts)
        ListBox1.Items.Item(9) = "QID: " & statQID(sts)
        ListBox1.Items.Item(10) = "SumSquared: " & statSumSquared(sts)
        ListBox1.Items.Item(11) = "Manual score: " & imgScore(sts)
        ListBox1.Items.Item(12) = "Calculated score: " & calcScore(sts)

        ListBox1.TopIndex = prv

    End Sub

    Private Sub Form1_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel

        If e.Delta > 0 And cImageVal.Value < cImageVal.Maximum Then cImageVal.Value = cImageVal.Value + 1
        If e.Delta < 0 And cImageVal.Value > 0 Then cImageVal.Value = cImageVal.Value - 1



    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim opf As IO.StreamWriter
        On Error GoTo filewriteerror

        sfd.AddExtension = True
        sfd.DefaultExt = ".coeff"
        sfd.Filter = "Coefficient files|*.coeff"
        sfd.ShowDialog()

        If sfd.FileName = "" Then MsgBox("Save cancelled.") : Exit Sub

        If IO.File.Exists(sfd.FileName) Then IO.File.Delete(sfd.FileName)

        opf = My.Computer.FileSystem.OpenTextFileWriter(sfd.FileName, False)

        For Each objHnd In Me.TabPage3.Controls("TableLayoutPanel1").Controls
            opf.WriteLine(objHnd.name)
            opf.WriteLine(objHnd.text)
        Next

        opf.Close()
        Exit Sub
filewriteerror:
        MsgBox("There was an error writing to the file specified.")

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim opf As IO.StreamReader
        Dim objN As String
        Dim objV As String

        ofd.AddExtension = True
        ofd.DefaultExt = "*.coeff"
        ofd.Filter = "Coefficient files|*.coeff"
        ofd.ShowDialog()

        If ofd.FileName = "" Then MsgBox("Load cancelled.") : Exit Sub

        opf = My.Computer.FileSystem.OpenTextFileReader(ofd.FileName)

        Do While opf.EndOfStream = False

            objN = opf.ReadLine
            objV = opf.ReadLine

            Me.TabPage3.Controls("TableLayoutPanel1").Controls(objN).Text = objV

        Loop

    End Sub

    Private Sub incCheck_CheckedChanged(sender As Object, e As EventArgs) Handles incCheck.CheckedChanged
        If sender.checked = True Then imgIncluded(cImageVal.Value) = True Else imgIncluded(cImageVal.Value) = False

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        exclabel.Text = sender.value

    End Sub

    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged

    End Sub

    Private Sub TrackBar1_MouseUp(sender As Object, e As MouseEventArgs) Handles TrackBar1.MouseUp
        exclabel.Text = sender.value
        For n = 0 To imgCount
            If calcScore(n) >= sender.value Then imgIncluded(n) = True Else imgIncluded(n) = False
            If Not imgScore(n) = -1 And imgScore(n) > sender.value Then imgIncluded(n) = True
        Next
    End Sub
End Class