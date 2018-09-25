Imports System.Data
Imports System.Data.OleDb
Imports System.Threading
Public Class Form4Results
    Dim dbResultsFile As String
    Private Sub Form4Results_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = False
        Panel1_Results.Visible = False
        dbResultsFile = "\..\Data\CoAnnualResultsTablesDatabase.mdb"
    End Sub
    Dim dvView As DataView
    Private Sub BtnAnnualResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnnualResults.Click
        Cursor = Cursors.WaitCursor
        'Dim t As Thread = New Thread(AddressOf ShowRatios)
        't.Start()
        ShowAnnualResults()
        Cursor = Cursors.Default
    End Sub
    Private Sub DataGridView1_Result_CellValueNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValueEventArgs) Handles DataGridView1_Result.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.Column1.Index Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Dim dtbRatiosResult As DataTable
    Sub ShowAnnualResults()
        '#1. get latest bhaav copy csv file name, say - EQ301110.CSV
        '#2. select the required data from both tables bhaavcopy & latest ratios table
        '#3. Add P/E RATIO Column to the table
        '#4. show the data

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
                 " FROM (([" + Form3_SortedRatios.GetLatestBhaavCopyName() + "] e1 " & _
                 " INNER JOIN [LatestAnnualResults.csv] e2 ON e1.SC_CODE = e2.SC_CODE) " & _
        " INNER JOIN [Companies.csv] e3 ON e1.SC_CODE = e3.Code)  "

        'Next
        'strSql = strSql.Substring(0, strSql.Length - 6)
        '#load the data from CSV to DataTable 
        Dim oleda As OleDbDataAdapter = New OleDbDataAdapter(strSql, CSVCon)
        dtbRatiosResult = New DataTable()
        'strConnection.
        oleda.Fill(dtbRatiosResult)
        System.IO.Directory.SetCurrentDirectory(Application.StartupPath())

        If dtbRatiosResult.Rows.Count = 0 Then
            MsgBox("Data not found ")
            strSql = Nothing
            'Return False
        End If


        'Empty the String 
        strSql = Nothing

        '# Add P/E Ratio Column to dataTable
        'Dim columnPE As DataColumn = New DataColumn("P/E Ratio", GetType(Double))
        '' "CLOSE + '/ ' +adjusted cash eps (rs)"                                                - not Working
        ''"IF(ISERROR([CLOSE]/[adjusted cash eps (rs)]),'NA',[CLOSE]/[adjusted cash eps (rs)])"  - not Working
        ''ROUNDUP([Column1],2)                                                                   - not Working
        'columnPE.Expression = "[CLOSE]/[adjusted cash eps (rs)]"
        'dtbRatiosResult.Columns.Add(columnPE)

        '# Add BookValue/CMP Column to dataTable

        'Dim columnBV As DataColumn = New DataColumn("BookValue/CMP", GetType(Double))
        'columnBV.Expression = "[book value (incl rev res) per share (rs#)]/[CLOSE]"
        'dtbRatiosResult.Columns.Add(columnBV)

        ' [book value (incl rev res) per share (rs.)] more than 1 and [p/e] less than 8 
        'ye dono conditions jo satisfy karte ho wo green me
        'ya BV/price more than 0.8

        '# Create DataView on dtbResult
        dvView = New DataView(dtbRatiosResult)
        DataGridView1_Result.DataSource = dvView
        'SetControlPropertyValue(DataGridView1_Result, "DataSource", dvView)
        ' hide all columns in for loop 3-15 , then display which ever is required
        For i As Int16 = 4 To 15
            DataGridView1_Result.Columns(i).Visible = False
            'SetControlPropertyValue(DataGridView1_Result, "Columns(3).Visible", False)
        Next
        For i As Int16 = 22 To 25
            DataGridView1_Result.Columns(i).Visible = False
            'SetControlPropertyValue(DataGridView1_Result, "Columns(3).Visible", False)
        Next

        DataGridView1_Result.Columns("CLOSE").Visible = True
        DataGridView1_Result.Columns("CLOSE").HeaderText = "CMP"
        DataGridView1_Result.Columns("CLOSE").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        DataGridView1_Result.Columns("Annual").Visible = True
        DataGridView1_Result.Columns("Annual").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        DataGridView1_Result.Columns("e1.SC_CODE").HeaderText = "SC-Code"
        DataGridView1_Result.Columns("e1.SC_CODE").DisplayIndex = 1

        DataGridView1_Result.Columns("SC_NAME").Frozen = True

        ''DataGridView1_Result.Columns("P/E Ratio").DisplayIndex = 16
        ' ''To display upto 2 decimal positions
        ''DataGridView1_Result.Columns("P/E Ratio").DefaultCellStyle.Format = "#,##0.00"
        ''DataGridView1_Result.Columns("P/E Ratio").DefaultCellStyle.ForeColor = Color.Brown
        ''DataGridView1_Result.Columns("P/E Ratio").DefaultCellStyle.BackColor = Color.AliceBlue

        ''DataGridView1_Result.Columns("BookValue/CMP").DisplayIndex = 17
        ' ''To display upto 2 decimal positions
        ''DataGridView1_Result.Columns("BookValue/CMP").DefaultCellStyle.Format = "#,##0.00"

        DataGridView1_Result.Columns("e2.SC_CODE").Visible = False
        DataGridView1_Result.Columns("company").Visible = False
        DataGridView1_Result.Columns("code").Visible = False
        DataGridView1_Result.Columns("index").Visible = False
        DataGridView1_Result.Columns("group").Visible = False
        'DataGridView1_Result.Columns("SC_NAME").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        '# Adding Visual Effects
        'DataGridView1_Result.BackgroundColor = Color.Azure
        'DataGridView1_Result.GridColor = Color.Blue
        'DataGridView1_Result.EnableHeadersVisualStyles = False
        'DataGridView1_Result.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue

        'SetControlPropertyValue(DataGridView1_Result, "Columns('CLOSE').Visible", True)
        'SetControlPropertyValue(DataGridView1_Result, "Columns('CLOSE').HeaderText", "CMP")
        'SetControlPropertyValue(DataGridView1_Result, "Columns('CLOSE').AutoSizeMode", DataGridViewAutoSizeColumnMode.AllCells)
        'SetControlPropertyValue(DataGridView1_Result, "Columns('Ratios').Visible", True)
        'SetControlPropertyValue(DataGridView1_Result, "Columns('Ratios').AutoSizeMode", DataGridViewAutoSizeColumnMode.AllCells)

        'SetControlPropertyValue(DataGridView1_Result, "Columns('e1.SC_CODE').HeaderText", "SC-Code")
        'SetControlPropertyValue(DataGridView1_Result, "Columns('e1.SC_CODE').DisplayIndex", 1)

        'SetControlPropertyValue(DataGridView1_Result, "Columns('SC_NAME').Frozen ", True)
        'SetControlPropertyValue(DataGridView1_Result, "Columns('P/E Ratio').DisplayIndex ", 16)
        'SetControlPropertyValue(DataGridView1_Result, "Columns('P/E Ratio').DefaultCellStyle.Format ", "#,##0.00")
        'SetControlPropertyValue(DataGridView1_Result, "Columns('P/E Ratio').DefaultCellStyle.ForeColor", Color.Brown)
        'SetControlPropertyValue(DataGridView1_Result, "Columns('P/E Ratio').DefaultCellStyle.BackColor", Color.AliceBlue)

        'SetControlPropertyValue(DataGridView1_Result, "Columns('BookValue/CMP').DisplayIndex", 17)
        'SetControlPropertyValue(DataGridView1_Result, "Columns('BookValue/CMP').DefaultCellStyle.Format", "#,##0.00")

        'SetControlPropertyValue(DataGridView1_Result, "Columns('e2.SC_CODE').Visible ", False)


        ComboBox1.Text = "ALL"
        ComboBoxSector.Text = "ALL"
        ComboBoxIndustry.Text = "ALL"
        PanelFilters.Visible = True
        Me.PopulateSectorComboBox()
        Me.PopulateIndustryComboBox()
        Panel1_Results.Visible = True


        'SetControlPropertyValue(Label2, "Visible", True)
        'SetControlPropertyValue(ComboBox1, "Visible", True)
        'SetControlPropertyValue(ComboBox1, "Text", "ALL")
        'SetControlPropertyValue(Panel1_SortedRatios, "Visible", True)



    End Sub

    Private Sub BtnUpdateResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateResults.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'Dim t As Thread = New Thread(AddressOf UpdateLatestResults)
        't.Start()
        UpdateLatestResults()
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MsgBox("Annual Results Updated !!")
    End Sub

    Sub UpdateLatestResults()
        'ProgressBar1.Visible = True
        'ProgressBar1.UseWaitCursor = True
        'ProgressBar1.Show()
        'ProgressBar1.Value = 1

        SetControlPropertyValue(ProgressBar1, "Visible", True)
        SetControlPropertyValue(ProgressBar1, "UseWaitCursor", True)
        SetControlPropertyValue(ProgressBar1, "Value", 1)

        Dim strSql As String
        Dim c As Boolean = True
        Dim ratioOutTable As DataTable
        Dim tableList As DataTable = Form3_SortedRatios.GetTableNamesFromDB(dbResultsFile)
        Dim CSVCon As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & _
                                        "Data Source=" + Application.StartupPath() & dbResultsFile)

        'ProgressBar1.Maximum = 5000
        'ProgressBar1.Minimum = 0

        SetControlPropertyValue(ProgressBar1, "Maximum", 5000)
        SetControlPropertyValue(ProgressBar1, "Minimum", 0)

        CSVCon.Open()
        For Each dr As DataRow In tableList.Rows
            If Not String.Compare(dr("TABLE_TYPE"), "TABLE") Then
                ''ProgressBar1.Increment(1)
                'ProgressBar1.Value += 1
                SetControlPropertyValue(ProgressBar1, "Value", ProgressBar1.Value + 1)

                strSql = "SELECT * FROM " + dr("TABLE_NAME")
                Dim oleda As OleDbDataAdapter = New OleDbDataAdapter(strSql, CSVCon)
                Dim ratioInTable As DataTable = New DataTable()
                'strConnection.
                oleda.Fill(ratioInTable)

                ' Transpose ************
                ratioInTable = Form3_SortedRatios.GenerateTransposedTable(ratioInTable)
                '*************
                Dim adc1 As DataColumn
                adc1 = New DataColumn("SC_CODE", System.Type.GetType("System.String"))
                ratioInTable.Columns.Add(adc1)
                'clone the table once only
                If c Then
                    ratioOutTable = ratioInTable.Clone
                    c = False
                End If

                ratioInTable.Rows.Item(0).Item(adc1) = dr("TABLE_NAME").Remove(6) '+ ",  " + ratioInTable.Rows.Item(0).Item(0).ToString

                'Pick 1st row (March 10) of each Co table(ratioInTable) in the db 
                'and put in new table(ratioOutTable )
                ratioOutTable.ImportRow(ratioInTable.Rows.Item(0))

            End If
        Next
        CSVCon.Close()

        '{
        'Write this datatable as "LatestRatiosTable" to the Database

        '1. if write to mdb database
        'CreateTable("LatestYearRatios", ratioOutTable)
        'FillDBCoTable("LatestYearRatios", ratioOutTable)

        '2. if write to a csv file
        Form3_SortedRatios.DataTable2CSV(ratioOutTable, "LatestAnnualResults.csv", ",")
        '}

        ' ShowAnnualResults()

        'ProgressBar1.Hide()
        'ProgressBar1.Visible = False
        SetControlPropertyValue(ProgressBar1, "Visible", False)
    End Sub
    Public Delegate Sub SetControlValueCallback(ByVal oControl As Control, ByVal propName As String, ByVal propValue As Object)
    Public Sub SetControlPropertyValue(ByVal oControl As Control, ByVal propName As String, ByVal propValue As Object)

        Dim index() As Nullable = Nothing

        If (oControl.InvokeRequired) Then
            Dim d As SetControlValueCallback = New SetControlValueCallback(AddressOf SetControlPropertyValue)
            oControl.Invoke(d, New Object() {oControl, propName, propValue})
        Else
            Dim t As Type = oControl.GetType()
            Dim props As Reflection.PropertyInfo() = t.GetProperties()
            For Each p As Reflection.PropertyInfo In props
                If (p.Name.ToUpper().Equals(propName.ToUpper())) Then
                    p.SetValue(oControl, propValue, index)
                End If
            Next
        End If
    End Sub


    Private Sub BtnDownloadCSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDownloadCSV.Click
        ' When user clicks button, show the dialog.
        With SaveFileDialog1
            .DefaultExt = "csv"
            .FileName = "AnnualResults_" + System.DateTime.Now.ToLongDateString
            .Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .AddExtension = True
            .Title = "Save File Dialog"
            .RestoreDirectory = True
        End With

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Form3_SortedRatios.DataTable2CSV(dtbRatiosResult, SaveFileDialog1.FileName, ",")    '"Ratios_Downloaded.csv", ",")
            MsgBox("Download Completed!! @ path = " + SaveFileDialog1.FileName)
            Console.WriteLine(SaveFileDialog1.FileName)
        End If

    End Sub



    Private Sub Form4Results_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Panel1_Results.Height = Me.Height - 136
        DataGridView1_Result.Height = Panel1_Results.Height - 23
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (Me.ComboBox1.Text <> "ALL") Then
            dvView.RowFilter = "SC_GROUP = ('" & Me.ComboBox1.SelectedItem & "')"
            If Not String.Equals(Me.ComboBoxSector.SelectedItem.ToString.ToLower, "ALL".ToLower) Then
                dvView.RowFilter &= "AND Sector = ('" & Me.ComboBoxSector.SelectedItem.ToString & "')"
            End If
            If Not String.Equals(Me.ComboBoxIndustry.SelectedItem.ToString.ToLower, "ALL".ToLower) Then
                dvView.RowFilter &= "AND Industry = ('" & Me.ComboBoxIndustry.SelectedItem.ToString & "')"
            End If
        End If
    End Sub

    Private Sub ComboBoxSector_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSector.SelectedIndexChanged
        If Not String.Equals(Me.ComboBoxSector.SelectedItem.ToString.ToLower, "ALL".ToLower) Then
            dvView.RowFilter = "Sector = ('" & Me.ComboBoxSector.SelectedItem.ToString & "')"
            If Not String.Equals(Me.ComboBox1.SelectedItem.ToString.ToLower, "ALL".ToLower) Then
                dvView.RowFilter &= "AND SC_GROUP = ('" & Me.ComboBox1.SelectedItem & "')"
            End If
            Me.PopulateIndustryComboBox()
        Else
            If Not String.Equals(Me.ComboBox1.SelectedItem.ToString.ToLower, "ALL".ToLower) Then
                dvView.RowFilter = " SC_GROUP = ('" & Me.ComboBox1.SelectedItem & "')"
            Else
                dvView.RowFilter = DBNull.Value.ToString
            End If
            Me.PopulateIndustryComboBox()
        End If

    End Sub

    Private Sub ComboBoxIndustry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxIndustry.SelectedIndexChanged
        If Not String.Equals(Me.ComboBoxIndustry.SelectedItem.ToString.ToLower, "ALL".ToLower) Then
            dvView.RowFilter = "Industry = ('" & Me.ComboBoxIndustry.SelectedItem.ToString & "')"
            If Not String.Equals(Me.ComboBox1.SelectedItem.ToString.ToLower, "ALL".ToLower) Then
                dvView.RowFilter &= "AND SC_GROUP = ('" & Me.ComboBox1.SelectedItem & "')"
            End If
        Else
            If Not String.Equals(Me.ComboBoxSector.SelectedItem.ToString.ToLower, "ALL".ToLower) Then
                dvView.RowFilter = "Sector = ('" & Me.ComboBoxSector.SelectedItem.ToString & "')"
                If Not String.Equals(Me.ComboBox1.SelectedItem.ToString.ToLower, "ALL".ToLower) Then
                    dvView.RowFilter &= "AND SC_GROUP = ('" & Me.ComboBox1.SelectedItem & "')"
                End If
            Else
                If Not String.Equals(Me.ComboBox1.SelectedItem.ToString.ToLower, "ALL".ToLower) Then
                    dvView.RowFilter = " SC_GROUP = ('" & Me.ComboBox1.SelectedItem & "')"
                Else
                    dvView.RowFilter = DBNull.Value.ToString
                End If
            End If
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
        Me.ComboBoxSector.SelectedIndex = 0
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
        Me.ComboBoxIndustry.SelectedIndex = 0
    End Sub
End Class