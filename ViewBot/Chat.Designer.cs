namespace ViewBot
{
    partial class Chat
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
            this.GrpUser = new System.Windows.Forms.GroupBox();
            this.TxtExitTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnExitRoom = new System.Windows.Forms.Button();
            this.TxtEnterTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUserStart = new System.Windows.Forms.TextBox();
            this.LabelUserStart = new System.Windows.Forms.Label();
            this.BtnEnterRoom = new System.Windows.Forms.Button();
            this.GridUser = new System.Windows.Forms.DataGridView();
            this.userNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sesskey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrpLog = new System.Windows.Forms.GroupBox();
            this.BtnSendMessage = new System.Windows.Forms.Button();
            this.TxtMessage = new System.Windows.Forms.TextBox();
            this.TxtSendUserNum = new System.Windows.Forms.TextBox();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnKeyAdd = new System.Windows.Forms.Button();
            this.TxtKeyEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtKeyStart = new System.Windows.Forms.TextBox();
            this.GridKeyword = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.response = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtKeyResponse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtKeyword = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.GrpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).BeginInit();
            this.GrpLog.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridKeyword)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpUser
            // 
            this.GrpUser.Controls.Add(this.TxtExitTime);
            this.GrpUser.Controls.Add(this.label2);
            this.GrpUser.Controls.Add(this.BtnExitRoom);
            this.GrpUser.Controls.Add(this.TxtEnterTime);
            this.GrpUser.Controls.Add(this.label1);
            this.GrpUser.Controls.Add(this.TxtUserStart);
            this.GrpUser.Controls.Add(this.LabelUserStart);
            this.GrpUser.Controls.Add(this.BtnEnterRoom);
            this.GrpUser.Controls.Add(this.GridUser);
            this.GrpUser.Font = new System.Drawing.Font("BatangChe", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpUser.Location = new System.Drawing.Point(12, 12);
            this.GrpUser.Name = "GrpUser";
            this.GrpUser.Size = new System.Drawing.Size(745, 180);
            this.GrpUser.TabIndex = 6;
            this.GrpUser.TabStop = false;
            this.GrpUser.Text = "방입장";
            // 
            // TxtExitTime
            // 
            this.TxtExitTime.Location = new System.Drawing.Point(607, 113);
            this.TxtExitTime.Name = "TxtExitTime";
            this.TxtExitTime.Size = new System.Drawing.Size(100, 22);
            this.TxtExitTime.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "방나가는 간격:";
            // 
            // BtnExitRoom
            // 
            this.BtnExitRoom.Location = new System.Drawing.Point(607, 147);
            this.BtnExitRoom.Name = "BtnExitRoom";
            this.BtnExitRoom.Size = new System.Drawing.Size(100, 22);
            this.BtnExitRoom.TabIndex = 18;
            this.BtnExitRoom.Text = "방나가기";
            this.BtnExitRoom.UseVisualStyleBackColor = true;
            this.BtnExitRoom.Click += new System.EventHandler(this.BtnExitRoom_Click);
            // 
            // TxtEnterTime
            // 
            this.TxtEnterTime.Location = new System.Drawing.Point(607, 80);
            this.TxtEnterTime.Name = "TxtEnterTime";
            this.TxtEnterTime.Size = new System.Drawing.Size(100, 22);
            this.TxtEnterTime.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "방입장 간격:";
            // 
            // TxtUserStart
            // 
            this.TxtUserStart.Location = new System.Drawing.Point(607, 46);
            this.TxtUserStart.Name = "TxtUserStart";
            this.TxtUserStart.Size = new System.Drawing.Size(100, 22);
            this.TxtUserStart.TabIndex = 14;
            // 
            // LabelUserStart
            // 
            this.LabelUserStart.AutoSize = true;
            this.LabelUserStart.Location = new System.Drawing.Point(448, 49);
            this.LabelUserStart.Name = "LabelUserStart";
            this.LabelUserStart.Size = new System.Drawing.Size(63, 13);
            this.LabelUserStart.TabIndex = 13;
            this.LabelUserStart.Text = "방 번호:";
            // 
            // BtnEnterRoom
            // 
            this.BtnEnterRoom.Location = new System.Drawing.Point(451, 147);
            this.BtnEnterRoom.Name = "BtnEnterRoom";
            this.BtnEnterRoom.Size = new System.Drawing.Size(100, 22);
            this.BtnEnterRoom.TabIndex = 15;
            this.BtnEnterRoom.Text = "방입장";
            this.BtnEnterRoom.UseVisualStyleBackColor = true;
            this.BtnEnterRoom.Click += new System.EventHandler(this.BtnEnterRoom_Click);
            // 
            // GridUser
            // 
            this.GridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNum,
            this.userId,
            this.sesskey});
            this.GridUser.Location = new System.Drawing.Point(21, 30);
            this.GridUser.Name = "GridUser";
            this.GridUser.Size = new System.Drawing.Size(381, 139);
            this.GridUser.TabIndex = 0;
            // 
            // userNum
            // 
            this.userNum.HeaderText = "번호";
            this.userNum.Name = "userNum";
            this.userNum.ReadOnly = true;
            this.userNum.Width = 70;
            // 
            // userId
            // 
            this.userId.HeaderText = "유저아이디";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            this.userId.Width = 130;
            // 
            // sesskey
            // 
            this.sesskey.HeaderText = "SessKey";
            this.sesskey.Name = "sesskey";
            this.sesskey.ReadOnly = true;
            this.sesskey.Width = 130;
            // 
            // GrpLog
            // 
            this.GrpLog.Controls.Add(this.BtnSendMessage);
            this.GrpLog.Controls.Add(this.TxtMessage);
            this.GrpLog.Controls.Add(this.TxtSendUserNum);
            this.GrpLog.Controls.Add(this.TxtLog);
            this.GrpLog.Controls.Add(this.label7);
            this.GrpLog.Font = new System.Drawing.Font("BatangChe", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpLog.Location = new System.Drawing.Point(12, 198);
            this.GrpLog.Name = "GrpLog";
            this.GrpLog.Size = new System.Drawing.Size(745, 221);
            this.GrpLog.TabIndex = 7;
            this.GrpLog.TabStop = false;
            this.GrpLog.Text = "채팅상세";
            // 
            // BtnSendMessage
            // 
            this.BtnSendMessage.Location = new System.Drawing.Point(607, 185);
            this.BtnSendMessage.Name = "BtnSendMessage";
            this.BtnSendMessage.Size = new System.Drawing.Size(100, 22);
            this.BtnSendMessage.TabIndex = 29;
            this.BtnSendMessage.Text = "보내기";
            this.BtnSendMessage.UseVisualStyleBackColor = true;
            this.BtnSendMessage.Click += new System.EventHandler(this.BtnSendMessage_Click);
            // 
            // TxtMessage
            // 
            this.TxtMessage.Location = new System.Drawing.Point(456, 81);
            this.TxtMessage.Multiline = true;
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtMessage.Size = new System.Drawing.Size(251, 93);
            this.TxtMessage.TabIndex = 29;
            this.TxtMessage.UseSystemPasswordChar = true;
            // 
            // TxtSendUserNum
            // 
            this.TxtSendUserNum.Location = new System.Drawing.Point(607, 45);
            this.TxtSendUserNum.Name = "TxtSendUserNum";
            this.TxtSendUserNum.Size = new System.Drawing.Size(100, 22);
            this.TxtSendUserNum.TabIndex = 21;
            // 
            // TxtLog
            // 
            this.TxtLog.Location = new System.Drawing.Point(30, 33);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.ReadOnly = true;
            this.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtLog.Size = new System.Drawing.Size(372, 174);
            this.TxtLog.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "유저 번호:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnKeyAdd);
            this.groupBox1.Controls.Add(this.TxtKeyEnd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtKeyStart);
            this.groupBox1.Controls.Add(this.GridKeyword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtKeyResponse);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtKeyword);
            this.groupBox1.Font = new System.Drawing.Font("BatangChe", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 241);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "키워드 응답";
            // 
            // BtnKeyAdd
            // 
            this.BtnKeyAdd.Location = new System.Drawing.Point(607, 19);
            this.BtnKeyAdd.Name = "BtnKeyAdd";
            this.BtnKeyAdd.Size = new System.Drawing.Size(100, 75);
            this.BtnKeyAdd.TabIndex = 21;
            this.BtnKeyAdd.Text = "추가";
            this.BtnKeyAdd.UseVisualStyleBackColor = true;
            this.BtnKeyAdd.Click += new System.EventHandler(this.BtnKeyAdd_Click);
            // 
            // TxtKeyEnd
            // 
            this.TxtKeyEnd.Location = new System.Drawing.Point(397, 22);
            this.TxtKeyEnd.Name = "TxtKeyEnd";
            this.TxtKeyEnd.Size = new System.Drawing.Size(186, 22);
            this.TxtKeyEnd.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "유저마감:";
            // 
            // TxtKeyStart
            // 
            this.TxtKeyStart.Location = new System.Drawing.Point(125, 22);
            this.TxtKeyStart.Name = "TxtKeyStart";
            this.TxtKeyStart.Size = new System.Drawing.Size(180, 22);
            this.TxtKeyStart.TabIndex = 26;
            // 
            // GridKeyword
            // 
            this.GridKeyword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridKeyword.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.keyword,
            this.response,
            this.startUser,
            this.endUser});
            this.GridKeyword.Location = new System.Drawing.Point(30, 100);
            this.GridKeyword.Name = "GridKeyword";
            this.GridKeyword.Size = new System.Drawing.Size(677, 127);
            this.GridKeyword.TabIndex = 21;
            // 
            // no
            // 
            this.no.HeaderText = "번호";
            this.no.Name = "no";
            this.no.Width = 70;
            // 
            // keyword
            // 
            this.keyword.HeaderText = "키워드";
            this.keyword.Name = "keyword";
            this.keyword.Width = 190;
            // 
            // response
            // 
            this.response.HeaderText = "응답";
            this.response.Name = "response";
            this.response.Width = 190;
            // 
            // startUser
            // 
            this.startUser.HeaderText = "유저시작";
            this.startUser.Name = "startUser";
            this.startUser.Width = 90;
            // 
            // endUser
            // 
            this.endUser.HeaderText = "유저마감";
            this.endUser.Name = "endUser";
            this.endUser.Width = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "유저시작:";
            // 
            // TxtKeyResponse
            // 
            this.TxtKeyResponse.Location = new System.Drawing.Point(397, 50);
            this.TxtKeyResponse.Multiline = true;
            this.TxtKeyResponse.Name = "TxtKeyResponse";
            this.TxtKeyResponse.Size = new System.Drawing.Size(186, 44);
            this.TxtKeyResponse.TabIndex = 24;
            this.TxtKeyResponse.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "키워드:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "응답:";
            // 
            // TxtKeyword
            // 
            this.TxtKeyword.Location = new System.Drawing.Point(125, 50);
            this.TxtKeyword.Multiline = true;
            this.TxtKeyword.Name = "TxtKeyword";
            this.TxtKeyword.Size = new System.Drawing.Size(180, 44);
            this.TxtKeyword.TabIndex = 22;
            this.TxtKeyword.UseSystemPasswordChar = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Font = new System.Drawing.Font("BatangChe", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 672);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(745, 75);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "로그";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(30, 21);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox9.Size = new System.Drawing.Size(677, 40);
            this.textBox9.TabIndex = 0;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(775, 758);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrpLog);
            this.Controls.Add(this.GrpUser);
            this.Name = "Chat";
            this.Text = "채팅상세";
            this.GrpUser.ResumeLayout(false);
            this.GrpUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).EndInit();
            this.GrpLog.ResumeLayout(false);
            this.GrpLog.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridKeyword)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpUser;
        private System.Windows.Forms.DataGridView GridUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn sesskey;
        private System.Windows.Forms.TextBox TxtEnterTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUserStart;
        private System.Windows.Forms.Label LabelUserStart;
        private System.Windows.Forms.Button BtnEnterRoom;
        private System.Windows.Forms.TextBox TxtExitTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnExitRoom;
        private System.Windows.Forms.GroupBox GrpLog;
        private System.Windows.Forms.TextBox TxtLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridKeyword;
        private System.Windows.Forms.TextBox TxtKeyStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtKeyResponse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtKeyword;
        private System.Windows.Forms.TextBox TxtKeyEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnKeyAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtMessage;
        private System.Windows.Forms.TextBox TxtSendUserNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn response;
        private System.Windows.Forms.DataGridViewTextBoxColumn startUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn endUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button BtnSendMessage;
    }
}