namespace lsmash_gui
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.About = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Clear_vtrack_name = new System.Windows.Forms.Button();
            this.FPS_Value = new System.Windows.Forms.ComboBox();
            this.vtrack_name = new System.Windows.Forms.TextBox();
            this.Vname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.open_videofile = new System.Windows.Forms.Button();
            this.Videopath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.Audiopath = new System.Windows.Forms.TextBox();
            this.openaudio = new System.Windows.Forms.Button();
            this.Language = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.Lang_Value = new System.Windows.Forms.ComboBox();
            this.Aname = new System.Windows.Forms.Label();
            this.atrack_name = new System.Windows.Forms.TextBox();
            this.Clear_atrack_name = new System.Windows.Forms.Button();
            this.ADelay = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.ADelay_Value = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.Chapters = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.Chapterpath = new System.Windows.Forms.TextBox();
            this.openchapter = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.muxed = new System.Windows.Forms.Label();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.outputpath = new System.Windows.Forms.TextBox();
            this.selectpath = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.logs = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.Start = new System.Windows.Forms.Button();
            this.Clear_All = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADelay_Value)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // About
            // 
            this.About.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Location = new System.Drawing.Point(16, 8);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(120, 40);
            this.About.TabIndex = 0;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.63291F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.36709F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel14, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.17822F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.82178F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(790, 1105);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.71831F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.28169F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 41);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(754, 141);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.39502F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.60498F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel3.Controls.Add(this.Clear_vtrack_name, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.FPS_Value, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.vtrack_name, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.Vname, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(151, 73);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(600, 65);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Clear_vtrack_name
            // 
            this.Clear_vtrack_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clear_vtrack_name.Location = new System.Drawing.Point(530, 9);
            this.Clear_vtrack_name.Name = "Clear_vtrack_name";
            this.Clear_vtrack_name.Size = new System.Drawing.Size(56, 46);
            this.Clear_vtrack_name.TabIndex = 2;
            this.Clear_vtrack_name.Text = "X";
            this.Clear_vtrack_name.UseVisualStyleBackColor = true;
            this.Clear_vtrack_name.Click += new System.EventHandler(this.Clear_vtrack_name_Click);
            // 
            // FPS_Value
            // 
            this.FPS_Value.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FPS_Value.FormattingEnabled = true;
            this.FPS_Value.Items.AddRange(new object[] {
            "24000/1001",
            "24000/1000",
            "25000/1000",
            "30000/1001",
            "30000/1000",
            "50000/1000",
            "60000/1001"});
            this.FPS_Value.Location = new System.Drawing.Point(3, 16);
            this.FPS_Value.Name = "FPS_Value";
            this.FPS_Value.Size = new System.Drawing.Size(179, 33);
            this.FPS_Value.TabIndex = 0;
            this.FPS_Value.SelectedIndexChanged += new System.EventHandler(this.FPS_Value_SelectedIndexChanged);
            // 
            // vtrack_name
            // 
            this.vtrack_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vtrack_name.Location = new System.Drawing.Point(276, 17);
            this.vtrack_name.Name = "vtrack_name";
            this.vtrack_name.Size = new System.Drawing.Size(231, 31);
            this.vtrack_name.TabIndex = 1;
            this.vtrack_name.TextChanged += new System.EventHandler(this.vtrack_name_TextChanged);
            // 
            // Vname
            // 
            this.Vname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Vname.AutoSize = true;
            this.Vname.Location = new System.Drawing.Point(192, 20);
            this.Vname.Name = "Vname";
            this.Vname.Size = new System.Drawing.Size(68, 25);
            this.Vname.TabIndex = 3;
            this.Vname.Text = "Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Video Input";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "FPS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.66666F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel4.Controls.Add(this.open_videofile, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.Videopath, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(151, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(600, 64);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // open_videofile
            // 
            this.open_videofile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.open_videofile.Location = new System.Drawing.Point(532, 9);
            this.open_videofile.Name = "open_videofile";
            this.open_videofile.Size = new System.Drawing.Size(56, 46);
            this.open_videofile.TabIndex = 0;
            this.open_videofile.Text = "...";
            this.open_videofile.UseVisualStyleBackColor = true;
            this.open_videofile.Click += new System.EventHandler(this.openvideo_Click);
            // 
            // Videopath
            // 
            this.Videopath.AllowDrop = true;
            this.Videopath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Videopath.Location = new System.Drawing.Point(3, 16);
            this.Videopath.Name = "Videopath";
            this.Videopath.ReadOnly = true;
            this.Videopath.Size = new System.Drawing.Size(514, 31);
            this.Videopath.TabIndex = 1;
            this.Videopath.DragDrop += new System.Windows.Forms.DragEventHandler(this.Videopath_DragDrop);
            this.Videopath.DragEnter += new System.Windows.Forms.DragEventHandler(this.Videopath_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Location = new System.Drawing.Point(3, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 297);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Audio";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.84021F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.15979F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.Language, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.ADelay, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 1, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(15, 47);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.17073F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.82927F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(751, 227);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Audio Input";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.58389F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.41611F));
            this.tableLayoutPanel6.Controls.Add(this.Audiopath, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.openaudio, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(151, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(596, 65);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // Audiopath
            // 
            this.Audiopath.AllowDrop = true;
            this.Audiopath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Audiopath.Location = new System.Drawing.Point(4, 17);
            this.Audiopath.Name = "Audiopath";
            this.Audiopath.ReadOnly = true;
            this.Audiopath.Size = new System.Drawing.Size(514, 31);
            this.Audiopath.TabIndex = 0;
            this.Audiopath.DragDrop += new System.Windows.Forms.DragEventHandler(this.Audiopath_DragDrop);
            this.Audiopath.DragEnter += new System.Windows.Forms.DragEventHandler(this.Audiopath_DragEnter);
            // 
            // openaudio
            // 
            this.openaudio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openaudio.Location = new System.Drawing.Point(531, 9);
            this.openaudio.Name = "openaudio";
            this.openaudio.Size = new System.Drawing.Size(56, 46);
            this.openaudio.TabIndex = 1;
            this.openaudio.Text = "...";
            this.openaudio.UseVisualStyleBackColor = true;
            this.openaudio.Click += new System.EventHandler(this.openaudio_Click);
            // 
            // Language
            // 
            this.Language.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Language.AutoSize = true;
            this.Language.Location = new System.Drawing.Point(3, 98);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(108, 25);
            this.Language.TabIndex = 2;
            this.Language.Text = "Language";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.34306F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.65693F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel7.Controls.Add(this.Lang_Value, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.Aname, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.atrack_name, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.Clear_atrack_name, 3, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(151, 75);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(596, 70);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // Lang_Value
            // 
            this.Lang_Value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lang_Value.FormattingEnabled = true;
            this.Lang_Value.Items.AddRange(new object[] {
            "abk",
            "aar",
            "afr",
            "aka",
            "alb",
            "amh",
            "ara",
            "arg",
            "arm",
            "asm",
            "ava",
            "ave",
            "aym",
            "aze",
            "bam",
            "bak",
            "baq",
            "bel",
            "ben",
            "bih",
            "bis",
            "bos",
            "bre",
            "bul",
            "bur",
            "cat",
            "cha",
            "che",
            "nya",
            "chi",
            "chv",
            "cor",
            "cos",
            "cre",
            "hrv",
            "cze",
            "dan",
            "div",
            "dut",
            "dzo",
            "eng",
            "epo",
            "est",
            "ewe",
            "fao",
            "fij",
            "fin",
            "fre",
            "ful",
            "glg",
            "geo",
            "ger",
            "gre",
            "grn",
            "guj",
            "hat",
            "hau",
            "heb",
            "her",
            "hin",
            "hmo",
            "hun",
            "ina",
            "ind",
            "ile",
            "gle",
            "ibo",
            "ipk",
            "ido",
            "ice",
            "ita",
            "iku",
            "jpn",
            "jav",
            "kal",
            "kan",
            "kau",
            "kas",
            "kaz",
            "khm",
            "kik",
            "kin",
            "kir",
            "kom",
            "kon",
            "kor",
            "kur",
            "kua",
            "lat",
            "ltz",
            "lug",
            "lim",
            "lin",
            "lao",
            "lit",
            "lub",
            "lav",
            "glv",
            "mac",
            "mlg",
            "may",
            "mal",
            "mlt",
            "mao",
            "mar",
            "mah",
            "mon",
            "nau",
            "nav",
            "nob",
            "nde",
            "nep",
            "ndo",
            "nno",
            "nor",
            "iii",
            "nbl",
            "oci",
            "oji",
            "chu",
            "orm",
            "ori",
            "oss",
            "pan",
            "pli",
            "per",
            "pol",
            "pus",
            "por",
            "que",
            "roh",
            "run",
            "rum",
            "rus",
            "san",
            "srd",
            "snd",
            "sme",
            "smo",
            "sag",
            "srp",
            "gla",
            "sna",
            "sin",
            "slo",
            "slv",
            "som",
            "sot",
            "azb",
            "spa",
            "sun",
            "swa",
            "ssw",
            "swe",
            "tam",
            "tel",
            "tgk",
            "tha",
            "tir",
            "tib",
            "tuk",
            "tgl",
            "tsn",
            "ton",
            "tur",
            "tso",
            "tat",
            "twi",
            "tah",
            "uig",
            "ukr",
            "urd",
            "uzb",
            "ven",
            "vie",
            "vol",
            "wln",
            "wel",
            "wol",
            "fry",
            "xho",
            "yid",
            "yor",
            "zha",
            "zul"});
            this.Lang_Value.Location = new System.Drawing.Point(3, 18);
            this.Lang_Value.Name = "Lang_Value";
            this.Lang_Value.Size = new System.Drawing.Size(181, 33);
            this.Lang_Value.TabIndex = 0;
            this.Lang_Value.SelectedIndexChanged += new System.EventHandler(this.Lang_Value_SelectedIndexChanged);
            // 
            // Aname
            // 
            this.Aname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aname.AutoSize = true;
            this.Aname.Location = new System.Drawing.Point(194, 22);
            this.Aname.Name = "Aname";
            this.Aname.Size = new System.Drawing.Size(68, 25);
            this.Aname.TabIndex = 1;
            this.Aname.Text = "Name";
            // 
            // atrack_name
            // 
            this.atrack_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.atrack_name.Location = new System.Drawing.Point(279, 19);
            this.atrack_name.Name = "atrack_name";
            this.atrack_name.Size = new System.Drawing.Size(229, 31);
            this.atrack_name.TabIndex = 2;
            // 
            // Clear_atrack_name
            // 
            this.Clear_atrack_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clear_atrack_name.Location = new System.Drawing.Point(529, 12);
            this.Clear_atrack_name.Name = "Clear_atrack_name";
            this.Clear_atrack_name.Size = new System.Drawing.Size(56, 46);
            this.Clear_atrack_name.TabIndex = 3;
            this.Clear_atrack_name.Text = "X";
            this.Clear_atrack_name.UseVisualStyleBackColor = true;
            this.Clear_atrack_name.Click += new System.EventHandler(this.Clear_atrack_name_Click);
            // 
            // ADelay
            // 
            this.ADelay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ADelay.AutoSize = true;
            this.ADelay.Location = new System.Drawing.Point(3, 176);
            this.ADelay.Name = "ADelay";
            this.ADelay.Size = new System.Drawing.Size(67, 25);
            this.ADelay.TabIndex = 4;
            this.ADelay.Text = "Delay";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.ADelay_Value, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(156, 153);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(586, 71);
            this.tableLayoutPanel8.TabIndex = 5;
            // 
            // ADelay_Value
            // 
            this.ADelay_Value.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ADelay_Value.Location = new System.Drawing.Point(3, 20);
            this.ADelay_Value.Name = "ADelay_Value";
            this.ADelay_Value.Size = new System.Drawing.Size(182, 31);
            this.ADelay_Value.TabIndex = 5;
            this.ADelay_Value.ValueChanged += new System.EventHandler(this.ADelay_Value_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel9);
            this.groupBox3.Location = new System.Drawing.Point(3, 527);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(784, 141);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chapter";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.10653F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.89348F));
            this.tableLayoutPanel9.Controls.Add(this.Chapters, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 1, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(15, 44);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(751, 71);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // Chapters
            // 
            this.Chapters.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Chapters.AutoSize = true;
            this.Chapters.Location = new System.Drawing.Point(3, 23);
            this.Chapters.Name = "Chapters";
            this.Chapters.Size = new System.Drawing.Size(140, 25);
            this.Chapters.TabIndex = 0;
            this.Chapters.Text = "Chapters File";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.04713F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.95286F));
            this.tableLayoutPanel10.Controls.Add(this.Chapterpath, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.openchapter, 1, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(154, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(594, 65);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // Chapterpath
            // 
            this.Chapterpath.AllowDrop = true;
            this.Chapterpath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Chapterpath.Location = new System.Drawing.Point(4, 17);
            this.Chapterpath.Name = "Chapterpath";
            this.Chapterpath.ReadOnly = true;
            this.Chapterpath.Size = new System.Drawing.Size(514, 31);
            this.Chapterpath.TabIndex = 0;
            this.Chapterpath.DragDrop += new System.Windows.Forms.DragEventHandler(this.Chapterpath_DragDrop);
            this.Chapterpath.DragEnter += new System.Windows.Forms.DragEventHandler(this.Chapterpath_DragEnter);
            // 
            // openchapter
            // 
            this.openchapter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openchapter.Location = new System.Drawing.Point(530, 9);
            this.openchapter.Name = "openchapter";
            this.openchapter.Size = new System.Drawing.Size(56, 46);
            this.openchapter.TabIndex = 1;
            this.openchapter.Text = "...";
            this.openchapter.UseVisualStyleBackColor = true;
            this.openchapter.Click += new System.EventHandler(this.openchapter_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel11);
            this.groupBox5.Location = new System.Drawing.Point(3, 674);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(784, 118);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Output";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.90546F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.09454F));
            this.tableLayoutPanel11.Controls.Add(this.muxed, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel12, 1, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(15, 27);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(751, 68);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // muxed
            // 
            this.muxed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.muxed.AutoSize = true;
            this.muxed.Location = new System.Drawing.Point(3, 21);
            this.muxed.Name = "muxed";
            this.muxed.Size = new System.Drawing.Size(147, 25);
            this.muxed.TabIndex = 0;
            this.muxed.Text = "Muxed Output";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.17567F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.82432F));
            this.tableLayoutPanel12.Controls.Add(this.outputpath, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.selectpath, 1, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(160, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(588, 62);
            this.tableLayoutPanel12.TabIndex = 1;
            this.tableLayoutPanel12.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel12_Paint);
            // 
            // outputpath
            // 
            this.outputpath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outputpath.Location = new System.Drawing.Point(3, 15);
            this.outputpath.Name = "outputpath";
            this.outputpath.ReadOnly = true;
            this.outputpath.Size = new System.Drawing.Size(512, 31);
            this.outputpath.TabIndex = 0;
            this.outputpath.TextChanged += new System.EventHandler(this.outputpath_TextChanged);
            // 
            // selectpath
            // 
            this.selectpath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectpath.Location = new System.Drawing.Point(525, 8);
            this.selectpath.Name = "selectpath";
            this.selectpath.Size = new System.Drawing.Size(56, 46);
            this.selectpath.TabIndex = 1;
            this.selectpath.Text = "...";
            this.selectpath.UseVisualStyleBackColor = true;
            this.selectpath.Click += new System.EventHandler(this.selectpath_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel13);
            this.groupBox4.Location = new System.Drawing.Point(3, 798);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(784, 242);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Log";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.logs, 0, 0);
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(775, 208);
            this.tableLayoutPanel13.TabIndex = 0;
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(3, 3);
            this.logs.Multiline = true;
            this.logs.Name = "logs";
            this.logs.ReadOnly = true;
            this.logs.Size = new System.Drawing.Size(769, 202);
            this.logs.TabIndex = 0;
            this.logs.TextChanged += new System.EventHandler(this.logs_TextChanged);
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 5;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.45055F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.54945F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel14.Controls.Add(this.About, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.Start, 4, 0);
            this.tableLayoutPanel14.Controls.Add(this.Clear_All, 3, 0);
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 1046);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(784, 56);
            this.tableLayoutPanel14.TabIndex = 6;
            // 
            // Start
            // 
            this.Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(650, 8);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(120, 40);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Clear_All
            // 
            this.Clear_All.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clear_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_All.Location = new System.Drawing.Point(493, 8);
            this.Clear_All.Name = "Clear_All";
            this.Clear_All.Size = new System.Drawing.Size(120, 40);
            this.Clear_All.TabIndex = 2;
            this.Clear_All.Text = "Clear";
            this.Clear_All.UseVisualStyleBackColor = true;
            this.Clear_All.Click += new System.EventHandler(this.Clear_All_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(814, 1129);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "L-SMASH Muxer GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ADelay_Value)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button About;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button open_videofile;
        private System.Windows.Forms.TextBox Videopath;
        private System.Windows.Forms.ComboBox FPS_Value;
        private System.Windows.Forms.TextBox vtrack_name;
        private System.Windows.Forms.Button Clear_vtrack_name;
        private System.Windows.Forms.Label Vname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox Audiopath;
        private System.Windows.Forms.Button openaudio;
        private System.Windows.Forms.Label Language;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.ComboBox Lang_Value;
        private System.Windows.Forms.Label Aname;
        private System.Windows.Forms.TextBox atrack_name;
        private System.Windows.Forms.Button Clear_atrack_name;
        private System.Windows.Forms.Label ADelay;
        private System.Windows.Forms.NumericUpDown ADelay_Value;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label Chapters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TextBox Chapterpath;
        private System.Windows.Forms.Button openchapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label muxed;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TextBox outputpath;
        private System.Windows.Forms.Button selectpath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.TextBox logs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Clear_All;
    }
}

