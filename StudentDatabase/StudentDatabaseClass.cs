using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    public static class StudentDatabaseClass
    {
        //Student number validation
        public static bool IsValidStudent(int student, int nameArray)
        {
            if (student > 0 && student < nameArray + 1)
            {
                return true;
            }
            return false;
        }

        //Category validation
        public static bool IsValidCategory(string category)
        {
            if (category == "home" || category == "town" || category == "hometown" ||
                category == "food" || category == "favorite" || category == "favorite food")
            {
                return true;
            }
            return false;
        }

        //Answer Validation
        public static bool isValidAnswer(string answer)
        {
            if (answer == "y" || answer == "n")
            {
                return true;
            }
            return false;
        }
            
    }
}
