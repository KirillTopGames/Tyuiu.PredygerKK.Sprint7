using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.PredygerKK.Sprint7.Project.V6
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonAboutClose_PKK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonAboutClose_PKK_MouseLeave(object sender, EventArgs e)
        {
            buttonAboutClose_PKK.BackColor = Color.WhiteSmoke;
        }
        private void buttonAboutClose_PKK_MouseEnter(object sender, EventArgs e)
        {
            buttonAboutClose_PKK.BackColor = Color.Gainsboro;
        }
    }
}
