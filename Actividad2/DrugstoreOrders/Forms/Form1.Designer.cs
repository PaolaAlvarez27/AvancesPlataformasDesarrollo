namespace DrugstoreOrders.Forms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNombMedicam;
        private System.Windows.Forms.ComboBox cbTipoMedic;
        private System.Windows.Forms.TextBox txtCantidadMedic;
        private System.Windows.Forms.RadioButton rbDist1;
        private System.Windows.Forms.RadioButton rbDist2;
        private System.Windows.Forms.RadioButton rbDist3;
        private System.Windows.Forms.CheckBox cbPrincip;
        private System.Windows.Forms.CheckBox cbSecund;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreMedicam;
        private System.Windows.Forms.Label lblTipoMedicam;
        private System.Windows.Forms.Label lblCantidadMedicam;
        private System.Windows.Forms.Label lblDistribuidor;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblImagenDerecha;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNombMedicam = new System.Windows.Forms.TextBox();
            this.cbTipoMedic = new System.Windows.Forms.ComboBox();
            this.txtCantidadMedic = new System.Windows.Forms.TextBox();
            this.rbDist1 = new System.Windows.Forms.RadioButton();
            this.rbDist2 = new System.Windows.Forms.RadioButton();
            this.rbDist3 = new System.Windows.Forms.RadioButton();
            this.cbPrincip = new System.Windows.Forms.CheckBox();
            this.cbSecund = new System.Windows.Forms.CheckBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombreMedicam = new System.Windows.Forms.Label();
            this.lblTipoMedicam = new System.Windows.Forms.Label();
            this.lblCantidadMedicam = new System.Windows.Forms.Label();
            this.lblDistribuidor = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblImagenDerecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Franklin Gothic Book", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(750, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Haz tu pedido en línea de forma fácil y segura";
            
            // 
            // lblNombreMedicam
            // 
            this.lblNombreMedicam.AutoSize = true;
            this.lblNombreMedicam.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.lblNombreMedicam.Location = new System.Drawing.Point(30, 100);
            this.lblNombreMedicam.Name = "lblNombreMedicam";
            this.lblNombreMedicam.Size = new System.Drawing.Size(177, 21);
            this.lblNombreMedicam.TabIndex = 1;
            this.lblNombreMedicam.Text = "Nombre del medicamento";
            
            // 
            // lblTipoMedicam
            // 
            this.lblTipoMedicam.AutoSize = true;
            this.lblTipoMedicam.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.lblTipoMedicam.Location = new System.Drawing.Point(30, 170);
            this.lblTipoMedicam.Name = "lblTipoMedicam";
            this.lblTipoMedicam.Size = new System.Drawing.Size(139, 21);
            this.lblTipoMedicam.TabIndex = 2;
            this.lblTipoMedicam.Text = "Tipo de medicamento";
            
            // 
            // lblCantidadMedicam
            // 
            this.lblCantidadMedicam.AutoSize = true;
            this.lblCantidadMedicam.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.lblCantidadMedicam.Location = new System.Drawing.Point(30, 240);
            this.lblCantidadMedicam.Name = "lblCantidadMedicam";
            this.lblCantidadMedicam.Size = new System.Drawing.Size(172, 21);
            this.lblCantidadMedicam.TabIndex = 3;
            this.lblCantidadMedicam.Text = "Cantidad de medicamento";
            
            // 
            // lblDistribuidor
            // 
            this.lblDistribuidor.AutoSize = true;
            this.lblDistribuidor.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.lblDistribuidor.Location = new System.Drawing.Point(30, 310);
            this.lblDistribuidor.Name = "lblDistribuidor";
            this.lblDistribuidor.Size = new System.Drawing.Size(154, 21);
            this.lblDistribuidor.TabIndex = 4;
            this.lblDistribuidor.Text = "Selecciona el distribuidor";
            
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.lblSucursal.Location = new System.Drawing.Point(220, 310);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(146, 21);
            this.lblSucursal.TabIndex = 5;
            this.lblSucursal.Text = "Selecciona la sucursal";
            
            // 
            // txtNombMedicam
            // 
            this.txtNombMedicam.Location = new System.Drawing.Point(30, 130);
            this.txtNombMedicam.Name = "txtNombMedicam";
            this.txtNombMedicam.Size = new System.Drawing.Size(320, 20);
            this.txtNombMedicam.TabIndex = 6;
            
            // 
            // cbTipoMedic
            // 
            this.cbTipoMedic.FormattingEnabled = true;
            this.cbTipoMedic.Items.AddRange(new object[] {
            "Analgésico",
            "Analéptico",
            "Anestésico",
            "Antiácido",
            "Antidepresivo",
            "Antibiótico"});
            this.cbTipoMedic.Location = new System.Drawing.Point(30, 200);
            this.cbTipoMedic.Name = "cbTipoMedic";
            this.cbTipoMedic.Size = new System.Drawing.Size(320, 21);
            this.cbTipoMedic.TabIndex = 7;
            
            // 
            // txtCantidadMedic
            // 
            this.txtCantidadMedic.Location = new System.Drawing.Point(30, 270);
            this.txtCantidadMedic.Name = "txtCantidadMedic";
            this.txtCantidadMedic.Size = new System.Drawing.Size(320, 20);
            this.txtCantidadMedic.TabIndex = 8;
            
            // 
            // rbDist1
            // 
            this.rbDist1.AutoSize = true;
            this.rbDist1.Location = new System.Drawing.Point(30, 340);
            this.rbDist1.Name = "rbDist1";
            this.rbDist1.Size = new System.Drawing.Size(64, 17);
            this.rbDist1.TabIndex = 9;
            this.rbDist1.TabStop = true;
            this.rbDist1.Text = "Cofarma";
            this.rbDist1.UseVisualStyleBackColor = true;
            
            // 
            // rbDist2
            // 
            this.rbDist2.AutoSize = true;
            this.rbDist2.Location = new System.Drawing.Point(30, 370);
            this.rbDist2.Name = "rbDist2";
            this.rbDist2.Size = new System.Drawing.Size(78, 17);
            this.rbDist2.TabIndex = 10;
            this.rbDist2.TabStop = true;
            this.rbDist2.Text = "Empsephar";
            this.rbDist2.UseVisualStyleBackColor = true;
            
            // 
            // rbDist3
            // 
            this.rbDist3.AutoSize = true;
            this.rbDist3.Location = new System.Drawing.Point(30, 400);
            this.rbDist3.Name = "rbDist3";
            this.rbDist3.Size = new System.Drawing.Size(64, 17);
            this.rbDist3.TabIndex = 11;
            this.rbDist3.TabStop = true;
            this.rbDist3.Text = "Cemefar";
            this.rbDist3.UseVisualStyleBackColor = true;
            
            // 
            // cbPrincip
            // 
            this.cbPrincip.AutoSize = true;
            this.cbPrincip.Location = new System.Drawing.Point(220, 340);
            this.cbPrincip.Name = "cbPrincip";
            this.cbPrincip.Size = new System.Drawing.Size(69, 17);
            this.cbPrincip.TabIndex = 12;
            this.cbPrincip.Text = "Principal";
            this.cbPrincip.UseVisualStyleBackColor = true;
            
            // 
            // cbSecund
            // 
            this.cbSecund.AutoSize = true;
            this.cbSecund.Location = new System.Drawing.Point(220, 370);
            this.cbSecund.Name = "cbSecund";
            this.cbSecund.Size = new System.Drawing.Size(76, 17);
            this.cbSecund.TabIndex = 13;
            this.cbSecund.Text = "Secundaria";
            this.cbSecund.UseVisualStyleBackColor = true;
            
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Green;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(60, 430);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(260, 50);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(380, 440);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 30);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            
            // 
            // lblLogo
            // 
            this.lblLogo.Image = System.Drawing.Image.FromFile("Resources/Logo_Drogueria_circ_p.png"); // Imagen logo
            this.lblLogo.Location = new System.Drawing.Point(600, 20);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(100, 100);
            this.lblLogo.TabIndex = 16;
            
            // 
            // lblImagenDerecha
            // 
            this.lblImagenDerecha.Image = System.Drawing.Image.FromFile("Resources/Tabletas.png"); // Imagen derecha
            this.lblImagenDerecha.Location = new System.Drawing.Point(550, 130);
            this.lblImagenDerecha.Name = "lblImagenDerecha";
            this.lblImagenDerecha.Size = new System.Drawing.Size(200, 300);
            this.lblImagenDerecha.TabIndex = 17;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblImagenDerecha);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblDistribuidor);
            this.Controls.Add(this.lblCantidadMedicam);
            this.Controls.Add(this.lblTipoMedicam);
            this.Controls.Add(this.lblNombreMedicam);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cbSecund);
            this.Controls.Add(this.cbPrincip);
            this.Controls.Add(this.rbDist3);
            this.Controls.Add(this.rbDist2);
            this.Controls.Add(this.rbDist1);
            this.Controls.Add(this.txtCantidadMedic);
            this.Controls.Add(this.cbTipoMedic);
            this.Controls.Add(this.txtNombMedicam);
            this.Name = "Form1";
            this.Text = "Pedido en línea";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
