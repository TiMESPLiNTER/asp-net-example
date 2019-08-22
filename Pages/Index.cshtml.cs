using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
    public class IndexModel : PageModel
    {
        public long Weight { get; set; }

        public long Height { get; set; }

        public Bmi Bmi { get; set; } = new Bmi(){Height = 170, Weight = 80}; // Startdata

        public void OnGet()
        {

        }

        public void OnPost(long Height, long Weight)
        {
            this.Bmi.Height = this.Height = Height;
            this.Bmi.Weight = this.Weight = Weight;
        }
    }
}
