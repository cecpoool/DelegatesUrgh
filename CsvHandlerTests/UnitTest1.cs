using System;
using System.Collections.Generic;
using NUnit.Framework;
using FileParserNetStandard;
using Delegate_Exercise;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        
        private FileHandler _fh;
        private DataParser _dp;
        private CsvHandler _ch;
        private string _csvPath = "/Users/cjmco/Downloads/delegates/data.csv";  // change to appropriate path
        private string _writeFile = "/Users/cjmco/Downloads/delegates/dataWrite.txt";  // change to appropriate path

        private List<List<string>> _data;

        [Test]
        public void ReadWriteFile()
        {
            var list = _fh.ReadFile(_csvPath);
            var parsCsv = _fh.ParseCsv(list);
           // var procCsv = _ch.ProcessCsv(_csvPath,_writeFile, );

        }

    }
}