namespace chatgpt
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
            btnPesq = new Button();
            rtxPesq = new RichTextBox();
            titulo1 = new Label();
            btnHist = new Button();
            richTextBox1 = new RichTextBox();
            lblresult = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnPesq
            // 
            btnPesq.Location = new Point(676, 313);
            btnPesq.Name = "btnPesq";
            btnPesq.Size = new Size(93, 41);
            btnPesq.TabIndex = 0;
            btnPesq.Text = "Pesquisar";
            btnPesq.UseVisualStyleBackColor = true;
            btnPesq.Click += btnPesq_Click;
            // 
            // rtxPesq
            // 
            rtxPesq.BackColor = SystemColors.MenuText;
            rtxPesq.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rtxPesq.ForeColor = Color.White;
            rtxPesq.Location = new Point(55, 313);
            rtxPesq.Name = "rtxPesq";
            rtxPesq.Size = new Size(599, 96);
            rtxPesq.TabIndex = 3;
            rtxPesq.Text = "";
            // 
            // titulo1
            // 
            titulo1.AutoSize = true;
            titulo1.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            titulo1.ForeColor = Color.White;
            titulo1.Location = new Point(55, 9);
            titulo1.Name = "titulo1";
            titulo1.Size = new Size(321, 46);
            titulo1.TabIndex = 4;
            titulo1.Text = "Pesquisador Inator";
            titulo1.Click += label1_Click;
            // 
            // btnHist
            // 
            btnHist.Location = new Point(12, 415);
            btnHist.Name = "btnHist";
            btnHist.Size = new Size(75, 23);
            btnHist.TabIndex = 5;
            btnHist.Text = "Histórico";
            btnHist.UseVisualStyleBackColor = true;
            btnHist.Click += btnHist_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.MenuText;
            richTextBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(55, 72);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(714, 337);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // lblresult
            // 
            lblresult.BackColor = SystemColors.MenuText;
            lblresult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblresult.ForeColor = Color.White;
            lblresult.Location = new Point(55, 72);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(599, 194);
            lblresult.TabIndex = 7;
            lblresult.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 289);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 8;
            label1.Text = "Digite Aqui:";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(lblresult);
            Controls.Add(btnHist);
            Controls.Add(titulo1);
            Controls.Add(rtxPesq);
            Controls.Add(btnPesq);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPesq;
        private RichTextBox rtxPesq;
        private Label titulo1;
        private Button btnHist;
        private RichTextBox richTextBox1;
        private RichTextBox lblresult;
        private Label label1;
    }
}