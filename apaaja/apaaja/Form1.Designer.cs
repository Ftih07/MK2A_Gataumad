namespace apaaja
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            label2 = new Label();
            txtC = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            txthasil = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 148);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 0;
            label1.Text = "A";
            label1.Click += label1_Click;
            // 
            // txtA
            // 
            txtA.BorderStyle = BorderStyle.None;
            txtA.Location = new Point(160, 145);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 20);
            txtA.TabIndex = 1;
            txtA.TextChanged += textBox1_TextChanged;
            // 
            // txtB
            // 
            txtB.Location = new Point(160, 193);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 27);
            txtB.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 196);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 2;
            label2.Text = "B";
            // 
            // txtC
            // 
            txtC.Location = new Point(160, 248);
            txtC.Name = "txtC";
            txtC.Size = new Size(125, 27);
            txtC.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 251);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 4;
            label3.Text = "C";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 332);
            label4.Name = "label4";
            label4.Size = new Size(20, 20);
            label4.TabIndex = 6;
            label4.Text = "D";
            // 
            // button1
            // 
            button1.Location = new Point(353, 130);
            button1.Name = "button1";
            button1.Size = new Size(138, 152);
            button1.TabIndex = 8;
            button1.Text = "Hitung";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txthasil
            // 
            txthasil.BackColor = SystemColors.ScrollBar;
            txthasil.BorderStyle = BorderStyle.FixedSingle;
            txthasil.Location = new Point(160, 325);
            txthasil.Name = "txthasil";
            txthasil.Size = new Size(200, 27);
            txthasil.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txthasil);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(txtC);
            Controls.Add(label3);
            Controls.Add(txtB);
            Controls.Add(label2);
            Controls.Add(txtA);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtA;
        private TextBox txtB;
        private Label label2;
        private TextBox txtC;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox txthasil;
    }
}
