namespace SocanCode
{
    partial class FormCodeCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCodeCreate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.btnSaveCurrentTab = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAfterNamespace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cobCmdType = new System.Windows.Forms.ComboBox();
            this.txtBeforeNamespace = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cobLevel3Frame = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cobBLFrame = new System.Windows.Forms.ComboBox();
            this.cobCacheFrame = new System.Windows.Forms.ComboBox();
            this.tcCodes = new System.Windows.Forms.TabControl();
            this.tpModel = new System.Windows.Forms.TabPage();
            this.txtModel = new ICSharpCode.TextEditor.TextEditorControl();
            this.tpIDAL = new System.Windows.Forms.TabPage();
            this.txtIDAL = new ICSharpCode.TextEditor.TextEditorControl();
            this.tpDAL = new System.Windows.Forms.TabPage();
            this.txtDAL = new ICSharpCode.TextEditor.TextEditorControl();
            this.tpDALFactory = new System.Windows.Forms.TabPage();
            this.txtDALFactory = new ICSharpCode.TextEditor.TextEditorControl();
            this.tpICacheDependency = new System.Windows.Forms.TabPage();
            this.txtICacheDependency = new ICSharpCode.TextEditor.TextEditorControl();
            this.tpTableDependency = new System.Windows.Forms.TabPage();
            this.txtTableDependency = new ICSharpCode.TextEditor.TextEditorControl();
            this.tpTableCacheDependency = new System.Windows.Forms.TabPage();
            this.txtTableCacheDependency = new ICSharpCode.TextEditor.TextEditorControl();
            this.tpDependencyAccess = new System.Windows.Forms.TabPage();
            this.txtDependencyAccess = new ICSharpCode.TextEditor.TextEditorControl();
            this.tpDependencyFacade = new System.Windows.Forms.TabPage();
            this.txtDependencyFacade = new ICSharpCode.TextEditor.TextEditorControl();
            this.tpBL = new System.Windows.Forms.TabPage();
            this.txtBL = new ICSharpCode.TextEditor.TextEditorControl();
            this.tpUserControl = new System.Windows.Forms.TabPage();
            this.txtUserControl = new ICSharpCode.TextEditor.TextEditorControl();
            this.tpUserControlDesignerCs = new System.Windows.Forms.TabPage();
            this.txtUserControlDesignerCs = new ICSharpCode.TextEditor.TextEditorControl();
            this.tpUserControlCs = new System.Windows.Forms.TabPage();
            this.txtUserControlCs = new ICSharpCode.TextEditor.TextEditorControl();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tcCodes.SuspendLayout();
            this.tpModel.SuspendLayout();
            this.tpIDAL.SuspendLayout();
            this.tpDAL.SuspendLayout();
            this.tpDALFactory.SuspendLayout();
            this.tpICacheDependency.SuspendLayout();
            this.tpTableDependency.SuspendLayout();
            this.tpTableCacheDependency.SuspendLayout();
            this.tpDependencyAccess.SuspendLayout();
            this.tpDependencyFacade.SuspendLayout();
            this.tpBL.SuspendLayout();
            this.tpUserControl.SuspendLayout();
            this.tpUserControlDesignerCs.SuspendLayout();
            this.tpUserControlCs.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnSaveAll);
            this.panel1.Controls.Add(this.btnSaveCurrentTab);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 149);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(97, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(479, 24);
            this.label7.TabIndex = 39;
            this.label7.Text = "注：使用保存代码不会输出DAL层必需的DALHelper.cs和BL层必需的CacheHelper.cs文件，\r\n请使用“输出代码”功能得相关文件。";
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Enabled = false;
            this.btnSaveAll.Location = new System.Drawing.Point(407, 88);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(138, 23);
            this.btnSaveAll.TabIndex = 38;
            this.btnSaveAll.Text = "保存所有代码";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnSaveCurrentTab
            // 
            this.btnSaveCurrentTab.Enabled = false;
            this.btnSaveCurrentTab.Location = new System.Drawing.Point(263, 88);
            this.btnSaveCurrentTab.Name = "btnSaveCurrentTab";
            this.btnSaveCurrentTab.Size = new System.Drawing.Size(138, 23);
            this.btnSaveCurrentTab.TabIndex = 38;
            this.btnSaveCurrentTab.Text = "保存当前Tab代码";
            this.btnSaveCurrentTab.UseVisualStyleBackColor = true;
            this.btnSaveCurrentTab.Click += new System.EventHandler(this.btnSaveCurrentTab_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(100, 88);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(157, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "生成代码";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtAfterNamespace, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cobCmdType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBeforeNamespace, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cobLevel3Frame, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cobBLFrame, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cobCacheFrame, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(821, 80);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // txtAfterNamespace
            // 
            this.txtAfterNamespace.Location = new System.Drawing.Point(403, 58);
            this.txtAfterNamespace.Name = "txtAfterNamespace";
            this.txtAfterNamespace.Size = new System.Drawing.Size(141, 21);
            this.txtAfterNamespace.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(44, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "三层结构";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(320, 55);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "命名空间后缀";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(320, 5);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "业务逻辑结构";
            // 
            // cobCmdType
            // 
            this.cobCmdType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobCmdType.FormattingEnabled = true;
            this.cobCmdType.Items.AddRange(new object[] {
            "SQL语句",
            "存储过程"});
            this.cobCmdType.Location = new System.Drawing.Point(103, 58);
            this.cobCmdType.Name = "cobCmdType";
            this.cobCmdType.Size = new System.Drawing.Size(162, 20);
            this.cobCmdType.TabIndex = 1;
            // 
            // txtBeforeNamespace
            // 
            this.txtBeforeNamespace.Location = new System.Drawing.Point(403, 33);
            this.txtBeforeNamespace.Name = "txtBeforeNamespace";
            this.txtBeforeNamespace.Size = new System.Drawing.Size(141, 21);
            this.txtBeforeNamespace.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Location = new System.Drawing.Point(32, 55);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "数据库读写";
            // 
            // cobLevel3Frame
            // 
            this.cobLevel3Frame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobLevel3Frame.FormattingEnabled = true;
            this.cobLevel3Frame.Items.AddRange(new object[] {
            "简单三层结构",
            "工厂模式三层结构"});
            this.cobLevel3Frame.Location = new System.Drawing.Point(103, 8);
            this.cobLevel3Frame.Name = "cobLevel3Frame";
            this.cobLevel3Frame.Size = new System.Drawing.Size(162, 20);
            this.cobLevel3Frame.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(320, 30);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "命名空间前缀";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(44, 30);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "缓存结构";
            // 
            // cobBLFrame
            // 
            this.cobBLFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobBLFrame.FormattingEnabled = true;
            this.cobBLFrame.Items.AddRange(new object[] {
            "类库",
            "Web服务"});
            this.cobBLFrame.Location = new System.Drawing.Point(403, 8);
            this.cobBLFrame.Name = "cobBLFrame";
            this.cobBLFrame.Size = new System.Drawing.Size(141, 20);
            this.cobBLFrame.TabIndex = 0;
            this.cobBLFrame.SelectedIndexChanged += new System.EventHandler(this.cobBLFrame_SelectedIndexChanged);
            // 
            // cobCacheFrame
            // 
            this.cobCacheFrame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobCacheFrame.FormattingEnabled = true;
            this.cobCacheFrame.Items.AddRange(new object[] {
            "不使用",
            "缓存对象",
            "聚合缓存依赖",
            "缓存对象+聚合缓存依赖"});
            this.cobCacheFrame.Location = new System.Drawing.Point(103, 33);
            this.cobCacheFrame.Name = "cobCacheFrame";
            this.cobCacheFrame.Size = new System.Drawing.Size(162, 20);
            this.cobCacheFrame.TabIndex = 1;
            // 
            // tcCodes
            // 
            this.tcCodes.Controls.Add(this.tpModel);
            this.tcCodes.Controls.Add(this.tpIDAL);
            this.tcCodes.Controls.Add(this.tpDAL);
            this.tcCodes.Controls.Add(this.tpDALFactory);
            this.tcCodes.Controls.Add(this.tpICacheDependency);
            this.tcCodes.Controls.Add(this.tpTableDependency);
            this.tcCodes.Controls.Add(this.tpTableCacheDependency);
            this.tcCodes.Controls.Add(this.tpDependencyAccess);
            this.tcCodes.Controls.Add(this.tpDependencyFacade);
            this.tcCodes.Controls.Add(this.tpBL);
            this.tcCodes.Controls.Add(this.tpUserControl);
            this.tcCodes.Controls.Add(this.tpUserControlDesignerCs);
            this.tcCodes.Controls.Add(this.tpUserControlCs);
            this.tcCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCodes.Location = new System.Drawing.Point(0, 149);
            this.tcCodes.Multiline = true;
            this.tcCodes.Name = "tcCodes";
            this.tcCodes.SelectedIndex = 0;
            this.tcCodes.Size = new System.Drawing.Size(821, 296);
            this.tcCodes.TabIndex = 2;
            // 
            // tpModel
            // 
            this.tpModel.Controls.Add(this.txtModel);
            this.tpModel.Location = new System.Drawing.Point(4, 38);
            this.tpModel.Name = "tpModel";
            this.tpModel.Padding = new System.Windows.Forms.Padding(3);
            this.tpModel.Size = new System.Drawing.Size(813, 254);
            this.tpModel.TabIndex = 0;
            this.tpModel.Text = "Model";
            this.tpModel.UseVisualStyleBackColor = true;
            // 
            // txtModel
            // 
            this.txtModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModel.Encoding = ((System.Text.Encoding)(resources.GetObject("txtModel.Encoding")));
            this.txtModel.Location = new System.Drawing.Point(3, 3);
            this.txtModel.Name = "txtModel";
            this.txtModel.ShowEOLMarkers = true;
            this.txtModel.ShowInvalidLines = false;
            this.txtModel.ShowMatchingBracket = false;
            this.txtModel.ShowSpaces = true;
            this.txtModel.ShowTabs = true;
            this.txtModel.ShowVRuler = true;
            this.txtModel.Size = new System.Drawing.Size(807, 248);
            this.txtModel.TabIndex = 0;
            // 
            // tpIDAL
            // 
            this.tpIDAL.Controls.Add(this.txtIDAL);
            this.tpIDAL.Location = new System.Drawing.Point(4, 38);
            this.tpIDAL.Name = "tpIDAL";
            this.tpIDAL.Padding = new System.Windows.Forms.Padding(3);
            this.tpIDAL.Size = new System.Drawing.Size(813, 254);
            this.tpIDAL.TabIndex = 1;
            this.tpIDAL.Text = "IDAL";
            this.tpIDAL.UseVisualStyleBackColor = true;
            // 
            // txtIDAL
            // 
            this.txtIDAL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIDAL.Encoding = ((System.Text.Encoding)(resources.GetObject("txtIDAL.Encoding")));
            this.txtIDAL.Location = new System.Drawing.Point(3, 3);
            this.txtIDAL.Name = "txtIDAL";
            this.txtIDAL.ShowEOLMarkers = true;
            this.txtIDAL.ShowInvalidLines = false;
            this.txtIDAL.ShowSpaces = true;
            this.txtIDAL.ShowTabs = true;
            this.txtIDAL.ShowVRuler = true;
            this.txtIDAL.Size = new System.Drawing.Size(807, 248);
            this.txtIDAL.TabIndex = 1;
            // 
            // tpDAL
            // 
            this.tpDAL.Controls.Add(this.txtDAL);
            this.tpDAL.Location = new System.Drawing.Point(4, 38);
            this.tpDAL.Name = "tpDAL";
            this.tpDAL.Size = new System.Drawing.Size(813, 254);
            this.tpDAL.TabIndex = 2;
            this.tpDAL.Text = "DAL";
            this.tpDAL.UseVisualStyleBackColor = true;
            // 
            // txtDAL
            // 
            this.txtDAL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDAL.Encoding = ((System.Text.Encoding)(resources.GetObject("txtDAL.Encoding")));
            this.txtDAL.Location = new System.Drawing.Point(0, 0);
            this.txtDAL.Name = "txtDAL";
            this.txtDAL.ShowEOLMarkers = true;
            this.txtDAL.ShowInvalidLines = false;
            this.txtDAL.ShowSpaces = true;
            this.txtDAL.ShowTabs = true;
            this.txtDAL.ShowVRuler = true;
            this.txtDAL.Size = new System.Drawing.Size(813, 254);
            this.txtDAL.TabIndex = 1;
            // 
            // tpDALFactory
            // 
            this.tpDALFactory.Controls.Add(this.txtDALFactory);
            this.tpDALFactory.Location = new System.Drawing.Point(4, 38);
            this.tpDALFactory.Name = "tpDALFactory";
            this.tpDALFactory.Size = new System.Drawing.Size(813, 254);
            this.tpDALFactory.TabIndex = 5;
            this.tpDALFactory.Text = "DALFactory";
            this.tpDALFactory.UseVisualStyleBackColor = true;
            // 
            // txtDALFactory
            // 
            this.txtDALFactory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDALFactory.Encoding = ((System.Text.Encoding)(resources.GetObject("txtDALFactory.Encoding")));
            this.txtDALFactory.Location = new System.Drawing.Point(0, 0);
            this.txtDALFactory.Name = "txtDALFactory";
            this.txtDALFactory.ShowEOLMarkers = true;
            this.txtDALFactory.ShowInvalidLines = false;
            this.txtDALFactory.ShowSpaces = true;
            this.txtDALFactory.ShowTabs = true;
            this.txtDALFactory.ShowVRuler = true;
            this.txtDALFactory.Size = new System.Drawing.Size(813, 254);
            this.txtDALFactory.TabIndex = 1;
            // 
            // tpICacheDependency
            // 
            this.tpICacheDependency.Controls.Add(this.txtICacheDependency);
            this.tpICacheDependency.Location = new System.Drawing.Point(4, 38);
            this.tpICacheDependency.Name = "tpICacheDependency";
            this.tpICacheDependency.Padding = new System.Windows.Forms.Padding(3);
            this.tpICacheDependency.Size = new System.Drawing.Size(813, 254);
            this.tpICacheDependency.TabIndex = 8;
            this.tpICacheDependency.Text = "ICacheDependency";
            this.tpICacheDependency.UseVisualStyleBackColor = true;
            // 
            // txtICacheDependency
            // 
            this.txtICacheDependency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtICacheDependency.Encoding = ((System.Text.Encoding)(resources.GetObject("txtICacheDependency.Encoding")));
            this.txtICacheDependency.Location = new System.Drawing.Point(3, 3);
            this.txtICacheDependency.Name = "txtICacheDependency";
            this.txtICacheDependency.ShowEOLMarkers = true;
            this.txtICacheDependency.ShowInvalidLines = false;
            this.txtICacheDependency.ShowSpaces = true;
            this.txtICacheDependency.ShowTabs = true;
            this.txtICacheDependency.ShowVRuler = true;
            this.txtICacheDependency.Size = new System.Drawing.Size(807, 248);
            this.txtICacheDependency.TabIndex = 2;
            // 
            // tpTableDependency
            // 
            this.tpTableDependency.Controls.Add(this.txtTableDependency);
            this.tpTableDependency.Location = new System.Drawing.Point(4, 38);
            this.tpTableDependency.Name = "tpTableDependency";
            this.tpTableDependency.Size = new System.Drawing.Size(813, 254);
            this.tpTableDependency.TabIndex = 10;
            this.tpTableDependency.Text = "TableDependency";
            this.tpTableDependency.UseVisualStyleBackColor = true;
            // 
            // txtTableDependency
            // 
            this.txtTableDependency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTableDependency.Encoding = ((System.Text.Encoding)(resources.GetObject("txtTableDependency.Encoding")));
            this.txtTableDependency.Location = new System.Drawing.Point(0, 0);
            this.txtTableDependency.Name = "txtTableDependency";
            this.txtTableDependency.ShowEOLMarkers = true;
            this.txtTableDependency.ShowInvalidLines = false;
            this.txtTableDependency.ShowSpaces = true;
            this.txtTableDependency.ShowTabs = true;
            this.txtTableDependency.ShowVRuler = true;
            this.txtTableDependency.Size = new System.Drawing.Size(813, 254);
            this.txtTableDependency.TabIndex = 3;
            // 
            // tpTableCacheDependency
            // 
            this.tpTableCacheDependency.Controls.Add(this.txtTableCacheDependency);
            this.tpTableCacheDependency.Location = new System.Drawing.Point(4, 38);
            this.tpTableCacheDependency.Name = "tpTableCacheDependency";
            this.tpTableCacheDependency.Size = new System.Drawing.Size(813, 254);
            this.tpTableCacheDependency.TabIndex = 9;
            this.tpTableCacheDependency.Text = "TableCacheDependency";
            this.tpTableCacheDependency.UseVisualStyleBackColor = true;
            // 
            // txtTableCacheDependency
            // 
            this.txtTableCacheDependency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTableCacheDependency.Encoding = ((System.Text.Encoding)(resources.GetObject("txtTableCacheDependency.Encoding")));
            this.txtTableCacheDependency.Location = new System.Drawing.Point(0, 0);
            this.txtTableCacheDependency.Name = "txtTableCacheDependency";
            this.txtTableCacheDependency.ShowEOLMarkers = true;
            this.txtTableCacheDependency.ShowInvalidLines = false;
            this.txtTableCacheDependency.ShowSpaces = true;
            this.txtTableCacheDependency.ShowTabs = true;
            this.txtTableCacheDependency.ShowVRuler = true;
            this.txtTableCacheDependency.Size = new System.Drawing.Size(813, 254);
            this.txtTableCacheDependency.TabIndex = 3;
            // 
            // tpDependencyAccess
            // 
            this.tpDependencyAccess.Controls.Add(this.txtDependencyAccess);
            this.tpDependencyAccess.Location = new System.Drawing.Point(4, 38);
            this.tpDependencyAccess.Name = "tpDependencyAccess";
            this.tpDependencyAccess.Size = new System.Drawing.Size(813, 254);
            this.tpDependencyAccess.TabIndex = 11;
            this.tpDependencyAccess.Text = "DependencyAccess";
            this.tpDependencyAccess.UseVisualStyleBackColor = true;
            // 
            // txtDependencyAccess
            // 
            this.txtDependencyAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDependencyAccess.Encoding = ((System.Text.Encoding)(resources.GetObject("txtDependencyAccess.Encoding")));
            this.txtDependencyAccess.Location = new System.Drawing.Point(0, 0);
            this.txtDependencyAccess.Name = "txtDependencyAccess";
            this.txtDependencyAccess.ShowEOLMarkers = true;
            this.txtDependencyAccess.ShowInvalidLines = false;
            this.txtDependencyAccess.ShowSpaces = true;
            this.txtDependencyAccess.ShowTabs = true;
            this.txtDependencyAccess.ShowVRuler = true;
            this.txtDependencyAccess.Size = new System.Drawing.Size(813, 254);
            this.txtDependencyAccess.TabIndex = 3;
            // 
            // tpDependencyFacade
            // 
            this.tpDependencyFacade.Controls.Add(this.txtDependencyFacade);
            this.tpDependencyFacade.Location = new System.Drawing.Point(4, 38);
            this.tpDependencyFacade.Name = "tpDependencyFacade";
            this.tpDependencyFacade.Size = new System.Drawing.Size(813, 254);
            this.tpDependencyFacade.TabIndex = 12;
            this.tpDependencyFacade.Text = "DependencyFacade";
            this.tpDependencyFacade.UseVisualStyleBackColor = true;
            // 
            // txtDependencyFacade
            // 
            this.txtDependencyFacade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDependencyFacade.Encoding = ((System.Text.Encoding)(resources.GetObject("txtDependencyFacade.Encoding")));
            this.txtDependencyFacade.Location = new System.Drawing.Point(0, 0);
            this.txtDependencyFacade.Name = "txtDependencyFacade";
            this.txtDependencyFacade.ShowEOLMarkers = true;
            this.txtDependencyFacade.ShowInvalidLines = false;
            this.txtDependencyFacade.ShowSpaces = true;
            this.txtDependencyFacade.ShowTabs = true;
            this.txtDependencyFacade.ShowVRuler = true;
            this.txtDependencyFacade.Size = new System.Drawing.Size(813, 254);
            this.txtDependencyFacade.TabIndex = 4;
            // 
            // tpBL
            // 
            this.tpBL.Controls.Add(this.txtBL);
            this.tpBL.Location = new System.Drawing.Point(4, 38);
            this.tpBL.Name = "tpBL";
            this.tpBL.Size = new System.Drawing.Size(813, 254);
            this.tpBL.TabIndex = 4;
            this.tpBL.Text = "BL";
            this.tpBL.UseVisualStyleBackColor = true;
            // 
            // txtBL
            // 
            this.txtBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBL.Encoding = ((System.Text.Encoding)(resources.GetObject("txtBL.Encoding")));
            this.txtBL.Location = new System.Drawing.Point(0, 0);
            this.txtBL.Name = "txtBL";
            this.txtBL.ShowEOLMarkers = true;
            this.txtBL.ShowInvalidLines = false;
            this.txtBL.ShowSpaces = true;
            this.txtBL.ShowTabs = true;
            this.txtBL.ShowVRuler = true;
            this.txtBL.Size = new System.Drawing.Size(813, 254);
            this.txtBL.TabIndex = 1;
            // 
            // tpUserControl
            // 
            this.tpUserControl.Controls.Add(this.txtUserControl);
            this.tpUserControl.Location = new System.Drawing.Point(4, 38);
            this.tpUserControl.Name = "tpUserControl";
            this.tpUserControl.Size = new System.Drawing.Size(813, 254);
            this.tpUserControl.TabIndex = 6;
            this.tpUserControl.Text = "UserControl.ascx";
            this.tpUserControl.UseVisualStyleBackColor = true;
            // 
            // txtUserControl
            // 
            this.txtUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserControl.Encoding = ((System.Text.Encoding)(resources.GetObject("txtUserControl.Encoding")));
            this.txtUserControl.Location = new System.Drawing.Point(0, 0);
            this.txtUserControl.Name = "txtUserControl";
            this.txtUserControl.ShowEOLMarkers = true;
            this.txtUserControl.ShowInvalidLines = false;
            this.txtUserControl.ShowSpaces = true;
            this.txtUserControl.ShowTabs = true;
            this.txtUserControl.ShowVRuler = true;
            this.txtUserControl.Size = new System.Drawing.Size(813, 254);
            this.txtUserControl.TabIndex = 2;
            // 
            // tpUserControlDesignerCs
            // 
            this.tpUserControlDesignerCs.Controls.Add(this.txtUserControlDesignerCs);
            this.tpUserControlDesignerCs.Location = new System.Drawing.Point(4, 38);
            this.tpUserControlDesignerCs.Name = "tpUserControlDesignerCs";
            this.tpUserControlDesignerCs.Padding = new System.Windows.Forms.Padding(3);
            this.tpUserControlDesignerCs.Size = new System.Drawing.Size(813, 254);
            this.tpUserControlDesignerCs.TabIndex = 13;
            this.tpUserControlDesignerCs.Text = "UserControl.ascx.designer.cs";
            this.tpUserControlDesignerCs.UseVisualStyleBackColor = true;
            // 
            // txtUserControlDesignerCs
            // 
            this.txtUserControlDesignerCs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserControlDesignerCs.Encoding = ((System.Text.Encoding)(resources.GetObject("txtUserControlDesignerCs.Encoding")));
            this.txtUserControlDesignerCs.Location = new System.Drawing.Point(3, 3);
            this.txtUserControlDesignerCs.Name = "txtUserControlDesignerCs";
            this.txtUserControlDesignerCs.ShowEOLMarkers = true;
            this.txtUserControlDesignerCs.ShowInvalidLines = false;
            this.txtUserControlDesignerCs.ShowSpaces = true;
            this.txtUserControlDesignerCs.ShowTabs = true;
            this.txtUserControlDesignerCs.ShowVRuler = true;
            this.txtUserControlDesignerCs.Size = new System.Drawing.Size(807, 248);
            this.txtUserControlDesignerCs.TabIndex = 3;
            // 
            // tpUserControlCs
            // 
            this.tpUserControlCs.Controls.Add(this.txtUserControlCs);
            this.tpUserControlCs.Location = new System.Drawing.Point(4, 38);
            this.tpUserControlCs.Name = "tpUserControlCs";
            this.tpUserControlCs.Size = new System.Drawing.Size(813, 254);
            this.tpUserControlCs.TabIndex = 7;
            this.tpUserControlCs.Text = "UserControl.ascx.cs";
            this.tpUserControlCs.UseVisualStyleBackColor = true;
            // 
            // txtUserControlCs
            // 
            this.txtUserControlCs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserControlCs.Encoding = ((System.Text.Encoding)(resources.GetObject("txtUserControlCs.Encoding")));
            this.txtUserControlCs.Location = new System.Drawing.Point(0, 0);
            this.txtUserControlCs.Name = "txtUserControlCs";
            this.txtUserControlCs.ShowEOLMarkers = true;
            this.txtUserControlCs.ShowInvalidLines = false;
            this.txtUserControlCs.ShowSpaces = true;
            this.txtUserControlCs.ShowTabs = true;
            this.txtUserControlCs.ShowVRuler = true;
            this.txtUserControlCs.Size = new System.Drawing.Size(813, 254);
            this.txtUserControlCs.TabIndex = 3;
            // 
            // FormCodeCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 445);
            this.Controls.Add(this.tcCodes);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "FormCodeCreate";
            this.TabText = "生成代码";
            this.Text = "frmCode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCodeCreate_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tcCodes.ResumeLayout(false);
            this.tpModel.ResumeLayout(false);
            this.tpIDAL.ResumeLayout(false);
            this.tpDAL.ResumeLayout(false);
            this.tpDALFactory.ResumeLayout(false);
            this.tpICacheDependency.ResumeLayout(false);
            this.tpTableDependency.ResumeLayout(false);
            this.tpTableCacheDependency.ResumeLayout(false);
            this.tpDependencyAccess.ResumeLayout(false);
            this.tpDependencyFacade.ResumeLayout(false);
            this.tpBL.ResumeLayout(false);
            this.tpUserControl.ResumeLayout(false);
            this.tpUserControlDesignerCs.ResumeLayout(false);
            this.tpUserControlCs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tcCodes;
        private System.Windows.Forms.TabPage tpModel;
        private ICSharpCode.TextEditor.TextEditorControl txtModel;
        private System.Windows.Forms.TabPage tpIDAL;
        private ICSharpCode.TextEditor.TextEditorControl txtIDAL;
        private System.Windows.Forms.TabPage tpDAL;
        private ICSharpCode.TextEditor.TextEditorControl txtDAL;
        private System.Windows.Forms.TabPage tpDALFactory;
        private ICSharpCode.TextEditor.TextEditorControl txtDALFactory;
        private System.Windows.Forms.TabPage tpBL;
        private ICSharpCode.TextEditor.TextEditorControl txtBL;
        private System.Windows.Forms.ComboBox cobLevel3Frame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobCacheFrame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabPage tpUserControl;
        private ICSharpCode.TextEditor.TextEditorControl txtUserControl;
        private System.Windows.Forms.TabPage tpUserControlCs;
        private ICSharpCode.TextEditor.TextEditorControl txtUserControlCs;
        private System.Windows.Forms.TextBox txtAfterNamespace;
        private System.Windows.Forms.TextBox txtBeforeNamespace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tpICacheDependency;
        private ICSharpCode.TextEditor.TextEditorControl txtICacheDependency;
        private System.Windows.Forms.TabPage tpTableDependency;
        private ICSharpCode.TextEditor.TextEditorControl txtTableDependency;
        private System.Windows.Forms.TabPage tpTableCacheDependency;
        private ICSharpCode.TextEditor.TextEditorControl txtTableCacheDependency;
        private System.Windows.Forms.TabPage tpDependencyAccess;
        private ICSharpCode.TextEditor.TextEditorControl txtDependencyAccess;
        private System.Windows.Forms.TabPage tpDependencyFacade;
        private ICSharpCode.TextEditor.TextEditorControl txtDependencyFacade;
        private System.Windows.Forms.ComboBox cobCmdType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cobBLFrame;
        private System.Windows.Forms.Button btnSaveCurrentTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tpUserControlDesignerCs;
        private ICSharpCode.TextEditor.TextEditorControl txtUserControlDesignerCs;

    }
}