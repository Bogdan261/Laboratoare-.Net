using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceMyPhotos;

namespace MyPhotosWeb.Pages.MyPhotos
{
    public class indexModel : PageModel
    {
        InterfaceMyPhotosClient client = new InterfaceMyPhotosClient();
        public async Task OnGetAsynch()
        {
            var path = await client.getFilesPathAsync();
            foreach (var i in path)
            {

            }

        }
    }
}