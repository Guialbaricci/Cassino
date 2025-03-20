namespace Cassino
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
            components = new System.ComponentModel.Container();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            btGirar = new Button();
            tmrGiro = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.White;
            lbl1.Font = new Font("MS Reference Sans Serif", 36F);
            lbl1.Location = new Point(122, 105);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(56, 60);
            lbl1.TabIndex = 0;
            lbl1.Text = "0";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.White;
            lbl2.Font = new Font("MS Reference Sans Serif", 36F);
            lbl2.Location = new Point(182, 105);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(56, 60);
            lbl2.TabIndex = 1;
            lbl2.Text = "0";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.White;
            lbl3.Font = new Font("MS Reference Sans Serif", 36F);
            lbl3.Location = new Point(242, 105);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(56, 60);
            lbl3.TabIndex = 2;
            lbl3.Text = "0";
            // 
            // btGirar
            // 
            btGirar.Font = new Font("MS Reference Sans Serif", 36F);
            btGirar.ForeColor = SystemColors.ActiveCaptionText;
            btGirar.Location = new Point(122, 208);
            btGirar.Name = "btGirar";
            btGirar.Size = new Size(174, 71);
            btGirar.TabIndex = 3;
            btGirar.Text = "Girar";
            btGirar.UseVisualStyleBackColor = true;
            btGirar.Click += button1_Click;
            // 
            // tmrGiro
            // 
            tmrGiro.Tick += tmrGiro_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(435, 402);
            Controls.Add(btGirar);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "CASSINO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Button btGirar;
        private System.Windows.Forms.Timer tmrGiro;
    }
}
