using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRIME_IDE_v2
{
    class Class2
    {
        public string error;
        public int linea;
        
        public string Error
        {
            get
            {
                return this.error;
            }
            set
            {
                this.error = value;
            }
        }
        public int Linea
        {
            get
            {
                return this.linea;
            }
            set
            {
                this.linea = value;
            }
        }
    }
}
