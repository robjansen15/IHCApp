using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataHandler.Database;

namespace DataHandler.Models
{
    public class Token
    {
        public Token()
        {
            _Token = null;
            _Username = null;
        }

        /// <summary>
        /// generate a tokenfor the user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private void tokenGenerator(string username)
        {
            _Token = tokenExists();

            if(_Token.Contains("null") == true)
            {
                //generate token
                _Token = "new generated token";

                //save token
                tokenSave();
            }    
        }


        /// <summary>
        /// checks to see if the token already exists in the database (must meet time requirements)
        /// </summary>
        /// <returns></returns>
        public string tokenExists()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            return databaseConnection._TokenStrategy.GetExistingToken(_Username);         
        }


        /// <summary>
        /// saves the token that was generated
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private void tokenSave()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection._TokenStrategy.SaveToken(this);
        }


        //return the created token
        public Token GenerateToken(string username)
        {
            //set the username
            _Username = username;

            tokenGenerator(username);     
            return this;
        }


        public string _Token { get; private set; }
        public string _Username { get; private set; }
    }
}