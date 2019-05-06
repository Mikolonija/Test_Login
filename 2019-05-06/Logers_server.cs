using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Text;

namespace _2019_05_06
{
    public class Logers_server
    {
        string filePath = string.Format("logai {0}.log", DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss"));
        public void Init()
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose();
            }

        }
        public void WriteLog(string log)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true)) {
                writer.WriteLine(log);
                Console.WriteLine(log);

            };
        }

    


    }
}
