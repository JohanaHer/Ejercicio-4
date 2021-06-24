
namespace Ejercicio_4
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.cb_datos = new System.Windows.Forms.ComboBox();
            this.btn_descendente = new System.Windows.Forms.Button();
            this.btn_ascendente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(154, 91);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(198, 22);
            this.txt_nombre.TabIndex = 0;
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(154, 166);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(100, 22);
            this.txt_edad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edad";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(154, 239);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(110, 56);
            this.btn_ingresar.TabIndex = 4;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // cb_datos
            // 
            this.cb_datos.FormattingEnabled = true;
            this.cb_datos.Location = new System.Drawing.Point(430, 88);
            this.cb_datos.Name = "cb_datos";
            this.cb_datos.Size = new System.Drawing.Size(138, 24);
            this.cb_datos.TabIndex = 5;
            // 
            // btn_descendente
            // 
            this.btn_descendente.Location = new System.Drawing.Point(562, 259);
            this.btn_descendente.Name = "btn_descendente";
            this.btn_descendente.Size = new System.Drawing.Size(110, 56);
            this.btn_descendente.TabIndex = 6;
            this.btn_descendente.Text = "Descendente";
            this.btn_descendente.UseVisualStyleBackColor = true;
            this.btn_descendente.Click += new System.EventHandler(this.btn_descendente_Click);
            // 
            // btn_ascendente
            // 
            this.btn_ascendente.Location = new System.Drawing.Point(420, 259);
            this.btn_ascendente.Name = "btn_ascendente";
            this.btn_ascendente.Size = new System.Drawing.Size(110, 56);
            this.btn_ascendente.TabIndex = 7;
            this.btn_ascendente.Text = "Ascendente";
            this.btn_ascendente.UseVisualStyleBackColor = true;
            this.btn_ascendente.Click += new System.EventHandler(this.btn_ascendente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ascendente);
            this.Controls.Add(this.btn_descendente);
            this.Controls.Add(this.cb_datos);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.ComboBox cb_datos;
        private System.Windows.Forms.Button btn_descendente;
        private System.Windows.Forms.Button btn_ascendente;
    }
}

