# 初期設定

## 必要なクラスのロード

dirとdelimは環境に合わせて調整する

```
>set dir = "c:¥git¥dotnetsamples"
>set delim = "¥"
>do $system.OBJ.Import(dir_delim_"REST"_delim_"Broker.cls","ck")
>do $system.OBJ.Import(dir_delim_"REST"_delim_"JSON.cls","ck")
>do $system.OBJ.Import(dir_delim_"MyApp"_delim_"Person2.cls","ck")
>do $system.OBJ.Import(dir_delim_"User"_delim_"Fax.cls","ck")
```

## API設定

restsetup.pngと同じように設定する
