namespace GameScreen_FormApp
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dexterityLabel;
            System.Windows.Forms.Label expLabel;
            System.Windows.Forms.Label goldLabel;
            System.Windows.Forms.Label intelligenceLabel;
            System.Windows.Forms.Label levelLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label staminaLabel;
            System.Windows.Forms.Label strengthLabel;
            this.overallSplitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.partyTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.updateInfobutton = new System.Windows.Forms.Button();
            this.dexterityValueLabel = new System.Windows.Forms.Label();
            this.expValueLabel = new System.Windows.Forms.Label();
            this.levelValueLabel = new System.Windows.Forms.Label();
            this.strengthValueLabel = new System.Windows.Forms.Label();
            this.intelligenceValueLabel = new System.Windows.Forms.Label();
            this.staminaValueLabel = new System.Windows.Forms.Label();
            this.nameValueLabel = new System.Windows.Forms.Label();
            this.goldValueLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MainWindowTimer = new System.Windows.Forms.Timer(this.components);
            this.currentLocationPictureBox = new System.Windows.Forms.PictureBox();
            this.gameSessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            dexterityLabel = new System.Windows.Forms.Label();
            expLabel = new System.Windows.Forms.Label();
            goldLabel = new System.Windows.Forms.Label();
            intelligenceLabel = new System.Windows.Forms.Label();
            levelLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            staminaLabel = new System.Windows.Forms.Label();
            strengthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.overallSplitContainer)).BeginInit();
            this.overallSplitContainer.Panel1.SuspendLayout();
            this.overallSplitContainer.Panel2.SuspendLayout();
            this.overallSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.partyTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentLocationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameSessionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dexterityLabel
            // 
            dexterityLabel.AutoSize = true;
            dexterityLabel.Location = new System.Drawing.Point(31, 162);
            dexterityLabel.Name = "dexterityLabel";
            dexterityLabel.Size = new System.Drawing.Size(51, 13);
            dexterityLabel.TabIndex = 0;
            dexterityLabel.Text = "Dexterity:";
            // 
            // expLabel
            // 
            expLabel.AutoSize = true;
            expLabel.Location = new System.Drawing.Point(31, 82);
            expLabel.Name = "expLabel";
            expLabel.Size = new System.Drawing.Size(28, 13);
            expLabel.TabIndex = 2;
            expLabel.Text = "Exp:";
            // 
            // goldLabel
            // 
            goldLabel.AutoSize = true;
            goldLabel.Location = new System.Drawing.Point(31, 107);
            goldLabel.Name = "goldLabel";
            goldLabel.Size = new System.Drawing.Size(32, 13);
            goldLabel.TabIndex = 4;
            goldLabel.Text = "Gold:";
            // 
            // intelligenceLabel
            // 
            intelligenceLabel.AutoSize = true;
            intelligenceLabel.Location = new System.Drawing.Point(31, 185);
            intelligenceLabel.Name = "intelligenceLabel";
            intelligenceLabel.Size = new System.Drawing.Size(64, 13);
            intelligenceLabel.TabIndex = 6;
            intelligenceLabel.Text = "Intelligence:";
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Location = new System.Drawing.Point(31, 58);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new System.Drawing.Size(36, 13);
            levelLabel.TabIndex = 8;
            levelLabel.Text = "Level:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(9, 21);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Name:";
            // 
            // staminaLabel
            // 
            staminaLabel.AutoSize = true;
            staminaLabel.Location = new System.Drawing.Point(31, 210);
            staminaLabel.Name = "staminaLabel";
            staminaLabel.Size = new System.Drawing.Size(48, 13);
            staminaLabel.TabIndex = 12;
            staminaLabel.Text = "Stamina:";
            // 
            // strengthLabel
            // 
            strengthLabel.AutoSize = true;
            strengthLabel.Location = new System.Drawing.Point(31, 233);
            strengthLabel.Name = "strengthLabel";
            strengthLabel.Size = new System.Drawing.Size(50, 13);
            strengthLabel.TabIndex = 14;
            strengthLabel.Text = "Strength:";
            // 
            // overallSplitContainer
            // 
            this.overallSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overallSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.overallSplitContainer.Name = "overallSplitContainer";
            // 
            // overallSplitContainer.Panel1
            // 
            this.overallSplitContainer.Panel1.Controls.Add(this.splitContainer2);
            // 
            // overallSplitContainer.Panel2
            // 
            this.overallSplitContainer.Panel2.Controls.Add(this.groupBox1);
            this.overallSplitContainer.Size = new System.Drawing.Size(1067, 554);
            this.overallSplitContainer.SplitterDistance = 215;
            this.overallSplitContainer.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.partyTabControl);
            this.splitContainer2.Size = new System.Drawing.Size(215, 554);
            this.splitContainer2.SplitterDistance = 344;
            this.splitContainer2.TabIndex = 0;
            // 
            // partyTabControl
            // 
            this.partyTabControl.Controls.Add(this.tabPage1);
            this.partyTabControl.Controls.Add(this.tabPage2);
            this.partyTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partyTabControl.Location = new System.Drawing.Point(0, 0);
            this.partyTabControl.Name = "partyTabControl";
            this.partyTabControl.SelectedIndex = 0;
            this.partyTabControl.Size = new System.Drawing.Size(215, 344);
            this.partyTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.updateInfobutton);
            this.tabPage1.Controls.Add(dexterityLabel);
            this.tabPage1.Controls.Add(this.dexterityValueLabel);
            this.tabPage1.Controls.Add(this.expValueLabel);
            this.tabPage1.Controls.Add(levelLabel);
            this.tabPage1.Controls.Add(this.levelValueLabel);
            this.tabPage1.Controls.Add(this.strengthValueLabel);
            this.tabPage1.Controls.Add(this.intelligenceValueLabel);
            this.tabPage1.Controls.Add(expLabel);
            this.tabPage1.Controls.Add(nameLabel);
            this.tabPage1.Controls.Add(strengthLabel);
            this.tabPage1.Controls.Add(intelligenceLabel);
            this.tabPage1.Controls.Add(this.staminaValueLabel);
            this.tabPage1.Controls.Add(this.nameValueLabel);
            this.tabPage1.Controls.Add(goldLabel);
            this.tabPage1.Controls.Add(this.goldValueLabel);
            this.tabPage1.Controls.Add(staminaLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(207, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Player";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // updateInfobutton
            // 
            this.updateInfobutton.Location = new System.Drawing.Point(109, 285);
            this.updateInfobutton.Name = "updateInfobutton";
            this.updateInfobutton.Size = new System.Drawing.Size(75, 23);
            this.updateInfobutton.TabIndex = 16;
            this.updateInfobutton.Text = "Update Info";
            this.updateInfobutton.UseVisualStyleBackColor = true;
            this.updateInfobutton.Click += new System.EventHandler(this.UpdateInfobutton_Click);
            // 
            // dexterityValueLabel
            // 
            this.dexterityValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameSessionBindingSource, "currentPlayer.Dexterity", true));
            this.dexterityValueLabel.Location = new System.Drawing.Point(101, 162);
            this.dexterityValueLabel.Name = "dexterityValueLabel";
            this.dexterityValueLabel.Size = new System.Drawing.Size(43, 23);
            this.dexterityValueLabel.TabIndex = 1;
            this.dexterityValueLabel.Text = "0";
            // 
            // expValueLabel
            // 
            this.expValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameSessionBindingSource, "CurrentPlayer.Exp", true));
            this.expValueLabel.Location = new System.Drawing.Point(101, 82);
            this.expValueLabel.Name = "expValueLabel";
            this.expValueLabel.Size = new System.Drawing.Size(83, 23);
            this.expValueLabel.TabIndex = 3;
            this.expValueLabel.Text = "0";
            // 
            // levelValueLabel
            // 
            this.levelValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameSessionBindingSource, "currentPlayer.Level", true));
            this.levelValueLabel.Location = new System.Drawing.Point(101, 58);
            this.levelValueLabel.Name = "levelValueLabel";
            this.levelValueLabel.Size = new System.Drawing.Size(83, 23);
            this.levelValueLabel.TabIndex = 9;
            this.levelValueLabel.Text = "0";
            // 
            // strengthValueLabel
            // 
            this.strengthValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameSessionBindingSource, "currentPlayer.Strength", true));
            this.strengthValueLabel.Location = new System.Drawing.Point(101, 233);
            this.strengthValueLabel.Name = "strengthValueLabel";
            this.strengthValueLabel.Size = new System.Drawing.Size(43, 23);
            this.strengthValueLabel.TabIndex = 15;
            this.strengthValueLabel.Text = "0";
            // 
            // intelligenceValueLabel
            // 
            this.intelligenceValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameSessionBindingSource, "currentPlayer.Intelligence", true));
            this.intelligenceValueLabel.Location = new System.Drawing.Point(101, 185);
            this.intelligenceValueLabel.Name = "intelligenceValueLabel";
            this.intelligenceValueLabel.Size = new System.Drawing.Size(43, 23);
            this.intelligenceValueLabel.TabIndex = 7;
            this.intelligenceValueLabel.Text = "0";
            // 
            // staminaValueLabel
            // 
            this.staminaValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameSessionBindingSource, "currentPlayer.Stamina", true));
            this.staminaValueLabel.Location = new System.Drawing.Point(101, 210);
            this.staminaValueLabel.Name = "staminaValueLabel";
            this.staminaValueLabel.Size = new System.Drawing.Size(43, 23);
            this.staminaValueLabel.TabIndex = 13;
            this.staminaValueLabel.Text = "0";
            // 
            // nameValueLabel
            // 
            this.nameValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameSessionBindingSource, "CurrentPlayer.Name", true));
            this.nameValueLabel.Location = new System.Drawing.Point(79, 21);
            this.nameValueLabel.Name = "nameValueLabel";
            this.nameValueLabel.Size = new System.Drawing.Size(83, 23);
            this.nameValueLabel.TabIndex = 11;
            this.nameValueLabel.Text = "Player";
            // 
            // goldValueLabel
            // 
            this.goldValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameSessionBindingSource, "currentPlayer.Gold", true));
            this.goldValueLabel.Location = new System.Drawing.Point(101, 107);
            this.goldValueLabel.Name = "goldValueLabel";
            this.goldValueLabel.Size = new System.Drawing.Size(43, 23);
            this.goldValueLabel.TabIndex = 5;
            this.goldValueLabel.Text = "0";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(207, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.currentLocationPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(565, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CurrentLocation";
            // 
            // MainWindowTimer
            // 
            this.MainWindowTimer.Tick += new System.EventHandler(this.MainWindowTimer_Tick);
            // 
            // currentLocationPictureBox
            // 
            this.currentLocationPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.gameSessionBindingSource, "CurrentLocation.ImageName", true));
            this.currentLocationPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentLocationPictureBox.Location = new System.Drawing.Point(3, 16);
            this.currentLocationPictureBox.Name = "currentLocationPictureBox";
            this.currentLocationPictureBox.Size = new System.Drawing.Size(265, 199);
            this.currentLocationPictureBox.TabIndex = 0;
            this.currentLocationPictureBox.TabStop = false;
            // 
            // gameSessionBindingSource
            // 
            this.gameSessionBindingSource.DataSource = typeof(Engine.ViewModels.GameSession);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.overallSplitContainer);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.overallSplitContainer.Panel1.ResumeLayout(false);
            this.overallSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.overallSplitContainer)).EndInit();
            this.overallSplitContainer.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.partyTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentLocationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameSessionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer overallSplitContainer;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentPlayerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label dexterityValueLabel;
        private System.Windows.Forms.BindingSource gameSessionBindingSource;
        private System.Windows.Forms.Label expValueLabel;
        private System.Windows.Forms.Label goldValueLabel;
        private System.Windows.Forms.Label intelligenceValueLabel;
        private System.Windows.Forms.Label levelValueLabel;
        private System.Windows.Forms.Label nameValueLabel;
        private System.Windows.Forms.Label staminaValueLabel;
        private System.Windows.Forms.Label strengthValueLabel;
        private System.Windows.Forms.TabControl partyTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button updateInfobutton;
        private System.Windows.Forms.Timer MainWindowTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox currentLocationPictureBox;
    }
}

