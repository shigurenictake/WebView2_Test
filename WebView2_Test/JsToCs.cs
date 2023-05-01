using System;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Windows.Forms;

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

        //htmlを新しいウィンドウで開く
        public void WindowOpen(string url)
        {
            //Form1で新しいサブフォームを生成
            SubFormCreate(url);
        }

        //ウィンドウを閉じる
        public void WindowClose()
        {
            SubFormClose();
        }

        //サブフォーム生成
        public void SubFormCreate(string url)
        {
            //subform1があれば取得する
            Form1 subform1 = this.GetForm1ByName("subform1");

            //二重起動防止
            if (subform1 == null || subform1.IsDisposed)
            {
                //ヌル、または破棄されていたら、新しいウィンドウで起動する
                subform1 = new Form1(url);
                subform1.Show();
                //フォーム名を設定
                subform1.Name = "subform1";
            }
            //フォームにフォーカスを当てる。
            if (!subform1.Visible)
            {
                subform1.Show();
            }
            else
            {
                subform1.Activate();
            }
        }

        //サブフォームを閉じる
        public void SubFormClose()
        {
            //subform1があれば取得する
            Form1 subform1 = this.GetForm1ByName("subform1");

            //subform1があれば削除する
            if (subform1 != null)
            {
                subform1.Close();
            }
        }

        //指定した名前のForm1があれば取得する
        public Form1 GetForm1ByName(string formname) {
            Form1 subform1 = null;
            //Console.WriteLine(Application.OpenForms.Count);
            foreach (Form form in Application.OpenForms)
            {
                //Console.WriteLine($"{form.Text}" + "," + $"{form.Name}");
                if (form.Name == formname)
                {
                    subform1 = (Form1)form;
                    break;
                }
            }
            return subform1;
        }

    }
}
