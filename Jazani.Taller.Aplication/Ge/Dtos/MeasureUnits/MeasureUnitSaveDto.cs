﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Ge.Dtos.MeasureUnits
{
    public class MeasureUnitSaveDto
    {
        public int? MeasureUnitId { get; set; }

        public string? Name { get; set; }

        public string? Symbol { get; set; }

        public string? Description { get; set; }

        public string? FormulaConversion { get; set; }
    }
}
