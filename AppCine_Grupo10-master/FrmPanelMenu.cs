using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCine_Grupo10
{
    public partial class FrmPanelMenu : Form
    {
        public FrmPanelMenu()
        {
            InitializeComponent();
        }

        private void FrmPanelMenu_Load(object sender, EventArgs e)
        {
            // Test de datos
            DGMenuPanel3.Rows.Add(new object[] { "Jurasic World", 500, "01/01/2022", "Completo" });
            DGMenuPanel3.ClearSelection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
