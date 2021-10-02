
namespace Volteo_De_Cadenas_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_Cadena_A_Voltear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Respuesta = new System.Windows.Forms.Label();
            this.btn_Voltear = new System.Windows.Forms.Button();
            this.ltsb_Respuesta = new System.Windows.Forms.ListBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Cadena_A_Voltear
            // 
            this.txt_Cadena_A_Voltear.Location = new System.Drawing.Point(60, 53);
            this.txt_Cadena_A_Voltear.Name = "txt_Cadena_A_Voltear";
            this.txt_Cadena_A_Voltear.Size = new System.Drawing.Size(174, 20);
            this.txt_Cadena_A_Voltear.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "1.- Copiar y pegar la cadena que se requieren voltear. \r\n2.- La cadena debe estar" +
    " separada con: (,)(.)(-)(_)( )\r\n2.- Dar en el boton \"Voltear\".";
            // 
            // lb_Respuesta
            // 
            this.lb_Respuesta.AutoSize = true;
            this.lb_Respuesta.Location = new System.Drawing.Point(9, 127);
            this.lb_Respuesta.Name = "lb_Respuesta";
            this.lb_Respuesta.Size = new System.Drawing.Size(0, 13);
            this.lb_Respuesta.TabIndex = 2;
            // 
            // btn_Voltear
            // 
            this.btn_Voltear.Location = new System.Drawing.Point(60, 79);
            this.btn_Voltear.Name = "btn_Voltear";
            this.btn_Voltear.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltear.TabIndex = 3;
            this.btn_Voltear.Text = "Voltear";
            this.btn_Voltear.UseVisualStyleBackColor = true;
            this.btn_Voltear.Click += new System.EventHandler(this.btn_Voltear_Click);
            // 
            // ltsb_Respuesta
            // 
            this.ltsb_Respuesta.FormattingEnabled = true;
            this.ltsb_Respuesta.Location = new System.Drawing.Point(15, 108);
            this.ltsb_Respuesta.Name = "ltsb_Respuesta";
            this.ltsb_Respuesta.Size = new System.Drawing.Size(271, 329);
            this.ltsb_Respuesta.TabIndex = 4;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(159, 79);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 5;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 450);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.ltsb_Respuesta);
            this.Controls.Add(this.btn_Voltear);
            this.Controls.Add(this.lb_Respuesta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Cadena_A_Voltear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AE - Voltear valores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Cadena_A_Voltear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Respuesta;
        private System.Windows.Forms.Button btn_Voltear;
        private System.Windows.Forms.ListBox ltsb_Respuesta;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}

