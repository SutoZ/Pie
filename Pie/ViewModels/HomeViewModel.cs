using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pie.Models;

namespace Pie.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<PieCake> Pies { get; set; }
    }
}
