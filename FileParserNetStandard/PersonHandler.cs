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
        Person newPerson;

        public PersonHandler(List<List<string>> people)
        {
            People = new List<Person>();
            for (int i = 1; i <= people.Count; i++)
            {
                people.Select(x =>
               {
                   x[i].Trim().Replace("#", "").Replace("\"", "");
                   if(x[0] != null) {
                   Person newPerson = new Person(int.Parse(x[0]), x[1], x[2], new DateTime(Convert.ToInt64(x[3])));
                   }
                   return newPerson;
               });
                   People.Add(newPerson);
            }
        }

        /// <summary>
        /// Gets oldest people
        /// </summary>
        /// <returns></returns>
        public List<Person> GetOldest() {
            
            return new List<Person>();
            var oldest = People.Select(p => new
            {
                p.Dob.Year,
                p.Dob.Month,
                FormattedDate = p.Dob.ToString("yyyy-MMM")
            })
            .Distinct()
            .OrderByDescending(p => p.Year)
            .ThenByDescending(p => p.Month)
            .Select(p => p.FormattedDate)
            .Take(5);
        }

        /// <summary>
        /// Gets string (from ToString) of Person from given Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetString(int id)
        {
            return People.Find(p => p.Id == id).ToString();
            
        }

        public List<Person> GetOrderBySurname() {
            return new List<Person>(People.OrderBy(p => p.Surname));
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