using Jazani.Taller.Domain.Mc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Domain.Ge.Models
{
    public class PeriodType
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public int Time { get; set; }

        public DateTimeOffset RegistrationDate { get; set; }

        public bool State { get; set; }

        public virtual ICollection<Investment>? Investments { get; set; }
    }
}
