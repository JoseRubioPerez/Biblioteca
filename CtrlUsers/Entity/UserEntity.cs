using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class UserEntity
    {
        private string PNumControl;
        private string PNombres;
        private string PApellidoPaterno;
        private string PApellidoMaterno;
        private char PSexo;
        private int PDepartamento;
        private char PStatus;
        private DateTime PHora;
        private DateTime PFecha;

        public string NumControl { get => this.PNumControl; set => this.PNumControl = value; }
        public string Nombres { get => this.PNombres; set => this.PNombres = value; }
        public string ApellidoPaterno { get => this.PApellidoPaterno; set => this.PApellidoPaterno = value; }
        public string ApellidoMaterno { get => this.PApellidoMaterno; set => this.PApellidoMaterno = value; }
        public char Sexo { get => this.PSexo; set => this.PSexo = value; }
        public int Departamento { get => this.PDepartamento; set => this.PDepartamento = value; }
        public char Status { get => this.PStatus; set => this.PStatus = value; }
        public DateTime Hora { get => this.PHora; set => this.PHora = value; }
        public DateTime Fecha { get => this.PFecha; set => this.PFecha = value; }
    }
}
