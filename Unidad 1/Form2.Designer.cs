
namespace Unidad_1
{
    partial class Form2
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
            this.pnlMain2 = new System.Windows.Forms.Panel();
            this.boxTemperatura = new System.Windows.Forms.GroupBox();
            this.boxEspacios = new System.Windows.Forms.GroupBox();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.btnTemperatura = new System.Windows.Forms.Button();
            this.txtTemperaturaResult = new System.Windows.Forms.TextBox();
            this.lblEspacios = new System.Windows.Forms.Label();
            this.txtEspacios = new System.Windows.Forms.TextBox();
            this.btnEspacios = new System.Windows.Forms.Button();
            this.txtEspaciosResult = new System.Windows.Forms.TextBox();
            this.pnlMain2.SuspendLayout();
            this.boxTemperatura.SuspendLayout();
            this.boxEspacios.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain2
            // 
            this.pnlMain2.Controls.Add(this.boxEspacios);
            this.pnlMain2.Controls.Add(this.boxTemperatura);
            this.pnlMain2.Location = new System.Drawing.Point(12, 12);
            this.pnlMain2.Name = "pnlMain2";
            this.pnlMain2.Size = new System.Drawing.Size(776, 426);
            this.pnlMain2.TabIndex = 0;
            // 
            // boxTemperatura
            // 
            this.boxTemperatura.BackColor = System.Drawing.SystemColors.Control;
            this.boxTemperatura.Controls.Add(this.txtTemperaturaResult);
            this.boxTemperatura.Controls.Add(this.btnTemperatura);
            this.boxTemperatura.Controls.Add(this.txtTemperatura);
            this.boxTemperatura.Controls.Add(this.lblTemperatura);
            this.boxTemperatura.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTemperatura.Location = new System.Drawing.Point(3, 3);
            this.boxTemperatura.Name = "boxTemperatura";
            this.boxTemperatura.Size = new System.Drawing.Size(381, 420);
            this.boxTemperatura.TabIndex = 0;
            this.boxTemperatura.TabStop = false;
            this.boxTemperatura.Text = "Conversión de Temperatura";
            // 
            // boxEspacios
            // 
            this.boxEspacios.Controls.Add(this.txtEspaciosResult);
            this.boxEspacios.Controls.Add(this.btnEspacios);
            this.boxEspacios.Controls.Add(this.txtEspacios);
            this.boxEspacios.Controls.Add(this.lblEspacios);
            this.boxEspacios.Location = new System.Drawing.Point(390, 3);
            this.boxEspacios.Name = "boxEspacios";
            this.boxEspacios.Size = new System.Drawing.Size(383, 420);
            this.boxEspacios.TabIndex = 1;
            this.boxEspacios.TabStop = false;
            this.boxEspacios.Text = "Contador de espacios";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(4, 32);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(303, 25);
            this.lblTemperatura.TabIndex = 0;
            this.lblTemperatura.Text = "Ingrese una temperatura en °C";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTemperatura.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperatura.Location = new System.Drawing.Point(9, 70);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(217, 27);
            this.txtTemperatura.TabIndex = 1;
            // 
            // btnTemperatura
            // 
            this.btnTemperatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTemperatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemperatura.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemperatura.Location = new System.Drawing.Point(9, 103);
            this.btnTemperatura.Name = "btnTemperatura";
            this.btnTemperatura.Size = new System.Drawing.Size(87, 29);
            this.btnTemperatura.TabIndex = 2;
            this.btnTemperatura.Text = "Convertir";
            this.btnTemperatura.UseVisualStyleBackColor = false;
            this.btnTemperatura.Click += new System.EventHandler(this.btnTemperatura_Click);
            this.btnTemperatura.MouseEnter += new System.EventHandler(this.btnTemperatura_MouseEnter);
            this.btnTemperatura.MouseLeave += new System.EventHandler(this.btnTemperatura_MouseLeave);
            // 
            // txtTemperaturaResult
            // 
            this.txtTemperaturaResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTemperaturaResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTemperaturaResult.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperaturaResult.Location = new System.Drawing.Point(9, 138);
            this.txtTemperaturaResult.Name = "txtTemperaturaResult";
            this.txtTemperaturaResult.ReadOnly = true;
            this.txtTemperaturaResult.Size = new System.Drawing.Size(217, 27);
            this.txtTemperaturaResult.TabIndex = 3;
            // 
            // lblEspacios
            // 
            this.lblEspacios.AutoSize = true;
            this.lblEspacios.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspacios.Location = new System.Drawing.Point(6, 32);
            this.lblEspacios.Name = "lblEspacios";
            this.lblEspacios.Size = new System.Drawing.Size(159, 25);
            this.lblEspacios.TabIndex = 4;
            this.lblEspacios.Text = "Ingrese el texto";
            // 
            // txtEspacios
            // 
            this.txtEspacios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEspacios.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspacios.Location = new System.Drawing.Point(11, 70);
            this.txtEspacios.Multiline = true;
            this.txtEspacios.Name = "txtEspacios";
            this.txtEspacios.Size = new System.Drawing.Size(366, 120);
            this.txtEspacios.TabIndex = 4;
            // 
            // btnEspacios
            // 
            this.btnEspacios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEspacios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspacios.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspacios.Location = new System.Drawing.Point(11, 196);
            this.btnEspacios.Name = "btnEspacios";
            this.btnEspacios.Size = new System.Drawing.Size(154, 29);
            this.btnEspacios.TabIndex = 4;
            this.btnEspacios.Text = "Contar Espacios";
            this.btnEspacios.UseVisualStyleBackColor = false;
            this.btnEspacios.Click += new System.EventHandler(this.btnEspacios_Click);
            this.btnEspacios.MouseEnter += new System.EventHandler(this.btnEspacios_MouseEnter);
            this.btnEspacios.MouseLeave += new System.EventHandler(this.btnEspacios_MouseLeave);
            // 
            // txtEspaciosResult
            // 
            this.txtEspaciosResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEspaciosResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEspaciosResult.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspaciosResult.Location = new System.Drawing.Point(11, 231);
            this.txtEspaciosResult.Name = "txtEspaciosResult";
            this.txtEspaciosResult.ReadOnly = true;
            this.txtEspaciosResult.Size = new System.Drawing.Size(287, 27);
            this.txtEspaciosResult.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.pnlMain2.ResumeLayout(false);
            this.boxTemperatura.ResumeLayout(false);
            this.boxTemperatura.PerformLayout();
            this.boxEspacios.ResumeLayout(false);
            this.boxEspacios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain2;
        private System.Windows.Forms.GroupBox boxEspacios;
        private System.Windows.Forms.GroupBox boxTemperatura;
        private System.Windows.Forms.Button btnTemperatura;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.TextBox txtTemperaturaResult;
        private System.Windows.Forms.TextBox txtEspaciosResult;
        private System.Windows.Forms.Button btnEspacios;
        private System.Windows.Forms.TextBox txtEspacios;
        private System.Windows.Forms.Label lblEspacios;
    }
}