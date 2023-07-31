namespace ViewBot
{
    partial class Viewbot
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
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.GridUser = new System.Windows.Forms.DataGridView();
            this.userNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrpProxy = new System.Windows.Forms.GroupBox();
            this.BtnAddProxy = new System.Windows.Forms.Button();
            this.GridProxy = new System.Windows.Forms.DataGridView();
            this.proxyNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxyIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxyPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrpLog = new System.Windows.Forms.GroupBox();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.GrpEnterRoom = new System.Windows.Forms.GroupBox();
            this.BtnEnterRoom = new System.Windows.Forms.Button();
            this.TxtRoomId = new System.Windows.Forms.TextBox();
            this.TxtUserRoomEnd = new System.Windows.Forms.TextBox();
            this.LabelRoomId = new System.Windows.Forms.Label();
            this.LabelUserRoomStart = new System.Windows.Forms.Label();
            this.TxtUserRoomStart = new System.Windows.Forms.TextBox();
            this.LabelUserRoomEnd = new System.Windows.Forms.Label();
            this.LabelUserStart = new System.Windows.Forms.Label();
            this.LabelUserEnd = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtEndUser = new System.Windows.Forms.TextBox();
            this.GrpLogin = new System.Windows.Forms.GroupBox();
            this.GridLoginUser = new System.Windows.Forms.DataGridView();
            this.luserNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sesskey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtUserStart = new System.Windows.Forms.TextBox();
            this.GrpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).BeginInit();
            this.GrpProxy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProxy)).BeginInit();
            this.GrpLog.SuspendLayout();
            this.GrpEnterRoom.SuspendLayout();
            this.GrpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLoginUser)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpUser
            // 
            this.GrpUser.Controls.Add(this.BtnAddUser);
            this.GrpUser.Controls.Add(this.GridUser);
            this.GrpUser.Font = new System.Drawing.Font("BatangChe", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpUser.Location = new System.Drawing.Point(23, 28);
            this.GrpUser.Name = "GrpUser";
            this.GrpUser.Size = new System.Drawing.Size(423, 236);
            this.GrpUser.TabIndex = 5;
            this.GrpUser.TabStop = false;
            this.GrpUser.Text = "유저리스트";
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Location = new System.Drawing.Point(302, 202);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(100, 22);
            this.BtnAddUser.TabIndex = 7;
            this.BtnAddUser.Text = "추가";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // GridUser
            // 
            this.GridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNum,
            this.userId,
            this.userPass});
            this.GridUser.Location = new System.Drawing.Point(21, 30);
            this.GridUser.Name = "GridUser";
            this.GridUser.Size = new System.Drawing.Size(381, 164);
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
            // userPass
            // 
            this.userPass.HeaderText = "유저비번";
            this.userPass.Name = "userPass";
            this.userPass.ReadOnly = true;
            this.userPass.Width = 130;
            // 
            // GrpProxy
            // 
            this.GrpProxy.Controls.Add(this.BtnAddProxy);
            this.GrpProxy.Controls.Add(this.GridProxy);
            this.GrpProxy.Font = new System.Drawing.Font("BatangChe", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpProxy.Location = new System.Drawing.Point(467, 28);
            this.GrpProxy.Name = "GrpProxy";
            this.GrpProxy.Size = new System.Drawing.Size(423, 236);
            this.GrpProxy.TabIndex = 6;
            this.GrpProxy.TabStop = false;
            this.GrpProxy.Text = "프록시리스트";
            // 
            // BtnAddProxy
            // 
            this.BtnAddProxy.Location = new System.Drawing.Point(303, 202);
            this.BtnAddProxy.Name = "BtnAddProxy";
            this.BtnAddProxy.Size = new System.Drawing.Size(100, 22);
            this.BtnAddProxy.TabIndex = 9;
            this.BtnAddProxy.Text = "추가";
            this.BtnAddProxy.UseVisualStyleBackColor = true;
            this.BtnAddProxy.Click += new System.EventHandler(this.BtnAddProxy_Click);
            // 
            // GridProxy
            // 
            this.GridProxy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProxy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proxyNum,
            this.proxyIp,
            this.proxyPort});
            this.GridProxy.Location = new System.Drawing.Point(22, 30);
            this.GridProxy.Name = "GridProxy";
            this.GridProxy.Size = new System.Drawing.Size(381, 164);
            this.GridProxy.TabIndex = 8;
            // 
            // proxyNum
            // 
            this.proxyNum.HeaderText = "번호";
            this.proxyNum.Name = "proxyNum";
            this.proxyNum.ReadOnly = true;
            this.proxyNum.Width = 70;
            // 
            // proxyIp
            // 
            this.proxyIp.HeaderText = "프록시아이피";
            this.proxyIp.Name = "proxyIp";
            this.proxyIp.ReadOnly = true;
            this.proxyIp.Width = 130;
            // 
            // proxyPort
            // 
            this.proxyPort.HeaderText = "프록시포트";
            this.proxyPort.Name = "proxyPort";
            this.proxyPort.ReadOnly = true;
            this.proxyPort.Width = 130;
            // 
            // GrpLog
            // 
            this.GrpLog.Controls.Add(this.TxtLog);
            this.GrpLog.Font = new System.Drawing.Font("BatangChe", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpLog.Location = new System.Drawing.Point(467, 270);
            this.GrpLog.Name = "GrpLog";
            this.GrpLog.Size = new System.Drawing.Size(423, 236);
            this.GrpLog.TabIndex = 6;
            this.GrpLog.TabStop = false;
            this.GrpLog.Text = "로그";
            // 
            // TxtLog
            // 
            this.TxtLog.Location = new System.Drawing.Point(21, 24);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.ReadOnly = true;
            this.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtLog.Size = new System.Drawing.Size(381, 193);
            this.TxtLog.TabIndex = 0;
            // 
            // GrpEnterRoom
            // 
            this.GrpEnterRoom.Controls.Add(this.BtnEnterRoom);
            this.GrpEnterRoom.Controls.Add(this.TxtRoomId);
            this.GrpEnterRoom.Controls.Add(this.TxtUserRoomEnd);
            this.GrpEnterRoom.Controls.Add(this.LabelRoomId);
            this.GrpEnterRoom.Controls.Add(this.LabelUserRoomStart);
            this.GrpEnterRoom.Controls.Add(this.TxtUserRoomStart);
            this.GrpEnterRoom.Controls.Add(this.LabelUserRoomEnd);
            this.GrpEnterRoom.Font = new System.Drawing.Font("BatangChe", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpEnterRoom.Location = new System.Drawing.Point(23, 512);
            this.GrpEnterRoom.Name = "GrpEnterRoom";
            this.GrpEnterRoom.Size = new System.Drawing.Size(867, 73);
            this.GrpEnterRoom.TabIndex = 6;
            this.GrpEnterRoom.TabStop = false;
            this.GrpEnterRoom.Text = "방입장";
            // 
            // BtnEnterRoom
            // 
            this.BtnEnterRoom.Location = new System.Drawing.Point(747, 33);
            this.BtnEnterRoom.Name = "BtnEnterRoom";
            this.BtnEnterRoom.Size = new System.Drawing.Size(100, 22);
            this.BtnEnterRoom.TabIndex = 12;
            this.BtnEnterRoom.Text = "방입장";
            this.BtnEnterRoom.UseVisualStyleBackColor = true;
            this.BtnEnterRoom.Click += new System.EventHandler(this.BtnEnterRoom_Click);
            // 
            // TxtRoomId
            // 
            this.TxtRoomId.Location = new System.Drawing.Point(615, 33);
            this.TxtRoomId.Name = "TxtRoomId";
            this.TxtRoomId.Size = new System.Drawing.Size(104, 22);
            this.TxtRoomId.TabIndex = 17;
            // 
            // TxtUserRoomEnd
            // 
            this.TxtUserRoomEnd.Location = new System.Drawing.Point(389, 33);
            this.TxtUserRoomEnd.Name = "TxtUserRoomEnd";
            this.TxtUserRoomEnd.Size = new System.Drawing.Size(104, 22);
            this.TxtUserRoomEnd.TabIndex = 15;
            // 
            // LabelRoomId
            // 
            this.LabelRoomId.AutoSize = true;
            this.LabelRoomId.Location = new System.Drawing.Point(522, 38);
            this.LabelRoomId.Name = "LabelRoomId";
            this.LabelRoomId.Size = new System.Drawing.Size(70, 13);
            this.LabelRoomId.TabIndex = 16;
            this.LabelRoomId.Text = "룸아이디:";
            // 
            // LabelUserRoomStart
            // 
            this.LabelUserRoomStart.AutoSize = true;
            this.LabelUserRoomStart.Location = new System.Drawing.Point(18, 38);
            this.LabelUserRoomStart.Name = "LabelUserRoomStart";
            this.LabelUserRoomStart.Size = new System.Drawing.Size(98, 13);
            this.LabelUserRoomStart.TabIndex = 12;
            this.LabelUserRoomStart.Text = "유저시작번호:";
            // 
            // TxtUserRoomStart
            // 
            this.TxtUserRoomStart.Location = new System.Drawing.Point(132, 33);
            this.TxtUserRoomStart.Name = "TxtUserRoomStart";
            this.TxtUserRoomStart.Size = new System.Drawing.Size(104, 22);
            this.TxtUserRoomStart.TabIndex = 14;
            // 
            // LabelUserRoomEnd
            // 
            this.LabelUserRoomEnd.AutoSize = true;
            this.LabelUserRoomEnd.Location = new System.Drawing.Point(266, 38);
            this.LabelUserRoomEnd.Name = "LabelUserRoomEnd";
            this.LabelUserRoomEnd.Size = new System.Drawing.Size(98, 13);
            this.LabelUserRoomEnd.TabIndex = 13;
            this.LabelUserRoomEnd.Text = "유저마감번호:";
            // 
            // LabelUserStart
            // 
            this.LabelUserStart.AutoSize = true;
            this.LabelUserStart.Location = new System.Drawing.Point(17, 28);
            this.LabelUserStart.Name = "LabelUserStart";
            this.LabelUserStart.Size = new System.Drawing.Size(98, 13);
            this.LabelUserStart.TabIndex = 1;
            this.LabelUserStart.Text = "유저시작번호:";
            // 
            // LabelUserEnd
            // 
            this.LabelUserEnd.AutoSize = true;
            this.LabelUserEnd.Location = new System.Drawing.Point(206, 29);
            this.LabelUserEnd.Name = "LabelUserEnd";
            this.LabelUserEnd.Size = new System.Drawing.Size(98, 13);
            this.LabelUserEnd.TabIndex = 2;
            this.LabelUserEnd.Text = "유저마감번호:";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(302, 56);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(100, 22);
            this.BtnLogin.TabIndex = 8;
            this.BtnLogin.Text = "로그인";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtEndUser
            // 
            this.TxtEndUser.Location = new System.Drawing.Point(302, 24);
            this.TxtEndUser.Name = "TxtEndUser";
            this.TxtEndUser.Size = new System.Drawing.Size(100, 22);
            this.TxtEndUser.TabIndex = 9;
            // 
            // GrpLogin
            // 
            this.GrpLogin.Controls.Add(this.GridLoginUser);
            this.GrpLogin.Controls.Add(this.TxtEndUser);
            this.GrpLogin.Controls.Add(this.BtnLogin);
            this.GrpLogin.Controls.Add(this.TxtUserStart);
            this.GrpLogin.Controls.Add(this.LabelUserStart);
            this.GrpLogin.Controls.Add(this.LabelUserEnd);
            this.GrpLogin.Font = new System.Drawing.Font("BatangChe", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpLogin.Location = new System.Drawing.Point(23, 270);
            this.GrpLogin.Name = "GrpLogin";
            this.GrpLogin.Size = new System.Drawing.Size(423, 236);
            this.GrpLogin.TabIndex = 8;
            this.GrpLogin.TabStop = false;
            this.GrpLogin.Text = "로그인";
            // 
            // GridLoginUser
            // 
            this.GridLoginUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLoginUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.luserNum,
            this.luserId,
            this.sesskey});
            this.GridLoginUser.Location = new System.Drawing.Point(21, 85);
            this.GridLoginUser.Name = "GridLoginUser";
            this.GridLoginUser.Size = new System.Drawing.Size(381, 132);
            this.GridLoginUser.TabIndex = 0;
            // 
            // luserNum
            // 
            this.luserNum.HeaderText = "번호";
            this.luserNum.Name = "luserNum";
            this.luserNum.ReadOnly = true;
            this.luserNum.Width = 70;
            // 
            // luserId
            // 
            this.luserId.HeaderText = "유저아이디";
            this.luserId.Name = "luserId";
            this.luserId.ReadOnly = true;
            this.luserId.Width = 130;
            // 
            // sesskey
            // 
            this.sesskey.HeaderText = "Sesskey";
            this.sesskey.Name = "sesskey";
            this.sesskey.ReadOnly = true;
            this.sesskey.Width = 130;
            // 
            // TxtUserStart
            // 
            this.TxtUserStart.Location = new System.Drawing.Point(112, 24);
            this.TxtUserStart.Name = "TxtUserStart";
            this.TxtUserStart.Size = new System.Drawing.Size(91, 22);
            this.TxtUserStart.TabIndex = 7;
            // 
            // Viewbot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(912, 603);
            this.Controls.Add(this.GrpLogin);
            this.Controls.Add(this.GrpEnterRoom);
            this.Controls.Add(this.GrpLog);
            this.Controls.Add(this.GrpProxy);
            this.Controls.Add(this.GrpUser);
            this.Name = "Viewbot";
            this.Text = "팬더 TV 뷰봇";
            this.GrpUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).EndInit();
            this.GrpProxy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridProxy)).EndInit();
            this.GrpLog.ResumeLayout(false);
            this.GrpLog.PerformLayout();
            this.GrpEnterRoom.ResumeLayout(false);
            this.GrpEnterRoom.PerformLayout();
            this.GrpLogin.ResumeLayout(false);
            this.GrpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLoginUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GrpUser;
        private System.Windows.Forms.GroupBox GrpProxy;
        private System.Windows.Forms.GroupBox GrpLog;
        private System.Windows.Forms.GroupBox GrpEnterRoom;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.DataGridView GridUser;
        private System.Windows.Forms.Button BtnAddProxy;
        private System.Windows.Forms.DataGridView GridProxy;
        private System.Windows.Forms.Label LabelUserEnd;
        private System.Windows.Forms.Label LabelUserStart;
        private System.Windows.Forms.TextBox TxtLog;
        private System.Windows.Forms.TextBox TxtEndUser;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnEnterRoom;
        private System.Windows.Forms.TextBox TxtRoomId;
        private System.Windows.Forms.TextBox TxtUserRoomEnd;
        private System.Windows.Forms.Label LabelRoomId;
        private System.Windows.Forms.Label LabelUserRoomStart;
        private System.Windows.Forms.TextBox TxtUserRoomStart;
        private System.Windows.Forms.Label LabelUserRoomEnd;
        private System.Windows.Forms.GroupBox GrpLogin;
        private System.Windows.Forms.DataGridView GridLoginUser;
        private System.Windows.Forms.TextBox TxtUserStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxyNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxyIp;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxyPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn luserNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn luserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn sesskey;
    }
}

