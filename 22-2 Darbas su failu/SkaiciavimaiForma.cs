using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_2_Darbas_su_failu
{
    public partial class SkaiciavimaiForma : Form
    {
        public SkaiciavimaiForma(List<Darbuotojas> Darbuotojai)
        {
            InitializeComponent();
            textBox1.Text = Vidurkis(Darbuotojai).ToString();
        }
        public double Vidurkis(List<Darbuotojas> Darbuotojai)
        {
            double suma = 0;

            foreach (var darbuotojas in Darbuotojai)
            {
                suma += darbuotojas.Alga;
            }
            return suma/Darbuotojai.Count;
        }
    }
}
