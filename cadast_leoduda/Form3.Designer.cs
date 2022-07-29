namespace cadast_leoduda
{
    partial class Form3
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
            this.btnexibir = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidadealun = new System.Windows.Forms.TextBox();
            this.txtcursoalu = new System.Windows.Forms.TextBox();
            this.txtnomealun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexibir
            // 
            this.btnexibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnexibir.Location = new System.Drawing.Point(159, 225);
            this.btnexibir.Name = "btnexibir";
            this.btnexibir.Size = new System.Drawing.Size(111, 35);
            this.btnexibir.TabIndex = 17;
            this.btnexibir.Text = "Exibir";
            this.btnexibir.UseVisualStyleBackColor = true;
            this.btnexibir.Click += new System.EventHandler(this.btnexibir_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnvoltar.Location = new System.Drawing.Point(289, 225);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(111, 35);
            this.btnvoltar.TabIndex = 16;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(121, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(121, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Curso";
            // 
            // txtidadealun
            // 
            this.txtidadealun.Location = new System.Drawing.Point(212, 86);
            this.txtidadealun.Multiline = true;
            this.txtidadealun.Name = "txtidadealun";
            this.txtidadealun.Size = new System.Drawing.Size(122, 28);
            this.txtidadealun.TabIndex = 13;
            // 
            // txtcursoalu
            // 
            this.txtcursoalu.Location = new System.Drawing.Point(212, 123);
            this.txtcursoalu.Multiline = true;
            this.txtcursoalu.Name = "txtcursoalu";
            this.txtcursoalu.Size = new System.Drawing.Size(122, 28);
            this.txtcursoalu.TabIndex = 12;
            // 
            // txtnomealun
            // 
            this.txtnomealun.Location = new System.Drawing.Point(212, 49);
            this.txtnomealun.Multiline = true;
            this.txtnomealun.Name = "txtnomealun";
            this.txtnomealun.Size = new System.Drawing.Size(122, 28);
            this.txtnomealun.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome";
            // 
            // btncad
            // 
            this.btncad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btncad.Location = new System.Drawing.Point(29, 225);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(111, 35);
            this.btncad.TabIndex = 9;
            this.btncad.Text = "Cadastrar";
            this.btncad.UseVisualStyleBackColor = true;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 336);
            this.Controls.Add(this.btnexibir);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidadealun);
            this.Controls.Add(this.txtcursoalu);
            this.Controls.Add(this.txtnomealun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncad);
            this.Name = "Form3";
            this.Text = "Cadastrar Aluno";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexibir;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidadealun;
        private System.Windows.Forms.TextBox txtcursoalu;
        private System.Windows.Forms.TextBox txtnomealun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncad;
    }
}