using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace BSK_2_MD
{
    public partial class Main : MaterialForm
    {
        private SqlConnector sqlConnector = null;
        public Main(ref SqlConnector sqlConnector)
        {
            this.sqlConnector = sqlConnector;
            InitializeComponent();
        }
    }
}
