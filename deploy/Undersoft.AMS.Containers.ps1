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

Set-Location "$location/src/AMS/src/AMS.Service.Application.Server"
Invoke-Expression "dotnet publish --os linux --arch x64 -p ContainerImageTag=$env:DOCKERTAG /t:PublishContainer -c Release"

Set-Location "$location/src/AMS/src/AMS.Service.Server"
Invoke-Expression "dotnet publish --os linux --arch x64 -p ContainerImageTag=$env:DOCKERTAG /t:PublishContainer -c Release"