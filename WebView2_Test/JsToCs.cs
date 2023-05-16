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
        public SubForm subform = null;

        //Jsからの呼び出し
        public void JsToCsMethod(string strText)
        {
            if (mainform != null)
            {
                mainform.richTextBox_JsToCs.AppendText(strText + "\n");
            }
            if (subform != null)
            {
                subform.richTextBox_JsToCs.AppendText(strText + "\n");
            }
        }

        //htmlを新しいウィンドウで開く
        public void WindowOpen(string url)
        {
            string fimeneme = System.IO.Path.GetFileName(url);

            switch (fimeneme)
            {
                case "subPatternA.html":
                    (new SubFormController()).CreateSubForm(fimeneme, url);
                    break;
                case "subpatternB.html":
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
                    (new SubFormController()).CloseForm(formname);
                    break;
                case "subpatternB.html":
                    break;
                default:
                    break;
            }
        }
    }
}
