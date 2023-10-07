using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jazani.Taller.Domain.Mc.Models;

namespace Jazani.Taller.Domain.Soc.Models
{
    public class Holder
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

        public virtual ICollection<Investment>? Investments { get; set; }
    }
}
