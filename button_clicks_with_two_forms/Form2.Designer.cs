
namespace button_clicks_with_two_forms
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
            this.labelClickCount = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonShowOrHideA = new System.Windows.Forms.Button();
            this.labelOtherControlA = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonShowOrHideB = new System.Windows.Forms.Button();
            this.labelOtherControlB = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelClickCount
            // 
            this.labelClickCount.AutoSize = true;
            this.labelClickCount.Location = new System.Drawing.Point(24, 31);
            this.labelClickCount.Name = "labelClickCount";
            this.labelClickCount.Size = new System.Drawing.Size(133, 25);
            this.labelClickCount.TabIndex = 0;
            this.labelClickCount.Text = "Click Count = 0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.buttonShowOrHideA);
            this.flowLayoutPanel1.Controls.Add(this.labelOtherControlA);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 91);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(396, 59);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonShowOrHideA
            // 
            this.buttonShowOrHideA.BackColor = System.Drawing.Color.Red;
            this.buttonShowOrHideA.ForeColor = System.Drawing.Color.White;
            this.buttonShowOrHideA.Location = new System.Drawing.Point(3, 3);
            this.buttonShowOrHideA.Name = "buttonShowOrHideA";
            this.buttonShowOrHideA.Size = new System.Drawing.Size(161, 34);
            this.buttonShowOrHideA.TabIndex = 0;
            this.buttonShowOrHideA.Text = "Show or Hide";
            this.buttonShowOrHideA.UseVisualStyleBackColor = false;
            this.buttonShowOrHideA.Visible = false;
            this.buttonShowOrHideA.Click += new System.EventHandler(this.buttonShowOrHideA_Click);
            // 
            // labelOtherControlA
            // 
            this.labelOtherControlA.BackColor = System.Drawing.Color.DimGray;
            this.labelOtherControlA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelOtherControlA.Location = new System.Drawing.Point(170, 3);
            this.labelOtherControlA.Margin = new System.Windows.Forms.Padding(3);
            this.labelOtherControlA.Name = "labelOtherControlA";
            this.labelOtherControlA.Size = new System.Drawing.Size(167, 34);
            this.labelOtherControlA.TabIndex = 1;
            this.labelOtherControlA.Text = "Other Control";
            this.labelOtherControlA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Controls.Add(this.buttonShowOrHideB);
            this.flowLayoutPanel2.Controls.Add(this.labelOtherControlB);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(24, 173);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(396, 59);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // buttonShowOrHideB
            // 
            this.buttonShowOrHideB.BackColor = System.Drawing.Color.Green;
            this.buttonShowOrHideB.ForeColor = System.Drawing.Color.White;
            this.buttonShowOrHideB.Location = new System.Drawing.Point(3, 3);
            this.buttonShowOrHideB.Name = "buttonShowOrHideB";
            this.buttonShowOrHideB.Size = new System.Drawing.Size(161, 34);
            this.buttonShowOrHideB.TabIndex = 0;
            this.buttonShowOrHideB.Text = "Show or Hide";
            this.buttonShowOrHideB.UseVisualStyleBackColor = false;
            this.buttonShowOrHideB.Visible = false;
            this.buttonShowOrHideB.Click += new System.EventHandler(this.buttonShowOrHideB_Click);
            // 
            // labelOtherControlB
            // 
            this.labelOtherControlB.BackColor = System.Drawing.Color.DimGray;
            this.labelOtherControlB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelOtherControlB.Location = new System.Drawing.Point(170, 3);
            this.labelOtherControlB.Margin = new System.Windows.Forms.Padding(3);
            this.labelOtherControlB.Name = "labelOtherControlB";
            this.labelOtherControlB.Size = new System.Drawing.Size(167, 34);
            this.labelOtherControlB.TabIndex = 2;
            this.labelOtherControlB.Text = "Other Control";
            this.labelOtherControlB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelClickCount);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClickCount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonShowOrHideA;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonShowOrHideB;
        private System.Windows.Forms.Label labelOtherControlA;
        private System.Windows.Forms.Label labelOtherControlB;
    }
}