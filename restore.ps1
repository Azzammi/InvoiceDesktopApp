    $NugetPath = "C:\\gitlab-runner\\nuget"
    $SolutionName = "Invoice OTC.sln"
 
    echo "Sedang merestore paket nuget untuk $SolutionName"
    & $NugetPath restore $SolutionName  
