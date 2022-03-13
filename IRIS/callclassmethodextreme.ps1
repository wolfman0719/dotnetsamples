Add-Type -Path 'C:\InterSystems\IRIS\dev\dotnet\bin\v4.5\InterSystems.Data.XEP.dll'

$ep = [InterSystems.XEP.PersisterFactory]::CreatePersister()


$ep.Connect("localhost", 1972, "USER", "_SYSTEM", "SYS")


$ep.CallClassMethod("%SYSTEM.Version","GetVersion")
