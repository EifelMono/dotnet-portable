#addin nuget:?package=NuGet.Protocol&version=6.6.1
using NuGet.Common;
using NuGet.Protocol;
using NuGet.Protocol.Core.Types;
using NuGet.Versioning;
using System.Threading;

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

var PackageIds = new List<string>
   {
      "dotnet-counters",
      "dotnet-coverage",
      "dotnet-dump",
      "dotnet-gcdump",
      "dotnet-monitor",
      "dotnet-trace",
      "dotnet-stack",
      "dotnet-symbol",
      "dotnet-sos",
      "dotnet-dsrouter",

      "cake.tool",
      "PowerShell",
   };

Task("DownLoadFromNuget")
.Does(async () =>
{
   ILogger logger = NullLogger.Instance;

   SourceCacheContext cache = new SourceCacheContext();
   SourceRepository repository = Repository.Factory.GetCoreV3("https://api.nuget.org/v3/index.json");
   FindPackageByIdResource resource = await repository.GetResourceAsync<FindPackageByIdResource>();

   foreach (var packageId in PackageIds)
   {
      try
      {
         Information($"Find versions for {packageId}");
         IEnumerable<NuGetVersion> versions = await resource.GetAllVersionsAsync(
            packageId,
            cache,
            logger,
            CancellationToken.None);

         var packageVersion = versions.Last(v => !v.IsPrerelease);
         Information($"Versions found {packageVersion}");

         var nugetName = $".nuget/{packageId}.{packageVersion}.nupkg";

         if (!FileExists(nugetName))
         {
            foreach (var file in GetFiles($".nuget/*{packageId}*"))
            {
               DeleteFile(file);
            }
            using var packageStream = new MemoryStream();
            Information($"Download {packageId} {packageVersion} ready");
            await resource.CopyNupkgToStreamAsync(
               packageId,
               packageVersion,
               packageStream,
               cache,
               logger,
               CancellationToken.None);

            using var fileStream = System.IO.File.Create(nugetName);
            packageStream.Seek(0, SeekOrigin.Begin);
            packageStream.CopyTo(fileStream);
            fileStream.Close();
            Information($"Download {packageId} {packageVersion} ready");
         }
         else
         {
            Information($"Package exist {packageId} {packageVersion} ready");
         }
      }
      catch (Exception ex)
      {
         Error(ex);
      }
   };
});

Task("AddToConfig")
.Does(() =>
{
   foreach (var packageId in PackageIds)
      StartProcess("dotnet.exe", new ProcessSettings
      {
         Arguments = new ProcessArgumentBuilder().Append("tool").Append("install").Append(packageId)
      });
});

Task("Default")
.Does(() =>
{
   Information("Hello Cake!");
});

RunTarget(target);