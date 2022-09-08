
namespace Design_Dashboard_Modern.Cliente
{
    partial class Form_Listado_del_Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Listado_del_Cliente));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_titu = new System.Windows.Forms.Panel();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.txt_buscar_Clientes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewcliente = new System.Windows.Forms.ListView();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelCliente = new System.Windows.Forms.Panel();
            this.FechaAniver = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Ubicacion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.cedula = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.NombreCliente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.IDCliente = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.lblruc = new System.Windows.Forms.Label();
            this.bunifuThinButtonRegistrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButtonLimpiar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnl_titu.SuspendLayout();
            this.PanelCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnl_titu
            // 
            this.pnl_titu.BackColor = System.Drawing.Color.DimGray;
            this.pnl_titu.Controls.Add(this.buttonBuscar);
            this.pnl_titu.Controls.Add(this.txt_buscar_Clientes);
            this.pnl_titu.Controls.Add(this.label1);
            this.pnl_titu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titu.Location = new System.Drawing.Point(0, 0);
            this.pnl_titu.Name = "pnl_titu";
            this.pnl_titu.Size = new System.Drawing.Size(547, 70);
            this.pnl_titu.TabIndex = 2;
            this.pnl_titu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_titu_MouseMove);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.buttonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.Location = new System.Drawing.Point(488, 19);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(32, 28);
            this.buttonBuscar.TabIndex = 13;
            this.buttonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // txt_buscar_Clientes
            // 
            this.txt_buscar_Clientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_buscar_Clientes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_buscar_Clientes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_buscar_Clientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_buscar_Clientes.HintForeColor = System.Drawing.Color.Empty;
            this.txt_buscar_Clientes.HintText = "";
            this.txt_buscar_Clientes.isPassword = false;
            this.txt_buscar_Clientes.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_buscar_Clientes.LineIdleColor = System.Drawing.Color.DarkGray;
            this.txt_buscar_Clientes.LineMouseHoverColor = System.Drawing.Color.SkyBlue;
            this.txt_buscar_Clientes.LineThickness = 3;
            this.txt_buscar_Clientes.Location = new System.Drawing.Point(197, 19);
            this.txt_buscar_Clientes.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscar_Clientes.Name = "txt_buscar_Clientes";
            this.txt_buscar_Clientes.Size = new System.Drawing.Size(340, 33);
            this.txt_buscar_Clientes.TabIndex = 12;
            this.txt_buscar_Clientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_buscar_Clientes.OnValueChanged += new System.EventHandler(this.txt_buscar_Clientes_OnValueChanged);
            this.txt_buscar_Clientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_Clientes_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista del los Clientes";
            // 
            // listViewcliente
            // 
            this.listViewcliente.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.listViewcliente.HideSelection = false;
            this.listViewcliente.Location = new System.Drawing.Point(4, 76);
            this.listViewcliente.Name = "listViewcliente";
            this.listViewcliente.Size = new System.Drawing.Size(537, 361);
            this.listViewcliente.TabIndex = 3;
            this.listViewcliente.UseCompatibleStateImageBehavior = false;
            this.listViewcliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewcliente_KeyDown);
            this.listViewcliente.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewcliente_MouseDoubleClick);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.txt_buscar_Clientes;
            // 
            // PanelCliente
            // 
            this.PanelCliente.Controls.Add(this.FechaAniver);
            this.PanelCliente.Controls.Add(this.label8);
            this.PanelCliente.Controls.Add(this.Ubicacion);
            this.PanelCliente.Controls.Add(this.label7);
            this.PanelCliente.Controls.Add(this.cedula);
            this.PanelCliente.Controls.Add(this.label6);
            this.PanelCliente.Controls.Add(this.NombreCliente);
            this.PanelCliente.Controls.Add(this.label5);
            this.PanelCliente.Controls.Add(this.IDCliente);
            this.PanelCliente.Controls.Add(this.label4);
            this.PanelCliente.Location = new System.Drawing.Point(3, 76);
            this.PanelCliente.Name = "PanelCliente";
            this.PanelCliente.Size = new System.Drawing.Size(541, 446);
            this.PanelCliente.TabIndex = 9;
            this.PanelCliente.Visible = false;
            // 
            // FechaAniver
            // 
            this.FechaAniver.Location = new System.Drawing.Point(7, 421);
            this.FechaAniver.Name = "FechaAniver";
            this.FechaAniver.Size = new System.Drawing.Size(74, 20);
            this.FechaAniver.TabIndex = 0;
            this.FechaAniver.Visible = false;
            // 
            // label8
            // 
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(55, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 24);
            this.label8.TabIndex = 10;
            // 
            // Ubicacion
            // 
            this.Ubicacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Ubicacion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Ubicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Ubicacion.HintForeColor = System.Drawing.Color.Empty;
            this.Ubicacion.HintText = "";
            this.Ubicacion.isPassword = false;
            this.Ubicacion.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.Ubicacion.LineIdleColor = System.Drawing.Color.Gray;
            this.Ubicacion.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.Ubicacion.LineThickness = 2;
            this.Ubicacion.Location = new System.Drawing.Point(86, 285);
            this.Ubicacion.Margin = new System.Windows.Forms.Padding(4);
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.Size = new System.Drawing.Size(399, 33);
            this.Ubicacion.TabIndex = 9;
            this.Ubicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(55, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 24);
            this.label7.TabIndex = 8;
            // 
            // cedula
            // 
            this.cedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cedula.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cedula.HintForeColor = System.Drawing.Color.Empty;
            this.cedula.HintText = "";
            this.cedula.isPassword = false;
            this.cedula.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.cedula.LineIdleColor = System.Drawing.Color.Gray;
            this.cedula.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.cedula.LineThickness = 2;
            this.cedula.Location = new System.Drawing.Point(86, 213);
            this.cedula.Margin = new System.Windows.Forms.Padding(4);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(399, 33);
            this.cedula.TabIndex = 7;
            this.cedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(55, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 24);
            this.label6.TabIndex = 6;
            // 
            // NombreCliente
            // 
            this.NombreCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NombreCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NombreCliente.HintForeColor = System.Drawing.Color.Empty;
            this.NombreCliente.HintText = "";
            this.NombreCliente.isPassword = false;
            this.NombreCliente.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.NombreCliente.LineIdleColor = System.Drawing.Color.Gray;
            this.NombreCliente.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.NombreCliente.LineThickness = 2;
            this.NombreCliente.Location = new System.Drawing.Point(86, 139);
            this.NombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Size = new System.Drawing.Size(399, 33);
            this.NombreCliente.TabIndex = 5;
            this.NombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(55, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 24);
            this.label5.TabIndex = 4;
            // 
            // IDCliente
            // 
            this.IDCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.IDCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IDCliente.HintForeColor = System.Drawing.Color.Empty;
            this.IDCliente.HintText = "";
            this.IDCliente.isPassword = false;
            this.IDCliente.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.IDCliente.LineIdleColor = System.Drawing.Color.Gray;
            this.IDCliente.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.IDCliente.LineThickness = 2;
            this.IDCliente.Location = new System.Drawing.Point(86, 68);
            this.IDCliente.Margin = new System.Windows.Forms.Padding(4);
            this.IDCliente.Name = "IDCliente";
            this.IDCliente.Size = new System.Drawing.Size(399, 33);
            this.IDCliente.TabIndex = 3;
            this.IDCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(191, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Registrar Cliente";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(5, 494);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(13, 13);
            this.labelID.TabIndex = 13;
            this.labelID.Text = "1";
            this.labelID.Visible = false;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(24, 494);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(13, 13);
            this.labelNom.TabIndex = 14;
            this.labelNom.Text = "2";
            this.labelNom.Visible = false;
            // 
            // lblruc
            // 
            this.lblruc.AutoSize = true;
            this.lblruc.Location = new System.Drawing.Point(43, 494);
            this.lblruc.Name = "lblruc";
            this.lblruc.Size = new System.Drawing.Size(13, 13);
            this.lblruc.TabIndex = 15;
            this.lblruc.Text = "3";
            this.lblruc.Visible = false;
            // 
            // bunifuThinButtonRegistrar
            // 
            this.bunifuThinButtonRegistrar.ActiveBorderThickness = 1;
            this.bunifuThinButtonRegistrar.ActiveCornerRadius = 20;
            this.bunifuThinButtonRegistrar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuThinButtonRegistrar.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButtonRegistrar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuThinButtonRegistrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButtonRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButtonRegistrar.BackgroundImage")));
            this.bunifuThinButtonRegistrar.ButtonText = "Resgistrar";
            this.bunifuThinButtonRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButtonRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButtonRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuThinButtonRegistrar.IdleBorderThickness = 1;
            this.bunifuThinButtonRegistrar.IdleCornerRadius = 20;
            this.bunifuThinButtonRegistrar.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButtonRegistrar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuThinButtonRegistrar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuThinButtonRegistrar.Location = new System.Drawing.Point(303, 459);
            this.bunifuThinButtonRegistrar.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButtonRegistrar.Name = "bunifuThinButtonRegistrar";
            this.bunifuThinButtonRegistrar.Size = new System.Drawing.Size(161, 53);
            this.bunifuThinButtonRegistrar.TabIndex = 144;
            this.bunifuThinButtonRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButtonLimpiar
            // 
            this.bunifuThinButtonLimpiar.ActiveBorderThickness = 1;
            this.bunifuThinButtonLimpiar.ActiveCornerRadius = 20;
            this.bunifuThinButtonLimpiar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuThinButtonLimpiar.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButtonLimpiar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuThinButtonLimpiar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButtonLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButtonLimpiar.BackgroundImage")));
            this.bunifuThinButtonLimpiar.ButtonText = "Limpiar";
            this.bunifuThinButtonLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButtonLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButtonLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuThinButtonLimpiar.IdleBorderThickness = 1;
            this.bunifuThinButtonLimpiar.IdleCornerRadius = 20;
            this.bunifuThinButtonLimpiar.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButtonLimpiar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuThinButtonLimpiar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuThinButtonLimpiar.Location = new System.Drawing.Point(76, 460);
            this.bunifuThinButtonLimpiar.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButtonLimpiar.Name = "bunifuThinButtonLimpiar";
            this.bunifuThinButtonLimpiar.Size = new System.Drawing.Size(161, 53);
            this.bunifuThinButtonLimpiar.TabIndex = 143;
            this.bunifuThinButtonLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Listado_del_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(547, 526);
            this.Controls.Add(this.PanelCliente);
            this.Controls.Add(this.listViewcliente);
            this.Controls.Add(this.pnl_titu);
            this.Controls.Add(this.lblruc);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.bunifuThinButtonRegistrar);
            this.Controls.Add(this.bunifuThinButtonLimpiar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form_Listado_del_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Listado_del_Cliente";
            this.Load += new System.EventHandler(this.Form_Listado_del_Cliente_Load);
            this.pnl_titu.ResumeLayout(false);
            this.pnl_titu.PerformLayout();
            this.PanelCliente.ResumeLayout(false);
            this.PanelCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnl_titu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewcliente;
        private System.Windows.Forms.Button buttonBuscar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_buscar_Clientes;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel PanelCliente;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox IDCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Ubicacion;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cedula;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NombreCliente;
        private System.Windows.Forms.DateTimePicker FechaAniver;
        internal System.Windows.Forms.Label labelNom;
        internal System.Windows.Forms.Label labelID;
        internal System.Windows.Forms.Label lblruc;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButtonRegistrar;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButtonLimpiar;
    }
}