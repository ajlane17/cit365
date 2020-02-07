using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class FileContext
    {
        private string @filePath = null;

        
        public FileContext(string @filePath)
        {
            this.filePath = filePath;
        }

        // If the file exists, returns a list of the contents, otherwise returns an empty collection
        public List<string> Read()
        {
            List<string> contents = null;

            try
            {
                if (File.Exists(filePath))
                {
                    contents = new List<string>();
                    using (var sr = new StreamReader(filePath))
                    {
                        while (sr.Peek() >= 0)
                            contents.Add(sr.ReadLine());
                    }
                }
                else
                {
                    contents = new List<string>();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return contents;
        }

        // Saves contents to a tmp file, replaces original save file after successful write
        public bool Save(List<string> contents)
        {
            string @tmpFile = filePath + ".tmp";

            try
            {
                if (File.Exists(tmpFile))
                    File.Delete(tmpFile);

                using (StreamWriter sw = File.CreateText(tmpFile))
                {
                    foreach (string line in contents)
                    {
                        sw.WriteLine(line);
                    }
                }

                if (File.Exists(filePath))
                    File.Delete(filePath);

                File.Copy(tmpFile, filePath);

                File.Delete(tmpFile);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
    }
}
