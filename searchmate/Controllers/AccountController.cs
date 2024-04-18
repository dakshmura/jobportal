using Microsoft.AspNetCore.Mvc;


    public class AccountController : Controller
    {
    
        // GET: /Account/Register
        public ActionResult Register()
        {
            return View();
        }
        
       // POST: /Account/Register
        [HttpPost]
        public ActionResult Register(string firstname, string lastname, string password, 
        string address, string city,string email)
        {
            // Here you can add code to register the user in your database
            // For simplicity, I'm just printing the username and password
            Console.WriteLine("Registered User:");
            //Console.WriteLine("Username: " + username);
            Console.WriteLine("LastName: " + lastname);
            Console.WriteLine("FirstName: " + firstname);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Password: " + password);
            
            return RedirectToAction("Register", "Views"); // Redirect to homepage after registration
        }

        // GET: /Account/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public ActionResult Login(string loginUsername, string loginPassword)
        {
            // Here you can add code to authenticate the user
            // For simplicity, I'm just printing the username and password
            Console.WriteLine("Logged In User:");
            Console.WriteLine("Username: " + loginUsername);
            Console.WriteLine("Password: " + loginPassword);
            
            // Assuming authentication is successful, redirect to job search page
            return RedirectToAction("JobSearch", "Jobs");
        }
    }

