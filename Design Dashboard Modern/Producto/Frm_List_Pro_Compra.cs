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
using Design_Dashboard_Modern.Utilitarios;

namespace Design_Dashboard_Modern.Producto
{
    public partial class Frm_List_Pro_Compra : Form
    {
        public Frm_List_Pro_Compra()
        {
            InitializeComponent();
        }

        private void Frm_List_Pro_Compra_Load(object sender, EventArgs e)
        {
            Configurar_ListVew();
            Cargar_Los_Productos();
            txt_buscar_Producto.Focus();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Tag = "";
        }

        private void btn_minimi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario obj = new Utilitario();

            if (e.Button ==MouseButtons.Left)
            {
                obj.Mover_formulario(this);

            }
        }
        private void Configurar_ListVew()
        {
            var listVewMarca = listViewProducto;
            
            listVewMarca.Items.Clear();
            listVewMarca.Columns.Clear();
            listVewMarca.View = View.Details;
            listVewMarca.GridLines = false;
            listVewMarca.FullRowSelect = true;
            listVewMarca.Scrollable = true;
            listVewMarca.HideSelection = false;
            listVewMarca.Columns.Add("ID", 120, HorizontalAlignment.Center);//0
            listVewMarca.Columns.Add("Nombre del Producto", 244, HorizontalAlignment.Center);//1
            listVewMarca.Columns.Add("Stock", 100, HorizontalAlignment.Center);//2
            listVewMarca.Columns.Add("Pre Compra", 130, HorizontalAlignment.Center);//3
            listVewMarca.Columns.Add("Marca", 130, HorizontalAlignment.Center);//5
            listVewMarca.Columns.Add("Estado", 130, HorizontalAlignment.Center);//5
            listVewMarca.Columns.Add("TipoProducto", 0, HorizontalAlignment.Center);

        }
        private void LLenar_ListVew(DataTable V)
        {
            listViewProducto.Items.Clear();

            for (int i = 0; i < V.Rows.Count; i++)
            {
                DataRow Dr = V.Rows[i];
                ListViewItem Lista = new ListViewItem(Dr["Id_Pro"].ToString());
                Lista.SubItems.Add(Dr["Descripcion_Larga"].ToString());
                Lista.SubItems.Add(Dr["Stock_Actual"].ToString());
                Lista.SubItems.Add(Dr["Pre_CompraS"].ToString());
                Lista.SubItems.Add(Dr["Marca"].ToString());
                Lista.SubItems.Add(Dr["Estado_Pro"].ToString());
                Lista.SubItems.Add(Dr["TipoProdcto"].ToString());
                listViewProducto.Items.Add(Lista);
            }
            Colores_Filas();
            //PanelResult.Visible = false;
        }
        private void Colores_Filas()
        {
            int Count = 0;
            for (int i= 0; i < listViewProducto.Items.Count; i++ )
            {
                if (Count % 2 == 1)
                {
                    listViewProducto.Items[i].BackColor = Color.WhiteSmoke;
                }
                Count++;
            }
        }
        public void Cargar_Los_Productos()
        {
            RN_Producto Pro = new RN_Producto();
            DataTable CargarProductos = new DataTable();

            CargarProductos = Pro.RN_Mostrar_Productos();

            if (CargarProductos.Rows.Count > 0)
            {
                LLenar_ListVew(CargarProductos);
            }
            else
            {
                listViewProducto.Items.Clear();
                PanelResult.Visible = true;
            }
        }
        public void Buscar_Los_Productos(string V)
        {
            RN_Producto Pro = new RN_Producto();
            DataTable BuscarProductos = new DataTable();

            BuscarProductos = Pro.RN_Buscar_Productos(V);

            if (BuscarProductos.Rows.Count > 0)
            {
                LLenar_ListVew(BuscarProductos);
            }
            else
            {
                listViewProducto.Items.Clear();
                PanelResult.Visible = true;
            }
        }
        private void txt_buscar_Producto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PanelResult.Visible = false;
                Cargar_Los_Productos();
            }
        }
        private void txt_buscar_Producto_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_buscar_Producto.Text.Trim().Length > 0)
            {
                Buscar_Los_Productos(txt_buscar_Producto.Text);
            }
            else
            {
                if (String.IsNullOrEmpty(txt_buscar_Producto.Text))
                {
                    PanelResult.Visible = false;
                    Cargar_Los_Productos();
                } 
            }
           
        }

        private void copiarIDProveedor_Click(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();
           

            if (listViewProducto.SelectedIndices.Count == 0) //esto quiere decir que el usuario no ha seleccionado nada en la tabla
            {
                filtro.Show();
     
                MessageBox.Show("Seleccione el item que seas Copiar","Productos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                filtro.Hide();
            }
            else
            {
                var lis = listViewProducto.SelectedItems[0];
                string idProveedor = lis.SubItems[0].Text;

                Clipboard.Clear();
                Clipboard.SetText(idProveedor.Trim());

            }
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();
            Frm_Agregar_Productos Add = new Frm_Agregar_Productos();

            filtro.Show();
            Add.ShowDialog();
            filtro.Hide();

            if (Add.Tag.ToString() == "A")
            {
                Cargar_Los_Productos();
            }
        }
        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();
            Frm_Agregar_Productos Add = new Frm_Agregar_Productos();

            filtro.Show();
            Add.ShowDialog();
            filtro.Hide();

            if (Add.Tag.ToString() == "A")
            {
                Cargar_Los_Productos();
            }
        }
        private void mostrarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();
            Frm_Editar_Productos edit = new Frm_Editar_Productos();

            if (listViewProducto.SelectedIndices.Count == 0) //esto quiere decir que el usuario no ha seleccionado nada en la tabla
            {
                MessageBox.Show("Seleccione el item que seas ediar", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                filtro.Hide();
            }
            else
            {
                var lis = listViewProducto.SelectedItems[0];
                string idProveedor = lis.SubItems[0].Text;

                filtro.Show();
                edit.Tag = idProveedor;
                edit.ShowDialog();
                filtro.Hide();

                if (edit.Tag.ToString() == "A")
                {
                    Cargar_Los_Productos();
                }
            }
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();
           
            Frm_Editar_Productos edit = new Frm_Editar_Productos();

            if (listViewProducto.SelectedIndices.Count == 0) 
            {
                filtro.Show();
                MessageBox.Show("Seleccione el item que seas ediar", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                filtro.Hide();
            }
            else
            {
                var lis = listViewProducto.SelectedItems[0];
                string idProducto = lis.SubItems[0].Text;

                filtro.Show();
                edit.Tag = idProducto;
                edit.ShowDialog();
                filtro.Hide();

                if (edit.Tag.ToString() == "A")
                {
                    Cargar_Los_Productos();
                }
            }
        }
        //private void Seleccionar_Producto()
        //{
        //    Frm_Filtro filtro = new Frm_Filtro();
        //    Frm_Solo_Compra solocompra = new Frm_Solo_Compra();

        //    if (listViewProducto.SelectedIndices.Count != 0)
        //    {
        //        string TipoProduct = "";
        //        double stock = 0;
        //        double importe = 0;
        //        string xxnompro = "";
        //        double xxcant = 0;
        //        double PreComProduc = 0;

        //        var fila = listViewProducto.SelectedItems[0];
        //        TipoProduct = fila.SubItems[6].Text;

        //        if (TipoProduct.Trim() == "Producto")
        //        {
        //            Frm_Compras.XidProducto = fila.SubItems[0].Text;
        //            Frm_Compras.XnomProduct = fila.SubItems[1].Text;
        //            stock = Convert.ToDouble(fila.SubItems[2].Text);
        //            Frm_Compras.Xprecio = Convert.ToDouble(fila.SubItems[3].Text);
                   
        //            filtro.Show();
        //            solocompra.labelStock.Text = stock.ToString();
        //            xxnompro = fila.SubItems[1].Text;
        //            solocompra.labelNom.Text = xxnompro;
        //            solocompra.ShowDialog();
        //            filtro.Hide();

        //            if (solocompra.Tag.ToString() == "A")
        //            {
        //                xxcant = Convert.ToDouble(solocompra.elEntrySoloCantidad.Text);
        //                solocompra.elEntrySoloCantidad.Text = "";

        //                importe = Convert.ToDouble(xxcant) * Convert.ToDouble(PreComProduc);
        //                Frm_Compras.Ximporte = importe;
        //                Frm_Compras.Xcant = xxcant;

        //                this.Tag = "A";
        //                this.Close();
        //            }
        //        }
        //    }
        //}
        private void listViewProducto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Seleccionar_Producto();
        }

        private void listViewProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Seleccionar_Producto();
            }
        }

        private void Frm_List_Pro_Compra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Tag = "";
                this.Close();
            }
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.A))
            {
                txt_buscar_Producto.Focus();
            }
        }

    }
}
