
namespace CajeroAutomatico1.pantallas
{
    partial class Transferencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxIdentDestino = new System.Windows.Forms.TextBox();
            this.txtBxCtaDestino = new System.Windows.Forms.TextBox();
            this.listBxTpCtaDestino = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxIdentOrigen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxCtaOrigen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBxTpCtaOrigen = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de identificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de cuenta\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de cuenta\r\n";
            // 
            // txtBxIdentDestino
            // 
            this.txtBxIdentDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxIdentDestino.Location = new System.Drawing.Point(168, 20);
            this.txtBxIdentDestino.Multiline = true;
            this.txtBxIdentDestino.Name = "txtBxIdentDestino";
            this.txtBxIdentDestino.Size = new System.Drawing.Size(180, 27);
            this.txtBxIdentDestino.TabIndex = 6;
            // 
            // txtBxCtaDestino
            // 
            this.txtBxCtaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCtaDestino.Location = new System.Drawing.Point(168, 56);
            this.txtBxCtaDestino.Multiline = true;
            this.txtBxCtaDestino.Name = "txtBxCtaDestino";
            this.txtBxCtaDestino.Size = new System.Drawing.Size(180, 27);
            this.txtBxCtaDestino.TabIndex = 7;
            // 
            // listBxTpCtaDestino
            // 
            this.listBxTpCtaDestino.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBxTpCtaDestino.FormattingEnabled = true;
            this.listBxTpCtaDestino.ItemHeight = 16;
            this.listBxTpCtaDestino.Items.AddRange(new object[] {
            "Cuenta de Ahorros",
            "Cuenta de Credito "});
            this.listBxTpCtaDestino.Location = new System.Drawing.Point(168, 89);
            this.listBxTpCtaDestino.Name = "listBxTpCtaDestino";
            this.listBxTpCtaDestino.Size = new System.Drawing.Size(180, 36);
            this.listBxTpCtaDestino.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBxIdentDestino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBxCtaDestino);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listBxTpCtaDestino);
            this.groupBox1.Location = new System.Drawing.Point(424, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 142);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta Destino";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBxIdentOrigen);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBxCtaOrigen);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.listBxTpCtaOrigen);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 142);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuenta Origen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Número de identificación";
            // 
            // txtBxIdentOrigen
            // 
            this.txtBxIdentOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxIdentOrigen.Location = new System.Drawing.Point(193, 23);
            this.txtBxIdentOrigen.Multiline = true;
            this.txtBxIdentOrigen.Name = "txtBxIdentOrigen";
            this.txtBxIdentOrigen.Size = new System.Drawing.Size(180, 27);
            this.txtBxIdentOrigen.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "Número de cuenta\r\n";
            // 
            // txtBxCtaOrigen
            // 
            this.txtBxCtaOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxCtaOrigen.Location = new System.Drawing.Point(193, 56);
            this.txtBxCtaOrigen.Multiline = true;
            this.txtBxCtaOrigen.Name = "txtBxCtaOrigen";
            this.txtBxCtaOrigen.Size = new System.Drawing.Size(180, 27);
            this.txtBxCtaOrigen.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de cuenta\r\n";
            // 
            // listBxTpCtaOrigen
            // 
            this.listBxTpCtaOrigen.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBxTpCtaOrigen.FormattingEnabled = true;
            this.listBxTpCtaOrigen.ItemHeight = 16;
            this.listBxTpCtaOrigen.Items.AddRange(new object[] {
            "Cuenta de Ahorros",
            "Cuenta de Credito "});
            this.listBxTpCtaOrigen.Location = new System.Drawing.Point(193, 89);
            this.listBxTpCtaOrigen.Name = "listBxTpCtaOrigen";
            this.listBxTpCtaOrigen.Size = new System.Drawing.Size(180, 36);
            this.listBxTpCtaOrigen.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CajeroAutomatico1.Properties.Resources.Imagenn33;
            this.pictureBox2.Location = new System.Drawing.Point(400, 220);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 153);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = global::CajeroAutomatico1.Properties.Resources.Imagenn25;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(85, 382);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(243, 42);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::CajeroAutomatico1.Properties.Resources.Imagen92;
            this.pictureBox7.Location = new System.Drawing.Point(737, 382);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(41, 42);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CajeroAutomatico1.Properties.Resources.Imagen12;
            this.pictureBox4.Location = new System.Drawing.Point(22, 382);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // btnTransferir
            // 
            this.btnTransferir.BackColor = System.Drawing.Color.Transparent;
            this.btnTransferir.BackgroundImage = global::CajeroAutomatico1.Properties.Resources.Imagenn26;
            this.btnTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferir.ForeColor = System.Drawing.Color.White;
            this.btnTransferir.Location = new System.Drawing.Point(472, 382);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(234, 42);
            this.btnTransferir.TabIndex = 16;
            this.btnTransferir.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CajeroAutomatico1.Properties.Resources.Imagenn32;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 206);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Transferencia";
            this.Text = "Transferencia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxIdentDestino;
        private System.Windows.Forms.TextBox txtBxCtaDestino;
        private System.Windows.Forms.ListBox listBxTpCtaDestino;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxIdentOrigen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxCtaOrigen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBxTpCtaOrigen;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}