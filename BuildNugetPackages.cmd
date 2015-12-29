pushd T4MVCExtensions
msbuild /p:Configuration=Release
nuget pack -symbols -Prop Configuration=Release T4MVCExtensions.csproj
move *.nupkg ..
popd

pushd "T4MVCHostMvcApp\T4MVC Files"
nuget pack
move *.nupkg ..\..
popd

pushd T4MVCVB
nuget pack
move *.nupkg ..
popd
