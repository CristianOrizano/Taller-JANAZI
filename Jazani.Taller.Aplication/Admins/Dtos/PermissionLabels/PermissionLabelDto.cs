using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Taller.Aplication.Admins.Dtos.PermissionLabels
{
    public class PermissionLabelDto
    {
        public int PermissionId { get; set; }
        public int LabelId { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
        public bool State { get; set; }

    }
}
