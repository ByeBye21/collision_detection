namespace NDP___Carpisma
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
            groupBox1 = new GroupBox();
            label = new Label();
            comboBox1 = new ComboBox();
            comboBox = new ComboBox();
            button = new Button();
            groupBox2 = new GroupBox();
            panel = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.WindowFrame;
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(comboBox);
            groupBox1.Controls.Add(button);
            groupBox1.Location = new Point(2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 449);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Panel";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(113, 335);
            label.Name = "label";
            label.Size = new Size(0, 20);
            label.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nokta", "Dikdortgen", "Daire", "Kure", "Yuzey", "Prizma", "Silindir" });
            comboBox1.Location = new Point(97, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Nokta", "Dikdortgen", "Daire", "Kure", "Yuzey", "Prizma", "Silindir" });
            comboBox.Location = new Point(97, 56);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(151, 28);
            comboBox.TabIndex = 1;
            // 
            // button
            // 
            button.Location = new Point(81, 247);
            button.Name = "button";
            button.Size = new Size(183, 34);
            button.TabIndex = 0;
            button.Text = "Çarpışma Denetimi Yap";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(panel);
            groupBox2.Location = new Point(344, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(458, 449);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ekran";
            // 
            // panel
            // 
            panel.Location = new Point(6, 26);
            panel.Name = "panel";
            panel.Size = new Size(446, 417);
            panel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 454);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox;
        private Button button;
        private Panel panel;
        private Label label;
    }
}