using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Geo.Dtos.Districts
{
    public class DistrictDto
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Capital { get; set; }
        public bool State { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }

    }
}
