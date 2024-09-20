﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LimparTexto()
        {
            foreach (Control item in grpFormas.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBase.Enabled = true;
            txtAltura.Enabled = true;
            txtRaio.Enabled = true;
            switch (cmbForma.Text)
            {
                case "Quadrado":
                    ExibirRaio(false);
                    ExibirBase(true);
                    ExibirAltura(false);

                    cmbTriangulo.Visible = false;
                    break;

                case "Triângulo":
                    ExibirRaio(false);
                    ExibirBase(true);
                    ExibirAltura(true);

                    cmbTriangulo.Visible = true;
                    cmbTriangulo_TextUpdate(null, null);
                    break;

                case "Retângulo":
                    ExibirRaio(false);
                    ExibirBase(true);
                    ExibirAltura(true);

                    cmbTriangulo.Visible = false;
                    break;

                case "Circunferência":
                    ExibirRaio(true);
                    ExibirBase(false);
                    ExibirAltura(false);

                    cmbTriangulo.Visible = false;
                    break;

                default:
                    txtBase.Enabled = false;
                    txtAltura.Enabled = false;
                    txtRaio.Enabled = false;
                    cmbTriangulo.Visible = false;
                    break;
            }
        }

        private void cmbTriangulo_TextUpdate(object sender, EventArgs e)
        {
            txtBase.Enabled = true;
            txtAltura.Enabled = true;
            switch (cmbTriangulo.Text)
            {
                case "Equilátero":
                    ExibirAltura(false);
                    break;
                case "Isósceles":
                    ExibirAltura(true);
                    break;
                case "Reto":
                    ExibirAltura(true);
                    break;
                default:
                    txtBase.Enabled = false;
                    txtAltura.Enabled = false;
                    break;
            }
        }

        private void ExibirBase(bool visivel)
        {
            lblBase.Visible = txtBase.Visible = visivel;
        }
        private void ExibirAltura(bool visivel)
        {
            lblAltura.Visible = txtAltura.Visible = visivel;
        }
        private void ExibirRaio(bool visivel)
        {
            lblRaio.Visible = txtRaio.Visible = visivel;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbForma.Text.Equals("Quadrado"))
                {
                    FormaGeometrica quadrado = new Quadrado()
                    {
                        Lado = Convert.ToDouble(txtBase.Text)
                    };
                    cmbObjetos.Items.Add(quadrado);
                }
                else if (cmbForma.Text.Equals("Triângulo"))
                {
                    if (cmbTriangulo.Text.Equals("Equilátero"))
                    {
                        FormaGeometrica triangulo = new TrianguloEquilatero()
                        {
                            Lado = Convert.ToDouble(txtBase.Text)
                        };
                        cmbObjetos.Items.Add(triangulo);
                    }
                    else if (cmbTriangulo.Text.Equals("Isósceles"))
                    {
                        FormaGeometrica triangulo = new TrianguloIsosceles()
                        {
                            A = Convert.ToDouble(txtAltura.Text),
                            B = Convert.ToDouble(txtBase.Text)
                        };
                        cmbObjetos.Items.Add(triangulo);
                    }
                    else if (cmbTriangulo.Text.Equals("Reto"))
                    {
                        FormaGeometrica triangulo = new TrianguloRetangulo()
                        {
                            A = Convert.ToDouble(txtAltura.Text),
                            B = Convert.ToDouble(txtBase.Text)
                        };
                        cmbObjetos.Items.Add(triangulo);
                    }
                }
                else if (cmbForma.Text.Equals("Retângulo"))
                {
                    FormaGeometrica retangulo = new Retangulo()
                    {
                        A = Convert.ToDouble(txtAltura.Text),
                        B = Convert.ToDouble(txtBase.Text)
                    };
                    cmbObjetos.Items.Add(retangulo);
                }
                else if (cmbForma.Text.Equals("Circunferência"))
                {
                    FormaGeometrica circunferencia = new Circunferencia()
                    {
                        Raio = Convert.ToDouble(txtRaio.Text)
                    };
                    cmbObjetos.Items.Add(circunferencia);
                }

                lblNotificacao.Visible = true;
                LimparTexto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormaGeometrica obj = cmbObjetos.SelectedItem as FormaGeometrica;
            txtArea.Text = obj.CalcularArea().ToString();
            txtPerimetro.Text = obj.CalcularPerimetro().ToString();
        }

        private void cmbObjetos_DropDown(object sender, EventArgs e)
        {
            lblNotificacao.Visible = false;
        }

        private void cmbObjetos_TextUpdate(object sender, EventArgs e)
        {
            LimparTexto();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grpFormas_Enter(object sender, EventArgs e)
        {

        }

        private void txtRaio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRaio_Click(object sender, EventArgs e)
        {

        }

        private void lblAltura_Click(object sender, EventArgs e)
        {

        }

        private void lblBase_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
