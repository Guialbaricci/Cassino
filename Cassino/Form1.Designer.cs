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
            lbxUltimos = new ListBox();
            chbVitorias = new CheckBox();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.White;
            lbl1.Font = new Font("MS Reference Sans Serif", 36F);
            lbl1.Location = new Point(33, 28);
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
            lbl2.Location = new Point(93, 28);
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
            lbl3.Location = new Point(153, 28);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(56, 60);
            lbl3.TabIndex = 2;
            lbl3.Text = "0";
            // 
            // btGirar
            // 
            btGirar.Font = new Font("MS Reference Sans Serif", 36F);
            btGirar.ForeColor = SystemColors.ActiveCaptionText;
            btGirar.Location = new Point(33, 103);
            btGirar.Name = "btGirar";
            btGirar.Size = new Size(176, 71);
            btGirar.TabIndex = 0;
            btGirar.Text = "&Girar";
            btGirar.UseVisualStyleBackColor = true;
            btGirar.Click += button1_Click;
            // 
            // tmrGiro
            // 
            tmrGiro.Tick += tmrGiro_Tick;
            // 
            // lbxUltimos
            // 
            lbxUltimos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxUltimos.FormattingEnabled = true;
            lbxUltimos.ItemHeight = 30;
            lbxUltimos.Location = new Point(33, 190);
            lbxUltimos.Name = "lbxUltimos";
            lbxUltimos.Size = new Size(176, 184);
            lbxUltimos.TabIndex = 1;
            // 
            // chbVitorias
            // 
            chbVitorias.AutoSize = true;
            chbVitorias.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbVitorias.Location = new Point(33, 380);
            chbVitorias.Name = "chbVitorias";
            chbVitorias.Size = new Size(130, 34);
            chbVitorias.TabIndex = 2;
            chbVitorias.Text = "Só &Vitórias";
            chbVitorias.UseVisualStyleBackColor = true;
            chbVitorias.CheckedChanged += chbVitorias_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(233, 426);
            Controls.Add(chbVitorias);
            Controls.Add(lbxUltimos);
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
        private ListBox lbxUltimos;
        private CheckBox chbVitorias;
    }
}
