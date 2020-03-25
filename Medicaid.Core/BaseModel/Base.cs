using System;
using System.Collections.Generic;
using System.Text;

namespace Medicaid.Core.BaseModel
{
    public abstract class Base<T>
    {
        public T Id { get; set; }
        public int IsActive { get; set; } = 1;
        public int CreatedBy { get; set; } = 1;
        public int UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
