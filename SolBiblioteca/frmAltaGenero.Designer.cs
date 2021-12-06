
namespace SolBiblioteca
{
    partial class frmAltaGenero
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtgenero = new System.Windows.Forms.TextBox();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.dgwGenero = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(1, 22);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(382, 43);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "AGREGAR GENERO";
            // 
            // txtgenero
            // 
            this.txtgenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgenero.Location = new System.Drawing.Point(203, 90);
            this.txtgenero.Name = "txtgenero";
            this.txtgenero.Size = new System.Drawing.Size(231, 40);
            this.txtgenero.TabIndex = 1;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnconfirmar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirmar.Location = new System.Drawing.Point(39, 270);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(148, 64);
            this.btnconfirmar.TabIndex = 2;
            this.btnconfirmar.Text = "CONFIRMAR";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.GreenYellow;
            this.btn2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(238, 270);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(145, 66);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "SALIR";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // dgwGenero
            // 
            this.dgwGenero.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.dgwGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGenero.Location = new System.Drawing.Point(41, 148);
            this.dgwGenero.Name = "dgwGenero";
            this.dgwGenero.Size = new System.Drawing.Size(372, 116);
            this.dgwGenero.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 28);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ingrese Genero :";
            // 
            // frmAltaGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(454, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwGenero);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.txtgenero);
            this.Controls.Add(this.lbl1);
            this.Name = "frmAltaGenero";
            this.Text = "Alta Genero";
            ((System.ComponentModel.ISupportInitialize)(this.dgwGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtgenero;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.DataGridView dgwGenero;
        private System.Windows.Forms.Label label1;
    }
}