﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model.Common
{
    public interface IAuditableEntity
    {
        DateTime? CreatedDate { get; set; }
        String CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; } //nullable for ? Some table they do not need audit interface
        String UpdatedBy { get; set; }

    }
}
