バイナリーデータをVB.Netでロード＆表示するサンプル

1.　動作環境　

　Cache　2014.1以降

2.　前提事項

　c:\temp\test.jpgというファイルがある前提

3.　必要な参照設定

InterSystems.Data.CacheClient


4. 実行手順

4.1 User.Fax.xmlをuserネームスペースにインポート


4.2 CacheNetWizard.exeを使って.netのプロキシクラスを生成
（fax.vb）

4.3 マイクロソフトビジュアルスタジオでVBimage.slnを開く

4.4 4.2で生成したファイルをプロジェクトに追加（含まれていない場合）

4.5　ビルド(B)>ソリューションのビルド（B）をクリック

4.6　デバッグ(D)>デバッグなしで開始(H)をクリック

4.7  Upload!ボタンをクリック

4.8　Display!ボタンをクリック

