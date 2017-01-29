using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace DAL
{
    public class LogHandler
    {
        private DateTime date;
        private TimeSpan time;
        private System.IO.FileStream file;
        public static String getPath()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var newPath = Path.Combine(outPutDirectory, "..\\..\\Resources\\");
            string path = new Uri(newPath).LocalPath;
            return path;
        }
        public static String path = getPath();

        public void WriteLogs(String log)
        {
            
            String filename = getFileName();
            if (File.Exists(path + filename))
            {
                file = new FileStream(path + filename, FileMode.Append, FileAccess.Write);
            }
            else
            {
                file = new FileStream(path + filename, FileMode.Create, FileAccess.Write);
            }

            StreamWriter sWriter = new StreamWriter(file);
            time = DateTime.Now.TimeOfDay;
            String text = time.ToString() + ": " + log + "\n";
            sWriter.WriteLine(text);
            sWriter.Flush();
            file.Close();
        }
        public String ReadLogs(String filename)
        {
            if (!File.Exists(path + filename))
            {
                file = new FileStream(path + filename, FileMode.Create);
                FileStream f = new FileStream(path + "log_files.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sW = new StreamWriter(f);
                sW.WriteLine(filename.Remove(filename.Length-4));
                sW.Flush();
                f.Close();
            }
            else
            {
                file = new FileStream(path + filename, FileMode.Open, FileAccess.Read);
            }
            StreamReader sReader = new StreamReader(file, Encoding.UTF8, true);
            String line, text="";
            while ((line = sReader.ReadLine()) != null)
            {
                text += line + "\n";
            }
            file.Close();
            return text;
        }
        public String getFileName()
        {
            date = DateTime.Now;
            return (date.ToString("dd.MM.yyyy") + ".txt");
        }
    }

}

