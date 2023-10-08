using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Mc.Dtos.Investments
{
    public class InvestmentSaveDto
    {
        public decimal AmountInvested { get; set; }
        public string? Description { get; set; }
        public int MiningConcessionid { get; set; }

        public int? Investmentconceptid { get; set; }
        public int? Measureunitid { get; set; }
        public int? Periodtypeid { get; set; }

        public int InvestmentTypeid { get; set; }
        public int CurrencyTypeid { get; set; }
        public int Holderid { get; set; }
        public int DeclaredTypeid { get; set; }
    }
}
