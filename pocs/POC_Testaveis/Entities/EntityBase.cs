using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public abstract class EntityBase
    {
        protected int id;

        public override bool Equals(object obj)
        {
            EntityBase other = (obj as EntityBase);

            if (other == null) return false;
            else if (System.Object.ReferenceEquals(this, other)) return true;
            else if (this.GetType().Name != other.GetType().Name) return false;
            else return (this.Id == other.Id);
        }

        public override int GetHashCode()
        {
            return ((short) id ^ ((short) id >> 16));
        }

        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
