using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Domain.Mc.Models
{
    public class Auctionarea
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Code { get; set; }
        public bool State { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
    }
}
