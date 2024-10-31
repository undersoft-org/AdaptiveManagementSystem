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

Set-Location "$location/src/AMS.Document/src/AMS.Document.Service.Server"
Invoke-Expression "dotnet publish --os linux --arch x64 -p ContainerImageTag=$env:DOCKERTAG /t:PublishContainer"

Set-Location "$location/src/AMS.Document/src/AMS.Document.Service.Server.Commercial"
Invoke-Expression "dotnet publish --os linux --arch x64 -p ContainerImageTag=$env:DOCKERTAG /t:PublishContainer"

Set-Location "$location/src/AMS.Document/src/AMS.Document.Service.Server.Financial"
Invoke-Expression "dotnet publish --os linux --arch x64 -p ContainerImageTag=$env:DOCKERTAG /t:PublishContainer"

Set-Location "$location/src/AMS.Document/src/AMS.Document.Service.Server.Legal"
Invoke-Expression "dotnet publish --os linux --arch x64 -p ContainerImageTag=$env:DOCKERTAG /t:PublishContainer"

Set-Location "$location/src/AMS.Document/src/AMS.Document.Service.Server.Logistical"
Invoke-Expression "dotnet publish --os linux --arch x64 -p ContainerImageTag=$env:DOCKERTAG /t:PublishContainer"

Set-Location "$location/src/AMS.Document/src/AMS.Document.Service.Server.Productional"
Invoke-Expression "dotnet publish --os linux --arch x64 -p ContainerImageTag=$env:DOCKERTAG /t:PublishContainer"