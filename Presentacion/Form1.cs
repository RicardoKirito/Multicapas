using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;


namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listar();
        }
        E_contacto objE = new E_contacto();
        N_contactos objN = new N_contactos();

        void Listar()
        {
            DataTable dt = objN.N_listado();
            datag.DataSource = dt;
        }
        void Buscar()
        {
            DataTable dt = objN.N_buscar(barra.Text);
            datag.DataSource = dt;
        }

        private void busca_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Limpiar()
        {
            nombrer.Text = "";
            apellidor.Text = "";
            direccionr.Text = "";
            generor.SelectedItem = "";
            estador.SelectedItem = "";
            telr.Text = "";
            correor.Text = "";
            fecharr.Value = DateTime.Today;
            advn.Text =  "";
            adva.Text ="";
            advt.Text = "";
            advt.Text ="";
            advf.Text =  "";

        }
        private void agregar_Click(object sender, EventArgs e)
        {
            if(nombrer.Text != "" && apellidor.Text != ""  && telr.Text != "" && telr.Text.Length == 12 && fecharr.Value.Year <= DateTime.Today.Year-5)
            {
                objN.N_insertar(nombrer.Text, apellidor.Text, direccionr.Text, generor.Text, estador.Text, telr.Text, correor.Text, fecharr.Text);

                //limpiamos
                Limpiar();
                MessageBox.Show("Agregado Exitosamente");
                Listar();


            }
            else
            {
                advn.Text = (nombrer.Text == "") ? "Es necesario" : "";
                adva.Text = (apellidor.Text == "") ? "Es necesario" : "";
                advt.Text = (telr.Text == "") ? "Es necesario" : "";
                advt.Text = (telr.Text.Length!=12)?"Formato : 555-555-5555":"";
                advf.Text = (fecharr.Value.Year >= DateTime.Today.Year - 5) ? "Debe ser mayor de 5 años" : "";
            }
            
        }

        int cell;
        private void datag_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                cecreto.Text = (string)datag.Rows[n].Cells[5].Value;
                Editar.Visible = true;
                Eliminar.Visible = true;
                cell = n;
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            Editar.Visible = false;
            Eliminar.Visible = false;
            datag.Enabled = false;
            agregar.Visible = false;
            guardar.Visible = true;
            cancelar.Visible = true;

            nombrer.Text = (string)datag.Rows[cell].Cells[0].Value;
            apellidor.Text = (string)datag.Rows[cell].Cells[1].Value;
            direccionr.Text = datag.Rows[cell].Cells[2].Value.ToString();
            generor.SelectedItem = datag.Rows[cell].Cells[3].Value.ToString();
            estador.SelectedItem = datag.Rows[cell].Cells[4].Value.ToString();
            telr.Text = datag.Rows[cell].Cells[5].Value.ToString();
            correor.Text = datag.Rows[cell].Cells[6].Value.ToString();
            fecharr.Text = datag.Rows[cell].Cells[7].Value.ToString();

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            datag.Enabled = true;
            agregar.Visible = true;
            guardar.Visible = false;
            cancelar.Visible = false;
            Limpiar();
        }
        private void modificar()
        {
            if (nombrer.Text != "" && apellidor.Text != "" && telr.Text != "" && telr.Text.Length == 12 && fecharr.Value.Year <= DateTime.Today.Year - 5)
            {
                if (cecreto.Text != telr.Text)
                {
                    if (objN.N_validar(telr.Text))
                    {
                        objN.N_modificar(nombrer.Text, apellidor.Text, direccionr.Text, generor.Text, estador.Text, telr.Text, correor.Text, fecharr.Text, cecreto.Text);
                        Limpiar();
                        MessageBox.Show("Agregado Exitosamente");
                        Listar();
                        guardar.Visible = false;
                        agregar.Visible = true;
                        cancelar.Visible = false;
                        datag.Enabled = true;
                    }
                    else
                    {
                        advt.Text = "Este numero Existe";
                    }
                }
                else
                {
                    objN.N_modificar(nombrer.Text, apellidor.Text, direccionr.Text, generor.Text, estador.Text, telr.Text, correor.Text, fecharr.Text, cecreto.Text);
                    Limpiar();
                    MessageBox.Show("Agregado Exitosamente");
                    Listar();
                    guardar.Visible = false;
                    agregar.Visible = true;
                    cancelar.Visible = false;
                    datag.Enabled = true;
                }
            }
            else
            {
                advn.Text = (nombrer.Text == "") ? "Es necesario" : "";
                adva.Text = (apellidor.Text == "") ? "Es necesario" : "";
                advt.Text = (telr.Text == "") ? "Es necesario" : "";
                advt.Text = (telr.Text.Length != 12) ? "Formato : 555-555-5555" : "";
                advf.Text = (fecharr.Value.Year >= DateTime.Today.Year - 5) ? "Debe ser mayor de 5 años" : "";
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
           DialogResult r =  MessageBox.Show("Quiere eliminar este registro?", "Eliminar", MessageBoxButtons.YesNoCancel);
            if(r == DialogResult.Yes)
            {
                objN.N_eliminar(cecreto.Text);
                Editar.Visible = false;
                Eliminar.Visible = false;
                Listar();
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            modificar();
        }
    }
}
