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
            this.panelBHC = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainerLR = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeftUD = new System.Windows.Forms.SplitContainer();
            this.splitContainerRightUD = new System.Windows.Forms.SplitContainer();
            this.panelForUCCon = new System.Windows.Forms.Panel();
            this.buttonUCAc = new System.Windows.Forms.Button();
            this.buttonUCAb = new System.Windows.Forms.Button();
            this.buttonUCAa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panelBHC.SuspendLayout();
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
            this.panelForUCCon.SuspendLayout();
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
            this.webView.Size = new System.Drawing.Size(931, 674);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // textBoxUrlBar
            // 
            this.textBoxUrlBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrlBar.Location = new System.Drawing.Point(3, 683);
            this.textBoxUrlBar.Name = "textBoxUrlBar";
            this.textBoxUrlBar.Size = new System.Drawing.Size(931, 19);
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
            this.richTextBox_JsToCs.Size = new System.Drawing.Size(467, 117);
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
            this.textBox_CsToJs.Size = new System.Drawing.Size(467, 19);
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
            this.richTextBox_CsToJsReturn.Size = new System.Drawing.Size(467, 102);
            this.richTextBox_CsToJsReturn.TabIndex = 10;
            this.richTextBox_CsToJsReturn.Text = "";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(124, 3);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(60, 23);
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
            this.groupBox2.Size = new System.Drawing.Size(479, 141);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "◆JavaScriptから受け取った値＞";
            // 
            // panelBHC
            // 
            this.panelBHC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBHC.BackColor = System.Drawing.SystemColors.Control;
            this.panelBHC.Controls.Add(this.buttonHelp);
            this.panelBHC.Controls.Add(this.buttonBack);
            this.panelBHC.Controls.Add(this.buttonClose);
            this.panelBHC.Location = new System.Drawing.Point(298, 0);
            this.panelBHC.Margin = new System.Windows.Forms.Padding(0);
            this.panelBHC.Name = "panelBHC";
            this.panelBHC.Size = new System.Drawing.Size(187, 26);
            this.panelBHC.TabIndex = 13;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.Location = new System.Drawing.Point(64, 3);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(60, 23);
            this.buttonHelp.TabIndex = 17;
            this.buttonHelp.Text = "ヘルプ";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(4, 3);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(60, 23);
            this.buttonBack.TabIndex = 18;
            this.buttonBack.Text = "戻る";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
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
            this.groupBox1.Size = new System.Drawing.Size(479, 192);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "◆C#からJavaScriptへ＞";
            // 
            // splitContainerLR
            // 
            this.splitContainerLR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerLR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLR.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLR.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerLR.Name = "splitContainerLR";
            // 
            // splitContainerLR.Panel1
            // 
            this.splitContainerLR.Panel1.Controls.Add(this.splitContainerLeftUD);
            // 
            // splitContainerLR.Panel2
            // 
            this.splitContainerLR.Panel2.Controls.Add(this.splitContainerRightUD);
            this.splitContainerLR.Panel2MinSize = 420;
            this.splitContainerLR.Size = new System.Drawing.Size(1434, 711);
            this.splitContainerLR.SplitterDistance = 941;
            this.splitContainerLR.TabIndex = 13;
            // 
            // splitContainerLeftUD
            // 
            this.splitContainerLeftUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeftUD.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerLeftUD.IsSplitterFixed = true;
            this.splitContainerLeftUD.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeftUD.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerLeftUD.Name = "splitContainerLeftUD";
            this.splitContainerLeftUD.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainerLeftUD.Panel1Collapsed = true;
            this.splitContainerLeftUD.Panel1MinSize = 26;
            // 
            // splitContainerLeftUD.Panel2
            // 
            this.splitContainerLeftUD.Panel2.Controls.Add(this.textBoxUrlBar);
            this.splitContainerLeftUD.Panel2.Controls.Add(this.webView);
            this.splitContainerLeftUD.Size = new System.Drawing.Size(937, 707);
            this.splitContainerLeftUD.SplitterDistance = 26;
            this.splitContainerLeftUD.SplitterWidth = 1;
            this.splitContainerLeftUD.TabIndex = 0;
            // 
            // splitContainerRightUD
            // 
            this.splitContainerRightUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRightUD.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerRightUD.IsSplitterFixed = true;
            this.splitContainerRightUD.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRightUD.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerRightUD.Name = "splitContainerRightUD";
            this.splitContainerRightUD.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRightUD.Panel1
            // 
            this.splitContainerRightUD.Panel1.Controls.Add(this.panelForUCCon);
            this.splitContainerRightUD.Panel1.Controls.Add(this.panelBHC);
            this.splitContainerRightUD.Panel1MinSize = 26;
            // 
            // splitContainerRightUD.Panel2
            // 
            this.splitContainerRightUD.Panel2.AutoScroll = true;
            this.splitContainerRightUD.Panel2.AutoScrollMinSize = new System.Drawing.Size(0, 600);
            this.splitContainerRightUD.Panel2.Controls.Add(this.groupBox2);
            this.splitContainerRightUD.Panel2.Controls.Add(this.groupBox1);
            this.splitContainerRightUD.Size = new System.Drawing.Size(485, 707);
            this.splitContainerRightUD.SplitterDistance = 26;
            this.splitContainerRightUD.SplitterWidth = 1;
            this.splitContainerRightUD.TabIndex = 0;
            // 
            // panelForUCCon
            // 
            this.panelForUCCon.BackColor = System.Drawing.SystemColors.Control;
            this.panelForUCCon.Controls.Add(this.buttonUCAc);
            this.panelForUCCon.Controls.Add(this.buttonUCAb);
            this.panelForUCCon.Controls.Add(this.buttonUCAa);
            this.panelForUCCon.Location = new System.Drawing.Point(0, 0);
            this.panelForUCCon.Margin = new System.Windows.Forms.Padding(0);
            this.panelForUCCon.Name = "panelForUCCon";
            this.panelForUCCon.Size = new System.Drawing.Size(229, 26);
            this.panelForUCCon.TabIndex = 17;
            // 
            // buttonUCAc
            // 
            this.buttonUCAc.Location = new System.Drawing.Point(153, 3);
            this.buttonUCAc.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUCAc.Name = "buttonUCAc";
            this.buttonUCAc.Size = new System.Drawing.Size(75, 23);
            this.buttonUCAc.TabIndex = 2;
            this.buttonUCAc.Text = "UCAc";
            this.buttonUCAc.UseVisualStyleBackColor = true;
            // 
            // buttonUCAb
            // 
            this.buttonUCAb.Location = new System.Drawing.Point(78, 3);
            this.buttonUCAb.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUCAb.Name = "buttonUCAb";
            this.buttonUCAb.Size = new System.Drawing.Size(75, 23);
            this.buttonUCAb.TabIndex = 1;
            this.buttonUCAb.Text = "UCAb";
            this.buttonUCAb.UseVisualStyleBackColor = true;
            // 
            // buttonUCAa
            // 
            this.buttonUCAa.Location = new System.Drawing.Point(3, 3);
            this.buttonUCAa.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUCAa.Name = "buttonUCAa";
            this.buttonUCAa.Size = new System.Drawing.Size(75, 23);
            this.buttonUCAa.TabIndex = 0;
            this.buttonUCAa.Text = "UCAa";
            this.buttonUCAa.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 711);
            this.Controls.Add(this.splitContainerLR);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panelBHC.ResumeLayout(false);
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
            this.panelForUCCon.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelBHC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.SplitContainer splitContainerLR;
        private System.Windows.Forms.SplitContainer splitContainerLeftUD;
        private System.Windows.Forms.SplitContainer splitContainerRightUD;
        private System.Windows.Forms.Panel panelForUCCon;
        private System.Windows.Forms.Button buttonUCAa;
        private System.Windows.Forms.Button buttonUCAc;
        private System.Windows.Forms.Button buttonUCAb;
    }
}

