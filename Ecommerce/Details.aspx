<%@ Page Title="" Language="C#" MasterPageFile="~/Ecommerce.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Ecommerce.Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-12">
            <div class="card bg-secondary text-light border-light d-flex" style="--bs-bg-opacity: .5;">
                <div class="d-flex flex-column align-items-center flex-md-row">
                    <asp:Image ID="productImage" CssClass="img-fluid w-50" runat="server" />

                    <div class="card-body d-flex flex-column align-items-center justify-content-md-between">
                        <h5 id="productName" runat="server" class="card-title "></h5>
                        <p id="description" runat="server" class="card-text mt-md-3"></p>
                        <asp:Button ID="AddToCart" runat="server" Text="Aggiungi" CssClass="btn btn-success w-50 mt-md-4" OnClick="AddToCart_Click" />
                        <div id="alert" runat="server" class="alert alert-success alert-dismissible fade show mt-5" role="alert">
                            <strong>Congratulazioni!</strong> Prodotto aggiunto correttamente
                        <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close" runat="server" id="btn"></button>
                            
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
