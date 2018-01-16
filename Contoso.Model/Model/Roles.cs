using Contoso.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model.Model
{
    public class Roles : AuditableEntity
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
        public ICollection<PersonRoles> PersonRoles { get; set; }

    }
}
