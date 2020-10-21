using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CL19037Guia6Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtNombre.Focus();
            //Mensajes de ayuda
            ttAyuda.SetToolTip(txtNombre, "Ingrese el nombre");
            ttAyuda.SetToolTip(txtApellido, "Ingrese el apellido");
            ttAyuda.SetToolTip(cbGenero, "Eliga un genero");
            ttAyuda.SetToolTip(nudEdad, "Eliga la edad del empleado");
            ttAyuda.SetToolTip(lblContador, "Cantidad de personas que se han ingresado");
            ttAyuda.SetToolTip(lblNombreMeG, "Nombre de la persona con menor salario");
            ttAyuda.SetToolTip(lblNombreMG, "Nombre de la persona con mayor salario");
            ttAyuda.SetToolTip(lblNombreMH, "Nombre de la persona con mayor salario, hombre");
            ttAyuda.SetToolTip(lblNombreMM, "Nombre de la persona con mayor salario, Mujer");
            ttAyuda.SetToolTip(lblSalarioMeGB, "Salario de la persona con menor salario mas un bono del 10%");
            ttAyuda.SetToolTip(lblSalarioMeG, "Salario");
            ttAyuda.SetToolTip(lblSalarioMG, "Salario");
            ttAyuda.SetToolTip(lblSalarioMH, "Salario");
            ttAyuda.SetToolTip(lblSalarioMM, "Salario");
            ttAyuda.SetToolTip(lblGeneroMeG, "Genero");
            ttAyuda.SetToolTip(lblGeneroMG, "Genero");
            ttAyuda.SetToolTip(lblGeneroMH, "Genero");
            ttAyuda.SetToolTip(lblGeneroMM, "Genero");
            ttAyuda.SetToolTip(lblEdadMeG, "Edad");
            ttAyuda.SetToolTip(lblEdadMG, "Edad");
            ttAyuda.SetToolTip(lblEdadMH, "Edad");
            ttAyuda.SetToolTip(lblEdadMM, "Edad");
        }
        //evento para agregar datos a la tabla
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int count = 0;

            int.TryParse(lblContador.Text, out count);
            count++;
            if (count > 0 && count < 11)
            {
                epError.Clear();
                if (txtApellido.Text != String.Empty && txtNombre.Text != string.Empty && txtSalario.Text != string.Empty && nudEdad.Value != 0 && cbGenero.Text != string.Empty)
                {
                    dgvEntrada.Rows.Add(txtNombre.Text + "", txtApellido.Text + "", nudEdad.Value + "", cbGenero.Text + "", txtSalario.Text + "");
                    lblContador.Text = count + "";
                    txtApellido.Clear();
                    txtNombre.Clear();
                    txtSalario.Clear();
                    nudEdad.Value = 0;
                    cbGenero.Text = null;
                    txtNombre.Focus();
                }
                else if (txtApellido.Text == String.Empty || txtNombre.Text == string.Empty || txtSalario.Text == string.Empty || nudEdad.Value == 0 || cbGenero.Text == string.Empty)
                {
                    MessageBox.Show("DEBE DE LLENAR TODOS LOS CAMPOS");
                    if (txtNombre.Text == string.Empty)
                    {
                        epError.SetError(txtNombre, "Este campo es obligatorio");
                    }
                    if (txtApellido.Text == string.Empty)
                    {
                        epError.SetError(txtApellido, "Este campo es obligatorio");
                    }
                    if (cbGenero.Text == string.Empty)
                    {
                        epError.SetError(cbGenero, "Este campo es obligatorio");
                    }
                    if (nudEdad.Value == 0)
                    {
                        epError.SetError(nudEdad, "Este campo es obligatorio");
                    }
                    if (txtSalario.Text == string.Empty)
                    {
                        epError.SetError(txtSalario, "Este campo es obligatorio");
                    }
                }
            }
            else if (count == 11)
            {
                MessageBox.Show("YA SE HAN INGRESADO TODOS LOS DATOS POSIBLES");
            }
        }
        //evento para limpiar todos los datos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //dgvEntrada.Rows.Clear();
            lblContador.Text = "10";
            lblEdadMeG.Text = "-";
            lblEdadMG.Text = "-";
            lblEdadMH.Text = "-";
            lblEdadMM.Text = "-";
            lblGeneroMeG.Text = "-";
            lblGeneroMG.Text = "-";
            lblGeneroMH.Text = "-";
            lblGeneroMM.Text = "-";
            lblNombreMeG.Text = "-";
            lblNombreMG.Text = "-";
            lblNombreMH.Text = "-";
            lblNombreMM.Text = "-";
            lblSalarioMeG.Text = "-";
            lblSalarioMeGB.Text = "-";
            lblSalarioMG.Text = "-";
            lblSalarioMH.Text = "-";
            lblSalarioMM.Text = "-";
        }
        //evento para hacer la evaluacion de los datos
        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            Empleados verificar = new Empleados();
            int i, j = 0, h = 0, k;
            if (lblContador.Text == "10")
            {
                for (i = 0; i < 10; i++)
                {
                    if (i == 0)
                    {
                        //Asignacion inicial de los datos
                        verificar.NewNombre = dgvEntrada.Rows[i].Cells[0].Value.ToString();
                        verificar.NewApellido = dgvEntrada.Rows[i].Cells[1].Value.ToString();
                        verificar.NewEdad = int.Parse(dgvEntrada.Rows[i].Cells[2].Value.ToString());
                        verificar.NewGenero = dgvEntrada.Rows[i].Cells[3].Value.ToString();
                        verificar.NewSalario = double.Parse(dgvEntrada.Rows[i].Cells[4].Value.ToString());
                        verificar.Contador = i;

                        //salario mayor general
                        lblNombreMG.Text = verificar.NameMaG().ToString();
                        lblEdadMG.Text = verificar.AgeMaG().ToString();
                        lblGeneroMG.Text = verificar.GenderMaG().ToString();
                        lblSalarioMG.Text = verificar.SalarioMaG().ToString();
                    }
                    else if (i != 0)
                    {
                        //Asignacion de datos para evaluacion                        
                        verificar.Nombre = lblNombreMG.Text;
                        verificar.Edad = int.Parse(lblEdadMG.Text);
                        verificar.Genero = lblGeneroMG.Text;
                        verificar.Salario = double.Parse(lblSalarioMG.Text);

                        verificar.NewNombre = dgvEntrada.Rows[i].Cells[0].Value.ToString();
                        verificar.NewApellido = dgvEntrada.Rows[i].Cells[1].Value.ToString();
                        verificar.NewEdad = int.Parse(dgvEntrada.Rows[i].Cells[2].Value.ToString());
                        verificar.NewGenero = dgvEntrada.Rows[i].Cells[3].Value.ToString();
                        verificar.NewSalario = double.Parse(dgvEntrada.Rows[i].Cells[4].Value.ToString());
                        verificar.Contador = i;

                        //salario mayor general
                        lblNombreMG.Text = verificar.NameMaG().ToString();
                        lblEdadMG.Text = verificar.AgeMaG().ToString();
                        lblGeneroMG.Text = verificar.GenderMaG().ToString();
                        lblSalarioMG.Text = verificar.SalarioMaG().ToString();
                    }

                    if (dgvEntrada.Rows[i].Cells[3].Value.ToString() == "Mujer")
                    {
                        if (j == 0)
                        {
                            //asignacion inicial de mayor salario entre mujeres
                            verificar.NewNombre = dgvEntrada.Rows[i].Cells[0].Value.ToString();
                            verificar.NewApellido = dgvEntrada.Rows[i].Cells[1].Value.ToString();
                            verificar.NewEdad = int.Parse(dgvEntrada.Rows[i].Cells[2].Value.ToString());
                            verificar.NewGenero = dgvEntrada.Rows[i].Cells[3].Value.ToString();
                            verificar.NewSalario = double.Parse(dgvEntrada.Rows[i].Cells[4].Value.ToString());
                            verificar.Contador = j;

                            lblNombreMM.Text = verificar.NameM().ToString();
                            lblEdadMM.Text = verificar.AgeM().ToString();
                            lblGeneroMM.Text = verificar.GenderM().ToString();
                            lblSalarioMM.Text = verificar.SalarioM().ToString();
                        }
                        else if (j != 0)
                        {
                            //avaluacion de mayor salario entre mujeres
                            verificar.Nombre = lblNombreMM.Text;
                            verificar.Edad = int.Parse(lblEdadMM.Text);
                            verificar.Genero = lblGeneroMM.Text;
                            verificar.Salario = double.Parse(lblSalarioMM.Text);

                            verificar.NewNombre = dgvEntrada.Rows[i].Cells[0].Value.ToString();
                            verificar.NewApellido = dgvEntrada.Rows[i].Cells[1].Value.ToString();
                            verificar.NewEdad = int.Parse(dgvEntrada.Rows[i].Cells[2].Value.ToString());
                            verificar.NewGenero = dgvEntrada.Rows[i].Cells[3].Value.ToString();
                            verificar.NewSalario = double.Parse(dgvEntrada.Rows[i].Cells[4].Value.ToString());
                            verificar.Contador = j;

                            lblNombreMM.Text = verificar.NameM().ToString();
                            lblEdadMM.Text = verificar.AgeM().ToString();
                            lblGeneroMM.Text = verificar.GenderM().ToString();
                            lblSalarioMM.Text = verificar.SalarioM().ToString();
                        }
                        j++;
                    }
                    if (dgvEntrada.Rows[i].Cells[3].Value.ToString() == "Hombre")
                    {
                        if (h == 0)
                        {
                            //asignacion de mayor salario entre hombres
                            verificar.NewNombre = dgvEntrada.Rows[i].Cells[0].Value.ToString();
                            verificar.NewApellido = dgvEntrada.Rows[i].Cells[1].Value.ToString();
                            verificar.NewEdad = int.Parse(dgvEntrada.Rows[i].Cells[2].Value.ToString());
                            verificar.NewGenero = dgvEntrada.Rows[i].Cells[3].Value.ToString();
                            verificar.NewSalario = double.Parse(dgvEntrada.Rows[i].Cells[4].Value.ToString());
                            verificar.Contador = h;

                            lblNombreMH.Text = verificar.NameH().ToString();
                            lblEdadMH.Text = verificar.AgeH().ToString();
                            lblGeneroMH.Text = verificar.GenderH().ToString();
                            lblSalarioMH.Text = verificar.SalarioH().ToString();
                        }
                        else if (h != 0)
                        {
                            //evaliacion de mayor salario entre hombres
                            verificar.Nombre = lblNombreMH.Text;
                            verificar.Edad = int.Parse(lblEdadMH.Text);
                            verificar.Genero = lblGeneroMH.Text;
                            verificar.Salario = double.Parse(lblSalarioMH.Text);

                            verificar.NewNombre = dgvEntrada.Rows[i].Cells[0].Value.ToString();
                            verificar.NewApellido = dgvEntrada.Rows[i].Cells[1].Value.ToString();
                            verificar.NewEdad = int.Parse(dgvEntrada.Rows[i].Cells[2].Value.ToString());
                            verificar.NewGenero = dgvEntrada.Rows[i].Cells[3].Value.ToString();
                            verificar.NewSalario = double.Parse(dgvEntrada.Rows[i].Cells[4].Value.ToString());
                            verificar.Contador = h;

                            lblNombreMH.Text = verificar.NameH().ToString();
                            lblEdadMH.Text = verificar.AgeH().ToString();
                            lblGeneroMH.Text = verificar.GenderH().ToString();
                            lblSalarioMH.Text = verificar.SalarioH().ToString();
                        }
                        h++;
                    }
                }
                for (k = 0; k < 10; k++)
                {
                    if (k == 0)
                    {
                        //Asignacion inicial de los datos
                        verificar.NewNombre = dgvEntrada.Rows[k].Cells[0].Value.ToString();
                        verificar.NewApellido = dgvEntrada.Rows[k].Cells[1].Value.ToString();
                        verificar.NewEdad = int.Parse(dgvEntrada.Rows[k].Cells[2].Value.ToString());
                        verificar.NewGenero = dgvEntrada.Rows[k].Cells[3].Value.ToString();
                        verificar.NewSalario = double.Parse(dgvEntrada.Rows[k].Cells[4].Value.ToString());
                        verificar.Contador = k;

                        //salario menor general
                        lblNombreMeG.Text = verificar.NameMeG().ToString();
                        lblEdadMeG.Text = verificar.AgeMeG().ToString();
                        lblGeneroMeG.Text = verificar.GenderMeG().ToString();
                        lblSalarioMeG.Text = verificar.SalarioMeG().ToString();
                    }
                    else if (k != 0)
                    {
                        //Asignacion de datos para evaluacion                        
                        verificar.Nombre = lblNombreMeG.Text;
                        verificar.Edad = int.Parse(lblEdadMeG.Text);
                        verificar.Genero = lblGeneroMeG.Text;
                        verificar.Salario = double.Parse(lblSalarioMeG.Text);

                        verificar.NewNombre = dgvEntrada.Rows[k].Cells[0].Value.ToString();
                        verificar.NewApellido = dgvEntrada.Rows[k].Cells[1].Value.ToString();
                        verificar.NewEdad = int.Parse(dgvEntrada.Rows[k].Cells[2].Value.ToString());
                        verificar.NewGenero = dgvEntrada.Rows[k].Cells[3].Value.ToString();
                        verificar.NewSalario = double.Parse(dgvEntrada.Rows[k].Cells[4].Value.ToString());
                        verificar.Contador = k;

                        //salario menor general
                        lblNombreMeG.Text = verificar.NameMeG().ToString();
                        lblEdadMeG.Text = verificar.AgeMeG().ToString();
                        lblGeneroMeG.Text = verificar.GenderMeG().ToString();
                        lblSalarioMeG.Text = verificar.SalarioMeG().ToString();
                        verificar.SalarioB = double.Parse(lblSalarioMeG.Text);
                        lblSalarioMeGB.Text = verificar.Bono().ToString();
                    }
                }
            }
            else 
                if(lblContador.Text != "10")
            {
                MessageBox.Show("No hay datos suficientes para poder operar");
            }
        }
        //evento para reducir la entrada de datos a solo numeros
        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                epError.SetError(txtSalario, ("ESTE CAMPO SOLO ADMITE NUMEROS: ENTEROS O DECIMALES"));
                e.Handled = true;
                return;
            }
            else
            {
                epError.Clear();
            }
        }
    }
}