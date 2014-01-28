param($installPath, $toolsPath, $package, $project)

$project.ProjectItems.Item("T4MVCVB.tt").Properties.Item("BuildAction").Value = 0 #prjBuildActionNone
$project.ProjectItems.Item("T4MVCVB.tt.hooks.t4").Properties.Item("BuildAction").Value = 0
$project.ProjectItems.Item("T4MVCVB.tt.settings.xml").Properties.Item("BuildAction").Value = 0
