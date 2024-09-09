using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementWinforms.MemberUserControls
{
    public partial class Home : UserControl
    {
        private static Home home;
        private static int index = -1;
        public Home(int id)
        {
            InitializeComponent();
            index = id;
        }

        public static Home GetInstance(int id)
        {
            if (home == null || id != index)
            {
                if (home != null)
                    home.Dispose();
                home = new Home(id);
            }
            return home;
        }
    }
}
