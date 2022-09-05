
namespace SistemaGestorDeDocentes
{
    partial class FrmColegio
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
            this.AbreviaCol = new System.Windows.Forms.Label();
            this.TxtNombreColegio = new System.Windows.Forms.TextBox();
            this.txtAbreviaturaColegio = new System.Windows.Forms.TextBox();
            this.DgvColegio = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvColegio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Colegio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Colegio:";
            // 
            // AbreviaCol
            // 
            this.AbreviaCol.AutoSize = true;
            this.AbreviaCol.Location = new System.Drawing.Point(63, 139);
            this.AbreviaCol.Name = "AbreviaCol";
            this.AbreviaCol.Size = new System.Drawing.Size(124, 13);
            this.AbreviaCol.TabIndex = 1;
            this.AbreviaCol.Text = "Abreviatura Colegio:";
            // 
            // TxtNombreColegio
            // 
            this.TxtNombreColegio.Location = new System.Drawing.Point(192, 98);
            this.TxtNombreColegio.Name = "TxtNombreColegio";
            this.TxtNombreColegio.Size = new System.Drawing.Size(116, 21);
            this.TxtNombreColegio.TabIndex = 2;
            // 
            // txtAbreviaturaColegio
            // 
            this.txtAbreviaturaColegio.Location = new System.Drawing.Point(192, 136);
            this.txtAbreviaturaColegio.Name = "txtAbreviaturaColegio";
            this.txtAbreviaturaColegio.Size = new System.Drawing.Size(116, 21);
            this.txtAbreviaturaColegio.TabIndex = 2;
            // 
            // DgvColegio
            // 
            this.DgvColegio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvColegio.Location = new System.Drawing.Point(462, 136);
            this.DgvColegio.Name = "DgvColegio";
            this.DgvColegio.Size = new System.Drawing.Size(295, 186);
            this.DgvColegio.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(338, 167);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(338, 244);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 23);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(338, 205);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(338, 282);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // FrmColegio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 400);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.DgvColegio);
            this.Controls.Add(this.txtAbreviaturaColegio);
            this.Controls.Add(this.TxtNombreColegio);
            this.Controls.Add(this.AbreviaCol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("PlutoSansW04-Bold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmColegio";
            this.Text = "Colegio";
            ((System.ComponentModel.ISupportInitialize)(this.DgvColegio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AbreviaCol;
        private System.Windows.Forms.TextBox TxtNombreColegio;
        private System.Windows.Forms.TextBox txtAbreviaturaColegio;
        private System.Windows.Forms.DataGridView DgvColegio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}