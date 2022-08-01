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
using Capa_Entidad;


namespace Design_Dashboard_Modern.Utilitarios
{
    public partial class Fmr_Marca : Form
    {
        public Fmr_Marca()
        {
            InitializeComponent();
        }
        private void Fmr_Categoria_Load(object sender, EventArgs e)
        {
            Configurar_ListVew();
            Cargar_Todos_Las_Marcas();
        }
        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {
         
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void Configurar_ListVew()
        {
            var listVewMarca = listView_Marca;

            listVewMarca.Items.Clear();
            listVewMarca.Columns.Clear();
            listVewMarca.View = View.Details;
            listVewMarca.GridLines = false;
            listVewMarca.FullRowSelect = true;
            listVewMarca.Scrollable = true;
            listVewMarca.HideSelection = false;
            listVewMarca.Columns.Add("ID", 40, HorizontalAlignment.Left);//0
            listVewMarca.Columns.Add("Nombre de la Marca", 350, HorizontalAlignment.Left);//1

        }
        
       public void LLenar_ListVew(DataTable V)
        {
            listView_Marca.Items.Clear();

            for (int i = 0; i<V.Rows.Count; i++)
            {
                DataRow Dr = V.Rows[i];
                ListViewItem Lista = new ListViewItem(Dr["Id_Marca"].ToString());
                Lista.SubItems.Add(Dr["Marca"].ToString());
                listView_Marca.Items.Add(Lista);
            }
            
        }
        public void Cargar_Todos_Las_Marcas()
        {
            DataTable dat = new DataTable();
            RN_Marca Mostrar = new RN_Marca();

            dat = Mostrar.RN_Mostrar_Marca();

            if (dat.Rows.Count > 0)
            {
                LLenar_ListVew(dat);
            }
            else
            {
                listView_Marca.Items.Clear();
            }
        }
       
        private void bt_Agregar_Click(object sender, EventArgs e)
        {
            gru_det.Visible = true;
            textMarca.Focus();
            editar = false;
            textMarca.Text = "";
            textBoxIDMarca.Text = "";
        }
        public bool editar = false;
        private void bt_Editar_Click(object sender, EventArgs e)
        {
            if (listView_Marca.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleccione ", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var Lsv = listView_Marca.SelectedItems[0];
                textBoxIDMarca.Text = Lsv.SubItems[0].Text;
                textMarca.Text = Lsv.SubItems[1].Text;

                gru_det.Visible = true;
                textMarca.Focus();
                editar = true;
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
           if (listView_Marca.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleccione ", "Marca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var Lsv = listView_Marca.SelectedItems[0];
                textBoxIDMarca.Text = Lsv.SubItems[0].Text;
                RN_Marca Eliminar_Marca = new RN_Marca();
                Eliminar_Marca.RN_Eliminar_Marca(Convert.ToInt32(textBoxIDMarca.Text));
                Cargar_Todos_Las_Marcas();
            }
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            if (listView_Marca.SelectedIndices.Count == 0) // estoy diciendo que si el indice es cero no se ha selecionado ninguno en el listvew
            {
                MessageBox.Show("Seleccione una categoria", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                var List = listView_Marca.SelectedItems[0];
                textBoxIDMarca.Text = List.SubItems[0].Text; // del lisvew estoy obteniendo los elementos para pasarlo a las caja de texto
                textMarca.Text = List.SubItems[1].Text;// del lisvew estoy obteniendo los elementos para pasarlo a las caja de texto

                this.Tag = "A";
                this.Close();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RN_Marca Obj = new RN_Marca();

            if (textMarca.Text.Trim().Length < 0)
            {
                MessageBox.Show("Ingrese el nombre de la Marca", "Marca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (editar == false)
            {
                Obj.RN_Insertar_Marca(textMarca.Text);
                gru_det.Visible = false;
                Cargar_Todos_Las_Marcas();
                textMarca.Text = "";
            }
            else
            {
                Obj.RN_Editar_Marca(Convert.ToInt32(textBoxIDMarca.Text), textMarca.Text);
                gru_det.Visible = false;
                Cargar_Todos_Las_Marcas();
                textMarca.Text = "";
                editar = false;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            textBoxIDMarca.Text = "";
            textMarca.Text = "";
            gru_det.Visible = false;
        }
    }
}
