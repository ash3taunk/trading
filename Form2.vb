Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Net
Imports System.Data
Imports System.Data.OleDb
Imports System.IO


Public Class Form2
    Enum ESyncType
        RATIOS = 1
        ANNUALRESULTS
    End Enum
    Dim gvTemp As DataGridView = New DataGridView
    Dim dtACL As DataTable = New DataTable     'ACL - All Compnay Profile WebLinks Table
    Dim ColumnName(0 To 5) As String        ' Declares ans initialise the array of strings
    Dim SQL As String
    Dim i As Long
    Dim SyncType As Int16 = 1

    '****** VAriables declaration for # Ratios Sync Downloading ****
    Dim objCmd As OleDbCommand
    Dim dsCoTable As DataSet = New DataSet
    '1 load the data from accdb(databse file)
    Dim DBFilePath As String = Application.StartupPath() + "\CoTablesDatabase.mdb"
    '2 creating the MS Access database connection.
    Dim Con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DBFilePath + ";")

    '****** VAriables declaration for # Annual-Results Sync Downloading ****
    Dim objCmdAnnualResults As OleDbCommand
    Dim dsCoTableAnnualResults As DataSet = New DataSet
    '1 load the data from accdb(databse file)
    Dim DBFilePathAnnualResults As String = Application.StartupPath() + "\..\Data\CoAnnualResultsTablesDatabase.mdb"
    '2 creating the MS Access database connection.
    Dim ConAnnualResults = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DBFilePathAnnualResults + ";")

    '#########################
    '### These functions avail you to set controls property of other thread ######
    '#########################
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

    Sub logFileWrite(ByVal text As String)
        Dim fs As New FileStream("LogFile.txt", FileMode.Append, FileAccess.Write)
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
    Function LoadSectorsList()
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
        CheckedListBox1.Items.Clear()
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
            CheckedListBox1.Items.Add(Category)
            ComboRow += 1
        End While

        CSVCon.Close()

    End Function
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BackColor = Color.WhiteSmoke
        Cursor = Cursors.WaitCursor
        ''##Convert ACL-HtmlPage to ACL data table: dtACL
        'Dim strACLPageLink As String = Application.StartupPath() + "\Indian stock markets  BSE Listed companies.htm"
        'Dim HTML As String = GetHTML(strACLPageLink)

        '' to get  ACL table , tag = "html",which is Default tag: on the first line of every web page.
        ''return the html code containing the first table data of the web page
        'HTML = RefineHTML(HTML, "<table class=")
        'dtACL = (ConvertHTMLTablesToDataSet(HTML)).Tables(0)
        'Form3_SortedRatios.DataTable2CSV(dtACL, "ACL.csv", ",")

        ''##Taking data from companies stored in CSV database  of All Company List (ACL)
        Dim CSVCon As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath() & "\..\Data\" + ";Extended Properties=Text")
        Dim strSql As String = Nothing
        strSql = " SELECT * " & _
                 " FROM [ACL.csv] "

        Dim oleda As OleDbDataAdapter = New OleDbDataAdapter(strSql, CSVCon)
        'strConnection.
        oleda.Fill(dtACL)


        'Show the dtACL
        'gvTemp.DataSource = dtACL
        'pnlGridViews.Controls.Add(gvTemp)
        'gvTemp.Dock = DockStyle.Fill


        Cursor = Cursors.Default
    End Sub
    '*********************************************************
    '       Click it to Sync All Companies RATIOS data in 1 Go    **********
    '*********************************************************   
    Private Sub btnSyncAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSyncAll.Click
        SyncType = ESyncType.RATIOS '1 'represents Ratios Page
        ' Empty the Log file here
        If System.IO.File.Exists("LogFile.txt") = True Then
            System.IO.File.Delete("LogFile.txt")
        End If

        logFileWrite("***************************  Sync Started ********************")
        logFileWrite("Time Started : " + Date.Now)
        Cursor = Cursors.WaitCursor
        Dim strURL As String
        Dim HTML As String
        Dim TableName As String
        Dim Iteration As Int16 = 0

        For Each dr As DataRow In dtACL.Rows
            'If Iteration >= 3 Then
            '    GoTo END_FUNCTION
            'End If
            Iteration += 1

            'strURL = "C:\Documents and Settings\User\Desktop\Astitatva\Web Crawler\Web Spider\Site Samle\ratio\ratio.htm"
            strURL = dr("Company")

            strURL = strURL + "/ratio"
            TableName = dr("Code")

            ' Here internet will be used 
            HTML = GetHTML(strURL)
            ' to get  Ratios table , tag = "<h2>Ratios</h2>"
            If Not HTML.Equals("False") Then
                HTML = RefineHTML(HTML, "<h2>Ratios</h2>")
            Else
                Continue For   ' To check for next company.
            End If

            If 1 Then
                '(dsCoTable.HasChanges) Then
                dsCoTable = ConvertHTMLTablesToDataSet(HTML)
                'Just for Ratios table
                dsCoTable.Tables(0).Columns(0).ColumnName = "RATIOS"
            End If


            'Dim Grid As DataGridView = New DataGridView
            'gvTemp.Visible = False

            '' Create a GridView for each DataTable  
            'For Each Data As DataTable In dsCoTable.Tables
            '    'Grid = New DataGridView
            '    Grid.DataSource = Data
            '    'Grid.Refresh()
            '    'Grid.DataBind()
            '    pnlGridViews.Controls.Add(Grid)
            '    Grid.Dock = DockStyle.Fill
            'Next
            Console.Write("no of tables: " + i.ToString)

            '****************************************************
            TableName = TableName.ToString.Trim + "_Table"   'TODO: TableName: "Company SC_CODE" + "_Table"
            '1. Create MSAccess table in CoTablesDatabase.mdb with same coulmn name as dsCoTable
            If CreateTable(TableName) Then
                '2. Fill data from dsCoTabel to AccessTable
                If FillDBCoTable(TableName) Then
                    logFileWrite(TableName + " is Updated Successfully!!")
                Else
                    logFileWrite("error:" + TableName + " is not Updated Completeley!!")
                End If
            Else
                logFileWrite("error:" + TableName + " is not Created !!")
            End If
            '3. Show data
        Next
        'END_FUNCTION:
        logFileWrite("Time Ended : " + Date.Now)
        MsgBox("Done!!!")
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnShowTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowTable.Click
        Cursor = Cursors.WaitCursor

        pnlGridViews.Visible = True

        Dim strURL As String = "C:\Documents and Settings\User\Desktop\Astitatva\Web Crawler\Web Spider\Site Samle\ratio\ratio.htm"

        ' Get some HTML (you can replace this test data with your real HTML)  
        Dim HTML As String = GetHTML(strURL)

        ' to get  Ratios table , tag = "<h2>Ratios</h2>"
        HTML = RefineHTML(HTML, "<h2>Ratios</h2>")

        dsCoTable = ConvertHTMLTablesToDataSet(HTML)

        'Just for Ratios table
        dsCoTable.Tables(0).Columns(0).ColumnName = "RATIOS"
        Dim Grid As DataGridView = New DataGridView
        gvTemp.Visible = False

        ' Create a GridView for each DataTable  
        For Each Data As DataTable In dsCoTable.Tables
            'Grid = New DataGridView
            Grid.DataSource = Data
            'Grid.Refresh()
            'Grid.DataBind()
            pnlGridViews.Controls.Add(Grid)
            Grid.Dock = DockStyle.Fill
        Next

        Cursor = Cursors.Default
        Console.Write("no of tables: " + i.ToString)
    End Sub
    Private Function GetHTML(ByVal strURL As String) As String

        '*************               *************
        '************** 1st Method ****************
        '*************              *************
        'Dim wc As New System.Net.WebClient()
        'Dim s As System.IO.Stream
        'Dim sr As System.IO.StreamReader

        's = wc.OpenRead("http://www.google.com/finance?q=NASDAQ%3ACSCO")

        ''read in the page
        'sr = New System.IO.StreamReader(s)
        'TextBox1.Text = sr.ReadToEnd()

        ''--tidy up
        'sr.Close()
        's.Close()


        '*************               *************
        '************** 2nd Method ****************
        '*************               *************
        'STEP 1: Create a WebClient instance
        Dim objWebClient As New Net.WebClient()
        Dim tempStr As String = Nothing
        'STEP 2 and 3

        If TxtLink.Text <> Nothing Then
            strURL = TxtLink.Text.ToString
        End If

        Dim objUTF8 As New UTF8Encoding()
        Try
            'Using Internet here
            Dim HTML As String = objUTF8.GetString(objWebClient.DownloadData(strURL))
            tempStr = HTML.ToString



        Catch e As WebException
            MsgBox(e.Message + ". Connection to the Server failed. or Site is Blocked.")
            ' Insert code here to handle for 
            '404 not found, host not found, unable to resolve the host etc.
            If e.Status = WebExceptionStatus.ProtocolError Then
                MsgBox("Status Code : {0}" + ". Connection to the Server failed. or Site is Blocked.", CType(e.Response, HttpWebResponse).StatusCode)
                MsgBox("Status Description : {0}" + ". Connection to the Server failed. or Site is Blocked.", CType(e.Response, HttpWebResponse).StatusDescription)
            End If

            Return False
        Catch e As Exception
            MsgBox(e.Message)
            Return False

        End Try
        '  Response.Write(" html table code: " + HTML.Substring(i))
        Return tempStr.ToString

    End Function
    '***********************************************
    '       Refine the Html code to get only table related data    **********
    '***********************************************   
    Private Function RefineHTML(ByVal HTML As String, Optional ByVal tag As String = "html") As String

        '### Algorithm ###
        '   noOfTables, 
        '   stringbuilder =null
        '   loop 0 -> noOfTables
        '       get html code of the selected table
        '       stringbuilder. add (htmlCodeForSelectedTable)
        '       staringPOint = EndPOint
        '   Next
        '
        HTML = HTML.ToLower
        tag = tag.ToLower
        Dim strRefinedHTML As String = Nothing
        Dim noOfTAbles, startPoint, endPoint As Int16
        Dim htmlBuilder As New StringBuilder

        If TxtTableName.Text <> Nothing Then
            tag = TxtTableName.Text.ToString
        End If

        i = HTML.IndexOf(tag)           'Starting Point
        strRefinedHTML = HTML.Substring(i)

        'For i As Int16 = 1 To noOfTAbles
        '    '       get html code of the selected table

        '    '       stringbuilder. add (htmlCodeForSelectedTable)
        '    '       staringPOint = EndPOint
        'Next
        'End Point will be diffrent for number of tables required from the html page
        'for RATIOS ,           Number of Tables = 1
        'for ANNUAL RESULTS ,   Number of Tables = 2
        Select Case SyncType
            Case ESyncType.RATIOS
                noOfTAbles = 1
                i = strRefinedHTML.IndexOf("</table>")  'End Point for Ratios(noOfTables =1)
                strRefinedHTML = strRefinedHTML.Substring(0, i)     ' End Point Index passed as length of Substring
                strRefinedHTML += "</table>"
            Case ESyncType.ANNUALRESULTS
                noOfTAbles = 2
                i = strRefinedHTML.IndexOf("rightcontainer") 'End Point for AnnualResults (noOfTables =2)
                strRefinedHTML = strRefinedHTML.Substring(0, i)     ' End Point Index passed as length of Substring
                'strRefinedHTML += "</table>"
            Case Else
                'WriteLine("Invalid. Please select 1, 2, or 3.")
        End Select

        Txttemp.Text = strRefinedHTML.ToString
        Return strRefinedHTML
    End Function

    Private Function ConvertHTMLTablesToDataSet(ByVal HTML As String) As DataSet
        ' Declarations  
        Dim ds As New DataSet
        Dim dt As DataTable
        Dim dr As DataRow
        Dim dc As DataColumn
        Dim TableExpression As String = "<table[^>]*>(.*?)</table>"
        Dim HeaderExpression As String = "<th[^>]*>(.*?)</th>"
        Dim HeadExpression As String = "<thead[^>]*>(.*?)</thead>"
        Dim RowExpression As String = "<tr[^>]*>(.*?)</tr>"
        Dim ColumnExpression As String = "<td[^>]*>(.*?)</td>"
        'regex for link is: <a\s+([^>]*)href="(https?://([^"]*))"\s+([^>]*)target="_parent"(.*?)>(.*?)</a>
        Dim LinkExpression As String = "<a\s+([^>]*)href=""(https?://([^""]*))""\s+([^>]*)target=""_parent""(.*?)>(.*?)</a>"
        Dim HeadersExist As Boolean = False
        Dim iCurrentColumn As Integer = 0
        Dim iCurrentRow As Integer = 0
        Dim dummy As Int16
        Dim tempstr As String
        ' Get a match for all the tables in the HTML  
        Dim Tables As MatchCollection = Regex.Matches(HTML, TableExpression, RegexOptions.Multiline Or RegexOptions.Singleline Or RegexOptions.IgnoreCase)
        i = 0
        ' Loop through each table element  
        For Each Table As Match In Tables
            i += 1
            ' Reset the current row counter and the header flag  
            iCurrentRow = 0
            HeadersExist = False

            ' Add a new table to the DataSet  
            dt = New DataTable

            ' Create the relevant amount of columns for this table (use the headers if they exist, otherwise use default names)  
            If Table.Value.Contains("<th") Then
                ' Set the HeadersExist flag  
                HeadersExist = True

                'Convert <td> to <th> in side <thead> tag
                Dim Heads As MatchCollection = Regex.Matches(Table.Value, HeadExpression, RegexOptions.Multiline Or RegexOptions.Singleline Or RegexOptions.IgnoreCase)

                Dim Head As String = Regex.Replace(Heads.Item(0).Value, "td", "th")
                ' Remove the <thead> tags from string Head, as it creates ambguity <th> for 1st column
                Head = Regex.Replace(Head, "thead", "")
                ' Get a match for all the headers(Coulumns) in the table  
                Dim Headers As MatchCollection = Regex.Matches(Head, HeaderExpression, RegexOptions.Multiline Or RegexOptions.Singleline Or RegexOptions.IgnoreCase)

                ' Loop through each header element  
                For Each Header As Match In Headers
                    dt.Columns.Add(Header.Groups(1).ToString)
                Next
            Else
                For iColumns As Integer = 1 To Regex.Matches(Regex.Matches(Regex.Matches(Table.Value, TableExpression, RegexOptions.Multiline Or RegexOptions.Singleline Or RegexOptions.IgnoreCase).Item(0).ToString, RowExpression, RegexOptions.Multiline Or RegexOptions.Singleline Or RegexOptions.IgnoreCase).Item(0).ToString, ColumnExpression, RegexOptions.Multiline Or RegexOptions.Singleline Or RegexOptions.IgnoreCase).Count
                    dt.Columns.Add("Column " & iColumns)
                Next
            End If

            ' Get a match for all the rows in the table  
            Dim Rows As MatchCollection = Regex.Matches(Table.Value, RowExpression, RegexOptions.Multiline Or RegexOptions.Singleline Or RegexOptions.IgnoreCase)

            ' Loop through each row element  
            For Each Row As Match In Rows

                ' Only loop through the row if it isn't a header row  
                If Not (iCurrentRow = 0 And HeadersExist = True) Then

                    ' Create a new row and reset the current column counter  
                    dr = dt.NewRow
                    iCurrentColumn = 0

                    ' Get a match for all the columns in the row  
                    Dim Columns As MatchCollection = Regex.Matches(Row.Value, ColumnExpression, RegexOptions.Multiline Or RegexOptions.Singleline Or RegexOptions.IgnoreCase)

                    ' Loop through each column element  
                    For Each Column As Match In Columns
                        If Column.Value.Contains("<h3") Then
                            GoTo NextRow
                            'leave the row, go for next row
                        End If
                        ' If item contains link, then take only link 
                        Dim strplaintext As String = Column.Groups(1).ToString
                        If Column.Value.Contains("<a href") Then
                            Dim plaintext As MatchCollection = Regex.Matches(Column.Groups(1).ToString, LinkExpression, RegexOptions.Multiline Or RegexOptions.Singleline Or RegexOptions.IgnoreCase)
                            strplaintext = plaintext.Item(0).Groups(2).ToString     'to get LINK
                            'strplaintext = plaintext.Item(0).Groups(6).ToString    'to get Name
                        End If

                        dr(iCurrentColumn) = strplaintext 'Column.Groups(1).ToString

                        ' Increase the current column  
                        iCurrentColumn += 1
                    Next

                    ' Add the DataRow to the DataTable  
                    dt.Rows.Add(dr)

                End If

                ' Increase the current row counter  
                iCurrentRow += 1
