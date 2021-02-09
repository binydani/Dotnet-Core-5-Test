using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public abstract class BaseEntity
    {
        public virtual int  Id { get; protected set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime UpdatedBy { get; set; }
    }
}
