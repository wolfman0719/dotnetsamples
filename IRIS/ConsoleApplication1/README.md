# samples.csprojファイル修正

環境依存の部分を修正

以下のライブラリのディレクトリ名を環境に合わせて修正する

```
<Reference Include="InterSystems.Data.Utils">
<HintPath>\opt\iris\dev\dotnet\bin\net8.0\InterSystems.Data.Utils.dll</HintPath>
</Reference>
<Reference Include="InterSystems.Data.IRISClient">
<HintPath>\opt\iris\dev\dotnet\bin\net8.0\InterSystems.Data.IRISClient.dll</HintPath>
</Reference>
```
