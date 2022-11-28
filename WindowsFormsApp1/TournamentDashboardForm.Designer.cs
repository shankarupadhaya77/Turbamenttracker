namespace WindowsFormsApp1
{
    partial class TournamentDashboardForm
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
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentDroupDown = new System.Windows.Forms.ComboBox();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.AutoSize = true;
            this.teamNameValue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.teamNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameValue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.teamNameValue.Location = new System.Drawing.Point(276, 138);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(413, 42);
            this.teamNameValue.TabIndex = 16;
            this.teamNameValue.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadExistingTournamentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExistingTournamentLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(347, 201);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(293, 29);
            this.loadExistingTournamentLabel.TabIndex = 24;
            this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadExistingTournamentDroupDown
            // 
            this.loadExistingTournamentDroupDown.FormattingEnabled = true;
            this.loadExistingTournamentDroupDown.Location = new System.Drawing.Point(283, 244);
            this.loadExistingTournamentDroupDown.Name = "loadExistingTournamentDroupDown";
            this.loadExistingTournamentDroupDown.Size = new System.Drawing.Size(406, 38);
            this.loadExistingTournamentDroupDown.TabIndex = 23;
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loadTournamentButton.Location = new System.Drawing.Point(398, 297);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(206, 45);
            this.loadTournamentButton.TabIndex = 25;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            this.loadTournamentButton.Click += new System.EventHandler(this.loadTournamentButton_Click);
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.AutoSize = true;
            this.createTournamentButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.createTournamentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createTournamentButton.Location = new System.Drawing.Point(316, 451);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(341, 42);
            this.createTournamentButton.TabIndex = 36;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.loadExistingTournamentDroupDown);
            this.Controls.Add(this.teamNameValue);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teamNameValue;
        private System.Windows.Forms.Label loadExistingTournamentLabel;
        private System.Windows.Forms.ComboBox loadExistingTournamentDroupDown;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Label createTournamentButton;
    }
}