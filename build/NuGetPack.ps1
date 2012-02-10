param(
	[Parameter(Mandatory = $true, ValueFromPipeline = $true)]
	[string]
	$apiKey
)

del *.nupkg

$nuget = '..\src\.nuget\nuget'

Get-ChildItem -Path .. -Include *.nuspec -Recurse | % { Start-Process $nuget -ArgumentList "pack $(Join-Path ([IO.Path]::GetDirectoryName($_)) ([IO.Path]::GetFileNameWithoutExtension($_) + '.csproj')) -Build -Prop Configuration=Release -Exclude '**\*.CodeAnalysisLog.xml'" -NoNewWindow -Wait }
Get-ChildItem *.nupkg | % { &$nuget push $_ $apiKey } 
del *.nupkg