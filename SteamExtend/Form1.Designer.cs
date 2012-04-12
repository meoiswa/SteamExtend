namespace SteamExtend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSteamSource = new System.Windows.Forms.TextBox();
            this.buttonSteamSource = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSteamDest = new System.Windows.Forms.TextBox();
            this.buttonSteamDest = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Steam Directory";
            // 
            // textBoxSteamSource
            // 
            this.textBoxSteamSource.Location = new System.Drawing.Point(12, 25);
            this.textBoxSteamSource.Name = "textBoxSteamSource";
            this.textBoxSteamSource.Size = new System.Drawing.Size(564, 20);
            this.textBoxSteamSource.TabIndex = 1;
            // 
            // buttonSteamSource
            // 
            this.buttonSteamSource.Location = new System.Drawing.Point(582, 23);
            this.buttonSteamSource.Name = "buttonSteamSource";
            this.buttonSteamSource.Size = new System.Drawing.Size(75, 23);
            this.buttonSteamSource.TabIndex = 2;
            this.buttonSteamSource.Text = "Browse...";
            this.buttonSteamSource.UseVisualStyleBackColor = true;
            this.buttonSteamSource.Click += new System.EventHandler(this.buttonSteamSource_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination Steam Directory";
            // 
            // textBoxSteamDest
            // 
            this.textBoxSteamDest.Location = new System.Drawing.Point(12, 64);
            this.textBoxSteamDest.Name = "textBoxSteamDest";
            this.textBoxSteamDest.Size = new System.Drawing.Size(564, 20);
            this.textBoxSteamDest.TabIndex = 4;
            // 
            // buttonSteamDest
            // 
            this.buttonSteamDest.Location = new System.Drawing.Point(582, 62);
            this.buttonSteamDest.Name = "buttonSteamDest";
            this.buttonSteamDest.Size = new System.Drawing.Size(75, 23);
            this.buttonSteamDest.TabIndex = 5;
            this.buttonSteamDest.Text = "Browse...";
            this.buttonSteamDest.UseVisualStyleBackColor = true;
            this.buttonSteamDest.Click += new System.EventHandler(this.buttonSteamDest_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(501, 164);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "Proceed";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(582, 164);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(633, 65);
            this.label3.TabIndex = 8;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 199);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonSteamDest);
            this.Controls.Add(this.textBoxSteamDest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSteamSource);
            this.Controls.Add(this.textBoxSteamSource);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SteamExtend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSteamSource;
        private System.Windows.Forms.Button buttonSteamSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSteamDest;
        private System.Windows.Forms.Button buttonSteamDest;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

