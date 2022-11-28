namespace WindowsFormsApp1
{
    partial class CreatePrizeForm
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
            this.teamNameValue = new System.Windows.Forms.Label();
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.prizeAmountValue = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.prizePercentageValue = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Label();
            this.CreatePrizeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.AutoSize = true;
            this.teamNameValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.teamNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameValue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.teamNameValue.Location = new System.Drawing.Point(-4, 23);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(225, 42);
            this.teamNameValue.TabIndex = 15;
            this.teamNameValue.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.Location = new System.Drawing.Point(227, 79);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(248, 35);
            this.placeNumberValue.TabIndex = 27;
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.placeNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNumberLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.placeNumberLabel.Location = new System.Drawing.Point(23, 79);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(167, 29);
            this.placeNumberLabel.TabIndex = 26;
            this.placeNumberLabel.Text = "Place Number";
            // 
            // placeNameValue
            // 
            this.placeNameValue.Location = new System.Drawing.Point(227, 120);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(248, 35);
            this.placeNameValue.TabIndex = 29;
            this.placeNameValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.placeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.placeNameLabel.Location = new System.Drawing.Point(23, 120);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(145, 29);
            this.placeNameLabel.TabIndex = 28;
            this.placeNameLabel.Text = "Place Name";
            this.placeNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // prizeAmountValue
            // 
            this.prizeAmountValue.Location = new System.Drawing.Point(227, 174);
            this.prizeAmountValue.Name = "prizeAmountValue";
            this.prizeAmountValue.Size = new System.Drawing.Size(248, 35);
            this.prizeAmountValue.TabIndex = 31;
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.prizeAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeAmountLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.prizeAmountLabel.Location = new System.Drawing.Point(23, 178);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(161, 29);
            this.prizeAmountLabel.TabIndex = 30;
            this.prizeAmountLabel.Text = "Prize Amount ";
            // 
            // prizePercentageValue
            // 
            this.prizePercentageValue.Location = new System.Drawing.Point(240, 289);
            this.prizePercentageValue.Name = "prizePercentageValue";
            this.prizePercentageValue.Size = new System.Drawing.Size(248, 35);
            this.prizePercentageValue.TabIndex = 33;
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePercentageLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.prizePercentageLabel.Location = new System.Drawing.Point(23, 289);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(198, 29);
            this.prizePercentageLabel.TabIndex = 32;
            this.prizePercentageLabel.Text = "Prize Percentage";
            this.prizePercentageLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.orLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.orLabel.Location = new System.Drawing.Point(184, 247);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(65, 29);
            this.orLabel.TabIndex = 34;
            this.orLabel.Text = "-OR-";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.AutoSize = true;
            this.createPrizeButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.createPrizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createPrizeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createPrizeButton.Location = new System.Drawing.Point(220, 431);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(204, 42);
            this.createPrizeButton.TabIndex = 35;
            this.createPrizeButton.Text = "Crate Prize";
            // 
            // CreatePrizeBtn
            // 
            this.CreatePrizeBtn.Location = new System.Drawing.Point(301, 344);
            this.CreatePrizeBtn.Name = "CreatePrizeBtn";
            this.CreatePrizeBtn.Size = new System.Drawing.Size(123, 35);
            this.CreatePrizeBtn.TabIndex = 36;
            this.CreatePrizeBtn.Text = "Save";
            this.CreatePrizeBtn.UseVisualStyleBackColor = true;
            this.CreatePrizeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.CreatePrizeBtn);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizePercentageValue);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.prizeAmountValue);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreatePrizeForm";
            this.Text = "CreatePrizeForm";
            this.Load += new System.EventHandler(this.CreatePrizeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teamNameValue;
        private System.Windows.Forms.TextBox placeNumberValue;
        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.TextBox placeNameValue;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox prizeAmountValue;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.TextBox prizePercentageValue;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Label createPrizeButton;
        private System.Windows.Forms.Button CreatePrizeBtn;
    }
}