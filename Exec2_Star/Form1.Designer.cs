namespace Exec2_Star
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.rowsTextBox = new System.Windows.Forms.TextBox();
            this.leftStarsButton = new System.Windows.Forms.Button();
            this.isoscelesStarsButton = new System.Windows.Forms.Button();
            this.rightStarsButton = new System.Windows.Forms.Button();
            this.starsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "列數 (1~10):";
            // 
            // rowsTextBox
            // 
            this.rowsTextBox.Location = new System.Drawing.Point(92, 27);
            this.rowsTextBox.MaxLength = 2;
            this.rowsTextBox.Name = "rowsTextBox";
            this.rowsTextBox.Size = new System.Drawing.Size(100, 23);
            this.rowsTextBox.TabIndex = 1;
            // 
            // leftStarsButton
            // 
            this.leftStarsButton.Location = new System.Drawing.Point(239, 30);
            this.leftStarsButton.Name = "leftStarsButton";
            this.leftStarsButton.Size = new System.Drawing.Size(75, 23);
            this.leftStarsButton.TabIndex = 2;
            this.leftStarsButton.Text = "靠左三角形";
            this.leftStarsButton.UseVisualStyleBackColor = true;
            this.leftStarsButton.Click += new System.EventHandler(this.leftStarsButton_Click);
            // 
            // isoscelesStarsButton
            // 
            this.isoscelesStarsButton.Location = new System.Drawing.Point(239, 122);
            this.isoscelesStarsButton.Name = "isoscelesStarsButton";
            this.isoscelesStarsButton.Size = new System.Drawing.Size(75, 23);
            this.isoscelesStarsButton.TabIndex = 4;
            this.isoscelesStarsButton.Text = "等腰三角形";
            this.isoscelesStarsButton.UseVisualStyleBackColor = true;
            this.isoscelesStarsButton.Click += new System.EventHandler(this.isoscelesStarsButton_Click);
            // 
            // rightStarsButton
            // 
            this.rightStarsButton.Location = new System.Drawing.Point(239, 76);
            this.rightStarsButton.Name = "rightStarsButton";
            this.rightStarsButton.Size = new System.Drawing.Size(75, 23);
            this.rightStarsButton.TabIndex = 3;
            this.rightStarsButton.Text = "靠右三角形";
            this.rightStarsButton.UseVisualStyleBackColor = true;
            this.rightStarsButton.Click += new System.EventHandler(this.rightStarsButton_Click);
            // 
            // starsTextBox
            // 
            this.starsTextBox.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.starsTextBox.Location = new System.Drawing.Point(12, 73);
            this.starsTextBox.Multiline = true;
            this.starsTextBox.Name = "starsTextBox";
            this.starsTextBox.ReadOnly = true;
            this.starsTextBox.Size = new System.Drawing.Size(206, 214);
            this.starsTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 326);
            this.Controls.Add(this.starsTextBox);
            this.Controls.Add(this.rightStarsButton);
            this.Controls.Add(this.isoscelesStarsButton);
            this.Controls.Add(this.leftStarsButton);
            this.Controls.Add(this.rowsTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox rowsTextBox;
        private Button leftStarsButton;
        private Button isoscelesStarsButton;
        private Button rightStarsButton;
        private TextBox starsTextBox;
    }
}