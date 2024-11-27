using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaderProject.ViewModel
{
    public class HeaderViewModel
    {
        public string HeaderText { get; set; }

        public HeaderViewModel()
        {
            HeaderText = "Header Content from ViewModel";
        }
    }
}

