namespace Ejercicioo.Presentacion
{
    partial class FormMenu
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
            this.btn_AltaUuario = new System.Windows.Forms.Button();
            this.btn_BajaUsuario = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AltaUuario
            // 
            this.btn_AltaUuario.Location = new System.Drawing.Point(89, 106);
            this.btn_AltaUuario.Name = "btn_AltaUuario";
            this.btn_AltaUuario.Size = new System.Drawing.Size(75, 23);
            this.btn_AltaUuario.TabIndex = 0;
            this.btn_AltaUuario.Text = "Alta Usuario";
            this.btn_AltaUuario.UseVisualStyleBackColor = true;
            this.btn_AltaUuario.Click += new System.EventHandler(this.btn_AltaUuario_Click);
            // 
            // btn_BajaUsuario
            // 
            this.btn_BajaUsuario.Location = new System.Drawing.Point(89, 135);
            this.btn_BajaUsuario.Name = "btn_BajaUsuario";
            this.btn_BajaUsuario.Size = new System.Drawing.Size(75, 23);
            this.btn_BajaUsuario.TabIndex = 1;
            this.btn_BajaUsuario.Text = "Baja Usuario";
            this.btn_BajaUsuario.UseVisualStyleBackColor = true;
            this.btn_BajaUsuario.Click += new System.EventHandler(this.btn_BajaUsuario_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(89, 164);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "MENU";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 206);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_BajaUsuario);
            this.Controls.Add(this.btn_AltaUuario);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AltaUuario;
        private System.Windows.Forms.Button btn_BajaUsuario;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label label1;
    }
}