namespace LeagueCreator
{
    partial class frmLeagueGenerator
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridviewPlayers = new System.Windows.Forms.DataGridView();
            this.btnCreateTeams = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 46);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(158, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Player Sheet";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "(ensure the \'Players.xls\' file is in the same directory as this executable)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "See the sample file format in \'PlayersSample.xls\' to see how to enter the player " +
    "names";
            // 
            // gridviewPlayers
            // 
            this.gridviewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewPlayers.Location = new System.Drawing.Point(12, 87);
            this.gridviewPlayers.Name = "gridviewPlayers";
            this.gridviewPlayers.Size = new System.Drawing.Size(868, 299);
            this.gridviewPlayers.TabIndex = 3;
            // 
            // btnCreateTeams
            // 
            this.btnCreateTeams.Location = new System.Drawing.Point(805, 406);
            this.btnCreateTeams.Name = "btnCreateTeams";
            this.btnCreateTeams.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTeams.TabIndex = 4;
            this.btnCreateTeams.Text = "Generate Teams";
            this.btnCreateTeams.UseVisualStyleBackColor = true;
            this.btnCreateTeams.Click += new System.EventHandler(this.btnCreateTeams_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "(outputted file will be \'Teams.xls\' in the same directory as this executable)";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(515, 46);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 6;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // frmLeagueGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 468);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreateTeams);
            this.Controls.Add(this.gridviewPlayers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Name = "frmLeagueGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "League Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridviewPlayers;
        private System.Windows.Forms.Button btnCreateTeams;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenFile;
    }
}

