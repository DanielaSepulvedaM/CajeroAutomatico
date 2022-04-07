
namespace CajeroAutomatico1.pantallas
{
    partial class ConfirmacionRetiro
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVlrRetirado = new System.Windows.Forms.Label();
            this.lblCostoTransaccion = new System.Windows.Forms.Label();
            this.lblTotalRetiro = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CajeroAutomatico1.Properties.Resources.Imagenn46;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 331);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblVlrRetirado
            // 
            this.lblVlrRetirado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVlrRetirado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrRetirado.Location = new System.Drawing.Point(552, 179);
            this.lblVlrRetirado.Name = "lblVlrRetirado";
            this.lblVlrRetirado.Size = new System.Drawing.Size(120, 25);
            this.lblVlrRetirado.TabIndex = 1;
            this.lblVlrRetirado.Text = "$ 20.000,00";
            // 
            // lblCostoTransaccion
            // 
            this.lblCostoTransaccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCostoTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTransaccion.Location = new System.Drawing.Point(552, 217);
            this.lblCostoTransaccion.Name = "lblCostoTransaccion";
            this.lblCostoTransaccion.Size = new System.Drawing.Size(120, 25);
            this.lblCostoTransaccion.TabIndex = 2;
            this.lblCostoTransaccion.Text = "$ 00,00";
            // 
            // lblTotalRetiro
            // 
            this.lblTotalRetiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRetiro.Location = new System.Drawing.Point(552, 276);
            this.lblTotalRetiro.Name = "lblTotalRetiro";
            this.lblTotalRetiro.Size = new System.Drawing.Size(120, 25);
            this.lblTotalRetiro.TabIndex = 3;
            this.lblTotalRetiro.Text = "$ 20.000,00";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::CajeroAutomatico1.Properties.Resources.Imagen92;
            this.pictureBox8.Location = new System.Drawing.Point(37, 369);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(41, 39);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 31;
            this.pictureBox8.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::CajeroAutomatico1.Properties.Resources.Imagenn45;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(97, 366);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(243, 42);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // ConfirmacionRetiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTotalRetiro);
            this.Controls.Add(this.lblCostoTransaccion);
            this.Controls.Add(this.lblVlrRetirado);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ConfirmacionRetiro";
            this.Size = new System.Drawing.Size(985, 560);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVlrRetirado;
        private System.Windows.Forms.Label lblCostoTransaccion;
        private System.Windows.Forms.Label lblTotalRetiro;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button btnSalir;
    }
}
