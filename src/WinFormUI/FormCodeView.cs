using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Document;

namespace SocanCode
{
    public partial class FormCodeView : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="caption">标题</param>
        /// <param name="text">内容</param>
        /// <param name="lang">语言:"ASP3/XHTML","BAT","Boo","Coco","C++.NET","C#","HTML",
        /// "Java","JavaScript","PHP","TeX","VBNET","XML","TSQL"</param>
        public FormCodeView(ContextMenuStrip cms, string caption, string text, string language)
        {
            InitializeComponent();
            this.TabPageContextMenuStrip = cms;

            this.TabText = caption;
            TextEditor.SetStyle(txtCode, language);
            txtCode.Text = text;
        }
    }
}