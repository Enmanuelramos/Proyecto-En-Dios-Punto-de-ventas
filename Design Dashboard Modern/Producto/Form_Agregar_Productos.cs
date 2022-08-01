using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Design_Dashboard_Modern.Utilitarios;
using Design_Dashboard_Modern.Proveedor;
using Capa_Entidad;
using Capa_Negocio;

namespace Design_Dashboard_Modern.Producto
{
    public partial class Form_Agregar_Productos : Form
    {
        public Form_Agregar_Productos()
        {
            InitializeComponent();
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            //this.Close();
        }
        string xFortoruta = "";
       
        private void LblBuscadorCategoria_Click(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();
            Fmr_Categoria categoria = new Fmr_Categoria();

            filtro.Show();
            categoria.ShowDialog();
            filtro.Hide();

            if (categoria.Tag.ToString() == "A")
            {
                idCat.Text = categoria.textBoxIDCategoria.Text;
                textBoxCategoria.Text = categoria.textNombretCategortia.Text;
            }

        }

        private void LblBuscadorProveedor_Click(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();
            Form_Listado_Proveedor Proveedor = new Form_Listado_Proveedor();

            filtro.Show();
            Proveedor.ShowDialog();
            filtro.Hide();

            if (Proveedor.Tag.ToString() == "A")
            {
                textBoxpro.Text = Proveedor.textBoxID.Text;
                textBoxProveedor.Text = Proveedor.textBoxNombre.Text;
            }
        }

        private void LblBuscaodorMarca_Click(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();
            Fmr_Marca marca = new Fmr_Marca();

            filtro.Show();
            marca.ShowDialog();
            filtro.Hide();

            if (marca.Tag.ToString() == "A")
            {
                idMarca.Text = marca.textBoxIDMarca.Text;
                textBoxMarca.Text = marca.textMarca.Text;
            }
        }
        private bool Validar_Caja_Texto()
        {
            Frm_Filtro filtro = new Frm_Filtro();

            if (string.IsNullOrEmpty(textIDproducto.Text))
            {
                filtro.Show();
                MessageBox.Show("Ingrese o genera el ID del producto", "Id Producto Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filtro.Hide();

                textIDproducto.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textDescripcion.Text))
            {
                filtro.Show();
                MessageBox.Show("Ingrese la descripcion del producto", "Descripcion Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filtro.Hide();

                textDescripcion.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxProveedor.Text))
            {
                filtro.Show();
                MessageBox.Show("Ingrese el proveedor del producto", "Proveedor Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filtro.Hide();

                textBoxProveedor.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxMarca.Text))
            {
                filtro.Show();
                MessageBox.Show("Ingrese la marca del producto", "Marca Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filtro.Hide();

                textBoxMarca.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxCategoria.Text))
            {
                filtro.Show();
                MessageBox.Show("Ingrese la categoria del producto", "Categoria Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filtro.Hide();

                textBoxCategoria.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(comboBoxTipoProducto.Text))
            {
                filtro.Show();
                MessageBox.Show("Ingrese el tipo del producto", "Tipo Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filtro.Hide();

                comboBoxTipoProducto.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(comboBoxUnidadMedida.Text))
            {
                filtro.Show();
                MessageBox.Show("Ingrese la unidad de mediga del producto", "unidad de medida Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filtro.Hide();

                comboBoxUnidadMedida.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxPrecioCompra.Text))
            {
                filtro.Show();
                MessageBox.Show("Ingrese precio compra del producto", "unidad de medida Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filtro.Hide();

                textBoxPrecioCompra.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxFrankUtilidad.Text))
            {
                filtro.Show();
                MessageBox.Show("Ingrese la utilidad del producto", "unidad de medida Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filtro.Hide();

                textBoxFrankUtilidad.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxPrecioMenor.Text))
            {
                filtro.Show();
                MessageBox.Show("Ingrese el precio menor del producto", "unidad de medida Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filtro.Hide();

                textBoxPrecioMenor.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBoxPrecioMayor.Text))
            {
                filtro.Show();
                MessageBox.Show("Ingrese el precio mayor del producto", "unidad de medida Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filtro.Hide();

                textBoxPrecioMayor.Focus();
                return false;
            }
            return true;
        }
        private void labelBuscarImagen_Click(object sender, EventArgs e)
        {

            var filePath = string.Empty;
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        xFortoruta = openFileDialog.FileName;
                        pictureBoxProducto.Load(xFortoruta);
                    }

                }
            }
            catch (Exception EX)
            {
                pictureBoxProducto.Load(Application.StartupPath + @"\more_info_40px.png"); // ojo no se quiere cargar la imagen por defecto
                xFortoruta = Application.StartupPath + @"\more_info_40px.png";

                MessageBox.Show("Error al cargar la imagen" + EX.Message);
            }
        }
        private void Registrar_Productos()
        {
            Frm_Filtro filtro = new Frm_Filtro();
            RN_Procutos Product = new RN_Procutos();
            EN_Productos EnPro = new EN_Productos();

            try
            {
                EnPro.Idproducto = textIDproducto.Text;
                EnPro.IdProveedor = textBoxpro.Text;
                EnPro.Descripcion = textDescripcion.Text;
                EnPro.Pre_compraSol = textBoxPrecioCompra.Text;
                EnPro.Frank = textBoxFrankUtilidad.Text;
                EnPro.StockActual = Convert.ToString("0");
                EnPro.IdCat = Convert.ToInt32(idMarca.Text);
                EnPro.IdMar = Convert.ToInt32(idCat.Text);

                if (xFortoruta.Trim().Length < 5 )
                {
                    EnPro.Foto = "_";
                }
                else{
                    EnPro.Foto = xFortoruta;
                }
                EnPro.Pre_Venta_Menor = textBoxPrecioMenor.Text;
                EnPro.Pre_Venta_Mayor = textBoxPrecioMayor.Text;
                EnPro.UndMdida = comboBoxUnidadMedida.Text;
                EnPro.TipoProd = comboBoxTipoProducto.Text;
                EnPro.Utilidad = textBoxUtilidad.Text;
                EnPro.ValorporProd = 0;

                Product.RN_Insertar_Productos(EnPro);

            }
            catch (Exception Ex)
            {
                MessageBox.Show("error al guardar el registro del producto " + Ex.Message);
            }
            filtro.Show();
            MessageBox.Show("Se guardo el registor del producto Exitosamente");
            filtro.Hide();

            this.Tag = "A";
            this.Close();
        }
        private void textBoxFrankUtilidad_TextChanged(object sender, EventArgs e)
        {
            textBoxFrankUtilidad.Text = textBoxFrankUtilidad.Text.Replace(",", ".");
            // espara comvertir la coma en punto
            //Text.Replace("este el carater que queremos quitar "," y el carracter que queremos reemplasar");
            textBoxFrankUtilidad.SelectionStart = textBoxFrankUtilidad.Text.Length;
            //estoy es para que el cursor no subraye los numeros al aplicar una letra
            try
            {

                if (textBoxFrankUtilidad.Text.Trim() == "") return;
                if (textBoxPrecioCompra.Text.Trim() == "") return;

                string ComPre;
                string PreUti;
                double NComPre = Convert.ToDouble(textBoxPrecioCompra.Text);
                double NPreUti = Convert.ToDouble(textBoxFrankUtilidad.Text);

                ComPre = Convert.ToString(Math.Round((NComPre) / (1 - (NPreUti / 100)), 2));
                textBoxPrecioMenor.Text = ComPre;

                PreUti = Convert.ToString(Math.Round((NComPre / (1 - (NPreUti / 100))) - NComPre, 2));
                textBoxUtilidad.Text = PreUti;
            }
            catch (Exception Ex)
            {
                string sms = Ex.Message;
            }
        }

