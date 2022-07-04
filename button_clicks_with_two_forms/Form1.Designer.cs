
namespace button_clicks_with_two_forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxShowForm2 = new System.Windows.Forms.CheckBox();
            this.buttonIncrementCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxShowForm2
            // 
            this.checkBoxShowForm2.AutoSize = true;
            this.checkBoxShowForm2.Location = new System.Drawing.Point(38, 47);
            this.checkBoxShowForm2.Name = "checkBoxShowForm2";
            this.checkBoxShowForm2.Size = new System.Drawing.Size(134, 29);
            this.checkBoxShowForm2.TabIndex = 0;
            this.checkBoxShowForm2.Text = "ShowForm2";
            this.checkBoxShowForm2.UseVisualStyleBackColor = true;
            // 
            // buttonIncrementCount
            // 
            this.buttonIncrementCount.Location = new System.Drawing.Point(38, 121);
            this.buttonIncrementCount.Name = "buttonIncrementCount";
            this.buttonIncrementCount.Size = new System.Drawing.Size(186, 34);
            this.buttonIncrementCount.TabIndex = 1;
            this.buttonIncrementCount.Text = "Button Click ++";
            this.buttonIncrementCount.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.buttonIncrementCount);
            this.Controls.Add(this.checkBoxShowForm2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxShowForm2;
        private System.Windows.Forms.Button buttonIncrementCount;
    }
}

