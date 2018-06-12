    $MsBuildPath = "C:\\Program Files (x86)\\MSBuild\\14.0\\Bin\\MSBuild.exe"
    $MsBuildPath64 = "C:\\Program Files (x86)\\MSBuild\\14.0\\Bin\\amd64\\MSBuild.exe"
    $NugetPath = "C:\\gitlab-runner\\nuget"
    $SolutionName = "Invoice OTC.sln"
 
    echo "Sedang merestore paket nuget untuk $SolutionName"
    $NugetPath restore $SolutionName  
