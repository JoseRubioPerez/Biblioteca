using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Session
    {
        public string NumControl { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstLastName { get; set; }
        public string SecondLastName { get; set; }
        public char Sex { get; set; }
        public string Password { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public char Permissions { get; set; }
    }

    public class ModifyUsers
    {
        public string NumControl { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstLastName { get; set; }
        public string SecondLastName { get; set; }
        public byte IndexDeparment { get; set; }
        public string Department { get; set; }
        public char Sex { get; set; }
        public char Status { get; set; }
    }
}