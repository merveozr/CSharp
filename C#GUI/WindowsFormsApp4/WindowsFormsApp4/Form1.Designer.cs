namespace WindowsFormsApp4
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
            this.textBox_Add = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.textBox_Remove = new System.Windows.Forms.TextBox();
            this.button_Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Add
            // 
            this.textBox_Add.Location = new System.Drawing.Point(62, 63);
            this.textBox_Add.Name = "textBox_Add";
            this.textBox_Add.Size = new System.Drawing.Size(129, 22);
            this.textBox_Add.TabIndex = 1;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(226, 57);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(93, 34);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(62, 109);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(256, 118);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // textBox_Remove
            // 
            this.textBox_Remove.Location = new System.Drawing.Point(62, 254);
            this.textBox_Remove.Name = "textBox_Remove";
            this.textBox_Remove.Size = new System.Drawing.Size(129, 22);
            this.textBox_Remove.TabIndex = 4;
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(226, 248);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(93, 34);
            this.button_Remove.TabIndex = 5;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 340);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.textBox_Remove);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Add;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox textBox_Remove;
        private System.Windows.Forms.Button button_Remove;
    }
}

