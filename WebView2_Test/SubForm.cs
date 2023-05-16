using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebView2_Test
{
    public partial class SubForm : Form
    {
        //JavaScriptで呼ぶ関数を保持するオブジェクト
        private JsToCs jsToCs = new JsToCs();

        //コンストラクタ
        public SubForm(string url)
        {
            //JsToCsクラスでForm1のフォーム取得参照用
            jsToCs.subform = this;

            InitializeComponent();

            //URLを設定
            //string path = System.IO.Path.GetFullPath(url);
            this.textBoxUrlBar.Text = url;
            this.webView.Source = new Uri(url);

            //WebView2のロード完了時のイベント
            webView.NavigationCompleted += WebView_NavigationCompleted;
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
            switch (fimeneme)
            {
                case "subPatternA.html":
                    //作成予定
                    break;
                case "subPatternB.html":
                    //作成予定
                    break;
                default:
                    MessageBox.Show("未登録のhtmlです");
                    break;
            }
        }
    }
}
