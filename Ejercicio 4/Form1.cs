using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        public void arreglos()
        {
            string[] nombre = new string[] { txt_nombre.Text };
            string[] edad = new string[] { txt_edad.Text };


            foreach (var item in nombre)
            {
                foreach (var itemE in edad)
                {

                    cb_datos.Items.Add(item + "  -  " + itemE);
                }
            }

        }


        private void btn_ingresar_Click(object sender, EventArgs e)
        {

            arreglos();
            txt_nombre.Clear();
            txt_edad.Clear();
        }

        private void btn_descendente_Click(object sender, EventArgs e)
        {


            //valores = valores.OrderByDescending(x => x).ToArray();
            //cb_datos.Text.OrderByDescending(nombre => nombre).ToArray();

        }





        private void btn_ascendente_Click(object sender, EventArgs e)
        {
            cb_datos.Sorted = true;
        }
    }
}
