using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class Login : PageModel
{
    // Try to put BindProperty with everything 
    [BindProperty]
    public string Age { get; set; }
    [BindProperty]

    public string Email { get; set; }
    [BindProperty]

    public string Name { get; set; }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {   //Pass this attribute to the Index Model

        return RedirectToPage("Index", new { name = Name, age = Age });
    }
}