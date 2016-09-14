using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Banco
    {
        private int _sucursal;
        private string _direccion;
        private int _altura;

        public int Sucursal {
            get { return _sucursal; }
            set { _sucursal = value; }
        }

        public string Direccion { 
            get { return _direccion; }
            set { _direccion = value; }
        }

        public int Altura {
            get { return _altura; }
            set { _altura = value; }
        }

        public Banco(string d, int a, int s)
        {
            this.Altura = a;
            this.Direccion = d;
            this.Sucursal = s;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Sucursal: "+this._sucursal.ToString());
            sb.Append(" Direccion: " + this._direccion);
            sb.Append(" Altura: "+this._altura.ToString());
            

            return sb.ToString();

        }

        

       
        public static int ComparacionBancos(Banco a, Banco b)
        {

            if (a.Sucursal > b.Sucursal)
                return 1;
            else if (a.Sucursal == b.Sucursal)
                return 0;
            else 
                return -1;

            
        }


    }
}
