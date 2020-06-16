﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double[,] Matriz = new double[5, 4];
            string valor = "";
            string Semana = "";
            double mes, Geral = 0;

            for (int lin = 0; lin < 5; lin++)
            {
                mes = 0;
                for (int col = 0; col < 4; col++)
                {
                    valor = Interaction.InputBox("Digite o Faturamento da semana " + (col + 1) +
                        " Mes: " + (lin + 1), "Digitação de dados");

                    if (double.TryParse(valor, out Matriz[lin, col]))
                    {
                        Semana = "Total do Mês: " + (lin + 1) + " Semana: " + (col + 1) + " R$ = " + Matriz[lin, col].ToString("N2");
                        mes += Matriz[lin, col];
                        Geral += Matriz[lin, col];
                        lstbxCalculos.Items.Add(Semana);
                    }
                    else
                    {
                        MessageBox.Show("Dado inválido!!!");
                        col--;
                    }
                }
                lstbxCalculos.Items.Add("Total Mês: " + (lin+1) + " R$ = " + mes.ToString("N2"));
                lstbxCalculos.Items.Add("-----------------------");
            }
            lstbxCalculos.Items.Add("Total Geral R$ = " + Geral.ToString("N2"));
        }
    }
}
