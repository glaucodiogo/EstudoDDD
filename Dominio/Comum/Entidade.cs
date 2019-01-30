using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Comum
{
    public abstract class Entidade
    {
        public virtual long Id { get; protected set; }

        public override bool Equals(object obj)
        {
            if (obj == null || (!obj.GetType().Equals(this.GetType())))
                return false;

            if (this == obj)
                return true;

            return (this.Id == ((Entidade)obj).Id);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}#{1}", this.Id.ToString(), this.GetType());
        }
    }
}
