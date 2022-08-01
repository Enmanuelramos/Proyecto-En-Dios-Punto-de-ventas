namespace Design_Dashboard_Modern.Utilitarios
{
    partial class Fmr_Marca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fmr_Marca));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_titu = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombreProducto = new System.Windows.Forms.TextBox();
            this.label_NombreProducto = new System.Windows.Forms.Label();
            this.textIdProducto = new System.Windows.Forms.TextBox();
            this.labelTituloMantenimiento = new System.Windows.Forms.Label();
            this.listView_Marca = new System.Windows.Forms.ListView();
            this.bt_Agregar = new System.Windows.Forms.Button();
            this.bt_Editar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIDMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRegistrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gru_det = new System.Windows.Forms.Panel();
            this.pnl_titu.SuspendLayout();
            this.gru_det.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnl_titu
            // 
            this.pnl_titu.BackColor = System.Drawing.Color.DimGray;
            this.pnl_titu.Controls.Add(this.btn_cerrar);
            this.pnl_titu.Controls.Add(this.label1);
            this.pnl_titu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titu.Location = new System.Drawing.Point(0, 0);
            this.pnl_titu.Name = "pnl_titu";
            this.pnl_titu.Size = new System.Drawing.Size(388, 45);
            this.pnl_titu.TabIndex = 1;
            this.pnl_titu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_titu_MouseMove);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(346, 4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(32, 32);
            this.btn_cerrar.TabIndex = 6;
            this.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento de Marca\r\n";
            // 
            // textNombreProducto
            // 
            this.textNombreProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombreProducto.ForeColor = System.Drawing.Color.DimGray;
            this.textNombreProducto.Location = new System.Drawing.Point(27, 126);
            this.textNombreProducto.Name = "textNombreProducto";
            this.textNombreProducto.Size = new System.Drawing.Size(339, 25);
            this.textNombreProducto.TabIndex = 10;
            // 
            // label_NombreProducto
            // 
            this.label_NombreProducto.AutoSize = true;
            this.label_NombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NombreProducto.Location = new System.Drawing.Point(24, 98);
            this.label_NombreProducto.Name = "label_NombreProducto";
            this.label_NombreProducto.Size = new System.Drawing.Size(131, 16);
            this.label_NombreProducto.TabIndex = 9;
            this.label_NombreProducto.Text = "Nombre de la Marca";
            // 
            // textIdProducto
            // 
            this.textIdProducto.Enabled = false;
            this.textIdProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdProducto.ForeColor = System.Drawing.Color.DimGray;
            this.textIdProducto.Location = new System.Drawing.Point(27, 57);
            this.textIdProducto.Name = "textIdProducto";
            this.textIdProducto.Size = new System.Drawing.Size(179, 25);
            this.textIdProducto.TabIndex = 7;
            // 
            // labelTituloMantenimiento
            // 
            this.labelTituloMantenimiento.AutoSize = true;
            this.labelTituloMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloMantenimiento.Location = new System.Drawing.Point(24, 26);
            this.labelTituloMantenimiento.Name = "labelTituloMantenimiento";
            this.labelTituloMantenimiento.Size = new System.Drawing.Size(60, 16);
            this.labelTituloMantenimiento.TabIndex = 6;
            this.labelTituloMantenimiento.Text = "Id Marca";
            // 
            // listView_Marca
            // 
            this.listView_Marca.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Marca.ForeColor = System.Drawing.Color.DimGray;
            this.listView_Marca.HideSelection = false;
            this.listView_Marca.Location = new System.Drawing.Point(1, 90);
            this.listView_Marca.Name = "listView_Marca";
            this.listView_Marca.Size = new System.Drawing.Size(384, 327);
            this.listView_Marca.TabIndex = 2;
            this.listView_Marca.UseCompatibleStateImageBehavior = false;
            // 
            // bt_Agregar
            // 
            this.bt_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Agregar.FlatAppearance.BorderSize = 0;
            this.bt_Agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.bt_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.bt_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Agregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Agregar.ForeColor = System.Drawing.Color.White;
            this.bt_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("bt_Agregar.Image")));
            this.bt_Agregar.Location = new System.Drawing.Point(318, 51);
            this.bt_Agregar.Name = "bt_Agregar";
            this.bt_Agregar.Size = new System.Drawing.Size(32, 32);
            this.bt_Agregar.TabIndex = 7;
            this.bt_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Agregar.UseVisualStyleBackColor = true;
            this.bt_Agregar.Click += new System.EventHandler(this.bt_Agregar_Click);
            // 
            // bt_Editar
            // 
            this.bt_Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Editar.FlatAppearance.BorderSize = 0;
            this.bt_Editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.bt_Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.bt_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Editar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Editar.ForeColor = System.Drawing.Color.White;
            this.bt_Editar.Image = ((System.Drawing.Image)(resources.GetObject("bt_Editar.Image")));
            this.bt_Editar.Location = new System.Drawing.Point(280, 51);
            this.bt_Editar.Name = "bt_Editar";
            this.bt_Editar.Size = new System.Drawing.Size(32, 32);
            this.bt_Editar.TabIndex = 8;
            this.bt_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Editar.UseVisualStyleBackColor = true;
            this.bt_Editar.Click += new System.EventHandler(this.bt_Editar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.Btn_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(238, 51);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(32, 32);
            this.Btn_Eliminar.TabIndex = 9;
            this.Btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSeleccionar.FlatAppearance.BorderSize = 0;
            this.buttonSeleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.buttonSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeleccionar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeleccionar.ForeColor = System.Drawing.Color.White;
            this.buttonSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSeleccionar.Image")));
            this.buttonSeleccionar.Location = new System.Drawing.Point(200, 51);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(32, 32);
            this.buttonSeleccionar.TabIndex = 10;
            this.buttonSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Id Marca";
            // 
            // textBoxIDMarca
            // 
            this.textBoxIDMarca.Enabled = false;
            this.textBoxIDMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDMarca.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxIDMarca.Location = new System.Drawing.Point(20, 66);
            this.textBoxIDMarca.Name = "textBoxIDMarca";
            this.textBoxIDMarca.Size = new System.Drawing.Size(179, 25);
            this.textBoxIDMarca.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre Marca";
            // 
            // textMarca
            // 
            this.textMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMarca.ForeColor = System.Drawing.Color.DimGray;
            this.textMarca.Location = new System.Drawing.Point(21, 135);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(339, 25);
            this.textMarca.TabIndex = 14;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Limpiar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(35, 232);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(131, 50);
            this.bunifuThinButton21.TabIndex = 30;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.ActiveBorderThickness = 1;
            this.btnRegistrar.ActiveCornerRadius = 20;
            this.btnRegistrar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrar.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.BackgroundImage")));
            this.btnRegistrar.ButtonText = "Registrar";
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrar.IdleBorderThickness = 1;
            this.btnRegistrar.IdleCornerRadius = 20;
            this.btnRegistrar.IdleFillColor = System.Drawing.Color.White;
            this.btnRegistrar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnRegistrar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrar.Location = new System.Drawing.Point(210, 232);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(131, 50);
            this.btnRegistrar.TabIndex = 31;
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // gru_det
            // 
            this.gru_det.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gru_det.Controls.Add(this.btnRegistrar);
            this.gru_det.Controls.Add(this.bunifuThinButton21);
            this.gru_det.Controls.Add(this.textMarca);
            this.gru_det.Controls.Add(this.label2);
            this.gru_det.Controls.Add(this.textBoxIDMarca);
            this.gru_det.Controls.Add(this.label3);
            this.gru_det.Location = new System.Drawing.Point(0, 41);
            this.gru_det.Name = "gru_det";
            this.gru_det.Size = new System.Drawing.Size(388, 378);
            this.gru_det.TabIndex = 12;
            this.gru_det.Visible = false;
            // 
            // Fmr_Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 421);
            this.Controls.Add(this.gru_det);
            this.Controls.Add(this.bt_Editar);
            this.Controls.Add(this.bt_Agregar);
            this.Controls.Add(this.listView_Marca);
            this.Controls.Add(this.pnl_titu);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.buttonSeleccionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fmr_Marca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Reg_Prod";
            this.Load += new System.EventHandler(this.Fmr_Categoria_Load);
            this.pnl_titu.ResumeLayout(false);
            this.pnl_titu.PerformLayout();
            this.gru_det.ResumeLayout(false);
            this.gru_det.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnl_titu;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label1;
        //private Klik.Windows.Forms.v1.EntryLib.ELGroupBox gru_det;
        //private Klik.Windows.Forms.v1.EntryLib.ELButton btn_cancel;
        //private Klik.Windows.Forms.v1.EntryLib.ELButton btn_listo;
        private System.Windows.Forms.Label labelTituloMantenimiento;
        private System.Windows.Forms.Label label_NombreProducto;
        private System.Windows.Forms.Button bt_Editar;
        private System.Windows.Forms.Button bt_Agregar;
        private System.Windows.Forms.ListView listView_Marca;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button buttonSeleccionar;
        public System.Windows.Forms.TextBox textIdProducto;
        public System.Windows.Forms.TextBox textNombreProducto;
        private System.Windows.Forms.Panel gru_det;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegistrar;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        public System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox textBoxIDMarca;
    }
}