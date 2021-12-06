
namespace SolBiblioteca
{
    partial class frmVerListaEditoriales
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
            this.dtgListaAutores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListaAutores
            // 
            this.dtgListaAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaAutores.Location = new System.Drawing.Point(0, 3);
            this.dtgListaAutores.Name = "dtgListaAutores";
            this.dtgListaAutores.Size = new System.Drawing.Size(513, 221);
            this.dtgListaAutores.TabIndex = 0;
            // 
            // frmVerListaEditoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 236);
            this.Controls.Add(this.dtgListaAutores);
            this.Name = "frmVerListaEditoriales";
            this.Text = "Lista Editoriales";
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaAutores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListaAutores;
    }
}