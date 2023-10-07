using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Domain.Mc.Models
{
    public class MiningConcession
    {
        public int Id { get; set; }

        public string? Code { get; set; }

        public string? Name { get; set; }

        public int MineralTypeId { get; set; }

        public int OriginId { get; set; }

        public int TypeId { get; set; }

        public int SituationId { get; set; }

        public int MiningUnitId { get; set; }

        public int ConditionId { get; set; }

        public int StateManagementId { get; set; }
        public bool State { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }

        public virtual ICollection<Investment>? Investments { get; set; }
    }
}
