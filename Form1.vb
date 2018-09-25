Imports System.Data
Imports System.Data.OleDb
Imports System.IO.FileInfo
Imports System.IO
Imports System.Threading
Imports ckidll





Public Class Form1
    'Form1 Class Variables *********
    Dim tbCompanies As DataTable
    Dim dgAutoComplete As AutoCompleteStringCollection
    'To declare something "Globally"(In all forms) you need to change "Dim" to "Public".
    Public clrPanelBackground As Color = Color.FromArgb(196, 215, 244)
    Dim showingHint As Boolean = True
    Dim dvView As DataView

    'Form1 Class Functions *********
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'Grand_databaseDataSet.EQ230410' table. You can move, or remove it, as needed.
        'Me.EQ230410TableAdapter.Fill(Me.Grand_databaseDataSet.EQ230410
        Me.WindowState = FormWindowState.Maximized

        Panel1.BackColor = clrPanelBackground
        Panel2.BackColor = clrPanelBackground
        Panel3.BackColor = clrPanelBackground
        GroupBox1.BackColor = clrPanelBackground

        Label1.Text = "Enter the company ID:"
        DataGridView1.Visible = False
        'DataGridView1.Width = Me.Width
        'DataGridView1.Height = Me.Height
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right

        Panel2.Dock = DockStyle.Bottom
        'TextBox2.Text = "Ruko Makhuncho !!! . .. Its Loading...".ToString

        ''Load the Company DataTable
        'dgAutoComplete = New AutoCompleteStringCollection
        'Dim tempPath As String = System.IO.Directory.GetCurrentDirectory
        'System.IO.Directory.SetCurrentDirectory(Application.StartupPath() & "\..\Data\ACL")
        'Dim CSVCon As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath() & "\..\Data\ACL\" + ";Extended Properties=Text")
        'Try
        '    CSVCon.Open()
        '    strSql = "SELECT * FROM [companies.csv] "
        '    tbCompanies = New DataTable
        '    Dim oleda As OleDbDataAdapter = New OleDbDataAdapter(strSql, CSVCon)
        '    oleda.Fill(tbCompanies)

        '    For Each dr As DataRow In tbCompanies.Rows
        '        'If Not String.IsNullOrEmpty(dr("Code").ToString) Then
        '        dgAutoComplete.Add(dr.Item("Company").ToString)
        '        ' End If
        '    Next
        '    'reader.GetString(1) not working :(   
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    System.IO.Directory.SetCurrentDirectory(tempPath)
        'End Try

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Dim strSql As String
    'Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
    '    'TextBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    '    'TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource
    '    'TextBox1.AutoCompleteCustomSource = dgAutoComplete
    'End Sub

    Sub SetData()
        ' Response.Write("Hello World")
        Dim i As Integer

        Dim Filename As String = Application.StartupPath() + "\Grand_database.mdb"

        Dim strConnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & _
                             "data source=" + Filename
        Dim objConnection As New OleDbConnection(strConnection)
        Dim dsSchema As DataSet = New DataSet()
        Dim dt As DataTable
        objConnection.Open()
        dt = objConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)

        dsSchema.Tables.Add(dt)
        dt = dsSchema.Tables(0)
        i = 1
        For Each dr As DataRow In dt.Rows
            If Not String.Compare(dr("TABLE_TYPE"), "TABLE") Then
                strSql &= "SELECT [SC_DATE],[SC_CODE ],[SC_NAME ],[SC_GROUP ],[SC_TYPE ],[OPEN ],[HIGH ],[LOW ],[CLOSE ],[LAST ],[PREVCLOSE ],[NO_TRADES ],[NO_OF_SHRS ],[NET_TURNOV ],[TDCLOINDI ]" & _
                        " FROM " + dr("TABLE_NAME") + " WHERE [SC_CODE] = " + TextBox1.Text.ToString + " "
                strSql &= "UNION "

                i += 1
            End If
        Next
        strSql = strSql.Substring(0, strSql.Length - 6)
        '**************************************

        'load the data from CSV to DataTable 
        Dim oleda As OleDbDataAdapter = New OleDbDataAdapter(strSql, strConnection)
        Dim dtbResult As DataTable = New DataTable()
        'strConnection.
        oleda.Fill(dtbResult)



        'Requested Query not fount in database
        If dtbResult.Rows.Count = 0 Then
            MsgBox("Data not found ")
            strSql = Nothing
            Return
        End If

        '**************************************
        'Name of Company As Label
        '**************************************
        lblCoName.Text = dtbResult.Rows(1).Item(2).ToString
        lblCoName.Text &= "     Group: " + dtbResult.Rows(1).Item(3).ToString
        lblCoName.Text &= "     Type: " + dtbResult.Rows(1).Item(4).ToString
        lblCoName.Visible = True


        'Empty the String 
        strSql = Nothing

        ' Create DataView on dtbCSV
        Dim dvView As New DataView(dtbResult)
        ' dvView.Sort = strViewString

        'Display data in a GridView control 

        DataGridView1.DataSource = dvView
        DataGridView1.AllowUserToResizeRows = True
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.Dock = DockStyle.Bottom
        DataGridView1.Columns(1).Visible = False    'hide SC_CODE
        DataGridView1.Columns(2).Visible = False    'hide SC_NAME
        DataGridView1.Columns(3).Visible = False    'hide SC_GROUP
        DataGridView1.Columns(4).Visible = False    'hide SC_TYPE
        ' DataGridView1.Columns(14).Visible = False    'hide TDCLOINDI

        DataGridView1.Columns(0).HeaderText = "Date"
        DataGridView1.Columns(2).HeaderText = "Company Name"
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView1.Font, FontStyle.Bold)
        DataGridView1.Visible = True


        Panel2.Visible = True
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        If showingHint Then
            TextBox1.ForeColor = Color.Black
            TextBox1.Text = ""
            showingHint = False
        End If
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        If ((Not showingHint) And String.IsNullOrEmpty(TextBox1.Text)) Then
            TextBox1.ForeColor = Color.LightGray
            TextBox1.Text = "Enter SC_CODE Here"
            showingHint = True
        End If
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Return Then
            Cursor = Cursors.WaitCursor

            'If TextBox1.Text.ToString <> String.Empty And Not showingHint Then
            '    WebBrowser1.Navigate("http://www.google.com/finance?q=BOM%3A" + TextBox1.Text.ToString)
            'End If
            Dim t As Thread = New Thread(AddressOf Search)
            t.Start()

            'Search()
            'SetData()

            Cursor = Cursors.Default
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cursor = Cursors.WaitCursor
        If TextBox1.Text.ToString <> String.Empty And Not showingHint Then
            WebBrowser1.Navigate("http://www.google.com/finance?q=BOM%3A" + TextBox1.Text.ToString)
        End If
        Dim t As Thread = New Thread(AddressOf Search)
        t.Start()

        'SetData()
        Cursor = Cursors.Default
    End Sub

    Sub Search()
        Dim di As New IO.DirectoryInfo(Application.StartupPath() & "\..\Data")
        Dim dataFiles As IO.FileInfo() = di.GetFiles("EQ*.csv") 'EQ* is used to  select only BhaavCopies
        Dim fi As IO.FileInfo
        If Not String.IsNullOrEmpty(TextBox1.Text) And Not showingHint Then
            ' TODO : check enter textbox1.text , is integer or string
            'If Integer.Parse(TextBox1.Text.ToString) < 999999 And Integer.Parse(TextBox1.Text.ToString) > 500000 Then

            System.IO.Directory.SetCurrentDirectory(Application.StartupPath() & "\..\Data")
            Dim CSVCon As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath() & "\..\Data\" + ";Extended Properties=Text")
            strSql = Nothing
            For Each fi In dataFiles
                strSql &= "SELECT * FROM [" + fi.Name + "]  WHERE [SC_CODE] = " + TextBox1.Text.ToString + " "
                strSql &= "UNION "
            Next
            strSql = strSql.Substring(0, strSql.Length - 6)
            'load the data from CSV to DataTable 
            Dim oleda As OleDbDataAdapter = New OleDbDataAdapter(strSql, CSVCon)
            Dim dtbResult As DataTable = New DataTable()
            'strConnection.
            oleda.Fill(dtbResult)
            System.IO.Directory.SetCurrentDirectory(Application.StartupPath())

            If dtbResult.Rows.Count = 0 Then
                MsgBox("Data not found ")
                strSql = Nothing
                Return 'False
            End If

            '**************************************
            'Name of Company As Label
            '**************************************
            SetControlPropertyValue(lblCoName, "Text", dtbResult.Rows(0).Item("SC_NAME").ToString)
            SetControlPropertyValue(lblCoName, "Text", lblCoName.Text + "     Group: " + dtbResult.Rows(0).Item("SC_GROUP").ToString)
            SetControlPropertyValue(lblCoName, "Text", lblCoName.Text + "     Type: " + dtbResult.Rows(0).Item("SC_TYPE").ToString)
            SetControlPropertyValue(lblCoName, "Visible", True)

            'lblCoName.Text = dtbResult.Rows(0).Item("SC_NAME").ToString
            'lblCoName.Text &= "     Group: " + dtbResult.Rows(0).Item("SC_GROUP").ToString
            'lblCoName.Text &= "     Type: " + dtbResult.Rows(0).Item("SC_TYPE").ToString
            'lblCoName.Visible = True

            'Empty the String 
            strSql = Nothing

            ' Create DataView on dtbCSV
            dvView = New DataView(dtbResult)
            ' dvView.Sort = strViewString

            '#Display data in a GridView control 
            'This is a thread safe method
            'To overcome this error "Cross-thread operation not valid: Control 'DataGridView1' accessed from a thread other than the thread it was created on"
            SetControlPropertyValue(DataGridView1, "DataSource", dvView)
            'DataGridView1.DataSource = dvView
            SetControlPropertyValue(DataGridView1, "AllowUserToResizeRows", True)
            SetControlPropertyValue(DataGridView1, "AllowUserToOrderColumns", True)
            SetControlPropertyValue(DataGridView1, "Dock", DockStyle.Bottom)
            SetControlPropertyValue(DataGridView1, "Columns('SC_CODE').Visible", False)
            SetControlPropertyValue(DataGridView1, "Columns('SC_NAME').Visible", False)
            SetControlPropertyValue(DataGridView1, "Columns('SC_GROUP').Visible", False)
            SetControlPropertyValue(DataGridView1, "Columns('SC_TYPE').Visible", False)
            SetControlPropertyValue(DataGridView1, "Columns('SC_DATE').HeaderText ", "Date")
            SetControlPropertyValue(DataGridView1, "Columns('SC_NAME').HeaderText", "Company Name")
            SetControlPropertyValue(DataGridView1, "ColumnHeadersDefaultCellStyle.Font", New Font(DataGridView1.Font, FontStyle.Bold))
            SetControlPropertyValue(DataGridView1, "ColumnHeadersDefaultCellStyle.SelectionForeColor", Color.DarkOrange)
            SetControlPropertyValue(DataGridView1, "Visible", True)
            SetControlPropertyValue(Panel2, "Visible", True)


            'DataGridView1.AllowUserToResizeRows = True
            'DataGridView1.AllowUserToOrderColumns = True
            'DataGridView1.Dock = DockStyle.Bottom
            'DataGridView1.Columns("SC_CODE").Visible = False    'hide SC_CODE
            'DataGridView1.Columns("SC_NAME").Visible = False    'hide SC_NAME
            'DataGridView1.Columns("SC_GROUP").Visible = False    'hide SC_GROUP
            'DataGridView1.Columns("SC_TYPE").Visible = False    'hide SC_TYPE
            '' DataGridView1.Columns(14).Visible = False    'hide TDCLOINDI
            'DataGridView1.Columns("SC_DATE").HeaderText = "Date"
            'DataGridView1.Columns("SC_NAME").HeaderText = "Company Name"
            'DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView1.Font, FontStyle.Bold)
            'DataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.DarkOrange
            'DataGridView1.Visible = True
            'Panel2.Visible = True
            'Else
            '    MsgBox("This SC Code is not Valid !!  ")
            '    Return False
            'End If
        Else
            MsgBox("Please enter something !! ")
            ' Return False
        End If
        'Return True
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


    Private Sub BtnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowse.Click
        ' OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "CSV file (*.csv)|*.csv|" & "Text files (*.txt)|*.txt|" & "All files|*.*"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Dim sr As New System.IO.StreamReader(OpenFileDialog1.FileName)
            tbFilePath.Text = OpenFileDialog1.FileName
        End If
        OpenFileDialog1.RestoreDirectory = True
    End Sub

    Private Sub BtnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpload.Click
        Cursor = Cursors.WaitCursor
        'Showing Loading information
        TextBox2.Visible = True
        Dim fileinfo As IO.FileInfo
        If Not String.IsNullOrEmpty(tbFilePath.Text) Then
            fileinfo = New IO.FileInfo(tbFilePath.Text.ToString)
        Else
            MsgBox("Please First Browse the file.")
            Cursor = Cursors.Default
            Return
        End If
        'Calculation of directory path, from which the file is loaded
        Dim strCsvFilePath As String = tbFilePath.Text.ToString
        strCsvFilePath = Path.GetDirectoryName(strCsvFilePath)
        ' For CSV file as database, we need to give the file directory path in the connection string

        Dim TableName As String = fileinfo.Name
        TableName = TableName.Substring(0, TableName.Length - 4)
        Dim CSVdtb As DataTable = New DataTable()
        '*************************************
        '       Create new Table         *****
        '*************************************
        'Dim Cmd As OleDbCommand
        'Dim SQL As String
        'Dim objCmd As New OleDbCommand


        ''1 load the data from accdb(databse file)
        'Dim DBFilePath As String = Application.StartupPath() + "\Grand_database.mdb"

        ''2 creating the MS Access database connection.
        'Dim Con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DBFilePath + ";")


        ' ''3 Creating the SQL query to create a new table in my Access database called 'tbCatalogue'.
        'SQL = "CREATE TABLE " + TableName + " ([SC_CODE] LONG, [SC_NAME] TEXT(40), [SC_GROUP] TEXT(3), [SC_TYPE] TEXT(3)," & _
        '                                    " [OPEN] Double, [HIGH] Double, [LOW] Double, [CLOSE] Double, [LAST] Double, " & _
        '                                    " [PREVCLOSE] Double, [NO_TRADES] Long, [NO_OF_SHRS] Long, [NET_TURNOV] Double," & _
        '                                    " [TDCLOINDI] TEXT(5),[SC_DATE] DateTime  )"
        'Cmd = New OleDbCommand(SQL, Con)

        ''4 Opening the connection to the database, executing the the SQL command/query, and then closing the database connection. 
        'Try
        '    Con.Open()
        '    objCmd = New OleDbCommand(SQL, Con)
        '    objCmd.ExecuteNonQuery()
        'Catch ex As Exception
        '    MessageBox.Show("error: " + ex.Message, "exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Cursor = Cursors.Default
        '    Return
        'Finally
        '    If Con.State = ConnectionState.Open Then
        '        Con.Close()
        '    End If

        'End Try

        '****************************************************
        '       Take data from CSV file to DataTable variable
        '****************************************************
        ' creating the csv file connection.
        Dim CSVCon As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strCsvFilePath + ";Extended Properties=Text")
        Dim CSVCmd As OleDbCommand = New OleDbCommand("SELECT * FROM [" + TableName + ".csv]", CSVCon)
        Dim CSVda As New OleDbDataAdapter

        'Open connection
        CSVCon.Open()
        'Fill dataset
        CSVda.SelectCommand = CSVCmd
        CSVda.Fill(CSVdtb)
        'Close connection
        If CSVCon.State = ConnectionState.Open Then
            CSVCon.Close()
        End If
        ' DataGridView2.DataSource = CSVdtb

        '****************************************************
        '       Add Date Coulmn to DataTable variable CSVdtb
        '****************************************************
        Dim CSVDateColumn As DataColumn

        CSVDateColumn = New DataColumn("SC_DATE", System.Type.GetType("System.DateTimeOffset"))
        CSVdtb.Columns.Add(CSVDateColumn)

        '****************************************************
        '       Fetch the Date from the file Name 
        '****************************************************
        Dim d1 As Date '= Date.FromOADate(23 / 9 / 2009)
        'd1 = Date.Now

        Dim year As Int16
        Dim month As Int16
        Dim day As Int16

        Dim strOldDate As String
        strOldDate = TableName.Substring(2, 6)
        Dim strDate As String

        year = strOldDate.Substring(4, 2)
        month = strOldDate.Substring(2, 2)
        day = strOldDate.Substring(0, 2)
        strDate = month & "/" & day & "/" & year

        MsgBox("This sheet is for (mm/dd/yy):" + strDate)
        d1 = Convert.ToDateTime(strDate)
        '***************************************************************************************
        '       Copy data from CSV dataTable to new empty TABLE of database                  ********
        '***************************************************************************************


        Dim insertOk As Boolean = DataTable2CSV(CSVdtb, TableName + "_new.csv", ",", d1.Date)

        'Try
        '    Con.Open()
        '    'loop
        '    For Each dr As DataRow In CSVdtb.Rows
        '        TextBox2.Text &= " ."
        '        SQL = "INSERT INTO " + TableName + " " & _
        '              "VALUES " & _
        '              "(@SC_CODE,@SC_NAME,@SC_GROUP,@SC_TYPE,@OPEN,@HIGH,@LOW,@CLOSE,@LAST,@PREVCLOSE,@NO_TRADES,@NO_OF_SHRS,@NET_TURNOV,@TDCLOINDI,@SC_DATE)"
        '        Cmd = New OleDbCommand(SQL, Con)

        '        Cmd.Parameters.AddWithValue("@SC_CODE", dr(0))
        '        Cmd.Parameters.AddWithValue("@SC_NAME", dr(1))
        '        Cmd.Parameters.AddWithValue("@SC_GROUP", dr(2))
        '        Cmd.Parameters.AddWithValue("@SC_TYPE", dr(3))
        '        Cmd.Parameters.AddWithValue("@OPEN", dr(4))
        '        Cmd.Parameters.AddWithValue("@HIGH", dr(5))
        '        Cmd.Parameters.AddWithValue("@LOW", dr(6))
        '        Cmd.Parameters.AddWithValue("@CLOSE", dr(7))
        '        Cmd.Parameters.AddWithValue("@LAST", dr(8))
        '        Cmd.Parameters.AddWithValue("@PREVCLOSE", dr(9))
        '        Cmd.Parameters.AddWithValue("@NO_TRADES", dr(10))
        '        Cmd.Parameters.AddWithValue("@NO_OF_SHRS", dr(11))
        '        Cmd.Parameters.AddWithValue("@NET_TURNOV", dr(12))
        '        Cmd.Parameters.AddWithValue("@TDCLOINDI", dr(13))
        '        Cmd.Parameters.AddWithValue("@SC_DATE", d1.Date)
        '        Cmd.ExecuteNonQuery()
        '    Next 'loop end
        'Catch ex As OleDbException
        '    MsgBox(ex.Message.ToString)
        '    insertOk = False
        'Finally
        '    Con.Close()
        'End Try

        If insertOk Then
            MsgBox("Details Submitted Successfully!")
        Else
            MsgBox("There was an error saving your data!")
        End If

        'Hiding loading information
        TextBox2.Visible = False

        ''Display data in a GridView control 
        'GridView1.DataSource = dtbCSV
        'GridView1.DataBind()
        ''**************************************
        ''Show the successful message
        'lbl_upload_sucessful.Text = "File uploaded successfully!!!"
        'lbl_upload_sucessful.Visible = True
        Cursor = Cursors.Default

    End Sub


    Function DataTable2CSV(ByVal table As DataTable, ByVal filename As String, ByVal sepChar As String, ByVal d1 As Date) As Boolean
        Dim writer As System.IO.StreamWriter

        If Not System.IO.Directory.Exists(Application.StartupPath() & "\..\Data") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath() & "\..\Data")
        End If
        Try
            writer = New System.IO.StreamWriter(Application.StartupPath() & "\..\Data\" + filename)

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
                    If String.Compare((col.ColumnName).ToString, ("SC_DATE").ToString) = 0 Then
                        'for date column
                        builder.Append(sep).Append(d1.Date.ToShortDateString)
                    Else
                        'for other columns which are present in data table
                        builder.Append(sep).Append(row(col.ColumnName))
                    End If

                    sep = sepChar
                Next
                writer.WriteLine(builder.ToString())
            Next
        Finally
            If Not writer Is Nothing Then writer.Close()
        End Try
        Return True
    End Function

    Private Sub btnListDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strFileSize As String = ""
        Dim di As New IO.DirectoryInfo(Application.StartupPath())
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.csv")
        Dim fi As IO.FileInfo

        Dim CSVda As New OleDbDataAdapter
        Dim dt1 As DataTable = New DataTable()

        Dim strCsvFilePath As String


        For Each fi In aryFi
            strFileSize = ((fi.Length / 1024)).ToString()
            Console.WriteLine("File Name: {0}", fi.Name)
            Console.WriteLine("File Full Name: {0}", fi.FullName)
            Console.WriteLine("File Size (KB): {0}", strFileSize)
            Console.WriteLine("File Extension: {0}", fi.Extension)
            Console.WriteLine("Last Accessed: {0}", fi.LastAccessTime)
            Console.WriteLine("Read Only: {0}", (FileAttributes.ReadOnly = True).ToString)

            strCsvFilePath = Path.GetDirectoryName(fi.FullName)

        Next
    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim empty As Object = System.Reflection.Missing.Value
        ' System.Uri.TryCreate("http://www.google.com/finance?q=BOM%3A500002", UriKind.Absolute, WebBrowser1.Url)
        'WebBrowser1.Navigate("about:blank")
        If Not showingHint Then
            If TextBox1.Text.ToString <> String.Empty Then
                WebBrowser1.Navigate("http://www.google.com/finance?q=BOM%3A" + TextBox1.Text)
            End If
        Else
            TextBox1.Text = ""
            MsgBox("Enter SC_Code of the Company First, Then Click on '" + Button2.Text + "'", MsgBoxStyle.Exclamation)
            TextBox1.ForeColor = Color.LightGray
            TextBox1.Text = "Enter SC_CODE Here"
            showingHint = True
        End If


        '' create an IHTMLDocument2
        'Dim doc As mshtml.IHTMLDocument2 = DirectCast(WebBrowser1.Document, mshtml.IHTMLDocument2)

        ' '' write to the doc
        'doc.clear()
        'doc.writeln("This is my text...")
        'doc.close()

        'WebBrowser1.DocumentText = doc '" Hello World !!!!"
        ''Dim doc As HtmlDocument = WebBrowser1.Document.DomDocument 'as IHTMLDocument2
        'doc.designMode = "On"
        'TextBox2.Text = WebBrowser1.Document.ToString
    End Sub


    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        TextBox2.Text = WebBrowser1.DocumentText.ToString
        WebBrowser1.Document.Window.ScrollTo(180, 5)
        Cursor = Cursors.Default

    End Sub

    Private Sub WebBrowser1_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        ' TextBox2.Text = WebBrowser1.DocumentText.ToString
    End Sub

    Private Sub WebBrowser1_Navigating(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        'TextBox2.Text = WebBrowser1.DocumentText.ToString
        Cursor = Cursors.WaitCursor
    End Sub


    Private Sub BtnResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResults.Click
        TabControl1.Visible = True
        TabControl1.SelectTab("tabpageAnnualResults")
        Form4Results.Show()
    End Sub

    Private Sub BtnRatios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRatios.Click
        TabControl1.Visible = True
        TabControl1.SelectTab("tabpageRatios")
        Form3_SortedRatios.Show()
    End Sub

    Private Sub BtnSync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSync.Click
        TabControl1.Visible = True
        TabControl1.SelectTab("tabpageSync")
        Form2.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub
    Private Sub BtnFundamentalRatios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFundamentalRatios.Click
        MsgBox("Before coming to fundamental Ratios, Be sure that you have synced Annual Results of all Companies")
        If MessageBox.Show("Do you want to Sync the Annual Results first", "?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Form2.Show()
        Else
            Form5FundamentalRatios.Show()
        End If

    End Sub

    Private Sub SplitContainerH_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainerH.Panel1.Paint

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim c1 As New ckidll.Class1
        Dim value As String
        value = c1.GetValue()
        Button3.Text = "lun" & value

    End Sub
End Class
