namespace login_form
{
    partial class user_access
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdduser = new System.Windows.Forms.Button();
            this.btnRemoveuser = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnUserAccessRights = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control Panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Access Management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Group :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cboBox
            // 
            this.cboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBox.FormattingEnabled = true;
            this.cboBox.Items.AddRange(new object[] {
            "User 1",
            "User 2",
            "User 3",
            "User 4",
            "User 5"});
            this.cboBox.Location = new System.Drawing.Point(302, 127);
            this.cboBox.Name = "cboBox";
            this.cboBox.Size = new System.Drawing.Size(121, 21);
            this.cboBox.TabIndex = 3;
            this.cboBox.SelectedIndexChanged += new System.EventHandler(this.cboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Selected :";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(593, 130);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(13, 13);
            this.lblValue.TabIndex = 5;
            this.lblValue.Text = "?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "If you want to add or remove user please use following buttons";
            // 
            // btnAdduser
            // 
            this.btnAdduser.Location = new System.Drawing.Point(269, 247);
            this.btnAdduser.Name = "btnAdduser";
            this.btnAdduser.Size = new System.Drawing.Size(75, 23);
            this.btnAdduser.TabIndex = 7;
            this.btnAdduser.Text = "Add User";
            this.btnAdduser.UseVisualStyleBackColor = true;
            this.btnAdduser.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveuser
            // 
            this.btnRemoveuser.Location = new System.Drawing.Point(473, 247);
            this.btnRemoveuser.Name = "btnRemoveuser";
            this.btnRemoveuser.Size = new System.Drawing.Size(98, 23);
            this.btnRemoveuser.TabIndex = 8;
            this.btnRemoveuser.Text = "Remove User";
            this.btnRemoveuser.UseVisualStyleBackColor = true;
            this.btnRemoveuser.Click += new System.EventHandler(this.btnRemoveuser_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(372, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(269, 309);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(302, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "If you want to add or remove user please use following buttons";
            // 
            // btnUserAccessRights
            // 
            this.btnUserAccessRights.Location = new System.Drawing.Point(349, 352);
            this.btnUserAccessRights.Name = "btnUserAccessRights";
            this.btnUserAccessRights.Size = new System.Drawing.Size(114, 23);
            this.btnUserAccessRights.TabIndex = 11;
            this.btnUserAccessRights.Text = "User Access Right";
            this.btnUserAccessRights.UseVisualStyleBackColor = true;
            this.btnUserAccessRights.Click += new System.EventHandler(this.btnUserAccessRights_Click);
            // 
            // user_access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUserAccessRights);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnRemoveuser);
            this.Controls.Add(this.btnAdduser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "user_access";
            this.Text = "user_access";
            this.Load += new System.EventHandler(this.user_access_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdduser;
        private System.Windows.Forms.Button btnRemoveuser;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnUserAccessRights;
    }
}