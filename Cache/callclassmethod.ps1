Add-Type -Path 'C:\InterSystems\Ensemble\dev\dotnet\bin\v4.0.30319\InterSystems.Data.CacheClient.dll'

$cc = New-Object InterSystems.Data.CacheClient.CacheConnection("localhost",1972,"USER","_SYSTEM","SYS")

$cc.Open()

$ms = New-Object InterSystems.Data.CacheTypes.CacheMethodSignature

$ms.Clear()

$ms.SetReturnType($cc,[InterSystems.Data.CacheTypes.ClientTypeId]::tString)

[InterSystems.Data.CacheTypes.CacheObject]::RunClassMethod($cc,"%SYSTEM.Version","GetVersion",$ms)

$ms.ReturnValue._Value
