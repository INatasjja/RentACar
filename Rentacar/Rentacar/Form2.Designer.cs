namespace Rentacar
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
            this.CriterioCliente = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AddCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.EditCliente = new System.Windows.Forms.Button();
            this.DeleteCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // CriterioCliente
            // 
            this.CriterioCliente.AutoSize = true;
            this.CriterioCliente.Location = new System.Drawing.Point(32, 26);
            this.CriterioCliente.Name = "CriterioCliente";
            this.CriterioCliente.Size = new System.Drawing.Size(53, 17);
            this.CriterioCliente.TabIndex = 0;
            this.CriterioCliente.Text = "Criterio";
            this.CriterioCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(35, 78);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(480, 233);
            this.dgvClientes.TabIndex = 1;
            // 
            // AddCliente
            // 
            this.AddCliente.Location = new System.Drawing.Point(320, 20);
            this.AddCliente.Name = "AddCliente";
            this.AddCliente.Size = new System.Drawing.Size(53, 23);
            this.AddCliente.TabIndex = 2;
            this.AddCliente.Text = "button1";
            this.AddCliente.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(103, 21);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(193, 22);
            this.txtCliente.TabIndex = 5;
            // 
            // EditCliente
            // 
            this.EditCliente.Location = new System.Drawing.Point(379, 20);
            this.EditCliente.Name = "EditCliente";
            this.EditCliente.Size = new System.Drawing.Size(53, 23);
            this.EditCliente.TabIndex = 6;
            this.EditCliente.Text = "button2";
            this.EditCliente.UseVisualStyleBackColor = true;
            // 
            // DeleteCliente
            // 
            this.DeleteCliente.Location = new System.Drawing.Point(438, 20);
            this.DeleteCliente.Name = "DeleteCliente";
            this.DeleteCliente.Size = new System.Drawing.Size(53, 23);
            this.DeleteCliente.TabIndex = 7;
            this.DeleteCliente.Text = "button3";
            this.DeleteCliente.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteCliente);
            this.Controls.Add(this.EditCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.AddCliente);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.CriterioCliente);
            this.Name = "Form2";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CriterioCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button AddCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button EditCliente;
        private System.Windows.Forms.Button DeleteCliente;
    }
}