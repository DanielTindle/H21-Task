using H21Task.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace H21Task.Pages
{
    public class IndexModel : PageModel
    {


        public void OnGet()
        {

        }

        public void OnPost()
        {
            string FullName = Request.Form["FullName"];
            string DateOfBirth = Request.Form["DateOfBirth"];
            string TelePhone = Request.Form["TelePhone"];
            string Email = Request.Form["Email"];
            Person person = new Person();
            person.SaveUser(FullName, DateOfBirth, TelePhone, Email);


        }
               

    }
}