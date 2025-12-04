namespace WindowsFormsApp3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_old = new System.Windows.Forms.RadioButton();
            this.radioButton_adult = new System.Windows.Forms.RadioButton();
            this.radioButton_child = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_smoker = new System.Windows.Forms.RadioButton();
            this.radioButton_NonSmoker = new System.Windows.Forms.RadioButton();
            this.richTextBox_out = new System.Windows.Forms.RichTextBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_old);
            this.groupBox1.Controls.Add(this.radioButton_adult);
            this.groupBox1.Controls.Add(this.radioButton_child);
            this.groupBox1.Location = new System.Drawing.Point(33, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Age";
            // 
            // radioButton_old
            // 
            this.radioButton_old.AutoSize = true;
            this.radioButton_old.Location = new System.Drawing.Point(16, 84);
            this.radioButton_old.Name = "radioButton_old";
            this.radioButton_old.Size = new System.Drawing.Size(125, 20);
            this.radioButton_old.TabIndex = 2;
            this.radioButton_old.TabStop = true;
            this.radioButton_old.Text = "Greather than 35";
            this.radioButton_old.UseVisualStyleBackColor = true;
            // 
            // radioButton_adult
            // 
            this.radioButton_adult.AutoSize = true;
            this.radioButton_adult.Location = new System.Drawing.Point(16, 58);
            this.radioButton_adult.Name = "radioButton_adult";
            this.radioButton_adult.Size = new System.Drawing.Size(115, 20);
            this.radioButton_adult.TabIndex = 1;
            this.radioButton_adult.TabStop = true;
            this.radioButton_adult.Text = "Between 18-25";
            this.radioButton_adult.UseVisualStyleBackColor = true;
            // 
            // radioButton_child
            // 
            this.radioButton_child.AutoSize = true;
            this.radioButton_child.Location = new System.Drawing.Point(16, 32);
            this.radioButton_child.Name = "radioButton_child";
            this.radioButton_child.Size = new System.Drawing.Size(102, 20);
            this.radioButton_child.TabIndex = 0;
            this.radioButton_child.TabStop = true;
            this.radioButton_child.Text = "Less than 18";
            this.radioButton_child.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_male);
            this.groupBox2.Controls.Add(this.radioButton_female);
            this.groupBox2.Location = new System.Drawing.Point(33, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 97);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_NonSmoker);
            this.groupBox3.Controls.Add(this.radioButton_smoker);
            this.groupBox3.Location = new System.Drawing.Point(275, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 108);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Smoker";
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(10, 33);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(93, 25);
            this.radioButton_female.TabIndex = 0;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Location = new System.Drawing.Point(10, 59);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(73, 25);
            this.radioButton_male.TabIndex = 1;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_smoker
            // 
            this.radioButton_smoker.AutoSize = true;
            this.radioButton_smoker.Location = new System.Drawing.Point(19, 36);
            this.radioButton_smoker.Name = "radioButton_smoker";
            this.radioButton_smoker.Size = new System.Drawing.Size(94, 25);
            this.radioButton_smoker.TabIndex = 0;
            this.radioButton_smoker.TabStop = true;
            this.radioButton_smoker.Text = "Smoker";
            this.radioButton_smoker.UseVisualStyleBackColor = true;
            // 
            // radioButton_NonSmoker
            // 
            this.radioButton_NonSmoker.AutoSize = true;
            this.radioButton_NonSmoker.Location = new System.Drawing.Point(19, 74);
            this.radioButton_NonSmoker.Name = "radioButton_NonSmoker";
            this.radioButton_NonSmoker.Size = new System.Drawing.Size(103, 20);
            this.radioButton_NonSmoker.TabIndex = 1;
            this.radioButton_NonSmoker.TabStop = true;
            this.radioButton_NonSmoker.Text = "Non Smoker";
            this.radioButton_NonSmoker.UseVisualStyleBackColor = true;
            // 
            // richTextBox_out
            // 
            this.richTextBox_out.Location = new System.Drawing.Point(33, 269);
            this.richTextBox_out.Name = "richTextBox_out";
            this.richTextBox_out.Size = new System.Drawing.Size(341, 105);
            this.richTextBox_out.TabIndex = 4;
            this.richTextBox_out.Text = "";
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(400, 283);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(89, 32);
            this.button_Submit.TabIndex = 5;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 413);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.richTextBox_out);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_old;
        private System.Windows.Forms.RadioButton radioButton_adult;
        private System.Windows.Forms.RadioButton radioButton_child;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton_NonSmoker;
        private System.Windows.Forms.RadioButton radioButton_smoker;
        private System.Windows.Forms.RichTextBox richTextBox_out;
        private System.Windows.Forms.Button button_Submit;
    }
}

