
namespace Login
{
    partial class Details
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
            this.name = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(291, 93);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(220, 23);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(291, 147);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(220, 23);
            this.userName.TabIndex = 1;
            this.userName.Text = "User Name";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(291, 201);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(220, 23);
            this.age.TabIndex = 2;
            this.age.Text = "Age";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(291, 257);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(220, 23);
            this.address.TabIndex = 3;
            this.address.Text = "Address";
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.address);
            this.Controls.Add(this.age);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.name);
            this.Name = "Details";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox address;
    }
}