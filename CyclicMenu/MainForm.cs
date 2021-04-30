using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyclicMenu
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void сменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassForm form = new ChangePassForm();
            form.ShowDialog();
        }

        private void продуктыПитанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsForm form = new ProductsForm();
            form.ShowDialog();
        }

        private void настройкаСоставаМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompoundMenuForm form = new CompoundMenuForm();
            form.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorizationForm form = new AuthorizationForm();
            form.Show();
        }
    }
}
