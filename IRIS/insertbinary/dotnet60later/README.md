# .NET 6.0以降で動作するプロジェクト

## samples.csproj

IRIS関連ライブラリの場所は、環境依存なので、環境に合わせて修正する

```
<ItemGroup>
<Reference Include="InterSystems.Data.Utils">
<HintPath>\opt\iris\dev\dotnet\bin\net8.0\InterSystems.Data.Utils.dll</HintPath>
</Reference>
<Reference Include="InterSystems.Data.IRISClient">
<HintPath>\opt\iris\dev\dotnet\bin\net8.0\InterSystems.Data.IRISClient.dll</HintPath>
</Reference>
</ItemGroup>
```
