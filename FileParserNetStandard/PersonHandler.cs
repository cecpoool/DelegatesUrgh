using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Delegate_Exercise;
using FileParserNetStandard;
using ObjectLibrary;


namespace FileParserNetStandard {

  
    public class PersonHandler {
        public List<Person> People;

        public PersonHandler(List<List<string>> people) {
            var _fh = new FileHandler();
            var _dp = new DataParser();
            var _ch = new CsvHandler();
            var data = _dp.NoHashtags(people);
            var data1 = _dp.StripQuotes(data);
            var dataFin = _dp.StripWhiteSpace(data1);
            var temp = dataFin.Select(row => row);


            temp.Select(p => new Person((int.Parse(p[0])), p[1], p[2], new DateTime(Convert.ToInt64(p[3]))));
            //temp.Select(p => int.TryParse(p[0],out res) == true ? continue : continue;

            //argh this isn't working but i felt like I was so close.
            //I tried to make a ternary for the first line in linq and had trouble.ss
        }

        /// <summary>
        /// Gets oldest people
        /// </summary>
        /// <returns></returns>
        public List<Person> GetOldest() {
            
            return new List<Person>(); //-- return result here
        }

        /// <summary>
        /// Gets string (from ToString) of Person from given Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetString(int id) {

            return "result";  //-- return result here
        }

        public List<Person> GetOrderBySurname() {
            return new List<Person>();  //-- return result here
        }

        /// <summary>
        /// Returns number of people with surname starting with a given string.  Allows case-sensitive and case-insensitive searches
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <param name="caseSensitive"></param>
        /// <returns></returns>
        public int GetNumSurnameBegins(string searchTerm, bool caseSensitive) {

            return 0;  //-- return result here
        }
        
        /// <summary>
        /// Returns a string with date and number of people with that date of birth.  Two values seperated by a tab.  Results ordered by date.
        /// </summary>
        /// <returns></returns>
        public List<string> GetAmountBornOnEachDate() {
            List<string> result = new List<string>();

            return result;  //-- return result here
        }
    }
}