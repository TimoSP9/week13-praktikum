
namespace week13_praktikum
{
    partial class Form1
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
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_playerid = new System.Windows.Forms.Label();
            this.lbl_playername = new System.Windows.Forms.Label();
            this.lbl_birthdate = new System.Windows.Forms.Label();
            this.lbl_nation = new System.Windows.Forms.Label();
            this.lbl_team = new System.Windows.Forms.Label();
            this.lbl_teamnumber = new System.Windows.Forms.Label();
            this.tb_playerid = new System.Windows.Forms.TextBox();
            this.tb_playername = new System.Windows.Forms.TextBox();
            this.date_birth = new System.Windows.Forms.DateTimePicker();
            this.cb_nation = new System.Windows.Forms.ComboBox();
            this.num_team = new System.Windows.Forms.NumericUpDown();
            this.lbl_adatidak = new System.Windows.Forms.Label();
            this.cb_team = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_team)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(104, 59);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(75, 67);
            this.btn_first.TabIndex = 0;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(245, 59);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 67);
            this.btn_prev.TabIndex = 1;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(389, 59);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 67);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(506, 59);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(75, 67);
            this.btn_last.TabIndex = 3;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(104, 461);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(183, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(389, 461);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(192, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_playerid
            // 
            this.lbl_playerid.AutoSize = true;
            this.lbl_playerid.Location = new System.Drawing.Point(104, 159);
            this.lbl_playerid.Name = "lbl_playerid";
            this.lbl_playerid.Size = new System.Drawing.Size(65, 17);
            this.lbl_playerid.TabIndex = 6;
            this.lbl_playerid.Text = "Player ID";
            // 
            // lbl_playername
            // 
            this.lbl_playername.AutoSize = true;
            this.lbl_playername.Location = new System.Drawing.Point(104, 215);
            this.lbl_playername.Name = "lbl_playername";
            this.lbl_playername.Size = new System.Drawing.Size(89, 17);
            this.lbl_playername.TabIndex = 7;
            this.lbl_playername.Text = "Player Name";
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Location = new System.Drawing.Point(104, 267);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(67, 17);
            this.lbl_birthdate.TabIndex = 8;
            this.lbl_birthdate.Text = "BirthDate";
            // 
            // lbl_nation
            // 
            this.lbl_nation.AutoSize = true;
            this.lbl_nation.Location = new System.Drawing.Point(104, 318);
            this.lbl_nation.Name = "lbl_nation";
            this.lbl_nation.Size = new System.Drawing.Size(74, 17);
            this.lbl_nation.TabIndex = 9;
            this.lbl_nation.Text = "Nationality";
            // 
            // lbl_team
            // 
            this.lbl_team.AutoSize = true;
            this.lbl_team.Location = new System.Drawing.Point(104, 373);
            this.lbl_team.Name = "lbl_team";
            this.lbl_team.Size = new System.Drawing.Size(44, 17);
            this.lbl_team.TabIndex = 10;
            this.lbl_team.Text = "Team";
            // 
            // lbl_teamnumber
            // 
            this.lbl_teamnumber.AutoSize = true;
            this.lbl_teamnumber.Location = new System.Drawing.Point(104, 410);
            this.lbl_teamnumber.Name = "lbl_teamnumber";
            this.lbl_teamnumber.Size = new System.Drawing.Size(98, 17);
            this.lbl_teamnumber.TabIndex = 11;
            this.lbl_teamnumber.Text = "Team Number";
            // 
            // tb_playerid
            // 
            this.tb_playerid.Location = new System.Drawing.Point(245, 153);
            this.tb_playerid.Name = "tb_playerid";
            this.tb_playerid.Size = new System.Drawing.Size(336, 22);
            this.tb_playerid.TabIndex = 12;
            // 
            // tb_playername
            // 
            this.tb_playername.Location = new System.Drawing.Point(245, 212);
            this.tb_playername.Name = "tb_playername";
            this.tb_playername.Size = new System.Drawing.Size(336, 22);
            this.tb_playername.TabIndex = 13;
            // 
            // date_birth
            // 
            this.date_birth.Location = new System.Drawing.Point(245, 267);
            this.date_birth.Name = "date_birth";
            this.date_birth.Size = new System.Drawing.Size(336, 22);
            this.date_birth.TabIndex = 14;
            // 
            // cb_nation
            // 
            this.cb_nation.FormattingEnabled = true;
            this.cb_nation.Location = new System.Drawing.Point(245, 311);
            this.cb_nation.Name = "cb_nation";
            this.cb_nation.Size = new System.Drawing.Size(336, 24);
            this.cb_nation.TabIndex = 15;
            // 
            // num_team
            // 
            this.num_team.Location = new System.Drawing.Point(245, 404);
            this.num_team.Name = "num_team";
            this.num_team.Size = new System.Drawing.Size(219, 22);
            this.num_team.TabIndex = 17;
            // 
            // lbl_adatidak
            // 
            this.lbl_adatidak.AutoSize = true;
            this.lbl_adatidak.Location = new System.Drawing.Point(495, 404);
            this.lbl_adatidak.Name = "lbl_adatidak";
            this.lbl_adatidak.Size = new System.Drawing.Size(0, 17);
            this.lbl_adatidak.TabIndex = 18;
            // 
            // cb_team
            // 
            this.cb_team.FormattingEnabled = true;
            this.cb_team.Location = new System.Drawing.Point(245, 366);
            this.cb_team.Name = "cb_team";
            this.cb_team.Size = new System.Drawing.Size(336, 24);
            this.cb_team.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.cb_team);
            this.Controls.Add(this.lbl_adatidak);
            this.Controls.Add(this.num_team);
            this.Controls.Add(this.cb_nation);
            this.Controls.Add(this.date_birth);
            this.Controls.Add(this.tb_playername);
            this.Controls.Add(this.tb_playerid);
            this.Controls.Add(this.lbl_teamnumber);
            this.Controls.Add(this.lbl_team);
            this.Controls.Add(this.lbl_nation);
            this.Controls.Add(this.lbl_birthdate);
            this.Controls.Add(this.lbl_playername);
            this.Controls.Add(this.lbl_playerid);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_first);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_team)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_playerid;
        private System.Windows.Forms.Label lbl_playername;
        private System.Windows.Forms.Label lbl_birthdate;
        private System.Windows.Forms.Label lbl_nation;
        private System.Windows.Forms.Label lbl_team;
        private System.Windows.Forms.Label lbl_teamnumber;
        private System.Windows.Forms.TextBox tb_playerid;
        private System.Windows.Forms.TextBox tb_playername;
        private System.Windows.Forms.DateTimePicker date_birth;
        private System.Windows.Forms.ComboBox cb_nation;
        private System.Windows.Forms.NumericUpDown num_team;
        private System.Windows.Forms.Label lbl_adatidak;
        private System.Windows.Forms.ComboBox cb_team;
    }
}

