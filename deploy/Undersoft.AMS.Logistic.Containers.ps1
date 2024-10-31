cd..
$location = Get-Location
if($env:DOCKERUSER -eq $null)
{
    ECHO "Username:"
    $env:DOCKERUSER = Read-Host
    ECHO "Token"
    $env:DOCKERTOKEN = Read-Host

    Invoke-Expression "docker login -u $env:DOCKERUSER -p $env:DOCKERTOKEN"
}

if($env:DOCKERTAG -eq $null)
{
    ECHO "Tag"
    $env:DOCKERTAG = Read-Host
}

Set-Location "$location/src/AMS.Logistic/src/AMS.Logistic.Service.Server"
Invoke-Expression "dotnet publish --os linux --arch x64 -p ContainerImageTag=$env:DOCKERTAG /t:PublishContainer"

Set-Location "$location/src/AMS.Logistic/src/AMS.Logistic.Service.Server.Inventory"
Invoke-Expression "dotnet publish --os linux --arch x64 -p ContainerImageTag=$env:DOCKERTAG /t:PublishContainer"

Set-Location "$location/src/AMS.Logistic/src/AMS.Logistic.Service.Server.Shipments"
Invoke-Expression "dotnet publish --os linux --arch x64 -p ContainerImageTag=$env:DOCKERTAG /t:PublishContainer"

Set-Location "$location/src/AMS.Logistic/src/AMS.Logistic.Service.Server.Receptions"
Invoke-Expression "dotnet publish --os linux --arch x64 -p ContainerImageTag=$env:DOCKERTAG /t:PublishContainer"