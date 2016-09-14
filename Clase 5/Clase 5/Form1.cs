using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria;

namespace Clase_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Banco[] _bancos = new Banco[10];

            
            Banco a = new Banco("asd", 1, 239);
            Banco b = new Banco("afd", 1, 232);
            Banco c = new Banco("afssd", 5, 213);
            Banco d = new Banco("asved", 101, 123);
            Banco k = new Banco("asd554", 154, 423);
            Banco f = new Banco("asd1sd", 121, 243);
            Banco g = new Banco("asdczc", 12, 234);
            Banco h = new Banco("asvvfd", 10, 235);
            Banco i = new Banco("aswfwd", 12111, 523);
            Banco j = new Banco("aawwasd", 321, 253);

            _bancos.SetValue(a, 0);
            _bancos.SetValue(b, 1);
            _bancos.SetValue(c, 2);
            _bancos.SetValue(d, 3);
            _bancos.SetValue(f, 4);
            _bancos.SetValue(g, 5);
            _bancos.SetValue(h, 6);
            _bancos.SetValue(i, 7);
            _bancos.SetValue(j, 8);
            _bancos.SetValue(k, 9);

            Array.Sort(_bancos, Banco.ComparacionBancos);

            for (int z = 0; z < 10; z++)
			{
			  this.listBox1.Items.Add(_bancos[z]);
			}

            this.listBox1.SelectedItem = a;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }

        

        
    }
}
