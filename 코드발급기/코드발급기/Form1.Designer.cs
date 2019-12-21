namespace 코드발급기
{
    partial class Form1
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
            this.Code = new System.Windows.Forms.TextBox();
            this.코드발급 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Code
            // 
            this.Code.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.Code.Location = new System.Drawing.Point(11, 33);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(280, 25);
            this.Code.TabIndex = 0;
            // 
            // 코드발급
            // 
            this.코드발급.Location = new System.Drawing.Point(11, 99);
            this.코드발급.Name = "코드발급";
            this.코드발급.Size = new System.Drawing.Size(280, 29);
            this.코드발급.TabIndex = 1;
            this.코드발급.Text = "코드 발급";
            this.코드발급.UseVisualStyleBackColor = true;
            this.코드발급.Click += new System.EventHandler(this.코드발급_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "코드 문자열 생성";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(145, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "15day";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 11);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(51, 16);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "1day";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(222, 11);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(57, 16);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "30day";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(74, 11);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(51, 16);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "7day";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 136);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.코드발급);
            this.Controls.Add(this.Code);
            this.Name = "Form1";
            this.Text = "코드발급기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Button 코드발급;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}

