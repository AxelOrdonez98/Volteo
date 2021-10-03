
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
            this.btn_Voltear = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_recipiente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Pass_Fail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Cadena_A_Voltear
            // 
            this.txt_Cadena_A_Voltear.Location = new System.Drawing.Point(12, 100);
            this.txt_Cadena_A_Voltear.Name = "txt_Cadena_A_Voltear";
            this.txt_Cadena_A_Voltear.Size = new System.Drawing.Size(290, 20);
            this.txt_Cadena_A_Voltear.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "1.- Copiar y pegar la cadena que se requieren voltear.\r\n2.- Introducir la ruta pa" +
    "ra guardar.\r\n3.- La cadena debe estar separada con: (,)(-)(_)( )\r\n4.- Dar en el " +
    "boton \"Voltear\".";
            // 
            // btn_Voltear
            // 
            this.btn_Voltear.Location = new System.Drawing.Point(12, 167);
            this.btn_Voltear.Name = "btn_Voltear";
            this.btn_Voltear.Size = new System.Drawing.Size(124, 23);
            this.btn_Voltear.TabIndex = 3;
            this.btn_Voltear.Text = "Voltear";
            this.btn_Voltear.UseVisualStyleBackColor = true;
            this.btn_Voltear.Click += new System.EventHandler(this.btn_Voltear_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(178, 167);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(124, 23);
            this.btn_Limpiar.TabIndex = 5;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cadena:";
            // 
            // txtb_recipiente
            // 
            this.txtb_recipiente.Location = new System.Drawing.Point(12, 141);
            this.txtb_recipiente.Name = "txtb_recipiente";
            this.txtb_recipiente.Size = new System.Drawing.Size(290, 20);
            this.txtb_recipiente.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ruta:";
            // 
            // lb_Pass_Fail
            // 
            this.lb_Pass_Fail.AutoSize = true;
            this.lb_Pass_Fail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pass_Fail.Location = new System.Drawing.Point(121, 214);
            this.lb_Pass_Fail.Name = "lb_Pass_Fail";
            this.lb_Pass_Fail.Size = new System.Drawing.Size(0, 15);
            this.lb_Pass_Fail.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(314, 260);
            this.Controls.Add(this.lb_Pass_Fail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb_recipiente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Voltear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Cadena_A_Voltear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AE - Flip";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Cadena_A_Voltear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Voltear;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_recipiente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Pass_Fail;
    }
}

