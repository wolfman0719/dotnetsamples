# 事前準備

## port番号調整

HTTPアクセスのポート番号は、環境に合わせて調整する。

```
// URLエンコーディング
string url = "http://localhost:52773/api/dotnetrest/getcolors";
```

## ライブラリのディレクトリ

環境依存なので環境に合わせてpareseJson.csprojの`<HintPath>`の値を修正する
