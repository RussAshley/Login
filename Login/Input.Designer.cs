
namespace Login
{
    partial class Input
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
            this.inputUserName = new System.Windows.Forms.TextBox();
            this.Inputpassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputUserName
            // 
            this.inputUserName.Location = new System.Drawing.Point(219, 99);
            this.inputUserName.Name = "inputUserName";
            this.inputUserName.Size = new System.Drawing.Size(289, 23);
            this.inputUserName.TabIndex = 0;
            this.inputUserName.Text = "User Name";
            // 
            // Inputpassword
            // 
            this.Inputpassword.Location = new System.Drawing.Point(219, 169);
            this.Inputpassword.Name = "Inputpassword";
            this.Inputpassword.Size = new System.Drawing.Size(289, 23);
            this.Inputpassword.TabIndex = 1;
            this.Inputpassword.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Inputpassword);
            this.Controls.Add(this.inputUserName);
            this.Name = "Input";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputUserName;
        private System.Windows.Forms.TextBox Inputpassword;
        private System.Windows.Forms.Button button1;
    }
}

