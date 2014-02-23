T4MVC readme file
Find latest version and documentation at https://t4mvc.codeplex.com/
Discuss on StackOverflow or on the MVC forum (http://forums.asp.net/1146.aspx)

Maintained by David Ebbo, with much feedback from the MVC community (thanks all!)
david.ebbo@microsoft.com
http://twitter.com/davidebbo
http://blog.davidebbo.com/ (previously: http://blogs.msdn.com/davidebb)

Related blog posts:
http://blogs.msdn.com/davidebb/archive/tags/T4MVC/default.aspx
http://www.hanselman.com/blog/TheWeeklySourceCode43ASPNETMVCAndT4AndNerdDinner.aspx

Feel free to use and modify to fit your needs.

This T4 template for ASP.NET MVC apps creates strongly typed helpers that eliminate the use
of literal strings when referring the controllers, actions and views.

To use it, simply copy it and T4MVC.settings.t4 to the root of your MVC application.

This will enable the following scenarios:

Refer to controller, action and view names as shown in these examples:
    - MVC.Dinners.Name: "Dinners" (controller name). 
    - MVC.Dinners.Views.DinnerForm: "DinnerForm" (view name)
    - MVC.Dinners.Actions.Delete: "Delete" (action name)

Strong type certain scenarios that refer to controller actions.  e.g.
    - Html.ActionLink("Delete Dinner", MVC.Dinners.Delete(Model.DinnerID))
    - Url.Action(MVC.Dinners.Delete(Model.DinnerID))
    - RedirectToAction(MVC.Dinners.Delete(dinner.DinnerID))
    - Route defaults e.g.
            routes.MapRoute(
                "UpcomingDinners", 
                "Dinners/Page/{page}", 
                MVC.Dinners.Index(null)
            );

Refer to your static images and script files with strong typing, e.g.
    Instead of <img src="/Content/nerd.jpg" ...>, you can write <img src="<%= Links.Content.nerd_jpg %>" ...>
    Instead of <script src="/Scripts/Map.js" ...>, you can write <script src="<%= Links.Scripts.Map_js %>" ...>
    Or if the file name is dynamic, you can write: Links.Content.Url("foo.jpg")

KNOWN ISSUES:
- Users running VisualSVN have reported some errors when T4MVC tries to change actions to virtual and controllers to partial.
  The suggestion when that happens is to manually make those changes.  This is just a one time thing you need to do.
- It will not locate controllers that live in a different project or assembly
- Compile error when folder under Content contains subfolder with same name as itself (http://blogs.msdn.com/davidebb/archive/2010/01/04/t4mvc-2-6-10-fluent-route-value-api-shorter-way-to-refer-to-action-and-more.aspx#9952727)

HISTORY:

!!! 3.7.7 (2-23-2014)
* Fix signing issue in 3.7.6. [url:https://t4mvc.codeplex.com/discussions/533445]

!!! 3.7.6 (2-20-2014)
* Allow AddRouteValues to override values. [url:https://t4mvc.codeplex.com/workitem/39]

!!! 3.7.5 (1-28-2014)
* Make statuc MVC class partial. [url:https://t4mvc.codeplex.com/SourceControl/network/forks/garyhunt/T4MVCpartial/contribution/6116]
* Mark action overloads as NonAction. [url:https://t4mvc.codeplex.com/SourceControl/network/forks/garyhunt/T4MVCNonAction/contribution/6118]

!!! 3.7.4 (9-19-2013)
* Set buildaction of t4 files to none. [url:https://t4mvc.codeplex.com/SourceControl/network/forks/duncans/T4MVC/contribution/5356]

!!! 3.7.3 (8-09-2013)
* Fix issue 23 - support for 'async Task<ActionResult>' methods. [url:https://t4mvc.codeplex.com/SourceControl/network/forks/mswainatwork/t4mvc/contribution/5154]

!!! 3.7.2 (8-07-2013)
* Fix abstract view result method generation. [url:https://t4mvc.codeplex.com/workitem/23]

!!! 3.7.1 (7-05-2013)
* Fixed bug where AddRouteValue() throws ArgumentException if route value has already been added. [url:https://t4mvc.codeplex.com/workitem/25]

!!! 3.7.0 (6-16-2013)
* New AddAllViewsFoldersToStaticFilesFolders flag to include view folder files as static files (off by default) [url:https://t4mvc.codeplex.com/discussions/445358]
* New ExcludedViewExtensions setting to not treat certain file extensions as views

!!! 3.6.5 (5-19-2013)
* Use Controller constructor with least number of params. [url:https://t4mvc.codeplex.com/workitem/22]

!!! 3.6.4 (5-08-2013)
* Added support for checking files out with Perforce P4VS. [url:https://t4mvc.codeplex.com/discussions/442992]

!!! 3.6.3 (5-08-2013)
* Fix assembly signing

!!! 3.6.2 (5-07-2013)
* Avoid identifier conflict when content file names are similar. [url:https://t4mvc.codeplex.com/discussions/441214]

!!! 3.6.1 (5-03-2013)
* Make actionresult classes partial. [url:https://t4mvc.codeplex.com/SourceControl/network/forks/duncans/T4MVC/contribution/4632]

!!! 3.6.0 (4-26-2013)
* Add support for task based actions. [url:https://t4mvc.codeplex.com/SourceControl/network/forks/kev_bite/T4mvcTaskBasedActions/contribution/4564]

!!! 3.5.4 (4-22-2013)
* Make action results internal to avoid cross project conflicts

!!! 3.5.3 (4-19-2013):
* Add support for portable areas without a standard area folder

!!! 3.5.2 (3-07-2013):
* Add support for inherited controller attributes. [url:http://t4mvc.codeplex.com/SourceControl/network/forks/mswainatwork/t4mvc/contribution/4194]

!!! 3.5.1 (2-25-2013):
* If static files include a timestamp, previously for minified CSS- and JavaScript-files the timestamp was generated by taking the last change time of the unminified file. [url:https://t4mvc.codeplex.com/SourceControl/network/forks/rmarcush/t4mvc/contribution/4122]

!!! 3.5.0 (2-08-2013):
* Sign T4MVCExtensions.dll [url:http://t4mvc.codeplex.com/discussions/432534]
* Call T4Extension.TimestampString through delegate for unit testing [url:http://t4mvc.codeplex.com/SourceControl/network/forks/rmarcush/t4mvc/contribution/4040]

!!! 3.4.1 (1-31-2013):
* Make T4MVCHelpers internal to avoid cross project conflicts [url:http://t4mvc.codeplex.com/workitem/17]

!!! 3.4.0 (1-23-2013):
* Add optional support for async methods [url:https://t4mvc.codeplex.com/SourceControl/network/forks/mswainatwork/t4mvc/contribution/3958]
* Generate partial methods to allow custom "overloading" of the return values.

!!! 3.3.0 (1-16-2013):
*  Add support for support for model unbinder providers [url:https://t4mvc.codeplex.com/SourceControl/network/forks/Augi/T4MVCUnbinderProvider/contribution/3879]
*  Fix handling of "completed" methods [url:https://t4mvc.codeplex.com/SourceControl/network/forks/phw/t4mvc/contribution/3922]

!!! 3.2.1 (12-27-2012):
*  Fix issue with VB projects causing exceptions [url:http://t4mvc.codeplex.com/workitem/7]

!!! 3.2.0 (12-11-2012):
*  Add option to make parameter names constants [url:https://t4mvc.codeplex.com/SourceControl/network/forks/WayneBrantley/ParameterNamesToConst/contribution/3762]

!!! 3.1.0 (12-09-2012):
* Added JavaScriptReplacableUrl helper [url:http://t4mvc.codeplex.com/discussions/405911]

!!! 3.0.3 (11-30-2012):
* Fix to deal with multiple attributes [url:http://t4mvc.codeplex.com/SourceControl/network/forks/ArtiomChi/t4mvc/contribution/3723]

!!! 3.0.2 (11-17-2012):
* Add support for generic result types [url:http://t4mvc.codeplex.com/SourceControl/network/forks/ryanrust/T4MVC/contribution/3653]

!!! 3.0.1 (11-16-2012):
* Fix T4MVC.tt.settings.xml so it only gets generated when needed [url:https://t4mvc.codeplex.com/discussions/403390]

!!! 3.0.0 (11-14-2012):
* Move all the non-dynamic code to a separate T4MVCExtensions.dll assembly
* Change generated code brace style to Allman
* Added many new RouteLink/BeginRouteForm/RouteUrl helpers

!!! 2.13.0 (10-24-2012):
* Move settings to T4MVC.tt.settings.xml XML file instead of tt file
* Make simple view names available alongside full names, e.g. MVC.Home.Views.SomeView vs MVC.Home.Views.ViewNames.SomeView

!!! 2.12.0 (10-16-2012):
* Add support for static files in nested folders [url:http://t4mvc.codeplex.com/workitem/6]
* Add MVC 4 bundle starter classes [url:https://t4mvc.codeplex.com/discussions/399205]

!!! 2.11.2 (10-11-2012):
* Removed optional params in ActionLink to support expression trees [url:http://t4mvc.codeplex.com/workitem/4]
* Change brace style of generated code to Allman

!!! 2.11.1 (10-10-2012):
* Ignore methods that return generic types [url:http://mvccontrib.codeplex.com/workitem/7178]

!!! 2.11.0 (10-09-2012):
* Corrects the ActionParameters class for overloaded actions to list all parameters and not just the parameters from the first action found.

!!! 2.10.4 (10-05-2012):
* Added attributes so it builds clean under Code Analysis [url:http://t4mvc.codeplex.com/workitem/10]

!!! 2.10.3 (09-30-2012):
* Fix crash when querystring contains a null key [url:http://t4mvc.codeplex.com/discussions/396916]

!!! 2.10.2 (09-17-2012):
* Fix UnbindModel to avoid failing on duplicate entries [url:http://t4mvc.codeplex.com/discussions/394529]
* Fix ModelUnbinder code generation when SplitIntoMultipleFiles is false [url:http://t4mvc.codeplex.com/workitem/9]

!!! 2.10.1 (07-31-2012):
* Fixed default param regression with model unbinder code ([url:http://stackoverflow.com/questions/11566207/t4mvc-optionalparameter-values-implied-from-current-context/11603897])

!!! 2.10.0 (07-03-2012):
* Added support for custom model binders ([url:https://t4mvc.codeplex.com/discussions/357386])
* Fixed unreachable code warning

!!! 2.9.0 (06-22-2012):
* Added support for minified css files ([url:https://t4mvc.codeplex.com/discussions/360443])
* Replaced improper new RouteValueDictionary usage on htmlAttributes

!!! 2.8.1 (04-12-2012):
* Also default to https for the default (no param) action overload
* Make T4MVCHelpers class public so that test code in a different assembly can access it

!!! 2.8 (03-25-2012):
* Generate parameter constants for action methods. e.g. MVC.MyController.MethodParams.someParam
* Default to https for Action Methods marked as RequireHttps (either at controller or action level)

!!! 2.7.0 (03-09-2012):
* Removed support for MVC earlier than 3, and for CLR earlier than 4.0
* Fix ActionLink to work with MVC4 (http://mvccontrib.codeplex.com/workitem/7191)

!!! 2.6.68 (02-03-2011):
* Ignore static ctors when looking for ctors (http://mvccontrib.codeplex.com/workitem/7185)

!!! 2.6.67 (12-24-2011):
* Restore Actions token that wasn't obsolete after all. Oops. (http://stackoverflow.com/questions/8625462/t4mvc-actions-token)

!!! 2.6.66 (12-22-2011):
* Disable constant generation in UseLowercaseRoutes mode (http://stackoverflow.com/questions/8605868/t4mvc-2-6-65-and-uselowercaseroutes-true-error)
* Remove obsolete Actions token (http://stackoverflow.com/questions/8536269/what-is-the-difference-between-these-2-definitions-in-t4mvc/8543510)

!!! 2.6.65 (12-06-2011):
* Add true constant strings for use in attributes (http://mvccontrib.codeplex.com/workitem/7177)

!!! 2.6.64 (10-21-2011):
* Fix issue when action parameter name is escaped using @ syntax (e.g. int @event)

!!! 2.6.63 (10-13-2011):
* Move hard coded T4MVC namespace into settings file

!!! 2.6.62 (08-13-2011):
* Replace some unwanted tab characters with whitespace

!!! 2.6.61 (08-01-2011):
* Ignore generic action methods (http://mvccontrib.codeplex.com/workitem/7156)

!!! 2.6.60 (07-28-2011):
* Added support for portable areas. Enabled by adding area names to PortableAreas in T4MVC.tt.settings.t4
* When generating links and views, if the folder name is the same as the parent, add a modifier to avoid class name conflicts (http://mvccontrib.codeplex.com/workitem/7153)

!!! 2.6.59 (07-12-2011):
* Added commented out logic to show how to debug into the template (http://mvccontrib.codeplex.com/workitem/7144)
* Ignore any class which name doesn't end with "Controller"

!!! 2.6.58 (06-24-2011):
* Change the controller detection logic to be more reliable and ignore anything that doesn't extend Controller.

!!! 2.6.57 (06-21-2011):
* Re-added Html.ActionLink/Url.Action overload without default params to avoid running into "CS0854: An expression tree may not contain a call or invocation that uses optional arguments"
* Make ProcessControllerActionMethods look for ControllerBase instead of Controller to support controllers like MailerBase (from ActionMailer) which extend ControllerBase.

!!! 2.6.56 (06-05-2011):
* Added optional Html.ActionLink parameters for protocol, hostname and fragment (http://stackoverflow.com/questions/6280347/how-can-i-add-a-hash-fragment-to-t4mvc-route-dictionary-actionresult/6302703)

!!! 2.6.55 (06-05-2011):
* Added optional Url.Action parameters for protocol and hostname (http://stackoverflow.com/questions/6240568/t4mvc-doesnt-work-property-with-url-action)

!!! 2.6.54 (04-23-2011):
* Added missing license to NuGet package and fixed some links. No actual template changes!

!!! 2.6.53 (04-18-2011):
* Ignore actions marked as obsolete ([url:http://mvccontrib.codeplex.com/workitem/7133])

!!! 2.6.52 (04-14-2011):
* Moved the 'Dummy' class under the GenerateMvcT4Extensions check
* Always include the area token in the route values unless running on MVC 1.x

!!! 2.6.51 (04-12-2011):
* Ignore async completion methods as they can't really be used in T4MVC, and can cause issues ([url:http://stackoverflow.com/questions/5419173/t4mvc-asynccontroller])

!!! 2.6.50 (04-08-2011):
* Added AddTimestampToStaticLink() method to settings file to allow more granular decision (per [url:this post|http://mvccontrib.codeplex.com/workitem/7129])
* Added GenerateMvcT4Extensions settings flag to omit the generation of the System.Web.Mvc.T4Extensions class, which can be useful if it is already defined in a referenced library (see [url:this post|http://stackoverflow.com/questions/5563163/t4mvc-use-extension-methods-in-control-library/5574227])

!!! 2.6.44 (03-10-2011):
* Added UseNonQualifiedViewNames flag which when set to true causes view names never to be fully qualified. Spark users may need that.

!!! 2.6.43 (02-24-2011):
* Renamed T4MVC.settings.t4 to T4MVC.tt.settings.t4 so it feels more like a 'child' file of T4MVC.tt

!!! 2.6.42 (02-01-2011):
* Fix partial view support for MVC
* Fix partial view support when name has periods (http://mvccontrib.codeplex.com/workitem/7113)

!!! 2.6.41 (01-17-2011):
* Added AJAX BeginForm overloads

!!! 2.6.40 (01-05-2011):
* Added BeginForm overload that just takes an ActionResult
* Fix MapRouteArea to use UseNamespaceFallback when there are no namespaces

!!! 2.6.32 (12-15-2010):
* Fix bug in controller name generation when IncludeAreasToken is true

!!! 2.6.31 (11-15-2010):
* Improve error message when T4MVC generated files are out of date.
* Changed some 'const bool' settings to 'static bool' to avoid unused code warnings.
* Disabled regen optimization added in 2.6.14 since it doesn't catch view changes

!!! 2.6.30 (09-05-2010):
* Changed ExplicitHtmlHelpersForPartials flag to be off by default (and fix a small issue when it's off)
* Handled System.NotImplementedException if project type (e.g. Installer) does not implement CodeModel property
* Fixed issue when action method params are all optional (http://stackoverflow.com/questions/3488610/t4mvc-and-named-parameters)
* Exclude Area related methods when using MVC 1.0, as that was breaking things
* Added logic to special case DisplayTemplates/EditorTemplates folders, since they need short view names passed in

!!! 2.6.21 (07-20-2010):
* Fix to the partial extension feature added in 2.6.20 to deal with conflicts

!!! 2.6.20 (07-19-2010):
* Added extension methods to render partial views (see [url:this post|http://www.weirdlover.com/2010/05/12/t4mvc-extension-for-mvc-partials/])
** e.g. Html.RenderPartial("Map", Model.Dinner); --> Html.RenderMap(Model.Dinner);
** Can be turned off in settings file via ExplicitHtmlHelpersForPartials flag.

!!! 2.6.15 (05-16-2010):
* Added missing MapRoute overloads to support namespaces
* Added MapRoute extensions on AreaRegistrationContext to support areas. Had to name them MapRouteArea to avoid clash with existing MapRoute methods :(

!!! 2.6.14 (05-06-2010):
* Added UseLowercaseRoutes flag to lower case the area, controller and action names in routes
* Added support for Views folders that don't match a controller name.
* Added optimization to not regenerate files when the controller has not changed since the last generation
* Turn AlwaysKeepTemplateDirty to false by default. We now have an [url:addin|http://blogs.msdn.com/davidebb/archive/2010/03/18/an-even-better-way-to-run-t4mvc-a-vs-addin.aspx] which provides a better solution to this

!!! 2.6.13 (03-08-2010):
* Added AddTimestampToStaticLinks flag to T4MVC.settings.t4 to  generate static links that change when the file changes.
* Added support for {"[Bind(Prefix = "newParamName")]"} attribute so it generates the correct route value
* Added an AddRouteValues overload that takes NameValueCollection, e.g.
** MVC.Home.About().AddRouteValues(Request.QueryString)
* Added MapRoute overload that supports contraints
* Removed some logic to support VS2010 Beta 2.  VS2010 RC or later should now be used.

!!! 2.6.12 (01-15-2010):
* Fixed issue where some special project types (e.g. DB projects) were throwing while enumerating over the list
* Changed to use GeneratedCode attribute instead of the less correct CompilerGenerated
* Fixed CompilerGenerated/DebuggerNonUserCode attributes so they don't incorrectly affect the control classes
* Change to avoid adding area to route if the app is not using areas

!!! 2.6.11 (01-10-2010):
* Added ExcludedStaticFileExtensions setting to T4MVC.settings.t4 to list extensions for which static links should not be generated.
* Support configurable name for IT4MVCActionResult, and it being defined externally (for sharing pourpose)
* Added DebuggerNonUserCode attribute to generated classes
* Improved error handling when trying to call T4MVC method with real ActionResult (previous threw InvalidCast)
* Fix issue when overridden action methods were incorrectly marked as virtual

!!! 2.6.10 (01-04-2010):
* Added support for adding arbitrary route parameters to T4MVC actions. e.g.
** MVC.Home.About().AddRouteValue("fooKey", bar.Foo.Key)
** MVC.Home.About().AddRouteValues(new {fooKey = bar.Foo.Key, barKey = bar.Key})
* Added shorter to refer to controller actions from with the controller itself. e.g.
** return RedirectToAction(MVC.MyController.Actions.About());		BECOMES:
** return RedirectToAction(Actions.About());
* What was previously called Actions was renamed to ActionNames (note, that's a BREAKING CHANGE if you used Actions before!)
* Ignore controller methods that are marked with a NonAction attribute
* Renamed IT4MVCActionResult.RouteValues to avoid conflict (this should not break anything, as it's only used internally)

!!! 2.6.03 (12-10-2009):
* Generate full view paths to allow cross controller references
** e.g. MVC.Dinners.Views.DinnerForm is now "~/Views/Dinners/DinnerForm.ascx" instead of just "DinnerForm"
* Fix compile error when a view name is a language keyword (e.g. string.ascx)

!!! 2.6.02 (12-04-2009)
* Added way to get area name from both Area and Controller objects
** e.g. MVC.MyArea.Name and MVC.MyArea.MyController.Area
* Added support for controllers in the default namespace (i.e. no namespace)
* Always include the area in the route data, even when it's null/empty

!!! 2.6.01 (12-02-2009)
* Fix compile error when a custom ActionResult type has a ctor that takes a value type

!!! 2.6.00 (11-28-2009)
* Added support for MVC 2 Areas
* Fixed issue where non-existing RenderAction method gets generated on VS2010 Beta 2
* Added check to give proper error when attempting to run T4MVC outside VS (e.g. from TextTransform.exe)

!!! 2.5.02 (11-24-2009)
* Change links in comment to point to new T4MVC home and forum
* Fix scenario where a View folder as a name that's a C# keyword

!!! 2.5.01 (11-20-2009)
* Added support for Html.RenderAction and Html.Action (see http://haacked.com/archive/2009/11/18/aspnetmvc2-render-action.aspx)
* Fix null ref exception issue when custom ActionResult type doesn't have any explicit ctors

!!! 2.5.00 (11-16-2009)
* Incorporated Damien Guard's multiple output manager to (optionally) split output from T4MVC into separate files to improve source control
* Added support for minified javascript files in production
* Fixed bug occurring when no action is of type ActionResult

!!! 2.4.04 (10-15-2009)
* Added support for MVC 2 by detecting the version and generating slightly different code

!!! 2.4.03 (10-02-2009)
* Added ProcessVirtualPath method to T4MVC.settings.t4 so user can write custom logic to modify client URL's
* Greatly simplified GetProjectContainingT4File logic by using FindProjectItem().
* Renamed generated classes to be CLS compliant
* Moved most of the doc and versioning comments from T4MVC.tt into the readme.txt file, as it was getting a bit long.

!!! 2.4.02 (09-02-2009)
* Added a setting in T4MVC.settings.t4 to set the namespace that Links get generated in
* Added pragma to prevent compiler from complaining about missing Xml comments
* Added <auto-generated /> comment to disable StyleCop in generated file
* Fixed issue when using a custom ResultType in a custom namespace. Now fully qualifying result types.

!!! 2.4.01 (07-29-2009):
* Put all the generated code in a T4MVC #region. This is useful to tell tools like ReSharper to ignore it.
* Fixed issue where controller methods returning generic types cause template to blow up
* Added a setting in T4MVC.settings.t4 to turn off the behavior that always keeps the template dirty

!!! 2.4.00 (07-28-2009):
* Added support for configurable settings in a separate T4MVC.settings.t4 file
* Added a parameter-less pseudo-action for every action that doesn't already have a parameter-less overload
* Added support for having T4MVC.tt in a sub folder instead of always at the root of the project
* Fixed issue when a base controller doesn't have a default ctor
* Added T4Extensions into System.Web.Mvc namespace to fix ambiguous resolution issue 
* Misc cleanup

!!! 2.3.01 (07-10-2009):
* Fixed issue with [ActionName] attribute set to non literal string values (e.g. [ActionName(SomeConst + "Abc")])
* Fixed duplication issue when partial controller classes have a base type which contains action methods
* Skip App_LocalResources when processing views
* Cleaned up rendering logic

!!! 2.3.00 (07-07-2009):
* Added support for sub view folders
* Added support for [ActionName] attribute
* Improved handling when the controller comes from a different project
* Don't try to process generic controller classes

!!! 2.2.03 (07-06-2009):
* Added support for action methods defined on controller base classes
* Improved error handling when not able to change actions to virtual and controllers to partial

!!! 2.2.02 (07-01-2009):
* Fixed break caused by incorrect support for derived ActionResult types in 2.2.01
* Fixed issue with duplicate view tokens getting generated when you have both foo.aspx and foo.ascx

!!! 2.2.01 (07-01-2009):
* Added support for action methods that return a type derived from ActionResult (as opposed to exactly an ActionResult)
* Fixed issue when controller is using partial classes
* Fixed folder handling logic to deal with generated files
* Fixed issue with folder names that are C# keyword
* Throw NotSupportedException instead of NotImplementedException to avoid being viewed as a TODO

!!! 2.2.00 (06-30-2009):
* Added strongly typed support to MapRoute
* Changed constructor generation to avoid confusing IoC containers
* Fixed issue with empty Content folder
* Fixed issue with abstract controller base classes

!!! 2.1.00 (06-29-2009):
* Added Html.BeginForm overloads that use the strongly typed pattern
* Added Url() helpers on static resources to increase flexibility
* Changed generated constants (view and action names, static files) to be readonly strings
* Fixed null ref exception in Solution Folder logic

!!! 2.0.04 (06-28-2009):
* Fixed issue with files and folders with names starting with a digit

!!! 2.0.03 (06-27-2009):
* Rework code element enumeration logic to work around a VS2010 issue. The template should now work with VS2010 beta 1!
* Reduced some redundancy in the generated code

!!! 2.0.02 (06-27-2009):
* Added ActionLink overloads that take object instead of dictionary (from both Html and Ajax)

!!! 2.0.01 (06-26-2009):
* Fixed issue with files and folders with invalid identifier characters (e.g. spaces, '-', '.')

!!! 2.0.00 (06-26-2009):
* Added support for refactoring in Action methods
* The T4 file automatically runs whenever you build, instead of being done manually
* Support for strongly typed links to static resources
* Fix: supports controllers that are in sub-folders of the Controllers folder and not directly in there
* Fix: works better with nested solution folder 
* Random other small fixes

!!! 1.0.xx (06-17-2009):
* the original based on [url:this post|http://blogs.msdn.com/davidebb/archive/2009/06/17/a-new-and-improved-asp-net-mvc-t4-template.aspx]



To use T4MVC, simply drop T4MVC.tt and T4MVC.settings.t4 at the root of your MVC project.

For more information, please see comment at the top of T4MVC.tt
