using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bit2char2byte
{
    public partial class bit : UserControl
    {
        public bit()
        {
            InitializeComponent();
        }

        public int val = 0;

        public int getValoare ()
        {
            return val;
        }

        public void setValoare()
        {
            val = 1;
            
        }
        private void bit_Click(object sender, EventArgs e)
        {
            if (val == 0)
            {
                val = 1;

            }
            else
            {
                val = 0;
            }
            label1.Text = val.ToString();
        }

        private void bit_Load(object sender, EventArgs e)
        {

        }
    }
}
