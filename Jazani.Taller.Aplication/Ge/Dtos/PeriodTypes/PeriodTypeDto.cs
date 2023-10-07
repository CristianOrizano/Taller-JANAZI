using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Ge.Dtos.PeriodTypes
{
    public class PeriodTypeDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public int Time { get; set; }

        public DateTimeOffset RegistrationDate { get; set; }

        public bool State { get; set; }
    }
}
