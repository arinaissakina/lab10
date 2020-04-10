using System;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace Gradebook.Controllers
{
    
        public class MainController : Controller
        {
            // GET
            public IActionResult Index()
            {
                return View();
            }
            
            [HttpPost]
            public IActionResult Index(string name, string surname, int day, int month, int year, int group)
            {
                StringBuilder id = new StringBuilder(" ");

                char[] n = name.ToUpper().ToCharArray();
                char[] sn = surname.ToUpper().ToCharArray();

                string y = year.ToString();
                char[] yr = y.ToCharArray();
                
                string g = group.ToString();
                char[] gr = g.ToCharArray();
                
                id.Append(n[0]);   
                id.Append(sn[0]);
                id.Append(day + month);
                id.Append(yr[2]);
                id.Append(gr[1]);
                id.Append(gr[2]);
                id.Append(gr[3]);
            
                string genId = id.ToString();

                ViewData["GenId"] = genId;
                return View();
                
                /*
                 My ID Generator is very very simple: 
                 first symbol is First letter of the name, 
                 second - first letter of the surname,
                 next - sum of day and moth of birth
                 then - last digit of year of birth
                 fifth, sixth, seventh and eight - last three digits of group number 
                */
                
            }    
            
            
        }
    
}