<%@ Page Title="" Language="C#" MasterPageFile="~/Ecommerce.Master" AutoEventWireup="true" CodeBehind="YourCart.aspx.cs" Inherits="Ecommerce.YourCart" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-12">
            <asp:GridView ID="GridView1" runat="server" ItemType="Ecommerce.Models.Product" AutoGenerateColumns="false" CssClass="table mt-4 table-success">
                <Columns>
                    <asp:TemplateField ControlStyle-CssClass="text-light">

                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" ImageUrl="<%#Item.Image %>" Width="150" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <Columns>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <strong>Nome</strong>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <%#Item.Name %>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <Columns>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <strong>Prezzo</strong>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <%#String.Format("{0:0.00 €}", Item.Price) %>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <Columns>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <strong>Azioni</strong>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Button ID="DeleteFrom" runat="server" Text="Rimuovi" CssClass="btn btn-danger" CommandName="Remove" CommandArgument="<%#Item.CartIndex %>" OnCommand="DeleteFrom_Command" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>


            <p id="prova" runat="server"></p>
        </div>
        <div class="col-12">
            <div id="total" runat="server"></div>
            <div id="message" runat="server"></div>
        </div>
        <div class="col-12 mt-2">
                        <div class="d-flex justify-content-center gap-2">
                <asp:Button ID="Button1" runat="server" Text="Ordina" CssClass="btn btn-success" />
                <asp:Button ID="Button2" runat="server" Text="Svuota" CssClass="btn btn-danger" OnClick="Button2_Click" />
            </div>
        </div>
    </div>
</asp:Content>
