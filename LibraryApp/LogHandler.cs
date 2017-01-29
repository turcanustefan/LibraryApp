using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL
{
    public class LogHandler
    {
        private DateTime date;
        private TimeSpan time;
        private System.IO.FileStream file;

        public void WriteLogs(String log)
        {
            String filename = getFileName();
            if (File.Exists(filename))
            {
                file = new FileStream(filename, FileMode.Append, FileAccess.Write);
            }
            else
            {
                file = new FileStream(filename, FileMode.Create, FileAccess.Write);
            }
            StreamWriter sWriter = new StreamWriter(file, Encoding.UTF8);
            time = DateTime.Now.TimeOfDay;
            sWriter.Write(time.ToString() + ":" + log + "\n");
            sWriter.Close();
            file.Close();
        }
        public StreamReader ReadLogs(String filename)
        {
            if (!File.Exists(filename))
            {
                return null;
            }

            file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sReader = new StreamReader(file, Encoding.UTF8, true);

            file.Close();
            return sReader;
        }
        public String getFileName()
        {
            date = DateTime.Now.Date;
            return (date.ToString() + ".txt");
        }
    }

}
