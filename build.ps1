    $MsBuildPath = "C:\\Program Files (x86)\\MSBuild\\14.0\\Bin\\MSBuild.exe"
    $MsBuildPath64 = "C:\\Program Files (x86)\\MSBuild\\14.0\\Bin\\amd64\\MSBuild.exe"
    $NugetPath = "C:\\gitlab-runner\\nuget"
    $SolutionName = "Invoice OTC.sln"
  
 
    echo "Sedang merestore paket nuget untuk $env:SolutionName"
    $env:NugetPath restore $env:SolutionName  
   
    echo "Sedang melakukan proses build 32 bit untuk $env:SolutionName ..."
    $env:MsBuildPath $env:SolutionName    
    echo "Sedang melakukan proses build 64 bit untuk $env:SolutionName ..."
    $env:MsBuildPath64 $env:SolutionName    
