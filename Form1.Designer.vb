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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.BtnUpload = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnBrowse = New System.Windows.Forms.Button
        Me.tbFilePath = New System.Windows.Forms.TextBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.lblCoName = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.BtnFundamentalRatios = New System.Windows.Forms.Button
        Me.BtnResults = New System.Windows.Forms.Button
        Me.BtnRatios = New System.Windows.Forms.Button
        Me.BtnSync = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPageSync = New System.Windows.Forms.TabPage
        Me.TabPageRatios = New System.Windows.Forms.TabPage
        Me.TabPageAnnualResults = New System.Windows.Forms.TabPage
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.EQ130410BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Grand_databaseDataSet = New WindowsApplication1.Grand_databaseDataSet
        Me.SplitContainerH = New System.Windows.Forms.SplitContainer
        Me.Button3 = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.BtnResults1 = New System.Windows.Forms.Button
        Me.BtnRatios1 = New System.Windows.Forms.Button
        Me.BtnSync1 = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.EQ130410BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grand_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerH.Panel1.SuspendLayout()
        Me.SplitContainerH.Panel2.SuspendLayout()
        Me.SplitContainerH.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the company ID:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 20
        Me.DataGridView1.Size = New System.Drawing.Size(974, 387)
        Me.DataGridView1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.AutoCompleteCustomSource.AddRange(New String() {"20 Microns Ltd.", "3i Infotech Ltd.", "3M India Ltd.", "Aadi Industries Ltd.", "Aakar Engineering & Manufacturing Company Ltd.", "Aarey Drugs & Pharmaceuticals Ltd.", "Aarti Drugs Ltd.", "Aarti Industries Ltd.", "Aarvee Denims and Exports Ltd.", "Aarya Global Shares & Securities Ltd.", "Aasda Life Care Ltd.", "Aasheesh Securities Ltd.", "Aastha Broadcasting Network Ltd.", "Aaswa Trading & Exports Ltd.", "Abacus Computers Ltd.", "Aban Offshore Ltd.", "ABB Ltd.", "Abbott India Ltd.", "ABC Bearings Ltd.", "ABC Gas (International) Ltd.", "ABC India Ltd.", "ABC Paper Ltd.", "Abee Info-Consumables Ltd.", "ABG Infralogistics Ltd.", "ABG Shipyard Ltd.", "Abhinav Capital Services Ltd.", "Abhishek Corporation Ltd.", "Abhishek Industries Ltd.", "Abirami Financial Services (India) Ltd.", "ABL Bio-Technologies Ltd.", "ABM Knowledgeware Ltd.", "ACC Ltd.", "Accel Frontline Ltd.", "Accel Transmatic Ltd.", "Accentia Technologies Ltd.", "Accurate Exports Ltd.", "Accurate Transformers Ltd.", "ACE Edutrend Ltd.", "ACE Software Exports Ltd.", "ACI Infocom Ltd.", "ACIL Cotton Industries Ltd.", "Acknit Industries Ltd.", "Ackruti City Ltd.", "ACL Projects Ltd.", "Acrow India Ltd.", "Acrysil Ltd.", "Action Construction Equipment Ltd.", "Action Financial Services (India) Ltd.", "Ad-Manum Finance Ltd.", "Adam Comsof Ltd.", "Adani Enterprises Ltd.", "Adani Power Ltd.", "Adarsh Chemicals & Fertilisers Ltd.", "Adarsh Plant Project Ltd.", "ADC India Communications Ltd.", "Addi Industries Ltd.", "ADF Foods Ltd.", "Adhunik Metaliks Ltd.", "Adi Finechem Ltd.", "Adinath Bio-Labs Ltd.", "Adinath Exim Resources Ltd.", "Aditya Birla Chemicals (India) Ltd.", "Aditya Birla Minacs IT Services Ltd.", "Aditya Birla Money Ltd.", "Aditya Birla Nuvo Ltd.", "Aditya Forge Ltd.", "Aditya International Ltd.", "Aditya Ispat Ltd.", "Aditya Spinners Ltd.", "Ador Fontech Ltd.", "Ador Multiproducts Ltd.", "Ador Welding Ltd.", "ADS Diagnostic Ltd.", "Advance Multitech Ltd.", "Advance Petrochemicals Ltd.", "Advance Powerinfra Tech Ltd.", "Advanced Micronic Devices Ltd.", "Advani Hotels & Resorts (India) Ltd.", "Advanta India Ltd.", "Advent Computer Services Ltd.", "Advik Laboratories Ltd.", "Aegis Logistics Ltd.", "Aeonian Investments Company Ltd.", "Aftek Ltd.", "Agarwal Holdings Ltd.", "Agarwal Industrial Corporation Ltd.", "AGC Networks Ltd.", "Agio Paper & Industries Ltd.", "Agro Dutch Industries Ltd.", "Agro Tech Foods Ltd.", "Ahlcon Parenterals (India) Ltd.", "Ahluwalia Contracts (India) Ltd.", "Ahmedabad Gases Ltd.", "Ahmedabad Steelcraft Ltd.", "Ahmednagar Forgings Ltd.", "AI Champdany Industries Ltd.", "AIA Engineering Ltd.", "Aimco Pesticides Ltd.", "Aishwarya Telecom Ltd.", "Ajanta Pharma Ltd.", "Ajanta Soya Ltd.", "Ajcon Global Services Ltd.", "Ajel Ltd.", "Ajmera Realty & Infra India Ltd.", "Ajwa Fun World & Resorts Ltd.", "AK Capital Services Ltd.", "Akanksha Cellualar Ltd.", "Akar Tools Ltd.", "AKL Soft & Infosys (India) Ltd.", "Aksh Optifibre Ltd.", "AksharChem (India) Ltd.", "Akzo Nobel India Ltd.", "Alacrity Electronics Ltd.", "Alacrity Housing Ltd.", "Alang Marine Ltd.", "Albert David Ltd.", "Albright & Wilson Chemicals India Ltd.", "Alchemist Corporation Ltd.", "Alchemist Ltd.", "Alchemist Realty Ltd.", "Alcobex Metals Ltd.", "Alembic Ltd.", "Alfa Ica (India) Ltd.", "Alfa Laval (India) Ltd.", "Alfa Transformers Ltd.", "Alfavision Overseas (India) Ltd.", "Alfred Herbert (India) Ltd.", "Alka Diamond Industries Ltd.", "Alka India Ltd.", "Alka Securities Ltd.", "Alkali Metals Ltd.", "Alkyl Amines Chemicals Ltd.", "Allahabad Bank", "Allcargo Global Logistics Ltd.", "Allied Computers International (Asia) Ltd.", "Allied Digital Services Ltd.", "Allied Resins & Chemicals Ltd.", "Allsec Technologies Ltd.", "Allsoft Corporation Ltd.", "Almondz Capital & Management Services Ltd.", "Almondz Global Securities Ltd.", "Alna Trading & Exports Ltd.", "Alok Industries Ltd.", "Alpa Laboratories Ltd.", "Alpha Geo (India) Ltd.", "Alpha Graphic India Ltd.", "Alpha Hi-Tech Fuel Ltd.", "Alpine Capital Services Ltd.", "Alpine Housing Development Corporation Ltd.", "Alps BPO Services Ltd.", "Alps Industries Ltd.", "Alsa Marine & Harvests Ltd.", "Alstom Projects India Ltd.", "Alufluoride Ltd.", "Alumeco India Extrusion Ltd.", "Amal Ltd.", "Amalgamated Electricity Company Ltd.", "Amani Trading & Exports Ltd.", "Amar Remedies Ltd.", "Amara Raja Batteries Ltd.", "Amarjothi Spinning Mills Ltd.", "Ambala Cements Ltd.", "Ambalal Sarabhai Enterprises Ltd.", "Ambica Agarbathies & Aroma Industries Ltd.", "Ambika Cotton Mills Ltd.", "Ambuja Cements Ltd.", "Amco India Ltd.", "AMD Industries Ltd.", "Amforge Industries Ltd.", "Ami Computers (I) Ltd.", "Amines & Plasticizers Ltd.", "Amison Foods Ltd.", "Amit International Ltd.", "Amit Securities Ltd.", "Amit Spinning Industries Ltd.", "Amradeep Industries Ltd.", "Amrapali Developers (India) Ltd.", "Amrapali Industries Ltd.", "Amraworld Agrico Ltd.", "Amrit Banaspati Company Ltd.", "Amrit Corp. Ltd.", "Amrutanjan Health Care Ltd.", "Amtek Auto Ltd.", "Amtek India Ltd.", "Amulya Leasing & Finance Ltd.", "Anand Credit Ltd.", "Anand Electric Supply Company Ltd.", "Anant Raj Industries Ltd.", "Andhra Bank", "Andhra Cements Ltd.", "Andhra Petrochemicals Ltd.", "Andhra Pradesh Paper Mills Ltd.", "Andhra Sugars Ltd.", "Andrew Yule & Company Ltd.", "ANG Industries Ltd.", "Anik Industries Ltd.", "Anil Ltd.", "Anil Special Steel Industries Ltd.", "Anjani Fabrics Ltd.", "Anjani Finance Ltd.", "Anjani Portland Cement Ltd.", "Anjani Synthetics Ltd.", "Anka India Ltd.", "Ankit Metal & Power Ltd.", "Ankur Drugs & Pharma Ltd.", "Ankush Finstock Ltd.", "Anna Infrastructures Ltd.", "ANS Ltd.", "Ansal Buildwell Ltd.", "Ansal Housing & Construction Ltd.", "Ansal Properties & Infrastructure Ltd.", "Anshuni Commercials Ltd.", "Anu's Laboratories Ltd.", "Anugraha Jewellers Ltd.", "Anuh Pharma Ltd.", "Apar Industries Ltd.", "Apcotex Industries Ltd.", "Apeejay Tea Ltd.", "Apex Intertech Ltd.", "Apis India Ltd.", "APL Apollo Tubes Ltd.", "Aplab Ltd.", "APM Industries Ltd.", "Apollo Finvest (India) Ltd.", "Apollo Hospitals Enterprise Ltd.", "Apollo Tyres Ltd.", "Apple Finance Ltd.", "Apt Packaging Ltd.", "Apte Amalgamation Ltd.", "Aptech Ltd.", "APW President Systems Ltd.", "Aqua Logistics Ltd.", "Aravali Securities & Finance Ltd.", "Arcee Industries Ltd.", "Arch Pharmalabs Ltd.", "Archidply Industries Ltd.", "Archies Ltd.", "Arcotech Ltd.", "Ardi Investment & Trading Company Ltd.", "Areva T&D India Ltd.", "Arex Industries Ltd.", "Ari Consolidated Investments Ltd.", "Aries Agro Ltd.", "Arihant Capital Markets Ltd.", "Arihant Foundations & Housing Ltd.", "Arihant Superstructures Ltd.", "Arihant Threads Ltd.", "Arihant Tournesol Ltd.", "Arihants Securities Ltd.", "Arman Financial Services Ltd.", "Arms Papers Ltd.", "Arnav Corporation Ltd.", "Aro Granite Industries Ltd.", "Aroni Commercials Ltd.", "Arora Fibres Ltd.", "Arrow Coated Products Ltd.", "Arrow Securities Ltd.", "Arrow Textiles Ltd.", "Arshiya International Ltd.", "Arsi Cosmetics & Chemicals Ltd", "ARSS Infrastructure Projects Ltd.", "Artech Power Products Ltd.", "Artefact Projects Ltd.", "Artheon Finance Ltd.", "Artillegence Bio-Innovations Ltd.", "Artson Engineering Ltd.", "Arun Mantex Ltd.", "Arun Processors Ltd.", "Aruna Hotels Ltd.", "Arunjyoti Enterprises Ltd.", "Arunoday Mills Ltd.", "Arvind Chemicals Ltd.", "Arvind International Ltd.", "Arvind Ltd.", "Arvind Products Ltd.", "Arvind Remedies Ltd.", "Aryaman Financial Services Ltd.", "Asahi India Glass Ltd.", "Asahi Industries Ltd.", "Asahi Infrastructure & Projects Ltd.", "Asahi Songwon Colors Ltd.", "Ascent Exim (India) Ltd.", "Ashapura Minechem Ltd.", "Ashco Niulab Industries Ltd.", "Ashiana Agro Industries Ltd.", "Ashiana Housing Ltd.", "Ashiana Ispat Ltd.", "Ashima Ltd.", "Ashirwad Capital Ltd.", "Ashirwad Steels & Industries Ltd.", "Ashish Polyplast Ltd.", "Ashnoor Textile Mills Ltd.", "Ashok Alco-Chem Ltd.", "Ashok Leyland Ltd.", "Ashok Organic Industries Ltd.", "Ashoka Buildcon Ltd.", "Ashutosh Paper Mills Ltd.", "Asia HR Technologies Ltd.", "Asian Electronics Ltd.", "Asian Fertilizers Ltd.", "Asian Films Production and Distribution Ltd.", "Asian Granito India Ltd.", "Asian Hotels (East) Ltd.", "Asian Hotels (North) Ltd.", "Asian Hotels (West) Ltd.", "Asian Oilfield Services Ltd.", "Asian Paints Ltd.", "Asian Petroproducts & Exports Ltd.", "Asian Star Company Ltd.", "Asian Tea Exports Ltd.", "Asit C Mehta Financial Services Ltd.", "ASM Technologies Ltd.", "Assam Company (India) Ltd.", "Assam Petrochemicals Ltd.", "Assambrook Ltd.", "Associated Alcohols & Breweries Ltd.", "Associated Stone Industries (Kotah) Ltd.", "Astec Lifesciences Ltd.", "Aster Silicates Ltd.", "Astra Microwave Products Ltd.", "Astral Poly Technik Ltd.", "AstraZeneca Pharma India Ltd.", "Astro Bio Systems Ltd.", "Asya Infrastructure & Tourism Corporation Ltd.", "Atco Corporation Ltd.", "Atcom Technologies Ltd.", "Atharv Enterprises Ltd.", "Athena Financial Services Ltd.", "Atlanta Ltd.", "Atlantic Spinning and Weaving Mills Ltd.", "Atlas Copco (India) Ltd.", "Atlas Cycles (Haryana) Ltd.", "ATN International Ltd.", "Atul Auto Ltd.", "Atul Ltd.", "ATV Projects India Ltd.", "AUNDE India Ltd.", "Aurangabad Paper Mills Ltd.", "Aurionpro Solutions Ltd.", "Auro Laboratories Ltd.", "Aurobindo Pharma Ltd.", "Auroma Coke Ltd.", "Aurum Soft Systems Ltd.", "Ausom Enterprise Ltd.", "Austin Engineering Company Ltd.", "Autoline Industries Ltd.", "Autolite (India) Ltd.", "Automobile Corporation Of Goa Ltd.", "Automotive Axles Ltd.", "Automotive Stampings and Assemblies Ltd.", "Autopal Industries Ltd.", "Autoriders Finance Ltd.", "Autoriders International Ltd.", "AV Cottex Ltd.", "Available Finance Ltd.", "Avance Technologies Ltd.", "Avantel Ltd.", "Avanti Feeds Ltd.", "Aventis Pharma Ltd.", "Avery India Ltd.", "Aviva Industries Ltd.", "Avon Corporation Ltd.", "Avon Organics Ltd.", "AVT Natural Products Ltd.", "Axel Polymers Ltd.", "Axis Bank Ltd.", "Axis Capital Markets (India) Ltd.", "AXIS-IT&T Ltd.", "Axon Infotech Ltd.", "Axtel Industries Ltd.", "Ayoki Mercantile Ltd.", "Aztecsoft Ltd.[Merged]", "B & A Packaging India Ltd.", "B L Kashyap & Sons Ltd.", "B N Rathi Securities Ltd.", "B Nanji Enterprises Ltd.", "B&A Ltd.", "B&B Realty Ltd.", "B2B Software Technologies Ltd.", "Baba Arts Ltd.", "Bacil Pharma Ltd.", "Baffin Engineering Projects Ltd.", "Bafna Pharmaceuticals Ltd.", "Bafna Spinning Mill & Exports Ltd.", "BAG Films & Media Ltd.", "Bagadia Colourchem Ltd.", "Bagalkot Udyog Ltd.", "Baid Leasing and Finance Company Ltd.", "Bajaj Auto Ltd.", "Bajaj Corp Ltd.", "Bajaj Electricals Ltd.", "Bajaj Finance Ltd.", "Bajaj Finserv Ltd.", "Bajaj Hindustan Ltd.", "Bajaj Hindusthan Sugar & Industries Ltd.", "Bajaj Holdings & Investment Ltd.", "Bajaj Steel Industries Ltd.", "Bajrang Finance Ltd.", "Bal Pharma Ltd.", "Bala Techno Global Ltd.", "Bala Techno Industries Ltd.", "Balaji Amines Ltd.", "Balaji Distilleries Ltd.", "Balaji Industrial Corporation Ltd.", "Balaji Telefilms Ltd.", "Balasore Alloys Ltd.", "Balkrishna Industries Ltd.", "Ballarpur Industries Ltd.", "Balmer Lawrie & Company Ltd.", "Balmer Lawrie Investments Ltd.", "Balmer Lawrie Van Leer Ltd.", "Balrampur Chini Mills Ltd.", "Balurghat Technologies Ltd.", "Bambino Agro Industries Ltd.", "Bampsl Securities Ltd.", "Banaras Beads Ltd.", "Banco Products (India) Ltd.", "Bang Overseas Ltd.", "Bank of Baroda", "Bank of India", "Bank of Maharashtra", "Bank of Rajasthan Ltd.", "Bannari Amman Spinning Mills Ltd.", "Bannari Amman Sugars Ltd.", "Bansisons Tea Industries Ltd.", "Banswara Syntex Ltd.", "Barak Valley Cements Ltd.", "Baroda Extrusion Ltd.", "Baron Infotech Ltd.", "Bartronics India Ltd.", "Basant Agro Tech (India) Ltd.", "BASF India Ltd.", "Basil Infrastructure Projects Ltd.", "Bata India Ltd.", "Bathina Technologies (India) Ltd.", "Batliboi Ltd.", "Bayer Cropscience Ltd.", "BCC Fuba India Ltd.", "BCL Forgings Ltd.", "BCL Industries & Infrastructures Ltd.", "BDH Industries Ltd.", "Beckons Industries Ltd.", "Bedmutha Industries Ltd.", "Bee Electronic Machines Ltd.", "Beeyu Overseas Ltd.", "Belapur Industries Ltd.", "Bell Ceramics Ltd.", "Bellary Steels & Alloys Ltd.", "Bemco Hydraulics Ltd.", "BEML Ltd.", "Benares Hotels Ltd.", "Bengal & Assam Company Ltd.", "Bengal Tea and Fabrics Ltd.", "Benzo Petro International Ltd.", "Berger Paints (India) Ltd.", "Bervin Investment & Leasing Ltd.", "Beryl Drugs Ltd.", "Beryl Securities Ltd.", "Best & Crompton Engineering Ltd.", "Best Eastern Hotels Ltd.", "Beta-Kappa Investments Ltd.", "Betala Global Securities Ltd.", "BF Utilities Ltd.", "BGIL Films & Technologies Ltd.", "BGR Energy Systems Ltd.", "Bhagawati Gas Ltd.", "Bhagawati Oxygen Ltd.", "Bhageria Dye-Chem Ltd.", "Bhagheeratha Engineering Ltd.", "Bhagiradha Chemicals & Industries Ltd.", "Bhagwandas Metals Ltd.", "Bhagwati Autocast Ltd.", "Bhagwati Banquets & Hotels Ltd.", "Bhagyanagar India Ltd.", "Bhagyanagar Wood Plast Ltd.", "Bhagyashree Leasing & Finance Ltd.", "Bhagyodaya Infrastructure Development Ltd.", "Bhagyodaya Infrastructure Development Ltd.", "Bhandari Consultancy & Finance Ltd.", "Bhandari Hosiery Exports Ltd.", "Bhandari Udhyog Ltd.", "Bhansali Engineering Polymers Ltd.", "Bharat Bhushan Share & Commodity Brokers Ltd.", "Bharat Bijlee Ltd.", "Bharat Commerce & Industries Ltd.", "Bharat Electronics Ltd.", "Bharat Fertiliser Industries Ltd.", "Bharat Forge Ltd.", "Bharat Gears Ltd.", "Bharat Heavy Electricals Ltd.", "Bharat Immunological & Biologicals Corporation Ltd.", "Bharat Line Ltd.", "Bharat Petroleum Corporation Ltd.", "Bharat Rasayan Ltd.", "Bharat Seats Ltd.", "Bharat Textiles & Proofing Industries Ltd.", "Bharati Shipyard Ltd.", "Bharti Airtel Ltd.", "Bhartiya International Ltd.", "Bhaskar Agrochemicals Ltd.", "Bhatia Industries & Infrastructure Ltd.", "Bheema Cements Ltd.", "Bhilwara Spinners Ltd.", "Bhilwara Technical Textiles Ltd.", "Bhilwara Tex-Fin Ltd.", "Bholanath International Ltd.", "Bhoomi Infrastructures Corporation Ltd.", "Bhor Industries Ltd.", "Bhoruka Aluminium Ltd.", "Bhoruka Steel & Services Ltd.", "Bhuruka Gases Ltd.", "Bhushan Steel Ltd.", "Bhuvan Tripura Industries Ltd.", "Bhuwalka Steel Industries Ltd.", "Bihar Sponge Iron Ltd.", "Bijoy Hans Ltd.", "Bilcare Ltd.", "Bilpower Ltd.", "Bimetal Bearings Ltd.", "Binani Cement Ltd.", "Binani Industries Ltd.", "Binayak Tex Processors Ltd.", "Binny Ltd.", "Bio Green Industries Ltd.", "Bio Whitegold Industries Ltd.", "Biocon Ltd.", "Biofil Chemicals & Pharmaceuticals Ltd.", "Biopac India Corporation Ltd.", "Birla Corporation Ltd.", "Birla Cotsyn (India) Ltd.", "Birla Ericsson Optical Ltd.", "Birla Leasing & Infrastructure Ltd.", "Birla Power Solutions Ltd.", "Birla Precision Technologies Ltd.", "Birla Shloka Edutech Ltd.", "Birla Transasia Carpets Ltd.", "Bisil Plast Ltd.", "BITS Ltd.", "BJ Duplex Boards Ltd.", "BK Duplex Board Ltd.", "BKV Industries Ltd.", "Black Rose Industries Ltd.", "BLB Ltd.", "Bliss GVS Pharma Ltd.", "Bloom Dekor Ltd.", "Bloom Industries Ltd.", "BLS Infotech Ltd.", "Blue Bird (India) Ltd.", "Blue Blends (India) Ltd.", "Blue Blends Finance Ltd.", "Blue Chip India Ltd.", "Blue Chip Tex Industries Ltd.", "Blue Circle Services Ltd.", "Blue Coast Hotels Ltd.", "Blue Dart Express Ltd.", "Blue Star Infotech Ltd.", "Blue Star Ltd.", "BNK Capital Markets Ltd.", "BNR Udyog Ltd", "Bobshell Electrodes Ltd.", "BOC India Ltd.", "Bodal Chemicals Ltd.", "Bokadia Films Ltd.", "Bombay Burmah Trading Corporation Ltd.", "Bombay Cycle & Motor Agency Ltd.", "Bombay Dyeing & Manufacturing Company Ltd.", "Bombay Oxygen Corporation Ltd.", "Bombay Paints Ltd.", "Bombay Potteries & Tiles Ltd.", "Bombay Rayon Fashions Ltd.", "Bombay Swadeshi Stores Ltd.", "Bombay Talkies Ltd.", "Bonanza Industries Ltd.", "Bongaigaon Refinery & Petrochemicals Ltd.[Merged]", "Borax Morarji Ltd.", "Borosil Glass Works Ltd.", "Bosch Chassis Systems India Ltd.", "Bosch Ltd.", "Boston Bio Systems Ltd.", "Boston Education and Software Technologies Ltd.", "BPL Ltd.", "Brabourne Enterprises Ltd.", "Brady & Morris Engg Co Ltd.", "Brahmanand Himghar Ltd.", "Brahmaputra Infraproject Ltd.", "Brakes Auto (India) Ltd.", "Brand Realty Services Ltd.", "Brandhouse Retails Ltd.", "Brawn Pharmaceuticals Ltd.", "Brescon Corporate Advisors Ltd.", "Bridge Securities Ltd.", "Brigade Enterprises Ltd.", "Bright Brothers Ltd.", "Brijlaxmi Leasing & Finance Ltd.", "Brilliant Securities Ltd.", "Brindaban Holding & Trading Ltd.", "Britannia Industries Ltd.", "Broadcast Initiatives Ltd.", "Brushman (India) Ltd.", "BS TransComm Ltd.", "BSEL Infrastructure Realty Ltd.", "BSI Ltd.", "BSL Ltd.", "Bubna Stock Broking Services Ltd.", "Burnpur Cement Ltd.", "BWL Ltd.", "C G Impex Ltd.", "C&C Constructions Ltd.", "Cable Corporation of India Ltd.", "Cadila Healthcare Ltd.", "Cairn India Ltd.", "Calcom Vision Ltd.", "California Software Company Ltd.", "Cals Refineries Ltd.", "Cambridge Solutions Ltd.", "Cambridge Technology Enterprises Ltd.", "Camex Ltd.", "Camlin Fine Chemicals Ltd.", "Camlin Ltd.", "Camphor & Allied Products Ltd.", "Camson Bio Technologies Ltd.", "Can Fin Homes Ltd.", "Canara Bank", "Cantabil Retail India Ltd.", "Capital Trust Ltd.", "Caplin Point Laboratories Ltd.", "Capman Financials Ltd.", "Capricorn Systems Global Solutions Ltd.", "Caprihans India Ltd.", "Caprolactam Chemicals Ltd.", "Carborundum Universal Ltd.", "Career Point Infosystems Ltd.", "Carnation Industries Ltd.", "Carol Info Services Ltd.", "Castrol India Ltd.", "CAT Technologies Ltd.", "Catvision Products Ltd.", "CCL International Ltd.", "CCL Products India Ltd.", "CCS Infotech Ltd.", "CDR Health Care Ltd.", "Ceat Ltd.", "Ceejay Finance Ltd.", "Ceenik Exports (India) Ltd.", "Ceeta Industries Ltd.", "Celebrity Fashions Ltd.", "Celestial Biolabs Ltd.", "Cellulose Products of India Ltd.", "Cenlub Industries Ltd.", "Centenial Surgical Suture Ltd.", "Central Bank of India", "Central Provinces Railways Company Ltd.", "Centron Industrial Alliance Ltd.", "Centrum Capital Ltd.", "Centum Electronics Ltd.", "Century 21st Portfolio Ltd.", "Century Enka Ltd.", "Century Extrusions Ltd.", "Century Plyboards (I) Ltd.", "Century Textiles & Industries Ltd.", "Cera Sanitaryware Ltd.", "Cerebra Integrated Technologies Ltd.", "CESC Ltd.", "CFL Capital Financial Services Ltd.", "CG - VAK Software & Exports Ltd.", "Chakan Vegoils Ltd.", "Chakkilam Infotech Ltd.", "Chaman Lal Setia Exports Ltd.", "Chambal Fertilisers & Chemicals Ltd.", "Chandni Textiles Engineering Industries Ltd.", "Chandra Prabhu International Ltd.", "Chandrika Traders Ltd.", "Channel Guide India Ltd.", "Charms Industries Ltd.", "Chartered Capital & Investment Ltd.", "Chartered Logistics Ltd.", "Chase Bright Steel Ltd.", "CHD Developers Ltd.", "Chembond Chemicals Ltd.", "Chemcel Biotech Ltd.", "Chemfab Alkalies Ltd.", "Chemplast Sanmar Ltd.", "Chennai Meenakshi Multispeciality Hospital Ltd.", "Chennai Petroleum Corporation Ltd.", "Cheslind Textiles Ltd.", "Chetak Spintex Ltd.", "Chettinad Cement Corporation Ltd.", "Cheviot Company Ltd.", "Chhattisgarh Industries Ltd.", "CHI Investments Ltd.", "Chicago Software Industries Ltd.", "Chisel & Hammer (Mobel) Ltd.", "Chitradurga Spintex Ltd.", "CHL Ltd.", "Choice International Ltd.", "Chokhani Securities Ltd.", "Choksi Imaging Ltd.", "Choksi Laboratories Ltd.", "Cholamandalam Investment & Finance Company Ltd.", "Chordia Food Products Ltd.", "Chowgule Steamships Ltd.", "Chromatic India Ltd.", "Ciba India Ltd. [Merged]", "CIL Securities Ltd.", "Cimmco Ltd.", "Cindrella Financial Services Ltd.", "Cindrella Hotels Ltd.", "Cinemax India Ltd.", "Cinerad Communications Ltd.", "Cinevistaas Ltd.", "Cipla Ltd.", "Circuit Systems (India) Ltd.", "Citadel Realty & Developers Ltd.", "Citi Port Financial Services Ltd.", "Citurgia Biochemicals Ltd.", "City Hospitalities India Ltd.", "City Union Bank Ltd.", "Cityman Ltd.", "CJ Gelatine Products Ltd.", "Clariant Chemicals (India) Ltd.", "Clarisis Organics Ltd.", "Clarus Finance & Securities Ltd.", "Classic Biotech & Exports Ltd.", "Classic Diamonds (India) Ltd.", "Classic Electricals Ltd.", "Classic Press (International) Ltd.", "CLIO Infotech Ltd.", "Clutch Auto Ltd.", "CMC Ltd.", "CMI FPE Ltd.", "CMI Ltd.", "CMS Finvest Ltd.", "CNI Research Ltd.", "Coal India Ltd.", "Coastal Roadways Ltd.", "Cochin Minerals & Rutile Ltd.", "Colgate-Palmolive (India) Ltd.", "Colinz Laboratories Ltd.", "Color Chips (India) Ltd.", "Combat Drugs Ltd.", "Comfort Intech Ltd.", "Commercial Engineers & Body Builders Co Ltd.", "Comp-u-Learn Tech India Ltd.", "Compact Disc India Ltd.", "Competent Automobiles Co Ltd.", "Compuage Infocom Ltd.", "Compucom Software Ltd.", "Compudyne Winfosystems Ltd.", "Compulink Systems Ltd.", "Computech International Ltd.", "Computer Point Ltd.", "Computerskill Ltd.", "Conart Engineers Ltd.", "Concurrent (India) Infrastructure Ltd.", "Confidence Petroleum Ltd.", "Consolidated Construction Consortium Ltd.", "Consolidated Fibres And Chemicals Ltd.", "Consolidated Securities Ltd.", "Consortex Karl Doelitzsch (India) Ltd.", "Container Corporation of India Ltd.", "Contil India Ltd.", "Continental Chemicals Ltd.", "Continental Controls Ltd.", "Continental Petroleums Ltd.", "Control Print Ltd.", "Coral Hub Ltd.", "Coral India Finance & Housing Ltd.", "Coral Laboratories Ltd.", "Coral Newsprints Ltd.", "Cords Cable Industries Ltd.", "Core Healthcare Ltd.", "Core Projects & Technologies Ltd.", "Coromandel Agro Products and Oils Ltd.", "Coromandel Engineering Company Ltd.", "Coromandel International Ltd.", "Corporate Couriers & Cargo Ltd.", "Corporation Bank", "Cosboard Industries Ltd.", "Cosco (India) Ltd.", "Cosmo Ferrites Ltd.", "Cosmo Films Ltd.", "Country Club (India) Ltd", "Country Condo's Ltd.", "Coventry Coil-O-Matic (Haryana) Ltd.", "Coventry Springs & Engg. Co. Ltd.", "Cox & Kings Ltd.", "CPEC Ltd.", "Cranes Software International Ltd.", "Cranex Ltd.", "Cravatex Ltd.", "Crazy Infotech Ltd.", "Creative Eye Ltd.", "Credence Sound & Vision Ltd.", "Cressanda Solutions Ltd.", "Crest Animation Studios Ltd.", "Crestchem Ltd.", "Crew B.O.S Products Ltd.", "Crimson Metal Engineering Company Ltd.", "Crisil Ltd.", "Crompton Greaves Ltd.", "Crystal Software Solutions Ltd.", "CSJ Technologies Ltd.", "CSS Technergy Ltd.", "CTR Manufacturing Industries Ltd.", "Cubex Tubings Ltd.", "Cubical Financial Services Ltd.", "Cummins India Ltd.", "Cupid Ltd.", "Cupid Trades & Finance Ltd.", "Cura Technologies Ltd.", "Cybele Industries Ltd.", "Cyber Media (India) Ltd.", "Cybermate Infotek Ltd.", "Cyberscape Multimedia Ltd.", "Cybertech Systems & Software Ltd.", "D & H Welding Electrodes (India) Ltd.", "D B (International) Stock Brokers Ltd.", "D B Realty Ltd.", "D-Link (India) Ltd.", "Dabur India Ltd.", "Daewoo Motors India Ltd.", "Dagger-forst Tools Ltd.", "Dahyabhai Sons Ltd.", "Dai Ichi Karkaria Ltd.", "Daikaffil Chemicals India Ltd.", "Dairyfield Ltd.", "Dalal Street Investments Ltd.", "Dalmia Bharat Sugar and Industries Ltd.", "Damodar Threads Ltd.", "Danlaw Technologies Ltd.", "Darshan Oils Ltd.", "Database Finance Ltd.", "Datamatics Global Services Ltd.", "Datanet Systems Ltd.", "Datapro Information Technology Ltd.", "Datar Switchgear Ltd.", "Datasoft Application Software (India) Ltd.", "Dazzel Confindive Ltd.", "DB Corp Ltd.", "DCM Financial Services Ltd.", "DCM Ltd.", "DCM Shriram Consolidated Ltd.", "DCM Shriram Industries Ltd.", "DCW Ltd.", "De Nora India Ltd.", "Deccan Bearings Ltd.", "Deccan Cements Ltd.", "Deccan Chronicle Holdings Ltd.", "Deccan Gold Mines Ltd.", "Deco-Mica Ltd.", "Decolight Ceramics Ltd.", "Decora Tubes Ltd.", "Deep Industries Ltd.", "Deepak Fertilizers & Petrochemicals Corp. Ltd.", "Deepak Nitrite Ltd.", "Deepak Spinners Ltd.", "Delta Corp Ltd.", "Delta Magnets Ltd.", "Delton Cables Ltd.", "Deltron Ltd.", "Den Networks Ltd.", "Dena Bank", "Denso India Ltd.", "Desh Rakshak Aushdhalaya Ltd.", "Design Auto System Ltd.", "Development Credit Bank Ltd.", "Devika Proteins Ltd.", "Devine Impex Ltd.", "Devki Leasing & Finance Ltd.", "Dewan Housing Finance Corporation Ltd.", "Dewan Rubber Industries Ltd.", "Dewan Tyres Ltd.", "DFM Foods Ltd.", "DGP Securities Ltd.", "Dhampur Sugar Mills Ltd.", "Dhampure Specialty Sugars Ltd.", "Dhanalaxmi Roto Spinners Ltd.", "Dhandapani Finance Ltd.", "Dhanlaxmi Bank Ltd.", "Dhanlaxmi Cotex Ltd.", "Dhanlaxmi Fabrics Ltd.", "Dhanuka Agritech Ltd.", "Dhanus Technologies Ltd.", "Dhanvantri Jeevan Rekha Ltd.", "Dhar Textile Mills Ltd.", "Dharamsi Morarji Chemicals Company Ltd.", "Dharani Finance Ltd.", "Dharani Sugars & Chemicals Ltd.", "Dharanidhar Global and Infraprojects Ltd.", "Dhoot Industrial Finance Ltd.", "Dhoot Industries Ltd.", "DHP India Ltd.", "Dhruv Estates Ltd.", "Dhruva Capital Services Ltd.", "Dhunseri Petrochem & Tea Ltd.", "Dhvanil Chemicals Ltd.", "Diamant Infrastructure Ltd.", "Diamines & Chemicals Ltd.", "Diamond Power Infrastructure Ltd.", "Diana Tea Company Ltd.", "DIC India Ltd.", "Digital Multiforms Ltd.", "Digjam Ltd.", "DIL Ltd.", "Dina Iron & Steel Ltd.", "Dinesh Allorga Ltd.", "Disa India Ltd.", "Dish TV India Ltd.", "Dishman Pharmaceuticals & Chemicals Ltd", "Divi's Laboratories Ltd.", "Divya Jyothi Industries Ltd.", "Divyashakti Granites Ltd.", "DJS Stock & Shares Ltd.", "DLF Ltd.", "DMC Education Ltd.", "Doctors Biotech India Ltd.", "Dolat Investments Ltd.", "Dollex Industries Ltd.", "Dolphin Medical Services Ltd.", "Dolphin Offshore Enterprises (India) Ltd.", "Donear Industries Ltd.", "Doon Valley Rice Ltd.", "DPIL Ltd.", "DQ Entertainment (International) Ltd.", "Dr. Agarwal's Eye Hospital Ltd.", "Dr. Reddy's Laboratories Ltd.", "Dredging Corporation Of India Ltd.", "Drillco Metal Carbides Ltd.", "DS Kulkarni Developers Ltd.", "Duck Tarpaulins Ltd.", "Dujodwala Paper Chemicals Ltd.", "Dujodwala Products Ltd.", "Duke Offshore Ltd.", "Duncans Industries Ltd.", "Dunlop India Ltd.", "Dutron Polymers Ltd.", "Dwarikesh Sugar Industries Ltd.", "Dynacons Systems & Solutions Ltd.", "Dynamatic Technologies Ltd.", "Dynamic Industries Ltd.", "Dynamic Microsteppers Ltd.", "Dynavision Ltd.", "Dynemic Products Ltd.", "E-Metals India Ltd.", "E.com Infotech (India) Ltd.", "E.Star Infotech Ltd.", "Eastcoast Steel Ltd.", "Eastern Gases Ltd.", "Eastern Silk Industries Ltd.", "Eastern Sugar & Industries Ltd.", "Eastern Treads Ltd.", "Easun Reyrolle Ltd.", "Easy Fincorp Ltd.", "ECE Industries Ltd.", "eClerx Services Ltd.", "Ecoboard Industries Ltd.", "Ecoplast Ltd.", "Edelweiss Capital Ltd.", "Edserv Softsystems Ltd.", "Educomp Solutions Ltd.", "Eicher Motors Ltd.", "EID Parry (India) Ltd.", "EIH Associated Hotels Ltd.", "EIH Ltd.", "Eimco Elecon (India) Ltd.", "EL Forge Ltd.", "Elango Industries Ltd.", "Elantas Beck India Ltd.", "Elbee Services Ltd.", "Elcid Investments Ltd.", "Elcon Finlease & Industries Ltd.", "Eldeco Housing & Industries Ltd.", "Elder Health Care Ltd.", "Elder Pharmaceuticals Ltd.", "Elder Projects Ltd.", "Elecon Engineering Company Ltd.", "Electrex (India) Ltd.", "Electrosteel Castings Ltd.", "Electrosteel Steels Ltd.", "Electrotherm (India) Ltd.", "Elegant Floriculture & Agrotech (I) Ltd.", "Elegant Marbles & Grani Industries Ltd.", "Elf Trading & Chemicals Manufacturing Ltd.", "Elgi Equipments Ltd.", "Elgi Industrial Products Ltd.", "Elgi Rubber Company Ltd.", "Ellenbarri Industrial Gases Ltd.", "Ellora Paper Mills Ltd.", "Elnet Technologies Ltd.", "Elpro International Ltd.", "Elpro Packaging Ltd.", "EMA India Ltd.", "Emami Infrastructure Ltd.", "Emami Ltd.", "Emami Paper Mills Ltd.", "Emco Ltd.", "Emergent Energy and Services Ltd.", "Emgee Cables And Communications Ltd.", "Emkay Global Financial Services Ltd.", "Emmbi Polyarns Ltd.", "Emmessar Biotech & Nutrition Ltd.", "Emmsons International Ltd.", "Empee Distilleries Ltd.", "Empee Sugars and Chemicals Ltd.", "Empire Industries Ltd.", "Emporis Projects Ltd.", "Empower Industries India Ltd.", "Emtex Industries (India) Ltd.", "Enbee Trade & Finance Ltd.", "Enchante Jewellery Ltd.", "Encore Software Ltd.", "Energy Development Company Ltd.", "Energy Products (India) Ltd.", "Engineers India Ltd.", "English Indian Clays Ltd.", "Enkay Texofood Industries Ltd.", "Enkei Castalloy Ltd.", "Ennore Coke Ltd.", "Enrich Industries Ltd.", "Ensa Steel Industries Ltd.", "Enso Secutrack Ltd.", "Entegra Ltd.", "Enterprise International Ltd.", "Entertainment Network (India) Ltd.", "Envair Electrodyne Ltd.", "Eonour Technologies Ltd.", "EPC Industrie Ltd.", "EPIC Energy Ltd.", "EPIC Enzymes Pharmaceuticals & Industrial Chemicals Ltd.", "EPSOM Properties Ltd.", "Equipment Conductors & Cables Ltd.", "Era E-Zone India Ltd.", "Era Infra Engineering Ltd.", "Eros International Media Ltd.", "Esab India Ltd.", "Escorts Finance Ltd.", "Escorts Ltd.", "Eskay Kn'IT (India) Ltd.", "Esquire Money Guarantees Ltd.", "Ess Dee Aluminium Ltd.", "Essar Oil Ltd.", "Essar Securities Ltd.", "Essar Shipping Ports & Logistics Ltd.", "Essar Steel Ltd.", "Essel Propack Ltd.", "Essen Suppliments India Ltd.", "Esskay Telecom Ltd.", "Ester Industries Ltd.", "ETC Networks Ltd.", "ETP Corporation Ltd.", "Euro Ceramics Ltd.", "Euro Finmart Ltd.", "Euro Leder Fashions Ltd.", "Euro Multivision Ltd.", "Eurotex Industries & Exports Ltd.", "Eveready Industries India Ltd.", "Everest Industries Ltd.", "Everest Kanto Cylinder Ltd.", "Everest Organics Ltd.", "Everlon Synthetics Ltd.", "Everonn Education Ltd.", "Evinix Industries Ltd.", "Excel Crop Care Ltd.", "Excel Glasses Ltd.", "Excel Industries Ltd.", "Excel Infoways Ltd.", "Exdon Trading Company Ltd.", "Exedy India Ltd.", "Exelon Infrastructure Ltd.", "Exide Industries Ltd.", "Explicit Finance Ltd.", "Expo Gas Containers Ltd.", "Exxoteq Corporation Ltd.", "Ez-Comm Trade Technologies Ltd.", "Facor Alloys Ltd.", "Facor Steels Ltd.", "Fact Enterprise Ltd.", "Fag Bearings India Ltd.", "Fairdeal Filaments Ltd.", "Fairfield Atlas Ltd.", "FAL Industries Ltd.(Merged)", "Falcon Tyres Ltd.", "Fame India Ltd.", "Farmax India Ltd.", "Farry Industries Ltd.", "Fast Track Entertainment Ltd.", "Faze Three Ltd.", "FCI OEN Connectors Ltd.", "FCS Software Solutions Ltd.", "FDC Ltd.", "Fedders Lloyd Corporation Ltd.", "Federal Bank Ltd.", "Federal-Mogul Goetze (India) Ltd.", "Fem Care Pharma Ltd.", "Fenoplast Ltd.", "Ferro Alloys Corporation Ltd.", "Fertilisers and Chemicals Travancore Ltd.", "FGP Ltd.", "Fiberweb (India) Ltd.", "Ficon Lease & Finance Ltd.", "FIEM Industries Ltd.", "Filaments India Ltd.", "Filatex Fashions Ltd.", "Filatex India Ltd.", "Filmcity Media Ltd.", "Financial Eyes (India) Ltd.", "Financial Technologies (India) Ltd.", "Fine Line Circuits Ltd.", "Finolex Cables Ltd.", "Finolex Industries Ltd.", "Fintech Communication Ltd.", "First Custodian Fund (India) Ltd.", "First Leasing Company of India Ltd.", "First Winner Industries Ltd.", "Firstobject Technologies Ltd.", "Firstsource Solutions Ltd.", "Fischer Chemic Ltd.", "Flawless Diamond (india) Ltd.", "Flex Engineering Ltd.", "Flex Foods Ltd.", "Flextronics Software Systems Ltd.", "Fluidomat Ltd.", "Fomento Resorts & Hotels Ltd.", "Foods & Inns Ltd.", "Forbes & Company Ltd.", "Force Motors Ltd.", "Fortis Healthcare Ltd.", "Fortis Malar Hospitals Ltd.", "Fortune Financial Services (India) Ltd.", "Fortune International Ltd.", "Foseco India Ltd.", "Foundry Fuel Products Ltd.", "Four Soft Ltd.", "Fourth Generation Information Systems Ltd.", "Fresenius Kabi Oncology Ltd.", "Freshtrop Fruits Ltd.", "Frontier Information Technologies Ltd.", "Frontier Leasing & Finance Ltd.", "Frontier Springs Ltd.", "Frontline Business Solutions Ltd.", "Frontline Corporation Ltd.", "Frontline Securities Ltd.", "Fulford (India) Ltd.", "Funworld & Tourism Development Ltd.", "Fusion Fittings (I) Ltd.", "Futura Polyesters Ltd.", "Future Capital Holdings Ltd.", "Futuristic Offshore Services & Chemical Ltd.", "Futuristic Securities Ltd.", "G G Automotive Gears Ltd.", "G G Dandekar Machine Works Ltd.", "G M Breweries Ltd.", "G R Cables Ltd.", "G S Auto International Ltd.", "G V Films Ltd.", "G-Tech Info-Training Ltd.", "Gabriel India Ltd.", "Gaekwar Mills Ltd.", "Gagan Gases Ltd.", "GAIL (India) Ltd.", "Gajra Bevel Gears Ltd.", "Galada Power & Telecommunications Ltd.", "Galaxy Bearing Ltd.", "Galaxy Entertainment Corporation Ltd.", "Gallantt Ispat Ltd.", "Gallantt Metal Ltd.", "Galore Prints Industries Ltd.", "Gamma Infoway Exalt Ltd.", "Gammon India Ltd.", "Gammon Infrastructure Projects Ltd.", "Gandhi Special Tubes Ltd.", "Gandhimathi Appliances Ltd.", "Gandhinagar Hotels Ltd.", "Gandhinagar Leasing & Finance Ltd.", "Ganesh Benzoplast Ltd.", "Ganesh Holding Ltd.", "Ganesh Housing Corporation Ltd.", "Ganesh Polytex Ltd.", "Gangotri Iron & Steel Company Ltd.", "Gangotri Textile Ltd.", "Garden Silk Mills Ltd.", "Garg Furnace Ltd.", "Garlon Industries Ltd.", "Garnet Construction Ltd.", "Garnet International Ltd.", "Garware Marine Industries Ltd.", "Garware Offshore Services Ltd.", "Garware Polyester Ltd.", "Garware Synthetics Ltd.", "Garware-Wall Ropes Ltd.", "Gateway Distriparks Ltd.", "Gati Ltd.", "Gayatri BioOrganics Ltd.", "Gayatri Projects Ltd.", "Gayatri Sugars Ltd.", "Gayatri Tissue & Papers Ltd.", "GCV Services Ltd.", "GDL Leasing & Finance Ltd.", "GDR Media Ltd.", "GE Capital Transportation Financial Services Ltd", "Gee Gee Granites Ltd.", "GEE Ltd.", "GeeCee Ventures Ltd.", "Geefcee Finance Ltd.", "Geekay Exim (India) Ltd.", "GEI Industrial Systems Ltd.", "Gem Cables and Conductors Ltd.", "Gem Spinners India Ltd.", "Gemini Communication Ltd.", "Gemstone Investments Ltd.", "Genesys International Corporation Ltd.", "Gennex Laboratories Ltd.", "Genomics Biotech Ltd.", "Genus Commu-Trade Ltd.", "Genus Power Infrastructures Ltd.", "Genus Prime Infra Ltd.", "Geodesic Ltd.", "Geojit BNP Paribas Financial Services Ltd.", "Geologging Industries Ltd.", "Geometric Ltd.", "Ghanshyam Steel Works Ltd.", "GHCL Ltd.", "GI Engineering Solutions Ltd.", "GIC Housing Finance Ltd.", "Gillanders Arbuthnot & Company Ltd.", "Gillette India Ltd.", "Gilt Pack Ltd.", "Gini Silk Mills Ltd.", "Ginni Filaments Ltd.", "Girdharilal Sugar & Allied Industries Ltd.", "Girnar Fibres Ltd.", "Gitanjali Gems Ltd.", "Givo Ltd.", "GK Consultants Ltd.", "GKB Ophthalmics Ltd.", "Glance Finance Ltd.", "GlaxoSmithKline Consumer Healthcare Ltd.", "GlaxoSmithKline Pharmaceuticals Ltd.", "Gleitlager (India) Ltd.", "Glenmark Pharmaceuticals Ltd.", "Glittek Granites Ltd.", "Global Boards Ltd.", "Global Capital Markets Ltd.", "Global Infrastructure & Technologies Ltd.", "Global Securities Ltd.", "Global Syntex (Bhilwara) Ltd.", "Global Vectra Helicorp Ltd.", "Globsyn Infotech Ltd.", "Globus Constructors & Developers Ltd.", "Globus Corporation Ltd.", "Globus Spirits Ltd.", "Glodyne Technoserve Ltd.", "Glory Polyfilms Ltd.", "Gloster Ltd.", "GMM Pfaudler Ltd.", "GMR Ferro Alloys & Industries Ltd.", "GMR Infrastructure Ltd.", "Goa Carbons Ltd.", "Godavari Drugs Ltd.", "Godavari Fertilizers and Chemicals Ltd.", "Godawari Power & Ispat Ltd.", "Godfrey Philips India Ltd.", "Godrej Consumer Products Ltd.", "Godrej Industries Ltd.", "Godrej Properties Ltd.", "Goenka Diamond & Jewels Ltd.", "Gogia Capital Services Ltd.", "Gokak Textiles Ltd.", "Gokaldas Exports Ltd.", "Gokul Refoils & Solvent Ltd.", "Gold Rock Investments Ltd.", "Goldcrest Finance (India) Ltd.", "Golden Carpets Ltd.", "Golden Legand Leasing & Finance Ltd.", "Golden Securities Ltd."})
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(13, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(268, 29)
        Me.TextBox1.TabIndex = 0
        '
        'BtnUpload
        '
        Me.BtnUpload.Font = New System.Drawing.Font("Century Schoolbook", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpload.ForeColor = System.Drawing.Color.Navy
        Me.BtnUpload.Location = New System.Drawing.Point(117, 51)
        Me.BtnUpload.Name = "BtnUpload"
        Me.BtnUpload.Size = New System.Drawing.Size(117, 32)
        Me.BtnUpload.TabIndex = 4
        Me.BtnUpload.Text = "Upload"
        Me.BtnUpload.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnBrowse)
        Me.Panel1.Controls.Add(Me.tbFilePath)
        Me.Panel1.Controls.Add(Me.BtnUpload)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(774, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(423, 94)
        Me.Panel1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(415, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Click on Browse,select the file and then Upload::  To upload the daily BhavCopy"
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBrowse.Location = New System.Drawing.Point(319, 24)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(97, 24)
        Me.BtnBrowse.TabIndex = 6
        Me.BtnBrowse.Text = "Browse..."
        Me.BtnBrowse.UseVisualStyleBackColor = True
        '
        'tbFilePath
        '
        Me.tbFilePath.Location = New System.Drawing.Point(6, 27)
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.ReadOnly = True
        Me.tbFilePath.Size = New System.Drawing.Size(307, 20)
        Me.tbFilePath.TabIndex = 5
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Navy
        Me.TextBox2.Location = New System.Drawing.Point(88, 566)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(176, 23)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Visible = False
        '
        'lblCoName
        '
        Me.lblCoName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCoName.AutoSize = True
        Me.lblCoName.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoName.ForeColor = System.Drawing.Color.Navy
        Me.lblCoName.Location = New System.Drawing.Point(11, 2)
        Me.lblCoName.Name = "lblCoName"
        Me.lblCoName.Size = New System.Drawing.Size(78, 19)
        Me.lblCoName.TabIndex = 7
        Me.lblCoName.Text = "CoName"
        Me.lblCoName.Visible = False
        '
        'Panel2
        '
        Me.Panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblCoName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 387)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(974, 28)
        Me.Panel2.TabIndex = 8
        Me.Panel2.Tag = "DataShowPanel"
        Me.Panel2.Visible = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 163)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(230, 224)
        Me.WebBrowser1.TabIndex = 14
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(543, 496)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "AstiTatva © 2011 · English (India)"
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel3.Location = New System.Drawing.Point(5, 29)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(324, 94)
        Me.Panel3.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Or Press 'Enter' to see the result"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.search_icon
        Me.Button1.Location = New System.Drawing.Point(279, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.WebBrowser1)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1199, 458)
        Me.SplitContainer1.SplitterDistance = 221
        Me.SplitContainer1.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Century Schoolbook", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 130)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Other Tasks :"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnFundamentalRatios, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnResults, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnRatios, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnSync, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Century Schoolbook", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(209, 111)
        Me.TableLayoutPanel2.TabIndex = 17
        '
        'BtnFundamentalRatios
        '
        Me.BtnFundamentalRatios.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnFundamentalRatios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnFundamentalRatios.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnFundamentalRatios.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnFundamentalRatios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFundamentalRatios.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFundamentalRatios.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnFundamentalRatios.Location = New System.Drawing.Point(1, 84)
        Me.BtnFundamentalRatios.Margin = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.BtnFundamentalRatios.Name = "BtnFundamentalRatios"
        Me.BtnFundamentalRatios.Size = New System.Drawing.Size(226, 26)
        Me.BtnFundamentalRatios.TabIndex = 19
        Me.BtnFundamentalRatios.Text = "Fundamental Ratios"
        Me.BtnFundamentalRatios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFundamentalRatios.UseVisualStyleBackColor = False
        '
        'BtnResults
        '
        Me.BtnResults.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnResults.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnResults.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResults.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResults.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnResults.Location = New System.Drawing.Point(1, 56)
        Me.BtnResults.Margin = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.BtnResults.Name = "BtnResults"
        Me.BtnResults.Size = New System.Drawing.Size(226, 27)
        Me.BtnResults.TabIndex = 18
        Me.BtnResults.Text = "Annual Results"
        Me.BtnResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnResults.UseVisualStyleBackColor = False
        '
        'BtnRatios
        '
        Me.BtnRatios.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnRatios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRatios.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnRatios.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnRatios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRatios.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRatios.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnRatios.Location = New System.Drawing.Point(1, 28)
        Me.BtnRatios.Margin = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.BtnRatios.Name = "BtnRatios"
        Me.BtnRatios.Size = New System.Drawing.Size(226, 27)
        Me.BtnRatios.TabIndex = 17
        Me.BtnRatios.Text = "Sorted Ratios "
        Me.BtnRatios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRatios.UseVisualStyleBackColor = False
        '
        'BtnSync
        '
        Me.BtnSync.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnSync.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSync.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnSync.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSync.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSync.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnSync.Location = New System.Drawing.Point(1, 1)
        Me.BtnSync.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnSync.Name = "BtnSync"
        Me.BtnSync.Size = New System.Drawing.Size(226, 26)
        Me.BtnSync.TabIndex = 16
        Me.BtnSync.Text = "Sync Quarterly data"
        Me.BtnSync.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSync.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Century Schoolbook", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Navy
        Me.Button2.Location = New System.Drawing.Point(0, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Live Stock Values"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageSync)
        Me.TabControl1.Controls.Add(Me.TabPageRatios)
        Me.TabControl1.Controls.Add(Me.TabPageAnnualResults)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(974, 458)
        Me.TabControl1.TabIndex = 13
        Me.TabControl1.Visible = False
        '
        'TabPageSync
        '
        Me.TabPageSync.ImageIndex = 0
        Me.TabPageSync.Location = New System.Drawing.Point(4, 23)
        Me.TabPageSync.Name = "TabPageSync"
        Me.TabPageSync.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSync.Size = New System.Drawing.Size(966, 431)
        Me.TabPageSync.TabIndex = 0
        Me.TabPageSync.Text = "Sync Data"
        Me.TabPageSync.UseVisualStyleBackColor = True
        '
        'TabPageRatios
        '
        Me.TabPageRatios.ImageIndex = 1
        Me.TabPageRatios.Location = New System.Drawing.Point(4, 23)
        Me.TabPageRatios.Name = "TabPageRatios"
        Me.TabPageRatios.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageRatios.Size = New System.Drawing.Size(966, 431)
        Me.TabPageRatios.TabIndex = 1
        Me.TabPageRatios.Text = "Ratios"
        Me.TabPageRatios.UseVisualStyleBackColor = True
        '
        'TabPageAnnualResults
        '
        Me.TabPageAnnualResults.ImageIndex = 2
        Me.TabPageAnnualResults.Location = New System.Drawing.Point(4, 23)
        Me.TabPageAnnualResults.Name = "TabPageAnnualResults"
        Me.TabPageAnnualResults.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAnnualResults.Size = New System.Drawing.Size(966, 431)
        Me.TabPageAnnualResults.TabIndex = 2
        Me.TabPageAnnualResults.Text = "Annual Results"
        Me.TabPageAnnualResults.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "sync.jpg")
        Me.ImageList1.Images.SetKeyName(1, "finance-ratios.jpg")
        Me.ImageList1.Images.SetKeyName(2, "Financial-Results.gif")
        '
        'EQ130410BindingSource
        '
        Me.EQ130410BindingSource.DataMember = "EQ130410"
        Me.EQ130410BindingSource.DataSource = Me.Grand_databaseDataSet
        '
        'Grand_databaseDataSet
        '
        Me.Grand_databaseDataSet.DataSetName = "Grand_databaseDataSet"
        Me.Grand_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitContainerH
        '
        Me.SplitContainerH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerH.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerH.Name = "SplitContainerH"
        Me.SplitContainerH.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerH.Panel1
        '
        Me.SplitContainerH.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainerH.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainerH.Panel1.Controls.Add(Me.ProgressBar1)
        Me.SplitContainerH.Panel1.Controls.Add(Me.Panel3)
        Me.SplitContainerH.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainerH.Panel1.Controls.Add(Me.MenuStrip1)
        Me.SplitContainerH.Panel1.Padding = New System.Windows.Forms.Padding(5)
        '
        'SplitContainerH.Panel2
        '
        Me.SplitContainerH.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainerH.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainerH.Size = New System.Drawing.Size(1199, 682)
        Me.SplitContainerH.SplitterDistance = 128
        Me.SplitContainerH.TabIndex = 16
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(383, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.Location = New System.Drawing.Point(501, 74)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 14
        Me.ProgressBar1.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(5, 5)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1189, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnResults1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnRatios1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Century Schoolbook", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'BtnResults1
        '
        Me.BtnResults1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnResults1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnResults1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnResults1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnResults1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResults1.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResults1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnResults1.Location = New System.Drawing.Point(1, 40)
        Me.BtnResults1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.BtnResults1.Name = "BtnResults1"
        Me.BtnResults1.Size = New System.Drawing.Size(220, 59)
        Me.BtnResults1.TabIndex = 18
        Me.BtnResults1.Text = "Annual Results"
        Me.BtnResults1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnResults1.UseVisualStyleBackColor = False
        '
        'BtnRatios1
        '
        Me.BtnRatios1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnRatios1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRatios1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnRatios1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnRatios1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRatios1.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRatios1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnRatios1.Location = New System.Drawing.Point(1, 20)
        Me.BtnRatios1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.BtnRatios1.Name = "BtnRatios1"
        Me.BtnRatios1.Size = New System.Drawing.Size(220, 19)
        Me.BtnRatios1.TabIndex = 17
        Me.BtnRatios1.Text = "Sorted Ratios "
        Me.BtnRatios1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRatios1.UseVisualStyleBackColor = False
        '
        'BtnSync1
        '
        Me.BtnSync1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnSync1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSync1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnSync1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnSync1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSync1.Font = New System.Drawing.Font("Century Schoolbook", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSync1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnSync1.Location = New System.Drawing.Point(1, 1)
        Me.BtnSync1.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnSync1.Name = "BtnSync1"
        Me.BtnSync1.Size = New System.Drawing.Size(226, 28)
        Me.BtnSync1.TabIndex = 16
        Me.BtnSync1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSync1.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 660)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1199, 22)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1199, 682)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainerH)
        Me.Controls.Add(Me.TextBox2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Asti Tatva"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        CType(Me.EQ130410BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grand_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerH.Panel1.ResumeLayout(False)
        Me.SplitContainerH.Panel1.PerformLayout()
        Me.SplitContainerH.Panel2.ResumeLayout(False)
        Me.SplitContainerH.Panel2.PerformLayout()
        Me.SplitContainerH.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Grand_databaseDataSet As WindowsApplication1.Grand_databaseDataSet
    Friend WithEvents EQ130410BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BtnUpload As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnBrowse As System.Windows.Forms.Button
    Friend WithEvents tbFilePath As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblCoName As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SplitContainerH As System.Windows.Forms.SplitContainer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnResults As System.Windows.Forms.Button
    Friend WithEvents BtnRatios As System.Windows.Forms.Button
    Friend WithEvents BtnSync As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnResults1 As System.Windows.Forms.Button
    Friend WithEvents BtnRatios1 As System.Windows.Forms.Button
    Friend WithEvents BtnSync1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageSync As System.Windows.Forms.TabPage
    Friend WithEvents TabPageRatios As System.Windows.Forms.TabPage
    Friend WithEvents TabPageAnnualResults As System.Windows.Forms.TabPage
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents BtnFundamentalRatios As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
