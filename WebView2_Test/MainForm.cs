﻿using Microsoft.Web;
using Microsoft.Web.WebView2.Core;//WebView2
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebView2_Test
{
    public partial class MainForm : Form
    {
        //JavaScriptで呼ぶ関数を保持するオブジェクト
        private JsToCs jsToCs = new JsToCs();

        //コンストラクタ
        public MainForm()
        {
            //JsToCsクラスでForm1のフォーム取得参照用
            jsToCs.mainform = this;

            InitializeComponent();

            //パネル1のスクロールバーを非表示　→なぜか非表示にならない
            splitContainerRightUD.Panel1.HorizontalScroll.Visible = false;
            //パネル1をパネル2と連動スクロール
            splitContainerRightUD.Panel2.Scroll += Panel2_Scroll;

            //URLを設定
            string path = System.IO.Path.GetFullPath(@"..\..\html\topMenu.html");
            this.textBoxUrlBar.Text = path;
            this.webView.Source = new Uri(path);

            //WebView2のロード完了時のイベント
            webView.NavigationCompleted += WebView_NavigationCompleted;
        }

        //パネル1をパネル2と連動スクロール
        private void Panel2_Scroll(object sender, ScrollEventArgs e)
        {
            splitContainerRightUD.Panel1.HorizontalScroll.Value = splitContainerRightUD.Panel2.HorizontalScroll.Value;
        }

        //WebView2のロード完了時
        private void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            try
            {
                if (webView.CoreWebView2 != null)
                {
                    //JavaScriptからC#のメソッドが実行できる様に仕込む
                    webView.CoreWebView2.AddHostObjectToScript("jsToCs", jsToCs);

                    //URLバーを更新する
                    string url = this.webView.Source.ToString();
                    this.textBoxUrlBar.Text = url;

                    //本フォームのWebView2内でhtmlを切り替える
                    Transform(url);
                }
                else MessageBox.Show("CoreWebView2==null");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //イベント - URLバーでキーダウン
        private void textBoxUrlBar_KeyDown(object sender, KeyEventArgs e)
        {
            //エンターならばURLを反映
            if (e.KeyCode == Keys.Enter)
            {
                this.webView.CoreWebView2.Navigate(this.textBoxUrlBar.Text);
            }
        }

        //イベント - C#からJavaScriptへ送信ボタン
        private async void button_CsToJs_Click(object sender, EventArgs e)
        {
            string sendStr = this.textBox_CsToJs.Text;

            //JavaScriptの関数を実行
            string str1 = await webView.ExecuteScriptAsync("jsFunc1(\"" + sendStr + "\")");
            //Jsからの戻り値を表示
            this.richTextBox_CsToJsReturn.AppendText(str1 + "\n");
        }

        //イベント - 閉じるボタン
        public void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //htmlファイル名に応じてフォーム内の構成を変更する
        private void Transform(string url)
        {
            //ファイル名を取得
            string fimeneme = System.IO.Path.GetFileName(url);
            switch(fimeneme){
                case "topMenu.html" :
                case "patternA.html":
                    //作成予定
                    break;
                case "patternB.html":
                    //作成予定
                    break;
                default:
                    MessageBox.Show("未登録のhtmlです");
                    break;
            }
        }

        bool isEveRunning = false;
        bool swScrollVisible = false;
        bool swScrollVisibleOld = false;
        private void splitContainerRightUD_Panel1_SizeChanged(object sender, EventArgs e)
        {
            if (isEveRunning == false)
            {
                isEveRunning = true;
                AdjustSplitter();
                isEveRunning = false;
            }
        }
        private void AdjustSplitter()
        {
            if (splitContainerRightUD.Panel1.HorizontalScroll.Visible)
            {
                swScrollVisible = true;
            }
            else
            {
                swScrollVisible = false;
            }

            if ((swScrollVisible == true) && (swScrollVisibleOld == false))
            {
                Console.WriteLine("水平スクロールバーが表示されました");
                splitContainerRightUD.SplitterDistance = 50;
            }
            else if ((swScrollVisible == false) && (swScrollVisibleOld == true))
            {
                Console.WriteLine("水平スクロールバーが非表示になりました");
                splitContainerRightUD.SplitterDistance = 35;
            }

            swScrollVisibleOld = swScrollVisible;
        }
    }

}