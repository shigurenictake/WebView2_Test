using System.Windows.Forms;

namespace WebView2_Test
{
    internal class SubFormController
    {
        //サブフォーム生成 Form1用
        public void CreateSubForm1(string formname, string path)
        {
            //指定した名前のフォームがあれば取得する
            Form1 subform1 = this.GetForm1ByName(formname);

            //二重起動防止
            if (subform1 == null || subform1.IsDisposed)
            {
                //ヌル、または破棄されていたら、新しいウィンドウで起動する
                subform1 = new Form1(path);
                subform1.Show();
                //フォーム名を設定
                subform1.Name = formname;
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

        //サブフォームを閉じる Form1用
        public void CloseSubForm1(string formname)
        {
            //指定した名前のフォームがあれば取得する
            Form1 subform1 = this.GetForm1ByName(formname);

            //subform1があれば削除する
            if (subform1 != null)
            {
                subform1.Close();
            }
        }

        //指定した名前のForm1オブジェクトがあれば取得する Form1用
        public Form1 GetForm1ByName(string formname)
        {
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
