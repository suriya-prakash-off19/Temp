using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementWinforms
{
    public partial class TempForm : Form
    {
        public TempForm(UserControl userControl)
        {
            InitializeComponent();
            AddControls(userControl);
            
        }

        private void AddControls(UserControl userControl)
        {
            Cont.Controls.Clear();
            Cont.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Visible = true;
            userControl.Enabled = true;
        }

        private void CloseClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
