using Microsoft.Web;
using Microsoft.Web.WebView2.Core;//WebView2
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
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

        //C#からJavaScriptにアクセスする用のクラスオブジェクト
        private CsToJs csToJs = new CsToJs();

        //コンストラクタ
        public MainForm()
        {
            //JsToCsクラスでForm1のフォーム取得参照用
            jsToCs.mainform = this;

            InitializeComponent();

            //本クラスのWebView2を参照できるようにする
            csToJs.webView = this.webView;
            //本フォームのプロパティを参照できるようにする
            csToJs.refForm = this;

            //パネル1のスクロールバーを非表示　→なぜか非表示にならない
            splitContainerRightUD.Panel1.HorizontalScroll.Visible = false;

            //URLを設定
            string path = System.IO.Path.GetFullPath(@"..\..\html\topMenu.html");
            this.textBoxUrlBar.Text = path;
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

                    csToJs.setIsCsharpWebView();

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

        //イベント 戻るボタン
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.webView.GoBack();
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
                    TransformA(fimeneme);
                    break;
                case "patternB.html":
                case "patternB1.html":
                    TransformB(fimeneme);
                    break;
                default:
                    MessageBox.Show("未登録のhtmlです");
                    break;
            }
        }

        //ウィンドウ構成A 全画面html
        private void TransformA(string fimeneme)
        {
            //コントロールのレイアウトを一時中断
            this.SuspendLayout();

            //htmlの閉じるボタンを削除
            this.csToJs.RemoveCloseBtn();

            //タイトルを設定
            this.csToJs.SetTitle();

            //右パネルを非表示
            this.splitContainerLR.Panel2Collapsed = true;

            //左上パネルを表示
            this.splitContainerLeftUD.Panel1Collapsed = false;

            //C#の「戻る/ヘルプ/閉じる」パネルを左上パネルに移動
            this.splitContainerRightUD.Panel1.Controls.Remove(this.panelBHC);
            this.splitContainerLeftUD.Panel1.Controls.Add(this.panelBHC);
            this.panelBHC.Location = new System.Drawing.Point(
                this.splitContainerLeftUD.Panel1.Width - this.panelBHC.Width,
                this.panelBHC.Location.Y);

            //戻るボタンの非表示・表示
            if (fimeneme == "topMenu.html")
            {
                //戻るボタンの非表示
                this.buttonBack.Visible = false;
            }
            else 
            {
                //戻るボタンの表示
                this.buttonBack.Visible = true;
            }

            //固有処理
            switch (fimeneme)
            {
                case "topMenu.html":
                    break;
                case "patternA.html":
                    this.csToJs.OperatePatternA();
                    break;
                default:
                    break;
            }

            //コントロールのレイアウトを再開
            this.ResumeLayout(false);
        }

        //ウィンドウ構成B 半画面html
        private void TransformB(string fimeneme)
        {
            //コントロールのレイアウトを一時中断
            this.SuspendLayout();

            //htmlの閉じるボタンを削除
            this.csToJs.RemoveCloseBtn();

            //タイトルを設定
            this.csToJs.SetTitle();

            //右パネルを表示
            this.splitContainerLR.Panel2Collapsed = false;

            //左上パネルを非表示
            this.splitContainerLeftUD.Panel1Collapsed = true;

            //C#の「戻る/ヘルプ/閉じる」パネルを右上パネルに移動
            this.splitContainerLeftUD.Panel1.Controls.Remove(this.panelBHC);
            this.splitContainerRightUD.Panel1.Controls.Add(this.panelBHC);
            this.panelBHC.Location = new System.Drawing.Point(
                this.splitContainerRightUD.Panel1.Width - this.panelBHC.Width,
                this.panelBHC.Location.Y);

            //戻るボタンの表示
            this.buttonBack.Visible = true;

            //スプリッターの位置を設定
            this.splitContainerLR.SplitterDistance = (int)(this.splitContainerLR.Width * 65 / 100);

            //固有処理
            switch (fimeneme)
            {
                case "patternB.html":
                    csToJs.OperatePatternB();
                    break;
                default:
                    break;
            }

            //コントロールのレイアウトを再開
            this.ResumeLayout(false);
        }

        //イベント 詳細へボタン
        private void buttonGoDetail_Click(object sender, EventArgs e)
        {
            csToJs.buttonClickGoDetail();
        }
    }
}