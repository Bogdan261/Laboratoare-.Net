using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPhotosWeb.Pages.MyPhotos
{
    public class viewItemModel : PageModel
    {
        public string nume;
        public async Task OnGetAsync(string? nume)
        {
            if (nume != "") 
                this.nume = nume;
        }
    }
}