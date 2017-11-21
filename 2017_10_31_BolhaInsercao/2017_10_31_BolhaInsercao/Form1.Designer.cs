namespace _2017_10_31_BolhaInsercao
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
            this.tituloLbl = new System.Windows.Forms.Label();
            this.gerarVetorBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.vetAleatChckB = new System.Windows.Forms.CheckBox();
            this.quaseOrdChckB = new System.Windows.Forms.CheckBox();
            this.vetDecrescChckB = new System.Windows.Forms.CheckBox();
            this.vetCrescChckB = new System.Windows.Forms.CheckBox();
            this.insercaoBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selecaoBtn = new System.Windows.Forms.Button();
            this.bolhaBtn = new System.Windows.Forms.Button();
            this.quickBtn = new System.Windows.Forms.Button();
            this.mergeBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloLbl
            // 
            this.tituloLbl.AutoSize = true;
            this.tituloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLbl.Location = new System.Drawing.Point(9, 14);
            this.tituloLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloLbl.Name = "tituloLbl";
            this.tituloLbl.Size = new System.Drawing.Size(161, 36);
            this.tituloLbl.TabIndex = 1;
            this.tituloLbl.Text = "Ordenação";
            // 
            // gerarVetorBtn
            // 
            this.gerarVetorBtn.BackColor = System.Drawing.Color.Red;
            this.gerarVetorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerarVetorBtn.Location = new System.Drawing.Point(172, 164);
            this.gerarVetorBtn.Margin = new System.Windows.Forms.Padding(4);
            this.gerarVetorBtn.Name = "gerarVetorBtn";
            this.gerarVetorBtn.Size = new System.Drawing.Size(199, 113);
            this.gerarVetorBtn.TabIndex = 4;
            this.gerarVetorBtn.Text = "Gerar Vetor";
            this.gerarVetorBtn.UseVisualStyleBackColor = false;
            this.gerarVetorBtn.Click += new System.EventHandler(this.gerarVetorBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "THE BIG RED BUTTON";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(27, 337);
            this.listBox.Margin = new System.Windows.Forms.Padding(4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(320, 260);
            this.listBox.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(361, 337);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(320, 260);
            this.listBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "VETOR DESORDENADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "VETOR ORDENADO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(533, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "-";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(559, 71);
            this.maskedTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox3.Mask = "0000000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(65, 22);
            this.maskedTextBox3.TabIndex = 21;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(459, 71);
            this.maskedTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox4.Mask = "0000000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(65, 22);
            this.maskedTextBox4.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(362, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "INFORME O INTERVALO (ATÉ 1.600.000)";
            // 
            // vetAleatChckB
            // 
            this.vetAleatChckB.AutoSize = true;
            this.vetAleatChckB.Location = new System.Drawing.Point(7, 103);
            this.vetAleatChckB.Margin = new System.Windows.Forms.Padding(4);
            this.vetAleatChckB.Name = "vetAleatChckB";
            this.vetAleatChckB.Size = new System.Drawing.Size(86, 21);
            this.vetAleatChckB.TabIndex = 26;
            this.vetAleatChckB.Text = "Aleatório";
            this.vetAleatChckB.UseVisualStyleBackColor = true;
            this.vetAleatChckB.CheckedChanged += new System.EventHandler(this.vetAleatChckB_CheckedChanged);
            // 
            // quaseOrdChckB
            // 
            this.quaseOrdChckB.AutoSize = true;
            this.quaseOrdChckB.Location = new System.Drawing.Point(7, 74);
            this.quaseOrdChckB.Margin = new System.Windows.Forms.Padding(4);
            this.quaseOrdChckB.Name = "quaseOrdChckB";
            this.quaseOrdChckB.Size = new System.Drawing.Size(140, 21);
            this.quaseOrdChckB.TabIndex = 25;
            this.quaseOrdChckB.Text = "Quase Ordenado";
            this.quaseOrdChckB.UseVisualStyleBackColor = true;
            this.quaseOrdChckB.CheckedChanged += new System.EventHandler(this.quaseOrdChckB_CheckedChanged);
            // 
            // vetDecrescChckB
            // 
            this.vetDecrescChckB.AutoSize = true;
            this.vetDecrescChckB.Location = new System.Drawing.Point(7, 44);
            this.vetDecrescChckB.Margin = new System.Windows.Forms.Padding(4);
            this.vetDecrescChckB.Name = "vetDecrescChckB";
            this.vetDecrescChckB.Size = new System.Drawing.Size(110, 21);
            this.vetDecrescChckB.TabIndex = 24;
            this.vetDecrescChckB.Text = "Decrescente";
            this.vetDecrescChckB.UseVisualStyleBackColor = true;
            this.vetDecrescChckB.CheckedChanged += new System.EventHandler(this.vetDecrescChckB_CheckedChanged);
            // 
            // vetCrescChckB
            // 
            this.vetCrescChckB.AutoSize = true;
            this.vetCrescChckB.Location = new System.Drawing.Point(7, 16);
            this.vetCrescChckB.Margin = new System.Windows.Forms.Padding(4);
            this.vetCrescChckB.Name = "vetCrescChckB";
            this.vetCrescChckB.Size = new System.Drawing.Size(94, 21);
            this.vetCrescChckB.TabIndex = 23;
            this.vetCrescChckB.Text = "Crescente";
            this.vetCrescChckB.UseVisualStyleBackColor = true;
            this.vetCrescChckB.CheckedChanged += new System.EventHandler(this.vetCrescChckB_CheckedChanged);
            // 
            // insercaoBtn
            // 
            this.insercaoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insercaoBtn.Location = new System.Drawing.Point(380, 166);
            this.insercaoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.insercaoBtn.Name = "insercaoBtn";
            this.insercaoBtn.Size = new System.Drawing.Size(105, 50);
            this.insercaoBtn.TabIndex = 28;
            this.insercaoBtn.Text = "Inserção";
            this.insercaoBtn.UseVisualStyleBackColor = true;
            this.insercaoBtn.Click += new System.EventHandler(this.insercaoBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quaseOrdChckB);
            this.groupBox1.Controls.Add(this.vetCrescChckB);
            this.groupBox1.Controls.Add(this.vetDecrescChckB);
            this.groupBox1.Controls.Add(this.vetAleatChckB);
            this.groupBox1.Location = new System.Drawing.Point(13, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(151, 134);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // selecaoBtn
            // 
            this.selecaoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecaoBtn.Location = new System.Drawing.Point(378, 224);
            this.selecaoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.selecaoBtn.Name = "selecaoBtn";
            this.selecaoBtn.Size = new System.Drawing.Size(107, 49);
            this.selecaoBtn.TabIndex = 27;
            this.selecaoBtn.Text = "Seleção";
            this.selecaoBtn.UseVisualStyleBackColor = true;
            this.selecaoBtn.Click += new System.EventHandler(this.selecaoBtn_Click);
            // 
            // bolhaBtn
            // 
            this.bolhaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bolhaBtn.Location = new System.Drawing.Point(493, 166);
            this.bolhaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.bolhaBtn.Name = "bolhaBtn";
            this.bolhaBtn.Size = new System.Drawing.Size(105, 50);
            this.bolhaBtn.TabIndex = 31;
            this.bolhaBtn.Text = "Bolha";
            this.bolhaBtn.UseVisualStyleBackColor = true;
            this.bolhaBtn.Click += new System.EventHandler(this.bolhaBtn_Click);
            // 
            // quickBtn
            // 
            this.quickBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickBtn.Location = new System.Drawing.Point(491, 224);
            this.quickBtn.Margin = new System.Windows.Forms.Padding(4);
            this.quickBtn.Name = "quickBtn";
            this.quickBtn.Size = new System.Drawing.Size(107, 49);
            this.quickBtn.TabIndex = 30;
            this.quickBtn.Text = "Quick ";
            this.quickBtn.UseVisualStyleBackColor = true;
            this.quickBtn.Click += new System.EventHandler(this.quickBtn_Click);
            // 
            // mergeBtn
            // 
            this.mergeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mergeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mergeBtn.Location = new System.Drawing.Point(607, 154);
            this.mergeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.mergeBtn.Name = "mergeBtn";
            this.mergeBtn.Size = new System.Drawing.Size(37, 142);
            this.mergeBtn.TabIndex = 32;
            this.mergeBtn.Text = "Merge";
            this.mergeBtn.UseVisualStyleBackColor = true;
            this.mergeBtn.Click += new System.EventHandler(this.mergeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 613);
            this.Controls.Add(this.mergeBtn);
            this.Controls.Add(this.bolhaBtn);
            this.Controls.Add(this.quickBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.insercaoBtn);
            this.Controls.Add(this.selecaoBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gerarVetorBtn);
            this.Controls.Add(this.tituloLbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Ordenação";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLbl;
        private System.Windows.Forms.Button gerarVetorBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox vetAleatChckB;
        private System.Windows.Forms.CheckBox quaseOrdChckB;
        private System.Windows.Forms.CheckBox vetDecrescChckB;
        private System.Windows.Forms.CheckBox vetCrescChckB;
        private System.Windows.Forms.Button insercaoBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selecaoBtn;
        private System.Windows.Forms.Button bolhaBtn;
        private System.Windows.Forms.Button quickBtn;
        private System.Windows.Forms.Button mergeBtn;
    }
}

