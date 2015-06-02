using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace SocanCode
{
    public partial class FormCodeCreate : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private Model.Table table;
        private Model.Database db;

        public FormCodeCreate(ContextMenuStrip cms, Model.Database db, Model.Table table)
        {
            InitializeComponent();
            this.TabPageContextMenuStrip = cms;

            this.db = db;
            this.table = table;
            this.TabText = string.Format("生成代码 {0}", table.Name);

            LoadConfig();

            tcCodes.Controls.Clear();

            TextEditor.SetStyle(txtModel, "C#");
            TextEditor.SetStyle(txtIDAL, "C#");
            TextEditor.SetStyle(txtDALFactory, "C#");
            TextEditor.SetStyle(txtDAL, "C#");
            TextEditor.SetStyle(txtBL, "C#");
            TextEditor.SetStyle(txtUserControl, "HTML");
            TextEditor.SetStyle(txtUserControlDesignerCs, "C#");
            TextEditor.SetStyle(txtUserControlCs, "C#");

            TextEditor.SetStyle(txtICacheDependency, "C#");
            TextEditor.SetStyle(txtTableDependency, "C#");
            TextEditor.SetStyle(txtTableCacheDependency, "C#");
            TextEditor.SetStyle(txtDependencyAccess, "C#");
            TextEditor.SetStyle(txtDependencyFacade, "C#");
        }

        private void LoadConfig()
        {
            int selectedLevel3Frame = Properties.Settings.Default.Level3Frame;
            if (cobLevel3Frame.Items.Count > selectedLevel3Frame)
                cobLevel3Frame.SelectedIndex = selectedLevel3Frame;

            int selectedBLFrame = Properties.Settings.Default.BLFrame;
            if (cobBLFrame.Items.Count > selectedBLFrame)
                cobBLFrame.SelectedIndex = selectedBLFrame;

            int selectedCacheFrame = Properties.Settings.Default.CacheFrame;
            if (cobCacheFrame.Items.Count > selectedCacheFrame)
                cobCacheFrame.SelectedIndex = selectedCacheFrame;

            txtBeforeNamespace.Text = Properties.Settings.Default.BeforeNamespace;

            int selectedCmdType = Properties.Settings.Default.CmdType;
            if (cobCmdType.Items.Count > selectedCmdType)
                cobCmdType.SelectedIndex = selectedCmdType;

            txtAfterNamespace.Text = Properties.Settings.Default.AfterNamespace;
        }

        void SaveConfig()
        {
            Properties.Settings.Default.Level3Frame = cobLevel3Frame.SelectedIndex;
            Properties.Settings.Default.BLFrame = cobBLFrame.SelectedIndex;
            Properties.Settings.Default.CacheFrame = cobCacheFrame.SelectedIndex;
            Properties.Settings.Default.BeforeNamespace = txtBeforeNamespace.Text;
            Properties.Settings.Default.CmdType = cobCmdType.SelectedIndex;
            Properties.Settings.Default.AfterNamespace = txtAfterNamespace.Text;
            Properties.Settings.Default.Save();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveConfig();

            #region 获取生成样式
            Model.CodeStyle style = new Model.CodeStyle();
            style.DBHelperName = db.DbName + "Helper";
            style.BeforeNamespace = txtBeforeNamespace.Text.Trim();
            style.AfterNamespace = txtAfterNamespace.Text.Trim();

            switch (cobLevel3Frame.SelectedIndex)
            {
                case 0:
                    style.SlnFrame = Model.CodeStyle.SlnFrames.Simple;
                    break;
                case 1:
                    style.SlnFrame = Model.CodeStyle.SlnFrames.Factory;
                    break;
                default:
                    break;
            }
            switch (cobCacheFrame.SelectedIndex)
            {
                case 0:
                    style.CacheFrame = Model.CodeStyle.CacheFrames.None;
                    break;
                case 1:
                    style.CacheFrame = Model.CodeStyle.CacheFrames.ObjectCache;
                    break;
                case 2:
                    style.CacheFrame = Model.CodeStyle.CacheFrames.AggregateDependency;
                    break;
                case 3:
                    style.CacheFrame = Model.CodeStyle.CacheFrames.ObjectCacheAndAggregateDependency;
                    break;
                default:
                    break;
            }
            switch (cobCmdType.SelectedIndex)
            {
                case 0:
                    style.CmdType = CommandType.Text;
                    break;
                case 1:
                    style.CmdType = CommandType.StoredProcedure;
                    break;
                default:
                    break;
            }
            switch (cobBLFrame.SelectedIndex)
            {
                case 1:
                    style.BlFrame = Model.CodeStyle.BLFrame.BLS;
                    break;
                default:
                    style.BlFrame = Model.CodeStyle.BLFrame.BLL;
                    break;
            }
            #endregion

            List<Model.Table> tables = new List<Model.Table>();
            tables.Add(table);

            tcCodes.Controls.Clear();

            //Model
            txtModel.Tag = Model.CodeLayer.CodeLayers.Model;
            txtModel.Text = Codes.ModelCode.GetModelCode(table, style);
            tcCodes.Controls.Add(tpModel);

            //IDAL
            if (style.SlnFrame == Model.CodeStyle.SlnFrames.Factory)
            {
                txtIDAL.Tag = Model.CodeLayer.CodeLayers.IDAL;
                txtIDAL.Text = Codes.IDALCode.GetIDALCode(table, style);
                tcCodes.Controls.Add(tpIDAL);
            }

            //DAL
            txtDAL.Tag = Model.CodeLayer.CodeLayers.DAL;
            txtDAL.Text = Codes.DALCode.GetDALCode(db, table, style);
            tcCodes.Controls.Add(tpDAL);

            //DALFactory
            if (style.SlnFrame == Model.CodeStyle.SlnFrames.Factory)
            {
                txtDALFactory.Tag = Model.CodeLayer.CodeLayers.DALFactory;
                txtDALFactory.Text = Codes.DALFactoryCode.GetDALFactoryCode(tables, style);
                tcCodes.Controls.Add(tpDALFactory);
            }

            if (style.CacheFrame == Model.CodeStyle.CacheFrames.AggregateDependency ||
                style.CacheFrame == Model.CodeStyle.CacheFrames.ObjectCacheAndAggregateDependency)
            {
                //ICacheDependency
                txtICacheDependency.Tag = Model.CodeLayer.CodeLayers.ICacheDependency;
                txtICacheDependency.Text = Codes.ICacheDependencyCode.GetICacheDependencyCode(style);
                tcCodes.Controls.Add(tpICacheDependency);

                //TableDependency
                txtTableDependency.Tag = Model.CodeLayer.CodeLayers.TableDependency;
                txtTableDependency.Text = Codes.TableCacheDependencyCode.GetTableDependencyCode(db, style);
                tcCodes.Controls.Add(tpTableDependency);

                //TableCacheDependency
                txtTableCacheDependency.Tag = Model.CodeLayer.CodeLayers.TableCacheDependency;
                txtTableCacheDependency.Text = Codes.TableCacheDependencyCode.GetTableCacheDependencyCode(db, table, style);
                tcCodes.Controls.Add(tpTableCacheDependency);

                //DependencyAccess
                txtDependencyAccess.Tag = Model.CodeLayer.CodeLayers.DependencyAccess;
                txtDependencyAccess.Text = Codes.CacheDependencyFactoryCode.GetDependencyAccessCode(tables, style);
                tcCodes.Controls.Add(tpDependencyAccess);

                //DependencyFacade
                txtDependencyFacade.Tag = Model.CodeLayer.CodeLayers.DependencyFacade;
                txtDependencyFacade.Text = Codes.CacheDependencyFactoryCode.GetDependencyFacadeCode(tables, style);
                tcCodes.Controls.Add(tpDependencyFacade);
            }

            //BL
            txtBL.Tag = Model.CodeLayer.CodeLayers.BL;
            txtBL.Text = Codes.BLCode.GetBLCSCode(db, table, style);
            tcCodes.Controls.Add(tpBL);

            //UserControl
            txtUserControl.Tag = Model.CodeLayer.CodeLayers.UserControl;
            txtUserControl.Text = Codes.UserControlCode.GetUserControlCode(table, style);
            tcCodes.Controls.Add(tpUserControl);

            //UserControlDesignerCs
            txtUserControlDesignerCs.Tag = Model.CodeLayer.CodeLayers.UserControlDesignerCs;
            txtUserControlDesignerCs.Text = Codes.UserControlCode.GetWebUserControlDesignerCsCode(table, style);
            tcCodes.Controls.Add(tpUserControlDesignerCs);

            //UserControlCs
            txtUserControlCs.Tag = Model.CodeLayer.CodeLayers.UserControlCs;
            txtUserControlCs.Text = Codes.UserControlCode.GetWebUserControlCsCode(table, style);
            tcCodes.Controls.Add(tpUserControlCs);

            btnSaveCurrentTab.Enabled = btnSaveAll.Enabled = true;
        }

        private void btnSaveCurrentTab_Click(object sender, EventArgs e)
        {
            if (tcCodes.SelectedTab == null)
            {
                MessageBox.Show("请先生成代码！");
                return;
            }

            ICSharpCode.TextEditor.TextEditorControl txtEditor = tcCodes.SelectedTab.Controls[0] as ICSharpCode.TextEditor.TextEditorControl;
            if (txtEditor != null)
            {
                Model.CodeLayer.CodeLayers layer = (Model.CodeLayer.CodeLayers)txtEditor.Tag;
                Model.CodeLayer codeLayer = new Model.CodeLayer(layer);

                SaveFileDialog dlg = new SaveFileDialog();
                dlg.AddExtension = true;
                dlg.FileName = string.Format(codeLayer.FileName, table.Name);
                dlg.Filter = string.Format(".{0}|*.{0}", codeLayer.FileExt);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    CodeUtility.FileStream.WriteFile(dlg.FileName, txtEditor.Text);
                }
            }
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            if (tcCodes.TabPages == null)
            {
                MessageBox.Show("请先生成代码！");
                return;
            }

            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (TabPage page in tcCodes.TabPages)
                {
                    ICSharpCode.TextEditor.TextEditorControl txtEditor = page.Controls[0] as ICSharpCode.TextEditor.TextEditorControl;
                    if (txtEditor != null)
                    {
                        Model.CodeLayer.CodeLayers layer = (Model.CodeLayer.CodeLayers)txtEditor.Tag;
                        Model.CodeLayer codeLayer = new Model.CodeLayer(layer);
                        string filePath = dlg.SelectedPath + "\\" + codeLayer.Folder;
                        string fileName = string.Format(codeLayer.FileName, table.Name);

                        if (!Directory.Exists(filePath))
                        {
                            Directory.CreateDirectory(filePath);
                        }

                        CodeUtility.FileStream.WriteFile(filePath + "\\" + fileName, txtEditor.Text);
                    }
                }
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

        private void FormCodeCreate_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }
    }
}