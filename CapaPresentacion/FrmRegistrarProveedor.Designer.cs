namespace CapaPresentacion
{
    partial class FrmRegistrarProveedor
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.rbtinactivo = new System.Windows.Forms.RadioButton();
            this.rbtactivo = new System.Windows.Forms.RadioButton();
            this.txtidproveedor = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtrfc = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtrazonsocial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(435, 315);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 34;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(354, 315);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 33;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // rbtinactivo
            // 
            this.rbtinactivo.AutoSize = true;
            this.rbtinactivo.Location = new System.Drawing.Point(463, 226);
            this.rbtinactivo.Name = "rbtinactivo";
            this.rbtinactivo.Size = new System.Drawing.Size(74, 20);
            this.rbtinactivo.TabIndex = 32;
            this.rbtinactivo.TabStop = true;
            this.rbtinactivo.Text = "Inactivo";
            this.rbtinactivo.UseVisualStyleBackColor = true;
            // 
            // rbtactivo
            // 
            this.rbtactivo.AutoSize = true;
            this.rbtactivo.Location = new System.Drawing.Point(354, 226);
            this.rbtactivo.Name = "rbtactivo";
            this.rbtactivo.Size = new System.Drawing.Size(65, 20);
            this.rbtactivo.TabIndex = 31;
            this.rbtactivo.TabStop = true;
            this.rbtactivo.Text = "Activo";
            this.rbtactivo.UseVisualStyleBackColor = true;
            // 
            // txtidproveedor
            // 
            this.txtidproveedor.Location = new System.Drawing.Point(203, 45);
            this.txtidproveedor.Name = "txtidproveedor";
            this.txtidproveedor.Size = new System.Drawing.Size(113, 22);
            this.txtidproveedor.TabIndex = 30;
            this.txtidproveedor.Visible = false;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(354, 73);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(300, 22);
            this.txttelefono.TabIndex = 29;
            // 
            // txtrfc
            // 
            this.txtrfc.Location = new System.Drawing.Point(16, 224);
            this.txtrfc.Name = "txtrfc";
            this.txtrfc.Size = new System.Drawing.Size(300, 22);
            this.txtrfc.TabIndex = 28;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(16, 153);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(300, 22);
            this.txtdni.TabIndex = 27;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(354, 153);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(300, 22);
            this.txtdireccion.TabIndex = 26;
            // 
            // txtrazonsocial
            // 
            this.txtrazonsocial.Location = new System.Drawing.Point(16, 73);
            this.txtrazonsocial.Name = "txtrazonsocial";
            this.txtrazonsocial.Size = new System.Drawing.Size(300, 22);
            this.txtrazonsocial.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Seleccione estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "RFC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Razón Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Registrar Nuevo Proveedor";
            // 
            // FrmRegistrarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.rbtinactivo);
            this.Controls.Add(this.rbtactivo);
            this.Controls.Add(this.txtidproveedor);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtrfc);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtrazonsocial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistrarProveedor";
            this.Text = "FrmRegistrarProveedor";
            this.Load += new System.EventHandler(this.FrmRegistrarProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.Button btnguardar;
        public System.Windows.Forms.RadioButton rbtinactivo;
        public System.Windows.Forms.RadioButton rbtactivo;
        public System.Windows.Forms.TextBox txtidproveedor;
        public System.Windows.Forms.TextBox txttelefono;
        public System.Windows.Forms.TextBox txtrfc;
        public System.Windows.Forms.TextBox txtdni;
        public System.Windows.Forms.TextBox txtdireccion;
        public System.Windows.Forms.TextBox txtrazonsocial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}