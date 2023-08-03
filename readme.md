# dotnet tools portable

## Why

We dot not have internet ......

So we need to have the nuget local and
install them from this directory with the follwing command

```console
dotnet tool restore
```

## [dotnet tools](https://learn.microsoft.com/en-us/dotnet/core/diagnostics/tools-overview)

### [dotnet-counters](https://learn.microsoft.com/en-us/dotnet/core/diagnostics/dotnet-counters)

### [dotnet-coverage](https://learn.microsoft.com/en-us/dotnet/core/diagnostics/dotnet-coverage)

### [dotnet-dump](https://learn.microsoft.com/en-us/dotnet/core/diagnostics/dotnet-dump)

### [dotnet-gcdump](https://learn.microsoft.com/en-us/dotnet/core/diagnostics/dotnet-gcdump)

### [dotnet-monitor](https://learn.microsoft.com/en-us/dotnet/core/diagnostics/dotnet-monitor)

### [dotnet-trace](https://learn.microsoft.com/en-us/dotnet/core/diagnostics/dotnet-trace)

### [dotnet-stack](https://learn.microsoft.com/en-us/dotnet/core/diagnostics/dotnet-stack)

### [dotnet-symbol](https://learn.microsoft.com/en-us/dotnet/core/diagnostics/dotnet-symbol)

### [dotnet-sos](https://learn.microsoft.com/en-us/dotnet/core/diagnostics/dotnet-sos)

### [dotnet-dsrouter](https://learn.microsoft.com/en-us/dotnet/core/diagnostics/dotnet-dsrouter)

## Learning videos

### [Finding MEMORY LEAKS in C# .NET Applications](https://www.youtube.com/watch?v=9QPgfJPaGvY&t=3s)

#### Steps from the video

```console
dotnet counters ps

dotnet counters monitor -p [processid]

dotnet dump ps

dotnet dump collect -p [processid]

dotnet dump analyze [filepath]

dumpheap -stat

dumpheap -mt [address from dumpheap -stat]

gcroot [address from dumpheap -mt]
```
