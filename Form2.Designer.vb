<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.pnlGridViews = New System.Windows.Forms.Panel
        Me.BtnShowTable = New System.Windows.Forms.Button
        Me.TxtLink = New System.Windows.Forms.TextBox
        Me.TxtTableName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Txttemp = New System.Windows.Forms.TextBox
        Me.BtnCreateCoTable = New System.Windows.Forms.Button
        Me.btnSyncAll = New System.Windows.Forms.Button
        Me.txtCoCode = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TableLayoutPanelLoadingSector = New System.Windows.Forms.TableLayoutPanel
        Me.LabelLoadingSector = New System.Windows.Forms.Label
        Me.PictureBoxLoadingSector = New System.Windows.Forms.PictureBox
        Me.LabelLoadingCompany = New System.Windows.Forms.Label
        Me.PictureBoxLoading = New System.Windows.Forms.PictureBox
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.LinkLabelShowSectorList = New System.Windows.Forms.LinkLabel
        Me.Label5 = New System.Windows.Forms.Label
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.BtnSyncResults = New System.Windows.Forms.Button
        Me.backgroundworkerSectorSync = New System.ComponentModel.BackgroundWorker
        Me.Process1 = New System.Diagnostics.Process
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.CheckBoxRatios = New System.Windows.Forms.CheckBox
        Me.CheckBoxAnnualResults = New System.Windows.Forms.CheckBox
        Me.GroupBoxChoose = New System.Windows.Forms.GroupBox
        Me.PanelSectorList = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.BtnSelectNone = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.BtnSelectAll = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanelLoadingSector.SuspendLayout()
        CType(Me.PictureBoxLoadingSector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBoxChoose.SuspendLayout()
        Me.PanelSectorList.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlGridViews
        '
        Me.pnlGridViews.Location = New System.Drawing.Point(9, 480)
        Me.pnlGridViews.Name = "pnlGridViews"
        Me.pnlGridViews.Size = New System.Drawing.Size(358, 25)
        Me.pnlGridViews.TabIndex = 0
        Me.pnlGridViews.Visible = False
        '
        'BtnShowTable
        '
        Me.BtnShowTable.Location = New System.Drawing.Point(661, 412)
        Me.BtnShowTable.Name = "BtnShowTable"
        Me.BtnShowTable.Size = New System.Drawing.Size(87, 27)
        Me.BtnShowTable.TabIndex = 2
        Me.BtnShowTable.Text = "Show"
        Me.BtnShowTable.UseVisualStyleBackColor = True
        Me.BtnShowTable.Visible = False
        '
        'TxtLink
        '
        Me.TxtLink.Location = New System.Drawing.Point(9, 416)
        Me.TxtLink.Name = "TxtLink"
        Me.TxtLink.Size = New System.Drawing.Size(434, 21)
        Me.TxtLink.TabIndex = 0
        Me.TxtLink.Visible = False
        '
        'TxtTableName
        '
        Me.TxtTableName.Location = New System.Drawing.Point(471, 415)
        Me.TxtTableName.Name = "TxtTableName"
        Me.TxtTableName.Size = New System.Drawing.Size(182, 21)
        Me.TxtTableName.TabIndex = 1
        Me.TxtTableName.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 394)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter website link here from which you need the data"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(467, 394)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter the tag of table you want data from"
        Me.Label2.Visible = False
        '
        'Txttemp
        '
        Me.Txttemp.Location = New System.Drawing.Point(756, 410)
        Me.Txttemp.Multiline = True
        Me.Txttemp.Name = "Txttemp"
        Me.Txttemp.Size = New System.Drawing.Size(322, 111)
        Me.Txttemp.TabIndex = 5
        Me.Txttemp.Visible = False
        '
        'BtnCreateCoTable
        '
        Me.BtnCreateCoTable.Location = New System.Drawing.Point(567, 446)
        Me.BtnCreateCoTable.Name = "BtnCreateCoTable"
        Me.BtnCreateCoTable.Size = New System.Drawing.Size(182, 27)
        Me.BtnCreateCoTable.TabIndex = 6
        Me.BtnCreateCoTable.Text = "Create Co Table"
        Me.BtnCreateCoTable.UseVisualStyleBackColor = True
        Me.BtnCreateCoTable.Visible = False
        '
        'btnSyncAll
        '
        Me.btnSyncAll.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSyncAll.ForeColor = System.Drawing.Color.Navy
        Me.btnSyncAll.Location = New System.Drawing.Point(125, 39)
        Me.btnSyncAll.Name = "btnSyncAll"
        Me.btnSyncAll.Size = New System.Drawing.Size(184, 30)
        Me.btnSyncAll.TabIndex = 7
        Me.btnSyncAll.Text = "Sync All Ratios"
        Me.btnSyncAll.UseVisualStyleBackColor = True
        '
        'txtCoCode
        '
        Me.txtCoCode.Location = New System.Drawing.Point(250, 455)
        Me.txtCoCode.Name = "txtCoCode"
        Me.txtCoCode.Size = New System.Drawing.Size(167, 21)
        Me.txtCoCode.TabIndex = 8
        Me.txtCoCode.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 458)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Enter Company Sc_Code to create table"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(436, 489)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "AstiTatva © 2011 · English (India)"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.TableLayoutPanelLoadingSector)
        Me.Panel1.Controls.Add(Me.PictureBoxLoading)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.LinkLabelShowSectorList)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(416, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 54)
        Me.Panel1.TabIndex = 14
        '
        'TableLayoutPanelLoadingSector
        '
        Me.TableLayoutPanelLoadingSector.ColumnCount = 2
        Me.TableLayoutPanelLoadingSector.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanelLoadingSector.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanelLoadingSector.Controls.Add(Me.LabelLoadingSector, 1, 0)
        Me.TableLayoutPanelLoadingSector.Controls.Add(Me.PictureBoxLoadingSector, 0, 0)
        Me.TableLayoutPanelLoadingSector.Controls.Add(Me.LabelLoadingCompany, 1, 1)
        Me.TableLayoutPanelLoadingSector.Location = New System.Drawing.Point(321, 5)
        Me.TableLayoutPanelLoadingSector.Name = "TableLayoutPanelLoadingSector"
        Me.TableLayoutPanelLoadingSector.RowCount = 2
        Me.TableLayoutPanelLoadingSector.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelLoadingSector.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.TableLayoutPanelLoadingSector.Size = New System.Drawing.Size(300, 49)
        Me.TableLayoutPanelLoadingSector.TabIndex = 30
        Me.TableLayoutPanelLoadingSector.Visible = False
        '
        'LabelLoadingSector
        '
        Me.LabelLoadingSector.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelLoadingSector.AutoSize = True
        Me.LabelLoadingSector.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLoadingSector.Location = New System.Drawing.Point(41, 6)
        Me.LabelLoadingSector.Name = "LabelLoadingSector"
        Me.LabelLoadingSector.Size = New System.Drawing.Size(55, 20)
        Me.LabelLoadingSector.TabIndex = 28
        Me.LabelLoadingSector.Text = "Sector"
        '
        'PictureBoxLoadingSector
        '
        Me.PictureBoxLoadingSector.Image = CType(resources.GetObject("PictureBoxLoadingSector.Image"), System.Drawing.Image)
        Me.PictureBoxLoadingSector.Location = New System.Drawing.Point(3, 3)
        Me.PictureBoxLoadingSector.Name = "PictureBoxLoadingSector"
        Me.PictureBoxLoadingSector.Size = New System.Drawing.Size(32, 27)
        Me.PictureBoxLoadingSector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBoxLoadingSector.TabIndex = 29
        Me.PictureBoxLoadingSector.TabStop = False
        '
        'LabelLoadingCompany
        '
        Me.LabelLoadingCompany.AutoSize = True
        Me.LabelLoadingCompany.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLoadingCompany.Location = New System.Drawing.Point(41, 33)
        Me.LabelLoadingCompany.Name = "LabelLoadingCompany"
        Me.LabelLoadingCompany.Size = New System.Drawing.Size(115, 16)
        Me.LabelLoadingCompany.TabIndex = 31
        Me.LabelLoadingCompany.Text = "Company SC Code:"
        '
        'PictureBoxLoading
        '
        Me.PictureBoxLoading.Image = CType(resources.GetObject("PictureBoxLoading.Image"), System.Drawing.Image)
        Me.PictureBoxLoading.Location = New System.Drawing.Point(621, 7)
        Me.PictureBoxLoading.Name = "PictureBoxLoading"
        Me.PictureBoxLoading.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBoxLoading.TabIndex = 28
        Me.PictureBoxLoading.TabStop = False
        Me.PictureBoxLoading.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(4, 46)
        Me.Panel9.TabIndex = 29
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(656, 4)
        Me.Panel8.TabIndex = 28
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 50)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(656, 4)
        Me.Panel5.TabIndex = 25
        '
        'LinkLabelShowSectorList
        '
        Me.LinkLabelShowSectorList.AutoSize = True
        Me.LinkLabelShowSectorList.Font = New System.Drawing.Font("Century Schoolbook", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelShowSectorList.Location = New System.Drawing.Point(5, 27)
        Me.LinkLabelShowSectorList.Name = "LinkLabelShowSectorList"
        Me.LinkLabelShowSectorList.Size = New System.Drawing.Size(127, 18)
        Me.LinkLabelShowSectorList.TabIndex = 18
        Me.LinkLabelShowSectorList.TabStop = True
        Me.LinkLabelShowSectorList.Text = "Show Sector List"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(2, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(316, 19)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Sync selected Industery/section here"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(8, 31)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(338, 276)
        Me.CheckedListBox1.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Location = New System.Drawing.Point(473, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 93)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Sync" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Selected Sectors Only"
        Me.ToolTip1.SetToolTip(Me.Button1, "Sync Selected sectors only")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btnSyncAll)
        Me.Panel2.Location = New System.Drawing.Point(9, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(392, 84)
        Me.Panel2.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "# Note"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(336, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Click here to Sync All Ratios at one Go"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.BtnSyncResults)
        Me.Panel3.Location = New System.Drawing.Point(9, 104)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(392, 84)
        Me.Panel3.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "# Note"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(333, 19)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = " Sync Annual Results of all Companies"
        '
        'BtnSyncResults
        '
        Me.BtnSyncResults.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSyncResults.ForeColor = System.Drawing.Color.Navy
        Me.BtnSyncResults.Location = New System.Drawing.Point(125, 39)
        Me.BtnSyncResults.Name = "BtnSyncResults"
        Me.BtnSyncResults.Size = New System.Drawing.Size(184, 30)
        Me.BtnSyncResults.TabIndex = 7
        Me.BtnSyncResults.Text = "Sync Annual Results"
        Me.BtnSyncResults.UseVisualStyleBackColor = True
        '
        'backgroundworkerSectorSync
        '
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'CheckBoxRatios
        '
        Me.CheckBoxRatios.AutoSize = True
        Me.CheckBoxRatios.Location = New System.Drawing.Point(7, 22)
        Me.CheckBoxRatios.Name = "CheckBoxRatios"
        Me.CheckBoxRatios.Size = New System.Drawing.Size(58, 19)
        Me.CheckBoxRatios.TabIndex = 21
        Me.CheckBoxRatios.Text = "Ratios"
        Me.CheckBoxRatios.UseVisualStyleBackColor = True
        '
        'CheckBoxAnnualResults
        '
        Me.CheckBoxAnnualResults.AutoSize = True
        Me.CheckBoxAnnualResults.Location = New System.Drawing.Point(7, 46)
        Me.CheckBoxAnnualResults.Name = "CheckBoxAnnualResults"
        Me.CheckBoxAnnualResults.Size = New System.Drawing.Size(105, 19)
        Me.CheckBoxAnnualResults.TabIndex = 22
        Me.CheckBoxAnnualResults.Text = "Annual Results"
        Me.CheckBoxAnnualResults.UseVisualStyleBackColor = True
        '
        'GroupBoxChoose
        '
        Me.GroupBoxChoose.Controls.Add(Me.CheckBoxRatios)
        Me.GroupBoxChoose.Controls.Add(Me.CheckBoxAnnualResults)
        Me.GroupBoxChoose.Location = New System.Drawing.Point(352, 30)
        Me.GroupBoxChoose.Name = "GroupBoxChoose"
        Me.GroupBoxChoose.Size = New System.Drawing.Size(115, 76)
        Me.GroupBoxChoose.TabIndex = 23
        Me.GroupBoxChoose.TabStop = False
        Me.GroupBoxChoose.Text = "Choose"
        '
        'PanelSectorList
        '
        Me.PanelSectorList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PanelSectorList.Controls.Add(Me.Panel7)
        Me.PanelSectorList.Controls.Add(Me.Panel6)
        Me.PanelSectorList.Controls.Add(Me.BtnSelectNone)
        Me.PanelSectorList.Controls.Add(Me.Panel4)
        Me.PanelSectorList.Controls.Add(Me.Button1)
        Me.PanelSectorList.Controls.Add(Me.BtnSelectAll)
        Me.PanelSectorList.Controls.Add(Me.GroupBoxChoose)
        Me.PanelSectorList.Controls.Add(Me.CheckedListBox1)
        Me.PanelSectorList.Location = New System.Drawing.Point(416, 66)
        Me.PanelSectorList.Name = "PanelSectorList"
        Me.PanelSectorList.Size = New System.Drawing.Size(656, 323)
        Me.PanelSectorList.TabIndex = 24
        Me.PanelSectorList.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(4, 319)
        Me.Panel7.TabIndex = 25
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 319)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(656, 4)
        Me.Panel6.TabIndex = 27
        '
        'BtnSelectNone
        '
        Me.BtnSelectNone.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelectNone.ForeColor = System.Drawing.Color.Navy
        Me.BtnSelectNone.Location = New System.Drawing.Point(87, 0)
        Me.BtnSelectNone.Name = "BtnSelectNone"
        Me.BtnSelectNone.Size = New System.Drawing.Size(99, 23)
        Me.BtnSelectNone.TabIndex = 26
        Me.BtnSelectNone.Text = "Select NONE"
        Me.BtnSelectNone.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel4.Location = New System.Drawing.Point(0, 24)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(412, 4)
        Me.Panel4.TabIndex = 24
        '
        'BtnSelectAll
        '
        Me.BtnSelectAll.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelectAll.ForeColor = System.Drawing.Color.Navy
        Me.BtnSelectAll.Location = New System.Drawing.Point(7, 0)
        Me.BtnSelectAll.Name = "BtnSelectAll"
        Me.BtnSelectAll.Size = New System.Drawing.Size(82, 23)
        Me.BtnSelectAll.TabIndex = 25
        Me.BtnSelectAll.Text = "Select ALL"
        Me.BtnSelectAll.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 518)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCoCode)
        Me.Controls.Add(Me.BtnCreateCoTable)
        Me.Controls.Add(Me.Txttemp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTableName)
        Me.Controls.Add(Me.TxtLink)
        Me.Controls.Add(Me.BtnShowTable)
        Me.Controls.Add(Me.pnlGridViews)
        Me.Controls.Add(Me.PanelSectorList)
        Me.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Sync"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanelLoadingSector.ResumeLayout(False)
        Me.TableLayoutPanelLoadingSector.PerformLayout()
        CType(Me.PictureBoxLoadingSector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBoxChoose.ResumeLayout(False)
        Me.GroupBoxChoose.PerformLayout()
        Me.PanelSectorList.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlGridViews As System.Windows.Forms.Panel
    Friend WithEvents BtnShowTable As System.Windows.Forms.Button
    Friend WithEvents TxtLink As System.Windows.Forms.TextBox
    Friend WithEvents TxtTableName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txttemp As System.Windows.Forms.TextBox
    Friend WithEvents BtnCreateCoTable As System.Windows.Forms.Button
    Friend WithEvents btnSyncAll As System.Windows.Forms.Button
    Friend WithEvents txtCoCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtnSyncResults As System.Windows.Forms.Button
    Friend WithEvents backgroundworkerSectorSync As System.ComponentModel.BackgroundWorker
    Friend WithEvents Process1 As System.Diagnostics.Process
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents LinkLabelShowSectorList As System.Windows.Forms.LinkLabel
    Friend WithEvents CheckBoxAnnualResults As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxRatios As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBoxChoose As System.Windows.Forms.GroupBox
    Friend WithEvents PanelSectorList As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BtnSelectNone As System.Windows.Forms.Button
    Friend WithEvents BtnSelectAll As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents PictureBoxLoading As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxLoadingSector As System.Windows.Forms.PictureBox
    Friend WithEvents LabelLoadingSector As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanelLoadingSector As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelLoadingCompany As System.Windows.Forms.Label
End Class
