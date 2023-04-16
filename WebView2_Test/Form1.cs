
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebView2_Test
{
    public partial class Form1 : Form
    {
        /// <summary>webviewのコントロール（わかりやすい様に、デザイナーを使わずにコード側で実装します。）</summary>
        //private Microsoft.Web.WebView2.WinForms.WebView2 webView = new Microsoft.Web.WebView2.WinForms.WebView2();

        /// <summary>JavaScriptで呼ぶ関数を保持するオブジェクト</summary>
        private JsToCs CsClass = new JsToCs();

        public Form1()
        {
            //JsToCsクラスでForm1のフォーム取得参照用
            CsClass.form1 = this;

            //this.Controls.Add(webView);
            InitializeComponent();

            //URLを設定
            this.textBox_UrlBar.Text = System.IO.Path.GetFullPath(@"..\\..\\html\\sample.html");
            this.webView.Source = new Uri(this.textBox_UrlBar.Text);

            //WebView2のサイズをフォームのサイズに合わせる
            //webView.Size = this.Size;
            //this.SizeChanged += Form1_SizeChanged;

            //WebView2のロード完了時のイベント
            webView.NavigationCompleted += WebView_NavigationCompleted;
        }

        /// <summary>WebView2のロード完了時</summary>
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
            //WebView.ExecuteScriptAsync("func1()").ResultをするとWebView2がフリーズする
            string str1 = await webView.ExecuteScriptAsync("jsFunc1(\"" + sendStr + "\")");
            this.richTextBox_JsToCs.AppendText("Jsからの戻り値＞" + str1 + "\n");
        }


        /// <summary>サイズ変更時のイベントでWebView2のサイズをフォームに合わせる</summary>
        //private void Form1_SizeChanged(object sender, EventArgs e)
        //{
        //    webView.Size = this.Size;
        //}
    }

    //↓属性設定が無いとエラーになります
    /// <summary>WebView2に読み込ませるためのJsで実行する関数を保持させたクラス</summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    public class JsToCs
    {
        public Form1 form1;

        /*        public JsToCs(Form1 form1)
                {
                    this.form1 = new Form1();
                }*/

        //Jsからの呼び出し
        public void JsToCsMethod(string strText)
        {
            form1.richTextBox_JsToCs.AppendText(strText + "\n");
        }
    }
}