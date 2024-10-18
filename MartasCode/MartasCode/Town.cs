using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MartasCode
{
    internal class Town
    {
        public int PostCode { get; set; }
        public string? Name { get; set; }
    }

    internal class House
    {
        public int HouseNumber { get; set; }
        public string Street { get; set; }
    }
}
