using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Mc.Dtos.Investmentconcepts
{
    public class InvestmentconceptDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool State { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }

    }
}
