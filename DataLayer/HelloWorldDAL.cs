using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class HelloWorldDAL : IHelloWorldDAL
    {
        public HelloWorldBO GetMessage()
        {
            HelloWorldBO helloWorldBO = new HelloWorldBO()
            {
                Message = "Hello World.."
            };

            return helloWorldBO;
        }
    }
}
