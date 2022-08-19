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
using Capa_Datos;

namespace Design_Dashboard_Modern.Producto
{
    public partial class Frm_Editar_Productos : Form
    {
        public Frm_Editar_Productos()
        {
            InitializeComponent();
        }
        private void Frm_Editar_Productos_Load(object sender, EventArgs e)
        {
            textIDproducto.Text = RN_Tipo_Documento.RN_Numero_ID(4);
            Buscar_Productos_Para_Editar(this.Tag.ToString());
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }
        string xFortoruta = "";
       
      

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
        private void Registrar_Kardex(string Id_Tipo)
        {
            RN_Kardex Kar = new RN_Kardex();
            EN_Kardex EnKAr = new EN_Kardex();

            try
            {
                if (Kar.BD_Verificar_Producto_SiTieneKardex(Id_Tipo) == true)
                {
                    return; // ya tiene un kardex
                }
                else
                {
                    string IDkar = RN_Tipo_Documento.RN_Numero_ID(6);
                    Kar.RN_Registrar_Kaxdex(IDkar, Id_Tipo, textBoxpro.Text);

                    if (BD_Kardex.segurado == true)
                    {
                        RN_Tipo_Documento.RN_Actualizar_Tipo_Document_CorelativoProducto(6);

                        EnKAr.IdKardex = IDkar;
                        EnKAr.Item = 1;
                        EnKAr.Doc_soporte = "000";
                        EnKAr.Det_operacion = "Inicio de Kardex";
                        // entrada 
                        EnKAr.Cantidad_In = Convert.ToString("0");
                        EnKAr.Precio_Unit_In = Convert.ToString("0");
                        EnKAr.Costo_Total_In = Convert.ToString("0");
                        // salida
                        EnKAr.Cantidad_Out = Convert.ToString("0");
                        EnKAr.Precio_Unt_Out = Convert.ToString("0");
                        EnKAr.Importe_Total_Out = Convert.ToString("0");
                        // Saldos
                        EnKAr.Cantidad_Saldo = Convert.ToString("0");
                        EnKAr.Promedio = Convert.ToString("0");
                        EnKAr.Costo_Total_Saldo = Convert.ToString("0");

                        Kar.RN_Registrar_Detalle_Kardex(EnKAr);

                        if (BD_Kardex.detsaved == true)
                        {

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al guardar  " + ex.Message);
            }
        }
        private void Actualizar_Productos()
        {
            RN_Producto Product = new RN_Producto();
            EN_Productos EnPro = new EN_Productos();

            try
            {
                EnPro.Idproducto = textIDproducto.Text;
                EnPro.IdProveedor = textBoxpro.Text;
                EnPro.Descripcion = textDescripcion.Text;
                EnPro.Pre_compraSol = textBoxPrecioCompra.Text;
                EnPro.Frank = textBoxFrankUtilidad.Text;
                EnPro.StockActual = Convert.ToString("0");
                EnPro.IdCat = Convert.ToInt32(idCat.Text);
                EnPro.IdMar = Convert.ToInt32(idMarca.Text);

                if (xFortoruta.Trim().Length < 5)
                {
                    EnPro.Foto = "_";
                }
                else
                {
                    EnPro.Foto = xFortoruta;
                }
                EnPro.Pre_Venta_Menor = textBoxPrecioMenor.Text;
                EnPro.Pre_Venta_Mayor = textBoxPrecioMayor.Text;
                EnPro.UndMdida = comboBoxUnidadMedida.Text;
                EnPro.TipoProd = comboBoxTipoProducto.Text;
                EnPro.Utilidad = textBoxUtilidad.Text;
                EnPro.ValorporProd = 0;

                Product.RN_Modificar_Productos(EnPro);

                if (BD_Productos.edito == true)
                {
                    Frm_Filtro Filtro = new Frm_Filtro();

                    Filtro.Show();
                    MessageBox.Show("Se edito Exitosamente", "Editar productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Filtro.Hide();

                    this.Tag = "A";
                    this.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show("error al guardar el registro del producto " + Ex.Message);
            }
        }
        private void Buscar_Productos_Para_Editar(string idPro)
        {
            RN_Producto Obj = new RN_Producto();
            DataTable data = new DataTable();

            try
            {
                data = Obj.RN_Buscar_Productos(idPro);
                if (data.Rows.Count > 0)
                {
                    //estamos trabajando con matrices fila y columna, columna 0 y fila corespondiente
                    textIDproducto.Text = Convert.ToString(data.Rows[0]["Id_Pro"]);
                    textDescripcion.Text = Convert.ToString(data.Rows[0]["Descripcion_Larga"]);
                    comboBoxTipoProducto.Text = Convert.ToString(data.Rows[0]["TipoProdcto"]);
                    comboBoxUnidadMedida.Text = Convert.ToString(data.Rows[0]["UndMedida"]);
                    textBoxPrecioCompra.Text = Convert.ToString(data.Rows[0]["Pre_CompraS"]);
                    textBoxFrankUtilidad.Text = Convert.ToString(data.Rows[0]["Frank"]);
                    textBoxPrecioMayor.Text = Convert.ToString(data.Rows[0]["Pre_vntaxMayor"]);
                    textBoxPrecioMenor.Text = Convert.ToString(data.Rows[0]["Pre_vntaxMenor"]);

                    textBoxUtilidad.Text = Convert.ToString(data.Rows[0]["UtilidadUnit"]);
                    idMarca.Text = Convert.ToString(data.Rows[0]["Id_Marca"]);
                    idCat.Text = Convert.ToString(data.Rows[0]["Id_Cat"]);
                    textBoxpro.Text = Convert.ToString(data.Rows[0]["IDPROVEE"]);
                    textBoxProveedor.Text = Convert.ToString(data.Rows[0]["NOMBRE"]);
                    textBoxMarca.Text = Convert.ToString(data.Rows[0]["Marca"]);
                    textBoxCategoria.Text = Convert.ToString(data.Rows[0]["Categoria"]);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No Se edito Corectamente el Producto " + Ex.Message, "Editar productos", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void LblBuscadorProveedor_Click_1(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();
            Form_Listado_Proveedor ProNom = new Form_Listado_Proveedor();

            filtro.Show();
            ProNom.ShowDialog();
            filtro.Hide();

            if (ProNom.Tag.ToString() == "A")
            {
                textBoxpro.Text = ProNom.textBoxID.Text;
                textBoxProveedor.Text = ProNom.textBoxNombre.Text;

            }
        }

        private void LblBuscaodorMarca_Click_1(object sender, EventArgs e)
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

        private void LblBuscadorCategoria_Click_1(object sender, EventArgs e)
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
            textBoxPrecioCompra.Text = textBoxPrecioCompra.Text.Replace(",", ".");
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
            textBoxPrecioMenor.Text = textBoxPrecioMenor.Text.Replace(",", ".");
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
            textBoxPrecioMayor.Text = textBoxPrecioMayor.Text.Replace(",", ".");
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
                Actualizar_Productos();
            }
        }

        
    }
}
