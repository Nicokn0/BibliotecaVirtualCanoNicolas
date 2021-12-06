
namespace SolBiblioteca
{
    partial class frmAltaEditorial
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
            this.btn2 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.txtnomedi = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwEditorial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEditorial)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn2.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(232, 310);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(141, 46);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "SALIR";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(38, 310);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(147, 46);
            this.btn.TabIndex = 6;
            this.btn.Text = "CONFIRMAR";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtnomedi
            // 
            this.txtnomedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomedi.Location = new System.Drawing.Point(298, 83);
            this.txtnomedi.Name = "txtnomedi";
            this.txtnomedi.Size = new System.Drawing.Size(203, 40);
            this.txtnomedi.TabIndex = 5;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(-3, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(432, 43);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "AGREGAR  EDITORIAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Agregar Nombre Editorial:";
            // 
            // dgwEditorial
            // 
            this.dgwEditorial.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwEditorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEditorial.Location = new System.Drawing.Point(37, 142);
            this.dgwEditorial.Name = "dgwEditorial";
            this.dgwEditorial.Size = new System.Drawing.Size(345, 150);
            this.dgwEditorial.TabIndex = 50;
            // 
            // frmAltaEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(509, 373);
            this.Controls.Add(this.dgwEditorial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtnomedi);
            this.Controls.Add(this.lbl1);
            this.Name = "frmAltaEditorial";
            this.Text = "Alta Editorial";
            ((System.ComponentModel.ISupportInitialize)(this.dgwEditorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txtnomedi;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwEditorial;
    }
}