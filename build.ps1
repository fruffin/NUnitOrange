$outputPath = "./BuildOutput"
$msbuildExe = "C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe"
$nugetExe = "./.nuget/nuget.exe"


if (Test-Path $outputPath) 
{
	Write-Host "Removing output directory located at $outputDir"
	Remove-Item $outputPath -force -Recurse | Out-Null
}

Write-Host "Creating output directory located at $outputDir"
Mkdir $outputPath | Out-Null

&$msbuildExe ('NUnitOrange.sln','/verbosity:q','/p:configuration=Release','/t:Clean,Rebuild')
&$nugetExe pack ./NUnitOrange/NUnitOrange.nuspec -OutputDirectory ./BuildOutput