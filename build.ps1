$BuildType = $args[0]
if ($BuildType -cne "Release" -and $BuildType -cne "Debug")
{
  Write-Output "$BuildType must be ""Release"" or ""Debug""" 
  return -1
}

dotnet build .\src\UniverseLib.sln -c "${BuildType}_IL2CPP"

dotnet build .\src\UniverseLib.sln -c "${BuildType}_Mono"