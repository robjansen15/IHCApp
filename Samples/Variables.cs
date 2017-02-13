using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceApp.ErrorHandling;

namespace ServiceApp
{
    public class Variables
    {
        /*application variables*/


        /*public helper classes*/
        //This class is used for application error logging
        public Logging Log { get; set; }
        public ErrorHandler ErrHandler { get; set; }


        /*singleton handling*/
        private static Variables instance;


        private Variables()
        {
            /*initialze helper classes*/
            Log = new Logging();
            ErrHandler = new ErrorHandler();
        }

        public static Variables GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Variables();
                }
                return instance;
            }
        }
    }
}
