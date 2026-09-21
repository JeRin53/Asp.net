<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="Project_1.AddProduct" %>

<!DOCTYPE html>
<html lang="en">

    <head runat="server">
        <meta charset="utf-8">
        <title>Add Product - Fruitables Admin</title>
        <meta content="width=device-width, initial-scale=1.0" name="viewport">
        <!-- Google Fonts & Bootstrap Stylesheets -->
        <link rel="preconnect" href="https://fonts.googleapis.com">
        <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
        <link href="https://fonts.googleapis.com/css2?family=Open+Sans:wght@400;600&family=Raleway:wght@600;800&display=swap" rel="stylesheet"> 
        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.15.4/css/all.css"/>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.4.1/font/bootstrap-icons.css" rel="stylesheet">
        <link href="css/bootstrap.min.css" rel="stylesheet">
        <link href="css/style.css" rel="stylesheet">
    </head>

    <body>
        <form id="form1" runat="server" enctype="multipart/form-data">

            <!-- Navbar -->
            <div class="container-fluid fixed-top">
                <div class="container px-0">
                    <nav class="navbar navbar-light bg-white navbar-expand-xl">
                        <a href="index.html" class="navbar-brand"><h1 class="text-primary display-6">Fruitables</h1></a>
                        <div class="collapse navbar-collapse bg-white">
                            <div class="navbar-nav mx-auto">
                                <a href="AdminHome.aspx" class="nav-item nav-link">Admin Home</a>
                                <a href="addcategory.aspx" class="nav-item nav-link">Add Category</a>
                                <a href="addproduct.aspx" class="nav-item nav-link active">Add Product</a>
                                <a href="login.aspx" class="nav-item nav-link">Sign Out</a>
                            </div>
                        </div>
                    </nav>
                </div>
            </div>

            <!-- Page Header -->
            <div class="container-fluid page-header py-5">
                <h1 class="text-center text-white display-6">Add New Product</h1>
                <ol class="breadcrumb justify-content-center mb-0">
                    <li class="breadcrumb-item"><a href="AdminHome.aspx">Admin Home</a></li>
                    <li class="breadcrumb-item active text-white">Add Product</li>
                </ol>
            </div>

            <!-- Form Section -->
            <div class="container-fluid py-5">
                <div class="container py-5">
                    <div class="row justify-content-center">
                        <div class="col-lg-8 col-md-10">

                            <div class="auth-card">
                                <div class="auth-card-header" style="background: linear-gradient(135deg, #ffb524 0%, #45595b 100%);">
                                    <h3 class="text-white mb-1"><i class="fas fa-plus-circle me-2"></i>Add New Product</h3>
                                    <p class="text-white-50 mb-0">Insert item details into dbo.Product_tab</p>
                                </div>
                                <div class="auth-card-body p-4 p-md-5">

                                    <!-- Status Message Label -->
                                    <asp:Label ID="Label1" runat="server" CssClass="d-block mb-4 fw-bold text-center"></asp:Label>

                                    <div class="row g-3">
                                        
                                        <!-- Prod_Name (TextBox1) -->
                                        <div class="col-md-12">
                                            <label for="TextBox1" class="form-label fw-bold text-dark">Product Name <span class="text-danger">*</span></label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-carrot input-icon"></i>
                                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control py-3" placeholder="e.g. Organic Gala Apples"></asp:TextBox>
                                            </div>
                                        </div>

                                        <!-- Cat_Id (DropDownList1) -->
                                        <div class="col-md-6">
                                            <label for="DropDownList1" class="form-label fw-bold text-dark">Category (Cat_Id) <span class="text-danger">*</span></label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-th-large input-icon"></i>
                                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-select py-3" AutoPostBack="True">
                                                </asp:DropDownList>
                                            </div>
                                        </div>

                                        <!-- Prod_price (TextBox2) -->
                                        <div class="col-md-6">
                                            <label for="TextBox2" class="form-label fw-bold text-dark">Price ($ / kg) <span class="text-danger">*</span></label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-dollar-sign input-icon"></i>
                                                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control py-3" placeholder="e.g. 4.99"></asp:TextBox>
                                            </div>
                                        </div>

                                        <!-- Prod_Stock (TextBox4) -->
                                        <div class="col-md-6">
                                            <label for="TextBox4" class="form-label fw-bold text-dark">Available Stock <span class="text-danger">*</span></label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-boxes input-icon"></i>
                                                <asp:TextBox ID="TextBox4" runat="server" TextMode="Number" CssClass="form-control py-3" placeholder="e.g. 100"></asp:TextBox>
                                            </div>
                                        </div>

                                        <!-- Prod_Status (DropDownList2) -->
                                        <div class="col-md-6">
                                            <label for="DropDownList2" class="form-label fw-bold text-dark">Product Status <span class="text-danger">*</span></label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-toggle-on input-icon"></i>
                                                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-select py-3">
                                                    <asp:ListItem Value="Available" Selected="True">Available</asp:ListItem>
                                                    <asp:ListItem Value="Out of Stock">Out of Stock</asp:ListItem>
                                                    <asp:ListItem Value="Discontinued">Discontinued</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </div>

                                        <!-- Prod_Image (FileUpload1) -->
                                        <div class="col-md-12">
                                            <label for="FileUpload1" class="form-label fw-bold text-dark">Product Image <span class="text-danger">*</span></label>
                                            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control py-3" />
                                        </div>

                                        <!-- Prod_Description (TextBox3) -->
                                        <div class="col-12">
                                            <label for="TextBox3" class="form-label fw-bold text-dark">Product Description <span class="text-danger">*</span></label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-align-left input-icon" style="top: 25px;"></i>
                                                <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Rows="4" CssClass="form-control py-2 ps-5" placeholder="Enter full details of the product..."></asp:TextBox>
                                            </div>
                                        </div>

                                    </div>

                                    <!-- Submit Button (Button1) -->
                                    <div class="row g-3 mt-4">
                                        <div class="col-md-8">
                                            <asp:Button ID="Button1" runat="server" Text="Add Product to Store" CssClass="btn btn-primary text-white w-100 py-3 rounded-3 fw-bold shadow-sm" OnClick="Button1_Click" />
                                        </div>
                                        <div class="col-md-4">
                                            <a href="AdminHome.aspx" class="btn btn-outline-secondary w-100 py-3 rounded-3">Cancel</a>
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </form>
    </body>
</html>

