
namespace SolBiblioteca
{
    partial class frmAltaPais
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
            this.components = new System.ComponentModel.Container();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.txtpais = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgwPais = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPais)).BeginInit();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.LawnGreen;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(231, 304);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(155, 66);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "SALIR";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.LawnGreen;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(27, 304);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(158, 64);
            this.btn.TabIndex = 6;
            this.btn.Text = "CONFIRMAR";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtpais
            // 
            this.txtpais.BackColor = System.Drawing.Color.LightYellow;
            this.txtpais.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpais.Location = new System.Drawing.Point(261, 81);
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(225, 40);
            this.txtpais.TabIndex = 5;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.YellowGreen;
            this.lbl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(17, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(308, 43);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "AGREGAR PAÍS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ingrese Nombre País :";
            // 
            // dgwPais
            // 
            this.dgwPais.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.dgwPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPais.Location = new System.Drawing.Point(25, 141);
            this.dgwPais.Name = "dgwPais";
            this.dgwPais.Size = new System.Drawing.Size(409, 139);
            this.dgwPais.TabIndex = 40;
            // 
            // frmAltaPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(505, 377);
            this.Controls.Add(this.dgwPais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtpais);
            this.Controls.Add(this.lbl1);
            this.Name = "frmAltaPais";
            this.Text = "Alta País";
            ((System.ComponentModel.ISupportInitialize)(this.dgwPais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgwPais;
    }
}