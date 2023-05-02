namespace WebView2_Test
{
    /// <summary>WebView2に読み込ませるためのJsで実行する関数を保持させたクラス</summary>
    //[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [System.Runtime.InteropServices.ComVisible(true)]
    public class JsToCs
    {
        //Form1のメンバ取得用
        public Form1 form1;

        //Jsからの呼び出し
        public void JsToCsMethod(string strText)
        {
            form1.richTextBox_JsToCs.AppendText(strText + "\n");
        }

        //htmlを新しいウィンドウで開く
        public void WindowOpen(string url)
        {
            //Form1で新しいサブフォームを生成
            (new SubFormController()).CreateSubForm1(url);
        }

        //ウィンドウを閉じる
        public void WindowClose()
        {
            (new SubFormController()).CloseSubForm1();
        }
    }
}
