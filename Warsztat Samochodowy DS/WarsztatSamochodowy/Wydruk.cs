using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarsztatSamochodowy
{
    public partial class Wydruk : Form
    {
        public Wydruk()
        {
            InitializeComponent();
        }

        private void Wydruk_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
