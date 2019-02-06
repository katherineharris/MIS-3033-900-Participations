using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1_Participation1
{
    class Information
    {
        public string Name { get; set; }
        public string Address { set; get; }
        public int ZipCode { set; get; }

        public Information()
        {
            Name = "";
            Address = "";
            ZipCode = 0;
        }
    }
}
