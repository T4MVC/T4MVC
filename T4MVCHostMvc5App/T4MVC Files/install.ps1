param($installPath, $toolsPath, $package, $project)

$project.ProjectItems.Item("T4MVC.tt").Properties.Item("BuildAction").Value = 0 #prjBuildActionNone
$project.ProjectItems.Item("T4MVC.tt.hooks.t4").Properties.Item("BuildAction").Value = 0
$project.ProjectItems.Item("T4MVC.tt.settings.xml").Properties.Item("BuildAction").Value = 0
