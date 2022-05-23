
namespace PratikumWeek13
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
            this.lbl_playerID = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_birthdate = new System.Windows.Forms.Label();
            this.lbl_nationality = new System.Windows.Forms.Label();
            this.lbl_team = new System.Windows.Forms.Label();
            this.lbl_teamNumber = new System.Windows.Forms.Label();
            this.tb_playerID = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.dtp_birthdate = new System.Windows.Forms.DateTimePicker();
            this.cb_team = new System.Windows.Forms.ComboBox();
            this.nud_TeamNumber = new System.Windows.Forms.NumericUpDown();
            this.lbl_avail = new System.Windows.Forms.Label();
            this.cb_nation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TeamNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(39, 29);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(54, 52);
            this.btn_first.TabIndex = 0;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(118, 29);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(54, 52);
            this.btn_prev.TabIndex = 1;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(206, 29);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(54, 52);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(296, 29);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(54, 52);
            this.btn_last.TabIndex = 3;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(47, 391);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(125, 28);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(225, 391);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(125, 28);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_playerID
            // 
            this.lbl_playerID.AutoSize = true;
            this.lbl_playerID.Location = new System.Drawing.Point(47, 105);
            this.lbl_playerID.Name = "lbl_playerID";
            this.lbl_playerID.Size = new System.Drawing.Size(65, 17);
            this.lbl_playerID.TabIndex = 6;
            this.lbl_playerID.Text = "Player ID";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(47, 149);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(89, 17);
            this.lbl_Name.TabIndex = 7;
            this.lbl_Name.Text = "Player Name";
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Location = new System.Drawing.Point(47, 191);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(67, 17);
            this.lbl_birthdate.TabIndex = 8;
            this.lbl_birthdate.Text = "BirthDate";
            // 
            // lbl_nationality
            // 
            this.lbl_nationality.AutoSize = true;
            this.lbl_nationality.Location = new System.Drawing.Point(47, 235);
            this.lbl_nationality.Name = "lbl_nationality";
            this.lbl_nationality.Size = new System.Drawing.Size(74, 17);
            this.lbl_nationality.TabIndex = 9;
            this.lbl_nationality.Text = "Nationality";
            // 
            // lbl_team
            // 
            this.lbl_team.AutoSize = true;
            this.lbl_team.Location = new System.Drawing.Point(47, 281);
            this.lbl_team.Name = "lbl_team";
            this.lbl_team.Size = new System.Drawing.Size(44, 17);
            this.lbl_team.TabIndex = 10;
            this.lbl_team.Text = "Team";
            // 
            // lbl_teamNumber
            // 
            this.lbl_teamNumber.AutoSize = true;
            this.lbl_teamNumber.Location = new System.Drawing.Point(47, 332);
            this.lbl_teamNumber.Name = "lbl_teamNumber";
            this.lbl_teamNumber.Size = new System.Drawing.Size(98, 17);
            this.lbl_teamNumber.TabIndex = 11;
            this.lbl_teamNumber.Text = "Team Number";
            // 
            // tb_playerID
            // 
            this.tb_playerID.Location = new System.Drawing.Point(151, 105);
            this.tb_playerID.Name = "tb_playerID";
            this.tb_playerID.Size = new System.Drawing.Size(235, 22);
            this.tb_playerID.TabIndex = 12;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(151, 149);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(235, 22);
            this.tb_Name.TabIndex = 13;
            // 
            // dtp_birthdate
            // 
            this.dtp_birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_birthdate.Location = new System.Drawing.Point(152, 191);
            this.dtp_birthdate.Name = "dtp_birthdate";
            this.dtp_birthdate.Size = new System.Drawing.Size(379, 22);
            this.dtp_birthdate.TabIndex = 15;
            // 
            // cb_team
            // 
            this.cb_team.FormattingEnabled = true;
            this.cb_team.Location = new System.Drawing.Point(151, 278);
            this.cb_team.Name = "cb_team";
            this.cb_team.Size = new System.Drawing.Size(236, 24);
            this.cb_team.TabIndex = 16;
            // 
            // nud_TeamNumber
            // 
            this.nud_TeamNumber.Location = new System.Drawing.Point(151, 327);
            this.nud_TeamNumber.Name = "nud_TeamNumber";
            this.nud_TeamNumber.Size = new System.Drawing.Size(235, 22);
            this.nud_TeamNumber.TabIndex = 17;
            this.nud_TeamNumber.ValueChanged += new System.EventHandler(this.nud_TeamNumber_ValueChanged);
            // 
            // lbl_avail
            // 
            this.lbl_avail.AutoSize = true;
            this.lbl_avail.Location = new System.Drawing.Point(409, 330);
            this.lbl_avail.Name = "lbl_avail";
            this.lbl_avail.Size = new System.Drawing.Size(20, 17);
            this.lbl_avail.TabIndex = 18;
            this.lbl_avail.Text = "...";
            // 
            // cb_nation
            // 
            this.cb_nation.FormattingEnabled = true;
            this.cb_nation.Location = new System.Drawing.Point(153, 232);
            this.cb_nation.Name = "cb_nation";
            this.cb_nation.Size = new System.Drawing.Size(232, 24);
            this.cb_nation.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_nation);
            this.Controls.Add(this.lbl_avail);
            this.Controls.Add(this.nud_TeamNumber);
            this.Controls.Add(this.cb_team);
            this.Controls.Add(this.dtp_birthdate);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_playerID);
            this.Controls.Add(this.lbl_teamNumber);
            this.Controls.Add(this.lbl_team);
            this.Controls.Add(this.lbl_nationality);
            this.Controls.Add(this.lbl_birthdate);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_playerID);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_first);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_TeamNumber)).EndInit();
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
        private System.Windows.Forms.Label lbl_playerID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_birthdate;
        private System.Windows.Forms.Label lbl_nationality;
        private System.Windows.Forms.Label lbl_team;
        private System.Windows.Forms.Label lbl_teamNumber;
        private System.Windows.Forms.TextBox tb_playerID;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.DateTimePicker dtp_birthdate;
        private System.Windows.Forms.ComboBox cb_team;
        private System.Windows.Forms.NumericUpDown nud_TeamNumber;
        private System.Windows.Forms.Label lbl_avail;
        private System.Windows.Forms.ComboBox cb_nation;
    }
}

