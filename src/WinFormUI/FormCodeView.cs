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
        /// ���캯��
        /// </summary>
        /// <param name="caption">����</param>
        /// <param name="text">����</param>
        /// <param name="lang">����:"ASP3/XHTML","BAT","Boo","Coco","C++.NET","C#","HTML",
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