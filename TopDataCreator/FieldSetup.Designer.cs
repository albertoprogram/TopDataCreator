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
            this.lblType = new System.Windows.Forms.Label();
            this.lblFieldType = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblFieldLength = new System.Windows.Forms.Label();
            this.rbFillAccordingTypeLength = new System.Windows.Forms.RadioButton();
            this.btnAccept = new System.Windows.Forms.Button();
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
            this.lblFieldName.Location = new System.Drawing.Point(231, 47);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(81, 20);
            this.lblFieldName.TabIndex = 1;
            this.lblFieldName.Text = "FieldName";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(42, 102);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 20);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // lblFieldType
            // 
            this.lblFieldType.AutoSize = true;
            this.lblFieldType.Location = new System.Drawing.Point(231, 102);
            this.lblFieldType.Name = "lblFieldType";
            this.lblFieldType.Size = new System.Drawing.Size(72, 20);
            this.lblFieldType.TabIndex = 3;
            this.lblFieldType.Text = "FieldType";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(42, 163);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(54, 20);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Length";
            // 
            // lblFieldLength
            // 
            this.lblFieldLength.AutoSize = true;
            this.lblFieldLength.Location = new System.Drawing.Point(231, 163);
            this.lblFieldLength.Name = "lblFieldLength";
            this.lblFieldLength.Size = new System.Drawing.Size(86, 20);
            this.lblFieldLength.TabIndex = 5;
            this.lblFieldLength.Text = "FieldLength";
            // 
            // rbFillAccordingTypeLength
            // 
            this.rbFillAccordingTypeLength.AutoSize = true;
            this.rbFillAccordingTypeLength.Location = new System.Drawing.Point(42, 232);
            this.rbFillAccordingTypeLength.Name = "rbFillAccordingTypeLength";
            this.rbFillAccordingTypeLength.Size = new System.Drawing.Size(193, 24);
            this.rbFillAccordingTypeLength.TabIndex = 6;
            this.rbFillAccordingTypeLength.TabStop = true;
            this.rbFillAccordingTypeLength.Text = "FillAccordingTypeLength";
            this.rbFillAccordingTypeLength.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(659, 380);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(94, 29);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // FieldSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.rbFillAccordingTypeLength);
            this.Controls.Add(this.lblFieldLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblFieldType);
            this.Controls.Add(this.lblType);
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
        private Label lblType;
        private Label lblFieldType;
        private Label lblLength;
        private Label lblFieldLength;
        private RadioButton rbFillAccordingTypeLength;
        private Button btnAccept;
    }
}