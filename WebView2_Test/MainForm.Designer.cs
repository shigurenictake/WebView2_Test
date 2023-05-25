namespace WebView2_Test
{
    partial class MainForm
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
            this.textBoxUrlBar = new System.Windows.Forms.TextBox();
            this.richTextBox_JsToCs = new System.Windows.Forms.RichTextBox();
            this.button_CsToJs = new System.Windows.Forms.Button();
            this.textBox_CsToJs = new System.Windows.Forms.TextBox();
            this.label_CsToJsReturn = new System.Windows.Forms.Label();
            this.richTextBox_CsToJsReturn = new System.Windows.Forms.RichTextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelTopRightButton = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainerLR = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeftUD = new System.Windows.Forms.SplitContainer();
            this.splitContainerRightUD = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panelTopRightButton.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLR)).BeginInit();
            this.splitContainerLR.Panel1.SuspendLayout();
            this.splitContainerLR.Panel2.SuspendLayout();
            this.splitContainerLR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeftUD)).BeginInit();
            this.splitContainerLeftUD.Panel2.SuspendLayout();
            this.splitContainerLeftUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRightUD)).BeginInit();
            this.splitContainerRightUD.Panel1.SuspendLayout();
            this.splitContainerRightUD.Panel2.SuspendLayout();
            this.splitContainerRightUD.SuspendLayout();
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
            this.webView.Location = new System.Drawing.Point(3, 3);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(910, 624);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // textBoxUrlBar
            // 
            this.textBoxUrlBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrlBar.Location = new System.Drawing.Point(3, 633);
            this.textBoxUrlBar.Name = "textBoxUrlBar";
            this.textBoxUrlBar.Size = new System.Drawing.Size(910, 19);
            this.textBoxUrlBar.TabIndex = 1;
            this.textBoxUrlBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUrlBar_KeyDown);
            // 
            // richTextBox_JsToCs
            // 
            this.richTextBox_JsToCs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_JsToCs.Location = new System.Drawing.Point(6, 18);
            this.richTextBox_JsToCs.Name = "richTextBox_JsToCs";
            this.richTextBox_JsToCs.Size = new System.Drawing.Size(438, 117);
            this.richTextBox_JsToCs.TabIndex = 5;
            this.richTextBox_JsToCs.Text = "";
            // 
            // button_CsToJs
            // 
            this.button_CsToJs.Location = new System.Drawing.Point(6, 43);
            this.button_CsToJs.Name = "button_CsToJs";
            this.button_CsToJs.Size = new System.Drawing.Size(66, 23);
            this.button_CsToJs.TabIndex = 6;
            this.button_CsToJs.Text = "▼送信";
            this.button_CsToJs.UseVisualStyleBackColor = true;
            this.button_CsToJs.Click += new System.EventHandler(this.button_CsToJs_Click);
            // 
            // textBox_CsToJs
            // 
            this.textBox_CsToJs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CsToJs.Location = new System.Drawing.Point(6, 18);
            this.textBox_CsToJs.Name = "textBox_CsToJs";
            this.textBox_CsToJs.Size = new System.Drawing.Size(438, 19);
            this.textBox_CsToJs.TabIndex = 8;
            // 
            // label_CsToJsReturn
            // 
            this.label_CsToJsReturn.AutoSize = true;
            this.label_CsToJsReturn.Location = new System.Drawing.Point(6, 69);
            this.label_CsToJsReturn.Name = "label_CsToJsReturn";
            this.label_CsToJsReturn.Size = new System.Drawing.Size(90, 12);
            this.label_CsToJsReturn.TabIndex = 9;
            this.label_CsToJsReturn.Text = "Jsからの戻り値＞";
            // 
            // richTextBox_CsToJsReturn
            // 
            this.richTextBox_CsToJsReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_CsToJsReturn.Location = new System.Drawing.Point(6, 84);
            this.richTextBox_CsToJsReturn.Name = "richTextBox_CsToJsReturn";
            this.richTextBox_CsToJsReturn.Size = new System.Drawing.Size(438, 102);
            this.richTextBox_CsToJsReturn.TabIndex = 10;
            this.richTextBox_CsToJsReturn.Text = "";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(166, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.richTextBox_JsToCs);
            this.groupBox2.Location = new System.Drawing.Point(3, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 141);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "◆JavaScriptから受け取った値＞";
            // 
            // panelTopRightButton
            // 
            this.panelTopRightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopRightButton.Controls.Add(this.button1);
            this.panelTopRightButton.Controls.Add(this.button2);
            this.panelTopRightButton.Controls.Add(this.buttonClose);
            this.panelTopRightButton.Location = new System.Drawing.Point(211, 1);
            this.panelTopRightButton.Name = "panelTopRightButton";
            this.panelTopRightButton.Size = new System.Drawing.Size(244, 29);
            this.panelTopRightButton.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "戻る";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(85, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "進む";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.richTextBox_CsToJsReturn);
            this.groupBox1.Controls.Add(this.textBox_CsToJs);
            this.groupBox1.Controls.Add(this.label_CsToJsReturn);
            this.groupBox1.Controls.Add(this.button_CsToJs);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 192);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "◆C#からJavaScriptへ＞";
            // 
            // splitContainerLR
            // 
            this.splitContainerLR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLR.IsSplitterFixed = true;
            this.splitContainerLR.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLR.Name = "splitContainerLR";
            // 
            // splitContainerLR.Panel1
            // 
            this.splitContainerLR.Panel1.Controls.Add(this.splitContainerLeftUD);
            // 
            // splitContainerLR.Panel2
            // 
            this.splitContainerLR.Panel2.Controls.Add(this.splitContainerRightUD);
            this.splitContainerLR.Size = new System.Drawing.Size(1384, 661);
            this.splitContainerLR.SplitterDistance = 920;
            this.splitContainerLR.TabIndex = 13;
            // 
            // splitContainerLeftUD
            // 
            this.splitContainerLeftUD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerLeftUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeftUD.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerLeftUD.IsSplitterFixed = true;
            this.splitContainerLeftUD.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeftUD.Name = "splitContainerLeftUD";
            this.splitContainerLeftUD.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainerLeftUD.Panel1Collapsed = true;
            this.splitContainerLeftUD.Panel1MinSize = 35;
            // 
            // splitContainerLeftUD.Panel2
            // 
            this.splitContainerLeftUD.Panel2.Controls.Add(this.textBoxUrlBar);
            this.splitContainerLeftUD.Panel2.Controls.Add(this.webView);
            this.splitContainerLeftUD.Size = new System.Drawing.Size(920, 661);
            this.splitContainerLeftUD.SplitterDistance = 35;
            this.splitContainerLeftUD.TabIndex = 0;
            // 
            // splitContainerRightUD
            // 
            this.splitContainerRightUD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerRightUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRightUD.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerRightUD.IsSplitterFixed = true;
            this.splitContainerRightUD.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRightUD.Name = "splitContainerRightUD";
            this.splitContainerRightUD.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRightUD.Panel1
            // 
            this.splitContainerRightUD.Panel1.AutoScroll = true;
            this.splitContainerRightUD.Panel1.AutoScrollMinSize = new System.Drawing.Size(400, 0);
            this.splitContainerRightUD.Panel1.Controls.Add(this.panelTopRightButton);
            this.splitContainerRightUD.Panel1MinSize = 35;
            // 
            // splitContainerRightUD.Panel2
            // 
            this.splitContainerRightUD.Panel2.AutoScroll = true;
            this.splitContainerRightUD.Panel2.AutoScrollMinSize = new System.Drawing.Size(400, 600);
            this.splitContainerRightUD.Panel2.Controls.Add(this.groupBox2);
            this.splitContainerRightUD.Panel2.Controls.Add(this.groupBox1);
            this.splitContainerRightUD.Panel2.SizeChanged += new System.EventHandler(this.splitContainer1_Panel2_SizeChanged);
            this.splitContainerRightUD.Size = new System.Drawing.Size(460, 661);
            this.splitContainerRightUD.SplitterDistance = 35;
            this.splitContainerRightUD.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.splitContainerLR);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panelTopRightButton.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainerLR.Panel1.ResumeLayout(false);
            this.splitContainerLR.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLR)).EndInit();
            this.splitContainerLR.ResumeLayout(false);
            this.splitContainerLeftUD.Panel2.ResumeLayout(false);
            this.splitContainerLeftUD.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeftUD)).EndInit();
            this.splitContainerLeftUD.ResumeLayout(false);
            this.splitContainerRightUD.Panel1.ResumeLayout(false);
            this.splitContainerRightUD.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRightUD)).EndInit();
            this.splitContainerRightUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.TextBox textBoxUrlBar;
        private System.Windows.Forms.Button button_CsToJs;
        public System.Windows.Forms.RichTextBox richTextBox_JsToCs;
        private System.Windows.Forms.TextBox textBox_CsToJs;
        private System.Windows.Forms.Label label_CsToJsReturn;
        private System.Windows.Forms.RichTextBox richTextBox_CsToJsReturn;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelTopRightButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer splitContainerLR;
        private System.Windows.Forms.SplitContainer splitContainerLeftUD;
        private System.Windows.Forms.SplitContainer splitContainerRightUD;
    }
}

