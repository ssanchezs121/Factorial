namespace CalculoFactorial
{
    partial class Form1
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
            this.txtValordeIngreso = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValordeIngreso
            // 
            this.txtValordeIngreso.Location = new System.Drawing.Point(76, 53);
            this.txtValordeIngreso.Name = "txtValordeIngreso";
            this.txtValordeIngreso.Size = new System.Drawing.Size(133, 22);
            this.txtValordeIngreso.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(25, 114);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 35);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(73, 174);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(179, 193);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 36);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValordeIngreso);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValordeIngreso;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSalir;
    }
}

