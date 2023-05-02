using System.IO;

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
        public void WindowOpen(string formname, string path)
        {
            switch (formname)
            {
                case "subform1":
                    //Form1で新しいサブフォームを生成
                    (new SubFormController()).CreateSubForm1(formname, path);
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
                case "subform1":
                    (new SubFormController()).CloseSubForm1(formname);
                    break;
                default:
                    break;
            }
        }
    }
}
