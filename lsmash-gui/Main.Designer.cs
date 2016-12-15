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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.About = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Clear_All = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Logs = new System.Windows.Forms.TableLayoutPanel();
            this.logs = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Video = new System.Windows.Forms.TableLayoutPanel();
            this.Clear_vtrack_name = new System.Windows.Forms.Button();
            this.open_videofile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Videopath = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_Video_Name = new System.Windows.Forms.TableLayoutPanel();
            this.vtrack_name = new System.Windows.Forms.TextBox();
            this.FPS_Value = new System.Windows.Forms.ComboBox();
            this.Vname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Audio = new System.Windows.Forms.TableLayoutPanel();
            this.ADelay_Value = new System.Windows.Forms.NumericUpDown();
            this.openaudio = new System.Windows.Forms.Button();
            this.Language = new System.Windows.Forms.Label();
            this.ADelay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Clear_atrack_name = new System.Windows.Forms.Button();
            this.Audiopath = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_Audio_Name = new System.Windows.Forms.TableLayoutPanel();
            this.Aname = new System.Windows.Forms.Label();
            this.Lang_Value = new System.Windows.Forms.ComboBox();
            this.atrack_name = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Chapter = new System.Windows.Forms.TableLayoutPanel();
            this.openchapter = new System.Windows.Forms.Button();
            this.Chapterpath = new System.Windows.Forms.TextBox();
            this.Chapters = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_output = new System.Windows.Forms.TableLayoutPanel();
            this.selectpath = new System.Windows.Forms.Button();
            this.outputpath = new System.Windows.Forms.TextBox();
            this.muxed = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Bottom = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Button = new System.Windows.Forms.TableLayoutPanel();
            this.Version = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Delay = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_vtrack = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_atrack = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_cpath = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_opath = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_AD = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel_Logs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel_Video.SuspendLayout();
            this.tableLayoutPanel_Video_Name.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel_Audio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADelay_Value)).BeginInit();
            this.tableLayoutPanel_Audio_Name.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel_Chapter.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel_output.SuspendLayout();
            this.tableLayoutPanel_Bottom.SuspendLayout();
            this.tableLayoutPanel_Button.SuspendLayout();
            this.tableLayoutPanel_Delay.SuspendLayout();
            this.tableLayoutPanel_vtrack.SuspendLayout();
            this.tableLayoutPanel_atrack.SuspendLayout();
            this.tableLayoutPanel_cpath.SuspendLayout();
            this.tableLayoutPanel_opath.SuspendLayout();
            this.tableLayoutPanel_AD.SuspendLayout();
            this.SuspendLayout();
            // 
            // About
            // 
            this.About.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.About.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Location = new System.Drawing.Point(19, 5);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(120, 40);
            this.About.TabIndex = 0;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Start
            // 
            this.Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Start.Font = new System.Drawing.Font("Arial", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(653, 5);
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
            this.Clear_All.Font = new System.Drawing.Font("Arial", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_All.Location = new System.Drawing.Point(493, 5);
            this.Clear_All.Name = "Clear_All";
            this.Clear_All.Size = new System.Drawing.Size(120, 40);
            this.Clear_All.TabIndex = 2;
            this.Clear_All.Text = "Clear";
            this.Clear_All.UseVisualStyleBackColor = true;
            this.Clear_All.Click += new System.EventHandler(this.Clear_All_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel_Logs);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 572);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(794, 215);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Log";
            // 
            // tableLayoutPanel_Logs
            // 
            this.tableLayoutPanel_Logs.ColumnCount = 1;
            this.tableLayoutPanel_Logs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Logs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Logs.Controls.Add(this.logs, 0, 0);
            this.tableLayoutPanel_Logs.Location = new System.Drawing.Point(7, 28);
            this.tableLayoutPanel_Logs.Name = "tableLayoutPanel_Logs";
            this.tableLayoutPanel_Logs.RowCount = 1;
            this.tableLayoutPanel_Logs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Logs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Logs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel_Logs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel_Logs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel_Logs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel_Logs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel_Logs.Size = new System.Drawing.Size(780, 170);
            this.tableLayoutPanel_Logs.TabIndex = 0;
            // 
            // logs
            // 
            this.logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logs.Location = new System.Drawing.Point(3, 3);
            this.logs.Multiline = true;
            this.logs.Name = "logs";
            this.logs.ReadOnly = true;
            this.logs.Size = new System.Drawing.Size(774, 164);
            this.logs.TabIndex = 0;
            this.logs.TextChanged += new System.EventHandler(this.logs_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel_Video);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video";
            // 
            // tableLayoutPanel_Video
            // 
            this.tableLayoutPanel_Video.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel_Video.ColumnCount = 3;
            this.tableLayoutPanel_Video.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Video.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_Video.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_Video.Controls.Add(this.Clear_vtrack_name, 2, 1);
            this.tableLayoutPanel_Video.Controls.Add(this.open_videofile, 2, 0);
            this.tableLayoutPanel_Video.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel_Video.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel_Video.Controls.Add(this.tableLayoutPanel_Video_Name, 1, 1);
            this.tableLayoutPanel_Video.Controls.Add(this.tableLayoutPanel_vtrack, 1, 0);
            this.tableLayoutPanel_Video.Location = new System.Drawing.Point(7, 25);
            this.tableLayoutPanel_Video.Name = "tableLayoutPanel_Video";
            this.tableLayoutPanel_Video.RowCount = 2;
            this.tableLayoutPanel_Video.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Video.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Video.Size = new System.Drawing.Size(780, 110);
            this.tableLayoutPanel_Video.TabIndex = 0;
            // 
            // Clear_vtrack_name
            // 
            this.Clear_vtrack_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clear_vtrack_name.Location = new System.Drawing.Point(713, 59);
            this.Clear_vtrack_name.Name = "Clear_vtrack_name";
            this.Clear_vtrack_name.Size = new System.Drawing.Size(56, 46);
            this.Clear_vtrack_name.TabIndex = 2;
            this.Clear_vtrack_name.Text = "X";
            this.Clear_vtrack_name.UseVisualStyleBackColor = true;
            this.Clear_vtrack_name.Click += new System.EventHandler(this.Clear_vtrack_name_Click);
            // 
            // open_videofile
            // 
            this.open_videofile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.open_videofile.Location = new System.Drawing.Point(713, 4);
            this.open_videofile.Name = "open_videofile";
            this.open_videofile.Size = new System.Drawing.Size(56, 46);
            this.open_videofile.TabIndex = 0;
            this.open_videofile.Text = "...";
            this.open_videofile.UseVisualStyleBackColor = true;
            this.open_videofile.Click += new System.EventHandler(this.openvideo_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "FPS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Video Input";
            // 
            // Videopath
            // 
            this.Videopath.AllowDrop = true;
            this.Videopath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Videopath.Location = new System.Drawing.Point(3, 8);
            this.Videopath.Name = "Videopath";
            this.Videopath.ReadOnly = true;
            this.Videopath.Size = new System.Drawing.Size(534, 32);
            this.Videopath.TabIndex = 1;
            this.Videopath.DragDrop += new System.Windows.Forms.DragEventHandler(this.Videopath_DragDrop);
            this.Videopath.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBoxDragEnter);
            // 
            // tableLayoutPanel_Video_Name
            // 
            this.tableLayoutPanel_Video_Name.ColumnCount = 3;
            this.tableLayoutPanel_Video_Name.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel_Video_Name.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Video_Name.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel_Video_Name.Controls.Add(this.vtrack_name, 2, 0);
            this.tableLayoutPanel_Video_Name.Controls.Add(this.FPS_Value, 0, 0);
            this.tableLayoutPanel_Video_Name.Controls.Add(this.Vname, 1, 0);
            this.tableLayoutPanel_Video_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Video_Name.Location = new System.Drawing.Point(159, 58);
            this.tableLayoutPanel_Video_Name.Name = "tableLayoutPanel_Video_Name";
            this.tableLayoutPanel_Video_Name.RowCount = 1;
            this.tableLayoutPanel_Video_Name.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Video_Name.Size = new System.Drawing.Size(540, 49);
            this.tableLayoutPanel_Video_Name.TabIndex = 3;
            // 
            // vtrack_name
            // 
            this.vtrack_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vtrack_name.Location = new System.Drawing.Point(300, 8);
            this.vtrack_name.Name = "vtrack_name";
            this.vtrack_name.Size = new System.Drawing.Size(237, 32);
            this.vtrack_name.TabIndex = 1;
            this.vtrack_name.TextChanged += new System.EventHandler(this.vtrack_name_TextChanged);
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
            this.FPS_Value.Location = new System.Drawing.Point(3, 8);
            this.FPS_Value.Name = "FPS_Value";
            this.FPS_Value.Size = new System.Drawing.Size(183, 32);
            this.FPS_Value.TabIndex = 0;
            this.FPS_Value.SelectedIndexChanged += new System.EventHandler(this.FPS_Value_SelectedIndexChanged);
            // 
            // Vname
            // 
            this.Vname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Vname.AutoSize = true;
            this.Vname.Location = new System.Drawing.Point(211, 12);
            this.Vname.Name = "Vname";
            this.Vname.Size = new System.Drawing.Size(64, 24);
            this.Vname.TabIndex = 3;
            this.Vname.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel_Audio);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 197);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Audio";
            // 
            // tableLayoutPanel_Audio
            // 
            this.tableLayoutPanel_Audio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel_Audio.ColumnCount = 3;
            this.tableLayoutPanel_Audio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Audio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_Audio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_Audio.Controls.Add(this.openaudio, 2, 0);
            this.tableLayoutPanel_Audio.Controls.Add(this.Language, 0, 1);
            this.tableLayoutPanel_Audio.Controls.Add(this.ADelay, 0, 2);
            this.tableLayoutPanel_Audio.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel_Audio.Controls.Add(this.Clear_atrack_name, 2, 1);
            this.tableLayoutPanel_Audio.Controls.Add(this.tableLayoutPanel_Delay, 1, 2);
            this.tableLayoutPanel_Audio.Controls.Add(this.tableLayoutPanel_Audio_Name, 1, 1);
            this.tableLayoutPanel_Audio.Controls.Add(this.tableLayoutPanel_atrack, 1, 0);
            this.tableLayoutPanel_Audio.Location = new System.Drawing.Point(7, 22);
            this.tableLayoutPanel_Audio.Name = "tableLayoutPanel_Audio";
            this.tableLayoutPanel_Audio.RowCount = 3;
            this.tableLayoutPanel_Audio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Audio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel_Audio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel_Audio.Size = new System.Drawing.Size(780, 165);
            this.tableLayoutPanel_Audio.TabIndex = 2;
            // 
            // ADelay_Value
            // 
            this.ADelay_Value.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ADelay_Value.Location = new System.Drawing.Point(3, 6);
            this.ADelay_Value.Name = "ADelay_Value";
            this.ADelay_Value.Size = new System.Drawing.Size(182, 32);
            this.ADelay_Value.TabIndex = 5;
            this.ADelay_Value.ValueChanged += new System.EventHandler(this.ADelay_Value_ValueChanged);
            // 
            // openaudio
            // 
            this.openaudio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openaudio.Location = new System.Drawing.Point(713, 4);
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
            this.Language.Location = new System.Drawing.Point(3, 69);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(102, 24);
            this.Language.TabIndex = 2;
            this.Language.Text = "Language";
            // 
            // ADelay
            // 
            this.ADelay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ADelay.AutoSize = true;
            this.ADelay.Location = new System.Drawing.Point(3, 125);
            this.ADelay.Name = "ADelay";
            this.ADelay.Size = new System.Drawing.Size(64, 24);
            this.ADelay.TabIndex = 4;
            this.ADelay.Text = "Delay";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Audio Input";
            // 
            // Clear_atrack_name
            // 
            this.Clear_atrack_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clear_atrack_name.Location = new System.Drawing.Point(713, 58);
            this.Clear_atrack_name.Name = "Clear_atrack_name";
            this.Clear_atrack_name.Size = new System.Drawing.Size(56, 46);
            this.Clear_atrack_name.TabIndex = 3;
            this.Clear_atrack_name.Text = "X";
            this.Clear_atrack_name.UseVisualStyleBackColor = true;
            this.Clear_atrack_name.Click += new System.EventHandler(this.Clear_atrack_name_Click);
            // 
            // Audiopath
            // 
            this.Audiopath.AllowDrop = true;
            this.Audiopath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Audiopath.Location = new System.Drawing.Point(3, 8);
            this.Audiopath.Name = "Audiopath";
            this.Audiopath.ReadOnly = true;
            this.Audiopath.Size = new System.Drawing.Size(534, 32);
            this.Audiopath.TabIndex = 0;
            this.Audiopath.DragDrop += new System.Windows.Forms.DragEventHandler(this.Audiopath_DragDrop);
            this.Audiopath.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBoxDragEnter);
            // 
            // tableLayoutPanel_Audio_Name
            // 
            this.tableLayoutPanel_Audio_Name.ColumnCount = 3;
            this.tableLayoutPanel_Audio_Name.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel_Audio_Name.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Audio_Name.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel_Audio_Name.Controls.Add(this.Aname, 1, 0);
            this.tableLayoutPanel_Audio_Name.Controls.Add(this.atrack_name, 2, 0);
            this.tableLayoutPanel_Audio_Name.Controls.Add(this.Lang_Value, 0, 0);
            this.tableLayoutPanel_Audio_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Audio_Name.Location = new System.Drawing.Point(159, 57);
            this.tableLayoutPanel_Audio_Name.Name = "tableLayoutPanel_Audio_Name";
            this.tableLayoutPanel_Audio_Name.RowCount = 1;
            this.tableLayoutPanel_Audio_Name.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Audio_Name.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel_Audio_Name.Size = new System.Drawing.Size(540, 49);
            this.tableLayoutPanel_Audio_Name.TabIndex = 6;
            // 
            // Aname
            // 
            this.Aname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aname.AutoSize = true;
            this.Aname.Location = new System.Drawing.Point(211, 12);
            this.Aname.Name = "Aname";
            this.Aname.Size = new System.Drawing.Size(64, 24);
            this.Aname.TabIndex = 1;
            this.Aname.Text = "Name";
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
            this.Lang_Value.Location = new System.Drawing.Point(3, 8);
            this.Lang_Value.Name = "Lang_Value";
            this.Lang_Value.Size = new System.Drawing.Size(183, 32);
            this.Lang_Value.TabIndex = 0;
            this.Lang_Value.SelectedIndexChanged += new System.EventHandler(this.Lang_Value_SelectedIndexChanged);
            // 
            // atrack_name
            // 
            this.atrack_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.atrack_name.Location = new System.Drawing.Point(300, 8);
            this.atrack_name.Name = "atrack_name";
            this.atrack_name.Size = new System.Drawing.Size(237, 32);
            this.atrack_name.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel_Chapter);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 360);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(794, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chapter";
            // 
            // tableLayoutPanel_Chapter
            // 
            this.tableLayoutPanel_Chapter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel_Chapter.ColumnCount = 3;
            this.tableLayoutPanel_Chapter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Chapter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_Chapter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_Chapter.Controls.Add(this.openchapter, 2, 0);
            this.tableLayoutPanel_Chapter.Controls.Add(this.Chapters, 0, 0);
            this.tableLayoutPanel_Chapter.Controls.Add(this.tableLayoutPanel_cpath, 1, 0);
            this.tableLayoutPanel_Chapter.Location = new System.Drawing.Point(7, 26);
            this.tableLayoutPanel_Chapter.Name = "tableLayoutPanel_Chapter";
            this.tableLayoutPanel_Chapter.RowCount = 1;
            this.tableLayoutPanel_Chapter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Chapter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel_Chapter.Size = new System.Drawing.Size(780, 55);
            this.tableLayoutPanel_Chapter.TabIndex = 4;
            // 
            // openchapter
            // 
            this.openchapter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openchapter.Location = new System.Drawing.Point(713, 4);
            this.openchapter.Name = "openchapter";
            this.openchapter.Size = new System.Drawing.Size(56, 46);
            this.openchapter.TabIndex = 1;
            this.openchapter.Text = "...";
            this.openchapter.UseVisualStyleBackColor = true;
            this.openchapter.Click += new System.EventHandler(this.openchapter_Click);
            // 
            // Chapterpath
            // 
            this.Chapterpath.AllowDrop = true;
            this.Chapterpath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Chapterpath.Location = new System.Drawing.Point(3, 8);
            this.Chapterpath.Name = "Chapterpath";
            this.Chapterpath.ReadOnly = true;
            this.Chapterpath.Size = new System.Drawing.Size(534, 32);
            this.Chapterpath.TabIndex = 0;
            this.Chapterpath.DragDrop += new System.Windows.Forms.DragEventHandler(this.Chapterpath_DragDrop);
            this.Chapterpath.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBoxDragEnter);
            // 
            // Chapters
            // 
            this.Chapters.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Chapters.AutoSize = true;
            this.Chapters.Location = new System.Drawing.Point(3, 15);
            this.Chapters.Name = "Chapters";
            this.Chapters.Size = new System.Drawing.Size(135, 24);
            this.Chapters.TabIndex = 0;
            this.Chapters.Text = "Chapters File";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel_output);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 466);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(794, 100);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Output";
            // 
            // tableLayoutPanel_output
            // 
            this.tableLayoutPanel_output.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel_output.ColumnCount = 3;
            this.tableLayoutPanel_output.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_output.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_output.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_output.Controls.Add(this.selectpath, 2, 0);
            this.tableLayoutPanel_output.Controls.Add(this.muxed, 0, 0);
            this.tableLayoutPanel_output.Controls.Add(this.tableLayoutPanel_opath, 1, 0);
            this.tableLayoutPanel_output.Location = new System.Drawing.Point(7, 26);
            this.tableLayoutPanel_output.Name = "tableLayoutPanel_output";
            this.tableLayoutPanel_output.RowCount = 1;
            this.tableLayoutPanel_output.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_output.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel_output.Size = new System.Drawing.Size(780, 55);
            this.tableLayoutPanel_output.TabIndex = 6;
            // 
            // selectpath
            // 
            this.selectpath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectpath.Location = new System.Drawing.Point(713, 4);
            this.selectpath.Name = "selectpath";
            this.selectpath.Size = new System.Drawing.Size(56, 46);
            this.selectpath.TabIndex = 1;
            this.selectpath.Text = "...";
            this.selectpath.UseVisualStyleBackColor = true;
            this.selectpath.Click += new System.EventHandler(this.selectpath_Click);
            // 
            // outputpath
            // 
            this.outputpath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outputpath.Location = new System.Drawing.Point(3, 8);
            this.outputpath.Name = "outputpath";
            this.outputpath.ReadOnly = true;
            this.outputpath.Size = new System.Drawing.Size(534, 32);
            this.outputpath.TabIndex = 0;
            this.outputpath.TextChanged += new System.EventHandler(this.outputpath_TextChanged);
            // 
            // muxed
            // 
            this.muxed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.muxed.AutoSize = true;
            this.muxed.Location = new System.Drawing.Point(3, 15);
            this.muxed.Name = "muxed";
            this.muxed.Size = new System.Drawing.Size(138, 24);
            this.muxed.TabIndex = 0;
            this.muxed.Text = "Muxed Output";
            // 
            // tableLayoutPanel_Bottom
            // 
            this.tableLayoutPanel_Bottom.ColumnCount = 1;
            this.tableLayoutPanel_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Bottom.Controls.Add(this.tableLayoutPanel_Button, 0, 5);
            this.tableLayoutPanel_Bottom.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel_Bottom.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel_Bottom.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel_Bottom.Controls.Add(this.groupBox5, 0, 3);
            this.tableLayoutPanel_Bottom.Controls.Add(this.groupBox4, 0, 4);
            this.tableLayoutPanel_Bottom.Location = new System.Drawing.Point(7, 4);
            this.tableLayoutPanel_Bottom.Name = "tableLayoutPanel_Bottom";
            this.tableLayoutPanel_Bottom.RowCount = 6;
            this.tableLayoutPanel_Bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.58794F));
            this.tableLayoutPanel_Bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.11558F));
            this.tableLayoutPanel_Bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0603F));
            this.tableLayoutPanel_Bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0603F));
            this.tableLayoutPanel_Bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.12563F));
            this.tableLayoutPanel_Bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.05025F));
            this.tableLayoutPanel_Bottom.Size = new System.Drawing.Size(800, 880);
            this.tableLayoutPanel_Bottom.TabIndex = 3;
            // 
            // tableLayoutPanel_Button
            // 
            this.tableLayoutPanel_Button.ColumnCount = 5;
            this.tableLayoutPanel_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Button.Controls.Add(this.About, 0, 0);
            this.tableLayoutPanel_Button.Controls.Add(this.Clear_All, 3, 0);
            this.tableLayoutPanel_Button.Controls.Add(this.Start, 4, 0);
            this.tableLayoutPanel_Button.Controls.Add(this.Version, 0, 1);
            this.tableLayoutPanel_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Button.Location = new System.Drawing.Point(3, 793);
            this.tableLayoutPanel_Button.Name = "tableLayoutPanel_Button";
            this.tableLayoutPanel_Button.RowCount = 2;
            this.tableLayoutPanel_Button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel_Button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel_Button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Button.Size = new System.Drawing.Size(794, 84);
            this.tableLayoutPanel_Button.TabIndex = 4;
            // 
            // Version
            // 
            this.Version.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Consolas", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.Location = new System.Drawing.Point(3, 55);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(58, 24);
            this.Version.TabIndex = 3;
            this.Version.Text = "v1.2";
            // 
            // tableLayoutPanel_Delay
            // 
            this.tableLayoutPanel_Delay.ColumnCount = 1;
            this.tableLayoutPanel_Delay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Delay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Delay.Controls.Add(this.tableLayoutPanel_AD, 0, 0);
            this.tableLayoutPanel_Delay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Delay.Location = new System.Drawing.Point(159, 112);
            this.tableLayoutPanel_Delay.Name = "tableLayoutPanel_Delay";
            this.tableLayoutPanel_Delay.RowCount = 1;
            this.tableLayoutPanel_Delay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Delay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Delay.Size = new System.Drawing.Size(540, 50);
            this.tableLayoutPanel_Delay.TabIndex = 4;
            // 
            // tableLayoutPanel_vtrack
            // 
            this.tableLayoutPanel_vtrack.ColumnCount = 1;
            this.tableLayoutPanel_vtrack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_vtrack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_vtrack.Controls.Add(this.Videopath, 0, 0);
            this.tableLayoutPanel_vtrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_vtrack.Location = new System.Drawing.Point(159, 3);
            this.tableLayoutPanel_vtrack.Name = "tableLayoutPanel_vtrack";
            this.tableLayoutPanel_vtrack.RowCount = 1;
            this.tableLayoutPanel_vtrack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_vtrack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_vtrack.Size = new System.Drawing.Size(540, 49);
            this.tableLayoutPanel_vtrack.TabIndex = 4;
            // 
            // tableLayoutPanel_atrack
            // 
            this.tableLayoutPanel_atrack.ColumnCount = 1;
            this.tableLayoutPanel_atrack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_atrack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_atrack.Controls.Add(this.Audiopath, 0, 0);
            this.tableLayoutPanel_atrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_atrack.Location = new System.Drawing.Point(159, 3);
            this.tableLayoutPanel_atrack.Name = "tableLayoutPanel_atrack";
            this.tableLayoutPanel_atrack.RowCount = 1;
            this.tableLayoutPanel_atrack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_atrack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_atrack.Size = new System.Drawing.Size(540, 48);
            this.tableLayoutPanel_atrack.TabIndex = 7;
            // 
            // tableLayoutPanel_cpath
            // 
            this.tableLayoutPanel_cpath.ColumnCount = 1;
            this.tableLayoutPanel_cpath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_cpath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_cpath.Controls.Add(this.Chapterpath, 0, 0);
            this.tableLayoutPanel_cpath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_cpath.Location = new System.Drawing.Point(159, 3);
            this.tableLayoutPanel_cpath.Name = "tableLayoutPanel_cpath";
            this.tableLayoutPanel_cpath.RowCount = 1;
            this.tableLayoutPanel_cpath.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_cpath.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_cpath.Size = new System.Drawing.Size(540, 49);
            this.tableLayoutPanel_cpath.TabIndex = 2;
            // 
            // tableLayoutPanel_opath
            // 
            this.tableLayoutPanel_opath.ColumnCount = 1;
            this.tableLayoutPanel_opath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_opath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_opath.Controls.Add(this.outputpath, 0, 0);
            this.tableLayoutPanel_opath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_opath.Location = new System.Drawing.Point(159, 3);
            this.tableLayoutPanel_opath.Name = "tableLayoutPanel_opath";
            this.tableLayoutPanel_opath.RowCount = 1;
            this.tableLayoutPanel_opath.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_opath.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_opath.Size = new System.Drawing.Size(540, 49);
            this.tableLayoutPanel_opath.TabIndex = 2;
            // 
            // tableLayoutPanel_AD
            // 
            this.tableLayoutPanel_AD.ColumnCount = 1;
            this.tableLayoutPanel_AD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_AD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_AD.Controls.Add(this.ADelay_Value, 0, 0);
            this.tableLayoutPanel_AD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_AD.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_AD.Name = "tableLayoutPanel_AD";
            this.tableLayoutPanel_AD.RowCount = 1;
            this.tableLayoutPanel_AD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_AD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_AD.Size = new System.Drawing.Size(534, 44);
            this.tableLayoutPanel_AD.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(814, 889);
            this.Controls.Add(this.tableLayoutPanel_Bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "L-SMASH Muxer GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel_Logs.ResumeLayout(false);
            this.tableLayoutPanel_Logs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel_Video.ResumeLayout(false);
            this.tableLayoutPanel_Video.PerformLayout();
            this.tableLayoutPanel_Video_Name.ResumeLayout(false);
            this.tableLayoutPanel_Video_Name.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel_Audio.ResumeLayout(false);
            this.tableLayoutPanel_Audio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADelay_Value)).EndInit();
            this.tableLayoutPanel_Audio_Name.ResumeLayout(false);
            this.tableLayoutPanel_Audio_Name.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel_Chapter.ResumeLayout(false);
            this.tableLayoutPanel_Chapter.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel_output.ResumeLayout(false);
            this.tableLayoutPanel_output.PerformLayout();
            this.tableLayoutPanel_Bottom.ResumeLayout(false);
            this.tableLayoutPanel_Button.ResumeLayout(false);
            this.tableLayoutPanel_Button.PerformLayout();
            this.tableLayoutPanel_Delay.ResumeLayout(false);
            this.tableLayoutPanel_vtrack.ResumeLayout(false);
            this.tableLayoutPanel_vtrack.PerformLayout();
            this.tableLayoutPanel_atrack.ResumeLayout(false);
            this.tableLayoutPanel_atrack.PerformLayout();
            this.tableLayoutPanel_cpath.ResumeLayout(false);
            this.tableLayoutPanel_cpath.PerformLayout();
            this.tableLayoutPanel_opath.ResumeLayout(false);
            this.tableLayoutPanel_opath.PerformLayout();
            this.tableLayoutPanel_AD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button About;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button open_videofile;
        private System.Windows.Forms.TextBox Videopath;
        private System.Windows.Forms.ComboBox FPS_Value;
        private System.Windows.Forms.TextBox vtrack_name;
        private System.Windows.Forms.Button Clear_vtrack_name;
        private System.Windows.Forms.Label Vname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Audiopath;
        private System.Windows.Forms.Button openaudio;
        private System.Windows.Forms.Label Language;
        private System.Windows.Forms.ComboBox Lang_Value;
        private System.Windows.Forms.Label Aname;
        private System.Windows.Forms.TextBox atrack_name;
        private System.Windows.Forms.Button Clear_atrack_name;
        private System.Windows.Forms.Label ADelay;
        private System.Windows.Forms.NumericUpDown ADelay_Value;
        private System.Windows.Forms.Label Chapters;
        private System.Windows.Forms.TextBox Chapterpath;
        private System.Windows.Forms.Button openchapter;
        private System.Windows.Forms.Label muxed;
        private System.Windows.Forms.TextBox outputpath;
        private System.Windows.Forms.Button selectpath;
        private System.Windows.Forms.TextBox logs;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Clear_All;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Video;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Video_Name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Audio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Audio_Name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Chapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Bottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_output;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Logs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Button;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Delay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_vtrack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_atrack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_cpath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_opath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_AD;
    }
}

