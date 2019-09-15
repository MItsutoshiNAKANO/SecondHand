using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondHand
{
    public partial class SecondHandForm : Form
    {
        public SecondHandForm()
        {
            InitializeComponent();
        }

        private void IntervalTimer_Tick(object sender, EventArgs e)
        {
            ViewTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd ddd HH:mm:ss");
        }
    }
}
