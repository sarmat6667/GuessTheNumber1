namespace GuessTheNumber
{
    partial class ResultForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.topPlayersGrid = new System.Windows.Forms.DataGridView();
            this.btnChangeUser = new System.Windows.Forms.Button();
            this.allPlayersListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.topPlayersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(141, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(139, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(93, 288);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(186, 55);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // topPlayersGrid
            // 
            this.topPlayersGrid.AllowUserToAddRows = false;
            this.topPlayersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.topPlayersGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.topPlayersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.topPlayersGrid.Location = new System.Drawing.Point(596, 243);
            this.topPlayersGrid.Name = "topPlayersGrid";
            this.topPlayersGrid.ReadOnly = true;
            this.topPlayersGrid.RowHeadersWidth = 51;
            this.topPlayersGrid.RowTemplate.Height = 24;
            this.topPlayersGrid.Size = new System.Drawing.Size(301, 230);
            this.topPlayersGrid.TabIndex = 3;
            // 
            // btnChangeUser
            // 
            this.btnChangeUser.Location = new System.Drawing.Point(81, 376);
            this.btnChangeUser.Name = "btnChangeUser";
            this.btnChangeUser.Size = new System.Drawing.Size(212, 62);
            this.btnChangeUser.TabIndex = 4;
            this.btnChangeUser.Text = "Сменить игрока";
            this.btnChangeUser.UseVisualStyleBackColor = true;
            this.btnChangeUser.Click += new System.EventHandler(this.btnChangeUser_Click);
            // 
            // allPlayersListBox
            // 
            this.allPlayersListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.allPlayersListBox.FormattingEnabled = true;
            this.allPlayersListBox.ItemHeight = 16;
            this.allPlayersListBox.Location = new System.Drawing.Point(596, 12);
            this.allPlayersListBox.Name = "allPlayersListBox";
            this.allPlayersListBox.Size = new System.Drawing.Size(301, 196);
            this.allPlayersListBox.TabIndex = 5;
            this.allPlayersListBox.SelectedIndexChanged += new System.EventHandler(this.allPlayersListBox_SelectedIndexChanged);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.allPlayersListBox);
            this.Controls.Add(this.btnChangeUser);
            this.Controls.Add(this.topPlayersGrid);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topPlayersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView topPlayersGrid;
        private System.Windows.Forms.Button btnChangeUser;
        private System.Windows.Forms.ListBox allPlayersListBox;
    }
}