        private void textBoxFrankUtilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario ul = new Utilitario();
            e.KeyChar = Convert.ToChar(ul.Solo_Numeros(e.KeyChar));
        }

        private void textBoxPrecioCompra_TextChanged(object sender, EventArgs e)
        {
            textBoxPrecioCompra.Text = textBoxPrecioCompra.Text.Replace(",",".");
            textBoxPrecioCompra.SelectionStart = textBoxPrecioCompra.Text.Length;
        }

        private void textBoxPrecioCompra_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPrecioCompra.Text = "";
        }

        private void textBoxFrankUtilidad_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxFrankUtilidad.Text = "";
        }

        private void textBoxPrecioMenor_TextChanged(object sender, EventArgs e)
        {
            textBoxPrecioMenor.Text = textBoxPrecioMenor.Text.Replace(",",".");
            textBoxPrecioMenor.SelectionStart = textBoxPrecioMenor.Text.Length;
        }

        private void textBoxPrecioMenor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario ul = new Utilitario();
            e.KeyChar = Convert.ToChar(ul.Solo_Numeros(e.KeyChar));
        }

        private void textBoxPrecioMenor_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPrecioMenor.Text = "";
        }

        private void textBoxPrecioMayor_TextChanged(object sender, EventArgs e)
        {
            textBoxPrecioMayor.Text = textBoxPrecioMayor.Text.Replace(",",".");
            textBoxPrecioMayor.SelectionStart = textBoxPrecioMayor.Text.Length;
        }

        private void textBoxPrecioMayor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitario ul = new Utilitario();
            e.KeyChar = Convert.ToChar(ul.Solo_Numeros(e.KeyChar));
        }

        private void textBoxPrecioMayor_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPrecioMayor.Text = "";
        }

        private void bunifuThinButtonRegistrar_Click(object sender, EventArgs e)
        {
            if (Validar_Caja_Texto() == true)
            {
                Registrar_Productos();
            }
        }
    }
}
