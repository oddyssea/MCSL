namespace MinecraftServerLauncher
{
    partial class FirstTimeLaunchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstTimeLaunchForm));
            this.MCSFilesDirectoryBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MCSWorldsDirectoryBox = new System.Windows.Forms.TextBox();
            this.FirstTimeOKButton = new System.Windows.Forms.Button();
            this.FirstTimeCloseButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrentWorldBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MCSFilesDirectoryBox
            // 
            this.MCSFilesDirectoryBox.Location = new System.Drawing.Point(258, 17);
            this.MCSFilesDirectoryBox.Name = "MCSFilesDirectoryBox";
            this.MCSFilesDirectoryBox.Size = new System.Drawing.Size(335, 20);
            this.MCSFilesDirectoryBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minecraftia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minecraft Server Files Directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minecraftia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minecraft Server Worlds Directory:";
            // 
            // MCSWorldsDirectoryBox
            // 
            this.MCSWorldsDirectoryBox.Location = new System.Drawing.Point(258, 44);
            this.MCSWorldsDirectoryBox.Name = "MCSWorldsDirectoryBox";
            this.MCSWorldsDirectoryBox.Size = new System.Drawing.Size(335, 20);
            this.MCSWorldsDirectoryBox.TabIndex = 2;
            // 
            // FirstTimeOKButton
            // 
            this.FirstTimeOKButton.BackColor = System.Drawing.Color.Silver;
            this.FirstTimeOKButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FirstTimeOKButton.FlatAppearance.BorderSize = 2;
            this.FirstTimeOKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstTimeOKButton.Font = new System.Drawing.Font("Minecraftia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstTimeOKButton.ForeColor = System.Drawing.Color.White;
            this.FirstTimeOKButton.Location = new System.Drawing.Point(493, 137);
            this.FirstTimeOKButton.Name = "FirstTimeOKButton";
            this.FirstTimeOKButton.Size = new System.Drawing.Size(100, 30);
            this.FirstTimeOKButton.TabIndex = 8;
            this.FirstTimeOKButton.Text = "OK";
            this.FirstTimeOKButton.UseVisualStyleBackColor = false;
            this.FirstTimeOKButton.Click += new System.EventHandler(this.FirstTimeOKButton_Click);
            // 
            // FirstTimeCloseButton
            // 
            this.FirstTimeCloseButton.BackColor = System.Drawing.Color.Silver;
            this.FirstTimeCloseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FirstTimeCloseButton.FlatAppearance.BorderSize = 2;
            this.FirstTimeCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstTimeCloseButton.Font = new System.Drawing.Font("Minecraftia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstTimeCloseButton.ForeColor = System.Drawing.Color.White;
            this.FirstTimeCloseButton.Location = new System.Drawing.Point(16, 137);
            this.FirstTimeCloseButton.Name = "FirstTimeCloseButton";
            this.FirstTimeCloseButton.Size = new System.Drawing.Size(100, 30);
            this.FirstTimeCloseButton.TabIndex = 9;
            this.FirstTimeCloseButton.Text = "Close";
            this.FirstTimeCloseButton.UseVisualStyleBackColor = false;
            this.FirstTimeCloseButton.Click += new System.EventHandler(this.FirstTimeCloseButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minecraftia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name of Currently Loaded World:";
            // 
            // CurrentWorldBox
            // 
            this.CurrentWorldBox.Location = new System.Drawing.Point(258, 71);
            this.CurrentWorldBox.Name = "CurrentWorldBox";
            this.CurrentWorldBox.Size = new System.Drawing.Size(335, 20);
            this.CurrentWorldBox.TabIndex = 10;
            // 
            // FirstTimeLaunchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 179);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CurrentWorldBox);
            this.Controls.Add(this.FirstTimeCloseButton);
            this.Controls.Add(this.FirstTimeOKButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MCSWorldsDirectoryBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MCSFilesDirectoryBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FirstTimeLaunchForm";
            this.Text = "First Time Setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirstTimeLaunchForm_FormClosing);
            this.Load += new System.EventHandler(this.FirstTimeLaunchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MCSFilesDirectoryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MCSWorldsDirectoryBox;
        private System.Windows.Forms.Button FirstTimeOKButton;
        private System.Windows.Forms.Button FirstTimeCloseButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CurrentWorldBox;
    }
}

