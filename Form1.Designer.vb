<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolstripobj = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.displaytimer = New System.Windows.Forms.Timer(Me.components)
        Me.frameinterval = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cImageVal = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pleasewaitpanel = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.exclabel = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.incCheck = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.filecountlabel = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.scoref0 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.filepath = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lutlist = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.noiseradius = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.despeckle = New System.Windows.Forms.CheckBox()
        Me.denoise = New System.Windows.Forms.CheckBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.threshMax = New System.Windows.Forms.NumericUpDown()
        Me.threshMin = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.upperthreshslider = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lowthreshslider = New System.Windows.Forms.TrackBar()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.coeffUniqueColours = New System.Windows.Forms.Label()
        Me.coeffEntropy = New System.Windows.Forms.Label()
        Me.coeffKurtosis = New System.Windows.Forms.Label()
        Me.coeffMaximum = New System.Windows.Forms.Label()
        Me.coeffMean = New System.Windows.Forms.Label()
        Me.coeffSkewness = New System.Windows.Forms.Label()
        Me.coeffDeviation = New System.Windows.Forms.Label()
        Me.coeffIntDen = New System.Windows.Forms.Label()
        Me.coeffPixelRamp = New System.Windows.Forms.Label()
        Me.coeffQID = New System.Windows.Forms.Label()
        Me.coeffSumSquared = New System.Windows.Forms.Label()
        Me.sigUniqueColours = New System.Windows.Forms.Label()
        Me.sigEntropy = New System.Windows.Forms.Label()
        Me.sigKurtosis = New System.Windows.Forms.Label()
        Me.sigMaximum = New System.Windows.Forms.Label()
        Me.sigMean = New System.Windows.Forms.Label()
        Me.sigSkewness = New System.Windows.Forms.Label()
        Me.sigDeviation = New System.Windows.Forms.Label()
        Me.sigIntDen = New System.Windows.Forms.Label()
        Me.sigPixelRamp = New System.Windows.Forms.Label()
        Me.sigQID = New System.Windows.Forms.Label()
        Me.sigSumSquared = New System.Windows.Forms.Label()
        Me.enUniqueColours = New System.Windows.Forms.Label()
        Me.enEntropy = New System.Windows.Forms.Label()
        Me.enKurtosis = New System.Windows.Forms.Label()
        Me.enMaximum = New System.Windows.Forms.Label()
        Me.enMean = New System.Windows.Forms.Label()
        Me.enSkewness = New System.Windows.Forms.Label()
        Me.enDeviation = New System.Windows.Forms.Label()
        Me.enIntDen = New System.Windows.Forms.Label()
        Me.enPixelRamp = New System.Windows.Forms.Label()
        Me.enQID = New System.Windows.Forms.Label()
        Me.enSumSquared = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.coeffConstant = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.statwait = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button15 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.cImageVal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pleasewaitpanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.threshMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.threshMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.upperthreshslider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lowthreshslider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.statwait.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(704, 681)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripobj, Me.tsProgress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 752)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1039, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'toolstripobj
        '
        Me.toolstripobj.AutoSize = False
        Me.toolstripobj.Name = "toolstripobj"
        Me.toolstripobj.Size = New System.Drawing.Size(250, 17)
        Me.toolstripobj.Text = "Status"
        Me.toolstripobj.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tsProgress
        '
        Me.tsProgress.Name = "tsProgress"
        Me.tsProgress.Size = New System.Drawing.Size(100, 16)
        '
        'displaytimer
        '
        Me.displaytimer.Interval = 25
        '
        'frameinterval
        '
        Me.frameinterval.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frameinterval.Location = New System.Drawing.Point(12, 255)
        Me.frameinterval.Name = "frameinterval"
        Me.frameinterval.Size = New System.Drawing.Size(44, 23)
        Me.frameinterval.TabIndex = 11
        Me.frameinterval.Text = "25"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Frame interval (ms)"
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(62, 255)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(39, 25)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Play"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cImageVal
        '
        Me.cImageVal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cImageVal.Location = New System.Drawing.Point(124, 255)
        Me.cImageVal.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.cImageVal.Name = "cImageVal"
        Me.cImageVal.Size = New System.Drawing.Size(46, 23)
        Me.cImageVal.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(121, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Current image"
        '
        'pleasewaitpanel
        '
        Me.pleasewaitpanel.BackColor = System.Drawing.Color.Navy
        Me.pleasewaitpanel.Controls.Add(Me.Label6)
        Me.pleasewaitpanel.Location = New System.Drawing.Point(12, 332)
        Me.pleasewaitpanel.Name = "pleasewaitpanel"
        Me.pleasewaitpanel.Size = New System.Drawing.Size(704, 88)
        Me.pleasewaitpanel.TabIndex = 5
        Me.pleasewaitpanel.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(216, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(261, 65)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Please wait"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(724, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(303, 646)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.exclabel)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.TrackBar1)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.incCheck)
        Me.TabPage1.Controls.Add(Me.frameinterval)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.cImageVal)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.filecountlabel)
        Me.TabPage1.Controls.Add(Me.CheckBox2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.scoref0)
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.filepath)
        Me.TabPage1.Controls.Add(Me.Button8)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(Me.Button7)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(295, 620)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "File/play control"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'exclabel
        '
        Me.exclabel.AutoSize = True
        Me.exclabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exclabel.Location = New System.Drawing.Point(247, 333)
        Me.exclabel.Name = "exclabel"
        Me.exclabel.Size = New System.Drawing.Size(17, 20)
        Me.exclabel.TabIndex = 24
        Me.exclabel.Text = "0"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(9, 333)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(153, 15)
        Me.Label25.TabIndex = 23
        Me.Label25.Text = "Do not show images below:"
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TrackBar1.LargeChange = 10
        Me.TrackBar1.Location = New System.Drawing.Point(12, 360)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Minimum = -100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(252, 45)
        Me.TrackBar1.SmallChange = 5
        Me.TrackBar1.TabIndex = 22
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(9, 309)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(95, 15)
        Me.Label24.TabIndex = 21
        Me.Label24.Text = "Exclusion criteria"
        '
        'incCheck
        '
        Me.incCheck.Appearance = System.Windows.Forms.Appearance.Button
        Me.incCheck.BackColor = System.Drawing.Color.Silver
        Me.incCheck.Location = New System.Drawing.Point(12, 164)
        Me.incCheck.Name = "incCheck"
        Me.incCheck.Size = New System.Drawing.Size(252, 24)
        Me.incCheck.TabIndex = 20
        Me.incCheck.Text = "Included"
        Me.incCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.incCheck.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(207, 59)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 24)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Import.."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Frame score"
        '
        'filecountlabel
        '
        Me.filecountlabel.AutoSize = True
        Me.filecountlabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filecountlabel.Location = New System.Drawing.Point(9, 64)
        Me.filecountlabel.Name = "filecountlabel"
        Me.filecountlabel.Size = New System.Drawing.Size(75, 15)
        Me.filecountlabel.TabIndex = 8
        Me.filecountlabel.Text = "Found X files"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(12, 200)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(116, 19)
        Me.CheckBox2.TabIndex = 19
        Me.CheckBox2.Text = "Advance on click"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(113, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 24)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'scoref0
        '
        Me.scoref0.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoref0.Location = New System.Drawing.Point(12, 126)
        Me.scoref0.Name = "scoref0"
        Me.scoref0.Size = New System.Drawing.Size(37, 32)
        Me.scoref0.TabIndex = 13
        Me.scoref0.Tag = "0"
        Me.scoref0.Text = "0"
        Me.scoref0.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(227, 126)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(37, 32)
        Me.Button9.TabIndex = 18
        Me.Button9.Tag = "0"
        Me.Button9.Text = "5"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(55, 126)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(37, 32)
        Me.Button5.TabIndex = 14
        Me.Button5.Tag = "0"
        Me.Button5.Text = "1"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'filepath
        '
        Me.filepath.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filepath.Location = New System.Drawing.Point(9, 28)
        Me.filepath.Name = "filepath"
        Me.filepath.Size = New System.Drawing.Size(275, 23)
        Me.filepath.TabIndex = 6
        Me.filepath.Text = "C:\Users\kavan\Desktop\832x624\8BIT\GRAY\img_832x624_1x8bit_bars_45deg_bltr_0128." &
    "png"
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(184, 126)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(37, 32)
        Me.Button8.TabIndex = 17
        Me.Button8.Tag = "0"
        Me.Button8.Text = "4"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "File path"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(98, 126)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(37, 32)
        Me.Button6.TabIndex = 15
        Me.Button6.Tag = "0"
        Me.Button6.Text = "2"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(141, 126)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(37, 32)
        Me.Button7.TabIndex = 16
        Me.Button7.Tag = "0"
        Me.Button7.Text = "3"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lutlist)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.noiseradius)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.despeckle)
        Me.TabPage2.Controls.Add(Me.denoise)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.threshMax)
        Me.TabPage2.Controls.Add(Me.threshMin)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.upperthreshslider)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.lowthreshslider)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(295, 620)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Image manipulation"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lutlist
        '
        Me.lutlist.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lutlist.FormattingEnabled = True
        Me.lutlist.Location = New System.Drawing.Point(13, 224)
        Me.lutlist.Name = "lutlist"
        Me.lutlist.Size = New System.Drawing.Size(268, 21)
        Me.lutlist.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Apply lookup table"
        '
        'noiseradius
        '
        Me.noiseradius.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noiseradius.Location = New System.Drawing.Point(229, 170)
        Me.noiseradius.Name = "noiseradius"
        Me.noiseradius.Size = New System.Drawing.Size(42, 22)
        Me.noiseradius.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(183, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Radius"
        '
        'despeckle
        '
        Me.despeckle.AutoSize = True
        Me.despeckle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.despeckle.Location = New System.Drawing.Point(94, 172)
        Me.despeckle.Name = "despeckle"
        Me.despeckle.Size = New System.Drawing.Size(78, 17)
        Me.despeckle.TabIndex = 24
        Me.despeckle.Text = "Despeckle"
        Me.despeckle.UseVisualStyleBackColor = True
        '
        'denoise
        '
        Me.denoise.AutoSize = True
        Me.denoise.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.denoise.Location = New System.Drawing.Point(17, 172)
        Me.denoise.Name = "denoise"
        Me.denoise.Size = New System.Drawing.Size(68, 17)
        Me.denoise.TabIndex = 23
        Me.denoise.Text = "Denoise"
        Me.denoise.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(193, 257)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 25)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Update all"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(94, 257)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 25)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Update one"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'threshMax
        '
        Me.threshMax.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.threshMax.Location = New System.Drawing.Point(229, 93)
        Me.threshMax.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.threshMax.Name = "threshMax"
        Me.threshMax.Size = New System.Drawing.Size(58, 22)
        Me.threshMax.TabIndex = 20
        Me.threshMax.Value = New Decimal(New Integer() {65535, 0, 0, 0})
        '
        'threshMin
        '
        Me.threshMin.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.threshMin.Location = New System.Drawing.Point(229, 12)
        Me.threshMin.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.threshMin.Name = "threshMin"
        Me.threshMin.Size = New System.Drawing.Size(58, 22)
        Me.threshMin.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Threshold upper"
        '
        'upperthreshslider
        '
        Me.upperthreshslider.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.upperthreshslider.LargeChange = 25
        Me.upperthreshslider.Location = New System.Drawing.Point(9, 123)
        Me.upperthreshslider.Maximum = 65535
        Me.upperthreshslider.Name = "upperthreshslider"
        Me.upperthreshslider.Size = New System.Drawing.Size(278, 45)
        Me.upperthreshslider.SmallChange = 2
        Me.upperthreshslider.TabIndex = 17
        Me.upperthreshslider.Value = 65535
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Threshold lower"
        '
        'lowthreshslider
        '
        Me.lowthreshslider.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lowthreshslider.LargeChange = 10
        Me.lowthreshslider.Location = New System.Drawing.Point(9, 35)
        Me.lowthreshslider.Maximum = 65535
        Me.lowthreshslider.Name = "lowthreshslider"
        Me.lowthreshslider.Size = New System.Drawing.Size(278, 45)
        Me.lowthreshslider.SmallChange = 5
        Me.lowthreshslider.TabIndex = 15
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button14)
        Me.TabPage3.Controls.Add(Me.Button13)
        Me.TabPage3.Controls.Add(Me.Button12)
        Me.TabPage3.Controls.Add(Me.Button11)
        Me.TabPage3.Controls.Add(Me.Label33)
        Me.TabPage3.Controls.Add(Me.Button10)
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.ListBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(295, 620)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Statistics"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(155, 583)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(125, 23)
        Me.Button14.TabIndex = 27
        Me.Button14.Text = "Load Coefficients"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(13, 583)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(125, 23)
        Me.Button13.TabIndex = 26
        Me.Button13.Text = "Save Coefficients"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(198, 551)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(82, 23)
        Me.Button12.TabIndex = 25
        Me.Button12.Text = "Apply"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(106, 551)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(82, 23)
        Me.Button11.TabIndex = 24
        Me.Button11.Text = "Do SWMLR"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(16, 524)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(76, 15)
        Me.Label33.TabIndex = 23
        Me.Label33.Text = "Adjusted R2: "
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(13, 551)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(82, 23)
        Me.Button10.TabIndex = 22
        Me.Button10.Text = "Do MLR"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.33708!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.59176!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.58427!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label19, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label21, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label22, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.coeffUniqueColours, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.coeffEntropy, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.coeffKurtosis, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.coeffMaximum, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.coeffMean, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.coeffSkewness, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.coeffDeviation, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.coeffIntDen, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.coeffPixelRamp, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.coeffQID, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.coeffSumSquared, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.sigUniqueColours, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.sigEntropy, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.sigKurtosis, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.sigMaximum, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.sigMean, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.sigSkewness, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.sigDeviation, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.sigIntDen, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.sigPixelRamp, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.sigQID, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.sigSumSquared, 2, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.enUniqueColours, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.enEntropy, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.enKurtosis, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.enMaximum, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.enMean, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.enSkewness, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.enDeviation, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.enIntDen, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.enPixelRamp, 3, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.enQID, 3, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.enSumSquared, 3, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Label34, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.coeffConstant, 1, 11)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 269)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 12
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(267, 243)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Unique Col."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 15)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Entropy"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Kurtosis"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 15)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Maximum"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 15)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Mean"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 100)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 15)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Skewness"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 15)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Deviation"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 140)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 15)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Int Density"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 160)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 15)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Pixel Ramp"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 180)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(27, 15)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "QID"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(3, 200)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 20)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Sum Squared"
        '
        'coeffUniqueColours
        '
        Me.coeffUniqueColours.AutoSize = True
        Me.coeffUniqueColours.Location = New System.Drawing.Point(84, 0)
        Me.coeffUniqueColours.Name = "coeffUniqueColours"
        Me.coeffUniqueColours.Size = New System.Drawing.Size(12, 15)
        Me.coeffUniqueColours.TabIndex = 11
        Me.coeffUniqueColours.Text = "-"
        '
        'coeffEntropy
        '
        Me.coeffEntropy.AutoSize = True
        Me.coeffEntropy.Location = New System.Drawing.Point(84, 20)
        Me.coeffEntropy.Name = "coeffEntropy"
        Me.coeffEntropy.Size = New System.Drawing.Size(12, 15)
        Me.coeffEntropy.TabIndex = 12
        Me.coeffEntropy.Text = "-"
        '
        'coeffKurtosis
        '
        Me.coeffKurtosis.AutoSize = True
        Me.coeffKurtosis.Location = New System.Drawing.Point(84, 40)
        Me.coeffKurtosis.Name = "coeffKurtosis"
        Me.coeffKurtosis.Size = New System.Drawing.Size(12, 15)
        Me.coeffKurtosis.TabIndex = 13
        Me.coeffKurtosis.Text = "-"
        '
        'coeffMaximum
        '
        Me.coeffMaximum.AutoSize = True
        Me.coeffMaximum.Location = New System.Drawing.Point(84, 60)
        Me.coeffMaximum.Name = "coeffMaximum"
        Me.coeffMaximum.Size = New System.Drawing.Size(12, 15)
        Me.coeffMaximum.TabIndex = 14
        Me.coeffMaximum.Text = "-"
        '
        'coeffMean
        '
        Me.coeffMean.AutoSize = True
        Me.coeffMean.Location = New System.Drawing.Point(84, 80)
        Me.coeffMean.Name = "coeffMean"
        Me.coeffMean.Size = New System.Drawing.Size(12, 15)
        Me.coeffMean.TabIndex = 15
        Me.coeffMean.Text = "-"
        '
        'coeffSkewness
        '
        Me.coeffSkewness.AutoSize = True
        Me.coeffSkewness.Location = New System.Drawing.Point(84, 100)
        Me.coeffSkewness.Name = "coeffSkewness"
        Me.coeffSkewness.Size = New System.Drawing.Size(12, 15)
        Me.coeffSkewness.TabIndex = 16
        Me.coeffSkewness.Text = "-"
        '
        'coeffDeviation
        '
        Me.coeffDeviation.AutoSize = True
        Me.coeffDeviation.Location = New System.Drawing.Point(84, 120)
        Me.coeffDeviation.Name = "coeffDeviation"
        Me.coeffDeviation.Size = New System.Drawing.Size(12, 15)
        Me.coeffDeviation.TabIndex = 17
        Me.coeffDeviation.Text = "-"
        '
        'coeffIntDen
        '
        Me.coeffIntDen.AutoSize = True
        Me.coeffIntDen.Location = New System.Drawing.Point(84, 140)
        Me.coeffIntDen.Name = "coeffIntDen"
        Me.coeffIntDen.Size = New System.Drawing.Size(12, 15)
        Me.coeffIntDen.TabIndex = 18
        Me.coeffIntDen.Text = "-"
        '
        'coeffPixelRamp
        '
        Me.coeffPixelRamp.AutoSize = True
        Me.coeffPixelRamp.Location = New System.Drawing.Point(84, 160)
        Me.coeffPixelRamp.Name = "coeffPixelRamp"
        Me.coeffPixelRamp.Size = New System.Drawing.Size(12, 15)
        Me.coeffPixelRamp.TabIndex = 19
        Me.coeffPixelRamp.Text = "-"
        '
        'coeffQID
        '
        Me.coeffQID.AutoSize = True
        Me.coeffQID.Location = New System.Drawing.Point(84, 180)
        Me.coeffQID.Name = "coeffQID"
        Me.coeffQID.Size = New System.Drawing.Size(12, 15)
        Me.coeffQID.TabIndex = 20
        Me.coeffQID.Text = "-"
        '
        'coeffSumSquared
        '
        Me.coeffSumSquared.AutoSize = True
        Me.coeffSumSquared.Location = New System.Drawing.Point(84, 200)
        Me.coeffSumSquared.Name = "coeffSumSquared"
        Me.coeffSumSquared.Size = New System.Drawing.Size(12, 15)
        Me.coeffSumSquared.TabIndex = 21
        Me.coeffSumSquared.Text = "-"
        '
        'sigUniqueColours
        '
        Me.sigUniqueColours.AutoSize = True
        Me.sigUniqueColours.Location = New System.Drawing.Point(155, 0)
        Me.sigUniqueColours.Name = "sigUniqueColours"
        Me.sigUniqueColours.Size = New System.Drawing.Size(12, 15)
        Me.sigUniqueColours.TabIndex = 22
        Me.sigUniqueColours.Text = "-"
        '
        'sigEntropy
        '
        Me.sigEntropy.AutoSize = True
        Me.sigEntropy.Location = New System.Drawing.Point(155, 20)
        Me.sigEntropy.Name = "sigEntropy"
        Me.sigEntropy.Size = New System.Drawing.Size(12, 15)
        Me.sigEntropy.TabIndex = 23
        Me.sigEntropy.Text = "-"
        '
        'sigKurtosis
        '
        Me.sigKurtosis.AutoSize = True
        Me.sigKurtosis.Location = New System.Drawing.Point(155, 40)
        Me.sigKurtosis.Name = "sigKurtosis"
        Me.sigKurtosis.Size = New System.Drawing.Size(12, 15)
        Me.sigKurtosis.TabIndex = 24
        Me.sigKurtosis.Text = "-"
        '
        'sigMaximum
        '
        Me.sigMaximum.AutoSize = True
        Me.sigMaximum.Location = New System.Drawing.Point(155, 60)
        Me.sigMaximum.Name = "sigMaximum"
        Me.sigMaximum.Size = New System.Drawing.Size(12, 15)
        Me.sigMaximum.TabIndex = 25
        Me.sigMaximum.Text = "-"
        '
        'sigMean
        '
        Me.sigMean.AutoSize = True
        Me.sigMean.Location = New System.Drawing.Point(155, 80)
        Me.sigMean.Name = "sigMean"
        Me.sigMean.Size = New System.Drawing.Size(12, 15)
        Me.sigMean.TabIndex = 26
        Me.sigMean.Text = "-"
        '
        'sigSkewness
        '
        Me.sigSkewness.AutoSize = True
        Me.sigSkewness.Location = New System.Drawing.Point(155, 100)
        Me.sigSkewness.Name = "sigSkewness"
        Me.sigSkewness.Size = New System.Drawing.Size(12, 15)
        Me.sigSkewness.TabIndex = 27
        Me.sigSkewness.Text = "-"
        '
        'sigDeviation
        '
        Me.sigDeviation.AutoSize = True
        Me.sigDeviation.Location = New System.Drawing.Point(155, 120)
        Me.sigDeviation.Name = "sigDeviation"
        Me.sigDeviation.Size = New System.Drawing.Size(12, 15)
        Me.sigDeviation.TabIndex = 28
        Me.sigDeviation.Text = "-"
        '
        'sigIntDen
        '
        Me.sigIntDen.AutoSize = True
        Me.sigIntDen.Location = New System.Drawing.Point(155, 140)
        Me.sigIntDen.Name = "sigIntDen"
        Me.sigIntDen.Size = New System.Drawing.Size(12, 15)
        Me.sigIntDen.TabIndex = 29
        Me.sigIntDen.Text = "-"
        '
        'sigPixelRamp
        '
        Me.sigPixelRamp.AutoSize = True
        Me.sigPixelRamp.Location = New System.Drawing.Point(155, 160)
        Me.sigPixelRamp.Name = "sigPixelRamp"
        Me.sigPixelRamp.Size = New System.Drawing.Size(12, 15)
        Me.sigPixelRamp.TabIndex = 30
        Me.sigPixelRamp.Text = "-"
        '
        'sigQID
        '
        Me.sigQID.AutoSize = True
        Me.sigQID.Location = New System.Drawing.Point(155, 180)
        Me.sigQID.Name = "sigQID"
        Me.sigQID.Size = New System.Drawing.Size(12, 15)
        Me.sigQID.TabIndex = 31
        Me.sigQID.Text = "-"
        '
        'sigSumSquared
        '
        Me.sigSumSquared.AutoSize = True
        Me.sigSumSquared.Location = New System.Drawing.Point(155, 200)
        Me.sigSumSquared.Name = "sigSumSquared"
        Me.sigSumSquared.Size = New System.Drawing.Size(12, 15)
        Me.sigSumSquared.TabIndex = 32
        Me.sigSumSquared.Text = "-"
        '
        'enUniqueColours
        '
        Me.enUniqueColours.AutoSize = True
        Me.enUniqueColours.Location = New System.Drawing.Point(242, 0)
        Me.enUniqueColours.Name = "enUniqueColours"
        Me.enUniqueColours.Size = New System.Drawing.Size(14, 15)
        Me.enUniqueColours.TabIndex = 33
        Me.enUniqueColours.Text = "Y"
        '
        'enEntropy
        '
        Me.enEntropy.AutoSize = True
        Me.enEntropy.Location = New System.Drawing.Point(242, 20)
        Me.enEntropy.Name = "enEntropy"
        Me.enEntropy.Size = New System.Drawing.Size(14, 15)
        Me.enEntropy.TabIndex = 34
        Me.enEntropy.Text = "Y"
        '
        'enKurtosis
        '
        Me.enKurtosis.AutoSize = True
        Me.enKurtosis.Location = New System.Drawing.Point(242, 40)
        Me.enKurtosis.Name = "enKurtosis"
        Me.enKurtosis.Size = New System.Drawing.Size(14, 15)
        Me.enKurtosis.TabIndex = 35
        Me.enKurtosis.Text = "Y"
        '
        'enMaximum
        '
        Me.enMaximum.AutoSize = True
        Me.enMaximum.Location = New System.Drawing.Point(242, 60)
        Me.enMaximum.Name = "enMaximum"
        Me.enMaximum.Size = New System.Drawing.Size(14, 15)
        Me.enMaximum.TabIndex = 36
        Me.enMaximum.Text = "Y"
        '
        'enMean
        '
        Me.enMean.AutoSize = True
        Me.enMean.Location = New System.Drawing.Point(242, 80)
        Me.enMean.Name = "enMean"
        Me.enMean.Size = New System.Drawing.Size(14, 15)
        Me.enMean.TabIndex = 37
        Me.enMean.Text = "Y"
        '
        'enSkewness
        '
        Me.enSkewness.AutoSize = True
        Me.enSkewness.Location = New System.Drawing.Point(242, 100)
        Me.enSkewness.Name = "enSkewness"
        Me.enSkewness.Size = New System.Drawing.Size(14, 15)
        Me.enSkewness.TabIndex = 38
        Me.enSkewness.Text = "Y"
        '
        'enDeviation
        '
        Me.enDeviation.AutoSize = True
        Me.enDeviation.Location = New System.Drawing.Point(242, 120)
        Me.enDeviation.Name = "enDeviation"
        Me.enDeviation.Size = New System.Drawing.Size(14, 15)
        Me.enDeviation.TabIndex = 39
        Me.enDeviation.Text = "Y"
        '
        'enIntDen
        '
        Me.enIntDen.AutoSize = True
        Me.enIntDen.Location = New System.Drawing.Point(242, 140)
        Me.enIntDen.Name = "enIntDen"
        Me.enIntDen.Size = New System.Drawing.Size(14, 15)
        Me.enIntDen.TabIndex = 40
        Me.enIntDen.Text = "Y"
        '
        'enPixelRamp
        '
        Me.enPixelRamp.AutoSize = True
        Me.enPixelRamp.Location = New System.Drawing.Point(242, 160)
        Me.enPixelRamp.Name = "enPixelRamp"
        Me.enPixelRamp.Size = New System.Drawing.Size(14, 15)
        Me.enPixelRamp.TabIndex = 41
        Me.enPixelRamp.Text = "Y"
        '
        'enQID
        '
        Me.enQID.AutoSize = True
        Me.enQID.Location = New System.Drawing.Point(242, 180)
        Me.enQID.Name = "enQID"
        Me.enQID.Size = New System.Drawing.Size(14, 15)
        Me.enQID.TabIndex = 42
        Me.enQID.Text = "Y"
        '
        'enSumSquared
        '
        Me.enSumSquared.AutoSize = True
        Me.enSumSquared.Location = New System.Drawing.Point(242, 200)
        Me.enSumSquared.Name = "enSumSquared"
        Me.enSumSquared.Size = New System.Drawing.Size(14, 15)
        Me.enSumSquared.TabIndex = 43
        Me.enSumSquared.Text = "Y"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(3, 220)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(55, 15)
        Me.Label34.TabIndex = 44
        Me.Label34.Text = "Constant"
        '
        'coeffConstant
        '
        Me.coeffConstant.AutoSize = True
        Me.coeffConstant.Location = New System.Drawing.Point(84, 220)
        Me.coeffConstant.Name = "coeffConstant"
        Me.coeffConstant.Size = New System.Drawing.Size(12, 15)
        Me.coeffConstant.TabIndex = 45
        Me.coeffConstant.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Multiple Linear Regression"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Current frame"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(91, 15)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(196, 184)
        Me.ListBox1.TabIndex = 10
        '
        'statwait
        '
        Me.statwait.BackColor = System.Drawing.Color.Navy
        Me.statwait.Controls.Add(Me.Label23)
        Me.statwait.Location = New System.Drawing.Point(455, 603)
        Me.statwait.Name = "statwait"
        Me.statwait.Size = New System.Drawing.Size(267, 48)
        Me.statwait.TabIndex = 25
        Me.statwait.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(64, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(149, 37)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Please wait"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button15)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(295, 620)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TifyDataAnalysis"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(6, 6)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(283, 25)
        Me.Button15.TabIndex = 0
        Me.Button15.Text = "Save all score data"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 774)
        Me.Controls.Add(Me.statwait)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.pleasewaitpanel)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.cImageVal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pleasewaitpanel.ResumeLayout(False)
        Me.pleasewaitpanel.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.threshMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.threshMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.upperthreshslider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lowthreshslider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.statwait.ResumeLayout(False)
        Me.statwait.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fbd As FolderBrowserDialog
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents toolstripobj As ToolStripStatusLabel
    Friend WithEvents tsProgress As ToolStripProgressBar
    Friend WithEvents displaytimer As Timer
    Friend WithEvents cImageVal As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents frameinterval As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents pleasewaitpanel As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents filecountlabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents filepath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents noiseradius As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents despeckle As CheckBox
    Friend WithEvents denoise As CheckBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents threshMax As NumericUpDown
    Friend WithEvents threshMin As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents upperthreshslider As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents lowthreshslider As TrackBar
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents scoref0 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lutlist As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents coeffUniqueColours As Label
    Friend WithEvents coeffEntropy As Label
    Friend WithEvents coeffKurtosis As Label
    Friend WithEvents coeffMaximum As Label
    Friend WithEvents coeffMean As Label
    Friend WithEvents coeffSkewness As Label
    Friend WithEvents coeffDeviation As Label
    Friend WithEvents coeffIntDen As Label
    Friend WithEvents coeffPixelRamp As Label
    Friend WithEvents coeffQID As Label
    Friend WithEvents coeffSumSquared As Label
    Friend WithEvents sigUniqueColours As Label
    Friend WithEvents sigEntropy As Label
    Friend WithEvents sigKurtosis As Label
    Friend WithEvents sigMaximum As Label
    Friend WithEvents sigMean As Label
    Friend WithEvents sigSkewness As Label
    Friend WithEvents sigDeviation As Label
    Friend WithEvents sigIntDen As Label
    Friend WithEvents sigPixelRamp As Label
    Friend WithEvents sigQID As Label
    Friend WithEvents sigSumSquared As Label
    Friend WithEvents enUniqueColours As Label
    Friend WithEvents enEntropy As Label
    Friend WithEvents enKurtosis As Label
    Friend WithEvents enMaximum As Label
    Friend WithEvents enMean As Label
    Friend WithEvents enSkewness As Label
    Friend WithEvents enDeviation As Label
    Friend WithEvents enIntDen As Label
    Friend WithEvents enPixelRamp As Label
    Friend WithEvents enQID As Label
    Friend WithEvents enSumSquared As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents coeffConstant As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents statwait As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents sfd As SaveFileDialog
    Friend WithEvents Button14 As Button
    Friend WithEvents incCheck As CheckBox
    Friend WithEvents exclabel As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label24 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Button15 As Button
End Class
