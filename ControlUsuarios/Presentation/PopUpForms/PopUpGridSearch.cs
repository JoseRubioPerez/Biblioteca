using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Options;
using Entity;
using Business;

namespace Presentation.PopUpForms
{
    public partial class PopUpGridSearch : PopUpFather
    {
        public PopUpGridSearch()
        {
            InitializeComponent();
            ButtonCancel.Visible = false;
            ButtonAccept.Visible = false;
        }

        public PopUpGridSearch(TypeModules Module, Search ObjSearch, string ModuloText)
        {
            InitializeComponent();
            GridSearch.DataSource = ObjSearch.Table;
            LabelTotalResults.Text = ObjSearch.Table.Rows.Count.ToString();
            LabelComboSearch.Text = ModuloText;
            ButtonCancel.Visible = false;
            ButtonAccept.Visible = false;
        }
    }
}
