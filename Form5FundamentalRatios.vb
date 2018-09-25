Imports System.Data
Imports System.Data.OleDb
Imports System.Threading

Public Class Form5FundamentalRatios
    Dim dtFundamentalRatios As DataTable
    Dim dvFundamentalRatios As DataView
    Private Sub Form5FundamentalRatios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor = Cursors.WaitCursor


        Dim strSql As String
        System.IO.Directory.SetCurrentDirectory(Application.StartupPath() & "\..\Data")
        Dim CSVCon As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath() & "\..\Data\" + ";Extended Properties=Text")
        strSql = Nothing
        'For Each fi In dataFiles
        'to Join 2 Tables
        'strSql = "SELECT *  " & _
        '        "FROM ([" + GetLatestBhaavCopyName() + "] e1 INNER JOIN" & _
        '        "[LatestRatiosTable.csv] e2 ON e1.SC_CODE = e2.SC_CODE)"

        'to Join 3 Tables, 3rd is Companies.csv, to add Industry & sector Columns
        strSql = " SELECT * " & _
                 " FROM ((([Companies.csv] e1 " & _
                 " INNER JOIN [" + Form3_SortedRatios.GetLatestBhaavCopyName() + "] e2 ON e1.Code = e2.SC_CODE) " & _
        " INNER JOIN [LatestRatiosTable.csv] e3 ON e1.Code = e3.SC_CODE)  " & _
        " INNER JOIN [LatestAnnualResults.csv] e4 ON e1.Code = e4.SC_CODE)  "

        'Next
        'strSql = strSql.Substring(0, strSql.Length - 6)
        '#load the data from CSV to DataTable 
        Dim oleda As OleDbDataAdapter = New OleDbDataAdapter(strSql, CSVCon)
        dtFundamentalRatios = New DataTable()
        'strConnection.
        oleda.Fill(dtFundamentalRatios)
        System.IO.Directory.SetCurrentDirectory(Application.StartupPath())

        If dtFundamentalRatios.Rows.Count = 0 Then
            MsgBox("Data not found ")
            strSql = Nothing
            'Return False
        End If

        'Empty the String 
        strSql = Nothing


        '# Add P/E Ratio Column to dataTable
        Dim columnPE As DataColumn = New DataColumn("P/E Ratio", GetType(Double))
        columnPE.Expression = "[CLOSE]/[adjusted cash eps (rs)]"
        dtFundamentalRatios.Columns.Add(columnPE)

        '# Create DataView on dtbResult
        dvFundamentalRatios = New DataView(dtFundamentalRatios)
        DataGridViewFundamentalRatios.DataSource = dvFundamentalRatios

        '## Collumns selected from bhaav copy(Total Columns:15)
        For i As Int16 = 7 + 1 To 7 + 15
            DataGridViewFundamentalRatios.Columns(i).Visible = False
        Next
        DataGridViewFundamentalRatios.Columns("CLOSE").Visible = True
        DataGridViewFundamentalRatios.Columns("CLOSE").HeaderText = "Price"
        DataGridViewFundamentalRatios.Columns("SC_DATE").Visible = True
        DataGridViewFundamentalRatios.Columns("SC_DATE").HeaderText = "Price Date"

        '## Collumns selected from LatestRatiosTable(Total Columns:40)
        For i As Int16 = 7 + 15 + 2 To 7 + 15 + 40
            DataGridViewFundamentalRatios.Columns(i).Visible = False
        Next
        DataGridViewFundamentalRatios.Columns("Ratios").HeaderText = "Ratios Date"
        With DataGridViewFundamentalRatios.Columns("adjusted return on net worth (%)")
            .Visible = True
            .HeaderText = "RONW(adj)"
            .ToolTipText = "Adjusted Return on net worth (%)"
        End With
        'book value (incl rev res) per share (rs.)
        With DataGridViewFundamentalRatios.Columns("book value (incl rev res) per share (rs#)") ' '.' converted to '#' in datatable
            .Visible = True
            .HeaderText = "BV/Share (Inc rev res)"
            .ToolTipText = "BookValue/Share(Inc rev res)(Rs.)"
        End With
        'total debt/equity
        With DataGridViewFundamentalRatios.Columns("total debt/equity")
            .Visible = True
            .HeaderText = "D/E (Total)"
            .ToolTipText = "Debt/Equity (Total)"
        End With
        'current ratio (inc. st loans)
        With DataGridViewFundamentalRatios.Columns("current ratio (inc# st loans)")
            .Visible = True
            .HeaderText = "Current Ratio"
            .ToolTipText = "Current Ratio(inc. st loans)"
        End With
        'quick ratio
        With DataGridViewFundamentalRatios.Columns("quick ratio")
            .Visible = True
            .HeaderText = "Quick Ratio"
            .ToolTipText = "Quick Ratio"
        End With
        'fin. charges cov.ratio (post tax)
        With DataGridViewFundamentalRatios.Columns("fin# charges cov#ratio (post tax)")
            .Visible = True
            .HeaderText = "FCCR(After Tax)"
            .ToolTipText = "Financial Charges Coverage Ratio(After Tax)"
        End With

        '## Collumns selected from LatestAnnualResults(Total Columns:30)
        For i As Int16 = 7 + 15 + 40 + 2 To 7 + 15 + 40 + 26
            DataGridViewFundamentalRatios.Columns(i).Visible = False
        Next
        DataGridViewFundamentalRatios.Columns("Annual").HeaderText = "Annual Date"
        With DataGridViewFundamentalRatios.Columns("eps (rs)")
            .Visible = True
            .HeaderText = "EPS(adj)"
            .ToolTipText = "EPS (Rs)"
        End With
        With DataGridViewFundamentalRatios.Columns("opm (%)")
            .Visible = True
            .HeaderText = "OPM (%)"
            .ToolTipText = "OPM (%)"
        End With
        With DataGridViewFundamentalRatios.Columns("gpm (%)")
            .Visible = True
            .HeaderText = "GPM (%)"
            .ToolTipText = "GPM (%)"
        End With
        With DataGridViewFundamentalRatios.Columns("npm (%)")
            .Visible = True
            .HeaderText = "NPM (%)"
            .ToolTipText = "NPM (%)"
        End With
        DataGridViewFundamentalRatios.Columns("e4.SC_CODE").Visible = False
        'To display upto 2 decimal positions
        DataGridViewFundamentalRatios.Columns("P/E Ratio").DefaultCellStyle.Format = "#,##0.00"

        'DataGridViewFundamentalRatios.Columns("Group").DefaultHeaderCellType = DataGridViewautofiltertextboxcolumn
        ComboBox1.Text = "ALL"
        ComboBoxSector.Text = "ALL"
        ComboBoxIndustry.Text = "ALL"
        PanelFilters.Visible = True
        Me.PopulateSectorComboBox()
        Me.PopulateIndustryComboBox()
        Panel1_Results.Visible = True

        Cursor = Cursors.Default

    End Sub

    Private Sub BtnDownloadCSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDownloadCSV.Click
        ' When user clicks button, show the dialog.
        With SaveFileDialog1
            .DefaultExt = "csv"
            .FileName = "Fundamental Ratios_" + System.DateTime.Now.ToLongDateString
            .Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .AddExtension = True
            .Title = "Save File Dialog"
            .RestoreDirectory = True
        End With

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Form3_SortedRatios.DataTable2CSV(dtFundamentalRatios, SaveFileDialog1.FileName, ",")    '"Ratios_Downloaded.csv", ",")
            MsgBox("Download Completed!! @ path = " + SaveFileDialog1.FileName)
            Console.WriteLine(SaveFileDialog1.FileName)
        End If
    End Sub

    Sub PopulateSectorComboBox()
        Dim CSVCon As OleDbConnection
        Dim Cmd As OleDb.OleDbCommand
        Dim Reader As OleDb.OleDbDataReader
        Dim ComboRow As Integer = -1
        Dim Columns As Integer = 0
        Dim Category As String = Nothing

        CSVCon = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath() & "\..\Data\" + ";Extended Properties=Text")
        Dim strSQL As String = "SELECT DISTINCT  [Sector] FROM [Companies.csv] ORDER BY [Sector] "
        Cmd = New OleDb.OleDbCommand(strSQL, CSVCon)
        CSVCon.Open()
        'Dim da As New OleDbDataAdapter(strSQL, CSVCon)
        'Dim ds As New DataSet
        'da.Fill(ds, "CoSector")
        Me.ComboBoxSector.Items.Clear()
        'With Me.ComboBoxSector
        '    .DataSource = ds.Tables("CoSector").DefaultView
        '    .DisplayMember = "Sector"
        '    .ValueMember = "Sector"
        'End With
        Reader = Cmd.ExecuteReader()
        While Reader.Read()
            For Columns = 0 To Reader.FieldCount - 1
                Category = Reader.Item(Columns).ToString  'READ COLUMN FROM DATABASE
            Next
            Me.ComboBoxSector.Items.Add(Category)
            ComboRow += 1
        End While

        CSVCon.Close()

        Me.ComboBoxSector.Items.Insert(0, ("ALL"))
        'Me.ComboBoxSector.SelectedIndex = 0
    End Sub
    Sub PopulateIndustryComboBox()
        Dim CSVCon As OleDbConnection
        Dim Cmd As OleDb.OleDbCommand
        Dim Reader As OleDb.OleDbDataReader
        Dim ComboRow As Integer = -1
        Dim Columns As Integer = 0
        Dim Category As String = Nothing
        Dim strSQL As String = Nothing

        CSVCon = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath() & "\..\Data\" + ";Extended Properties=Text")
        If String.Equals(Me.ComboBoxSector.Text.Trim, "ALL") Then
            strSQL = "SELECT DISTINCT  [Industry], [Sector] FROM [Companies.csv] ORDER BY [Industry] "
        Else
            strSQL = "SELECT DISTINCT  [Industry], [Sector] FROM [Companies.csv] WHERE ([Sector] = '" & Me.ComboBoxSector.Text.Trim & "') ORDER BY [Industry] "
        End If
        Cmd = New OleDb.OleDbCommand(strSQL, CSVCon)
        CSVCon.Open()

        Me.ComboBoxIndustry.Items.Clear()
        Reader = Cmd.ExecuteReader()
        While Reader.Read()
            Category = Reader.Item("Industry").ToString  'READ COLUMN FROM DATABASE

            Me.ComboBoxIndustry.Items.Add(Category)
            ComboRow += 1
        End While

        CSVCon.Close()

        Me.ComboBoxIndustry.Items.Insert(0, ("ALL"))
        ' Me.ComboBoxIndustry.SelectedIndex = 0
    End Sub

    Private Function StockSearch()
        On Error GoTo Error_StockSearch

        Dim addAnd As String = Nothing

        '1st Combo - Group 
        If (Me.ComboBox1.Text <> "ALL") And (Me.ComboBox1.Text <> String.Empty) Then
            If dvFundamentalRatios.RowFilter <> String.Empty Then
                addAnd = "AND "
            End If
            dvFundamentalRatios.RowFilter &= addAnd + "SC_GROUP = ('" & Me.ComboBox1.SelectedItem & "')"
        End If

        addAnd = Nothing
        '2nd Combo -Sector 
        If (Me.ComboBoxSector.Text <> "ALL") And (Me.ComboBoxSector.Text <> String.Empty) Then
            If dvFundamentalRatios.RowFilter <> String.Empty Then
                addAnd = "AND "
            End If
            dvFundamentalRatios.RowFilter &= addAnd + "Sector = ('" & Me.ComboBoxSector.SelectedItem & "')"
        End If

        addAnd = Nothing
        '3rd Combo - Industry
        If (Me.ComboBoxIndustry.Text <> "ALL") And (Me.ComboBoxIndustry.Text <> String.Empty) Then
            If dvFundamentalRatios.RowFilter <> String.Empty Then
                addAnd = "AND "
            End If
            dvFundamentalRatios.RowFilter &= addAnd + "Industry = ('" & Me.ComboBoxIndustry.SelectedItem & "')"
        End If

Exit_StockSearch:
        Exit Function

Error_StockSearch:
        MsgBox("StockSearch Function Error" & vbCr & vbCr & _
               Err.Number & " - " & Err.Description, vbExclamation, _
               "Stock Search Error")
        Resume Exit_StockSearch
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        dvFundamentalRatios.RowFilter = ""
        StockSearch()
    End Sub

    Private Sub ComboBoxSector_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSector.SelectedIndexChanged
        dvFundamentalRatios.RowFilter = ""
        StockSearch()
    End Sub

    Private Sub ComboBoxIndustry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxIndustry.SelectedIndexChanged
        dvFundamentalRatios.RowFilter = ""
        StockSearch()
    End Sub
End Class