using System.Runtime.InteropServices;

namespace WebView2_Test
{
    /// <summary>WebView2に読み込ませるためのJsで実行する関数を保持させたクラス</summary>
    //[ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    public class JsToCs
    {
        //Form1のメンバ取得用
        public Form1 form1;

        //Jsからの呼び出し
        public void JsToCsMethod(string strText)
        {
            form1.richTextBox_JsToCs.AppendText(strText + "\n");
        }

        //サブフォーム
        public Form1 subform1 = null;

        //htmlを新しいウィンドウで開く
        public void WindowOpenNewForm(string url)
        {
            //二重起動防止
            if (this.subform1 == null || this.subform1.IsDisposed)
            {
                //ヌル、または破棄されていたら、新しいウィンドウで起動する
                this.subform1 = new Form1(url);
                subform1.Show();
            }

            //フォームにフォーカスを当てる。
            if (!this.subform1.Visible)
            {
                this.subform1.Show();
            }
            else
            {
                this.subform1.Activate();
            }
        }
    }
}
