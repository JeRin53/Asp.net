<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewSingleProduct.aspx.cs" Inherits="Project_1.ViewSingleProduct" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <!-- Single Page Header start -->
            <div class="container-fluid page-header py-5">
                <h1 class="text-center text-white display-6">Product Details</h1>
                <ol class="breadcrumb justify-content-center mb-0">
                    <li class="breadcrumb-item"><a href="UserHome.aspx">Home</a></li>
                    <li class="breadcrumb-item"><a href="viewallproducts.aspx">Products</a></li>
                    <li class="breadcrumb-item active text-white">Details</li>
                </ol>
            </div>
            <!-- Single Page Header End -->

            <!-- Single Product Section Start -->
            <div class="container-fluid py-5">
                <div class="container py-5">
                    
                    <!-- Navigation back bar -->
                    <div class="mb-4">
                        <a href="viewallproducts.aspx" class="btn btn-outline-primary rounded-pill px-4">
                            <i class="fas fa-arrow-left me-2"></i>Back to All Products
                        </a>
                    </div>

                    <div class="card border-0 shadow rounded-4 overflow-hidden p-4 p-md-5 bg-white">
                        <div class="row g-5 align-items-center">
                            
                            <!-- Product Image -->
                            <div class="col-lg-5 text-center">
                                <div class="border rounded-4 p-3 bg-light d-inline-block shadow-sm">
                                    <asp:Image ID="imgProduct" runat="server" CssClass="img-fluid rounded-3" Style="max-height: 380px; width: 100%; object-fit: cover;" />
                                </div>
                            </div>

                            <!-- Product Details & Add to Cart -->
                            <div class="col-lg-7">
                                
                                <span class="badge bg-secondary text-dark px-3 py-2 rounded-pill mb-2">Organic Selection</span>
                                
                                <!-- Product Name -->
                                <h2 class="display-6 fw-bold text-dark mb-2">
                                    <asp:Label ID="lblProductName" runat="server"></asp:Label>
                                </h2>

                                <!-- Product Price -->
                                <div class="d-flex align-items-baseline mb-3">
                                    <h3 class="text-primary fw-bold mb-0 me-3">
                                        $<asp:Label ID="lblProductPrice" runat="server"></asp:Label>
                                    </h3>
                                    <span class="text-muted fs-6">/ kilogram</span>
                                    <span class="ms-4">
                                        <asp:Label ID="lblProductStock" runat="server" CssClass="badge bg-success px-3 py-2"></asp:Label>
                                    </span>
                                </div>

                                <!-- Description -->
                                <div class="mb-4">
                                    <h6 class="fw-bold text-dark mb-2">Product Description:</h6>
                                    <p class="text-muted lead fs-6">
                                        <asp:Label ID="lblProductDescription" runat="server"></asp:Label>
                                    </p>
                                </div>

                                <hr class="my-4" />

                                <!-- Quantity Dropdown Selection -->
                                <div class="row align-items-center g-3 mb-4">
                                    <div class="col-auto">
                                        <label for="ddlQuantity" class="form-label fw-bold text-dark mb-0 fs-5">
                                            Select Quantity (kg):
                                        </label>
                                    </div>
                                    <div class="col-auto" style="width: 130px;">
                                        <asp:DropDownList ID="ddlQuantity" runat="server" CssClass="form-select form-select-lg py-2">
                                        </asp:DropDownList>
                                    </div>
                                </div>

                                <!-- Action Buttons -->
                                <div class="d-flex flex-wrap gap-3 align-items-center mt-4">
                                    <asp:Button ID="btnAddToCart" runat="server" Text="Add to Cart" CssClass="btn btn-primary text-white py-3 px-4 rounded-pill fw-bold shadow" OnClick="btnAddToCart_Click" />
                                    <asp:Button ID="btnContinue" runat="server" Text="Continue Shopping" CssClass="btn btn-outline-secondary py-3 px-4 rounded-pill fw-bold" OnClick="btnContinue_Click" />
                                    <asp:Button ID="btnViewCart" runat="server" Text="View Cart" CssClass="btn btn-warning text-dark py-3 px-4 rounded-pill fw-bold shadow-sm" OnClick="btnViewCart_Click" />
                                </div>

                                <!-- Cart Status Message -->
                                <div class="mt-3">
                                    <asp:Label ID="lblCartMessage" runat="server" CssClass="d-block fw-bold fs-5"></asp:Label>
                                </div>

                            </div>
                        </div>
                    </div>

                </div>
            </div>
            <!-- Single Product Section End -->
</asp:Content>
