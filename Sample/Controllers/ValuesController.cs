using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer;
using BusinessObjects;

namespace Sample.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public  string Get()
        {
            IHelloWorldBAL helloWorldBAL = new HelloWorldBAL();
            return helloWorldBAL.GetMessage().Message;
        }
 
    }
}
