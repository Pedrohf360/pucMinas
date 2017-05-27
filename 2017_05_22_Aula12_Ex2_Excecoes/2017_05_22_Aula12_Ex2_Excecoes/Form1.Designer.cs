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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbVisor = new System.Windows.Forms.TextBox();
            this.btSoma = new System.Windows.Forms.Button();
            this.btSubtracao = new System.Windows.Forms.Button();
            this.btDivisao = new System.Windows.Forms.Button();
            this.btMultiplicacao = new System.Windows.Forms.Button();
            this.btModulo = new System.Windows.Forms.Button();
            this.btIgualdade = new System.Windows.Forms.Button();
            this.btLimpol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbVisor
            // 
            this.tbVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVisor.Location = new System.Drawing.Point(3, 3);
            this.tbVisor.Name = "tbVisor";
            this.tbVisor.Size = new System.Drawing.Size(474, 80);
            this.tbVisor.TabIndex = 0;
            this.tbVisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbVisor.TextChanged += new System.EventHandler(this.MudancaTexto);
            // 
            // btSoma
            // 
            this.btSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoma.Location = new System.Drawing.Point(2, 88);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(119, 53);
            this.btSoma.TabIndex = 1;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click);
            // 
            // btSubtracao
            // 
            this.btSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubtracao.Location = new System.Drawing.Point(127, 88);
            this.btSubtracao.Name = "btSubtracao";
            this.btSubtracao.Size = new System.Drawing.Size(119, 53);
            this.btSubtracao.TabIndex = 2;
            this.btSubtracao.Text = "-";
            this.btSubtracao.UseVisualStyleBackColor = true;
            this.btSubtracao.Click += new System.EventHandler(this.btSubtracao_Click);
            // 
            // btDivisao
            // 
            this.btDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDivisao.Location = new System.Drawing.Point(252, 88);
            this.btDivisao.Name = "btDivisao";
            this.btDivisao.Size = new System.Drawing.Size(119, 53);
            this.btDivisao.TabIndex = 3;
            this.btDivisao.Text = "/";
            this.btDivisao.UseVisualStyleBackColor = true;
            this.btDivisao.Click += new System.EventHandler(this.btDivisao_Click);
            // 
            // btMultiplicacao
            // 
            this.btMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiplicacao.Location = new System.Drawing.Point(2, 146);
            this.btMultiplicacao.Name = "btMultiplicacao";
            this.btMultiplicacao.Size = new System.Drawing.Size(185, 53);
            this.btMultiplicacao.TabIndex = 4;
            this.btMultiplicacao.Text = "X";
            this.btMultiplicacao.UseVisualStyleBackColor = true;
            this.btMultiplicacao.Click += new System.EventHandler(this.btMultiplicacao_Click);
            // 
            // btModulo
            // 
            this.btModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModulo.Location = new System.Drawing.Point(193, 146);
            this.btModulo.Name = "btModulo";
            this.btModulo.Size = new System.Drawing.Size(178, 53);
            this.btModulo.TabIndex = 5;
            this.btModulo.Text = "%";
            this.btModulo.UseVisualStyleBackColor = true;
            this.btModulo.Click += new System.EventHandler(this.btModulo_Click);
            // 
            // btIgualdade
            // 
            this.btIgualdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgualdade.Location = new System.Drawing.Point(377, 87);
            this.btIgualdade.Name = "btIgualdade";
            this.btIgualdade.Size = new System.Drawing.Size(100, 112);
            this.btIgualdade.TabIndex = 6;
            this.btIgualdade.Text = "=";
            this.btIgualdade.UseVisualStyleBackColor = true;
            this.btIgualdade.Click += new System.EventHandler(this.btIgualdade_Click);
            // 
            // btLimpol
            // 
            this.btLimpol.Image = ((System.Drawing.Image)(resources.GetObject("btLimpol.Image")));
            this.btLimpol.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btLimpol.Location = new System.Drawing.Point(481, 3);
            this.btLimpol.Name = "btLimpol";
            this.btLimpol.Size = new System.Drawing.Size(107, 196);
            this.btLimpol.TabIndex = 7;
            this.btLimpol.UseVisualStyleBackColor = true;
            this.btLimpol.Click += new System.EventHandler(this.btLimpol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 202);
            this.Controls.Add(this.btLimpol);
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
        private System.Windows.Forms.Button btLimpol;
    }
}

