Set-Location 'X:\APPDATA\PostgreSQL\15\bin'
$env:PGPASSWORD = 'Q00dkaPL'
$dbInfoList = Invoke-Expression "./psql.exe -l -U postgres" | ForEach-Object { $_.Split(' ')[1] } | Where-Object { $_ -Like "*db" }
$dbInfoList | ForEach-Object { Invoke-Expression "./dropdb --host=localhost --port=5432 --username=postgres --no-password $_" }
