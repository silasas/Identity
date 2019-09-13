using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Windows.Forms;

namespace Identity
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        [Authorize(Roles = "Admin")]
        public void Auth()
        {

        }

        [Authorize(Roles = "Admin")]
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
