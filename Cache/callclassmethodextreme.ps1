Add-Type -Path 'C:\InterSystems\Ensemble\dev\dotnet\bin\v2.0.50727\InterSystems.CacheExtreme.dll'

$ep = [InterSystems.XEP.PersisterFactory]::CreatePersister()


$ep.Connect("USER","_SYSTEM","SYS")


$ep.CallClassMethod("%SYSTEM.Version","GetVersion")