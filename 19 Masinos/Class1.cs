using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Masinos
{
    class Class1
    {
        public string kintamasis;

        public int Pvz { get; private set; }

        // propg - property GET

        // pirmas enkapsuliacijos pavyzdys

        private string _jhbjh;

        public string ImtiJkdbg()
        {
            return _jhbjh;
        }

        public void DetiJdg(string shd)
        {
            _jhbjh = shd;
        }

        // antras enkapsuliacijos pavyzdys

        private string _hd;

        public string Hd
        {
            get { return _hd; }
            set { _hd = value; }
        }

        // propfull
    }
}
