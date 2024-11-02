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

Invoke-Expression "docker build -t uscr/amsdatacluster:$env:DOCKERTAG -f Undersoft.AMS.Data.Cluster.Dockerfile ."

Invoke-Expression "docker push uscr/amsdatacluster:$env:DOCKERTAG"