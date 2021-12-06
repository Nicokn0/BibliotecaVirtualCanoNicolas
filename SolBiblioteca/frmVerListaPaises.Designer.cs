
namespace SolBiblioteca
{
    partial class frmVerListaPaises
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
            this.dgwPaises = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPaises)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwPaises
            // 
            this.dgwPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPaises.Location = new System.Drawing.Point(12, 12);
            this.dgwPaises.Name = "dgwPaises";
            this.dgwPaises.Size = new System.Drawing.Size(360, 148);
            this.dgwPaises.TabIndex = 0;
            // 
            // frmVerListaPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 195);
            this.Controls.Add(this.dgwPaises);
            this.Name = "frmVerListaPaises";
            this.Text = "frmVerListaPaises";
            ((System.ComponentModel.ISupportInitialize)(this.dgwPaises)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPaises;
    }
}