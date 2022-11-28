namespace WindowsFormsApp1
{
    partial class CreateTurnamentForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.turnamentNameValue = new System.Windows.Forms.TextBox();
            this.turnamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamDroupDown = new System.Windows.Forms.ComboBox();
            this.selctTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButtom = new System.Windows.Forms.Button();
            this.turnamentPlayerListBox = new System.Windows.Forms.ListBox();
            this.turnamentPlayerLabel = new System.Windows.Forms.Label();
            this.deleteSelectedPlayersButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(36, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "Crate Tournament";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // turnamentNameValue
            // 
            this.turnamentNameValue.Location = new System.Drawing.Point(43, 92);
            this.turnamentNameValue.Name = "turnamentNameValue";
            this.turnamentNameValue.Size = new System.Drawing.Size(264, 35);
            this.turnamentNameValue.TabIndex = 13;
            this.turnamentNameValue.TextChanged += new System.EventHandler(this.teamOneScoreValue_TextChanged);
            // 
            // turnamentNameLabel
            // 
            this.turnamentNameLabel.AutoSize = true;
            this.turnamentNameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.turnamentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnamentNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.turnamentNameLabel.Location = new System.Drawing.Point(38, 60);
            this.turnamentNameLabel.Name = "turnamentNameLabel";
            this.turnamentNameLabel.Size = new System.Drawing.Size(200, 29);
            this.turnamentNameLabel.TabIndex = 12;
            this.turnamentNameLabel.Text = "Turnament Name";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(177, 133);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(100, 35);
            this.entryFeeValue.TabIndex = 15;
            this.entryFeeValue.Text = "0";
            this.entryFeeValue.TextChanged += new System.EventHandler(this.teamOneScoreValue_TextChanged_1);
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.entryFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.entryFeeLabel.Location = new System.Drawing.Point(38, 137);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(116, 29);
            this.entryFeeLabel.TabIndex = 14;
            this.entryFeeLabel.Text = "Entry Fee";
            this.entryFeeLabel.Click += new System.EventHandler(this.teamOneScoreLabel_Click);
            // 
            // selectTeamDroupDown
            // 
            this.selectTeamDroupDown.FormattingEnabled = true;
            this.selectTeamDroupDown.Location = new System.Drawing.Point(31, 230);
            this.selectTeamDroupDown.Name = "selectTeamDroupDown";
            this.selectTeamDroupDown.Size = new System.Drawing.Size(264, 38);
            this.selectTeamDroupDown.TabIndex = 17;
            this.selectTeamDroupDown.SelectedIndexChanged += new System.EventHandler(this.roundDroupDown_SelectedIndexChanged);
            // 
            // selctTeamLabel
            // 
            this.selctTeamLabel.AutoSize = true;
            this.selctTeamLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selctTeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selctTeamLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.selctTeamLabel.Location = new System.Drawing.Point(38, 190);
            this.selctTeamLabel.Name = "selctTeamLabel";
            this.selctTeamLabel.Size = new System.Drawing.Size(125, 29);
            this.selctTeamLabel.TabIndex = 16;
            this.selctTeamLabel.Text = "Add Team";
            this.selctTeamLabel.Click += new System.EventHandler(this.roundLabel_Click);
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.LinkColor = System.Drawing.Color.Navy;
            this.createNewTeamLink.Location = new System.Drawing.Point(181, 190);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(114, 30);
            this.createNewTeamLink.TabIndex = 18;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "create new";
            this.createNewTeamLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLink_LinkClicked);
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addTeamButton.Location = new System.Drawing.Point(74, 297);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(142, 45);
            this.addTeamButton.TabIndex = 19;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // createPrizeButtom
            // 
            this.createPrizeButtom.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.createPrizeButtom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButtom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButtom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPrizeButtom.Location = new System.Drawing.Point(74, 367);
            this.createPrizeButtom.Name = "createPrizeButtom";
            this.createPrizeButtom.Size = new System.Drawing.Size(142, 45);
            this.createPrizeButtom.TabIndex = 20;
            this.createPrizeButtom.Text = "Create Prize";
            this.createPrizeButtom.UseVisualStyleBackColor = true;
            this.createPrizeButtom.Click += new System.EventHandler(this.createPrizeButtom_Click);
            // 
            // turnamentPlayerListBox
            // 
            this.turnamentPlayerListBox.AccessibleName = "";
            this.turnamentPlayerListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.turnamentPlayerListBox.FormattingEnabled = true;
            this.turnamentPlayerListBox.ItemHeight = 30;
            this.turnamentPlayerListBox.Location = new System.Drawing.Point(395, 114);
            this.turnamentPlayerListBox.Name = "turnamentPlayerListBox";
            this.turnamentPlayerListBox.Size = new System.Drawing.Size(379, 152);
            this.turnamentPlayerListBox.TabIndex = 21;
            // 
            // turnamentPlayerLabel
            // 
            this.turnamentPlayerLabel.AutoSize = true;
            this.turnamentPlayerLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.turnamentPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnamentPlayerLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.turnamentPlayerLabel.Location = new System.Drawing.Point(390, 82);
            this.turnamentPlayerLabel.Name = "turnamentPlayerLabel";
            this.turnamentPlayerLabel.Size = new System.Drawing.Size(175, 29);
            this.turnamentPlayerLabel.TabIndex = 22;
            this.turnamentPlayerLabel.Text = "Teams/Players";
            this.turnamentPlayerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // deleteSelectedPlayersButton
            // 
            this.deleteSelectedPlayersButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPlayersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedPlayersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedPlayersButton.Location = new System.Drawing.Point(790, 157);
            this.deleteSelectedPlayersButton.Name = "deleteSelectedPlayersButton";
            this.deleteSelectedPlayersButton.Size = new System.Drawing.Size(93, 63);
            this.deleteSelectedPlayersButton.TabIndex = 23;
            this.deleteSelectedPlayersButton.Text = "Delete Selected";
            this.deleteSelectedPlayersButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(799, 349);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(93, 63);
            this.deleteSelectedPrizeButton.TabIndex = 26;
            this.deleteSelectedPrizeButton.Text = "Delete Selected";
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            this.deleteSelectedPrizeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.prizesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizesLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.prizesLabel.Location = new System.Drawing.Point(400, 274);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(175, 29);
            this.prizesLabel.TabIndex = 25;
            this.prizesLabel.Text = "Teams/Players";
            this.prizesLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // prizesListBox
            // 
            this.prizesListBox.AccessibleName = "";
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 30;
            this.prizesListBox.Location = new System.Drawing.Point(405, 312);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(369, 152);
            this.prizesListBox.TabIndex = 24;
            this.prizesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // createTournamentButtom
            // 
            this.createTournamentButtom.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.createTournamentButtom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButtom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButtom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentButtom.Location = new System.Drawing.Point(227, 495);
            this.createTournamentButtom.Name = "createTournamentButtom";
            this.createTournamentButtom.Size = new System.Drawing.Size(221, 43);
            this.createTournamentButtom.TabIndex = 27;
            this.createTournamentButtom.Text = "Create Tournament";
            this.createTournamentButtom.UseVisualStyleBackColor = true;
            this.createTournamentButtom.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CreateTurnamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.createTournamentButtom);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deleteSelectedPlayersButton);
            this.Controls.Add(this.turnamentPlayerLabel);
            this.Controls.Add(this.turnamentPlayerListBox);
            this.Controls.Add(this.createPrizeButtom);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamDroupDown);
            this.Controls.Add(this.selctTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.turnamentNameValue);
            this.Controls.Add(this.turnamentNameLabel);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTurnamentForm";
            this.Text = "Create Turnament";
            this.Load += new System.EventHandler(this.CreateTurnamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox turnamentNameValue;
        private System.Windows.Forms.Label turnamentNameLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox selectTeamDroupDown;
        private System.Windows.Forms.Label selctTeamLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButtom;
        private System.Windows.Forms.ListBox turnamentPlayerListBox;
        private System.Windows.Forms.Label turnamentPlayerLabel;
        private System.Windows.Forms.Button deleteSelectedPlayersButton;
        private System.Windows.Forms.Button deleteSelectedPrizeButton;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTournamentButtom;
    }
}