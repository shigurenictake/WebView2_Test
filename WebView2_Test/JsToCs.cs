using System.IO;

namespace WebView2_Test
{
    /// <summary>WebView2に読み込ませるためのJsで実行する関数を保持させたクラス</summary>
    //[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [System.Runtime.InteropServices.ComVisible(true)]
    public class JsToCs
    {
        //Formのメンバ取得用(初期化はForm側で行う)
        public MainForm mainform = null;
        public SubFormB subformb = null;

        //C#_WebViewチェック
        public string CheckCsharpWebView()
        {
            return "CsharpWebView_OK";
        }

        //Jsからの呼び出し
        public void JsToCsMethod(string strText)
        {
            if (mainform != null)
            {
                mainform.richTextBox_JsToCs.AppendText(strText + "\n");
            }
            if (subformb != null)
            {
                subformb.richTextBox_JsToCs.AppendText(strText + "\n");
            }
        }

        //htmlを新しいウィンドウで開く
        public void WindowOpen(string url)
        {
            string fimeneme = System.IO.Path.GetFileName(url);

            switch (fimeneme)
            {
                case "subPatternA.html":
                    (new SubFormGenerator()).CreateSubForm(fimeneme, url);
                    break;
                case "subPatternB.html":
                    (new SubFormGenerator()).CreateSubForm(fimeneme, url);
                    break;
                default:
                    break;
            }
        }

        //ウィンドウを閉じる
        public void WindowClose(string formname)
        {
            switch (formname)
            {
                case "subPatternA.html":
                    (new SubFormGenerator()).CloseForm(formname);
                    break;
                case "subPatternB.html":
                    (new SubFormGenerator()).CloseForm(formname);
                    break;
                default:
                    break;
            }
        }
    }
}
