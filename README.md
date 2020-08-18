# IRIS .NET インターフェースサンプル

IRISに用意されている.NETの様々なインタフェースの使用方法を示すサンプルです。
ほとんどのものは、Cachéで動作していたものをIRIS用に書き直したものです。

# ディレクトリ構成

## README.MD

このファイルです。

## LICENSE

MIT Licenseに準拠してることを示す文書です。

## User

バイナリー処理のサンプルに必要なIRISクラス定義

- User.Fax.cls

## REST

RESTサンプルで使用するIRISクラス定義

- REST.Broker.cls
- REST.JSON.cls

## MyApp

- MyApp.Person2.cls

## restsetup.png

RESTインタフェースを動作させるために必要な管理ポータルの設定を示す図

## Cache

Caché用のオリジナルファイル

最新版のCachéで動作確認できていません。

## IRIS

IRIS用に書き換えたもの

IRIS　2020.2で動作確認しています。

IRIS　2020.3以降デフォルト・スーパーポート番号が51773から1972に変更されているため、そのポート番号を書き換える必要があります。

### callclassmethod.ps1

Powershellから.NET Native APIを使用してクラスメソッドを呼び出すサンプル

### callclassmethodextreme.ps1

PowerShellから.NETのXEPインタフェースを使ってクラスメソッドを呼び出すサンプル

### classload.ps1

Powershellから.Net Native APIを使用してクラス定義をロードするサンプル

### classloadextreme.ps1

Powershellから.NET XEPインタフェースを使用してクラス定義をロードするサンプル

### load.xml

クラス定義をロードするサンプルで使用するクラス定義のXMLファイル

### ConsoleApplication1

.NET Native APIを使用してクラスメソッドを呼び出すサンプル

### ConsoleApplication3

.NET XEP APIを使用してクラスメソッドを呼び出すサンプル

### insertbinary

ADO.NETのIRISインタフェースを使用してバイナリファイルを読み込むサンプル

#### 前提条件

　c:\temp\test.jpgというファイルがある前提

### VBIMage

.NET Native APIを使用してバイナリーファイルの読み書きを行うサンプル

#### 前提条件

　c:\temp\test.jpgというファイルがある前提

#### 参照設定

InterSystems.Data.CacheClient

#### 実行方法

- Upload!ボタンをクリック

- Display!ボタンをクリック

### REST

REST/JSONを使用したサンプル

#### ParseJSON

IRISサーバーからJSONデータを取得するサンプル

#### SendJSON

IRISサーバーにJSONデータを送信するサンプル

##### 必要な参照設定

System.Json;
InterSystems.XEP;


##### NuGetパッケージのインストール

- ツール>NuGetパッケージマネージャー>パッケージマネージャーコンソール

- 以下を実行

- PM> Install-Package JsonValue -Version 0.6.0

