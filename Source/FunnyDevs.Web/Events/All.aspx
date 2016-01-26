<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="All.aspx.cs" Inherits="FunnyDevs.Web.Events.All" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Events</h1>
    <asp:LoginView runat="server" ViewStateMode="Disabled">
        <LoggedInTemplate>
            <div class="row text-center">
                <div class="col-md-8 col-md-offset-2">
                    <h2>You can: <a runat="server" href="~/Events/Add" class="btn btn-lg btn-success">Add Event</a> </h2>
                </div>
            </div>
        </LoggedInTemplate>
    </asp:LoginView>
    <br />
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
                                    <asp:Literal Text="Tittle" runat="server" />
                                </th>
                                <th class="text-center">
                                    <asp:LinkButton Text="Location" runat="server"
                                        ID="LocationSort"
                                        CommandName="Sort"
                                        CommandArgument="Location" />
                                </th>
                                <th class="text-center">
                                    <asp:LinkButton Text="Description" runat="server"
                                        ID="DescriptionSort"
                                        CommandName="Sort"
                                        CommandArgument="Description" />
                                </th>
                                <th class="text-center">
                                    <asp:LinkButton Text="Date" runat="server"
                                        ID="DateSort"
                                        CommandName="Sort"
                                        CommandArgument="Dae" />
                                </th>
                            </tr>
                            <asp:PlaceHolder ID="itemplaceholder" runat="server" />
                        </table>
                    </LayoutTemplate>

                    <ItemTemplate runat="server">
                        <tr>
                            <td>
                                <asp:Label Text='<%#: Item.Tittle %>' Width="50px" runat="server" />
                            </td>
                            <td>
                                <asp:Label Text='<%#: Item.Location %>' runat="server" />
                            </td>
                            <td>
                                <asp:Label Text='<%#: Item.Description %>' runat="server" />
                            </td>
                            <td>
                                <asp:Label Text='<%#: Item.Date %>' runat="server" />
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
