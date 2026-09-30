<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="Project_1.ViewCart" %>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .cart-card {
            background: #ffffff;
            border-radius: 15px;
            padding: 30px;
            box-shadow: 0 4px 15px rgba(0,0,0,0.08);
            margin-top: 30px;
            margin-bottom: 50px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Single Page Header start -->
    <div class="container-fluid page-header py-5">
        <h1 class="text-center text-white display-6">Shopping Cart</h1>
        <ol class="breadcrumb justify-content-center mb-0">
            <li class="breadcrumb-item"><a href="UserHome.aspx">Home</a></li>
            <li class="breadcrumb-item active text-white">Cart Items</li>
        </ol>
    </div>
    <!-- Single Page Header End -->

    <!-- Cart Items Section Start -->
    <div class="container-fluid py-5">
        <div class="container py-5">
            <div class="cart-card">
                
                <div class="d-flex justify-content-between align-items-center mb-4 flex-wrap gap-2">
                    <h3 class="text-dark fw-bold mb-0">
                        <i class="fas fa-shopping-cart text-primary me-2"></i>My Cart Items
                    </h3>
                    <asp:Button ID="btnContinueShopping" runat="server" Text="Continue Shopping" CssClass="btn btn-outline-primary rounded-pill px-4 fw-bold" OnClick="btnContinueShopping_Click" />
                </div>

                <!-- Cart GridView -->
                <div class="table-responsive">
                    <asp:GridView ID="gvCart" runat="server" AutoGenerateColumns="False" 
                        DataKeyNames="Cart_Id"
                        OnRowEditing="gvCart_RowEditing"
                        OnRowCancelingEdit="gvCart_RowCancelingEdit"
                        OnRowUpdating="gvCart_RowUpdating"
                        OnRowDeleting="gvCart_RowDeleting"
                        CssClass="table table-hover table-bordered align-middle text-center mb-0 bg-white"
                        HeaderStyle-CssClass="table-light text-dark fw-bold"
                        EmptyDataText="Your cart is currently empty.">
                        <Columns>
                            
                            <%-- Product Image --%>
                            <asp:TemplateField HeaderText="Product Image" ItemStyle-Width="120px">
                                <ItemTemplate>
                                    <asp:Image ID="imgCartProduct" runat="server" ImageUrl='<%# Eval("Prod_Image") %>' Width="75px" Height="75px" CssClass="img-thumbnail rounded shadow-sm" />
                                </ItemTemplate>
                            </asp:TemplateField>

                            <%-- Product Name --%>
                            <asp:BoundField DataField="Prod_Name" HeaderText="Product Name" ReadOnly="True" ItemStyle-Font-Bold="True" ItemStyle-CssClass="text-dark fs-5" />

                            <%-- Quantity --%>
                            <asp:TemplateField HeaderText="Quantity (kg)" ItemStyle-Width="140px">
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("Cart_Quantity") %>' CssClass="fw-bold"></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("Cart_Quantity") %>' CssClass="form-control form-control-sm mx-auto text-center" Style="max-width: 90px;"></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>

                            <%-- Subtotal --%>
                            <asp:TemplateField HeaderText="Subtotal" ItemStyle-Width="160px">
                                <ItemTemplate>
                                    <span class="text-primary fw-bold fs-5">$<%# Eval("Cart_Subtotal") %></span>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <%-- Actions (Edit / Delete) --%>
                            <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" HeaderText="Actions" />

                        </Columns>
                    </asp:GridView>
                </div>
                <!-- Bottom Action Controls -->
                <div class="d-flex justify-content-between align-items-center mt-4 flex-wrap gap-2">
                    <asp:Button ID="btnContinueShopping2" runat="server" Text="← Continue Shopping" CssClass="btn btn-outline-secondary rounded-pill px-4 fw-bold" OnClick="btnContinueShopping_Click" />
                    <asp:Button ID="btnConfirm" runat="server" Text="Confirm Order →" CssClass="btn btn-primary text-white rounded-pill px-5 py-2 fw-bold shadow-sm" OnClick="btnConfirm_Click" />
                </div>
                <asp:Label ID="lblCartMessage" runat="server" CssClass="d-block mt-3 text-center fw-bold text-danger"></asp:Label>
            </div>
        </div>
    </div>
    <!-- Cart Items Section End -->

</asp:Content>

