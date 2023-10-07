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
        public int MiningConcessionId { get; set; }

        public int? Investmentconceptid { get; set; }
        public int? Measureunitid { get; set; }
        public int? Periodtypeid { get; set; }

        public int InvestmentTypeId { get; set; }
        public int CurrencyTypeId { get; set; }
        public int HolderId { get; set; }
        public int DeclaredTypeId { get; set; }
    }
}
