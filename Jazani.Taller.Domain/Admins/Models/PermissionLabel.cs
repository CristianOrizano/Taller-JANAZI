using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Domain.Admins.Models
{
    public class PermissionLabel
    {
        public int PermissionId { get; set; }
        public int LabelId { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
        public bool State { get; set; }

        public Permission Permission { get; set; } // Propiedad de navegación
        public Label Label { get; set; } // Propiedad de navegación

    }
}
