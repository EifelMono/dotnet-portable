# dotnet tools portable

- [dotnet tools portable](#dotnet-tools-portable)
  - [Why](#why)
  - [dotnet tools](#dotnet-tools)
    - [dotnet-counters](#dotnet-counters)
    - [dotnet-coverage](#dotnet-coverage)
    - [dotnet-dump](#dotnet-dump)
    - [dotnet-gcdump](#dotnet-gcdump)
    - [dotnet-monitor](#dotnet-monitor)
    - [dotnet-trace](#dotnet-trace)
    - [dotnet-stack](#dotnet-stack)
    - [dotnet-symbol](#dotnet-symbol)
    - [dotnet-sos](#dotnet-sos)
    - [dotnet-dsrouter](#dotnet-dsrouter)
  - [Learning videos](#learning-videos)
    - [Finding MEMORY LEAKS in C# .NET Applications](#finding-memory-leaks-in-c-net-applications)
      - [Steps from the video](#steps-from-the-video)
- [Windows Terminal](#windows-terminal)
  - [Download](#download)
- [Powershell](#powershell)

## Why

We dot not have internet ......

So we need to have the nuget local and
install them from this directory with the follwing command

```console
dotnet tool restore
```

This stuff is to look at running dotnet programs

```console
dotnet counters -ps

dotnet counters monitor -p [processid from dotnet counters ps]

```

Additional Windows Terminal is also available.

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

dotnet counters monitor -p [processid from dotnet counters ps]

dotnet dump ps

dotnet dump collect -p [processid from dotnet dump ps]

dotnet dump analyze [filepath]

dumpheap -stat

dumpheap -mt [address from dumpheap -stat]

gcroot [address from dumpheap -mt]
```

# Windows Terminal

## [Download](https://github.com/microsoft/terminal/releases)

# Powershell

Include in the nugets
