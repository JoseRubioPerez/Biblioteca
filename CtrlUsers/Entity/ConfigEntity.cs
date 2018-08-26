using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ConfigEntity
    {
        private bool PTypeImport;

        public bool TypeImport { get => this.PTypeImport; set => this.PTypeImport = value; }
    }
}
