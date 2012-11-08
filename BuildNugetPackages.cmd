pushd T4MVCExtensions
nuget pack -symbols
move *.nupkg ..
popd

pushd "T4MVCHostMvcApp\T4MVC Files"
nuget pack
move *.nupkg ..\..
popd