NextRow:
            Next

            ' Add the DataTable to the DataSet  
            ds.Tables.Add(dt)

        Next

        Return (ds)

    End Function


    Private Sub TxtTableName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTableName.TextChanged
        'pnlGridViews.Visible = False
        dsCoTable.Clear()
        Txttemp.Text = Nothing
    End Sub

    Private Sub txtCoCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCoCode.KeyPress

    End Sub
    '***********************************************
    '       Create new Table Button Click    **********
    '***********************************************   
    Private Sub BtnCreateCoTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreateCoTable.Click
        Dim TableName As String  'TODO: TableName: "Company SC_CODE" + "_Table"
        If (txtCoCode.Text < "500000" Or txtCoCode.Text > "599999") Then
            MessageBox.Show("Please Enter valid Sc_Code !!")
            Return
        End If

        TableName = txtCoCode.Text.Trim + "_Table"
        '1. Create MSAccess table in CoTablesDatabase.mdb with same coulmn name as dsCoTable
        If CreateTable(TableName) Then
            '2. Fill data from dsCoTabel to AccessTable
            If FillDBCoTable(TableName) Then
                MsgBox("Done!!!")
            End If
        End If

        '3. Show data
    End Sub
    '*************************************
    '       Create new Table         *****
    '*************************************
    Function CreateTable(ByVal TableName As String) As Boolean

        'Cursor = Cursors.WaitCursor
        Dim dtCoTable As DataTable
        Select Case SyncType
            Case ESyncType.RATIOS   '<ratios>
                'If Datatable has data
                If (dsCoTable.HasChanges) Then
                    dtCoTable = dsCoTable.Tables(0)
                Else
                    Console.WriteLine("Data has not been retrieved from the web site !! Try Again Later. ")
                    logFileWrite("error:" + TableName + " : Data has not been retrieved from the web site !! Try Again Later.!! ")
                    'Cursor = Cursors.Default
                    Return False
                End If
            Case ESyncType.ANNUALRESULTS    '<Annual-results>
                'If Datatable has data
                If (dsCoTableAnnualResults.HasChanges) Then
                    dtCoTable = dsCoTableAnnualResults.Tables(0)
                Else
                    Console.WriteLine("Data has not been retrieved from the web site !! Try Again Later. ")
                    logFileWrite("error:" + TableName + " : Data has not been retrieved from the web site !! Try Again Later.!! ")
                    'Cursor = Cursors.Default
                    Return False
                End If
        End Select

        '2.1 Extract Coulmn Nmae from dsCoTable
        Dim i As Int16 = 0
        Dim dc As DataColumn

        '3 Creating the SQL query to create a new table in my Access database called 'CoTablesDatabase.mdb'.
        Select Case SyncType
            Case ESyncType.RATIOS   '<ratios>
                SQL = "CREATE TABLE " + TableName + " ([Ratios] TEXT(60), "
            Case ESyncType.ANNUALRESULTS   '<Annual-results>
                SQL = "CREATE TABLE " + TableName + " ([Annual] TEXT(60), "
        End Select
        '" [" + ColumnName(1).ToString() + "] Double," & _
        '" [" + ColumnName(2).ToString() + "] Double," & _
        '" [" + ColumnName(3).ToString() + "] Double," & _
        '" [" + ColumnName(4).ToString() + "] Double," & _
        '" [" + ColumnName(5).ToString() + "] Double " & _
        '")"

        i = 0
        For Each dc In dtCoTable.Columns
            ColumnName(i) = dc.ColumnName.ToString()
            ColumnName(i) = ColumnName(i).Replace(" ' ", "_")
            If i <> 0 Then
                SQL &= " [" + ColumnName(i).ToString() + "] Double,"
            End If
            Console.Write(ColumnName(i).ToString() & " " & dc.DataType.ToString() & "\n")
            i += 1
        Next
        SQL = SQL.Substring(0, SQL.Length - 1)
        SQL &= " )"
        logFileWrite("Total Columns: " + i.ToString)

        If (i = 1) Then ' only feild names are present, no values are ppresent
            Return False
        End If

        '4 Opening the connection to the database, executing the the SQL command/query, and then closing the database connection. 
        Try
            Select Case SyncType
                Case ESyncType.RATIOS   '<ratios>
                    If Con.State = ConnectionState.Closed Then
                        Con.Open()
                    End If
                    objCmd = New OleDbCommand(SQL, Con)
                Case ESyncType.ANNUALRESULTS   '<Annual-results>
                    If ConAnnualResults.State = ConnectionState.Closed Then
                        ConAnnualResults.Open()
                    End If
                    objCmd = New OleDbCommand(SQL, ConAnnualResults)
            End Select
            objCmd.ExecuteNonQuery()
        Catch ex As Exception
            'Comment to continue to Update without asking the user
            'MessageBox.Show(ex.Message + "Click Yes to Update the table", "Already Exist", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Console.WriteLine(ex.Message)
            logFileWrite(ex.Message)

            'Emptise the table first , otherwise double entries will be there
            'EmptyTheTable(TableName)
            Select Case SyncType
                Case ESyncType.RATIOS   '<ratios>
                    objCmd = New OleDbCommand("DROP TABLE " + TableName, Con)
                Case ESyncType.ANNUALRESULTS   '<Annual-results>
                    objCmd = New OleDbCommand("DROP TABLE " + TableName, ConAnnualResults)
            End Select
            objCmd.ExecuteNonQuery()
            logFileWrite(TableName + " is Empty now !!")
            '#Bug - 08162011
            '### If the table is already present then delete the whole table , then again create the table with new column names..
            CreateTable(TableName)  ' will be called only in case of exception
        Finally
            '<ratios>
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
            '<Annual-results>
            If ConAnnualResults.State = ConnectionState.Open Then
                ConAnnualResults.Close()
            End If
        End Try
        'Cursor = Cursors.Default
        Return True ' Return true if table already exists
    End Function

    Function EmptyTheTable(ByVal TableName As String) As Boolean
        '4 Opening the connection to the database, executing the the SQL command/query, and then closing the database connection. 
        Try
            '<ratios>
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            '<Annual-results>
            If ConAnnualResults.State = ConnectionState.Closed Then
                ConAnnualResults.Open()
            End If
            Select Case SyncType
                Case ESyncType.RATIOS   '<ratios>
                    objCmd = New OleDbCommand("DELETE FROM " + TableName, Con)
                Case ESyncType.ANNUALRESULTS   '<Annual-results>
                    objCmd = New OleDbCommand("DELETE FROM " + TableName, ConAnnualResults)
            End Select
            objCmd.ExecuteNonQuery()
        Catch ex As Exception
            logFileWrite("error: Failed to empty the " + TableName + " !!")
            Return False
        Finally
            '<ratios>
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
            '<Annual-results>
            If ConAnnualResults.State = ConnectionState.Open Then
                ConAnnualResults.Close()
            End If
        End Try
        logFileWrite(TableName + " is Empty now !!")
        Return True
    End Function
    '***************************************************************************************
    '       Copy data from dtCoTable dataTable to new empty TABLE of database                  ********
    '***************************************************************************************
    Function FillDBCoTable(ByVal TableName As String) As Boolean
        'Cursor = Cursors.WaitCursor
        Dim insertOk As Boolean = True
        Dim dtCoTable As DataTable
        Dim noOfTables As Int16
        Select Case SyncType
            Case ESyncType.RATIOS   '<ratios>
                noOfTables = 1
            Case ESyncType.ANNUALRESULTS   '<Annual-results>
                noOfTables = 2
        End Select

        For n As Int16 = 1 To noOfTables Step +1       '##Assuming both tables has same columns
            'If Datatable has data
            Select Case SyncType
                Case ESyncType.RATIOS   '<ratios>
                    If (dsCoTable.HasChanges) Then
                        dtCoTable = dsCoTable.Tables(n - 1)
                    Else
                        Console.WriteLine("Data has not been retrieved from the web site !! Try Again Later. ")
                        Return False
                    End If
                Case ESyncType.ANNUALRESULTS   '<Annual-results>
                    If (dsCoTableAnnualResults.HasChanges) Then
                        dtCoTable = dsCoTableAnnualResults.Tables(n - 1)
                    Else
                        Console.WriteLine("Data has not been retrieved from the web site !! Try Again Later. ")
                        Return False
                    End If
            End Select


            '  Dim sqlcon As OleDbConnection = New OleDbConnection("Data Source=C:\Debug\Data.mdb; Provider=Microsoft.Jet.OLEDB.4.0; User ID=Admin")
            Try
                Select Case SyncType
                    Case ESyncType.RATIOS   '<ratios>
                        Con.Open()
                    Case ESyncType.ANNUALRESULTS   '<Annual-results>
                        ConAnnualResults.Open()
                End Select
                SQL = Nothing

                'loop
                For Each dr As DataRow In dtCoTable.Rows
                    SQL = "INSERT INTO " + TableName + " VALUES ("
                    '" @" + ColumnName(0).ToString() + "," & _
                    '" @" + ColumnName(1).ToString() + "," & _
                    '" @" + ColumnName(2).ToString() + "," & _
                    '" @" + ColumnName(3).ToString() + "," & _
                    '" @" + ColumnName(4).ToString() + "," & _
                    '" @" + ColumnName(5).ToString() + ")"
                    i = 0
                    For Each dc As DataColumn In dtCoTable.Columns
                        SQL &= " @" + ColumnName(i).ToString() + ","
                        i += 1
                    Next
                    SQL = SQL.Substring(0, SQL.Length - 1)
                    SQL &= " )"
                    Select Case SyncType
                        Case ESyncType.RATIOS   '<ratios>
                            objCmd = New OleDbCommand(SQL, Con)
                        Case ESyncType.ANNUALRESULTS   '<Annual-results>
                            objCmd = New OleDbCommand(SQL, ConAnnualResults)
                    End Select
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
                            objCmd.Parameters.AddWithValue("@" + ColumnName(j).ToString(), IIf(Double.TryParse(dr(j).ToString, cellvalue), cellvalue, DBNull.Value)) '(Row_i,j)
                        Else
                            'For columns of String type .. No need to check
                            objCmd.Parameters.AddWithValue("@" + ColumnName(j).ToString(), dr(j).ToString) '(Row_i,j)
                        End If
                        j += 1
                    Next
                    objCmd.ExecuteNonQuery()
                Next 'loop end
            Catch ex As OleDbException
                'MsgBox(ex.Message.ToString + " **while inserting data ")
                logFileWrite("error: " + ex.Message.ToString + " **while inserting data ")
                insertOk = False
            Finally
                '<ratios>
                If Con.State = ConnectionState.Open Then
                    Con.Close()
                End If
                '<Annual-results>
                If ConAnnualResults.State = ConnectionState.Open Then
                    ConAnnualResults.Close()
                End If
            End Try
        Next
        If insertOk Then
            ' MsgBox("Details Submitted Successfully!")
        Else
            'MsgBox("There was an error saving your data!")
        End If


        ''Display data in a GridView control 
        'GridView1.DataSource = dtbCSV
        'GridView1.DataBind()

        'Cursor = Cursors.Default
        Return insertOk
    End Function

    Private Sub BtnSyncResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSyncResults.Click
        SyncType = ESyncType.ANNUALRESULTS '2    'Represents Annual Result page
        ' Empty the Log file here
        If System.IO.File.Exists("LogFile.txt") = True Then
            System.IO.File.Delete("LogFile.txt")
        End If

        logFileWrite("***************************  Sync Started for Annual results********************")
        logFileWrite("Time Started : " + Date.Now)
        'Cursor = Cursors.WaitCursor
        Dim strURL As String
        Dim HTML As String
        Dim TableName As String
        Dim Iteration As Int16 = 0

        For Each dr As DataRow In dtACL.Rows
            'If Iteration >= 3 Then
            '    GoTo END_FUNCTION
            'End If
            Iteration += 1

            'strURL = "C:\Documents and Settings\User\Desktop\Astitatva\Web Crawler\Web Spider\Site Samle\ratio\ratio.htm"
            strURL = dr("Company")

            strURL = strURL + "/results-annual"     '##1change
            TableName = dr("Code")

            ' Here internet will be used 
            HTML = GetHTML(strURL)
            ' to get  Ratios table , tag = "<h2>Ratios</h2>"
            If Not HTML.Equals("False") Then
                HTML = RefineHTML(HTML, "<h2>Annual results in brief</h2>")      '##2change
            Else
                Continue For   ' To check for next company.
            End If

            If 1 Then
                '(dsCoTable.HasChanges) Then
                dsCoTableAnnualResults = ConvertHTMLTablesToDataSet(HTML)
                'Just for Ratios table
                dsCoTableAnnualResults.Tables(0).Columns(0).ColumnName = "AnnualResults"    '##3change
            End If

            'Dim Grid As DataGridView = New DataGridView
            'gvTemp.Visible = False

            '' Create a GridView for each DataTable  
            'For Each Data As DataTable In dsCoTable.Tables
            '    'Grid = New DataGridView
            '    Grid.DataSource = Data
            '    'Grid.Refresh()
            '    'Grid.DataBind()
            '    pnlGridViews.Controls.Add(Grid)
            '    Grid.Dock = DockStyle.Fill
            'Next
            Console.Write("no of tables: " + i.ToString)

            '****************************************************
            TableName = TableName.ToString.Trim + "_Table"   'TODO: TableName: "Company SC_CODE" + "_Table"
            '1. Create MSAccess table in CoTablesDatabase.mdb with same coulmn name as dsCoTable
            If CreateTable(TableName) Then
                '2. Fill data from dsCoTabel to AccessTable
                If FillDBCoTable(TableName) Then
                    logFileWrite(TableName + " is Updated Successfully!!")
                Else
                    logFileWrite("error:" + TableName + " is not Updated Completeley!!")
                End If
            Else
                logFileWrite("error:" + TableName + " is not Created !!")
            End If
            '3. Show data
        Next
        'END_FUNCTION:
        logFileWrite("Time Ended : " + Date.Now)
        MsgBox("Done!!!")
        ' Cursor = Cursors.Default
    End Sub

    Private Sub LinkLabelShowSectorList_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelShowSectorList.LinkClicked
        Cursor = Cursors.WaitCursor

        If Not String.Compare(LinkLabelShowSectorList.Text, "Show Sector List") Then
            LoadSectorsList()
            PanelSectorList.Visible = True
            CheckedListBox1.MultiColumn = False
            'TODO:
            'Load saved marked list, the sectors which were marked before hiding them.
            'CheckedListBox1.
            LinkLabelShowSectorList.Text = "Hide Sector List"
        Else
            'TODO:
            'Save marked list, the sectors which are marked.
            PanelSectorList.Visible = False
            LinkLabelShowSectorList.Text = "Show Sector List"
        End If

        Cursor = Cursors.Default
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'TableLayoutPanelLoadingSector.Location = New Point(475, 600)
        'TableLayoutPanelLoadingSector.BringToFront()
        'to test
        backgroundworkerSectorSync.RunWorkerAsync()
        'SyncSelectedSectors()
    End Sub

    Public Sub SyncSelectedSectors()
        '1. Get list of seleceted Sectors
        '2. For each Sector get companies in it
        '3. For each Company Sync the data

        If CheckBoxRatios.Checked Then
            SyncType = ESyncType.RATIOS     'RATIO
        End If
        If CheckBoxAnnualResults.Checked Then
            SyncType = ESyncType.ANNUALRESULTS    'Annual Results
        End If

        If System.IO.File.Exists("LogFile.txt") = True Then
            System.IO.File.Delete("LogFile.txt")
        End If

        logFileWrite("*************************** Sector vise Sync Started for " + SyncType.ToString + "********************")
        logFileWrite("Time Started : " + Date.Now)
        'Cursor = Cursors.WaitCursor

        Dim CSVCon As OleDbConnection
        Dim Cmd As OleDb.OleDbCommand
        Dim Reader As OleDb.OleDbDataReader
        Dim HTML As String = Nothing
        Dim TableName As String = Nothing
        Dim strURL As String = Nothing

        Dim Checked_Sectors As CheckedListBox.CheckedItemCollection = CheckedListBox1.CheckedItems
        Dim txt As String = "     Selected Students:" & vbCrLf


        For Each Sector As Object In Checked_Sectors
            '#. Show Loading panel
            SetControlPropertyValue(LabelLoadingSector, "Text", Sector.ToString)
            SetControlPropertyValue(TableLayoutPanelLoadingSector, "Visible", True)
            'LabelLoadingSector.Text = Sector.ToString
            'TableLayoutPanelLoadingSector.Visible = True

            '2. get Companies
            CSVCon = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath() & "\..\Data\" + ";Extended Properties=Text")
            Dim strSQL As String = "SELECT [company],[code] FROM [ACL.csv] WHERE ([Sector] = '" + Sector.ToString.Trim + "') "
            Cmd = New OleDb.OleDbCommand(strSQL, CSVCon)
            If CSVCon.State = ConnectionState.Closed Then
                CSVCon.Open()
            End If

            Reader = Cmd.ExecuteReader()
            txt &= vbCrLf & Sector.ToString & " :" & vbCrLf
            While Reader.Read()
                strURL = Reader.Item(0).ToString.Trim   'READ Comapny Link COLUMN FROM DATABASE
                Select Case SyncType
                    Case ESyncType.RATIOS
                        strURL = strURL + "/ratio"
                    Case ESyncType.ANNUALRESULTS
                        strURL = strURL + "/results-annual"
                End Select

                TableName = Reader.Item(1).ToString.Trim     'READ Comapny SC-Code COLUMN FROM DATABASE
                SetControlPropertyValue(LabelLoadingCompany, "Text", TableName.ToString)

                ' Here internet will be used 
                HTML = GetHTML(strURL)
                ' to get  Ratios table , tag = "<h2>Ratios</h2>"
                If Not HTML.Equals("False") Then
                    Select Case SyncType
                        Case ESyncType.RATIOS
                            HTML = RefineHTML(HTML, "(Rs crore)") '"<h2>Ratios</h2>")
                        Case ESyncType.ANNUALRESULTS
                            HTML = RefineHTML(HTML, "Annual results in brief") '"<h2>Annual results in brief</h2>")
                    End Select

                Else
                    Continue For   ' To check for next company.
                End If

                If 1 Then
                    '(dsCoTable.HasChanges) Then
                    Select Case SyncType
                        Case ESyncType.RATIOS
                            dsCoTable = ConvertHTMLTablesToDataSet(HTML)
                            'Just for Ratios table
                            dsCoTable.Tables(0).Columns(0).ColumnName = "RATIOS"
                        Case ESyncType.ANNUALRESULTS
                            dsCoTableAnnualResults = ConvertHTMLTablesToDataSet(HTML)
                            'Just for Annual Results table
                            dsCoTableAnnualResults.Tables(0).Columns(0).ColumnName = "AnnualResults"
                    End Select

                End If

                Console.Write("no of tables: " + i.ToString)

                '****************************************************
                TableName = TableName.ToString.Trim + "_Table"   'TODO: TableName: "Company SC_CODE" + "_Table"
                '1. Create MSAccess table in CoTablesDatabase.mdb with same coulmn name as dsCoTable
                If CreateTable(TableName) Then
                    '2. Fill data from dsCoTabel to AccessTable
                    If FillDBCoTable(TableName) Then
                        logFileWrite(TableName + " is Updated Successfully!!")
                    Else
                        logFileWrite("error:" + TableName + " is not Updated Completeley!!")
                    End If
                Else
                    logFileWrite("error:" + TableName + " is not Created !!")
                End If
                txt &= strURL.ToString & vbCrLf
            End While

            If CSVCon.State = ConnectionState.Open Then
                CSVCon.Close()
            End If

        Next Sector
        ' MessageBox.Show(txt)
        logFileWrite("Time Ended : " + Date.Now)
        MsgBox("Done!!!")
        'Cursor = Cursors.Default

    End Sub


    Private Sub BtnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectAll.Click
        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub BtnSelectNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectNone.Click
        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub backgroundworkerSectorSync_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles backgroundworkerSectorSync.DoWork
        SetControlPropertyValue(Button1, "Enabled", False)
        SetControlPropertyValue(PanelSectorList, "Enabled", False)
        SetControlPropertyValue(PictureBoxLoading, "Enabled", True)
        SetControlPropertyValue(PictureBoxLoading, "Visible", True)
        SyncSelectedSectors()

    End Sub

    Private Sub backgroundworkerSectorSync_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles backgroundworkerSectorSync.RunWorkerCompleted
        'Hide Loading Panel
        PictureBoxLoading.Visible = False
        TableLayoutPanelLoadingSector.Visible = False

        Button1.Enabled = True
        PanelSectorList.Enabled = True

        MessageBox.Show(" Sync Completed, Last Sector Synced : " + LabelLoadingSector.Text.ToString + "\n Company :" + LabelLoadingCompany.Text.ToString)


    End Sub

End Class