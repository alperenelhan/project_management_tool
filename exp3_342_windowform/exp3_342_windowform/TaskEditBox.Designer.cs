namespace exp3_342_windowform
{
    partial class TaskEditBox
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
            this.hourWorkedTextBox = new System.Windows.Forms.TextBox();
            this.isTaskCompletedBox = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work Hour                 :";
            // 
            // hourWorkedTextBox
            // 
            this.hourWorkedTextBox.Location = new System.Drawing.Point(167, 31);
            this.hourWorkedTextBox.Name = "hourWorkedTextBox";
            this.hourWorkedTextBox.Size = new System.Drawing.Size(44, 20);
            this.hourWorkedTextBox.TabIndex = 1;
            this.hourWorkedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HourWorkedBoxKeyPress);
            // 
            // isTaskCompletedBox
            // 
            this.isTaskCompletedBox.AutoSize = true;
            this.isTaskCompletedBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isTaskCompletedBox.Location = new System.Drawing.Point(51, 76);
            this.isTaskCompletedBox.Name = "isTaskCompletedBox";
            this.isTaskCompletedBox.Size = new System.Drawing.Size(129, 17);
            this.isTaskCompletedBox.TabIndex = 3;
            this.isTaskCompletedBox.Text = "Is Task Completed?  :";
            this.isTaskCompletedBox.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(195, 136);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(114, 136);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // TaskEditBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(279, 171);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.isTaskCompletedBox);
            this.Controls.Add(this.hourWorkedTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TaskEditBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hourWorkedTextBox;
        private System.Windows.Forms.CheckBox isTaskCompletedBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
    }
}