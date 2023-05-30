/* 共通処理 */

//C#_WebView判定フラグ
var isCsharpWebView = Boolean(0); //false 初期化

//load イベント
window.onload = function(){
    //C#_WebView判定フラグを設定
    setIsisCsharpWebView();
}

//C#_WebView判定フラグを設定
async function setIsCsharpWebView(){
    var strIsCsharpWebView="";//初期化
    try{
        strIsCsharpWebView = chrome.webview.hostObjects.jsToCs.CheckCsharpWebView();
    }catch(error){
        strIsCsharpWebView="";
    }finally{
        if(strIsCsharpWebView=="CsharpWebView_OK"){
            isCsharpWebView = Boolean(1); //true
        }else{
            isCsharpWebView = Boolean(0); //false
        }
    }
}

//C#からJavaScriptを呼び出す
function jsFunc1(str1) {
    //タグを生成
    const tag = document.createElement("div");
    tag.innerText = str1;
    //未完了のリストに追加
    document.getElementById("CsToJs").appendChild(tag);
    return "success"
}

//JavaScriptからC#を呼び出す
function ButtonClick_JsToCs() {
    //テキストボックスから値取得
    const sendtext = document.getElementById('sendtext');
    //C#の関数の実行
    chrome.webview.hostObjects.jsToCs.JsToCsMethod(sendtext.value);
}

//htmlからウィンドウを閉じる
function closeWindow() {
    window.close();
}

//htmlからサブウィンドウを開く
function openNewWindowHtml(id) {
    let path="";
    switch(id){
        case "btn-html-new-win-a" :
            path = "./subPatternA.html";
            break;
        case "btn-html-new-win-b" :
            path = "./subpatternB.html";
            break;
        default : 
    }
    window.open(path, "_blank", "width=800,height=300");
}

//C#からサブウィンドウを開く
function openNewWindowByCs(id) {
    // 現在のURLの情報を取得する
    const currentUrl = new URL(window.location.href);
    // 相対パスをフルパスに変換する
    let relativePath="";
    switch(id){
        case "btn-cs-new-win-a" :
            relativePath = "./subPatternA.html";
            break;
        case "btn-cs-new-win-b" :
            relativePath = "./subPatternB.html";
            break;
        default : 
    }
    const fullPath = new URL(relativePath, currentUrl).href;
    console.log(fullPath);
    //C#の関数の実行。htmlを新しいフォームで開く
    chrome.webview.hostObjects.jsToCs.WindowOpen(fullPath);
}

//htmlでURL切り替え
function windowOpenSelf(id) {
    let path="";
    switch(id){
        case "btn-self-win-a" :
            path = "./patternA.html";
            break;
        case "btn-self-win-b" :
            path = "./patternB.html";
            break;
        default : 
    }
    window.open(path, "_self");
}
