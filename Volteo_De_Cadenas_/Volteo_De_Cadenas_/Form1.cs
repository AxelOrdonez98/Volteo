﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Volteo_De_Cadenas_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Voltear_Click(object sender, EventArgs e)
        {
            if (txt_Cadena_A_Voltear.Text != "")
            {
                lb_Respuesta.Text = "";
                string str_test = txt_Cadena_A_Voltear.Text;
                string str_Acum = "";
                int i_total_de_separado = 0;
                ltsb_Respuesta.Items.Clear();
                List<string> L_mostrar = new List<string>();
                for (int i = 0; i < str_test.Length; ++i)
                {
                    str_Acum += str_test[i];
                    if (str_Acum.Contains(" ") || str_Acum.Contains(",") || str_Acum.Contains(".") || str_Acum.Contains("-") || str_Acum.Contains("_"))
                    {
                        L_mostrar.Add(str_Acum);
                        str_Acum = "";
                    }
                }
                i_total_de_separado = L_mostrar.Count;
                L_mostrar.Reverse();
                for (int i = 0; i < i_total_de_separado; i++)
                {
                    ltsb_Respuesta.Items.Add(L_mostrar[i]);
                }
            }
            else
            {
                MessageBox.Show("Verifique que campo de texto no este vacio", "ERROR");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            ltsb_Respuesta.Items.Clear();
            txt_Cadena_A_Voltear.Clear();
        }
    }
}
