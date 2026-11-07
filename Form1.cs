using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace predicate_tuplas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTuplas_Click(object sender, EventArgs e)
        {
            int r, y;
            int[] x;
            int[] numeros = { 5, 333, 7, 9 };
            (r, x, y) = Suma(numeros, 6);
            MessageBox.Show($"R={r}, X={x}, Y={y}");
        }

        private (int, int[], int) Suma(int[] a, int b)
        {
            int res = 0;

            foreach (int numeracion in a)
            {
                res = res + numeracion;
            }
            return (res, a, b);

        }

        private void btnPredicate_Click(object sender, EventArgs e)
        {
            Predicate<int> esPar = x => x % 2 == 0;
            Predicate<int> esPositivo = x => x > 0;

            int miNumero = Convert.ToInt32(txtNumeros.Text);

            bool resultado1 = esPar(miNumero);
            MessageBox.Show(resultado1.ToString());

            List<int> denomicacion = new List<int>();
            denomicacion.Add(15);
            denomicacion.Add(22);
            denomicacion.Add(30);
            denomicacion.Add(11);
            denomicacion.Add(5);
            denomicacion.Add(60);
            denomicacion.Add(9);

           List<int> numerosPares =denomicacion.FindAll(esPar);

            numerosPares.ForEach(x=> MessageBox.Show(x.ToString()));

        }
        
    }
}
