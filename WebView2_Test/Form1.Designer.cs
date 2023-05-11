namespace WebView2_Test
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.textBox_UrlBar = new System.Windows.Forms.TextBox();
            this.label_CsToJs = new System.Windows.Forms.Label();
            this.label_JsToCs = new System.Windows.Forms.Label();
            this.richTextBox_JsToCs = new System.Windows.Forms.RichTextBox();
            this.button_CsToJs = new System.Windows.Forms.Button();
            this.label_UrlBar = new System.Windows.Forms.Label();
            this.textBox_CsToJs = new System.Windows.Forms.TextBox();
            this.label_CsToJsReturn = new System.Windows.Forms.Label();
            this.richTextBox_CsToJsReturn = new System.Windows.Forms.RichTextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(12, 37);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(643, 401);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // textBox_UrlBar
            // 
            this.textBox_UrlBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_UrlBar.Location = new System.Drawing.Point(46, 12);
            this.textBox_UrlBar.Name = "textBox_UrlBar";
            this.textBox_UrlBar.Size = new System.Drawing.Size(609, 19);
            this.textBox_UrlBar.TabIndex = 1;
            this.textBox_UrlBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_UrlBar_KeyDown);
            // 
            // label_CsToJs
            // 
            this.label_CsToJs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CsToJs.AutoSize = true;
            this.label_CsToJs.Location = new System.Drawing.Point(661, 37);
            this.label_CsToJs.Name = "label_CsToJs";
            this.label_CsToJs.Size = new System.Drawing.Size(126, 12);
            this.label_CsToJs.TabIndex = 2;
            this.label_CsToJs.Text = "◆C#からJavaScriptへ＞";
            // 
            // label_JsToCs
            // 
            this.label_JsToCs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JsToCs.AutoSize = true;
            this.label_JsToCs.Location = new System.Drawing.Point(661, 230);
            this.label_JsToCs.Name = "label_JsToCs";
            this.label_JsToCs.Size = new System.Drawing.Size(165, 12);
            this.label_JsToCs.TabIndex = 4;
            this.label_JsToCs.Text = "◆JavaScriptから受け取った値＞\r\n";
            // 
            // richTextBox_JsToCs
            // 
            this.richTextBox_JsToCs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_JsToCs.Location = new System.Drawing.Point(662, 245);
            this.richTextBox_JsToCs.Name = "richTextBox_JsToCs";
            this.richTextBox_JsToCs.Size = new System.Drawing.Size(345, 193);
            this.richTextBox_JsToCs.TabIndex = 5;
            this.richTextBox_JsToCs.Text = "";
            // 
            // button_CsToJs
            // 
            this.button_CsToJs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_CsToJs.Location = new System.Drawing.Point(661, 77);
            this.button_CsToJs.Name = "button_CsToJs";
            this.button_CsToJs.Size = new System.Drawing.Size(66, 23);
            this.button_CsToJs.TabIndex = 6;
            this.button_CsToJs.Text = "▼送信";
            this.button_CsToJs.UseVisualStyleBackColor = true;
            this.button_CsToJs.Click += new System.EventHandler(this.button_CsToJs_Click);
            // 
            // label_UrlBar
            // 
            this.label_UrlBar.AutoSize = true;
            this.label_UrlBar.Location = new System.Drawing.Point(13, 19);
            this.label_UrlBar.Name = "label_UrlBar";
            this.label_UrlBar.Size = new System.Drawing.Size(27, 12);
            this.label_UrlBar.TabIndex = 7;
            this.label_UrlBar.Text = "URL";
            // 
            // textBox_CsToJs
            // 
            this.textBox_CsToJs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CsToJs.Location = new System.Drawing.Point(661, 52);
            this.textBox_CsToJs.Name = "textBox_CsToJs";
            this.textBox_CsToJs.Size = new System.Drawing.Size(346, 19);
            this.textBox_CsToJs.TabIndex = 8;
            // 
            // label_CsToJsReturn
            // 
            this.label_CsToJsReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CsToJsReturn.AutoSize = true;
            this.label_CsToJsReturn.Location = new System.Drawing.Point(663, 107);
            this.label_CsToJsReturn.Name = "label_CsToJsReturn";
            this.label_CsToJsReturn.Size = new System.Drawing.Size(90, 12);
            this.label_CsToJsReturn.TabIndex = 9;
            this.label_CsToJsReturn.Text = "Jsからの戻り値＞";
            // 
            // richTextBox_CsToJsReturn
            // 
            this.richTextBox_CsToJsReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_CsToJsReturn.Location = new System.Drawing.Point(663, 123);
            this.richTextBox_CsToJsReturn.Name = "richTextBox_CsToJsReturn";
            this.richTextBox_CsToJsReturn.Size = new System.Drawing.Size(344, 87);
            this.richTextBox_CsToJsReturn.TabIndex = 10;
            this.richTextBox_CsToJsReturn.Text = "";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(932, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.richTextBox_CsToJsReturn);
            this.Controls.Add(this.label_CsToJsReturn);
            this.Controls.Add(this.textBox_CsToJs);
            this.Controls.Add(this.label_UrlBar);
            this.Controls.Add(this.button_CsToJs);
            this.Controls.Add(this.richTextBox_JsToCs);
            this.Controls.Add(this.label_JsToCs);
            this.Controls.Add(this.label_CsToJs);
            this.Controls.Add(this.textBox_UrlBar);
            this.Controls.Add(this.webView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.TextBox textBox_UrlBar;
        private System.Windows.Forms.Label label_CsToJs;
        private System.Windows.Forms.Label label_JsToCs;
        private System.Windows.Forms.Button button_CsToJs;
        private System.Windows.Forms.Label label_UrlBar;
        public System.Windows.Forms.RichTextBox richTextBox_JsToCs;
        private System.Windows.Forms.TextBox textBox_CsToJs;
        private System.Windows.Forms.Label label_CsToJsReturn;
        private System.Windows.Forms.RichTextBox richTextBox_CsToJsReturn;
        private System.Windows.Forms.Button buttonClose;
    }
}

