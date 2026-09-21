<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewBill.aspx.cs" Inherits="Project_1.ViewBill" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <!-- Single Page Header start -->
    <div class="container-fluid page-header py-5 no-print">
        <h1 class="text-center text-white display-6">Order Invoice</h1>
        <ol class="breadcrumb justify-content-center mb-0">
            <li class="breadcrumb-item"><a href="UserHome.aspx">Home</a></li>
            <li class="breadcrumb-item"><a href="viewcart.aspx">Cart</a></li>
            <li class="breadcrumb-item active text-white">Bill Summary</li>
        </ol>
    </div>
    <!-- Single Page Header End -->

    <!-- Bill Details Section Start -->
    <div class="container-fluid py-4">
        <div class="container py-3">
            <div class="row justify-content-center">
                <div class="col-lg-10">
                    
                    <div class="invoice-card">
                        
                        <!-- Invoice Header -->
                        <div class="invoice-header d-flex justify-content-between align-items-center flex-wrap gap-2">
                            <div>
                                <h2 class="text-primary fw-bold mb-1"><i class="fas fa-apple-alt me-2"></i>Fruitables</h2>
                                <p class="text-muted mb-0">Fresh & Organic Grocery Store</p>
                            </div>
                            <div class="text-end">
                                <h4 class="text-dark fw-bold mb-1">INVOICE BILL</h4>
                                <p class="text-muted mb-1">Bill No: <asp:Label ID="lblBillId" runat="server" CssClass="fw-bold text-dark"></asp:Label></p>
                                <p class="text-muted mb-0">Date: <asp:Label ID="lblBillDate" runat="server" CssClass="fw-bold text-dark"></asp:Label></p>
                            </div>
                        </div>

                        <!-- Customer Details (Joined from User_tab) -->
                        <div class="info-box">
                            <h5 class="text-dark fw-bold mb-3"><i class="fas fa-user-check text-primary me-2"></i>Customer & Delivery Details</h5>
                            <div class="row">
                                <div class="col-md-6 mb-2">
                                    <span class="text-muted">Customer Name:</span>
                                    <asp:Label ID="lblUserName" runat="server" CssClass="fw-bold text-dark d-block fs-6"></asp:Label>
                                </div>
                                <div class="col-md-6 mb-2">
                                    <span class="text-muted">Phone Number:</span>
                                    <asp:Label ID="lblPhone" runat="server" CssClass="fw-bold text-dark d-block fs-6"></asp:Label>
                                </div>
                                <div class="col-md-6 mb-2">
                                    <span class="text-muted">Email Address:</span>
                                    <asp:Label ID="lblEmail" runat="server" CssClass="fw-bold text-dark d-block fs-6"></asp:Label>
                                </div>
                                <div class="col-md-6 mb-2">
                                    <span class="text-muted">Delivery Address:</span>
                                    <asp:Label ID="lblAddress" runat="server" CssClass="fw-bold text-dark d-block fs-6"></asp:Label>
                                </div>
                            </div>
                        </div>

                        <!-- Order Items Section (Joined from Order_tab & Product_tab) -->
                        <h5 class="text-dark fw-bold mb-3"><i class="fas fa-shopping-basket text-primary me-2"></i>Ordered Items</h5>
                        <div class="table-responsive mb-4">
                            <asp:GridView ID="gvBillItems" runat="server" AutoGenerateColumns="False" 
                                CssClass="table table-hover table-bordered align-middle text-center mb-0 bg-white"
                                HeaderStyle-CssClass="table-light text-dark fw-bold"
                                EmptyDataText="No items found for this order.">
                                <Columns>
                                    <%-- Product Image --%>
                                    <asp:TemplateField HeaderText="Product Image" ItemStyle-Width="100px">
                                        <ItemTemplate>
                                            <asp:Image ID="imgProd" runat="server" ImageUrl='<%# Eval("Prod_Image") %>' Width="60px" Height="60px" CssClass="img-thumbnail rounded shadow-sm" />
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <%-- Product Name --%>
                                    <asp:BoundField DataField="Prod_Name" HeaderText="Product Name" ItemStyle-Font-Bold="True" ItemStyle-CssClass="text-dark text-start ps-3" />

                                    <%-- Unit Price --%>
                                    <asp:TemplateField HeaderText="Unit Price" ItemStyle-Width="120px">
                                        <ItemTemplate>
                                            <span class="text-muted fw-bold">$<%# Eval("Prod_price") %></span>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <%-- Quantity --%>
                                    <asp:BoundField DataField="Ord_Quantity" HeaderText="Quantity (kg)" ItemStyle-Width="120px" ItemStyle-CssClass="fw-bold" />

                                    <%-- Subtotal --%>
                                    <asp:TemplateField HeaderText="Subtotal" ItemStyle-Width="140px">
                                        <ItemTemplate>
                                            <span class="text-dark fw-bold">$<%# Eval("Ord_Subtotal") %></span>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>

                        <!-- Bill Calculation & Grand Total (from Bill_tab) -->
                        <div class="row justify-content-end mb-4">
                            <div class="col-md-5">
                                <div class="total-box text-end">
                                    <div class="d-flex justify-content-between align-items-center mb-2">
                                        <span class="text-muted fw-bold">Order Status:</span>
                                        <span class="badge bg-success px-3 py-2">Confirmed / Ordered</span>
                                    </div>
                                    <hr class="my-2" />
                                    <div class="d-flex justify-content-between align-items-center">
                                        <h5 class="text-dark fw-bold mb-0">Grand Total:</h5>
                                        <asp:Label ID="lblGrandTotal" runat="server" CssClass="text-primary fw-bold fs-4"></asp:Label>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- Action Buttons -->
                        <div class="d-flex justify-content-between align-items-center flex-wrap gap-2 no-print pt-3 border-top">
                            <asp:Button ID="btnContinueShopping" runat="server" Text="← Continue Shopping" CssClass="btn btn-outline-primary rounded-pill px-4 fw-bold" OnClick="btnContinueShopping_Click" />
                            <div>
                                <button type="button" class="btn btn-secondary rounded-pill px-4 fw-bold me-2" onclick="window.print();">
                                    <i class="fas fa-print me-2"></i>Print Bill
                                </button>
                                <asp:Button ID="btnHome" runat="server" Text="Go to Home" CssClass="btn btn-primary text-white rounded-pill px-4 fw-bold" OnClick="btnHome_Click" />
                                <asp:Button ID="btnPayment" runat="server" Text="Pay now" CssClass="btn btn-primary text-white rounded-pill px-4 fw-bold" OnClick="btnPayment_Click" BackColor="Red" />
                            </div>
                        </div>

                    </div>

                </div>
            </div>
        </div>
    </div>
    <!-- Bill Details Section End -->

</asp:Content>
