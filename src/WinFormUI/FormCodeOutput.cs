using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using CodeFactory;
using System.Data.OleDb;
using System.Threading;
using System.Xml;
using System.Diagnostics;

namespace SocanCode
{
    public partial class FormCodeOutput : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private Model.Database db;

        public FormCodeOutput(ContextMenuStrip cms, Model.Database db)
        {
            InitializeComponent();
            this.TabPageContextMenuStrip = cms;

            this.db = db;
            this.TabText = string.Format("输出代码 {0}", db.DbName);

            foreach (Model.Table table in db.Tables)
            {
                lstTables.Items.Add(table);
            }
            foreach (Model.Table view in db.Views)
            {
                lstTables.Items.Add(view);
            }

            LoadConfig(db);
        }

        /// <summary>
        /// 生成样式
        /// </summary>
        private Model.CreateStyle createStyle
        {
            get
            {
                Model.CreateStyle createStyle = new Model.CreateStyle();
                createStyle.Level3Frame = radVS2005.Checked ? Model.CreateStyle.Level3Frames.VS2005 : Model.CreateStyle.Level3Frames.VS2008;
                createStyle.CreateFilePath = txtPath.Text;
                createStyle.HasCreateBL = chkBL.Checked;
                createStyle.HasCreateDAL = chkDAL.Checked;
                createStyle.HasCreateDALFactory = chkDALFactory.Checked;
                createStyle.HasCreateDBULibrary = chkDBUtility.Checked;
                createStyle.HasCreateIDAL = chkIDAL.Checked;
                createStyle.HasCreateModel = chkModel.Checked;
                createStyle.HasCreateUserControl = chkUserControl.Checked;
                createStyle.HasCreateICacheDependency = chkICacheDependency.Checked;
                createStyle.HasCreateTableCacheDependency = chkTableCacheDependency.Checked;
                createStyle.HasCreateCacheDependencyFactory = chkCacheDependencyFactory.Checked;
                return createStyle;
            }
        }

        /// <summary>
        /// 代码样式
        /// </summary>
        private Model.CodeStyle codeStyle
        {
            get
            {
                Model.CodeStyle codeStyle = new Model.CodeStyle();
                codeStyle.DBHelperName = db.DbName + "Helper";
                codeStyle.BeforeNamespace = txtBeforeNamespace.Text.Trim();
                codeStyle.AfterNamespace = txtAfterNamespace.Text.Trim();

                switch (cobLevel3Frame.SelectedIndex)
                {
                    case 0:
                        codeStyle.SlnFrame = Model.CodeStyle.SlnFrames.Simple;
                        break;
                    case 1:
                        codeStyle.SlnFrame = Model.CodeStyle.SlnFrames.Factory;
                        break;
                    default:
                        break;
                }
                switch (cobCacheFrame.SelectedIndex)
                {
                    case 0:
                        codeStyle.CacheFrame = Model.CodeStyle.CacheFrames.None;
                        break;
                    case 1:
                        codeStyle.CacheFrame = Model.CodeStyle.CacheFrames.ObjectCache;
                        break;
                    case 2:
                        codeStyle.CacheFrame = Model.CodeStyle.CacheFrames.AggregateDependency;
                        break;
                    case 3:
                        codeStyle.CacheFrame = Model.CodeStyle.CacheFrames.ObjectCacheAndAggregateDependency;
                        break;
                    default:
                        break;
                }
                switch (cobCmdType.SelectedIndex)
                {
                    case 0:
                        codeStyle.CmdType = CommandType.Text;
                        break;
                    case 1:
                        codeStyle.CmdType = CommandType.StoredProcedure;
                        break;
                    default:
                        break;
                }
                switch (cobDALFrame.SelectedIndex)
                {
                    case 1:
                        codeStyle.DALFrame = Model.CodeStyle.DALFrames.AccessDAL;
                        break;
                    case 2:
                        codeStyle.DALFrame = Model.CodeStyle.DALFrames.SqlServerDAL;
                        break;
                    case 3:
                        codeStyle.DALFrame = Model.CodeStyle.DALFrames.MySqlDAL;
                        break;
                    case 4:
                        codeStyle.DALFrame = Model.CodeStyle.DALFrames.OracleDAL;
                        break;
                    default:
                        codeStyle.DALFrame = Model.CodeStyle.DALFrames.DAL;
                        break;
                }
                switch (cobBLFrame.SelectedIndex)
                {
                    case 1:
                        codeStyle.BlFrame = Model.CodeStyle.BLFrame.BLS;
                        break;
                    default:
                        codeStyle.BlFrame = Model.CodeStyle.BLFrame.BLL;
                        break;
                }
                return codeStyle;
            }
        }

