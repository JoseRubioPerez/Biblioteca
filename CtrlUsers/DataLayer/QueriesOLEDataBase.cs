using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Data;

namespace DataLayer
{
    public class QueriesOLEDataBase
    {
        private OleDbConnection conex;
        private DataTable Table = new DataTable();
        private string str = "";

        public QueriesOLEDataBase(string str)
        {
            this.str = str;
            conex = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + Path.GetDirectoryName(this.str) + "\";Extended Properties='text;HDR=yes;FMT=Delimited(,)';");
        }

        public DataTable ProcedimientoOLEDB()
        {
            //string[] values = File.ReadAllText(Path.GetDirectoryName(this.str)).Split(',');

            OleDbCommand cmd = new OleDbCommand(string.Format("SELECT * FROM [{0}]", new FileInfo(str).Name), conex);
            conex.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(Table);
            conex.Close();
            return Table;
        }
    }
}
