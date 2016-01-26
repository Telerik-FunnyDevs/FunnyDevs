<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="FunnyDevs.Web.Profile.ProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%: Context.User.Identity.GetUserName()  %></h1>
    <img src="http://www.popsci.com/sites/popsci.com/files/bill_gates_july_2014.jpg" width="30px" height="30px"/>
    <h2>About Me</h2>
    <p>Whatever at Whatever Whatever at Whatever Whatever at Whatever Whatever at Whatever Whatever at Whatever Whatever at Whatever Whatever at Whatever </p>
    <div>
        <h2>Events</h2>
        <table class="table table-striped table-hover">
            <tr>
                <th class="text-center">Name</th>
                <th class="text-center">Date</th>
            </tr>
            <tr>
                <td class="text-center">Whatever</td>
                <td class="text-center">Never</td>
            </tr>
        </table>
    </div>
    <div>
        <h2>Friends</h2>
        <table class="table table-striped table-hover">
            <tr>
                <th class="text-center">Name</th>
                <th class="text-center">Sure</th>
            </tr>
            <tr>
                <td class="text-center">Whatever</td>
                <td class="text-center">Thing</td>
            </tr>
        </table>
    </div>
</asp:Content>
