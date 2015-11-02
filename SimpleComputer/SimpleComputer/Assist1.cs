using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleComputer;

namespace SimpleComputer
{
    //ASSIST FORM
    public partial class Assist1 : Form
    {
        public Assist1()
        {
            InitializeComponent();
        }

        private int _HI;

        /// <summary>
        /// Update~
        /// </summary>
        public int MyProperty
        {
            get { return _HI; }
            set { _HI = value; }
        }
        

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
