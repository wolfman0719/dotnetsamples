Add-Type -Path 'C:\InterSystems\IRIS\dev\dotnet\bin\v4.5\InterSystems.Data.XEP.dll'

$ep = [InterSystems.XEP.PersisterFactory]::CreatePersister()


$ep.Connect("localhost", 51773, "USER", "_SYSTEM", "SYS")


$ep.CallClassMethod("%SYSTEM.OBJ","Load","c:\temp\load.xml","ck-d")