namespace AcountOperationApp
{
    partial class accountOperationUI
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
            this.accountCreationGroupBox = new System.Windows.Forms.GroupBox();
            this.transactionGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.accountCreateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.accountCreationGroupBox.SuspendLayout();
            this.transactionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountCreationGroupBox
            // 
            this.accountCreationGroupBox.Controls.Add(this.accountCreateButton);
            this.accountCreationGroupBox.Controls.Add(this.accountNumberTextBox);
            this.accountCreationGroupBox.Controls.Add(this.customerNameTextBox);
            this.accountCreationGroupBox.Controls.Add(this.label2);
            this.accountCreationGroupBox.Controls.Add(this.label1);
            this.accountCreationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.accountCreationGroupBox.Name = "accountCreationGroupBox";
            this.accountCreationGroupBox.Size = new System.Drawing.Size(347, 100);
            this.accountCreationGroupBox.TabIndex = 0;
            this.accountCreationGroupBox.TabStop = false;
            this.accountCreationGroupBox.Text = "Account Creation";
            // 
            // transactionGroupBox
            // 
            this.transactionGroupBox.Controls.Add(this.withdrawButton);
            this.transactionGroupBox.Controls.Add(this.depositButton);
            this.transactionGroupBox.Controls.Add(this.amountTextBox);
            this.transactionGroupBox.Controls.Add(this.label3);
            this.transactionGroupBox.Location = new System.Drawing.Point(12, 118);
            this.transactionGroupBox.Name = "transactionGroupBox";
            this.transactionGroupBox.Size = new System.Drawing.Size(347, 78);
            this.transactionGroupBox.TabIndex = 1;
            this.transactionGroupBox.TabStop = false;
            this.transactionGroupBox.Text = "Transaction";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Name";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(119, 43);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(222, 20);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(119, 15);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(222, 20);
            this.accountNumberTextBox.TabIndex = 0;
            // 
            // accountCreateButton
            // 
            this.accountCreateButton.Location = new System.Drawing.Point(265, 70);
            this.accountCreateButton.Name = "accountCreateButton";
            this.accountCreateButton.Size = new System.Drawing.Size(75, 23);
            this.accountCreateButton.TabIndex = 2;
            this.accountCreateButton.Text = "Create";
            this.accountCreateButton.UseVisualStyleBackColor = true;
            this.accountCreateButton.Click += new System.EventHandler(this.accountCreateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amount";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(115, 14);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(225, 20);
            this.amountTextBox.TabIndex = 0;
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(115, 40);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 1;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(265, 40);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(197, 203);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 0;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // accountOperationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 261);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.transactionGroupBox);
            this.Controls.Add(this.accountCreationGroupBox);
            this.Name = "accountOperationUI";
            this.Text = "Account Operation";
            this.accountCreationGroupBox.ResumeLayout(false);
            this.accountCreationGroupBox.PerformLayout();
            this.transactionGroupBox.ResumeLayout(false);
            this.transactionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox accountCreationGroupBox;
        private System.Windows.Forms.Button accountCreateButton;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox transactionGroupBox;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button reportButton;
    }
}

