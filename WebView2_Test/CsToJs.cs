using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebView2_Test
{
    internal class CsToJs
    {
        //参照元クラスのWebView2取得用(初期化は参照元クラスで行う)
        public Microsoft.Web.WebView2.WinForms.WebView2 webView;

        //JavaScript実行要求
        public async void RemoveCloseBtn()
        {
            System.Text.StringBuilder js = new System.Text.StringBuilder();
            js.AppendLine("console.log('RemoveCloseBtn start');");
            js.AppendLine("var element = document.getElementById('btn-close');");
            js.AppendLine("element.parentNode.remove();");//親要素と一緒に削除
            js.AppendLine("console.log('RemoveCloseBtn end');");
            await webView.ExecuteScriptAsync(js.ToString());
        }


    }
}
