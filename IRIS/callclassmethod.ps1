Add-Type -Path 'C:\InterSystems\IRIS\dev\dotnet\bin\v4.5\InterSystems.Data.IRISClient.dll'

$cc = New-Object InterSystems.Data.IRISClient.IRISConnection("localhost",1972,"USER","_SYSTEM","SYS")

$cc.Open()

$iris = [InterSystems.Data.IRISClient.ADO.IRIS]::CreateIRIS($cc)

$ReturnValue = $iris.ClassMethodString("%SYSTEM.Version","GetVersion")

$ReturnValue
