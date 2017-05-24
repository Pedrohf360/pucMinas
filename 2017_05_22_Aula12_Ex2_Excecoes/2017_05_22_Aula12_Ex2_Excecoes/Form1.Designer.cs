namespace _2017_05_22_Aula12_Ex2_Excecoes
{
    partial class Form1
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
            this.tbVisor = new System.Windows.Forms.TextBox();
            this.btSoma = new System.Windows.Forms.Button();
            this.btSubtracao = new System.Windows.Forms.Button();
            this.btDivisao = new System.Windows.Forms.Button();
            this.btMultiplicacao = new System.Windows.Forms.Button();
            this.btModulo = new System.Windows.Forms.Button();
            this.btIgualdade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbVisor
            // 
            this.tbVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVisor.Location = new System.Drawing.Point(3, 0);
            this.tbVisor.Name = "tbVisor";
            this.tbVisor.Size = new System.Drawing.Size(474, 80);
            this.tbVisor.TabIndex = 0;
            this.tbVisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbVisor.TextChanged += new System.EventHandler(this.tbVisor_TextChanged);
            // 
            // btSoma
            // 
            this.btSoma.Location = new System.Drawing.Point(12, 86);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(119, 53);
            this.btSoma.TabIndex = 1;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click);
            // 
            // btSubtracao
            // 
            this.btSubtracao.Location = new System.Drawing.Point(137, 86);
            this.btSubtracao.Name = "btSubtracao";
            this.btSubtracao.Size = new System.Drawing.Size(119, 53);
            this.btSubtracao.TabIndex = 2;
            this.btSubtracao.Text = "-";
            this.btSubtracao.UseVisualStyleBackColor = true;
            // 
            // btDivisao
            // 
            this.btDivisao.Location = new System.Drawing.Point(262, 86);
            this.btDivisao.Name = "btDivisao";
            this.btDivisao.Size = new System.Drawing.Size(119, 53);
            this.btDivisao.TabIndex = 3;
            this.btDivisao.Text = "/";
            this.btDivisao.UseVisualStyleBackColor = true;
            // 
            // btMultiplicacao
            // 
            this.btMultiplicacao.Location = new System.Drawing.Point(12, 145);
            this.btMultiplicacao.Name = "btMultiplicacao";
            this.btMultiplicacao.Size = new System.Drawing.Size(185, 53);
            this.btMultiplicacao.TabIndex = 4;
            this.btMultiplicacao.Text = "X";
            this.btMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // btModulo
            // 
            this.btModulo.Location = new System.Drawing.Point(203, 145);
            this.btModulo.Name = "btModulo";
            this.btModulo.Size = new System.Drawing.Size(178, 53);
            this.btModulo.TabIndex = 5;
            this.btModulo.Text = "%";
            this.btModulo.UseVisualStyleBackColor = true;
            // 
            // btIgualdade
            // 
            this.btIgualdade.Location = new System.Drawing.Point(387, 86);
            this.btIgualdade.Name = "btIgualdade";
            this.btIgualdade.Size = new System.Drawing.Size(80, 112);
            this.btIgualdade.TabIndex = 6;
            this.btIgualdade.Text = "=";
            this.btIgualdade.UseVisualStyleBackColor = true;
            this.btIgualdade.Click += new System.EventHandler(this.btIgualdade_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 202);
            this.Controls.Add(this.btIgualdade);
            this.Controls.Add(this.btModulo);
            this.Controls.Add(this.btMultiplicacao);
            this.Controls.Add(this.btDivisao);
            this.Controls.Add(this.btSubtracao);
            this.Controls.Add(this.btSoma);
            this.Controls.Add(this.tbVisor);
            this.Name = "Form1";
            this.Text = "Calculadora - Melhor que a do Windows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVisor;
        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button btSubtracao;
        private System.Windows.Forms.Button btDivisao;
        private System.Windows.Forms.Button btMultiplicacao;
        private System.Windows.Forms.Button btModulo;
        private System.Windows.Forms.Button btIgualdade;
    }
}

