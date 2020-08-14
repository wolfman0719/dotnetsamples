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


ツール>ライブラリーパッケージマネージャー>パッケージマネージャーコンソール

以下を実行

PM> Install-Package JsonValue -Version 0.6.0


sendJSON.csをコンパイル、実行

ソース上は

userネームスペース

　
となっているので、実行環境に合わせてこの指定を変更