        /// <summary>
        /// 要输出的表
        /// </summary>
        private List<Model.Table> outputTables
        {
            get
            {
                List<Model.Table> tables = new List<Model.Table>();
                foreach (object obj in lstSelectedTables.Items)
                {
                    tables.Add(obj as Model.Table);
                }
                return tables;
            }
        }

        private void LoadConfig(Model.Database db)
        {
            int selectedLevel3Frame = Properties.Settings.Default.Level3Frame;
            if (cobLevel3Frame.Items.Count > selectedLevel3Frame)
                cobLevel3Frame.SelectedIndex = selectedLevel3Frame;

            txtBeforeNamespace.Text = Properties.Settings.Default.BeforeNamespace;
            txtAfterNamespace.Text = Properties.Settings.Default.AfterNamespace;
            chkDBUtility.Checked = Properties.Settings.Default.IsCreateDBUtility;
            chkModel.Checked = Properties.Settings.Default.IsCreateModel;
            chkIDAL.Checked = Properties.Settings.Default.IsCreateIDAL;
            chkDAL.Checked = Properties.Settings.Default.IsCreateDAL;

            int selectedCmdType = Properties.Settings.Default.CmdType;
            if (cobCmdType.Items.Count > selectedCmdType)
                cobCmdType.SelectedIndex = selectedCmdType;

            int selectedDALFrame = Properties.Settings.Default.DALFrame;
            if (selectedDALFrame < 0)
            {
                switch (db.Type)
                {
                    case Model.Database.DatabaseType.Access:
                        cobDALFrame.SelectedIndex = 1;
                        break;
                    case Model.Database.DatabaseType.Sql2000:
                    case Model.Database.DatabaseType.Sql2005:
                        cobDALFrame.SelectedIndex = 2;
                        break;
                    case Model.Database.DatabaseType.MySql:
                        cobDALFrame.SelectedIndex = 3;
                        break;
                    default:
                        cobDALFrame.SelectedIndex = 0;
                        break;
                }

            }
            else
            {
                if (cobDALFrame.Items.Count > selectedDALFrame)
                    cobDALFrame.SelectedIndex = selectedDALFrame;
            }

            chkDALFactory.Checked = Properties.Settings.Default.IsCreateDALFactory;
            chkBL.Checked = Properties.Settings.Default.IsCreateBL;

            int selectedCacheFrame = Properties.Settings.Default.CacheFrame;
            if (cobCacheFrame.Items.Count > selectedCacheFrame)
                cobCacheFrame.SelectedIndex = selectedCacheFrame;

            int selectedBLFrame = Properties.Settings.Default.BLFrame;
            if (cobBLFrame.Items.Count > selectedBLFrame)
                cobBLFrame.SelectedIndex = selectedBLFrame;

            chkUserControl.Checked = Properties.Settings.Default.IsCreateUserControl;
            txtControlsPath.Text = Properties.Settings.Default.ControlsPath;
            chkICacheDependency.Checked = Properties.Settings.Default.IsCreateICacheDependency;
            chkTableCacheDependency.Checked = Properties.Settings.Default.IsCreateTableCacheDependency;
            chkCacheDependencyFactory.Checked = Properties.Settings.Default.IsCreateCacheDependencyFactory;
        }

        void SaveConfig()
        {
            Properties.Settings.Default.Level3Frame = cobLevel3Frame.SelectedIndex;
            Properties.Settings.Default.BeforeNamespace = txtBeforeNamespace.Text;
            Properties.Settings.Default.AfterNamespace = txtAfterNamespace.Text;
            Properties.Settings.Default.IsCreateDBUtility = chkDBUtility.Checked;
            Properties.Settings.Default.IsCreateModel = chkModel.Checked;
            Properties.Settings.Default.IsCreateIDAL = chkIDAL.Checked;
            Properties.Settings.Default.IsCreateDAL = chkDAL.Checked;
            Properties.Settings.Default.CmdType = cobCmdType.SelectedIndex;

            if (cobDALFrame.SelectedIndex == 0)
                Properties.Settings.Default.DALFrame = 0;
            else
                Properties.Settings.Default.DALFrame = -1;

            Properties.Settings.Default.IsCreateDALFactory = chkDALFactory.Checked;
            Properties.Settings.Default.IsCreateBL = chkBL.Checked;

            int selectedCacheFrame = Properties.Settings.Default.CacheFrame = cobCacheFrame.SelectedIndex;

            Properties.Settings.Default.BLFrame = cobBLFrame.SelectedIndex;

            Properties.Settings.Default.IsCreateUserControl = chkUserControl.Checked;
            Properties.Settings.Default.ControlsPath = txtControlsPath.Text;
            Properties.Settings.Default.IsCreateICacheDependency = chkICacheDependency.Checked;
            Properties.Settings.Default.IsCreateTableCacheDependency = chkTableCacheDependency.Checked;
            Properties.Settings.Default.IsCreateCacheDependencyFactory = chkCacheDependencyFactory.Checked;

            Properties.Settings.Default.Save();
        }

