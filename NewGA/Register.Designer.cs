namespace NewGA
{
    partial class frmRegister
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister1 = new System.Windows.Forms.Button();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.lblPassword1 = new System.Windows.Forms.Label();
            this.txtUsername1 = new System.Windows.Forms.TextBox();
            this.lblUsername1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(472, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 39);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister1
            // 
            this.btnRegister1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister1.Location = new System.Drawing.Point(218, 328);
            this.btnRegister1.Name = "btnRegister1";
            this.btnRegister1.Size = new System.Drawing.Size(98, 39);
            this.btnRegister1.TabIndex = 17;
            this.btnRegister1.Text = "Register";
            this.btnRegister1.UseVisualStyleBackColor = true;
            this.btnRegister1.Click += new System.EventHandler(this.btnRegister1_Click);
            // 
            // txtPassword1
            // 
            this.txtPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword1.Location = new System.Drawing.Point(387, 166);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(153, 28);
            this.txtPassword1.TabIndex = 16;
            this.txtPassword1.TextChanged += new System.EventHandler(this.txtPassword1_TextChanged);
            // 
            // lblPassword1
            // 
            this.lblPassword1.AutoSize = true;
            this.lblPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword1.Location = new System.Drawing.Point(242, 166);
            this.lblPassword1.Name = "lblPassword1";
            this.lblPassword1.Size = new System.Drawing.Size(97, 24);
            this.lblPassword1.TabIndex = 15;
            this.lblPassword1.Text = "Password:";
            // 
            // txtUsername1
            // 
            this.txtUsername1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername1.Location = new System.Drawing.Point(387, 83);
            this.txtUsername1.Name = "txtUsername1";
            this.txtUsername1.Size = new System.Drawing.Size(153, 28);
            this.txtUsername1.TabIndex = 14;
            // 
            // lblUsername1
            // 
            this.lblUsername1.AutoSize = true;
            this.lblUsername1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername1.Location = new System.Drawing.Point(242, 83);
            this.lblUsername1.Name = "lblUsername1";
            this.lblUsername1.Size = new System.Drawing.Size(102, 24);
            this.lblUsername1.TabIndex = 13;
            this.lblUsername1.Text = "Username:";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister1);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.lblPassword1);
            this.Controls.Add(this.txtUsername1);
            this.Controls.Add(this.lblUsername1);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister1;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Label lblPassword1;
        private System.Windows.Forms.TextBox txtUsername1;
        private System.Windows.Forms.Label lblUsername1;
    }
}