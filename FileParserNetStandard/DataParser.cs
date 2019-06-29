using System.Collections.Generic;
using System.Linq;

namespace FileParserNetStandard {
    public class DataParser {
        

        public List<List<string>> StripWhiteSpace(List<List<string>> data) {
            return data.Select(row => row.Select(col => col.Replace(" ", "")).ToList()).ToList();
        }

        public List<List<string>> StripQuotes(List<List<string>> data) {

            return data.Select(row => row.Select(col => col.Replace("\"", "")).ToList()).ToList();
        }

        public List<List<string>> NoHashtags(List<List<string>> data)
        {
            return data.Select(row => row.Select(col => col.Replace("#", "")).ToList()).ToList();

        }

    }
}