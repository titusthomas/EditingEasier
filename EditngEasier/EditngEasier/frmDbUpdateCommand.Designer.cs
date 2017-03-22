namespace EditngEasier
{
    partial class frmDbUpdateCommand
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtCmdNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkDbUpdateCommand = new System.Windows.Forms.CheckBox();
            this.txtVariableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkVB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(375, 411);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(159, 41);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(355, 234);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(208, 57);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "CHANGE";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(590, 4);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(324, 488);
            this.txtOutput.TabIndex = 5;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(5, 5);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(324, 488);
            this.txtInput.TabIndex = 4;
            // 
            // txtCmdNo
            // 
            this.txtCmdNo.Location = new System.Drawing.Point(355, 63);
            this.txtCmdNo.Name = "txtCmdNo";
            this.txtCmdNo.Size = new System.Drawing.Size(188, 20);
            this.txtCmdNo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Execute command starting no";
            // 
            // chkDbUpdateCommand
            // 
            this.chkDbUpdateCommand.AutoSize = true;
            this.chkDbUpdateCommand.Location = new System.Drawing.Point(358, 316);
            this.chkDbUpdateCommand.Name = "chkDbUpdateCommand";
            this.chkDbUpdateCommand.Size = new System.Drawing.Size(128, 17);
            this.chkDbUpdateCommand.TabIndex = 10;
            this.chkDbUpdateCommand.Text = "Db Update Command";
            this.chkDbUpdateCommand.UseVisualStyleBackColor = true;
            // 
            // txtVariableName
            // 
            this.txtVariableName.Location = new System.Drawing.Point(355, 385);
            this.txtVariableName.Name = "txtVariableName";
            this.txtVariableName.Size = new System.Drawing.Size(188, 20);
            this.txtVariableName.TabIndex = 11;
            this.txtVariableName.Text = "Query";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Variable Name";
            // 
            // chkVB
            // 
            this.chkVB.AutoSize = true;
            this.chkVB.Location = new System.Drawing.Point(358, 339);
            this.chkVB.Name = "chkVB";
            this.chkVB.Size = new System.Drawing.Size(40, 17);
            this.chkVB.TabIndex = 13;
            this.chkVB.Text = "VB";
            this.chkVB.UseVisualStyleBackColor = true;
            // 
            // frmDbUpdateCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 502);
            this.Controls.Add(this.chkVB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVariableName);
            this.Controls.Add(this.chkDbUpdateCommand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCmdNo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "frmDbUpdateCommand";
            this.Text = "Db Update Query Builder";
            this.Load += new System.EventHandler(this.frmDbUpdateCommand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtCmdNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDbUpdateCommand;
        private System.Windows.Forms.TextBox txtVariableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkVB;
    }
}