using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RememberEachWord
{
    public partial class RoundNameDialog : Form
    {
        public string RoundName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public RoundNameDialog()
        {
            InitializeComponent();
        }
    }
}
