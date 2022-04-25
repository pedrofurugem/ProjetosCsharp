using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //1.Cri3	variáveis	com	as	idades	dos	seus	melhores	amigos	e/ou	familiares.	

        private void button1_Click(object sender, EventArgs e)
        {
            /*1.Crie 3 variáveis com as	idades dos seus	melhores amigos	e/ou familiares.	
            int idadeBia = 25;
            int idadePedro = 26;
            double media = (idadeBia + idadePedro) / 2;
            MessageBox.Show("A media de idade de ambos é " + media);*/

            /*2 e 3
            double pi = 3.14;
            int piQuebrado = (int)pi;

            MessageBox.Show("pi quebrado = " + piQuebrado);*/

            //4 - formula do tio babaka
            int a = 2;
            int b = 3;
            int c = 5;

            double delta = b * b - 4 * a * c;
            double a1 = (-b - delta) / (2 * a);
            double a2 = (-b + delta) / (2 * a);

            MessageBox.Show("a1 = " + a1 + " e a2 = " + a2);
        }
    }
}
