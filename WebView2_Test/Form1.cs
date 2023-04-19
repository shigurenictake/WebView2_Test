using Microsoft.Web.WebView2.Core;//WebView2
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SharpMap;//SharpMap
using SharpMap.Layers;//SharpMap
using SharpMap.Data.Providers;//SharpMap
using GeoAPI.Geometries;//SharpMap
using System.Drawing;//SharpMap
using SharpMap.Forms;//SharpMap
using SharpMap.Forms.ToolBar;//SharpMap
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace WebView2_Test
{
    public partial class Form1 : Form
    {
        //JavaScriptで呼ぶ関数を保持するオブジェクト
        private JsToCs CsClass = new JsToCs();

        //コンストラクタ
        public Form1()
        {
            //JsToCsクラスでForm1のフォーム取得参照用
            CsClass.form1 = this;

            InitializeComponent();

            //URLを設定
            this.textBox_UrlBar.Text = System.IO.Path.GetFullPath(@"..\\..\\html\\sample.html");
            this.webView.Source = new Uri(this.textBox_UrlBar.Text);

            //WebView2のロード完了時のイベント
            webView.NavigationCompleted += WebView_NavigationCompleted;

            //======================
            //SharpMap
            //参考
            //http://blog.livedoor.jp/kuro_program/archives/7235669.html

            mapBox1.Map = new Map(new Size(mapBox1.Width, mapBox1.Height));
            mapBox1.Map.BackColor = Color.Blue;

            //レイヤーの作成
            VectorLayer baseLayer = new VectorLayer("Countries");
            //baseLayer.DataSource = new ShapeFile(@"..\..\ShapeFiles\polbnda_jpn\polbnda_jpn.shp");
            baseLayer.DataSource = new ShapeFile(@"..\..\ShapeFiles\ne_10m_coastline\ne_10m_coastline.shp",true);

            baseLayer.Style.Fill = Brushes.LimeGreen;
            baseLayer.Style.Outline = Pens.Black;
            baseLayer.Style.EnableOutline = true;

            //マップにレイヤーを追加
            mapBox1.Map.Layers.Add(baseLayer);


            //線と点を書く start -------
            VectorLayer orgLayer = new VectorLayer("子午線");
            GeometryFactory gf = new GeometryFactory();
            List<IGeometry> eomColl = new List<IGeometry>();

            //線を書く
            Coordinate[] linePos = { new Coordinate(135, 30), new Coordinate(135, 37) };
            eomColl.Add(gf.CreateLineString(linePos));

            //点を書く
            eomColl.Add(gf.CreatePoint(new Coordinate(135, 35)));

            GeometryProvider vpro = new GeometryProvider(eomColl);
            orgLayer.DataSource = vpro;

            mapBox1.Map.Layers.Add(orgLayer);
            //線と点を書く end -------


            //Zoom制限
            mapBox1.Map.MinimumZoom = 0.1;
            mapBox1.Map.MaximumZoom = 360.0;

            mapBox1.Map.ZoomToExtents();
            mapBox1.Refresh();
            //======================

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //WebView2のロード完了時
        private void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            try
            {
                if (webView.CoreWebView2 != null)
                {
                    //JavaScriptからC#のメソッドが実行できる様に仕込む
                    webView.CoreWebView2.AddHostObjectToScript("CsClass", CsClass);
                }
                else MessageBox.Show("CoreWebView2==null");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //イベント - URL変更
        private void textBox_UrlBar_TextChanged(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(this.textBox_UrlBar.Text);
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

    }

    /// <summary>WebView2に読み込ませるためのJsで実行する関数を保持させたクラス</summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    public class JsToCs
    {
        public Form1 form1;

        //Jsからの呼び出し
        public void JsToCsMethod(string strText)
        {
            form1.richTextBox_JsToCs.AppendText(strText + "\n");
        }
    }
}