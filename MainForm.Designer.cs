namespace DB_CoffeeShop
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogincheck = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DTPcasher = new System.Windows.Forms.DateTimePicker();
            this.buttoncoffee_cafemocha = new System.Windows.Forms.Button();
            this.buttoncoffee_cafelatte = new System.Windows.Forms.Button();
            this.buttoncoffee_americano = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGVadmin = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVadmin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(55, 9);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 21);
            this.textBoxID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "비밀번호";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(220, 9);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 21);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelLogincheck
            // 
            this.labelLogincheck.AutoSize = true;
            this.labelLogincheck.Location = new System.Drawing.Point(497, 12);
            this.labelLogincheck.Name = "labelLogincheck";
            this.labelLogincheck.Size = new System.Drawing.Size(105, 12);
            this.labelLogincheck.TabIndex = 4;
            this.labelLogincheck.Text = "로그인을 해주세요";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(335, 8);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "로그인";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(695, 8);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "로그아웃";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DTPcasher);
            this.groupBox1.Controls.Add(this.buttoncoffee_cafemocha);
            this.groupBox1.Controls.Add(this.buttoncoffee_cafelatte);
            this.groupBox1.Controls.Add(this.buttoncoffee_americano);
            this.groupBox1.Location = new System.Drawing.Point(15, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 157);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "캐셔용 화면";
            // 
            // DTPcasher
            // 
            this.DTPcasher.CustomFormat = "yyyy-MM-dd";
            this.DTPcasher.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPcasher.Location = new System.Drawing.Point(7, 21);
            this.DTPcasher.Name = "DTPcasher";
            this.DTPcasher.Size = new System.Drawing.Size(200, 21);
            this.DTPcasher.TabIndex = 11;
            this.DTPcasher.ValueChanged += new System.EventHandler(this.DTPcasher_ValueChanged_1);
            // 
            // buttoncoffee_cafemocha
            // 
            this.buttoncoffee_cafemocha.Location = new System.Drawing.Point(524, 47);
            this.buttoncoffee_cafemocha.Name = "buttoncoffee_cafemocha";
            this.buttoncoffee_cafemocha.Size = new System.Drawing.Size(225, 95);
            this.buttoncoffee_cafemocha.TabIndex = 10;
            this.buttoncoffee_cafemocha.Text = "카페모카";
            this.buttoncoffee_cafemocha.UseVisualStyleBackColor = true;
            this.buttoncoffee_cafemocha.Click += new System.EventHandler(this.buttoncoffee_cafemocha_Click);
            // 
            // buttoncoffee_cafelatte
            // 
            this.buttoncoffee_cafelatte.Location = new System.Drawing.Point(265, 47);
            this.buttoncoffee_cafelatte.Name = "buttoncoffee_cafelatte";
            this.buttoncoffee_cafelatte.Size = new System.Drawing.Size(225, 95);
            this.buttoncoffee_cafelatte.TabIndex = 9;
            this.buttoncoffee_cafelatte.Text = "카페라떼";
            this.buttoncoffee_cafelatte.UseVisualStyleBackColor = true;
            this.buttoncoffee_cafelatte.Click += new System.EventHandler(this.buttoncoffee_cafelatte_Click);
            // 
            // buttoncoffee_americano
            // 
            this.buttoncoffee_americano.Location = new System.Drawing.Point(6, 47);
            this.buttoncoffee_americano.Name = "buttoncoffee_americano";
            this.buttoncoffee_americano.Size = new System.Drawing.Size(225, 95);
            this.buttoncoffee_americano.TabIndex = 8;
            this.buttoncoffee_americano.Text = "아메리카노";
            this.buttoncoffee_americano.UseVisualStyleBackColor = true;
            this.buttoncoffee_americano.Click += new System.EventHandler(this.buttoncoffee_americano_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGVadmin);
            this.groupBox2.Location = new System.Drawing.Point(15, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 177);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "관리자용 화면";
            // 
            // DGVadmin
            // 
            this.DGVadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVadmin.Location = new System.Drawing.Point(7, 21);
            this.DGVadmin.Name = "DGVadmin";
            this.DGVadmin.RowTemplate.Height = 23;
            this.DGVadmin.Size = new System.Drawing.Size(742, 150);
            this.DGVadmin.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelLogincheck);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "길동 커피";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVadmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttoncoffee_cafemocha;
        private System.Windows.Forms.Button buttoncoffee_cafelatte;
        private System.Windows.Forms.Button buttoncoffee_americano;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label labelLogincheck;
        public System.Windows.Forms.Button buttonLogin;
        public System.Windows.Forms.TextBox textBoxID;
        public System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.DateTimePicker DTPcasher;
        public System.Windows.Forms.DataGridView DGVadmin;
    }
}

