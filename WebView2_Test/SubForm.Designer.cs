namespace WebView2_Test
{
    partial class SubForm
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
            this.textBoxUrlBar = new System.Windows.Forms.TextBox();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.richTextBox_JsToCs = new System.Windows.Forms.RichTextBox();
            this.richTextBox_CsToJsReturn = new System.Windows.Forms.RichTextBox();
            this.textBox_CsToJs = new System.Windows.Forms.TextBox();
            this.label_CsToJsReturn = new System.Windows.Forms.Label();
            this.button_CsToJs = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelTopRightButton = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelTopRightButton.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUrlBar
            // 
            this.textBoxUrlBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrlBar.Location = new System.Drawing.Point(3, 3);
            this.textBoxUrlBar.Name = "textBoxUrlBar";
            this.textBoxUrlBar.Size = new System.Drawing.Size(606, 19);
            this.textBoxUrlBar.TabIndex = 1;
            this.textBoxUrlBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUrlBar_KeyDown);
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(3, 28);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(606, 324);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // richTextBox_JsToCs
            // 
            this.richTextBox_JsToCs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_JsToCs.Location = new System.Drawing.Point(6, 18);
            this.richTextBox_JsToCs.Name = "richTextBox_JsToCs";
            this.richTextBox_JsToCs.Size = new System.Drawing.Size(239, 133);
            this.richTextBox_JsToCs.TabIndex = 5;
            this.richTextBox_JsToCs.Text = "";
            // 
            // richTextBox_CsToJsReturn
            // 
            this.richTextBox_CsToJsReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_CsToJsReturn.Location = new System.Drawing.Point(6, 84);
            this.richTextBox_CsToJsReturn.Name = "richTextBox_CsToJsReturn";
            this.richTextBox_CsToJsReturn.Size = new System.Drawing.Size(239, 61);
            this.richTextBox_CsToJsReturn.TabIndex = 10;
            this.richTextBox_CsToJsReturn.Text = "";
            // 
            // textBox_CsToJs
            // 
            this.textBox_CsToJs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CsToJs.Location = new System.Drawing.Point(6, 18);
            this.textBox_CsToJs.Name = "textBox_CsToJs";
            this.textBox_CsToJs.Size = new System.Drawing.Size(239, 19);
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
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.Controls.Add(this.panelLeft, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(884, 361);
            this.tableLayoutPanel.TabIndex = 13;
            // 
            // panelLeft
            // 
            this.panelLeft.AutoScroll = true;
            this.panelLeft.Controls.Add(this.textBoxUrlBar);
            this.panelLeft.Controls.Add(this.webView);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(3, 3);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(612, 355);
            this.panelLeft.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panelTopRightButton);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(621, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 355);
            this.panel1.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.richTextBox_JsToCs);
            this.groupBox2.Location = new System.Drawing.Point(3, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 157);
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
            this.panelTopRightButton.Location = new System.Drawing.Point(13, 3);
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
            this.groupBox1.Location = new System.Drawing.Point(3, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 151);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "◆C#からJavaScriptへ＞";
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "SubForm";
            this.Text = "SubForm";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panelTopRightButton.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUrlBar;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        public System.Windows.Forms.RichTextBox richTextBox_JsToCs;
        private System.Windows.Forms.RichTextBox richTextBox_CsToJsReturn;
        private System.Windows.Forms.TextBox textBox_CsToJs;
        private System.Windows.Forms.Label label_CsToJsReturn;
        private System.Windows.Forms.Button button_CsToJs;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelTopRightButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}