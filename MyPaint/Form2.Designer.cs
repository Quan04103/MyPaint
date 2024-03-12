namespace MyPaint
{
    partial class Form2
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
            this.cdPenColor = new System.Windows.Forms.ColorDialog();
            this.cdColorBg = new System.Windows.Forms.ColorDialog();
            this.RecBtn = new System.Windows.Forms.RadioButton();
            this.CircleBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1227, 686);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // RecBtn
            // 
            this.RecBtn.AutoSize = true;
            this.RecBtn.Location = new System.Drawing.Point(1273, 212);
            this.RecBtn.Name = "RecBtn";
            this.RecBtn.Size = new System.Drawing.Size(90, 20);
            this.RecBtn.TabIndex = 7;
            this.RecBtn.TabStop = true;
            this.RecBtn.Text = "Rectangle";
            this.RecBtn.UseVisualStyleBackColor = true;
            this.RecBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // CircleBtn
            // 
            this.CircleBtn.AutoSize = true;
            this.CircleBtn.Location = new System.Drawing.Point(1273, 170);
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(62, 20);
            this.CircleBtn.TabIndex = 0;
            this.CircleBtn.TabStop = true;
            this.CircleBtn.Text = "Circle";
            this.CircleBtn.UseVisualStyleBackColor = true;
            this.CircleBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 710);
            this.Controls.Add(this.RecBtn);
            this.Controls.Add(this.CircleBtn);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ColorDialog cdPenColor;
        private System.Windows.Forms.ColorDialog cdColorBg;
        private System.Windows.Forms.RadioButton RecBtn;
        private System.Windows.Forms.RadioButton CircleBtn;
    }
}