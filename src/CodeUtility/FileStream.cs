using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace CodeUtility
{
    public class FileStream
    {
        public static void WriteFile(string path, string content)
        {
            StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
            sw.Write(content);
            sw.Close();
        }

        public static string ReadFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            string str = sr.ReadToEnd();
            sr.Close();
            return str;
        }

        /// <summary>
        /// 运行命令行
        /// </summary>
        public static void RunCommand(string cmd)
        {
            string tempPath = Environment.GetEnvironmentVariable("TEMP");
            string fileName = tempPath + "\\" + Guid.NewGuid().ToString("N") + ".bat";
            CodeUtility.FileStream.WriteFile(fileName, cmd.ToString());
            Process.Start(fileName);
        }
    }
}
