namespace TopDataCreator
{
    partial class FieldSetup
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
            this.lblField = new System.Windows.Forms.Label();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(42, 47);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(41, 20);
            this.lblField.TabIndex = 0;
            this.lblField.Text = "Field";
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Location = new System.Drawing.Point(176, 47);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(81, 20);
            this.lblFieldName.TabIndex = 1;
            this.lblFieldName.Text = "FieldName";
            // 
            // FieldSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFieldName);
            this.Controls.Add(this.lblField);
            this.Name = "FieldSetup";
            this.Text = "FieldSetup";
            this.Load += new System.EventHandler(this.FieldSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblField;
        private Label lblFieldName;
    }
}