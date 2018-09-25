<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4Results
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.BtnAnnualResults = New System.Windows.Forms.Button
        Me.BtnUpdateResults = New System.Windows.Forms.Button
        Me.PanelFilters = New System.Windows.Forms.Panel
        Me.ComboBoxSector = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBoxIndustry = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1_Results = New System.Windows.Forms.Panel
        Me.BtnDownloadCSV = New System.Windows.Forms.Button
        Me.DataGridView1_Result = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.PanelFilters.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel1_Results.SuspendLayout()
        CType(Me.DataGridView1_Result, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAnnualResults
        '
        Me.BtnAnnualResults.Font = New System.Drawing.Font("Century Schoolbook", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnnualResults.ForeColor = System.Drawing.Color.Navy
        Me.BtnAnnualResults.Location = New System.Drawing.Point(2, 4)
        Me.BtnAnnualResults.Name = "BtnAnnualResults"
        Me.BtnAnnualResults.Size = New System.Drawing.Size(193, 23)
        Me.BtnAnnualResults.TabIndex = 0
        Me.BtnAnnualResults.Text = "Show Annual Results"
        Me.BtnAnnualResults.UseVisualStyleBackColor = True
        '
        'BtnUpdateResults
        '
        Me.BtnUpdateResults.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateResults.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BtnUpdateResults.Location = New System.Drawing.Point(3, 7)
        Me.BtnUpdateResults.Name = "BtnUpdateResults"
        Me.BtnUpdateResults.Size = New System.Drawing.Size(178, 23)
        Me.BtnUpdateResults.TabIndex = 2
        Me.BtnUpdateResults.Text = "Update Annual Results"
        Me.BtnUpdateResults.UseVisualStyleBackColor = True
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
        Me.PanelFilters.Location = New System.Drawing.Point(2, 43)
        Me.PanelFilters.Name = "PanelFilters"
        Me.PanelFilters.Size = New System.Drawing.Size(545, 49)
        Me.PanelFilters.TabIndex = 20
        Me.PanelFilters.Visible = False
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
        'ComboBoxIndustry
        '
        Me.ComboBoxIndustry.FormattingEnabled = True
        Me.ComboBoxIndustry.Items.AddRange(New Object() {"ALL", "2/3 Wheelers", "Advertising & Media", "Aerospace", "Agrochemicals", "Airlines", "Aluminium", "Asset Management Companies", "Auto Parts & Equipments", "Auto Tyres & Rubber Products", "Banks", "Biotechnology", "BPO/KPO", "Breweries & Distilleries", "Broadcasting & Cable TV", "Carbon Black", "Cars & Utility Vehicles", "Cement & Cement Products", "Cigarettes, Tobacco Products", "Coal", "Comm. Printing/Stationary", "Comm. Trading & Distribution", "Commercial Vehicles", "Commodity Chemicals", "Computer Hardware", "Construction & Engineering", "Construction Materials", "Consulting Services", "Consumer Electronics", "Containers & Packaging", "Copper", "Data Processing Services", "Defence", "Department Stores", "Distributors", "Diversified", "Edible Oils", "Education", "Electric Utilities", "Electronic Components", "Exploration & Production", "Fertilizers", "Fibres & Plastics", "Finance (including NBFCs)", "Financial Institutions", "Footwear", "Forest Products", "Furniture, Furnishing, Paints", "Gift Articles, Toys & Cards", "Healthcare Facilities", "Healthcare Services", "Healthcare Supplies", "Heavy Electrical Equipment", "Hotels", "Household Appliances", "Household Products", "Houseware", "Housing Finance", "Industrial Gases", "Industrial Machinery", "Integrated Oil & Gas", "Internet & Catalogue Retail", "Internet Software & Services", "Investment Companies", "Iron & Steel Products", "Iron & Steel/Interm. Products", "IT Consulting & Software", "IT Networking Equipment", "IT Software Products", "IT Training Services", "Jute & Jute Products", "Marine Port & Services", "Medical Equipment", "Mining", "Misc. Commercial Services", "Movies & Entertainment", "NA", "Non-Alcoholic Beverages", "Non-Durable Household Products", "Oil Equipment & Services", "Oil Marketing & Distribution", "Other Agricultural Products", "Other Apparels & Accessories", "Other Elec Equipment/Products", "Other Financial Services", "Other Food Products", "Other Industrial Products", "Other Leisure Facilities", "Other Leisure Products", "Other Non-Ferrous Metals", "Other Telecom Services", "Packaged Foods", "Paper & Paper Products", "Personal Products", "Petrochemicals", "Pharmaceuticals", "Photographic Products", "Plastic Products", "Publishing", "Realty", "Refineries/Petro-Products", "Restaurants", "Roads & Highways", "Shipping", "Specialty Chemicals", "Specialty Retail", "Storage Media & Peripherals", "Sugar", "Surface Transportation", "Tea & Coffee", "Telecom Cables", "Telecom Equipment", "Telecom Services", "Telecom-Alternate Carriers", "Textiles", "Transport Related Services", "Travel Support Services", "Utilities: Non-Electrical", "Zinc"})
        Me.ComboBoxIndustry.Location = New System.Drawing.Point(346, 21)
        Me.ComboBoxIndustry.Name = "ComboBoxIndustry"
        Me.ComboBoxIndustry.Size = New System.Drawing.Size(183, 21)
        Me.ComboBoxIndustry.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnUpdateResults)
        Me.Panel1.Location = New System.Drawing.Point(483, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 38)
        Me.Panel1.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Update database table after every new sync from rediff"
        '
        'Panel1_Results
        '
        Me.Panel1_Results.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1_Results.Controls.Add(Me.BtnDownloadCSV)
        Me.Panel1_Results.Controls.Add(Me.DataGridView1_Result)
        Me.Panel1_Results.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1_Results.Location = New System.Drawing.Point(0, 98)
        Me.Panel1_Results.Name = "Panel1_Results"
        Me.Panel1_Results.Size = New System.Drawing.Size(965, 402)
        Me.Panel1_Results.TabIndex = 22
        '
        'BtnDownloadCSV
        '
        Me.BtnDownloadCSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDownloadCSV.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDownloadCSV.Location = New System.Drawing.Point(814, 0)
        Me.BtnDownloadCSV.Name = "BtnDownloadCSV"
        Me.BtnDownloadCSV.Size = New System.Drawing.Size(152, 23)
        Me.BtnDownloadCSV.TabIndex = 19
        Me.BtnDownloadCSV.Text = "Download as CSV file"
        Me.BtnDownloadCSV.UseVisualStyleBackColor = True
        '
        'DataGridView1_Result
        '
        Me.DataGridView1_Result.AllowUserToAddRows = False
        Me.DataGridView1_Result.AllowUserToDeleteRows = False
        Me.DataGridView1_Result.AllowUserToOrderColumns = True
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridView1_Result.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1_Result.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1_Result.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1_Result.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DataGridView1_Result.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridView1_Result.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1_Result.GridColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataGridView1_Result.Location = New System.Drawing.Point(0, 23)
        Me.DataGridView1_Result.Name = "DataGridView1_Result"
        Me.DataGridView1_Result.ReadOnly = True
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1_Result.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1_Result.Size = New System.Drawing.Size(965, 379)
        Me.DataGridView1_Result.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column1.HeaderText = "S. No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 40
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(793, 38)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(169, 23)
        Me.ProgressBar1.TabIndex = 23
        '
        'Form4Results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(965, 500)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel1_Results)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelFilters)
        Me.Controls.Add(Me.BtnAnnualResults)
        Me.Name = "Form4Results"
        Me.Text = "Annual Results"
        Me.PanelFilters.ResumeLayout(False)
        Me.PanelFilters.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel1_Results.ResumeLayout(False)
        CType(Me.DataGridView1_Result, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAnnualResults As System.Windows.Forms.Button
    Friend WithEvents BtnUpdateResults As System.Windows.Forms.Button
    Friend WithEvents PanelFilters As System.Windows.Forms.Panel
    Friend WithEvents ComboBoxSector As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxIndustry As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1_Results As System.Windows.Forms.Panel
    Friend WithEvents BtnDownloadCSV As System.Windows.Forms.Button
    Friend WithEvents DataGridView1_Result As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
