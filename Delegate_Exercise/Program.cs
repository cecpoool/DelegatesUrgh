using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using FileParserNetStandard;

public delegate List<List<string>> Parser(List<List<string>> data);

namespace Delegate_Exercise {
 
    
    internal class Delegate_Exercise {
        public static void Main(string[] args) {
            string openFilePath = "C:\\Users\\cjmco\\Downloads\\delegates\\data.csv";
            string writeFilePath = "C:\\Users\\cjmco\\Downloads\\delegates\\outPut.csv";

        var csvHan = new CsvHandler();

        csvHan.ProcessCsv(openFilePath, writeFilePath, (x) => x);

            Console.WriteLine("Completed Successfully ;)");
            Console.ReadLine();
        }

        
        
    }
}