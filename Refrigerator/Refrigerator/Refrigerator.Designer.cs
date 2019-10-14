namespace Refrigerator
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
            this.maximumWeightEntiyTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.noOfItemsextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currentTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.remanigTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mximum weight it can be take";
            // 
            // maximumWeightEntiyTextBox
            // 
            this.maximumWeightEntiyTextBox.Location = new System.Drawing.Point(203, 62);
            this.maximumWeightEntiyTextBox.Name = "maximumWeightEntiyTextBox";
            this.maximumWeightEntiyTextBox.Size = new System.Drawing.Size(145, 20);
            this.maximumWeightEntiyTextBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(426, 62);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 26);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "No of Items";
            // 
            // noOfItemsextBox
            // 
            this.noOfItemsextBox.Location = new System.Drawing.Point(173, 114);
            this.noOfItemsextBox.Name = "noOfItemsextBox";
            this.noOfItemsextBox.Size = new System.Drawing.Size(145, 20);
            this.noOfItemsextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Weight(kg)/unit";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(484, 114);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(145, 20);
            this.weightTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Current (Weight)";
            // 
            // currentTextBox
            // 
            this.currentTextBox.Location = new System.Drawing.Point(173, 170);
            this.currentTextBox.Name = "currentTextBox";
            this.currentTextBox.Size = new System.Drawing.Size(145, 20);
            this.currentTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Remaning (weight)";
            // 
            // remanigTextBox
            // 
            this.remanigTextBox.Location = new System.Drawing.Point(484, 170);
            this.remanigTextBox.Name = "remanigTextBox";
            this.remanigTextBox.Size = new System.Drawing.Size(145, 20);
            this.remanigTextBox.TabIndex = 4;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(667, 117);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(94, 26);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 244);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.remanigTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.noOfItemsextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maximumWeightEntiyTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Refrigerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maximumWeightEntiyTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox noOfItemsextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox currentTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox remanigTextBox;
        private System.Windows.Forms.Button enterButton;
    }
}

