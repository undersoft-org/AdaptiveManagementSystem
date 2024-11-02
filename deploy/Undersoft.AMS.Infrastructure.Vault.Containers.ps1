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

Invoke-Expression "docker build -t uscr/amssecretvault:$env:DOCKERTAG -f Undersoft.AMS.Secret.Vault.Dockerfile ."

Invoke-Expression "docker push uscr/amssecretvault:$env:DOCKERTAG"