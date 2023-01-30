using System;
using System.Collections.Generic;
using System.Data;
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

        //Student name validation
        public static string CheckName(string userStudent)
        {
            if (userStudent == "peter" || userStudent ==  "parker" || userStudent == "peter parker")
            {
                return  "1";
            }
            else if (userStudent == "bruce" || userStudent == "wayne" || userStudent == "bruce wayne")
            {
                return "2";
            }
            else if (userStudent == "ash" || userStudent == "williams" || userStudent == "ash williams")
            {
                return "3";
            }
            else if (userStudent == "laurie" || userStudent == "strode" || userStudent == "laurie strode")
            {
                return "4";
            }
            else if (userStudent == "sidney" || userStudent == "prescott" || userStudent == "sidney prescott")
            {
                return "5";
            }
            else if (userStudent == "snake" || userStudent == "plissken" || userStudent == "snake plissken")
            {
                return "6";
            }
            else if (userStudent == "alex" || userStudent == "murphy" || userStudent == "murphy")
            {
                return "7";
            }
            else if (userStudent == "Henry" || userStudent == "armitage" || userStudent == "henry armitage")
            {
                return "8";
            }
            else if (userStudent == "rick" || userStudent == "deckard" || userStudent == "rick deckard")
            {
                return "9";
            }
            else if (userStudent == "joeseph" || userStudent == "dredd" || userStudent == "joeseph dredd")
            {
                return "10";
            }
            else
            {
                return userStudent;
            }
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
