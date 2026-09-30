<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewAllProducts.aspx.cs" Inherits="Project_1.ViewAllProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Page Header -->
    <div class="container-fluid page-header py-5">
        <h1 class="text-center text-white display-6">Our Products</h1>
        <ol class="breadcrumb justify-content-center mb-0">
            <li class="breadcrumb-item">
                <a href="UserHome.aspx">Home</a>
            </li>
            <li class="breadcrumb-item active text-white">
                Products
            </li>
        </ol>
    </div>

    <!-- Products Section -->
    <div class="container-fluid py-5">
        <div class="container py-5">

            <!-- Top Toolbar -->
            <div class="d-flex justify-content-between align-items-center mb-4">

                <a href="UserHome.aspx"
                   class="btn btn-outline-primary rounded-pill px-4">
                    <i class="fas fa-arrow-left me-2"></i>
                    Back to Categories
                </a>

                <span class="text-muted">
                    Click any product image to view details and buy
                </span>

            </div>

            <!-- Products DataList -->
            <div class="d-flex justify-content-center">

                <asp:DataList ID="dlProducts"
                    runat="server"
                    RepeatColumns="3"
                    RepeatDirection="Horizontal"
                    CellPadding="15">

                    <ItemTemplate>

                        <div class="card border-0 shadow-sm rounded-3 text-center p-3 m-2"
                             style="width:320px; background:#fff;">

                            <!-- Product Image -->
                            <div class="overflow-hidden rounded mb-3 text-center">

                                <asp:ImageButton
                                    ID="imgBtnProduct"
                                    runat="server"
                                    ImageUrl='<%# Eval("Prod_Image") %>'
                                    CommandArgument='<%# Eval("Prod_Id") %>'
                                    OnCommand="imgBtnProduct_Command"
                                    CssClass="img-fluid rounded"
                                    Style="height:220px; width:100%; object-fit:cover;"
                                    AlternateText='<%# Eval("Prod_Name") %>' />

                            </div>

                            <!-- Product Name -->
                            <h4 class="text-dark fw-bold mb-1">

                                <asp:Label
                                    ID="lblProdName"
                                    runat="server"
                                    Text='<%# Eval("Prod_Name") %>'>
                                </asp:Label>

                            </h4>

                            <!-- Product Price -->
                            <p class="text-primary fs-5 fw-bold mb-2">

                                ₹<asp:Label
                                    ID="lblProdPrice"
                                    runat="server"
                                    Text='<%# Eval("Prod_price") %>'>
                                </asp:Label>

                                / kg

                            </p>

                            <!-- Product Description -->
                            <p class="text-muted small mb-0">

                                <asp:Label
                                    ID="lblProdDesc"
                                    runat="server"
                                    Text='<%# Eval("Prod_Description") %>'>
                                </asp:Label>

                            </p>

                        </div>

                    </ItemTemplate>

                </asp:DataList>

            </div>

        </div>
    </div>

</asp:Content>
