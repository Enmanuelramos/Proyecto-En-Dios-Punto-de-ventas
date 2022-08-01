using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Design_Dashboard_Modern.Utilitarios
{
    public partial class Fmr_Categoria : Form
    {
        public Fmr_Categoria()
        {
            InitializeComponent();
        }
        private void Fmr_Categoria_Load(object sender, EventArgs e)
        {
            Configurar_ListVew();
            Cargar_Todos_Las_Categoria();
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void Configurar_ListVew()
        {
            var listVewMarca = listView_Categoria;

            listVewMarca.Items.Clear();
            listVewMarca.Columns.Clear();
            listVewMarca.View = View.Details;
            listVewMarca.GridLines = false;
            listVewMarca.FullRowSelect = true;
            listVewMarca.Scrollable = true;
            listVewMarca.HideSelection = false;
            listVewMarca.Columns.Add("ID", 40, HorizontalAlignment.Left);//0
            listVewMarca.Columns.Add("Nombre de Categoria", 350, HorizontalAlignment.Left);//1

        }
        
       public void LLenar_ListVew(DataTable V)
        {
            listView_Categoria.Items.Clear();

            for (int i = 0; i<V.Rows.Count; i++)
            {
                DataRow Dr = V.Rows[i];
                ListViewItem Lista = new ListViewItem(Dr["Id_Cat"].ToString());
                Lista.SubItems.Add(Dr["Categoria"].ToString());
                listView_Categoria.Items.Add(Lista);
            }
            
        }
        public void Cargar_Todos_Las_Categoria()
        {
            DataTable dat = new DataTable();
            RN_Categoria ObjCat = new RN_Categoria();

            dat = ObjCat.RN_Mostrar_categoria();

            if (dat.Rows.Count > 0)
            {
                LLenar_ListVew(dat);
            }
            else
            {
                listView_Categoria.Items.Clear();
            }
        }
       
        private void bt_Agregar_Click(object sender, EventArgs e)
        {
            gru_det.Visible = true;
            textNombretCategortia.Focus();
            editar = false;
            textNombretCategortia.Text = "";
            textBoxIDCategoria.Text = "";
        }
        public bool editar = false;
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            textBoxIDCategoria.Text = "";
            textNombretCategortia.Text = "";
            gru_det.Visible = false;
        }

        private void bt_Editar_Click(object sender, EventArgs e)
        {
            if (listView_Categoria.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleccione ", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                var Lsv = listView_Categoria.SelectedItems[0];
                textBoxIDCategoria.Text = Lsv.SubItems[0].Text;
                textNombretCategortia.Text = Lsv.SubItems[1].Text;

                gru_det.Visible = true;
                textNombretCategortia.Focus();
                editar = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (listView_Categoria.SelectedIndices.Count == 0) //esto es para identificar si el usuario a seleccionado una fila
            {
                MessageBox.Show("Seleccione una Categoria", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                var Lsv = listView_Categoria.SelectedItems[0];
                textBoxIDCategoria.Text = Lsv.SubItems[0].Text;
                textNombretCategortia.Text = Lsv.SubItems[1].Text;

                this.Tag = "A";
                this.Close();

            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender,e);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RN_Categoria guardar = new RN_Categoria();

            if (textNombretCategortia.Text.Trim().Length < 0)
            {
                MessageBox.Show("Ingrese el nombre de la categoria", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (editar == false)
            {
                guardar.RN_Registrar_Categoria(textNombretCategortia.Text);
                gru_det.Visible = false;
                Cargar_Todos_Las_Categoria();
                textNombretCategortia.Text = "";
            }
            else
            {
                guardar.RN_Editar_Categoria(Convert.ToInt32(textBoxIDCategoria.Text), textNombretCategortia.Text);
                gru_det.Visible = false;
                Cargar_Todos_Las_Categoria();
                textNombretCategortia.Text = "";
                editar = false;
            }
        }

       
    }
}
