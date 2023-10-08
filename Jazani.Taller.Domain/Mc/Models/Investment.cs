using Jazani.Taller.Domain.Ge.Models;
using Jazani.Taller.Domain.Soc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Domain.Mc.Models
{
    public class Investment
    {
        public int Id { get; set; }
        public decimal AmountInvested { get; set; }
        public string? Description { get; set; }
        public int MiningConcessionid { get; set; }

        public int? Investmentconceptid { get; set; }
        public int? Measureunitid { get; set; }
        public int? Periodtypeid { get; set; }

        public int InvestmentTypeid { get; set; }
        public int CurrencyTypeid { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
        public int HolderId { get; set; }
        public int DeclaredTypeid { get; set; }
        public bool State { get; set; }


        //llaves Foraneas
        public virtual Holder? Holder { get; set; }
        public virtual Investmentconcept? Investmentconcept { get; set; }
        public virtual Investmenttype? Investmenttype { get; set; }

        public virtual MeasureUnit? MeasureUnit { get; set; }
        public virtual MiningConcession? MiningConcession { get; set; }
        public virtual PeriodType? PeriodType { get; set; }

    }
}
