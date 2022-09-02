
namespace SistemaGestorDeDocentes
{
    partial class FrmZonaGeografica
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
            this.TbZonaGeografica = new System.Windows.Forms.TabControl();
            this.TbAldea = new System.Windows.Forms.TabPage();
            this.TbMunicipio = new System.Windows.Forms.TabPage();
            this.TbDepartamento = new System.Windows.Forms.TabPage();
            this.TbZonaGeografica.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zona Geográfica";
            // 
            // TbZonaGeografica
            // 
            this.TbZonaGeografica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbZonaGeografica.Controls.Add(this.TbAldea);
            this.TbZonaGeografica.Controls.Add(this.TbMunicipio);
            this.TbZonaGeografica.Controls.Add(this.TbDepartamento);
            this.TbZonaGeografica.Location = new System.Drawing.Point(99, 85);
            this.TbZonaGeografica.Name = "TbZonaGeografica";
            this.TbZonaGeografica.SelectedIndex = 0;
            this.TbZonaGeografica.Size = new System.Drawing.Size(494, 204);
            this.TbZonaGeografica.TabIndex = 1;
            // 
            // TbAldea
            // 
            this.TbAldea.Location = new System.Drawing.Point(4, 22);
            this.TbAldea.Name = "TbAldea";
            this.TbAldea.Padding = new System.Windows.Forms.Padding(3);
            this.TbAldea.Size = new System.Drawing.Size(486, 178);
            this.TbAldea.TabIndex = 0;
            this.TbAldea.Text = "Aldea";
            this.TbAldea.UseVisualStyleBackColor = true;
            // 
            // TbMunicipio
            // 
            this.TbMunicipio.Location = new System.Drawing.Point(4, 22);
            this.TbMunicipio.Name = "TbMunicipio";
            this.TbMunicipio.Padding = new System.Windows.Forms.Padding(3);
            this.TbMunicipio.Size = new System.Drawing.Size(486, 178);
            this.TbMunicipio.TabIndex = 1;
            this.TbMunicipio.Text = "Municipio";
            this.TbMunicipio.UseVisualStyleBackColor = true;
            // 
            // TbDepartamento
            // 
            this.TbDepartamento.Location = new System.Drawing.Point(4, 22);
            this.TbDepartamento.Name = "TbDepartamento";
            this.TbDepartamento.Padding = new System.Windows.Forms.Padding(3);
            this.TbDepartamento.Size = new System.Drawing.Size(486, 178);
            this.TbDepartamento.TabIndex = 2;
            this.TbDepartamento.Text = "Departamento";
            this.TbDepartamento.UseVisualStyleBackColor = true;
            // 
            // FrmZonaGeografica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.TbZonaGeografica);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmZonaGeografica";
            this.Text = "FrmZonaGeografica";
            this.TbZonaGeografica.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TbZonaGeografica;
        private System.Windows.Forms.TabPage TbAldea;
        private System.Windows.Forms.TabPage TbMunicipio;
        private System.Windows.Forms.TabPage TbDepartamento;
    }
}