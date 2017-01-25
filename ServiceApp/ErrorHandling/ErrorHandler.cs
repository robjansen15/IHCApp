using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.ErrorHandling
{
    public class ErrorHandler
    {
        public ErrorHandler()
        {
            State = true;
        }


        public void HandleState()
        {

        }


        //State of the application
        public bool State { get; set; }
    }
}
