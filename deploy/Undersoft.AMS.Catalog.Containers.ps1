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

Set-Location "$location/src/AMS.Catalog/src/AMS.Catalog.Service.Server"
Invoke-Expression "dotnet publish --os linux --arch x64 -p ContainerImageTag=$env:DOCKERTAG /t:PublishContainer"

Set-Location "$location/src/AMS.Catalog/src/AMS.Catalog.Service.Server.Participants"
Invoke-Expression "dotnet publish --os linux --arch x64 -p ContainerImageTag=$env:DOCKERTAG /t:PublishContainer"

Set-Location "$location/src/AMS.Catalog/src/AMS.Catalog.Service.Server.Resources"
Invoke-Expression "dotnet publish --os linux --arch x64 -p ContainerImageTag=$env:DOCKERTAG /t:PublishContainer"

Set-Location "$location/src/AMS.Catalog/src/AMS.Catalog.Service.Server.Subjects"
Invoke-Expression "dotnet publish --os linux --arch x64 -p ContainerImageTag=$env:DOCKERTAG /t:PublishContainer"