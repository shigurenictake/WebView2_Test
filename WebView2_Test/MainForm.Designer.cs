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
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainerLR = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeftUD = new System.Windows.Forms.SplitContainer();
            this.splitContainerRightUD = new System.Windows.Forms.SplitContainer();
            this.panelRUForLinkScroll = new System.Windows.Forms.Panel();
            this.panelForUCA = new System.Windows.Forms.Panel();
            this.buttonUCAc = new System.Windows.Forms.Button();
            this.buttonUCAb = new System.Windows.Forms.Button();
            this.buttonUCAa = new System.Windows.Forms.Button();
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
            this.panelRUForLinkScroll.SuspendLayout();
            this.panelForUCA.SuspendLayout();
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
            this.webView.Size = new System.Drawing.Size(900, 624);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // textBoxUrlBar
            // 
            this.textBoxUrlBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrlBar.Location = new System.Drawing.Point(3, 633);
            this.textBoxUrlBar.Name = "textBoxUrlBar";
            this.textBoxUrlBar.Size = new System.Drawing.Size(900, 19);
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
            this.richTextBox_JsToCs.Size = new System.Drawing.Size(448, 117);
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
            this.textBox_CsToJs.Size = new System.Drawing.Size(448, 19);
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
            this.richTextBox_CsToJsReturn.Size = new System.Drawing.Size(448, 102);
            this.richTextBox_CsToJsReturn.TabIndex = 10;
            this.richTextBox_CsToJsReturn.Text = "";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(135, 4);
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
            this.groupBox2.Size = new System.Drawing.Size(460, 141);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "◆JavaScriptから受け取った値＞";
            // 
            // panelTopRightButton
            // 
            this.panelTopRightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopRightButton.BackColor = System.Drawing.SystemColors.Control;
            this.panelTopRightButton.Controls.Add(this.buttonHelp);
            this.panelTopRightButton.Controls.Add(this.buttonBack);
            this.panelTopRightButton.Controls.Add(this.buttonClose);
            this.panelTopRightButton.Location = new System.Drawing.Point(262, 0);
            this.panelTopRightButton.Name = "panelTopRightButton";
            this.panelTopRightButton.Size = new System.Drawing.Size(201, 34);
            this.panelTopRightButton.TabIndex = 13;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.Location = new System.Drawing.Point(3, 4);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(60, 23);
            this.buttonHelp.TabIndex = 17;
            this.buttonHelp.Text = "ヘルプ";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(69, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(60, 23);
            this.buttonBack.TabIndex = 18;
            this.buttonBack.Text = "戻る";
            this.buttonBack.UseVisualStyleBackColor = true;
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
            this.groupBox1.Size = new System.Drawing.Size(460, 192);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "◆C#からJavaScriptへ＞";
            // 
            // splitContainerLR
            // 
            this.splitContainerLR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerLR.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.splitContainerLR.SplitterDistance = 910;
            this.splitContainerLR.TabIndex = 13;
            this.splitContainerLR.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainerLR_SplitterMoved);
            // 
            // splitContainerLeftUD
            // 
            this.splitContainerLeftUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeftUD.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerLeftUD.IsSplitterFixed = true;
            this.splitContainerLeftUD.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeftUD.Name = "splitContainerLeftUD";
            this.splitContainerLeftUD.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainerLeftUD.Panel1Collapsed = true;
            this.splitContainerLeftUD.Panel1MinSize = 40;
            // 
            // splitContainerLeftUD.Panel2
            // 
            this.splitContainerLeftUD.Panel2.Controls.Add(this.textBoxUrlBar);
            this.splitContainerLeftUD.Panel2.Controls.Add(this.webView);
            this.splitContainerLeftUD.Size = new System.Drawing.Size(906, 657);
            this.splitContainerLeftUD.SplitterDistance = 40;
            this.splitContainerLeftUD.TabIndex = 0;
            // 
            // splitContainerRightUD
            // 
            this.splitContainerRightUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRightUD.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerRightUD.IsSplitterFixed = true;
            this.splitContainerRightUD.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRightUD.Name = "splitContainerRightUD";
            this.splitContainerRightUD.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRightUD.Panel1
            // 
            this.splitContainerRightUD.Panel1.Controls.Add(this.panelRUForLinkScroll);
            this.splitContainerRightUD.Panel1.SizeChanged += new System.EventHandler(this.splitContainerRightUD_Panel1_SizeChanged);
            this.splitContainerRightUD.Panel1MinSize = 40;
            // 
            // splitContainerRightUD.Panel2
            // 
            this.splitContainerRightUD.Panel2.AutoScroll = true;
            this.splitContainerRightUD.Panel2.AutoScrollMinSize = new System.Drawing.Size(450, 600);
            this.splitContainerRightUD.Panel2.Controls.Add(this.groupBox2);
            this.splitContainerRightUD.Panel2.Controls.Add(this.groupBox1);
            this.splitContainerRightUD.Panel2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.splitContainerRightUD_Panel2_Scroll);
            this.splitContainerRightUD.Panel2MinSize = 0;
            this.splitContainerRightUD.Size = new System.Drawing.Size(466, 657);
            this.splitContainerRightUD.SplitterDistance = 40;
            this.splitContainerRightUD.TabIndex = 0;
            // 
            // panelRUForLinkScroll
            // 
            this.panelRUForLinkScroll.Controls.Add(this.panelForUCA);
            this.panelRUForLinkScroll.Controls.Add(this.panelTopRightButton);
            this.panelRUForLinkScroll.Location = new System.Drawing.Point(0, 0);
            this.panelRUForLinkScroll.Name = "panelRUForLinkScroll";
            this.panelRUForLinkScroll.Size = new System.Drawing.Size(463, 37);
            this.panelRUForLinkScroll.TabIndex = 14;
            // 
            // panelForUCA
            // 
            this.panelForUCA.BackColor = System.Drawing.SystemColors.Control;
            this.panelForUCA.Controls.Add(this.buttonUCAc);
            this.panelForUCA.Controls.Add(this.buttonUCAb);
            this.panelForUCA.Controls.Add(this.buttonUCAa);
            this.panelForUCA.Location = new System.Drawing.Point(0, 0);
            this.panelForUCA.Name = "panelForUCA";
            this.panelForUCA.Size = new System.Drawing.Size(248, 34);
            this.panelForUCA.TabIndex = 17;
            // 
            // buttonUCAc
            // 
            this.buttonUCAc.Location = new System.Drawing.Point(171, 4);
            this.buttonUCAc.Name = "buttonUCAc";
            this.buttonUCAc.Size = new System.Drawing.Size(75, 23);
            this.buttonUCAc.TabIndex = 2;
            this.buttonUCAc.Text = "UCAc";
            this.buttonUCAc.UseVisualStyleBackColor = true;
            // 
            // buttonUCAb
            // 
            this.buttonUCAb.Location = new System.Drawing.Point(90, 4);
            this.buttonUCAb.Name = "buttonUCAb";
            this.buttonUCAb.Size = new System.Drawing.Size(75, 23);
            this.buttonUCAb.TabIndex = 1;
            this.buttonUCAb.Text = "UCAb";
            this.buttonUCAb.UseVisualStyleBackColor = true;
            // 
            // buttonUCAa
            // 
            this.buttonUCAa.Location = new System.Drawing.Point(9, 4);
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
            this.panelRUForLinkScroll.ResumeLayout(false);
            this.panelForUCA.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.SplitContainer splitContainerLR;
        private System.Windows.Forms.SplitContainer splitContainerLeftUD;
        private System.Windows.Forms.SplitContainer splitContainerRightUD;
        private System.Windows.Forms.Panel panelRUForLinkScroll;
        private System.Windows.Forms.Panel panelForUCA;
        private System.Windows.Forms.Button buttonUCAa;
        private System.Windows.Forms.Button buttonUCAc;
        private System.Windows.Forms.Button buttonUCAb;
    }
}

