using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Net.Http;
using System.Net;
using System.Web;
using System.IO;
using System.Text;


namespace Router.Controllers{
    public class Routes : Controller
    {
        private Request_Response.Controllers.TaxubotResponses taxubot;
        
        // 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        public string Goodbye(){
            return "This is the Goodbye action method...";            
        }

        public void Log(){
            
        }
        
    }

}