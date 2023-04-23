using Microsoft.Web.WebView2.Core;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WebView2_Test
{
    public partial class Form1 : Form
    {
        //JavaScriptで呼ぶ関数を保持するオブジェクト
        private JsToCs CsClass = new JsToCs();

        public Form1()
        {
            //JsToCsクラスでForm1のフォーム取得参照用
            CsClass.form1 = this;

            InitializeComponent();

            //URLを設定
            this.textBox_UrlBar.Text = System.IO.Path.GetFullPath(@"..\\..\\html\\sample.html");
            this.webView.Source = new Uri(this.textBox_UrlBar.Text);

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
                    webView.CoreWebView2.AddHostObjectToScript("CsClass", CsClass);
                }
                else MessageBox.Show("CoreWebView2==null");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //イベント - URL変更
        private void textBox_UrlBar_TextChanged(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(this.textBox_UrlBar.Text);
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

    }

    /// <summary>WebView2に読み込ませるためのJsで実行する関数を保持させたクラス</summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    public class JsToCs
    {
        public Form1 form1;

        //Jsからの呼び出し
        public void JsToCsMethod(string strText)
        {
            form1.richTextBox_JsToCs.AppendText(strText + "\n");
        }
    }
}