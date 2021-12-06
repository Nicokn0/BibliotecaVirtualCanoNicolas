
namespace SolBiblioteca
{
    partial class frmVerListaAutores
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
            this.dgvListaAutores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaAutores
            // 
            this.dgvListaAutores.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dgvListaAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAutores.Location = new System.Drawing.Point(2, 0);
            this.dgvListaAutores.Name = "dgvListaAutores";
            this.dgvListaAutores.Size = new System.Drawing.Size(529, 279);
            this.dgvListaAutores.TabIndex = 0;
            // 
            // frmVerListaAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 279);
            this.Controls.Add(this.dgvListaAutores);
            this.Name = "frmVerListaAutores";
            this.Text = "frmVerAutores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAutores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaAutores;
    }
}