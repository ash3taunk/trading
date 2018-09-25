<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5FundamentalRatios
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1_Results = New System.Windows.Forms.Panel
        Me.BtnDownloadCSV = New System.Windows.Forms.Button
        Me.DataGridViewFundamentalRatios = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PanelFilters = New System.Windows.Forms.Panel
        Me.ComboBoxSector = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBoxIndustry = New System.Windows.Forms.ComboBox
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Panel1_Results.SuspendLayout()
        CType(Me.DataGridViewFundamentalRatios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFilters.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1_Results
        '
        Me.Panel1_Results.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1_Results.Controls.Add(Me.BtnDownloadCSV)
        Me.Panel1_Results.Controls.Add(Me.DataGridViewFundamentalRatios)
        Me.Panel1_Results.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1_Results.Location = New System.Drawing.Point(0, 57)
        Me.Panel1_Results.Name = "Panel1_Results"
        Me.Panel1_Results.Size = New System.Drawing.Size(843, 406)
        Me.Panel1_Results.TabIndex = 24
        '
        'BtnDownloadCSV
        '
        Me.BtnDownloadCSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDownloadCSV.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDownloadCSV.Location = New System.Drawing.Point(692, 0)
        Me.BtnDownloadCSV.Name = "BtnDownloadCSV"
        Me.BtnDownloadCSV.Size = New System.Drawing.Size(152, 23)
        Me.BtnDownloadCSV.TabIndex = 19
        Me.BtnDownloadCSV.Text = "Download as CSV file"
        Me.BtnDownloadCSV.UseVisualStyleBackColor = True
        '
        'DataGridViewFundamentalRatios
        '
        Me.DataGridViewFundamentalRatios.AllowUserToAddRows = False
        Me.DataGridViewFundamentalRatios.AllowUserToDeleteRows = False
        Me.DataGridViewFundamentalRatios.AllowUserToOrderColumns = True
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DataGridViewFundamentalRatios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewFundamentalRatios.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewFundamentalRatios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewFundamentalRatios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFundamentalRatios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DataGridViewFundamentalRatios.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridViewFundamentalRatios.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridViewFundamentalRatios.GridColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataGridViewFundamentalRatios.Location = New System.Drawing.Point(0, 23)
        Me.DataGridViewFundamentalRatios.Name = "DataGridViewFundamentalRatios"
        Me.DataGridViewFundamentalRatios.ReadOnly = True
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewFundamentalRatios.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewFundamentalRatios.Size = New System.Drawing.Size(843, 383)
        Me.DataGridViewFundamentalRatios.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle11
        Me.Column1.HeaderText = "S. No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 40
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
        Me.PanelFilters.Location = New System.Drawing.Point(3, 3)
        Me.PanelFilters.Name = "PanelFilters"
        Me.PanelFilters.Size = New System.Drawing.Size(570, 49)
        Me.PanelFilters.TabIndex = 23
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
        'Form5FundamentalRatios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 463)
        Me.Controls.Add(Me.Panel1_Results)
        Me.Controls.Add(Me.PanelFilters)
        Me.Name = "Form5FundamentalRatios"
        Me.Text = "+"
        Me.Panel1_Results.ResumeLayout(False)
        CType(Me.DataGridViewFundamentalRatios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFilters.ResumeLayout(False)
        Me.PanelFilters.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1_Results As System.Windows.Forms.Panel
    Friend WithEvents BtnDownloadCSV As System.Windows.Forms.Button
    Friend WithEvents DataGridViewFundamentalRatios As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PanelFilters As System.Windows.Forms.Panel
    Friend WithEvents ComboBoxSector As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxIndustry As System.Windows.Forms.ComboBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
