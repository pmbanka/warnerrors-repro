# warnerrors-repro

https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/compiler-options

https://stackoverflow.com/a/468166/1108916

```
Paket version 5.81.2
Performance:
 - Disk IO: 438 milliseconds
 - Runtime: 2 seconds
Building project with version: LocalBuild
Shortened DependencyGraph for Target Build:
<== Build
   <== Clean

The running order is:
  - Clean
  - Build
Running build with 1 worker
Starting Target: Clean 
Deleting contents of ./build/
Deleting contents of ./deploy/
Finished Target: Clean
Starting Target: Build (==> Clean)
Building project: c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fsproj
  C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\MSBuild\15.0\Bin\MSBuild.exe  c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fsproj /t:Build /m      /p:RestorePackages="False" /p:OutputPath="c:\repos\warnerrors-repro\build" /p:Configuration="Debug" /logger:Fake.MsBuildLogger+ErrorLogger,"c:\repos\warnerrors-repro\packages\FAKE\tools\FakeLib.dll"
Microsoft (R) Build Engine version 15.1.1012.6693
Copyright (C) Microsoft Corporation. All rights reserved.

Build started 27-Jul-17 14:54:46.
     1>Project "c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fsproj" on node 1 (Build target(s)).
     1>GenerateTargetFrameworkMonikerAttribute:
       Skipping target "GenerateTargetFrameworkMonikerAttribute" because all output files are up-to-date with respect to the input files.
       CoreCompile:
         C:\Program Files (x86)\Microsoft SDKs\F#\4.1\Framework\v4.0\fsc.exe -o:obj\Debug\WarnAsError.dll
         -g
         --debug:full
         --noframework
         --define:DEBUG
         --define:TRACE
         --doc:bin\Debug\WarnAsError.XML
         --optimize-
         --tailcalls-
         -r:c:\repos\warnerrors-repro\packages\FSharp.Core\lib\net45\FSharp.Core.dll
         -r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.2\mscorlib.dll
         -r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.2\System.Core.dll
         -r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.2\System.dll
         -r:C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.6.2\System.Numerics.dll
         --target:library
         --warn:3
         --warnaserror
         --warnaserror:76
         --fullpaths
         --flaterrors
         --subsystemversion:6.00
         --highentropyva+
         C:\Users\n635925\AppData\Local\Temp\.NETFramework,Version=v4.6.2.AssemblyAttributes.fs
         WarnAsError.fs
         
         
     1>c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fs(9,21): error FS0044: This construct is deprecated [c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fsproj]
         
     1>c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fs(9,21): error FS0044: This construct is deprecated [c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fsproj]
         
     1>c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fs(9,21): error FS0044: This construct is deprecated [c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fsproj]
     1>Done Building Project "c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fsproj" (Build target(s)) -- FAILED.

Build FAILED.

       "c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fsproj" (Build target) (1) ->
       (CoreCompile target) -> 
         c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fs(9,21): error FS0044: This construct is deprecated [c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fsproj]
         c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fs(9,21): error FS0044: This construct is deprecated [c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fsproj]
         c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fs(9,21): error FS0044: This construct is deprecated [c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fsproj]

    0 Warning(s)
    3 Error(s)

Time Elapsed 00:00:04.18
Running build failed.
Error:
Building c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fsproj failed with exitcode 1.

---------------------------------------------------------------------
Build Time Report
---------------------------------------------------------------------
Target     Duration
------     --------
Clean      00:00:00.0035031
Build      Failure
Total:     00:00:11.3388825
---------------------------------------------------------------------
---------------------------------------------------------------------
Status:    Failure
---------------------------------------------------------------------
  1) Building c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fsproj failed with exitcode 1.
  2) FS0044: c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fs(9,21): This construct is deprecated
---------------------------------------------------------------------
  3) FS0044: c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fs(9,21): This construct is deprecated
  4) FS0044: c:\repos\warnerrors-repro\WarnAsError\WarnAsError.fs(9,21): This construct is deprecated

```
