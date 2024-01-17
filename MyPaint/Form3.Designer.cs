namespace MyPaint
{
    partial class Form3
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.inpPenWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnWidthColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RecBtn = new System.Windows.Forms.RadioButton();
            this.CircleBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBgColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ColorFillButton = new System.Windows.Forms.RadioButton();
            this.ColorPatternFill = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cdPenColor = new System.Windows.Forms.ColorDialog();
            this.cdBgColor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.inpPenWidth)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1163, 569);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // inpPenWidth
            // 
            this.inpPenWidth.Location = new System.Drawing.Point(78, 21);
            this.inpPenWidth.Name = "inpPenWidth";
            this.inpPenWidth.Size = new System.Drawing.Size(89, 22);
            this.inpPenWidth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnWidthColor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.inpPenWidth);
            this.panel2.Location = new System.Drawing.Point(1226, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 81);
            this.panel2.TabIndex = 3;
            // 
            // btnWidthColor
            // 
            this.btnWidthColor.Location = new System.Drawing.Point(78, 49);
            this.btnWidthColor.Name = "btnWidthColor";
            this.btnWidthColor.Size = new System.Drawing.Size(89, 23);
            this.btnWidthColor.TabIndex = 5;
            this.btnWidthColor.Text = "Pick A Color";
            this.btnWidthColor.UseVisualStyleBackColor = true;
            this.btnWidthColor.Click += new System.EventHandler(this.btnWidthColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1257, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RecBtn);
            this.groupBox1.Controls.Add(this.CircleBtn);
            this.groupBox1.Location = new System.Drawing.Point(1226, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 169);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shape";
            // 
            // RecBtn
            // 
            this.RecBtn.AutoSize = true;
            this.RecBtn.Location = new System.Drawing.Point(22, 55);
            this.RecBtn.Name = "RecBtn";
            this.RecBtn.Size = new System.Drawing.Size(90, 20);
            this.RecBtn.TabIndex = 5;
            this.RecBtn.TabStop = true;
            this.RecBtn.Text = "Rectangle";
            this.RecBtn.UseVisualStyleBackColor = true;
            // 
            // CircleBtn
            // 
            this.CircleBtn.AutoSize = true;
            this.CircleBtn.Location = new System.Drawing.Point(22, 108);
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(62, 20);
            this.CircleBtn.TabIndex = 6;
            this.CircleBtn.TabStop = true;
            this.CircleBtn.Text = "Circle";
            this.CircleBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBgColor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ColorFillButton);
            this.groupBox2.Controls.Add(this.ColorPatternFill);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(1226, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 166);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brush";
            // 
            // btnBgColor
            // 
            this.btnBgColor.Location = new System.Drawing.Point(53, 129);
            this.btnBgColor.Name = "btnBgColor";
            this.btnBgColor.Size = new System.Drawing.Size(115, 23);
            this.btnBgColor.TabIndex = 4;
            this.btnBgColor.Text = "Pick A Color";
            this.btnBgColor.UseVisualStyleBackColor = true;
            this.btnBgColor.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color";
            // 
            // ColorFillButton
            // 
            this.ColorFillButton.AutoSize = true;
            this.ColorFillButton.Location = new System.Drawing.Point(11, 67);
            this.ColorFillButton.Name = "ColorFillButton";
            this.ColorFillButton.Size = new System.Drawing.Size(80, 20);
            this.ColorFillButton.TabIndex = 1;
            this.ColorFillButton.TabStop = true;
            this.ColorFillButton.Text = "Color Fill";
            this.ColorFillButton.UseVisualStyleBackColor = true;
            // 
            // ColorPatternFill
            // 
            this.ColorPatternFill.AutoSize = true;
            this.ColorPatternFill.Location = new System.Drawing.Point(11, 93);
            this.ColorPatternFill.Name = "ColorPatternFill";
            this.ColorPatternFill.Size = new System.Drawing.Size(90, 20);
            this.ColorPatternFill.TabIndex = 2;
            this.ColorPatternFill.TabStop = true;
            this.ColorPatternFill.Text = "Pattern Fill";
            this.ColorPatternFill.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 41);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "No Fill";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 660);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.inpPenWidth)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.NumericUpDown inpPenWidth;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnWidthColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBgColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton ColorFillButton;
        private System.Windows.Forms.RadioButton ColorPatternFill;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton RecBtn;
        private System.Windows.Forms.RadioButton CircleBtn;
        private System.Windows.Forms.ColorDialog cdPenColor;
        private System.Windows.Forms.ColorDialog cdBgColor;
    }
}