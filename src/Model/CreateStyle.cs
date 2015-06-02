using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class CreateStyle
    {
        public static string CURRENT_PATH = System.Windows.Forms.Application.StartupPath;

        public enum Level3Frames
        {
            /// <summary>
            /// ��VS2005��
            /// </summary>
            VS2005,
            /// <summary>
            /// ��VS2008��
            /// </summary>
            VS2008
        }

        private string createFilePath;
        private bool hasCreateModel;
        private bool hasCreateIDAL;
        private bool hasCreateDAL;
        private bool hasCreatedDBLibrary;
        private bool hasCreateDALFactory;
        private bool hasCreateBLL;
        private bool hasCreateUserControl;
        private bool hasCreateICacheDependency;
        private bool hasCreateTableCacheDependency;
        private bool hasCreateCacheDependencyFactory;
        private Level3Frames level3Frame;

        /// <summary>
        /// ����������ͣ�VS2005 or VS2008��
        /// </summary>
        public Level3Frames Level3Frame
        {
            get { return level3Frame; }
            set { level3Frame = value; }
        }
        /// <summary>
        /// ���ɵ��ļ����õ�·��
        /// </summary>
        public string CreateFilePath
        {
            get { return createFilePath; }
            set { createFilePath = value; }
        }

        /// <summary>
        /// �Ƿ�����Model�����
        /// </summary>
        public bool HasCreateModel
        {
            get { return hasCreateModel; }
            set { hasCreateModel = value; }
        }

        /// <summary>
        /// �Ƿ�����IDAL�����
        /// </summary>
        public bool HasCreateIDAL
        {
            get { return hasCreateIDAL; }
            set { hasCreateIDAL = value; }
        }

        /// <summary>
        /// �Ƿ�����DAL�����
        /// </summary>
        public bool HasCreateDAL
        {
            get { return hasCreateDAL; }
            set { hasCreateDAL = value; }
        }

        /// <summary>
        /// �Ƿ�����DBULibrary�����
        /// </summary>
        public bool HasCreateDBULibrary
        {
            get { return hasCreatedDBLibrary; }
            set { hasCreatedDBLibrary = value; }
        }

        /// <summary>
        /// �Ƿ�����DALFactory�����
        /// </summary>
        public bool HasCreateDALFactory
        {
            get { return hasCreateDALFactory; }
            set { hasCreateDALFactory = value; }
        }

        /// <summary>
        /// �Ƿ�����BLL�����
        /// </summary>
        public bool HasCreateBL
        {
            get { return hasCreateBLL; }
            set { hasCreateBLL = value; }
        }

        /// <summary>
        /// �Ƿ������û��ؼ�����
        /// </summary>
        public bool HasCreateUserControl
        {
            get { return hasCreateUserControl; }
            set { hasCreateUserControl = value; }
        }

        /// <summary>
        /// �Ƿ�����ICacheDependency�����
        /// </summary>
        public bool HasCreateICacheDependency
        {
            get { return hasCreateICacheDependency; }
            set { hasCreateICacheDependency = value; }
        }

        /// <summary>
        /// �Ƿ�����TableCacheDependency�����
        /// </summary>
        public bool HasCreateTableCacheDependency
        {
            get { return hasCreateTableCacheDependency; }
            set { hasCreateTableCacheDependency = value; }
        }

        /// <summary>
        /// �Ƿ�����CacheDependencyFactory�����
        /// </summary>
        public bool HasCreateCacheDependencyFactory
        {
            get { return hasCreateCacheDependencyFactory; }
            set { hasCreateCacheDependencyFactory = value; }
        }
    }
}
