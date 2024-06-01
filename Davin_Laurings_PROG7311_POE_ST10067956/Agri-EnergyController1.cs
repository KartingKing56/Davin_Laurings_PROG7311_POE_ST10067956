using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Davin_Laurings_PROG7311_POE_ST10067956
{
    public class Agri_EnergyController1 : ApiController
    {
        private readonly DatabaseHandler _dbHandler;

        public Agri_EnergyController1()
        {
            // Initialize your DatabaseHandler here
            _dbHandler = new DatabaseHandler();
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody] User model)
        {
            // Call your CheckUserInfo method from DatabaseHandler
            _dbHandler.CheckUserInfo(model.Username, model.Password);

            if (_dbHandler.Status == "False")
            {
                return (IActionResult)BadRequest("Invalid credentials");
            }

            // Return user info or other relevant data
            return (IActionResult)Ok(_dbHandler.GetUserInfo(model.Username, model.Password));
        }
    }
}