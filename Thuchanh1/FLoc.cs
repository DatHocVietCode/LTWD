using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thuchanh1
{
    public partial class FLoc : Form
    {
        string option = string.Empty;
        public FLoc()
        {
            InitializeComponent();
   
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
       
        }
        public string Return_Option() 
        {
            if (rb1_8.Checked)
            {
                return "Option 1";
            }
            else if (rb2_8_5.Checked)
            {
                return "Option 2";

            }
            else if (rb_5.Checked)
            {
                return "Option 3";
               
            }
            else
            {
                return option;
            }
        }

        private void FLoc_Load(object sender, EventArgs e)
        {

        }
    }
}
