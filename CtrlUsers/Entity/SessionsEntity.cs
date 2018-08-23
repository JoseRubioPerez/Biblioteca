using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class SessionsEntity
    {
        private string PUsername;
        private string PPassword;
        private char PSuperSu;

        public string Username { get => this.PUsername; set => this.PUsername = value; }
        public string Password { get => this.PPassword; set => this.PPassword = value; }
        public char SuperSu { get => this.PSuperSu; set => this.PSuperSu = value; }
    }
}
