using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard.View
{
    public partial class MenuForm : BaseMetro
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            RegistroUsuariosForm f = new RegistroUsuariosForm();
            f.Show();
            Close();
        }
    }
}