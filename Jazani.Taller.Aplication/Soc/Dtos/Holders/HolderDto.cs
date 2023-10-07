using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Soc.Dtos.Holders
{
    public class HolderDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Lastname { get; set; }
        public string? MaidenName { get; set; }
        public string? documentnumber { get; set; }
        public string? landline { get; set; }
        public string? mobile { get; set; }
        public string? corporatemail { get; set; }
        public string? personalmail { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
        public bool State { get; set; }

    }
}
