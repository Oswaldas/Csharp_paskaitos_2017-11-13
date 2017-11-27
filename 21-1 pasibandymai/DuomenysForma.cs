using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_1_pasibandymai
{
    public partial class DuomenysForma : Form
    {
        public DuomenysForma()
        {
            InitializeComponent();
        }
        public DuomenysForma(string vardas, int amzius)
        {

            InitializeComponent();
            textBox1.Text = vardas;
            textBox2.Text = amzius.ToString();
        }

    }
}