        private void btnOutputCode_Click(object sender, EventArgs e)
        {
            if (lstSelectedTables.Items.Count <= 0)
            {
                FormMain.ShowMessage("未选择任何表!");
                return;
            }

            foreach (Model.Table table in outputTables)
            {
                if (!table.HasConditonRow)
                {
                    FormMain.ShowMessage(string.Format("表{0}不存在任何字段，无法生成！", table.Name));
                    return;
                }
            }

            if (MessageBox.Show("确定要输出代码吗?", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            if (Directory.Exists(createStyle.CreateFilePath))
            {
                if (MessageBox.Show("该目录已存在，是否删除?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Directory.Delete(createStyle.CreateFilePath, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }

            SaveConfig();

            OutputCode(outputTables, codeStyle, createStyle);

            CreateSln(createStyle, codeStyle);

            progressBar1.Value = 0;

            if (MessageBox.Show("成功生成,是否打开目录?", "恭喜", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Process.Start(createStyle.CreateFilePath);
        }

        private void btnOutputStoreProcedure_Click(object sender, EventArgs e)
        {
            if (lstSelectedTables.Items.Count <= 0)
            {
                FormMain.ShowMessage("未选择任何表!");
                return;
            }
            if (MessageBox.Show("确定要输出存储过程吗?", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            OutputStoreProcedure(outputTables, createStyle);

            if (MessageBox.Show("成功生成,是否打开目录?", "恭喜", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Process.Start(createStyle.CreateFilePath);
        }

        private void OutputStoreProcedure(List<Model.Table> tables, Model.CreateStyle createStyle)
        {
            string path = createStyle.CreateFilePath;
            Directory.CreateDirectory(path);
            CodeFactory.StoreProcedureAccess.CreateStoreProcedureFile(db, tables, path);
        }

        /// <summary>
        /// 创建Sln文件
        /// </summary>
        private void CreateSln(Model.CreateStyle createStyle, Model.CodeStyle codeStyle)
        {
            StringBuilder sln = new StringBuilder();

            switch (createStyle.Level3Frame)
            {
                case Model.CreateStyle.Level3Frames.VS2008:
                    sln.AppendLine("Microsoft Visual Studio Solution File, Format Version 10.00");
                    sln.AppendLine("# Visual Studio 2008");
                    break;
                case Model.CreateStyle.Level3Frames.VS2005:
                default:
                    sln.AppendLine("Microsoft Visual Studio Solution File, Format Version 9.00");
                    sln.AppendLine("# Visual Studio 2005");
                    break;
            }

            if (createStyle.HasCreateBL)
            {
                switch (codeStyle.BlFrame)
                {
                    case Model.CodeStyle.BLFrame.BLS:
                        sln.AppendLine(CodeUtility.FileStream.ReadFile(Model.CreateStyle.CURRENT_PATH + "\\Sln\\BLS.csproj"));
                        break;
                    case Model.CodeStyle.BLFrame.BLL:
                    default:
                        sln.AppendLine(CodeUtility.FileStream.ReadFile(Model.CreateStyle.CURRENT_PATH + "\\Sln\\BLL.csproj"));
                        break;
                }
            }

            if (createStyle.HasCreateDAL)
            {
                switch (codeStyle.DALFrame)
                {
                    case Model.CodeStyle.DALFrames.AccessDAL:
                        sln.AppendLine(CodeUtility.FileStream.ReadFile(Model.CreateStyle.CURRENT_PATH + "\\Sln\\AccessDAL.csproj"));
                        break;
                    case Model.CodeStyle.DALFrames.SqlServerDAL:
                        sln.AppendLine(CodeUtility.FileStream.ReadFile(Model.CreateStyle.CURRENT_PATH + "\\Sln\\SqlServerDAL.csproj"));
                        break;
                    case Model.CodeStyle.DALFrames.MySqlDAL:
                        sln.AppendLine(CodeUtility.FileStream.ReadFile(Model.CreateStyle.CURRENT_PATH + "\\Sln\\MySqlDAL.csproj"));
                        break;
                    case Model.CodeStyle.DALFrames.OracleDAL:
                        sln.AppendLine(CodeUtility.FileStream.ReadFile(Model.CreateStyle.CURRENT_PATH + "\\Sln\\OracleDAL.csproj"));
                        break;
                    default:
                        sln.AppendLine(CodeUtility.FileStream.ReadFile(Model.CreateStyle.CURRENT_PATH + "\\Sln\\DAL.csproj"));
                        break;
                }
            }

            if (createStyle.HasCreateDALFactory)
            {
                sln.AppendLine(CodeUtility.FileStream.ReadFile(Model.CreateStyle.CURRENT_PATH + "\\Sln\\DALFactory.csproj"));
            }

            if (createStyle.HasCreateDBULibrary)
            {
                sln.AppendLine(CodeUtility.FileStream.ReadFile(Model.CreateStyle.CURRENT_PATH + "\\Sln\\DBUtility.csproj"));
            }

            if (createStyle.HasCreateIDAL)
            {
                sln.AppendLine(CodeUtility.FileStream.ReadFile(Model.CreateStyle.CURRENT_PATH + "\\Sln\\IDAL.csproj"));
            }

            if (createStyle.HasCreateModel)
            {
                sln.AppendLine(CodeUtility.FileStream.ReadFile(Model.CreateStyle.CURRENT_PATH + "\\Sln\\Model.csproj"));
            }

            if (createStyle.HasCreateICacheDependency)
            {
                sln.AppendLine(CodeUtility.FileStream.ReadFile(Model.CreateStyle.CURRENT_PATH + "\\Sln\\ICacheDependency.csproj"));
            }

            if (createStyle.HasCreateTableCacheDependency)
            {
                sln.AppendLine(CodeUtility.FileStream.ReadFile(Model.CreateStyle.CURRENT_PATH + "\\Sln\\TableCacheDependency.csproj"));
            }

            if (createStyle.HasCreateCacheDependencyFactory)
            {
                sln.AppendLine(CodeUtility.FileStream.ReadFile(Model.CreateStyle.CURRENT_PATH + "\\Sln\\CacheDependencyFactory.csproj"));
            }

            if (createStyle.HasCreateUserControl)
            {
                sln.AppendLine(CodeUtility.FileStream.ReadFile(Model.CreateStyle.CURRENT_PATH + "\\Sln\\Web.csproj"));
            }

            Directory.CreateDirectory(createStyle.CreateFilePath);
            StreamWriter sw = new StreamWriter(createStyle.CreateFilePath + "\\Socansoft.sln");
            sw.Write(sln.ToString());
            sw.Close();
        }

        /// <summary>
        /// 输出代码
        /// </summary>
        private void OutputCode(List<Model.Table> tables, Model.CodeStyle codeStyle, Model.CreateStyle createStyle)
        {
            string slnDictionary = createStyle.Level3Frame == Model.CreateStyle.Level3Frames.VS2005 ? "Template2005" : "Template2008";

            if (createStyle.HasCreateModel)
            {
                string pathModel = createStyle.CreateFilePath + "\\Model";
                CopyFiles(string.Format("{0}\\{1}\\Model", Model.CreateStyle.CURRENT_PATH, slnDictionary), pathModel);
                CodeFactory.CodeAccess.CreateModelFile(db, tables, codeStyle, pathModel);
            }
            progressBar1.Value = 10;

            if (createStyle.HasCreateIDAL)
            {
                string pathIDAL = createStyle.CreateFilePath + "\\IDAL";
                CopyFiles(string.Format("{0}\\{1}\\IDAL", Model.CreateStyle.CURRENT_PATH, slnDictionary), pathIDAL);
                CodeFactory.CodeAccess.CreateIDALFile(db, tables, codeStyle, pathIDAL);
            }
            progressBar1.Value = 20;

            if (createStyle.HasCreateDAL)
            {
                string pathDAL = createStyle.CreateFilePath + "\\" + codeStyle.DALFrame.ToString();
                CopyFiles(string.Format("{0}\\{1}\\{2}", Model.CreateStyle.CURRENT_PATH, slnDictionary, codeStyle.DALFrame.ToString()), pathDAL);
                CodeFactory.CodeAccess.CreateDALFile(db, tables, codeStyle, pathDAL);
            }
            progressBar1.Value = 30;

            if (createStyle.HasCreateBL)
            {
                string pathBL;
                pathBL = createStyle.CreateFilePath + "\\" + codeStyle.BlFrame.ToString();
                CopyFiles(string.Format("{0}\\{1}\\{2}", Model.CreateStyle.CURRENT_PATH, slnDictionary, codeStyle.BlFrame.ToString()), pathBL);
                CodeFactory.CodeAccess.CreateBLFile(db, tables, codeStyle, pathBL);
            }
            progressBar1.Value = 40;

            if (createStyle.HasCreateUserControl)
            {
                string pathUserControl = createStyle.CreateFilePath + "\\Web\\" + txtControlsPath.Text;
                CopyFiles(string.Format("{0}\\{1}\\Web", Model.CreateStyle.CURRENT_PATH, slnDictionary), createStyle.CreateFilePath + "\\Web");
                CodeFactory.CodeAccess.CreateUserControl(db, tables, codeStyle, pathUserControl);
            }
            progressBar1.Value = 50;

            if (createStyle.HasCreateDALFactory)
            {
                string pathDALFactory = createStyle.CreateFilePath + "\\DALFactory";
                CopyFiles(string.Format("{0}\\{1}\\DALFactory", Model.CreateStyle.CURRENT_PATH, slnDictionary), pathDALFactory);
                CodeFactory.CodeAccess.CreateDALFactoryFile(tables, codeStyle, pathDALFactory);
            }
            progressBar1.Value = 50;

            if (createStyle.HasCreateDBULibrary)
            {
                string pathDBUtility = createStyle.CreateFilePath + "\\DBUtility";
                CopyFiles(string.Format("{0}\\{1}\\DBUtility", Model.CreateStyle.CURRENT_PATH, slnDictionary), pathDBUtility);
            }
            progressBar1.Value = 60;

            if (createStyle.HasCreateICacheDependency)
            {
                string pathICacheDependency = createStyle.CreateFilePath + "\\ICacheDependency";
                CopyFiles(string.Format("{0}\\{1}\\ICacheDependency", Model.CreateStyle.CURRENT_PATH, slnDictionary), pathICacheDependency);
                CodeFactory.CodeAccess.CreateICacheDependencyFile(codeStyle, pathICacheDependency);
            }
            progressBar1.Value = 70;

            if (createStyle.HasCreateTableCacheDependency)
            {
                string pathTableCacheDependency = createStyle.CreateFilePath + "\\TableCacheDependency";
                CopyFiles(string.Format("{0}\\{1}\\TableCacheDependency", Model.CreateStyle.CURRENT_PATH, slnDictionary), pathTableCacheDependency);
                CodeFactory.CodeAccess.CreateTableCacheDependencyFile(db, tables, codeStyle, pathTableCacheDependency);
            }
            progressBar1.Value = 80;

            if (createStyle.HasCreateCacheDependencyFactory)
            {
                string pathCacheDependencyFactory = createStyle.CreateFilePath + "\\CacheDependencyFactory";
                CopyFiles(string.Format("{0}\\{1}\\CacheDependencyFactory", Model.CreateStyle.CURRENT_PATH, slnDictionary), pathCacheDependencyFactory);
                CodeFactory.CodeAccess.CreateCacheDependencyFactoryFile(tables, codeStyle, pathCacheDependencyFactory);
            }
            progressBar1.Value = 90;
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dlg.SelectedPath;
            }
        }

        #region ---------------  选择表和视图的操作  ---------------

        private void btnSelected_Click(object sender, EventArgs e)
        {
            List<object> objs = new List<object>();
            foreach (object obj in lstTables.SelectedItems)
            {
                objs.Add(obj);
            }
            foreach (object obj in objs)
            {
                lstSelectedTables.Items.Add(obj);
                lstTables.Items.Remove(obj);
            }
        }

        private void btnSelectedAll_Click(object sender, EventArgs e)
        {
            List<object> objs = new List<object>();
            foreach (object obj in lstTables.Items)
            {
                objs.Add(obj);
            }
            foreach (object obj in objs)
            {
                lstSelectedTables.Items.Add(obj);
                lstTables.Items.Remove(obj);
            }
        }

        private void btnUnSelected_Click(object sender, EventArgs e)
        {
            List<object> objs = new List<object>();
            foreach (object obj in lstSelectedTables.SelectedItems)
            {
                objs.Add(obj);
            }
            foreach (object obj in objs)
            {
                lstTables.Items.Add(obj);
                lstSelectedTables.Items.Remove(obj);
            }
        }

        private void btnUnSelectedAll_Click(object sender, EventArgs e)
        {
            List<object> objs = new List<object>();
            foreach (object obj in lstSelectedTables.Items)
            {
                objs.Add(obj);
            }
            foreach (object obj in objs)
            {
                lstTables.Items.Add(obj);
                lstSelectedTables.Items.Remove(obj);
            }
        }

        #endregion

        private void chkUserControl_CheckedChanged(object sender, EventArgs e)
        {
            txtControlsPath.Enabled = chkUserControl.Checked;
        }

        private void cobSlnFrame_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cobLevel3Frame.SelectedIndex)
            {
                case 0:
                    chkDBUtility.Checked = true;
                    chkModel.Checked = true;
                    chkDAL.Checked = true;
                    chkBL.Checked = true;
                    chkIDAL.Checked = chkIDAL.Enabled = false;
                    chkDALFactory.Checked = chkDALFactory.Enabled = false;
                    break;
                case 1:
                    chkDBUtility.Checked = true;
                    chkModel.Checked = true;
                    chkDAL.Checked = true;
                    chkBL.Checked = true;
                    chkIDAL.Checked = chkIDAL.Enabled = true;
                    chkDALFactory.Checked = chkDALFactory.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void CopyFiles(string sourceDirectory, string targetDirectory)
        {
            Directory.CreateDirectory(targetDirectory);

            if (!Directory.Exists(sourceDirectory)) return;

            string[] directories = Directory.GetDirectories(sourceDirectory);

            if (directories.Length > 0)
            {
                foreach (string d in directories)
                {
                    CopyFiles(d, targetDirectory + d.Substring(d.LastIndexOf("\\")));
                }
            }

            string[] files = Directory.GetFiles(sourceDirectory);

            if (files.Length > 0)
            {
                foreach (string s in files)
                {
                    File.Copy(s, targetDirectory + s.Substring(s.LastIndexOf("\\")), true);
                }
            }
        }

        private void cobCacheFrame_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cobCacheFrame.SelectedIndex)
            {
                case 2:
                case 3:
                    chkICacheDependency.Enabled = chkICacheDependency.Checked = true;
                    chkTableCacheDependency.Enabled = chkTableCacheDependency.Checked = true;
                    chkCacheDependencyFactory.Enabled = chkCacheDependencyFactory.Checked = true;
                    break;
                default:
                    chkICacheDependency.Enabled = chkICacheDependency.Checked = false;
                    chkTableCacheDependency.Enabled = chkTableCacheDependency.Checked = false;
                    chkCacheDependencyFactory.Enabled = chkCacheDependencyFactory.Checked = false;
                    break;
            }
        }

        private void cobDALFrame_SelectedIndexChanged(object sender, EventArgs e)
        {
            cobCacheFrame.Items.Clear();
            cobCacheFrame.Items.Add("不使用");
            cobCacheFrame.Items.Add("缓存对象");

            switch (cobDALFrame.SelectedIndex)
            {
                case 2:
                    cobCacheFrame.Items.Add("聚合缓存依赖");
                    cobCacheFrame.Items.Add("缓存对象+聚合缓存依赖");
                    break;
                default:
                    break;
            }
            cobCacheFrame.SelectedIndex = 0;

            switch (cobDALFrame.SelectedIndex)
            {
                case 0:
                    cobLevel3Frame.SelectedIndex = 0;
                    cobLevel3Frame.Enabled = false;
                    break;
                default:
                    cobLevel3Frame.Enabled = true;
                    break;
            }
        }

        private void cobBLFrame_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cobBLFrame.SelectedIndex)
            {
                case 1:
                    FormMain.ShowMessage("不建议直接把业务逻辑层做成Web服务，\n更好的做法是新建一个Web服务项目，调用业务逻辑层的方法。");
                    break;
                default:
                    break;
            }
        }

        private void FormCodeOutput_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }
    }
}