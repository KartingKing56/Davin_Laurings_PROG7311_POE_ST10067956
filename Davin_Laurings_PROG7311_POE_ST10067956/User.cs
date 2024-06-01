using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Davin_Laurings_PROG7311_POE_ST10067956
{
    /// <summary>
    /// Class is used to retrieve all the neccesary data for the user to log in and see 
    /// specific data related to them.
    /// </summary>
    
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Category { get; set; }
        public string Email { get; set; }

        
    }
}