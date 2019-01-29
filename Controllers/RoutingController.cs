using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Text;



namespace Router.Controllers{
    public class Routes : Controller
    {
        // 
        // GET: /HelloWorld/
        public string Index()
        {
            
            return "123";
        }

        [Route("confirm")]
        [HttpPost]
        public IActionResult SendConfirmation(){

            return Ok("1234");
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