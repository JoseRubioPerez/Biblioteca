using System;
using System.Collections.Generic;
using System.Data;

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

    public class Search
    {
        public string FirstLastName { get; set; }
        public string SecondLastName { get; set; }
        public int IndexDeparmentStart { get; set; }
        public int IndexDeparmentEnd { get; set; }
        public char SexStart { get; set; }
        public char SexEnd { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public DataTable Table { get; set; }
        public List<byte> Services = new List<byte>();
    }
}