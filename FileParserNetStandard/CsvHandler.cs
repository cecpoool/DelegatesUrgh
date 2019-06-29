using System;
using System.Collections.Generic;
using System.Diagnostics;
using FileParserNetStandard;

namespace Delegate_Exercise {


    public class CsvHandler {

        /// <summary>
        /// Reads a csv file (readfile) and applies datahandling via dataHandler delegate and writes result as csv to writeFile.
        /// </summary>
        /// <param name="readFile"></param>
        /// <param name="writeFile"></param>
        /// <param name="dataHandler"></param>
        public void ProcessCsv(string readFile, string writeFile, Func<List<List<string>>, List<List<string>>> dataHandler) {
            var fileH = new FileHandler();
            var dataP = new DataParser();
            var newCsv = fileH.ReadFile(readFile);
            var processedCsv = fileH.ParseCsv(newCsv);
            dataHandler += dataP.StripQuotes;
            dataHandler += dataP.StripWhiteSpace;
            dataHandler += dataP.NoHashtags;

            var outputCsv = dataHandler(processedCsv);
            fileH.WriteFile(writeFile, ',', outputCsv);
            
        }

        public delegate List<List<string>> dataHandler(List<List<string>> data);

    }
}