using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataLayer;

namespace BusinessLayer
{
    public class HelloWorldBAL : IHelloWorldBAL
    {
        IHelloWorldDAL helloWorldDAL = null;
        public HelloWorldBAL()
        {
            helloWorldDAL = new HelloWorldDAL();
        }

        public HelloWorldBO GetMessage()
        {
            return helloWorldDAL.GetMessage();
        }
    }

}
