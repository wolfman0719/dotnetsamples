# IRIS .NET インターフェースサンプル

IRISに用意されている.NETの様々なインタフェースの使用方法を示すサンプルです。

ほとんどのものは、Cachéで動作していたものをIRIS用に書き直したものです。

# ディレクトリ構成

## README.md

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

insertbinaryサンプルで使用するクラス定義

- MyApp.Person2.cls

## restsetup.png

RESTインタフェースを動作させるために必要な管理ポータルの設定を示す図

## Cache

Caché用のオリジナルファイル

最新版のCachéで動作確認できていません。

## IRIS

IRIS用に書き換えたもの

IRIS　2025.2で動作確認しています。

### callclassmethod.ps1

Powershellから.NET Native APIを使用してクラスメソッドを呼び出すサンプル

Powershellで動かす前に以下のポリシー設定が必要

 `Set-ExecutionPolicy -ExecutionPolicy Bypass -Scope Process`

### classload.ps1

Powershellから.Net Native APIを使用してクラス定義をロードするサンプル


### load.xml

クラス定義をロードするサンプルで使用するクラス定義のXMLファイル

c:¥temp¥load.xmlにファイルを置くという前提でプログラムは記述されているので、環境によって変更する必要がある

### ConsoleApplication1

.NET Native APIを使用してクラスメソッドを呼び出すサンプル

### insertbinary

ADO.NETのIRISインタフェースを使用してバイナリファイルを読み込むサンプル

#### 前提条件

　c:\temp\test.jpgというファイルがある前提

### VBImage

.NET Native APIを使用してバイナリーファイルの読み書きを行うサンプル

#### 前提条件

　c:\temp\test.jpgというファイルがある前提

#### 実行方法

- Upload!ボタンをクリック

- Display!ボタンをクリック

### VBImageADO

ADO.Netを使用してバイナリーファイルの読み書きを行うサンプル

#### 前提条件

　c:\temp\test.jpgというファイルがある前提

#### 実行方法

- Upload!ボタンをクリック

- Display!ボタンをクリック

### REST

REST/JSONを使用したサンプル

#### ParseJSON

IRISサーバーからJSONデータを取得するサンプル

#### SendJSON

IRISサーバーにJSONデータを送信するサンプル









