namespace ProiectOOp
{
    partial class FormMatrix
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
            this.comboBoxChoice = new System.Windows.Forms.ComboBox();
            this.buttonCalculeaza = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAlegere = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxChoice
            // 
            this.comboBoxChoice.FormattingEnabled = true;
            this.comboBoxChoice.Items.AddRange(new object[] {
            "Adunare a 2 matrice",
            "Scadere dintre 2 matrice",
            "Inmultirea a 2 matrice",
            "Ridicarea unei matrice la o putere",
            "Scoaterea unui factor comun dintr-o matrice",
            "Determinantul unei matrice",
            "Urma unei matrice",
            "Factorul comun dintr-un determinant de pe o anumita linie/coloana",
            "Rangul unei matrice",
            "Rezolvarea unui sistem de ecuatii",
            "Al k-lea element Fibonacci"});
            this.comboBoxChoice.Location = new System.Drawing.Point(276, 26);
            this.comboBoxChoice.Name = "comboBoxChoice";
            this.comboBoxChoice.Size = new System.Drawing.Size(392, 21);
            this.comboBoxChoice.TabIndex = 0;
            // 
            // buttonCalculeaza
            // 
            this.buttonCalculeaza.Location = new System.Drawing.Point(786, 24);
            this.buttonCalculeaza.Name = "buttonCalculeaza";
            this.buttonCalculeaza.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculeaza.TabIndex = 2;
            this.buttonCalculeaza.Text = "Continua\r\n";
            this.buttonCalculeaza.UseVisualStyleBackColor = true;
            this.buttonCalculeaza.Click += new System.EventHandler(this.buttonCalculeaza_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelAlegere);
            this.panel1.Controls.Add(this.buttonCalculeaza);
            this.panel1.Controls.Add(this.comboBoxChoice);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1571, 73);
            this.panel1.TabIndex = 3;
            // 
            // labelAlegere
            // 
            this.labelAlegere.AutoSize = true;
            this.labelAlegere.Location = new System.Drawing.Point(60, 29);
            this.labelAlegere.Name = "labelAlegere";
            this.labelAlegere.Size = new System.Drawing.Size(163, 13);
            this.labelAlegere.TabIndex = 3;
            this.labelAlegere.Text = "Alegeti ce operatie doriti sa faceti";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1571, 814);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(966, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = ".";
            // 
            // FormMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1595, 917);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMatrix";
            this.Text = "Calculator de Matrice";
            this.Load += new System.EventHandler(this.FormMatrix_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChoice;
        private System.Windows.Forms.Button buttonCalculeaza;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAlegere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

