using System.Windows.Forms;
using BusinessLayer;

namespace Application.Search
{
    public partial class Area : UserControl
    {
        #region Instancias

        private Business ObjBusiness = new Business();

        #endregion Instancias

        public Area()
        {
            InitializeComponent();
        }

        private void LlenarAreas(object sender, System.EventArgs e)
        {
            ObjBusiness.LlenarCombo(comboAreas, "CargarAreas", 1);
        }
    }
}