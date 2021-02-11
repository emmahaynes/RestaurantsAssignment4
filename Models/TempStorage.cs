using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Emma Haynes 2-10-21

namespace RestaurantsAssignment4.Models
{
    public class TempStorage
    {
        //Puts form responses in the tempstorage class/model
        private static List<Suggestions> formResponses = new List<Suggestions>();

        public static IEnumerable<Suggestions> FormResponses => formResponses;

        public static void AddApplication(Suggestions formResponse)
        {
            formResponses.Add(formResponse);
        }
    }
}
