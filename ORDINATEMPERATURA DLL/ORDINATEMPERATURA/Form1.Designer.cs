namespace ORDINATEMPERATURA
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Carica = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.annulla = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(564, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Temperature ordinate";
            // 
            // Carica
            // 
            this.Carica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Carica.Location = new System.Drawing.Point(31, 33);
            this.Carica.Name = "Carica";
            this.Carica.Size = new System.Drawing.Size(160, 82);
            this.Carica.TabIndex = 16;
            this.Carica.Text = "Carica temperature";
            this.Carica.UseVisualStyleBackColor = true;
            this.Carica.Click += new System.EventHandler(this.carica_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "Bubble sort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.bubble_click);
            // 
            // annulla
            // 
            this.annulla.Location = new System.Drawing.Point(31, 296);
            this.annulla.Name = "annulla";
            this.annulla.Size = new System.Drawing.Size(103, 45);
            this.annulla.TabIndex = 18;
            this.annulla.Text = "Selection sort";
            this.annulla.UseVisualStyleBackColor = true;
            this.annulla.Click += new System.EventHandler(this.selection_click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 40);
            this.button4.TabIndex = 19;
            this.button4.Text = "Quick sort";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.quick_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(187, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tempo impiegato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(187, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tempo impiegato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(187, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tempo impiegato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(379, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(379, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(379, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Time";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(240, 22);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 147);
            this.listBox1.TabIndex = 26;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(31, 380);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 44);
            this.button5.TabIndex = 27;
            this.button5.Text = "Annulla";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.annulla_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(504, 70);
            this.listBox2.MultiColumn = true;
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(268, 368);
            this.listBox2.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.annulla);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Carica);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Carica;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button annulla;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox2;
    }
}

