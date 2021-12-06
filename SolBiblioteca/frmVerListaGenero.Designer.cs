
namespace SolBiblioteca
{
    partial class frmVerListaGenero
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
            this.dgwGenero = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwGenero
            // 
            this.dgwGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGenero.Location = new System.Drawing.Point(12, 32);
            this.dgwGenero.Name = "dgwGenero";
            this.dgwGenero.Size = new System.Drawing.Size(514, 149);
            this.dgwGenero.TabIndex = 0;
            // 
            // frmVerListaGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 198);
            this.Controls.Add(this.dgwGenero);
            this.Name = "frmVerListaGenero";
            this.Text = "Lista Genero";
            ((System.ComponentModel.ISupportInitialize)(this.dgwGenero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwGenero;
    }
}