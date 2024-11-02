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

Invoke-Expression "docker build -t uscr/amsdataserver:$env:DOCKERTAG -f Undersoft.AMS.Data.Server.Dockerfile ."
Invoke-Expression "docker build -t uscr/amsdatacluster:$env:DOCKERTAG -f Undersoft.AMS.Data.Cluster.Dockerfile ."
Invoke-Expression "docker build -t uscr/amsmessagebroker:$env:DOCKERTAG -f Undersoft.AMS.Message.Broker.Dockerfile ."
Invoke-Expression "docker build -t uscr/amsmetricsserver:$env:DOCKERTAG -f Undersoft.AMS.Metrics.Server.Dockerfile ."
Invoke-Expression "docker build -t uscr/amstracingserver:$env:DOCKERTAG -f Undersoft.AMS.Tracing.Server.Dockerfile ."
Invoke-Expression "docker build -t uscr/amstelemetrygraphs:$env:DOCKERTAG -f Undersoft.AMS.Telemetry.Graphs.Dockerfile ."
Invoke-Expression "docker build -t uscr/amssecretvault:$env:DOCKERTAG -f Undersoft.AMS.Secret.Vault.Dockerfile ."

Invoke-Expression "docker push uscr/amsdataserver:$env:DOCKERTAG"
Invoke-Expression "docker push uscr/amsdatacluster:$env:DOCKERTAG"
Invoke-Expression "docker push uscr/amsmessagebroker:$env:DOCKERTAG"
Invoke-Expression "docker push uscr/amsmetricsserver:$env:DOCKERTAG"
Invoke-Expression "docker push uscr/amstracingserver:$env:DOCKERTAG"
Invoke-Expression "docker push uscr/amstelemetrygraphs:$env:DOCKERTAG"
Invoke-Expression "docker push uscr/amssecretvault:$env:DOCKERTAG"