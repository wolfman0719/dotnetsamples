PowerShellを使ってルーチン、クラス等をロードする

シェルやコマンドスクリプトを経由してCachéを呼び出す場合、エラーステータスの引き渡しなどが難しい。

PowerShell経由でCachéを呼び出すと戻り値などの引き渡しが簡単にできる。

1.　PowerShellを管理者権限付きで起動する

2.　PowerShellのコマンドプロンプトから以下を実行する

PS>Set-ExecutionPolicy RemoteSigned

3.　load.xmlを適当なネームスペースにロードする

4.　test.xmlを適当なディレクトリに置く

5.　classloadxreme.ps1の内容を確認

最初の行が実際のファイルの場所と一致するように修正する。

Add-Type -Path 'C:\InterSystems\Cache\dev\dotnet\bin\v2.0.50727\InterSystems.CacheExtreme.dll'

ネームスペース、ユーザー名、パスワードの調整

以下の行が実際のネームスペース、ユーザー名、パスワードと一致するように調整する。

$ep.Connect("USER","_SYSTEM","SYS")

最後の行のファイルの場所が実際のファイルの置き場所と一致するように変更する。

$ep.CallClassMethod("User.LoadHelper","Load","c:\temp\test.xml","ck")

6. classloadextreme.ps1を実行

7.　test.xmlの中のコードを変更してわざとコンパイルエラーを起こすようにファイルを変更

8.　再度classloadextreme.ps1を実行

エラーが出力されることを確認
