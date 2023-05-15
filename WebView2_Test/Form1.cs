using Microsoft.Web;
using Microsoft.Web.WebView2.Core;//WebView2
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebView2_Test
{
    public partial class Form1 : Form
    {
        //JavaScriptで呼ぶ関数を保持するオブジェクト
        private JsToCs jsToCs = new JsToCs();

        //コンストラクタ
        public Form1(string path)
        {
            //JsToCsクラスでForm1のフォーム取得参照用
            jsToCs.form1 = this;

            InitializeComponent();

            //URLを設定
            this.textBox_UrlBar.Text = path;
            this.webView.Source = new Uri(path);

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
                    this.textBox_UrlBar.Text = url;

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
        private void textBox_UrlBar_KeyDown(object sender, KeyEventArgs e)
        {
            //EnterキーならばURL反映
            if (e.KeyCode == Keys.Enter)
            {
                if (webView != null && webView.CoreWebView2 != null)
                {
                    webView.CoreWebView2.Navigate(this.textBox_UrlBar.Text);
                }
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
                case "patternA.html":
                    //作成予定
                    break;
                case "patternB.html":
                    //作成予定
                    break;
                default:
                    Console.WriteLine("未登録のhtmlです");
                    break;
            }
        }
    }

}