namespace SocanCode
{
    partial class FormCodeOutput
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.btnOutputCode = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radVS2008 = new System.Windows.Forms.RadioButton();
            this.radVS2005 = new System.Windows.Forms.RadioButton();
            this.btnOutputSqlStoreProcedure = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.chkCacheDependencyFactory = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkTableCacheDependency = new System.Windows.Forms.CheckBox();
            this.cobLevel3Frame = new System.Windows.Forms.ComboBox();
            this.chkICacheDependency = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtControlsPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cobDALFrame = new System.Windows.Forms.ComboBox();
            this.chkUserControl = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBeforeNamespace = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cobCmdType = new System.Windows.Forms.ComboBox();
            this.chkBL = new System.Windows.Forms.CheckBox();
            this.txtAfterNamespace = new System.Windows.Forms.TextBox();
            this.chkDALFactory = new System.Windows.Forms.CheckBox();
            this.chkDBUtility = new System.Windows.Forms.CheckBox();
            this.chkModel = new System.Windows.Forms.CheckBox();
            this.chkIDAL = new System.Windows.Forms.CheckBox();
            this.chkDAL = new System.Windows.Forms.CheckBox();
            this.cobCacheFrame = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cobBLFrame = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstSelectedTables = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstTables = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelectedAll = new System.Windows.Forms.Button();
            this.btnSelected = new System.Windows.Forms.Button();
            this.btnUnSelected = new System.Windows.Forms.Button();
            this.btnUnSelectedAll = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(20, 32);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(418, 21);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "C:\\Documents and Settings\\Administrator\\桌面\\Socansoft";
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSelectPath.Location = new System.Drawing.Point(601, 30);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(34, 23);
            this.btnSelectPath.TabIndex = 1;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // btnOutputCode
            // 
            this.btnOutputCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOutputCode.Location = new System.Drawing.Point(641, 30);
            this.btnOutputCode.Name = "btnOutputCode";
            this.btnOutputCode.Size = new System.Drawing.Size(75, 23);
            this.btnOutputCode.TabIndex = 2;
            this.btnOutputCode.Text = "输出代码";
            this.btnOutputCode.UseVisualStyleBackColor = true;
            this.btnOutputCode.Click += new System.EventHandler(this.btnOutputCode_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 521);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(849, 19);
            this.progressBar1.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radVS2008);
            this.groupBox4.Controls.Add(this.radVS2005);
            this.groupBox4.Controls.Add(this.txtPath);
            this.groupBox4.Controls.Add(this.btnOutputSqlStoreProcedure);
            this.groupBox4.Controls.Add(this.btnOutputCode);
            this.groupBox4.Controls.Add(this.btnSelectPath);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(849, 77);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "输出路径";
            // 
            // radVS2008
            // 
            this.radVS2008.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radVS2008.AutoSize = true;
            this.radVS2008.Location = new System.Drawing.Point(530, 34);
            this.radVS2008.Name = "radVS2008";
            this.radVS2008.Size = new System.Drawing.Size(59, 16);
            this.radVS2008.TabIndex = 3;
            this.radVS2008.Text = "VS2008";
            this.radVS2008.UseVisualStyleBackColor = true;
            // 
            // radVS2005
            // 
            this.radVS2005.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radVS2005.AutoSize = true;
            this.radVS2005.Checked = true;
            this.radVS2005.Location = new System.Drawing.Point(461, 34);
            this.radVS2005.Name = "radVS2005";
            this.radVS2005.Size = new System.Drawing.Size(59, 16);
            this.radVS2005.TabIndex = 3;
            this.radVS2005.TabStop = true;
            this.radVS2005.Text = "VS2005";
            this.radVS2005.UseVisualStyleBackColor = true;
            // 
            // btnOutputSqlStoreProcedure
            // 
            this.btnOutputSqlStoreProcedure.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOutputSqlStoreProcedure.Location = new System.Drawing.Point(731, 30);
            this.btnOutputSqlStoreProcedure.Name = "btnOutputSqlStoreProcedure";
            this.btnOutputSqlStoreProcedure.Size = new System.Drawing.Size(106, 23);
            this.btnOutputSqlStoreProcedure.TabIndex = 2;
            this.btnOutputSqlStoreProcedure.Tag = "";
            this.btnOutputSqlStoreProcedure.Text = "输出存储过程";
            this.btnOutputSqlStoreProcedure.UseVisualStyleBackColor = true;
            this.btnOutputSqlStoreProcedure.Click += new System.EventHandler(this.btnOutputStoreProcedure_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 77);
            this.panel1.TabIndex = 37;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 444);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel3);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(591, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(255, 438);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "代码结构";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.chkCacheDependencyFactory, 0, 15);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.chkTableCacheDependency, 0, 14);
            this.tableLayoutPanel3.Controls.Add(this.cobLevel3Frame, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.chkICacheDependency, 0, 13);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtControlsPath, 1, 12);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 12);
            this.tableLayoutPanel3.Controls.Add(this.cobDALFrame, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.chkUserControl, 0, 11);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtBeforeNamespace, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.cobCmdType, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.chkBL, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.txtAfterNamespace, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.chkDALFactory, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.chkDBUtility, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.chkModel, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.chkIDAL, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.chkDAL, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.cobCacheFrame, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 10);
            this.tableLayoutPanel3.Controls.Add(this.cobBLFrame, 1, 10);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 16;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249805F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249805F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249805F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249805F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249805F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249805F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249805F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249805F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249805F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249805F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25293F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249805F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249805F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249805F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249805F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249805F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(249, 418);
            this.tableLayoutPanel3.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "三层架构";
            // 
            // chkCacheDependencyFactory
            // 
            this.chkCacheDependencyFactory.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.chkCacheDependencyFactory, 3);
            this.chkCacheDependencyFactory.Location = new System.Drawing.Point(3, 395);
            this.chkCacheDependencyFactory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.chkCacheDependencyFactory.Name = "chkCacheDependencyFactory";
            this.chkCacheDependencyFactory.Size = new System.Drawing.Size(156, 16);
            this.chkCacheDependencyFactory.TabIndex = 42;
            this.chkCacheDependencyFactory.Text = "CacheDependencyFactory";
            this.chkCacheDependencyFactory.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "DAL项目类型";
            // 
            // chkTableCacheDependency
            // 
            this.chkTableCacheDependency.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.chkTableCacheDependency, 3);
            this.chkTableCacheDependency.Location = new System.Drawing.Point(3, 369);
            this.chkTableCacheDependency.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.chkTableCacheDependency.Name = "chkTableCacheDependency";
            this.chkTableCacheDependency.Size = new System.Drawing.Size(144, 16);
            this.chkTableCacheDependency.TabIndex = 41;
            this.chkTableCacheDependency.Text = "TableCacheDependency";
            this.chkTableCacheDependency.UseVisualStyleBackColor = true;
            // 
            // cobLevel3Frame
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.cobLevel3Frame, 2);
            this.cobLevel3Frame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobLevel3Frame.FormattingEnabled = true;
            this.cobLevel3Frame.Items.AddRange(new object[] {
            "简单三层结构",
            "工厂模式三层结构"});
            this.cobLevel3Frame.Location = new System.Drawing.Point(92, 3);
            this.cobLevel3Frame.Name = "cobLevel3Frame";
            this.cobLevel3Frame.Size = new System.Drawing.Size(147, 20);
            this.cobLevel3Frame.TabIndex = 0;
            this.cobLevel3Frame.SelectedIndexChanged += new System.EventHandler(this.cobSlnFrame_SelectedIndexChanged);
            // 
            // chkICacheDependency
            // 
            this.chkICacheDependency.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.chkICacheDependency, 3);
            this.chkICacheDependency.Location = new System.Drawing.Point(3, 343);
            this.chkICacheDependency.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.chkICacheDependency.Name = "chkICacheDependency";
            this.chkICacheDependency.Size = new System.Drawing.Size(120, 16);
            this.chkICacheDependency.TabIndex = 40;
            this.chkICacheDependency.Text = "ICacheDependency";
            this.chkICacheDependency.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 138);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 43;
            this.label8.Text = "数据库读写";
            // 
            // txtControlsPath
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtControlsPath, 2);
            this.txtControlsPath.Location = new System.Drawing.Point(92, 315);
            this.txtControlsPath.Name = "txtControlsPath";
            this.txtControlsPath.Size = new System.Drawing.Size(147, 21);
            this.txtControlsPath.TabIndex = 13;
            this.txtControlsPath.Text = "Controls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 320);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "用户控件目录";
            // 
            // cobDALFrame
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.cobDALFrame, 2);
            this.cobDALFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobDALFrame.FormattingEnabled = true;
            this.cobDALFrame.Items.AddRange(new object[] {
            "兼容",
            "Access",
            "SqlServer",
            "MySql",
            "Oracle"});
            this.cobDALFrame.Location = new System.Drawing.Point(92, 159);
            this.cobDALFrame.Name = "cobDALFrame";
            this.cobDALFrame.Size = new System.Drawing.Size(147, 20);
            this.cobDALFrame.TabIndex = 1;
            this.cobDALFrame.SelectedIndexChanged += new System.EventHandler(this.cobDALFrame_SelectedIndexChanged);
            // 
            // chkUserControl
            // 
            this.chkUserControl.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.chkUserControl, 3);
            this.chkUserControl.Location = new System.Drawing.Point(3, 291);
            this.chkUserControl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.chkUserControl.Name = "chkUserControl";
            this.chkUserControl.Size = new System.Drawing.Size(240, 16);
            this.chkUserControl.TabIndex = 11;
            this.chkUserControl.Text = "用户控件(无标识且有多个主键时不推荐)";
            this.chkUserControl.UseVisualStyleBackColor = true;
            this.chkUserControl.CheckedChanged += new System.EventHandler(this.chkUserControl_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "缓存架构";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 39;
            this.label6.Text = "命名空间前缀";
            // 
            // txtBeforeNamespace
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtBeforeNamespace, 2);
            this.txtBeforeNamespace.Location = new System.Drawing.Point(92, 29);
            this.txtBeforeNamespace.Name = "txtBeforeNamespace";
            this.txtBeforeNamespace.Size = new System.Drawing.Size(147, 21);
            this.txtBeforeNamespace.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "命名空间后缀";
            // 
            // cobCmdType
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.cobCmdType, 2);
            this.cobCmdType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobCmdType.FormattingEnabled = true;
            this.cobCmdType.Items.AddRange(new object[] {
            "SQL语句",
            "存储过程"});
            this.cobCmdType.Location = new System.Drawing.Point(92, 133);
            this.cobCmdType.Name = "cobCmdType";
            this.cobCmdType.Size = new System.Drawing.Size(147, 20);
            this.cobCmdType.TabIndex = 1;
            this.cobCmdType.SelectedIndexChanged += new System.EventHandler(this.cobCacheFrame_SelectedIndexChanged);
            // 
            // chkBL
            // 
            this.chkBL.AutoSize = true;
            this.chkBL.Checked = true;
            this.chkBL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBL.Location = new System.Drawing.Point(3, 213);
            this.chkBL.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.chkBL.Name = "chkBL";
            this.chkBL.Size = new System.Drawing.Size(36, 16);
            this.chkBL.TabIndex = 10;
            this.chkBL.Text = "BL";
            this.chkBL.UseVisualStyleBackColor = true;
            // 
            // txtAfterNamespace
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtAfterNamespace, 2);
            this.txtAfterNamespace.Location = new System.Drawing.Point(92, 55);
            this.txtAfterNamespace.Name = "txtAfterNamespace";
            this.txtAfterNamespace.Size = new System.Drawing.Size(147, 21);
            this.txtAfterNamespace.TabIndex = 3;
            // 
            // chkDALFactory
            // 
            this.chkDALFactory.AutoSize = true;
            this.chkDALFactory.Location = new System.Drawing.Point(3, 187);
            this.chkDALFactory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.chkDALFactory.Name = "chkDALFactory";
            this.chkDALFactory.Size = new System.Drawing.Size(83, 16);
            this.chkDALFactory.TabIndex = 9;
            this.chkDALFactory.Text = "DALFactory";
            this.chkDALFactory.UseVisualStyleBackColor = true;
            // 
            // chkDBUtility
            // 
            this.chkDBUtility.AutoSize = true;
            this.chkDBUtility.Checked = true;
            this.chkDBUtility.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDBUtility.Location = new System.Drawing.Point(3, 83);
            this.chkDBUtility.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.chkDBUtility.Name = "chkDBUtility";
            this.chkDBUtility.Size = new System.Drawing.Size(78, 16);
            this.chkDBUtility.TabIndex = 4;
            this.chkDBUtility.Text = "DBUtility";
            this.chkDBUtility.UseVisualStyleBackColor = true;
            // 
            // chkModel
            // 
            this.chkModel.AutoSize = true;
            this.chkModel.Checked = true;
            this.chkModel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkModel.Location = new System.Drawing.Point(92, 83);
            this.chkModel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.chkModel.Name = "chkModel";
            this.chkModel.Size = new System.Drawing.Size(54, 16);
            this.chkModel.TabIndex = 5;
            this.chkModel.Text = "Model";
            this.chkModel.UseVisualStyleBackColor = true;
            // 
            // chkIDAL
            // 
            this.chkIDAL.AutoSize = true;
            this.chkIDAL.Location = new System.Drawing.Point(171, 83);
            this.chkIDAL.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.chkIDAL.Name = "chkIDAL";
            this.chkIDAL.Size = new System.Drawing.Size(48, 16);
            this.chkIDAL.TabIndex = 6;
            this.chkIDAL.Text = "IDAL";
            this.chkIDAL.UseVisualStyleBackColor = true;
            // 
            // chkDAL
            // 
            this.chkDAL.AutoSize = true;
            this.chkDAL.Checked = true;
            this.chkDAL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDAL.Location = new System.Drawing.Point(3, 109);
            this.chkDAL.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.chkDAL.Name = "chkDAL";
            this.chkDAL.Size = new System.Drawing.Size(42, 16);
            this.chkDAL.TabIndex = 7;
            this.chkDAL.Text = "DAL";
            this.chkDAL.UseVisualStyleBackColor = true;
            // 
            // cobCacheFrame
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.cobCacheFrame, 2);
            this.cobCacheFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobCacheFrame.FormattingEnabled = true;
            this.cobCacheFrame.Items.AddRange(new object[] {
            "不使用",
            "缓存对象",
            "聚合缓存依赖",
            "缓存对象+聚合缓存依赖"});
            this.cobCacheFrame.Location = new System.Drawing.Point(92, 237);
            this.cobCacheFrame.Name = "cobCacheFrame";
            this.cobCacheFrame.Size = new System.Drawing.Size(147, 20);
            this.cobCacheFrame.TabIndex = 1;
            this.cobCacheFrame.SelectedIndexChanged += new System.EventHandler(this.cobCacheFrame_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 45;
            this.label1.Text = "业务逻辑结构";
            // 
            // cobBLFrame
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.cobBLFrame, 2);
            this.cobBLFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobBLFrame.FormattingEnabled = true;
            this.cobBLFrame.Items.AddRange(new object[] {
            "类库",
            "Web服务"});
            this.cobBLFrame.Location = new System.Drawing.Point(92, 263);
            this.cobBLFrame.Name = "cobBLFrame";
            this.cobBLFrame.Size = new System.Drawing.Size(147, 20);
            this.cobBLFrame.TabIndex = 1;
            this.cobBLFrame.SelectedIndexChanged += new System.EventHandler(this.cobBLFrame_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstSelectedTables);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(322, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 438);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "要输出代码的表";
            // 
            // lstSelectedTables
            // 
            this.lstSelectedTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSelectedTables.FormattingEnabled = true;
            this.lstSelectedTables.ItemHeight = 12;
            this.lstSelectedTables.Location = new System.Drawing.Point(3, 17);
            this.lstSelectedTables.Name = "lstSelectedTables";
            this.lstSelectedTables.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSelectedTables.Size = new System.Drawing.Size(257, 412);
            this.lstSelectedTables.TabIndex = 0;
            this.lstSelectedTables.DoubleClick += new System.EventHandler(this.btnUnSelected_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstTables);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库中的表";
            // 
            // lstTables
            // 
            this.lstTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTables.FormattingEnabled = true;
            this.lstTables.ItemHeight = 12;
            this.lstTables.Location = new System.Drawing.Point(3, 17);
            this.lstTables.Name = "lstTables";
            this.lstTables.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTables.Size = new System.Drawing.Size(257, 412);
            this.lstTables.TabIndex = 0;
            this.lstTables.DoubleClick += new System.EventHandler(this.btnSelected_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnSelectedAll, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSelected, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnUnSelected, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnUnSelectedAll, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(272, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(44, 438);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnSelectedAll
            // 
            this.btnSelectedAll.Location = new System.Drawing.Point(3, 172);
            this.btnSelectedAll.Name = "btnSelectedAll";
            this.btnSelectedAll.Size = new System.Drawing.Size(38, 44);
            this.btnSelectedAll.TabIndex = 1;
            this.btnSelectedAll.Text = ">>";
            this.btnSelectedAll.UseVisualStyleBackColor = true;
            this.btnSelectedAll.Click += new System.EventHandler(this.btnSelectedAll_Click);
            // 
            // btnSelected
            // 
            this.btnSelected.Location = new System.Drawing.Point(3, 122);
            this.btnSelected.Name = "btnSelected";
            this.btnSelected.Size = new System.Drawing.Size(38, 44);
            this.btnSelected.TabIndex = 0;
            this.btnSelected.Text = ">";
            this.btnSelected.UseVisualStyleBackColor = true;
            this.btnSelected.Click += new System.EventHandler(this.btnSelected_Click);
            // 
            // btnUnSelected
            // 
            this.btnUnSelected.Location = new System.Drawing.Point(3, 222);
            this.btnUnSelected.Name = "btnUnSelected";
            this.btnUnSelected.Size = new System.Drawing.Size(38, 44);
            this.btnUnSelected.TabIndex = 2;
            this.btnUnSelected.Text = "<";
            this.btnUnSelected.UseVisualStyleBackColor = true;
            this.btnUnSelected.Click += new System.EventHandler(this.btnUnSelected_Click);
            // 
            // btnUnSelectedAll
            // 
            this.btnUnSelectedAll.Location = new System.Drawing.Point(3, 272);
            this.btnUnSelectedAll.Name = "btnUnSelectedAll";
            this.btnUnSelectedAll.Size = new System.Drawing.Size(38, 44);
            this.btnUnSelectedAll.TabIndex = 3;
            this.btnUnSelectedAll.Text = "<<";
            this.btnUnSelectedAll.UseVisualStyleBackColor = true;
            this.btnUnSelectedAll.Click += new System.EventHandler(this.btnUnSelectedAll_Click);
            // 
            // FormCodeOutput
            // 
            this.AcceptButton = this.btnOutputCode;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 540);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Name = "FormCodeOutput";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
            this.TabText = "输出代码";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCodeOutput_FormClosing);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Button btnOutputCode;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtControlsPath;
        private System.Windows.Forms.CheckBox chkUserControl;
        private System.Windows.Forms.CheckBox chkBL;
        private System.Windows.Forms.CheckBox chkDBUtility;
        private System.Windows.Forms.CheckBox chkModel;
        private System.Windows.Forms.CheckBox chkDALFactory;
        private System.Windows.Forms.CheckBox chkIDAL;
        private System.Windows.Forms.CheckBox chkDAL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstSelectedTables;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstTables;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSelectedAll;
        private System.Windows.Forms.Button btnSelected;
        private System.Windows.Forms.Button btnUnSelected;
        private System.Windows.Forms.Button btnUnSelectedAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cobLevel3Frame;
        private System.Windows.Forms.ComboBox cobCacheFrame;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAfterNamespace;
        private System.Windows.Forms.TextBox txtBeforeNamespace;
        private System.Windows.Forms.CheckBox chkCacheDependencyFactory;
        private System.Windows.Forms.CheckBox chkTableCacheDependency;
        private System.Windows.Forms.CheckBox chkICacheDependency;
        private System.Windows.Forms.ComboBox cobCmdType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOutputSqlStoreProcedure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cobDALFrame;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobBLFrame;
        private System.Windows.Forms.RadioButton radVS2008;
        private System.Windows.Forms.RadioButton radVS2005;
    }
}

