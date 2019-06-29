using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace FileParserNetStandard {
    public class FileHandler {
       
        public FileHandler() { }

        public List<string> ReadFile(string filePath)
        {
            return File.ReadAllLines(filePath).ToList();
        }

        public void WriteFile(string filePath, char delimeter, List<List<string>> rows)
        {
            File.WriteAllLines(filePath, rows.Select(row => string.Join(delimeter.ToString(), row)));
        }

        public List<List<string>> ParseData(List<string> data, char delimeter)
        {
            return data.Select(row => row.Split(delimeter).ToList()).ToList();
        }
   
        public List<List<string>> ParseCsv(List<string> data)
        {
            return data.Select(row => row.Split(',').ToList()).ToList();
        }
    }
}