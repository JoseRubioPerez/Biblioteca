using System.Windows.Forms;
using CapaNegocio;

namespace CapaPre.Search
{
    public partial class Area : UserControl
    {
        #region Instancias

        private Negocio negocio = new Negocio();

        #endregion Instancias

        public Area()
        {
            InitializeComponent();
        }

        private void LlenarAreas(object sender, System.EventArgs e)
        {
            negocio.LlenarCombo(comboAreas, "CargarAreas", 1);
        }
    }
}