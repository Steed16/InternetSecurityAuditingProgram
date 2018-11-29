using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlockWebsites
{
    public class Globalcs
    {
        public void BlockWebsites()
        {
            string originalPath = new Uri(HttpContext.Request.Path).OriginalString;
            MessageBox.Show(originalPath);
        }
    }
}
