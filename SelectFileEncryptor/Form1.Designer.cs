namespace SelectFileEncryptor
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.DirectInputButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.EncryptFileListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // DirectInputButton
            // 
            this.DirectInputButton.Location = new System.Drawing.Point(248, 316);
            this.DirectInputButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DirectInputButton.Name = "DirectInputButton";
            this.DirectInputButton.Size = new System.Drawing.Size(121, 51);
            this.DirectInputButton.TabIndex = 1;
            this.DirectInputButton.Text = "직접찾기";
            this.DirectInputButton.UseVisualStyleBackColor = true;
            this.DirectInputButton.Click += new System.EventHandler(this.DirectInputButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(376, 316);
            this.EncryptButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(121, 51);
            this.EncryptButton.TabIndex = 2;
            this.EncryptButton.Text = "암호화하기";
            this.EncryptButton.UseVisualStyleBackColor = true;
            // 
            // EncryptFileListView
            // 
            this.EncryptFileListView.AllowDrop = true;
            this.EncryptFileListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.EncryptFileListView.Location = new System.Drawing.Point(15, 16);
            this.EncryptFileListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EncryptFileListView.Name = "EncryptFileListView";
            this.EncryptFileListView.Size = new System.Drawing.Size(482, 292);
            this.EncryptFileListView.TabIndex = 3;
            this.EncryptFileListView.UseCompatibleStateImageBehavior = false;
            this.EncryptFileListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.EncryptFileListView_DragDrop);
            this.EncryptFileListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.EncryptFileListView_DragEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 380);
            this.Controls.Add(this.EncryptFileListView);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.DirectInputButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "SelectFileEncryptor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DirectInputButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.ListView EncryptFileListView;
    }
}

