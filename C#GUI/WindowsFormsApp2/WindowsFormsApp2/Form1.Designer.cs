namespace WindowsFormsApp2
{
    partial class Form1
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
            this.checkBox_ice = new System.Windows.Forms.CheckBox();
            this.checkBox_cake = new System.Windows.Forms.CheckBox();
            this.Button_Submit = new System.Windows.Forms.Button();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.richTextBox_Out = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // checkBox_ice
            // 
            this.checkBox_ice.AutoSize = true;
            this.checkBox_ice.Location = new System.Drawing.Point(89, 43);
            this.checkBox_ice.Name = "checkBox_ice";
            this.checkBox_ice.Size = new System.Drawing.Size(120, 20);
            this.checkBox_ice.TabIndex = 0;
            this.checkBox_ice.Text = "Like icecream?";
            this.checkBox_ice.UseVisualStyleBackColor = true;
            // 
            // checkBox_cake
            // 
            this.checkBox_cake.AutoSize = true;
            this.checkBox_cake.Location = new System.Drawing.Point(89, 92);
            this.checkBox_cake.Name = "checkBox_cake";
            this.checkBox_cake.Size = new System.Drawing.Size(96, 20);
            this.checkBox_cake.TabIndex = 1;
            this.checkBox_cake.Text = "Like Cake?";
            this.checkBox_cake.UseVisualStyleBackColor = true;
            // 
            // Button_Submit
            // 
            this.Button_Submit.Location = new System.Drawing.Point(88, 154);
            this.Button_Submit.Name = "Button_Submit";
            this.Button_Submit.Size = new System.Drawing.Size(95, 24);
            this.Button_Submit.TabIndex = 2;
            this.Button_Submit.Text = "Submit";
            this.Button_Submit.UseVisualStyleBackColor = true;
            this.Button_Submit.Click += new System.EventHandler(this.Button_Submit_Click);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(200, 154);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(95, 24);
            this.Button_Clear.TabIndex = 3;
            this.Button_Clear.Text = "Clear";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // richTextBox_Out
            // 
            this.richTextBox_Out.Location = new System.Drawing.Point(89, 201);
            this.richTextBox_Out.Name = "richTextBox_Out";
            this.richTextBox_Out.Size = new System.Drawing.Size(206, 97);
            this.richTextBox_Out.TabIndex = 4;
            this.richTextBox_Out.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 368);
            this.Controls.Add(this.richTextBox_Out);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Button_Submit);
            this.Controls.Add(this.checkBox_cake);
            this.Controls.Add(this.checkBox_ice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_ice;
        private System.Windows.Forms.CheckBox checkBox_cake;
        private System.Windows.Forms.Button Button_Submit;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.RichTextBox richTextBox_Out;
    }
}

