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
    public partial class Transparant : Form
    {
        public Transparant()
        {
            InitializeComponent();
            this.Opacity = 0.6;
            BackColor = Color.Black;
        }
    }
}
