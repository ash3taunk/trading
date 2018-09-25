<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3_SortedRatios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1_SortedRatios = New System.Windows.Forms.Panel
        Me.BtnDownloadCSV = New System.Windows.Forms.Button
        Me.DataGridView1_SortedRatios = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnShowRatios = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        Me.ComboBoxIndustry = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ComboBoxSector = New System.Windows.Forms.ComboBox
        Me.PanelFilters = New System.Windows.Forms.Panel
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.Panel1_SortedRatios.SuspendLayout()
        CType(Me.DataGridView1_SortedRatios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelFilters.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1_SortedRatios
        '
        Me.Panel1_SortedRatios.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1_SortedRatios.Controls.Add(Me.BtnDownloadCSV)
        Me.Panel1_SortedRatios.Controls.Add(Me.DataGridView1_SortedRatios)
        Me.Panel1_SortedRatios.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1_SortedRatios.Location = New System.Drawing.Point(0, 97)
        Me.Panel1_SortedRatios.Name = "Panel1_SortedRatios"
        Me.Panel1_SortedRatios.Size = New System.Drawing.Size(1039, 402)
        Me.Panel1_SortedRatios.TabIndex = 0
        '
        'BtnDownloadCSV
        '
        Me.BtnDownloadCSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDownloadCSV.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDownloadCSV.Location = New System.Drawing.Point(891, 0)
        Me.BtnDownloadCSV.Name = "BtnDownloadCSV"
        Me.BtnDownloadCSV.Size = New System.Drawing.Size(145, 23)
        Me.BtnDownloadCSV.TabIndex = 19
        Me.BtnDownloadCSV.Text = "Download as CSV file"
        Me.BtnDownloadCSV.UseVisualStyleBackColor = True
        '
        'DataGridView1_SortedRatios
        '
        Me.DataGridView1_SortedRatios.AllowUserToAddRows = False
        Me.DataGridView1_SortedRatios.AllowUserToDeleteRows = False
        Me.DataGridView1_SortedRatios.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridView1_SortedRatios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1_SortedRatios.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1_SortedRatios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1_SortedRatios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1_SortedRatios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DataGridView1_SortedRatios.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridView1_SortedRatios.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1_SortedRatios.GridColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataGridView1_SortedRatios.Location = New System.Drawing.Point(0, 23)
        Me.DataGridView1_SortedRatios.Name = "DataGridView1_SortedRatios"
        Me.DataGridView1_SortedRatios.ReadOnly = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1_SortedRatios.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1_SortedRatios.Size = New System.Drawing.Size(1039, 379)
        Me.DataGridView1_SortedRatios.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.HeaderText = "S. No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 40
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(862, 46)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(169, 23)
        Me.ProgressBar1.TabIndex = 1
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BtnUpdate.Location = New System.Drawing.Point(3, 4)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(161, 28)
        Me.BtnUpdate.TabIndex = 2
        Me.BtnUpdate.Text = "Update database table"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnUpdate)
        Me.Panel1.Location = New System.Drawing.Point(567, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 38)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Update database table after every new sync from rediff"
        '
        'BtnShowRatios
        '
        Me.BtnShowRatios.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShowRatios.ForeColor = System.Drawing.Color.Navy
        Me.BtnShowRatios.Location = New System.Drawing.Point(4, 4)
        Me.BtnShowRatios.Name = "BtnShowRatios"
        Me.BtnShowRatios.Size = New System.Drawing.Size(163, 23)
        Me.BtnShowRatios.TabIndex = 4
        Me.BtnShowRatios.Text = "Show Ratios Table"
        Me.BtnShowRatios.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ALL", "A", "B", "F", "S", "T", "TS", "Z"})
        Me.ComboBox1.Location = New System.Drawing.Point(7, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Select Group"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(426, 474)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "AstiTatva © 2011 · English (India)"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.SystemColors.Window
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"cgfh", "nbn,b", "nhkhn", "nkn"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(641, 42)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.ScrollAlwaysVisible = True
        Me.CheckedListBox1.Size = New System.Drawing.Size(120, 49)
        Me.CheckedListBox1.Sorted = True
        Me.CheckedListBox1.TabIndex = 14
        Me.CheckedListBox1.Visible = False
        '
        'ComboBoxIndustry
        '
        Me.ComboBoxIndustry.FormattingEnabled = True
        Me.ComboBoxIndustry.Items.AddRange(New Object() {"ALL", "2/3 Wheelers", "Advertising & Media", "Aerospace", "Agrochemicals", "Airlines", "Aluminium", "Asset Management Companies", "Auto Parts & Equipments", "Auto Tyres & Rubber Products", "Banks", "Biotechnology", "BPO/KPO", "Breweries & Distilleries", "Broadcasting & Cable TV", "Carbon Black", "Cars & Utility Vehicles", "Cement & Cement Products", "Cigarettes, Tobacco Products", "Coal", "Comm. Printing/Stationary", "Comm. Trading & Distribution", "Commercial Vehicles", "Commodity Chemicals", "Computer Hardware", "Construction & Engineering", "Construction Materials", "Consulting Services", "Consumer Electronics", "Containers & Packaging", "Copper", "Data Processing Services", "Defence", "Department Stores", "Distributors", "Diversified", "Edible Oils", "Education", "Electric Utilities", "Electronic Components", "Exploration & Production", "Fertilizers", "Fibres & Plastics", "Finance (including NBFCs)", "Financial Institutions", "Footwear", "Forest Products", "Furniture, Furnishing, Paints", "Gift Articles, Toys & Cards", "Healthcare Facilities", "Healthcare Services", "Healthcare Supplies", "Heavy Electrical Equipment", "Hotels", "Household Appliances", "Household Products", "Houseware", "Housing Finance", "Industrial Gases", "Industrial Machinery", "Integrated Oil & Gas", "Internet & Catalogue Retail", "Internet Software & Services", "Investment Companies", "Iron & Steel Products", "Iron & Steel/Interm. Products", "IT Consulting & Software", "IT Networking Equipment", "IT Software Products", "IT Training Services", "Jute & Jute Products", "Marine Port & Services", "Medical Equipment", "Mining", "Misc. Commercial Services", "Movies & Entertainment", "NA", "Non-Alcoholic Beverages", "Non-Durable Household Products", "Oil Equipment & Services", "Oil Marketing & Distribution", "Other Agricultural Products", "Other Apparels & Accessories", "Other Elec Equipment/Products", "Other Financial Services", "Other Food Products", "Other Industrial Products", "Other Leisure Facilities", "Other Leisure Products", "Other Non-Ferrous Metals", "Other Telecom Services", "Packaged Foods", "Paper & Paper Products", "Personal Products", "Petrochemicals", "Pharmaceuticals", "Photographic Products", "Plastic Products", "Publishing", "Realty", "Refineries/Petro-Products", "Restaurants", "Roads & Highways", "Shipping", "Specialty Chemicals", "Specialty Retail", "Storage Media & Peripherals", "Sugar", "Surface Transportation", "Tea & Coffee", "Telecom Cables", "Telecom Equipment", "Telecom Services", "Telecom-Alternate Carriers", "Textiles", "Transport Related Services", "Travel Support Services", "Utilities: Non-Electrical", "Zinc"})
        Me.ComboBoxIndustry.Location = New System.Drawing.Point(346, 21)
        Me.ComboBoxIndustry.Name = "ComboBoxIndustry"
        Me.ComboBoxIndustry.Size = New System.Drawing.Size(183, 21)
        Me.ComboBoxIndustry.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(343, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Select industry"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(142, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Select Sector"
        '
        'ComboBoxSector
        '
        Me.ComboBoxSector.FormattingEnabled = True
        Me.ComboBoxSector.Items.AddRange(New Object() {"ALL", "Automobiles", "Entertainment & Media", "Transportation", "Chemicals", "Mining/Metals", "Finance", "Banks", "Healthcare", "Computer Hardware/Software/IT Services", "Consumer Products", "Raw Materials", "Infrastructure Development", "Fuel", "Misc./Consultancy", "Electronic Products", "Defence Supplies", "Retail", "Education", "Power/Power Related Products", "Fibres & Plastics/Plastic Products", "Agriculture", "Furniture, Furnishing & Paints", "Hotels/Restaurants", "Industrial Products", "Telecom"})
        Me.ComboBoxSector.Location = New System.Drawing.Point(145, 21)
        Me.ComboBoxSector.Name = "ComboBoxSector"
        Me.ComboBoxSector.Size = New System.Drawing.Size(183, 21)
        Me.ComboBoxSector.TabIndex = 17
        '
        'PanelFilters
        '
        Me.PanelFilters.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PanelFilters.Controls.Add(Me.ComboBoxSector)
        Me.PanelFilters.Controls.Add(Me.Label4)
        Me.PanelFilters.Controls.Add(Me.Label5)
        Me.PanelFilters.Controls.Add(Me.ComboBox1)
        Me.PanelFilters.Controls.Add(Me.Label2)
        Me.PanelFilters.Controls.Add(Me.ComboBoxIndustry)
        Me.PanelFilters.Location = New System.Drawing.Point(4, 44)
        Me.PanelFilters.Name = "PanelFilters"
        Me.PanelFilters.Size = New System.Drawing.Size(547, 49)
        Me.PanelFilters.TabIndex = 19
        Me.PanelFilters.Visible = False
        '
        'BackgroundWorker1
        '
        '
        'Form3_SortedRatios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1039, 499)
        Me.Controls.Add(Me.PanelFilters)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnShowRatios)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel1_SortedRatios)
        Me.Name = "Form3_SortedRatios"
        Me.Text = "Form3_SortedRatios"
        Me.Panel1_SortedRatios.ResumeLayout(False)
        CType(Me.DataGridView1_SortedRatios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelFilters.ResumeLayout(False)
        Me.PanelFilters.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1_SortedRatios As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1_SortedRatios As System.Windows.Forms.DataGridView
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnShowRatios As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents ComboBoxIndustry As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxSector As System.Windows.Forms.ComboBox
    Friend WithEvents BtnDownloadCSV As System.Windows.Forms.Button
    Friend WithEvents PanelFilters As System.Windows.Forms.Panel
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
