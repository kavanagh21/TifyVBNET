Imports System.IO
Imports System.Security.Principal
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

        ofd.AddExtension = True
        ofd.DefaultExt = "*.*"
        ofd.Filter = "All files|*.*"

        ofd.ShowDialog()
        fpth = ofd.FileName

        If fpth = "" Then Exit Sub

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
        Dim n1 As Integer
        Dim bv As UShort()
        Dim pxCount As Integer

        Dim stp As New Stopwatch
        Dim fPixel As IPixelCollection
        Dim prTVal As Double
        Dim quad(3) As Double
        Dim adval As Double
        Dim dvs As Integer
        Dim imgDiv As Double
        Dim xcol As Integer
        Dim imgDivH As Double
        Dim ycol As Integer
        Dim snum As Integer
        Dim segmentsum(0) As Double
        Dim sgdim As Integer

        CheckBox1.Checked = False
        displaytimer.Enabled = False
        pleasewaitpanel.Visible = True

        Application.DoEvents()

        fpth = filepath.Text
        flname = fpth.Substring(0, fpth.LastIndexOf("\"))
        folname = fpth.Substring(fpth.LastIndexOf("\") + 1)
        fcount = Directory.GetFiles(flname, folname)


        tsProgress.Maximum = fcount.Length - 1
        toolstripobj.Text = "Loading image"

        ReDim imagef(fcount.Length - 1)
        ReDim imagefinfo(fcount.Length - 1)
        GC.SuppressFinalize(imagef)

        ReDim statUniqueColour(fcount.Length - 1)
        ReDim statEntropy(fcount.Length - 1)
        ReDim statKurtosis(fcount.Length - 1)
        ReDim statMaximum(fcount.Length - 1)
        ReDim statMean(fcount.Length - 1)
        ReDim statSkewness(fcount.Length - 1)
        ReDim statDeviation(fcount.Length - 1)
        ReDim statIntDensity(fcount.Length - 1)
        ReDim statPixelRamp(fcount.Length - 1)
        ReDim statQID(fcount.Length - 1)
        ReDim imagepath(fcount.Length - 1)
        ReDim statSumSquared(fcount.Length - 1)
        ReDim imgScore(fcount.Length - 1)
        ReDim calcScore(fcount.Length - 1)
        ReDim imgIncluded(fcount.Length - 1)
        imgCount = fcount.Length
        cImageVal.Maximum = imgCount - 1

        'statCount is the number of statistics that are analysed for the image. 

        If setimgminmax.Checked = True Then
            threshMin.Maximum = 1
            threshMax.Maximum = 1
            threshMin.Value = 1
            threshMax.Value = 1

            upperthreshslider.Maximum = 1
            lowthreshslider.Maximum = 1
        Else
            threshMin.Maximum = 65535
            threshMax.Maximum = 65535
            threshMax.Value = 65535
            upperthreshslider.Maximum = 65535
            lowthreshslider.Maximum = 65535
            lowthreshslider.Value = 1
            upperthreshslider.Value = 65535
        End If




        For Each imgfilepath In fcount
            stp.Start()
            imagepath(n) = imgfilepath
            imagef(n) = New MagickImage(imgfilepath)
            imagef(n).Grayscale(PixelIntensityMethod.Average)
            imagefinfo(n) = New MagickImageInfo(imgfilepath)
            imgScore(n) = -1
            imgIncluded(n) = True

            If setimgminmax.Checked = True Then
                If threshMin.Maximum < imagef(n).Statistics.Composite.Maximum Then threshMin.Maximum = imagef(n).Statistics.Composite.Maximum

                If threshMax.Maximum < imagef(n).Statistics.Composite.Maximum Then threshMax.Maximum = imagef(n).Statistics.Composite.Maximum
                If upperthreshslider.Maximum < imagef(n).Statistics.Composite.Maximum Then upperthreshslider.Maximum = imagef(n).Statistics.Composite.Maximum
                If lowthreshslider.Maximum < imagef(n).Statistics.Composite.Maximum Then lowthreshslider.Maximum = imagef(n).Statistics.Composite.Maximum
                lowthreshslider.Value = 0
                threshMin.Value = 0
                upperthreshslider.Value = upperthreshslider.Maximum
                threshMax.Value = threshMax.Maximum
                'Debug.print(imagef(n).Statistics.Composite.Maximum)
            End If


            Using imgStream As New MemoryStream
                imgStream.SetLength(0)
                imagef(n).Write(imgStream)
                PictureBox1.Refresh()
                PictureBox1.Image = Image.FromStream(imgStream)
            End Using


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
            pxCount = 0

            Select Case qidCount.SelectedIndex
                Case 0
                    dvs = 2
                    sgdim = 3
                Case 1
                    dvs = 3
                    sgdim = 8
                Case 2
                    dvs = 4
                    sgdim = 15
                Case 3
                    dvs = 5
                    sgdim = 24
                Case 4
                    dvs = 6
                    sgdim = 35
            End Select


            ReDim segmentsum(sgdim)

            imgDiv = imagef(n).Width / dvs
            imgDivH = imagef(n).Height / dvs

            'calculate iterative statistics. efficient to cycle once, calculate many!
            'the global variable statpxStep defines the statistics stepping value
            If CheckBox3.Checked = False Then
                For x = statpxStep To imagef(n).Width - 1 Step statpxStep
                    For y = statpxStep To imagef(n).Height - 1 Step statpxStep

                        bv = fPixel.GetValue(x, y)

                        'pixel ramp collection
                        adval = (fPixel.GetValue(x, y).GetValue(0) - fPixel.GetValue(x, y - statpxStep).GetValue(0))

                        prTVal = prTVal + Math.Abs(adval)

                        'quadrant intensity values
                        'calculate quadrant location
                        xcol = Int(x / imgDiv) + 1
                        ycol = Int(y / imgDivH) + 1
                        snum = (xcol + ((ycol - 1) * dvs)) - 1
                        segmentsum(snum) += fPixel.GetValue(x, y).GetValue(0)


                        'Debug.print("X:" & x & "; Y: " & y & "; xcol: " & xcol & "; ycol: " & ycol & "; snum: " & snum)

                        'Debug.print("PxInt: " & fPixel.GetValue(x, y).GetValue(0))
                        pxCount += 1

                    Next
                Next
            End If
            'Debug.print("QUAD values: " & quad(0) & ", " & quad(1) & ", " & quad(2) & ", " & quad(3))
            'Debug.print("QUAD values: " & segmentsum(0) & ", " & segmentsum(1) & ", " & segmentsum(2) & ", " & segmentsum(3))
            'Debug.print("STDEV:" & quad.StandardDeviation)
            'Debug.print("STDEV: " & segmentsum.StandardDeviation)
            'Debug.Print(prTVal)

            If normalisestats.Checked = True Then
                For n1 = 0 To sgdim
                    segmentsum(n1) = segmentsum(n1) / pxCount
                Next
            End If


            If normalisestats.Checked = False Then
                statPixelRamp(n) = prTVal
                statQID(n) = segmentsum.StandardDeviation
            Else
                statPixelRamp(n) = prTVal / pxCount
                statQID(n) = segmentsum.StandardDeviation
            End If

            Debug.Print(statQID(n))

            If ListBox1.Items.Count = 0 Then
                For xx = 0 To 12
                    ListBox1.Items.Add("-")
                Next xx
            End If

            updateStatistics(n)

            tsProgress.Value = n

            stp.Stop()
            toolstripobj.Text = "Loading image " & n & " of " & fcount.Length - 1 & " (" & stp.ElapsedMilliseconds & "ms) [" & pxCount & "]"
            cfilename.Text = "Current filename: " & imagepath(n)
            stp.Reset()
            Application.DoEvents()

            n = n + 1
        Next

        If setimgminmax.Checked = True Then
            Call Button4_Click(vbNull, e)
        End If


        pleasewaitpanel.Visible = False
        GC.KeepAlive(imagef)
        TrackBar1.Enabled = True
        incCheck.BackColor = Color.Green
        incCheck.ForeColor = Color.White

    End Sub


    Private Sub displaytimer_Tick(sender As Object, e As EventArgs) Handles displaytimer.Tick
        Dim tmpv As Integer

        If imgIncluded.Count(Function(x) x = True) = 0 Then toolstripobj.Text = "No images remain in the set." : displaytimer.Enabled = False : Exit Sub


        If imgCount > 0 Then
            If cImageVal.Value = cImageVal.Maximum Then
                cImageVal.Value = 0
                Exit Sub
            End If


            tmpv = cImageVal.Value
tryagain:
            tmpv += 1
            If tmpv > imgCount - 1 Then tmpv = 0
            If imgIncluded(tmpv) = False And skipcheck.Checked = True Then GoTo tryagain : 




            cImageVal.Value = tmpv
            cfilename.Text = "Current filename: " & imagepath(tmpv)
            Application.DoEvents()
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
            incCheck.BackColor = Color.Red
        Else
            incCheck.Checked = True
            incCheck.BackColor = Color.Green

        End If
        cfilename.Text = "Current filename: " & imagepath(cImageVal.Value)
        Application.DoEvents()



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
        'Application.DoEvents()
        imagef(cImageVal.Value).Dispose()
        imagef(cImageVal.Value).Read(imagepath(cImageVal.Value))
        imagef(cImageVal.Value).Grayscale(PixelIntensityMethod.Average)

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

        If lutlist.SelectedIndex > 0 Then
            Bmphandle = My.Resources.imgResource.ResourceManager.GetObject(lutlist.Text)
            ovImg = New MagickImage(Bmphandle)
        End If


        For n = 0 To imgCount - 1
            imagef(n).Dispose()
            imagef(n).Read(imagepath(n))
            imagef(n).Grayscale(PixelIntensityMethod.Average)
            imagef(n).Level(CUShort(threshMin.Value), CUShort(threshMax.Value))
            If despeckle.Checked Then imagef(n).Despeckle()
            If denoise.Checked Then imagef(n).ReduceNoise(Val(noiseradius.Text))

            Application.DoEvents()
            toolstripobj.Text = "Applying changes to frame " & n
            tsProgress.Value = n

            If lutlist.SelectedIndex > 0 Then
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

        'hide TabPage4 as the main purpose was for the production of data for the accompanying manuscript.
        'TabControl1.TabPages.Remove(TabPage4)

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

        For n = 1 To 200
            expfulldata.Items.Add(n)
        Next

        pxstepDropdown.SelectedIndex = 2
        statpxStep = 3
        qidCount.SelectedIndex = 0


        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)


    End Sub

    Private Sub scoreFrame(sender As Object, e As EventArgs) Handles scoref0.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click


        imgScore(cImageVal.Value) = Val(sender.text)
        If CheckBox2.Checked = True Then
            If cImageVal.Value = cImageVal.Maximum Then cImageVal.Value = 0 Else cImageVal.Value = cImageVal.Value + 1
        End If

        updateStatistics()

    End Sub

    Private Sub lowthreshslider_Scroll(sender As Object, e As EventArgs) Handles lowthreshslider.Scroll
        threshMin.Value = sender.value

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
        Dim swlimval As Integer

        'Use PSPP to perform statistics
        tmpfile1 = Application.StartupPath & "\psppFolder\command.cmd"
        tmpfile2 = Application.StartupPath & "\psppFolder\data.csv"
        If IO.File.Exists(tmpfile1) Then IO.File.Delete(tmpfile1)
        If IO.File.Exists(tmpfile2) Then IO.File.Delete(tmpfile2)
        toolstripobj.Text = "OCS1 complete"


        'Debug.print("CMD>" & tmpfile1)
        'Debug.print("DATA>" & tmpfile2)


        IO.File.AppendAllText(tmpfile1, "SET FORMAT F30.14." & vbCrLf)
        IO.File.AppendAllText(tmpfile1, "GET DATA /TYPE=TXT" & vbCrLf)
        IO.File.AppendAllText(tmpfile1, "   /FILE='" & tmpfile2 & "'" & vbCrLf)
        IO.File.AppendAllText(tmpfile1, "   /ARRANGEMENT=DELIMITED" & vbCrLf)
        IO.File.AppendAllText(tmpfile1, "   /DELIMITERS=','" & vbCrLf)
        IO.File.AppendAllText(tmpfile1, "   /FIRSTCASE=1" & vbCrLf)

        IO.File.AppendAllText(tmpfile1, "   /VARIABLES=")
        vstr = ""
        toolstripobj.Text = "OCS2 complete"

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
        toolstripobj.Text = "OCS3 complete"

        'Debug.print(tmpfile1)
        'Debug.print(tmpfile2)

        toolstripobj.Text = "OCS3a complete"


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
            'this information is published to the secondary temporary file (e.g. the data file)
            toolstripobj.Text = "OCS3b complete"
            If swlimit.SelectedItem.ToString = "No limit" Or swlimit.SelectedItem.ToString = "" Then
                swlimval = 9999
            Else
                swlimval = CInt(swlimit.SelectedItem) - 1
            End If

            If imgScore(n) > -1 And swlimval >= n Then IO.File.AppendAllText(tmpfile2, stp & vbCrLf)

            toolstripobj.Text = "OCS3c complete"

        Next

        toolstripobj.Text = "OCS4 complete"


        Dim proc = New Process()
        proc.StartInfo.UseShellExecute = False
        proc.StartInfo.RedirectStandardError = True
        proc.StartInfo.RedirectStandardOutput = True
        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.FileName = Application.StartupPath & "\psppFolder\pspp.exe"
        proc.StartInfo.Arguments = "-O format=csv " & Chr(34) & tmpfile1 & Chr(34)
        proc.StartInfo.WorkingDirectory = Application.StartupPath & "\psppFolder"
        proc.Start()
        statwait.Refresh()
        Application.DoEvents()

        toolstripobj.Text = "OCS5 complete"


        rsp = proc.WaitForExit(5000)
        If rsp = False Then
            MsgBox("PSPP did not respond in a timely fashion. Please ensure the application is accessible to Tify.", MsgBoxStyle.Critical)
            RunMLR = -1
            Exit Function
        End If
        txtResp = proc.StandardOutput.ReadToEnd()
        proc.Close()
        'Debug.print(txtResp)
        txtRespL = Split(txtResp, Environment.NewLine)

        toolstripobj.Text = "OCS6 complete"


        'process the incoming data
        nlFlag = ""
        For Each ltxt As String In txtRespL
            'Debug.print(ltxt)

            If ltxt.Length = 0 Then Continue For

            If InStr(ltxt, "Adjusted R Square") > 0 Then nlFlag = "rsquared" : Continue For

            If nlFlag = "rsquared" Then
                tmparray = Split(ltxt, ",")
                If InStr(tmparray(3), "Infinity") = 0 Then
                    Label33.Text = "Adjusted R2: " & CDbl(tmparray(3))
                    adjR2 = CDbl(tmparray(3))
                End If
                If InStr(tmparray(3), "Infinity") > 0 Then Label33.Text = "Adjusted R2: Infinity"
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

        toolstripobj.Text = "OCS7 complete"


    End Function
    Private Sub enUniqueColours_Click(sender As Object, e As EventArgs) Handles enUniqueColours.Click, enSumSquared.Click, enSkewness.Click, enQID.Click, enPixelRamp.Click, enMean.Click, enMaximum.Click, enKurtosis.Click, enIntDen.Click, enEntropy.Click, enDeviation.Click

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


        DoSWMLR()


    End Sub

    Private Sub DoSWMLR()

        'perform the step wise MLR
        Dim sninc As Integer
        Dim rsv As Double
        Dim nrsv As Double
        Dim maxP As Double
        Dim maxPobj As String
        Dim subopt As Boolean

        subopt = False
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
                'Debug.print(">>>>>>>>>" & Me.TabPage3.Controls("TableLayoutPanel1").Controls(maxPobj).Name)
                Me.TabPage3.Controls("TableLayoutPanel1").Controls(maxPobj.Replace("sig", "en")).Text = "Y"
                RunMLR()
                subopt = True
                GoTo exitSLoop
            End If

            'go back and go again.
            GoTo beginSLoop



        End If


exitSLoop:
        'check to see if this model has non-significant parameters
        If subopt = False Then
            Label37.Visible = False
        Else
            Label37.Visible = True
        End If

        statwait.Visible = False

    End Sub


    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim rtot As Double
        statwait.Visible = True
        statwait.Refresh()
        Application.DoEvents()

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
                If n < tsProgress.Maximum Then tsProgress.Value = n + 1

            Next

            calcScore(n) = rtot

        Next

        statwait.Visible = False

        updateStatistics()
    End Sub

    Private Sub updateStatistics(Optional imgval As Integer = -1)
        Dim sts As Integer
        Dim prv As Integer

        If imgval > -1 Then
            sts = imgval
        Else
            sts = cImageVal.Value
        End If

        If ListBox1.Items.Count = 0 Then
            For xx = 0 To 12
                ListBox1.Items.Add("-")
            Next xx
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
        ListBox1.Items.Item(9) = "SID: " & statQID(sts)
        ListBox1.Items.Item(10) = "SumSquared: " & statSumSquared(sts)
        ListBox1.Items.Item(11) = "Manual score: " & imgScore(sts)
        ListBox1.Items.Item(12) = "Calculated score: " & calcScore(sts)

        ListBox1.TopIndex = prv

    End Sub

    Private Sub Form1_MouseWheel(sender As Object, e As MouseEventArgs) Handles MyBase.MouseWheel

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
        If sender.checked = True Then
            imgIncluded(cImageVal.Value) = True
            incCheck.BackColor = Color.Green
        Else
            imgIncluded(cImageVal.Value) = False
            incCheck.BackColor = Color.PaleVioletRed
        End If

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        exclabel.Text = (sender.value / 10)
        Label30.Text = CalculateWindow(sender.value / 10)
        If imgCount = 0 Then Exit Sub
        For n = 0 To imgCount - 1
            If calcScore(n) >= CDbl(exclabel.Text) Then imgIncluded(n) = True Else imgIncluded(n) = False
            If Not imgScore(n) = -1 And imgScore(n) > CDbl(exclabel.Text) Then imgIncluded(n) = True
        Next
        longtermstatus.Text = imgIncluded.Count(Function(x) x = True) & " images remain in set (" & imgIncluded.Count(Function(x) x = False) & " excluded)"

    End Sub

    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged

    End Sub

    Private Sub TrackBar1_MouseUp(sender As Object, e As MouseEventArgs) Handles TrackBar1.MouseUp
        exclabel.Text = (sender.value / 10)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim opf As StreamWriter
        sfd.AddExtension = True
        sfd.DefaultExt = ".txt"
        sfd.Filter = "Text files|*.txt"
        sfd.ShowDialog()

        If sfd.FileName = "" Then MsgBox("Save cancelled.") : Exit Sub

        If IO.File.Exists(sfd.FileName) Then IO.File.Delete(sfd.FileName)

        opf = My.Computer.FileSystem.OpenTextFileWriter(sfd.FileName, False)

        opf.WriteLine(InputBox("Enter a name for this data set"))
        opf.WriteLine(imgCount)
        For n = 0 To imgCount - 1
            opf.WriteLine(imagepath(n))
            opf.WriteLine(statDeviation(n))
            opf.WriteLine(statEntropy(n))
            opf.WriteLine(statIntDensity(n))
            opf.WriteLine(statKurtosis(n))
            opf.WriteLine(statMaximum(n))
            opf.WriteLine(statMean(n))
            opf.WriteLine(statPixelRamp(n))
            opf.WriteLine(statQID(n))
            opf.WriteLine(statSkewness(n))
            opf.WriteLine(statSumSquared(n))
            opf.WriteLine(statUniqueColour(n))
            opf.WriteLine(imgScore(n))
        Next
        opf.Close()
        MsgBox("File saved.")

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        fbd1.ShowDialog()

        For n = 0 To imgCount - 1
            'only export the frame if it's not excluded

            If skipcheck.Checked = True And imgIncluded(n) = True Then imagef(n).Write(fbd1.SelectedPath & "\frame" & Format(n, "00000000") & "." & outputformat.Text)
            If skipcheck.Checked = False Then imagef(n).Write(fbd1.SelectedPath & "\frame" & Format(n, "00000000") & "." & outputformat.Text)

            toolstripobj.Text = "Saving image " & n
            tsProgress.Value = n

        Next

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim imgcol As MagickImageCollection
        Dim imgHold As MagickImage
        Dim n As Integer

        ofd.ShowDialog()
        imgHold = New MagickImage(ofd.FileName)
        imgcol = New MagickImageCollection(ofd.FileName)

        MsgBox("The video has " & imgcol.Count & " frames. Choose an output folder. Frames will be written as TIFF")
        fbd.ShowDialog()

        For n = 0 To imgcol.Count - 1

            imgcol(n).Write(fbd.SelectedPath & "\frame" & Format(n, "000000000") & ".tiff")

        Next

        MsgBox("Video frames successfully converted to images.")

    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Public Function CalculateWindow(cutoff As Double)
        Dim framefailed As Boolean
        Dim frame_end As Integer
        Dim minframewidth As Integer

        fwidth.Items.Clear()
        fwidth.Items.Add("Best")

        For n = 1 To Int(imgCount / 2)
            fwidth.Items.Add(CStr(n))
        Next

        For currentstep = 1 To Int(imgCount / 4)
            framefailed = True

            For frame_start = 0 To imgCount - 1 Step currentstep

                frame_end = frame_start + (currentstep - 1)
                If frame_end > imgCount - 1 Then Exit For
                framefailed = True

                For n = frame_start To frame_end
                    If calcScore(n) > cutoff Then framefailed = False
                Next

                If framefailed = True Then
                    'you might as well leave the whole routine because it's failed.

                    Exit For

                End If




            Next frame_start

            If minframewidth = 0 And framefailed = False Then minframewidth = currentstep

        Next currentstep

        CalculateWindow = minframewidth

    End Function

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim gdc As Integer
        Dim bdc As Integer
        Dim fmw As Integer
        Dim frame_end As Integer
        Dim fhv As Integer
        Dim fhv_num As Integer
        Dim framefailed As Boolean
        Dim nows As Integer

        If fwidth.SelectedItem = "Best" Then
            fmw = Label30.Text
        Else
            fmw = CDbl(fwidth.SelectedItem)
        End If

        For n = 0 To imgCount - 1
            If imgIncluded(n) = True Then gdc = gdc + 1
            If imgIncluded(n) = False Then bdc = bdc + 1
        Next

        longtermstatus.Text = "Pre-windowing: " & gdc & " included, " & bdc & " excluded"

        For frame_start = 0 To imgCount Step CDbl(fmw)

            frame_end = frame_start + (fmw - 1)
            If frame_end > imgCount Then
                frame_end = imgCount - 1
            End If
            If frame_start > frame_end Then
                '?
                Exit For
            End If

            framefailed = True
            fhv = 0
            fhv_num = -1
            If frame_end > imgCount - 1 Then frame_end = imgCount - 1
            For n = frame_start To frame_end
                'if the frame is included then then see if it is higher than all the others.
                If calcScore(n) > fhv Then fhv = calcScore(n) : fhv_num = n

                imgIncluded(n) = False
            Next
            If fhv_num > -1 Then
                imgIncluded(fhv_num) = True
                nows = nows + 1
            End If



        Next frame_start
        gdc = 0
        bdc = 0
        For n = 0 To imgCount - 1
            If imgIncluded(n) = True Then gdc = gdc + 1
            If imgIncluded(n) = False Then bdc = bdc + 1
        Next

        longtermstatus.Text = "Post-windowing: " & gdc & " included, " & bdc & " excluded"


    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim opfl As IO.StreamReader
        Dim setname As String
        Dim cfn As Integer

        swlimit.Items.Clear()
        swlimit.Items.Add("No limit")




        ofd.AddExtension = True
        ofd.DefaultExt = "*.txt"
        ofd.Filter = "Text files|*.txt"
        ofd.ShowDialog()

        If ofd.FileName = "" Then MsgBox("Load cancelled.") : Exit Sub

        opfl = My.Computer.FileSystem.OpenTextFileReader(ofd.FileName)

        setname = opfl.ReadLine
        imgCount = CDbl(opfl.ReadLine)

        For n = 1 To imgCount - 1
            swlimit.Items.Add(n)
        Next

        ReDim imagef(imgCount - 1)
        ReDim imagefinfo(imgCount - 1)
        GC.SuppressFinalize(imagef)

        ReDim statUniqueColour(imgCount - 1)
        ReDim statEntropy(imgCount - 1)
        ReDim statKurtosis(imgCount - 1)
        ReDim statMaximum(imgCount - 1)
        ReDim statMean(imgCount - 1)
        ReDim statSkewness(imgCount - 1)
        ReDim statDeviation(imgCount - 1)
        ReDim statIntDensity(imgCount - 1)
        ReDim statPixelRamp(imgCount - 1)
        ReDim statQID(imgCount - 1)
        ReDim imagepath(imgCount - 1)
        ReDim statSumSquared(imgCount - 1)
        ReDim imgScore(imgCount - 1)
        ReDim calcScore(imgCount - 1)
        ReDim imgIncluded(imgCount - 1)

        Do While opfl.EndOfStream = False

            imagepath(cfn) = opfl.ReadLine
            statDeviation(cfn) = CDbl(opfl.ReadLine)
            statEntropy(cfn) = CDbl(opfl.ReadLine)
            statIntDensity(cfn) = CDbl(opfl.ReadLine)
            statKurtosis(cfn) = CDbl(opfl.ReadLine)
            statMaximum(cfn) = CDbl(opfl.ReadLine)
            statMean(cfn) = CDbl(opfl.ReadLine)
            statPixelRamp(cfn) = CDbl(opfl.ReadLine)
            statQID(cfn) = CDbl(opfl.ReadLine)
            statSkewness(cfn) = CDbl(opfl.ReadLine)
            statSumSquared(cfn) = CDbl(opfl.ReadLine)
            statUniqueColour(cfn) = CDbl(opfl.ReadLine)
            imgScore(cfn) = CDbl(opfl.ReadLine)
            cfn = cfn + 1
        Loop
        opfl.Close()

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim pbrd As String

        For n = 0 To imgCount - 1

            pbrd = pbrd & imgScore(n) & vbCrLf

        Next

        Clipboard.SetText(pbrd)

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim pbrd As String

        For n = 0 To imgCount - 1

            pbrd = pbrd & calcScore(n) & vbCrLf

        Next

        Clipboard.SetText(pbrd)

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim opfl As IO.StreamReader
        Dim setname As String
        Dim cfn As Integer
        Dim ofdres As DialogResult

        ofd.AddExtension = True
        ofd.DefaultExt = "*.txt"
        ofd.Filter = "Text files|*.txt"
        ofdres = ofd.ShowDialog()

        If ofdres = Windows.Forms.DialogResult.Cancel Then MsgBox("Load cancelled.") : Exit Sub

        opfl = My.Computer.FileSystem.OpenTextFileReader(ofd.FileName)

        Do While opfl.EndOfStream = False

            imgScore(cfn) = CDbl(opfl.ReadLine)
            cfn = cfn + 1

        Loop
        opfl.Close()

        swlimit.Items.Clear()
        swlimit.Items.Add("No limit")

        For n = 1 To imgCount - 1
            swlimit.Items.Add(n)
        Next

        swlimit.SelectedIndex = 0


    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim tStart As Single
        Dim tEnd As Single

        'activate excel
        Call Button21_Click(sender, e)
        Application.DoEvents()
        System.Threading.Thread.Sleep(10000)


startagain:
        enDeviation.Text = "Y"
        enEntropy.Text = "Y"
        enIntDen.Text = "Y"
        enKurtosis.Text = "Y"
        enMaximum.Text = "Y"
        enMean.Text = "Y"
        enPixelRamp.Text = "Y"
        enQID.Text = "Y"
        enSkewness.Text = "Y"
        enSumSquared.Text = "Y"
        enUniqueColours.Text = "Y"
        Application.DoEvents()



        Call Button11_Click(sender, e)
        Application.DoEvents()

        Call Button20_Click(sender, e)
        Application.DoEvents()

        Call Button12_Click(sender, e)
        Application.DoEvents()

        Dim pbrd As String

        For n = 0 To imgCount - 1

            pbrd = pbrd & calcScore(n) & vbCrLf

        Next

        Clipboard.SetText(pbrd)


        swlimit.SelectedIndex += 2



        If swlimit.Text <> "64" Then
            toolstripobj.Text = "waiting 4 seconds, have pasted " & (swlimit.SelectedIndex - 2)



            tStart = Microsoft.VisualBasic.Timer()
            tEnd = 1 + Microsoft.VisualBasic.Timer()
            Clipboard.SetText(pbrd)
            Do While tEnd > tStart
                Application.DoEvents()
                tStart = Microsoft.VisualBasic.Timer()
            Loop
            Clipboard.SetText(pbrd)
            toolstripobj.Text = "working"

            pbrd = ""

            System.Windows.Forms.SendKeys.Send("{RIGHT}")
            System.Windows.Forms.SendKeys.Send("^v")
            System.Windows.Forms.SendKeys.Send("^v")
            System.Windows.Forms.SendKeys.Send("^v")

            GoTo startagain

        End If

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim stp As String
        Dim delim As String
        delim = vbTab
        For n = 0 To Val(expfulldata.SelectedItem) - 1

            stp = stp & statDeviation(n) & delim
            stp = stp & statEntropy(n) & delim
            stp = stp & statIntDensity(n) & delim
            stp = stp & statKurtosis(n) & delim
            stp = stp & statMaximum(n) & delim
            stp = stp & statMean(n) & delim
            stp = stp & statQID(n) & delim
            stp = stp & statSkewness(n) & delim
            stp = stp & statSumSquared(n) & delim
            stp = stp & statUniqueColour(n) & delim
            stp = stp & statPixelRamp(n) & delim
            stp = stp & imgScore(n) & delim
            stp = stp & calcScore(n)
            stp = stp & vbCrLf

        Next

        Clipboard.SetText(stp)
        MsgBox("Copied to clipboard")
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim opfl As IO.StreamReader
        Dim strL As String
        Dim vrs() As String
        Dim cvr As Integer
        Dim delim As String
        Dim maxdimensionbound As Integer
        delim = vbTab

        ofd.AddExtension = True
        ofd.DefaultExt = "*.txt"
        ofd.Filter = "CSV Data files|*.txt"
        ofd.ShowDialog()

        If ofd.FileName = "" Then MsgBox("Load cancelled.") : Exit Sub

        MsgBox("This will overwrite the statistics of the current image set and is only for the purposes of analysis. The current image set will no longer be valid and will need to be reloaded.")

        opfl = My.Computer.FileSystem.OpenTextFileReader(ofd.FileName)
        'reset the image count to zero
        imgCount = 0
        'as the stream object loads the data into variables as it goes along, and doesn't know the file size in advance, we can be inefficient in setting
        'the dimension for the stats arrays. You can drop the value if required, but it shouldn't be too pressing to leave it at 500.
        maxdimensionbound = 500

        ReDim statUniqueColour(maxdimensionbound)
        ReDim statEntropy(maxdimensionbound)
        ReDim statKurtosis(maxdimensionbound)
        ReDim statMaximum(maxdimensionbound)
        ReDim statMean(maxdimensionbound)
        ReDim statSkewness(maxdimensionbound)
        ReDim statDeviation(maxdimensionbound)
        ReDim statIntDensity(maxdimensionbound)
        ReDim statPixelRamp(maxdimensionbound)
        ReDim statQID(maxdimensionbound)
        ReDim imagepath(maxdimensionbound)
        ReDim statSumSquared(maxdimensionbound)
        ReDim imgScore(maxdimensionbound)
        ReDim calcScore(maxdimensionbound)
        ReDim imgIncluded(maxdimensionbound)

        Do While opfl.EndOfStream = False

            strL = opfl.ReadLine

            If InStr(strL, delim) > 0 Then

                vrs = Split(strL, delim)

                statDeviation(cvr) = vrs(0)
                statEntropy(cvr) = vrs(1)
                statIntDensity(cvr) = vrs(2)
                statKurtosis(cvr) = vrs(3)
                statMaximum(cvr) = vrs(4)
                statMean(cvr) = vrs(5)
                statQID(cvr) = vrs(6)
                statSkewness(cvr) = vrs(7)
                statSumSquared(cvr) = vrs(8)
                statUniqueColour(cvr) = vrs(9)
                statPixelRamp(cvr) = vrs(10)
                imgScore(cvr) = vrs(11)

                cvr = cvr + 1

            End If


        Loop
        opfl.Close()
        imgCount = cvr
        toolstripobj.Text = "Loaded in " & cvr & " image data frames to memory"
        swlimit.Items.Clear()
        swlimit.Items.Add("No limit")

        For n = 1 To maxdimensionbound
            swlimit.Items.Add(n)
        Next

        swlimit.SelectedIndex = 0

    End Sub

    Private Sub swlimit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles swlimit.SelectedIndexChanged

    End Sub

    Private Sub pxstepDropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pxstepDropdown.SelectedIndexChanged

        statpxStep = pxstepDropdown.SelectedIndex + 1
        toolstripobj.Text = "Set statistics pixel step to " & statpxStep
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Dim vidwriter As New Accord.Video.FFMPEG.VideoFileWriter


        Dim n As Integer
        Dim bmpholder As Bitmap

        sfd1.ShowDialog()
        If sfd1.FileName = "" Then Exit Sub
        If Strings.Right(sfd1.FileName.ToUpper, 3) <> "AVI" Then
            sfd1.FileName = sfd1.FileName & ".avi"
        End If

        'sfd1.FileName, imagef(0).Width, imagef(0).Height, 10, Accord.Video.FFMPEG.VideoCodec.Raw
        vidwriter.Open(sfd1.FileName, imagef(0).Width, imagef(0).Width, 10, Accord.Video.FFMPEG.VideoCodec.Raw)


        For n = 0 To imgCount - 1

            If imgIncluded(n) = True Then
                bmpholder = imagef(n).ToBitmap
                vidwriter.WriteVideoFrame(bmpholder)
            End If

        Next

        vidwriter.Close()
        vidwriter.Dispose()
        MsgBox("Finished writing video.")
    End Sub

    Private Sub Button28_Click_1(sender As Object, e As EventArgs) Handles Button28.Click
        Form2.ShowDialog()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim minval As Double
        Dim maxval As Double
        Dim dval As Double

        'find the lowest calc value
        minval = calcScore.Min
        'adjust the calcscores based on this.
        For n = 0 To imgCount - 1

            If minval < 0 Then
                calcScore(n) = calcScore(n) + Math.Abs(minval)
            End If

            If minval > 0 Then
                calcScore(n) = calcScore(n) - minval
            End If

        Next

        'get max value
        maxval = calcScore.Max
        dval = (maxval / 5)

        For n = 0 To imgCount - 1

            calcScore(n) = calcScore(n) / dval

        Next
        MsgBox("Calculated score ranging completed.")

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Clipboard.SetText(Replace(ListBox1.SelectedItem.ToString, ":", vbTab))
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick

        On Error GoTo leaveroutine
        Dim fPixel As IPixelCollection
        Dim pxV As Double
        fPixel = imagef(cImageVal.Value).GetPixels
        pxV = fPixel.GetValue(e.X, e.Y).GetValue(0)
        PixelIntLabel.Text = pxV.ToString


        Exit Sub

leaveroutine:
    End Sub

    Private Sub TabPage6_Click(sender As Object, e As EventArgs) Handles TabPage6.Click

    End Sub

    Private Sub qidCount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles qidCount.SelectedIndexChanged

    End Sub

    Private Sub Label37_Click(sender As Object, e As EventArgs) Handles Label37.Click
        MsgBox("This model did not finish with p-values below 0.05 for all parameters in the model. You should consider carefully whether to use this model for the calculation of quality scores.", MsgBoxStyle.Exclamation, "Warning")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class