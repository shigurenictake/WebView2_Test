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

        //イベント スプリッターの移動完了時
        private void splitContainerLR_SplitterMoved(object sender, SplitterEventArgs e)
        {
            //連動スクロール用右上パネル(連動パネル)の位置を調整
            AdjustPanelRUForLinkScroll();
        }

        //イベント 右上パネルのサイズ変更時
        private void splitContainerRightUD_Panel1_SizeChanged(object sender, EventArgs e)
        {
            //連動スクロール用右上パネル(連動パネル)の位置を調整
            AdjustPanelRUForLinkScroll();
        }

        //連動スクロール用右上パネル(連動パネル)の幅と位置を調整
        private void AdjustPanelRUForLinkScroll()
        {
            //右下パネルのスクロールバー出現しているか判定
            if (splitContainerRightUD.Panel2.HorizontalScroll.Visible == true)
            {
                //幅を右下パネルの最小幅に固定
                this.panelRUForLinkScroll.Size = new System.Drawing.Size(
                    splitContainerRightUD.Panel2.AutoScrollMinSize.Width,
                    this.panelRUForLinkScroll.Size.Height);

                //位置を右下パネルのスクロール位置に連動
                this.panelRUForLinkScroll.Left = this.splitContainerRightUD.Panel2.AutoScrollPosition.X;
            }
            else
            {
                //幅を右上パネルの幅に更新
                this.panelRUForLinkScroll.Size = new System.Drawing.Size(
                    splitContainerRightUD.Panel1.Width,
                    this.panelRUForLinkScroll.Size.Height);

                //左端の座標を0に合わせる
                this.panelRUForLinkScroll.Left = 0;
            }
        }

        //イベント ユーザーが右下パネルをスクロールした時
        private void splitContainerRightUD_Panel2_Scroll(object sender, ScrollEventArgs e)
        {
            //水平スクロールか判定
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                //右上パネルのスクロール位置を右下パネルのスクロール位置に連動
                this.panelRUForLinkScroll.Left = -e.NewValue;
            }
        }
    }
}