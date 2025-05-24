using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulaCSharp04
{
    public partial class telaLoding : Form
    {
        public telaLoding()
        {
            InitializeComponent();
        }

        private void telaLoding_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }
    }
}
