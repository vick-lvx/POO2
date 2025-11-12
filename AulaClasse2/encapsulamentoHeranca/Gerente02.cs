using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Gerente02 : Empregado
    {
        private string area;

        public virtual string Area
        {
            get
            {
                return area;

            }
            set
            {
                area = value;
            }
        }
    }
}
