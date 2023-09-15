<%@ Page Title="" Language="C#" MasterPageFile="~/Ecommerce.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ecommerce.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <asp:Repeater ID="RepeaterCol" runat="server" ItemType="Ecommerce.Models.Product">
            <ItemTemplate>
                <div class="col-lg-4 col-12">
                    <div class="my-card border bg-secondary border-light rounded-1 mt-2 shadow-lg " style="--bs-bg-opacity: .5;">
                        <div class="img-cont d-flex justify-content-evenly mt-2 shadow-lg">
                            <asp:Image ID="Image1" runat="server" Width="200" ImageUrl='<%#Item.Image %>' CssClass="bd-placeholder-img rounded-circle border border-light" />
                        </div>
                        <h2 class="fw-normal"><%#Item.Name %></h2>
                        <p><%#String.Format("{0:0.00 €}", Item.Price) %></p>
                        <p><a class="btn btn-outline-warning" href="Details.aspx?index=<%#Item.ProductId %>">Vedi dettagli »</a></p>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
       
    </div>
</asp:Content>
