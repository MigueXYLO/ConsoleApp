namespace WindowsFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.buttonGetUCName = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUCName = new System.Windows.Forms.TextBox();
            this.btnSaveToDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(127, 43);
            this.textBoxStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(461, 22);
            this.textBoxStudentName.TabIndex = 1;
            // this.textBoxStudentName.TextChanged += new System.EventHandler(this.textBoxStudentName_TextChanged);
            // 
            // buttonGetUCName
            // 
            this.buttonGetUCName.Location = new System.Drawing.Point(21, 132);
            this.buttonGetUCName.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetUCName.Name = "buttonGetUCName";
            this.buttonGetUCName.Size = new System.Drawing.Size(152, 28);
            this.buttonGetUCName.TabIndex = 4;
            this.buttonGetUCName.Text = "Get UC Name";
            this.buttonGetUCName.UseVisualStyleBackColor = true;
            this.buttonGetUCName.Click += new System.EventHandler(this.buttonGetUCName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "UC Name";
            // 
            // textBoxUCName
            // 
            this.textBoxUCName.Location = new System.Drawing.Point(127, 81);
            this.textBoxUCName.Name = "textBoxUCName";
            this.textBoxUCName.Size = new System.Drawing.Size(461, 22);
            this.textBoxUCName.TabIndex = 6;
            // 
            // btnSaveToDatabase
            // 
            this.btnSaveToDatabase.Location = new System.Drawing.Point(436, 132);
            this.btnSaveToDatabase.Name = "btnSaveToDatabase";
            this.btnSaveToDatabase.Size = new System.Drawing.Size(152, 28);
            this.btnSaveToDatabase.TabIndex = 7;
            this.btnSaveToDatabase.Text = "Save to Database";
            this.btnSaveToDatabase.UseVisualStyleBackColor = true;
            this.btnSaveToDatabase.Click += new System.EventHandler(this.btnSaveToDatabase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 201);
            this.Controls.Add(this.btnSaveToDatabase);
            this.Controls.Add(this.textBoxUCName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGetUCName);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "EI SI Worksheet 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Button buttonGetUCName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUCName;
        private System.Windows.Forms.Button btnSaveToDatabase;
    }
}

