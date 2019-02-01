namespace TestManagement.Forms
{
    partial class GUI_TestCase
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
            this.TestName = new System.Windows.Forms.TextBox();
            this.Documentation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ExpectedResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddStep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Case";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // TestName
            // 
            this.TestName.Location = new System.Drawing.Point(19, 65);
            this.TestName.Name = "TestName";
            this.TestName.Size = new System.Drawing.Size(100, 20);
            this.TestName.TabIndex = 2;
            // 
            // Documentation
            // 
            this.Documentation.Location = new System.Drawing.Point(19, 105);
            this.Documentation.Name = "Documentation";
            this.Documentation.Size = new System.Drawing.Size(100, 20);
            this.Documentation.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Documetation:";
            // 
            // ExpectedResult
            // 
            this.ExpectedResult.Location = new System.Drawing.Point(149, 65);
            this.ExpectedResult.Multiline = true;
            this.ExpectedResult.Name = "ExpectedResult";
            this.ExpectedResult.Size = new System.Drawing.Size(250, 60);
            this.ExpectedResult.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Expected Result:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(435, 48);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddStep
            // 
            this.AddStep.Location = new System.Drawing.Point(19, 132);
            this.AddStep.Name = "AddStep";
            this.AddStep.Size = new System.Drawing.Size(75, 23);
            this.AddStep.TabIndex = 8;
            this.AddStep.Text = "Add Step";
            this.AddStep.UseVisualStyleBackColor = true;
            this.AddStep.Click += new System.EventHandler(this.AddStep_Click);
            // 
            // GUI_TestCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddStep);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ExpectedResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Documentation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TestName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUI_TestCase";
            this.Text = "TestCase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TestName;
        private System.Windows.Forms.TextBox Documentation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ExpectedResult;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AddStep;
    }
}