# IRIS .Net Interfaces samples 

Here's samples that shows how to use the various .Net interfaces provided in IRIS.
Most of them were originally written for Cache and modified to work with IRIS.


JSON形式のデータを.NetとCaché間で交換するサンプル(.NETからCachéへJSONデータを送る)

1.　動作環境　

　Caché　2014.1以降

2.　前提事項

　以前公開したJSON&jqueryのサンプルがインストールおよびセットアップされてること

3.　必要な参照設定

System.Json;
InterSystems.XEP;



4. 実行手順


sendjson.xmlをインポート


ツール>NuGetパッケージマネージャー>パッケージマネージャーコンソール

以下を実行

PM> Install-Package JsonValue -Version 0.6.0


sendJSON.csをコンパイル、実行

ソース上は

userネームスペース

　
となっているので、実行環境に合わせてこの指定を変更

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