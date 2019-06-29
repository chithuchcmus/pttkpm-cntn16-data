namespace HandleData
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
            this.cb_loaidulieu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.bt_findUrl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_url = new System.Windows.Forms.ComboBox();
            this.bt_sendData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_loaidulieu
            // 
            this.cb_loaidulieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_loaidulieu.FormattingEnabled = true;
            this.cb_loaidulieu.Location = new System.Drawing.Point(290, 18);
            this.cb_loaidulieu.Margin = new System.Windows.Forms.Padding(4);
            this.cb_loaidulieu.Name = "cb_loaidulieu";
            this.cb_loaidulieu.Size = new System.Drawing.Size(196, 28);
            this.cb_loaidulieu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn loại dữ liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đường dẫn đến File Source";
            // 
            // tb_url
            // 
            this.tb_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_url.Location = new System.Drawing.Point(290, 71);
            this.tb_url.Multiline = true;
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(383, 43);
            this.tb_url.TabIndex = 3;
            // 
            // bt_findUrl
            // 
            this.bt_findUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_findUrl.Location = new System.Drawing.Point(710, 71);
            this.bt_findUrl.Name = "bt_findUrl";
            this.bt_findUrl.Size = new System.Drawing.Size(109, 43);
            this.bt_findUrl.TabIndex = 4;
            this.bt_findUrl.Text = "Tìm kiếm";
            this.bt_findUrl.UseVisualStyleBackColor = true;
            this.bt_findUrl.Click += new System.EventHandler(this.Bt_findUrl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đường dẫn Server";
            // 
            // cb_url
            // 
            this.cb_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_url.FormattingEnabled = true;
            this.cb_url.Location = new System.Drawing.Point(290, 139);
            this.cb_url.Margin = new System.Windows.Forms.Padding(4);
            this.cb_url.Name = "cb_url";
            this.cb_url.Size = new System.Drawing.Size(383, 28);
            this.cb_url.TabIndex = 7;
            // 
            // bt_sendData
            // 
            this.bt_sendData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sendData.Location = new System.Drawing.Point(559, 189);
            this.bt_sendData.Name = "bt_sendData";
            this.bt_sendData.Size = new System.Drawing.Size(114, 45);
            this.bt_sendData.TabIndex = 8;
            this.bt_sendData.Text = "Gửi";
            this.bt_sendData.UseVisualStyleBackColor = true;
            this.bt_sendData.Click += new System.EventHandler(this.Bt_sendData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 264);
            this.Controls.Add(this.bt_sendData);
            this.Controls.Add(this.cb_url);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_findUrl);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_loaidulieu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ToolSendDataToServer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_loaidulieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Button bt_findUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_url;
        private System.Windows.Forms.Button bt_sendData;
    }
}

