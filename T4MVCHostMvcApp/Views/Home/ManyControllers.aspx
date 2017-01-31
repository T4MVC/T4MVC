<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ContentPlaceHolderID="TitleContent" runat="server">
    Many controllers list
</asp:Content>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<%
    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
    long elapsedMs = 0;
    int numElems = 20;
%>

 
   <table>
    <tr>
        <th>Column 1</th>
        <th>Column 2</th>
        <th>Column 3</th>
        <th>Column 4</th>
        <th>Column 5</th>
        <th>Column 6</th>
    </tr>

    <% sw.Start(); %>
<%
    for( int i = 0; i < numElems; ++i )
    {
%>
        <tr>
            <td><%= Html.ActionLink( "Index " + i, MVC.Ctrl81.Index() ) %></td>
            <td><%= Html.ActionLink( "Details " + i, MVC.Ctrl81.Details( i ) ) %></td>
            <td><%= Html.ActionLink( "Create " + i, MVC.Ctrl81.Create() ) %></td>
            <td><%= Html.ActionLink( "Edit " + i, MVC.Ctrl81.Edit( i ) ) %></td>
            <td><%= Html.ActionLink( "Delete " + i, MVC.Ctrl81.Delete( i ) ) %></td>
            <td><%= Html.ActionLink( "Other " + i, MVC.Ctrl81.OtherAction( i ) ) %></td>
        </tr>
<%
    }
    {
        elapsedMs = sw.ElapsedMilliseconds;
    }
%>
</table>
<p>
    Elapsed Html.ActionLink rendering time for Ctrl81: <%= elapsedMs %> ms
</p>

<table>
    <tr>
        <th>Column 1</th>
        <th>Column 2</th>
        <th>Column 3</th>
        <th>Column 4</th>
        <th>Column 5</th>
        <th>Column 6</th>
    </tr>

<%
        sw.Restart(); 
    for( int i = 0; i < numElems; ++i )
    {
%>
        <tr>
            <td><%= Html.AutoNamedRouteLink( "Index " + i, MVC.Ctrl81.Index() ) %></td>
            <td><%= Html.AutoNamedRouteLink( "Details " + i, MVC.Ctrl81.Details( i ) ) %></td>
            <td><%= Html.AutoNamedRouteLink( "Create " + i, MVC.Ctrl81.Create() ) %></td>
            <td><%= Html.AutoNamedRouteLink( "Edit " + i, MVC.Ctrl81.Edit( i ) ) %></td>
            <td><%= Html.AutoNamedRouteLink( "Delete " + i, MVC.Ctrl81.Delete( i ) ) %></td>
            <td><%= Html.AutoNamedRouteLink( "Other " + i, MVC.Ctrl81.OtherAction( i ) ) %></td>
        </tr>
<%
   }
    {
        elapsedMs = sw.ElapsedMilliseconds;
    }
%>
</table>
<p>
    Elapsed Html.AutoNamedRouteLink rendering time for Ctrl81: <%= elapsedMs %> ms
</p>
</asp:Content>
