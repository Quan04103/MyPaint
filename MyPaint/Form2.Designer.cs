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
            this.SolidBtn = new System.Windows.Forms.RadioButton();
            this.DottedBtn = new System.Windows.Forms.RadioButton();
            this.DashedBtn = new System.Windows.Forms.RadioButton();
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
            // SolidBtn
            // 
            this.SolidBtn.AutoSize = true;
            this.SolidBtn.Location = new System.Drawing.Point(1273, 212);
            this.SolidBtn.Name = "SolidBtn";
            this.SolidBtn.Size = new System.Drawing.Size(59, 20);
            this.SolidBtn.TabIndex = 7;
            this.SolidBtn.TabStop = true;
            this.SolidBtn.Text = "Solid";
            this.SolidBtn.UseVisualStyleBackColor = true;
            this.SolidBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // DottedBtn
            // 
            this.DottedBtn.AutoSize = true;
            this.DottedBtn.Location = new System.Drawing.Point(1273, 170);
            this.DottedBtn.Name = "DottedBtn";
            this.DottedBtn.Size = new System.Drawing.Size(68, 20);
            this.DottedBtn.TabIndex = 0;
            this.DottedBtn.TabStop = true;
            this.DottedBtn.Text = "Dotted";
            this.DottedBtn.UseVisualStyleBackColor = true;
            this.DottedBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // DashedBtn
            // 
            this.DashedBtn.AutoSize = true;
            this.DashedBtn.Location = new System.Drawing.Point(1273, 255);
            this.DashedBtn.Name = "DashedBtn";
            this.DashedBtn.Size = new System.Drawing.Size(76, 20);
            this.DashedBtn.TabIndex = 8;
            this.DashedBtn.TabStop = true;
            this.DashedBtn.Text = "Dashed";
            this.DashedBtn.UseVisualStyleBackColor = true;
            this.DashedBtn.CheckedChanged += new System.EventHandler(this.DashedBtn_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 710);
            this.Controls.Add(this.DashedBtn);
            this.Controls.Add(this.SolidBtn);
            this.Controls.Add(this.DottedBtn);
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
        private System.Windows.Forms.RadioButton SolidBtn;
        private System.Windows.Forms.RadioButton DottedBtn;
        private System.Windows.Forms.RadioButton DashedBtn;
    }
}