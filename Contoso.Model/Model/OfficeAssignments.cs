using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model.Model
{
    [Table("OfficeAssignments")]
    public class OfficeAssignments : Instructor
    {
        public String Location { get; set; }
        
    }
}
