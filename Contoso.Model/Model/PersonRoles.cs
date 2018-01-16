using Contoso.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model.Model
{
    public class PersonRoles : Entity

    {
        public People People { get; set; }
        public Roles Roles { get; set; }

    }
}
