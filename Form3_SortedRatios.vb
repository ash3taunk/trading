Imports System.Data
Imports System.Data.OleDb
Imports System.Threading
Imports System.IO
Imports System.Text
'#define MULTI_THREADING

Public Class Form3_SortedRatios

    Sub logFileWrite(ByVal text As String)
        Dim fs As New FileStream("RatiosLogFile.txt", FileMode.Append, FileAccess.Write)
        'declaring a FileStream and creating a word document file named file with
        'access mode of writing
        Dim s As New StreamWriter(fs)
        'creating a new StreamWriter and passing the filestream object fs as argument
        s.BaseStream.Seek(0, SeekOrigin.End)
        'the seek method is used to move the cursor to next position to avoid text to be
        'overwritten
        s.WriteLine(text)
        'writing text to the newly created file
        s.Close()
        'closing the file
    End Sub

    Private Sub Form3_SortedRatios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = False
        Panel1_SortedRatios.Visible = False
        'to generate CellValueNeeded Event , VirtualMode should be true
        DataGridView1_SortedRatios.VirtualMode = True
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'Dim t As Thread = New Thread(AddressOf UpdateLatestRatios)
        't.Start()
        UpdateLatestRatios()
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MsgBox("other Ratios Updated !!")
    End Sub
    Dim builderError As New stringbuilder
    Private Sub UpdateLatestRatios()

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
        Dim tableList As DataTable = GetTableNamesFromDB("\CoTablesDatabase.mdb")
        Dim CSVCon As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & _
                                        "Data Source=" + Application.StartupPath() & "\CoTablesDatabase.mdb")

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
                Try
                    ratioInTable = GenerateTransposedTable(ratioInTable)
                    logFileWrite(dr("TABLE_NAME") + " is updated")
                Catch ex As Exception
                    logFileWrite("error: " + dr("TABLE_NAME") + " is not updated")
                    builderError.Append("error: " + dr("TABLE_NAME") + " is not updated").AppendLine()
                    Continue For
                End Try

                '*************
                Dim adc1 As DataColumn
                adc1 = New DataColumn("SC_CODE", System.Type.GetType("System.String"))
                Try
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
                Catch ex As Exception
                    logFileWrite("error: " + dr("TABLE_NAME") + " is not updated")
                    builderError.Append("error: " + dr("TABLE_NAME") + " is not updated").AppendLine()
                End Try

            End If
        Next
        CSVCon.Close()

        '{
        'Write this datatable as "LatestRatiosTable" to the Database

        '1. if write to mdb database
        'CreateTable("LatestYearRatios", ratioOutTable)
        'FillDBCoTable("LatestYearRatios", ratioOutTable)

        '2. if write to a csv file
        DataTable2CSV(ratioOutTable, "LatestRatiosTable.csv", ",")
        '}

        'ShowRatios()
        MessageBox.Show(builderError.ToString)
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

    Function GetTableNamesFromDB(ByVal dbFilePath As String) As DataTable
        Dim Filename As String = Application.StartupPath() + dbFilePath
        Dim strConnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & _
                             "data source=" + Filename

        Dim objConnection As New OleDbConnection(strConnection)
        Dim dsSchema As DataSet = New DataSet()
        Dim dt As DataTable
        objConnection.Open()
        dt = objConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)

        dsSchema.Tables.Add(dt)
        dt = dsSchema.Tables(0)
        Return dt
    End Function

    Function GenerateTransposedTable(ByVal inputTable As DataTable) As DataTable

        Dim outputTable As DataTable = New DataTable()

        ' Add columns by looping rows

        ' Header row's first column is same as in inputTable
        outputTable.Columns.Add(inputTable.Columns(0).ColumnName.ToString())

        ' Header row's second column onwards, 'inputTable's first column taken
        For Each inRow As DataRow In inputTable.Rows
            Dim newColName As String = inRow(0).ToString()
            Try
                outputTable.Columns.Add(newColName)
            Catch ex As Exception
                logFileWrite(ex.Message)
                Exit Function
            End Try

        Next

        ' Add rows by looping columns
        Dim rCount, cCount As Int16
        For rCount = 1 To (inputTable.Columns.Count - 1) Step 1

            Dim newRow As DataRow = outputTable.NewRow()

            ' First column is inputTable's Header row's second column
            newRow(0) = inputTable.Columns(rCount).ColumnName.ToString()
            For cCount = 0 To inputTable.Rows.Count - 1 Step 1
                Dim colValue As String = inputTable.Rows(cCount)(rCount).ToString()
                newRow(cCount + 1) = colValue
            Next
            outputTable.Rows.Add(newRow)
        Next

        Return outputTable
    End Function

    Function DataTable2CSV(ByVal table As DataTable, ByVal filename As String, ByVal sepChar As String) As Boolean
        Dim writer As System.IO.StreamWriter

        If Not System.IO.Directory.Exists(Application.StartupPath() & "\..\Data") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath() & "\..\Data")
        End If

        Try
            If Not String.IsNullOrEmpty(Path.GetDirectoryName(filename).ToString) Then
                ' If path specified in the string
                writer = New System.IO.StreamWriter(filename)
            Else
                'saving at default path 
                writer = New System.IO.StreamWriter(Application.StartupPath() & "\..\Data\" + filename)
            End If

            ' first write a line with the columns name
            Dim sep As String = ""
            Dim builder As New System.Text.StringBuilder
            For Each col As DataColumn In table.Columns
                builder.Append(sep).Append(col.ColumnName)
                sep = sepChar
            Next
            writer.WriteLine(builder.ToString())

            ' then write all the rows
            For Each row As DataRow In table.Rows
                sep = ""
                builder = New System.Text.StringBuilder

                For Each col As DataColumn In table.Columns
                    'for other columns which are present in data table
                    builder.Append(sep).Append(row(col.ColumnName))
                    sep = sepChar
                Next
                writer.WriteLine(builder.ToString())
            Next
        Finally
            If Not writer Is Nothing Then writer.Close()
        End Try
        Return True
    End Function

    Dim ColumnName(0 To 40) As String
    Function CreateTable(ByVal TableName As String, ByVal dtCoTable As DataTable) As Boolean

        Cursor = Cursors.WaitCursor
        Dim SQL As String
        'If Datatable has data
        'If (dsCoTable.HasChanges) Then
        '    dtCoTable = dsCoTable.Tables(0)
        'Else
        '    ' MessageBox.Show("Data has not been retrieved from the web site !! Try Again Later. ")
        '    Console.WriteLine("Data has not been retrieved from the web site !! Try Again Later. ")
        '    logFileWrite("error:" + TableName + " : Data has not been retrieved from the web site !! Try Again Later.!! ")
        '    Cursor = Cursors.Default
        '    Return False
        'End If
        '2.1 Extract Coulmn Nmae from dsCoTable
        Dim i As Int16 = 0

        Dim dc As DataColumn

        '3 Creating the SQL query to create a new table in my Access database called 'CoTablesDatabase.mdb'.
        SQL = "CREATE TABLE " + TableName + " ([Ratios] TEXT(60), "
        '" [" + ColumnName(1).ToString() + "] Double," & _
        '" [" + ColumnName(2).ToString() + "] Double," & _
        '" [" + ColumnName(3).ToString() + "] Double," & _
        '" [" + ColumnName(4).ToString() + "] Double," & _
        '" [" + ColumnName(5).ToString() + "] Double " & _
        '")"
        i = 0

        For Each dc In dtCoTable.Columns
            ColumnName(i) = dc.ColumnName.ToString()
            ColumnName(i) = ColumnName(i).Replace(" ", "_")
            ColumnName(i) = ColumnName(i).Replace(".", "")
            ColumnName(i) = ColumnName(i).Replace("_(", "(")
            ColumnName(i) = ColumnName(i).Replace(")_", ")")
            ColumnName(i) = ColumnName(i).Replace("per_share", "PS")

            If i <> 0 Then
                SQL &= " [" + ColumnName(i).ToString() + "] Double,"
            End If
            Console.Write(ColumnName(i).ToString() & " " & dc.DataType.ToString() & "\n")
            i += 1
        Next
        SQL = SQL.Substring(0, SQL.Length - 1)
        SQL &= " )"
        'logFileWrite("Total Columns: " + i.ToString)
        Dim Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & _
                                                "Data Source=" + Application.StartupPath() & "\CoTablesDatabase.mdb")
        Dim objCmd As OleDbCommand = New OleDbCommand(SQL, Con)

        '4 Opening the connection to the database, executing the the SQL command/query, and then closing the database connection. 
        Try
            Con.Open()
            objCmd = New OleDbCommand(SQL, Con)
            objCmd.ExecuteNonQuery()
        Catch ex As Exception
            'Comment to continue to Update without asking the user
            'MessageBox.Show(ex.Message + "Click Yes to Update the table", "Already Exist", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Console.WriteLine(ex.Message)
            ' logFileWrite(ex.Message)

            'Emptise the table first , otherwise double entries will be there
            'EmptyTheTable(TableName)
            objCmd = New OleDbCommand("DELETE FROM " + TableName, Con)
            objCmd.ExecuteNonQuery()
            'logFileWrite(TableName + " is Empty now !!")
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
        Cursor = Cursors.Default
        Return True ' Return true if table already exists
    End Function

    Function FillDBCoTable(ByVal TableName As String, ByVal dtCoTable As DataTable) As Boolean
        Cursor = Cursors.WaitCursor
        Dim insertOk As Boolean = True
        Dim Sql As String
        Dim i As Int16

        'If Datatable has data
        'If (dsCoTable.HasChanges) Then
        '    dtCoTable = dsCoTable.Tables(0)
        'Else
        '    Console.WriteLine("Data has not been retrieved from the web site !! Try Again Later. ")
        '    Return False
        'End If

        Dim Con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & _
                                                "Data Source=" + Application.StartupPath() & "\CoTablesDatabase.mdb")


        Try
            Con.Open()
            Sql = Nothing

            'loop
            For Each dr As DataRow In dtCoTable.Rows

                Sql = "INSERT INTO " + TableName + " VALUES ("
                '" @" + ColumnName(0).ToString() + "," & _
                '" @" + ColumnName(1).ToString() + "," & _
                '" @" + ColumnName(2).ToString() + "," & _
                '" @" + ColumnName(3).ToString() + "," & _
                '" @" + ColumnName(4).ToString() + "," & _
                '" @" + ColumnName(5).ToString() + ")"
                i = 0
                For Each dc As DataColumn In dtCoTable.Columns
                    ColumnName(i) = "col" + i.ToString
                    Sql &= " @" + ColumnName(i).ToString() + ","
                    i += 1
                Next
                Sql = Sql.Substring(0, Sql.Length - 1)
                Sql &= " )"

                Dim Cmd As OleDbCommand = New OleDbCommand(Sql, Con)
                'Console.Write("***************" & dr(0).ToString.Equals("-"))
                'Cmd.Parameters.AddWithValue("@" + ColumnName(0).ToString(), IIf(dr(0).ToString.Equals("-"), DBNull.Value, dr(0))) '(Row_i,0)
                'Cmd.Parameters.AddWithValue("@" + ColumnName(1).ToString(), IIf(dr(1).ToString.Equals("-"), DBNull.Value, dr(1))) '(Row_i,1)
                'Cmd.Parameters.AddWithValue("@" + ColumnName(2).ToString(), IIf(dr(2).ToString.Equals("-"), DBNull.Value, dr(2))) '(Row_i,2)
                'Cmd.Parameters.AddWithValue("@" + ColumnName(3).ToString(), IIf(dr(3).ToString.Equals("-"), DBNull.Value, dr(3))) '(Row_i,3)
                'Cmd.Parameters.AddWithValue("@" + ColumnName(4).ToString(), IIf(dr(4).ToString.Equals("-"), DBNull.Value, dr(4))) '(Row_i,4)
                'Cmd.Parameters.AddWithValue("@" + ColumnName(5).ToString(), IIf(dr(5).ToString.Equals("-"), DBNull.Value, dr(5))) '(Row_i,5)
                Dim cellvalue As Double

                Dim j As Integer = 0        'Column number
                For Each dc As DataColumn In dtCoTable.Columns
                    ' Cmd.Parameters.AddWithValue("@" + ColumnName(j).ToString(), IIf(dr(j).ToString.Equals("-"), DBNull.Value, dr(j))) '(Row_i,j)
                    If Not j = 0 Then
                        'For columns of double type .. Check each valu for its double type
                        Cmd.Parameters.AddWithValue("@" + ColumnName(j).ToString(), IIf(Double.TryParse(dr(j).ToString, cellvalue), cellvalue, DBNull.Value)) '(Row_i,j)
                    Else
                        'For columns of String type .. No need to check
                        Cmd.Parameters.AddWithValue("@" + ColumnName(j).ToString(), dr(j).ToString) '(Row_i,j)
                    End If
                    j += 1
                Next

                Cmd.ExecuteNonQuery()
            Next 'loop end
        Catch ex As OleDbException
            MsgBox(ex.Message.ToString + " **while inserting data ")
            'logFileWrite("error: " + ex.Message.ToString + " **while inserting data ")
            insertOk = False
        Finally
            Con.Close()
        End Try

        If insertOk Then
            ' MsgBox("Details Submitted Successfully!")
        Else
            'MsgBox("There was an error saving your data!")
        End If


        ''Display data in a GridView control 
        'GridView1.DataSource = dtbCSV
        'GridView1.DataBind()

        Cursor = Cursors.Default
        Return insertOk
    End Function

    Dim dvView As DataView
    Private Sub BtnShowRatios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowRatios.Click
        Cursor = Cursors.WaitCursor
        'Dim t As Thread = New Thread(AddressOf ShowRatios)
        't.Start()
        ShowRatios()
        Cursor = Cursors.Default
    End Sub

    Dim dtbRatiosResult As DataTable
    Sub ShowRatios()
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
                 " FROM (([" + GetLatestBhaavCopyName() + "] e1 " & _
                 " INNER JOIN [LatestRatiosTable.csv] e2 ON e1.SC_CODE = e2.SC_CODE) " & _
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
        Dim columnPE As DataColumn = New DataColumn("P/E Ratio", GetType(Double))
        ' "CLOSE + '/ ' +adjusted cash eps (rs)"                                                - not Working
        '"IF(ISERROR([CLOSE]/[adjusted cash eps (rs)]),'NA',[CLOSE]/[adjusted cash eps (rs)])"  - not Working
        'ROUNDUP([Column1],2)                                                                   - not Working
        columnPE.Expression = "[CLOSE]/[adjusted cash eps (rs)]"
        dtbRatiosResult.Columns.Add(columnPE)

        '# Add BookValue/CMP Column to dataTable

        Dim columnBV As DataColumn = New DataColumn("BookValue/CMP", GetType(Double))
        columnBV.Expression = "[Book value (incl rev res) per share EPS (Rs)]/[CLOSE]"
        dtbRatiosResult.Columns.Add(columnBV)

        ' [book value (incl rev res) per share (rs.)] more than 1 and [p/e] less than 8 
        'ye dono conditions jo satisfy karte ho wo green me
        'ya BV/price more than 0.8

        '# Create DataView on dtbResult
        dvView = New DataView(dtbRatiosResult)
        DataGridView1_SortedRatios.DataSource = dvView
        'SetControlPropertyValue(DataGridView1_SortedRatios, "DataSource", dvView)
        ' hide all columns in for loop 3-15 , then display which ever is required
        For i As Int16 = 4 To 15
            DataGridView1_SortedRatios.Columns(i).Visible = False
            'SetControlPropertyValue(DataGridView1_SortedRatios, "Columns(3).Visible", False)

        Next

        DataGridView1_SortedRatios.Columns("CLOSE").Visible = True
        DataGridView1_SortedRatios.Columns("CLOSE").HeaderText = "CMP"
        DataGridView1_SortedRatios.Columns("CLOSE").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        DataGridView1_SortedRatios.Columns("Ratios").Visible = True
        DataGridView1_SortedRatios.Columns("Ratios").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        DataGridView1_SortedRatios.Columns("e1.SC_CODE").HeaderText = "SC-Code"
        DataGridView1_SortedRatios.Columns("e1.SC_CODE").DisplayIndex = 1

        DataGridView1_SortedRatios.Columns("SC_NAME").Frozen = True

        DataGridView1_SortedRatios.Columns("P/E Ratio").DisplayIndex = 16
        'To display upto 2 decimal positions
        DataGridView1_SortedRatios.Columns("P/E Ratio").DefaultCellStyle.Format = "#,##0.00"
        DataGridView1_SortedRatios.Columns("P/E Ratio").DefaultCellStyle.ForeColor = Color.Brown
        DataGridView1_SortedRatios.Columns("P/E Ratio").DefaultCellStyle.BackColor = Color.AliceBlue

        DataGridView1_SortedRatios.Columns("BookValue/CMP").DisplayIndex = 17
        'To display upto 2 decimal positions
        DataGridView1_SortedRatios.Columns("BookValue/CMP").DefaultCellStyle.Format = "#,##0.00"

        DataGridView1_SortedRatios.Columns("e2.SC_CODE").Visible = False
        'DataGridView1_SortedRatios.Columns("SC_NAME").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        '# Adding Visual Effects
        'DataGridView1_SortedRatios.BackgroundColor = Color.Azure
        'DataGridView1_SortedRatios.GridColor = Color.Blue
        'DataGridView1_SortedRatios.EnableHeadersVisualStyles = False
        'DataGridView1_SortedRatios.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue

        'SetControlPropertyValue(DataGridView1_SortedRatios, "Columns('CLOSE').Visible", True)
        'SetControlPropertyValue(DataGridView1_SortedRatios, "Columns('CLOSE').HeaderText", "CMP")
        'SetControlPropertyValue(DataGridView1_SortedRatios, "Columns('CLOSE').AutoSizeMode", DataGridViewAutoSizeColumnMode.AllCells)
        'SetControlPropertyValue(DataGridView1_SortedRatios, "Columns('Ratios').Visible", True)
        'SetControlPropertyValue(DataGridView1_SortedRatios, "Columns('Ratios').AutoSizeMode", DataGridViewAutoSizeColumnMode.AllCells)

        'SetControlPropertyValue(DataGridView1_SortedRatios, "Columns('e1.SC_CODE').HeaderText", "SC-Code")
        'SetControlPropertyValue(DataGridView1_SortedRatios, "Columns('e1.SC_CODE').DisplayIndex", 1)

        'SetControlPropertyValue(DataGridView1_SortedRatios, "Columns('SC_NAME').Frozen ", True)
        'SetControlPropertyValue(DataGridView1_SortedRatios, "Columns('P/E Ratio').DisplayIndex ", 16)
        'SetControlPropertyValue(DataGridView1_SortedRatios, "Columns('P/E Ratio').DefaultCellStyle.Format ", "#,##0.00")
        'SetControlPropertyValue(DataGridView1_SortedRatios, "Columns('P/E Ratio').DefaultCellStyle.ForeColor", Color.Brown)
        'SetControlPropertyValue(DataGridView1_SortedRatios, "Columns('P/E Ratio').DefaultCellStyle.BackColor", Color.AliceBlue)

        'SetControlPropertyValue(DataGridView1_SortedRatios, "Columns('BookValue/CMP').DisplayIndex", 17)
        'SetControlPropertyValue(DataGridView1_SortedRatios, "Columns('BookValue/CMP').DefaultCellStyle.Format", "#,##0.00")

        'SetControlPropertyValue(DataGridView1_SortedRatios, "Columns('e2.SC_CODE').Visible ", False)

      
        ComboBox1.Text = "ALL"
        ComboBoxSector.Text = "ALL"
        ComboBoxIndustry.Text = "ALL"
        PanelFilters.Visible = True
        PopulateSectorComboBox()
        PopulateIndustryComboBox()
        Panel1_SortedRatios.Visible = True


        'SetControlPropertyValue(Label2, "Visible", True)
        'SetControlPropertyValue(ComboBox1, "Visible", True)
        'SetControlPropertyValue(ComboBox1, "Text", "ALL")
        'SetControlPropertyValue(Panel1_SortedRatios, "Visible", True)



    End Sub
    Function GetLatestBhaavCopyName() As String
        Dim di As New IO.DirectoryInfo(Application.StartupPath() & "\..\Data")
        Dim dataFiles As IO.FileInfo() = di.GetFiles("EQ*.csv")
        Dim fi As IO.FileInfo
        Dim LatestBCName As String = Nothing
        Dim strOldDate As String
        Dim year, month, day As Int16
        Dim d1, d2 As Date
        'All numeric data types initialize to zero and so a zero date is equivalent to 12/30/1899 12:00:00 AM
        d2 = #12/30/1902 1:30:00 PM#
        Format(d2, "mm/dd/yyyy") 'Always show just the Date
        For Each fi In dataFiles
            'trim "EQ" & "_new.csv"
            'put in one date variable
            'compare with previous date variable

            strOldDate = fi.Name.ToString.Replace("EQ", "")
            strOldDate = strOldDate.Replace("_new.csv", "")
            'strOldDate = .Substring(2, 6)

            year = strOldDate.Substring(4, 2)
            month = strOldDate.Substring(2, 2)
            day = strOldDate.Substring(0, 2)
            d1 = Convert.ToDateTime(month & "/" & day & "/" & year)
            If d1.Date > d2.Date Then
                d2 = d1
            End If
        Next

        LatestBCName = "EQ" + IIf(d2.Day < 10, "0" + d2.Day.ToString, d2.Day.ToString).ToString() + IIf(d2.Month < 10, "0" + d2.Month.ToString, d2.Month.ToString).ToString() + d2.Year.ToString.Substring(2, 2) + "_new.csv"
        Return LatestBCName
    End Function
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
        ComboBoxSector.Items.Clear()
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
            ComboBoxSector.Items.Add(Category)
            ComboRow += 1
        End While

        
        CSVCon.Close()


        ComboBoxSector.Items.Insert(0, ("ALL"))
        ComboBoxSector.SelectedIndex = 0
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
        If String.Equals(ComboBoxSector.Text.Trim, "ALL") Then
            strSQL = "SELECT DISTINCT  [Industry], [Sector] FROM [Companies.csv] ORDER BY [Industry] "
        Else
            strSQL = "SELECT DISTINCT  [Industry], [Sector] FROM [Companies.csv] WHERE ([Sector] = '" & ComboBoxSector.Text.Trim & "') ORDER BY [Industry] "
        End If
        Cmd = New OleDb.OleDbCommand(strSQL, CSVCon)
        CSVCon.Open()
       
        ComboBoxIndustry.Items.Clear()
        Reader = Cmd.ExecuteReader()
        While Reader.Read()
            Category = Reader.Item("Industry").ToString  'READ COLUMN FROM DATABASE

            ComboBoxIndustry.Items.Add(Category)
            ComboRow += 1
        End While
       
        CSVCon.Close()

        ComboBoxIndustry.Items.Insert(0, ("ALL"))
        ComboBoxIndustry.SelectedIndex = 0
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.Text <> "ALL") Then
            dvView.RowFilter = "SC_GROUP = ('" & ComboBox1.SelectedItem & "')"
            If Not String.Equals(ComboBoxSector.SelectedItem.ToString.ToLower, "ALL".ToLower) Then
                dvView.RowFilter &= "AND Sector = ('" & ComboBoxSector.SelectedItem.ToString & "')"
                If Not String.Equals(ComboBoxIndustry.SelectedItem.ToString.ToLower, "ALL".ToLower) Then
                    dvView.RowFilter &= "AND Industry = ('" & ComboBoxIndustry.SelectedItem.ToString & "')"
                End If
            End If
            'If (ComboBox1.Text = "ALL") Then
            'dvView.RowFilter = "SC_GROUP = 'A' OR SC_GROUP = 'B' OR SC_GROUP = 'F' OR SC_GROUP = 'S' OR SC_GROUP = 'T' OR SC_GROUP = 'TS' OR SC_GROUP = 'Z'  "
            'ElseIf (ComboBox1.Text = "A") Then
            '    dvView.RowFilter = "SC_GROUP = 'A'"
            'ElseIf (ComboBox1.Text = "B") Then
            '    dvView.RowFilter = "SC_GROUP = 'B'"
            'ElseIf (ComboBox1.Text = "F") Then
            '    dvView.RowFilter = "SC_GROUP = 'F'"
            'ElseIf (ComboBox1.Text = "S") Then
            '    dvView.RowFilter = "SC_GROUP = 'S'"
            'ElseIf (ComboBox1.Text = "T") Then
            '    dvView.RowFilter = "SC_GROUP = 'T'"
            'ElseIf (ComboBox1.Text = "TS") Then
            '    dvView.RowFilter = "SC_GROUP = 'TS'"
            'ElseIf (ComboBox1.Text = "Z") Then
            '    dvView.RowFilter = "SC_GROUP = 'Z'"
        End If


    End Sub

    'Private Sub DataGridView1_SortedRatios_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DataGridView1_SortedRatios.CellPainting
    '    If Me.DataGridView1_SortedRatios.Columns("P/E Ratio").Index = _
    '           e.ColumnIndex AndAlso e.RowIndex >= 0 Then

    '        Dim newRect As New Rectangle(e.CellBounds.X + 1, e.CellBounds.Y + 1, _
    '            e.CellBounds.Width, e.CellBounds.Height)
    '        Dim backColorBrush As New SolidBrush(e.CellStyle.BackColor)
    '        Dim gridBrush As New SolidBrush(Me.DataGridView1_SortedRatios.GridColor)
    '        Dim gridLinePen As New Pen(gridBrush)

    '        Try

    '            ' Erase the cell.
    '            If (e.Value IsNot Nothing) Then
    '                If e.Value > 0 And e.Value < 8 Then
    '                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds)
    '                End If
    '            End If

    '            ' Draw the grid lines (only the right and bottom lines;
    '            ' DataGridView takes care of the others).
    '            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, _
    '                e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, _
    '                e.CellBounds.Bottom - 1)
    '            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, _
    '                e.CellBounds.Top, e.CellBounds.Right - 1, _
    '                e.CellBounds.Bottom)

    '            ' Draw the inset highlight box.
    '            e.Graphics.DrawRectangle(Pens.Blue, newRect)

    '            ' Draw the text content of the cell, ignoring alignment.
    '            If (e.Value IsNot Nothing) Then
    '                If e.Value > 0 And e.Value < 8 Then
    '                    e.Graphics.DrawString(CStr(e.Value), e.CellStyle.Font, _
    '                    Brushes.Green, e.CellBounds.X + 2, e.CellBounds.Y + 2, _
    '                    StringFormat.GenericDefault)
    '                End If
    '            End If
    '            e.Handled = True

    '        Finally
    '            gridLinePen.Dispose()
    '            gridBrush.Dispose()
    '            backColorBrush.Dispose()
    '        End Try

    '    End If
    'End Sub


    Private Sub DataGridView1_SortedRatios_CellValueNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValueEventArgs) Handles DataGridView1_SortedRatios.CellValueNeeded
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = Me.Column1.Index Then
            e.Value = e.RowIndex + 1
        End If

    End Sub


    Private Sub ComboBoxSector_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxSector.SelectedIndexChanged
        If Not String.Equals(ComboBoxSector.SelectedItem.ToString.ToLower, "ALL".ToLower) Then
            dvView.RowFilter = "Sector = ('" & ComboBoxSector.SelectedItem.ToString & "')"
            If Not String.Equals(ComboBox1.SelectedItem.ToString.ToLower, "ALL".ToLower) Then
                dvView.RowFilter &= "AND SC_GROUP = ('" & ComboBox1.SelectedItem & "')"
            End If
            PopulateIndustryComboBox()
        Else
            If Not String.Equals(ComboBox1.SelectedItem.ToString.ToLower, "ALL".ToLower) Then
                dvView.RowFilter = " SC_GROUP = ('" & ComboBox1.SelectedItem & "')"
            Else
                dvView.RowFilter = DBNull.Value.ToString
            End If
            PopulateIndustryComboBox()
        End If

    End Sub

    Private Sub ComboBoxIndustry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxIndustry.SelectedIndexChanged
        If Not String.Equals(ComboBoxIndustry.SelectedItem.ToString.ToLower, "ALL".ToLower) Then
            dvView.RowFilter = "Industry = ('" & ComboBoxIndustry.SelectedItem.ToString & "')"
            If Not String.Equals(ComboBox1.SelectedItem.ToString.ToLower, "ALL".ToLower) Then
                dvView.RowFilter &= "AND SC_GROUP = ('" & ComboBox1.SelectedItem & "')"
            End If
        Else
            If Not String.Equals(ComboBoxSector.SelectedItem.ToString.ToLower, "ALL".ToLower) Then
                dvView.RowFilter = "Sector = ('" & ComboBoxSector.SelectedItem.ToString & "')"
                If Not String.Equals(ComboBox1.SelectedItem.ToString.ToLower, "ALL".ToLower) Then
                    dvView.RowFilter &= "AND SC_GROUP = ('" & ComboBox1.SelectedItem & "')"
                End If
            Else
                If Not String.Equals(ComboBox1.SelectedItem.ToString.ToLower, "ALL".ToLower) Then
                    dvView.RowFilter = " SC_GROUP = ('" & ComboBox1.SelectedItem & "')"
                Else
                    dvView.RowFilter = DBNull.Value.ToString
                End If
            End If
        End If

    End Sub

  
    Private Sub BtnDownloadCSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDownloadCSV.Click
        ' When user clicks button, show the dialog.
        With SaveFileDialog1
            .DefaultExt = "csv"
            .FileName = "Ratios_" + System.DateTime.Now.ToLongDateString
            .Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .AddExtension = True
            .Title = "Save File Dialog"
            .RestoreDirectory = True
        End With

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            DataTable2CSV(dtbRatiosResult, SaveFileDialog1.FileName, ",")    '"Ratios_Downloaded.csv", ",")
            MsgBox("Download Completed!! @ path = " + SaveFileDialog1.FileName)
            Console.WriteLine(SaveFileDialog1.FileName)
        End If
        
    End Sub


    Private Sub Form3_SortedRatios_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Panel1_SortedRatios.Height = Me.Height - 136
        DataGridView1_SortedRatios.Height = Panel1_SortedRatios.Height - 23
    End Sub

    '## Has same effect as Resize Event ##
    'Private Sub Form3_SortedRatios_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    Panel1_SortedRatios.Height = Me.Height - 100
    '    DataGridView1_SortedRatios.Height = Panel1_SortedRatios.Height - 20
    'End Sub
 
 
End Class