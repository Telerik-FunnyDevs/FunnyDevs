<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="All.aspx.cs" Inherits="FunnyDevs.Web.Events.All" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Events</h1>
    <div class="row text-center">
                <div class="col-md-8 col-md-offset-2">
                    <div class="panel panel-info">
                        <div class="panel-heading text-center"><%: Title %></div>
                        <asp:ListView ID="ViewAllEvents" runat="server"
                            SelectMethod="GridViewAll_GetData"
                            ItemType="FunnyDevs.Data.Models.Event"
                            AllowPaging="True"
                            EnableSortingAndPagingCallback="True"
                            AllowSorting="True"
                            DataKeyNames="Id"
                            AutoGenerateColumns="false">
                            <LayoutTemplate>
                                <table class="table table-striped table-hover">
                                    <tr>
                                        <th class="text-center">
                                            <asp:Literal Text="Image" runat="server" />
                                        </th>
                                        <th class="text-center">
                                            <asp:LinkButton Text="Name" runat="server"
                                                ID="SortByModel"
                                                CommandName="Sort"
                                                CommandArgument="Description" />
                                        </th>
                                        <th class="text-center">
                                            <asp:LinkButton Text="Description" runat="server"
                                                ID="SortByCarType"
                                                CommandName="Sort"
                                                CommandArgument="CarType" />
                                        </th>
                                        <th class="text-center">
                                            <asp:LinkButton Text="Location" runat="server"
                                                ID="SortByFuelEconomy"
                                                CommandName="Sort"
                                                CommandArgument="FuelEconomy" />
                                        </th>
                                    </tr>
                                    <asp:PlaceHolder ID="itemplaceholder" runat="server" />
                                </table>
                            </LayoutTemplate>

                            <ItemTemplate runat="server">
                                <tr>
                                    <td>
                                        <asp:Image ImageUrl='<%#: Item.Tittle %>' Width="50px" runat="server" />
                                    </td>
                                    <td>
                                        <asp:Label Text='<%#: Item.Description %>' runat="server" />
                                    </td>
                                    <td>
                                        <asp:Label Text='<%#: Item.Location %>' runat="server" />
                                    </td>
                                   <!-- <td>
                                        <asp:HyperLink NavigateUrl='<%#: string.Format("~/Cars/CarDetails.aspx?id={0}", Item.Id) %>' runat="server"> Details
                                        </asp:HyperLink>
                                    </td> -->
                                </tr>
                            </ItemTemplate>

                            <EmptyDataTemplate runat="server">
                                <h5 class="content-empty">No items available</h5>
                            </EmptyDataTemplate>
                        </asp:ListView>
                    </div>
                </div>
            </div>
</asp:Content>
