using System.Windows.Forms;

namespace WebView2_Test
{
    internal class SubFormController
    {
        //サブフォーム生成 Form1用
        public void CreateSubForm1(string formname, string path)
        {
            //指定した名前のフォームがあれば取得する
            Form subform = this.GetFormByName(formname);

            //二重起動防止
            if (subform == null || subform.IsDisposed)
            {
                //ヌル、または破棄されていたら、新しいウィンドウで起動する
                subform = new Form1(path);
                subform.Show();
                //フォーム名を設定
                subform.Name = formname;
            }
            //フォームにフォーカスを当てる。
            if (!subform.Visible)
            {
                subform.Show();
            }
            else
            {
                subform.Activate();
            }
        }

        //指定した名前のFormオブジェクトがあれば閉じる
        public void CloseForm(string formname)
        {
            //指定した名前のフォームがあれば取得する
            Form form = this.GetFormByName(formname);

            //subformがあれば削除する
            if (form != null)
            {
                form.Close();
            }
        }

        //指定した名前のFormオブジェクトがあれば取得する
        public Form GetFormByName(string formname)
        {
            Form retform = null;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == formname)
                {
                    retform = (Form)form;
                    break;
                }
            }
            return retform;
        }
    }
}
