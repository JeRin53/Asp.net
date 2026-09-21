<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="Project_1.AddCategory" %>

<!DOCTYPE html>
<html lang="en">

    <head runat="server">
        <meta charset="utf-8">
        <title>Add Category - Fruitables Admin</title>
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
                                <a href="addcategory.aspx" class="nav-item nav-link active">Add Category</a>
                                <a href="addproduct.aspx" class="nav-item nav-link">Add Product</a>
                                <a href="login.aspx" class="nav-item nav-link">Sign Out</a>
                            </div>
                        </div>
                    </nav>
                </div>
            </div>

            <!-- Page Header -->
            <div class="container-fluid page-header py-5">
                <h1 class="text-center text-white display-6">Add New Category</h1>
                <ol class="breadcrumb justify-content-center mb-0">
                    <li class="breadcrumb-item"><a href="AdminHome.aspx">Admin Home</a></li>
                    <li class="breadcrumb-item active text-white">Add Category</li>
                </ol>
            </div>

            <!-- Form Section -->
            <div class="container-fluid py-5">
                <div class="container py-5">
                    <div class="row justify-content-center">
                        <div class="col-lg-8 col-md-10">

                            <div class="auth-card">
                                <div class="auth-card-header" style="background: linear-gradient(135deg, #81c408 0%, #45595b 100%);">
                                    <h3 class="text-white mb-1"><i class="fas fa-folder-plus me-2"></i>Add Category</h3>
                                    <p class="text-white-50 mb-0">Insert records into dbo.Category_tab</p>
                                </div>
                                <div class="auth-card-body p-4 p-md-5">

                                    <!-- Status Message Label -->
                                    <asp:Label ID="Label1" runat="server" CssClass="d-block mb-4 fw-bold text-center"></asp:Label>

                                    <div class="row g-3">
                                        
                                        <!-- Cat_Name (TextBox1) -->
                                        <div class="col-md-12">
                                            <label for="TextBox1" class="form-label fw-bold text-dark">Category Name <span class="text-danger">*</span></label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-tag input-icon"></i>
                                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control py-3" placeholder="e.g. Fresh Organic Fruits"></asp:TextBox>
                                            </div>
                                        </div>

                                        <!-- Cat_Description (TextBox2) -->
                                        <div class="col-12">
                                            <label for="TextBox2" class="form-label fw-bold text-dark">Category Description <span class="text-danger">*</span></label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-align-left input-icon" style="top: 25px;"></i>
                                                <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Rows="4" CssClass="form-control py-2 ps-5" placeholder="Enter Category Description"></asp:TextBox>
                                            </div>
                                        </div>

                                        <!-- Cat_Image (FileUpload1) -->
                                        <div class="col-md-12">
                                            <label for="FileUpload1" class="form-label fw-bold text-dark">Category Image <span class="text-danger">*</span></label>
                                            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control py-3" />
                                        </div>

                                        <!-- Cat_Status (DropDownList1) -->
                                        <div class="col-md-12">
                                            <label for="DropDownList1" class="form-label fw-bold text-dark">Category Status <span class="text-danger">*</span></label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-toggle-on input-icon"></i>
                                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-select py-3">
                                                    <asp:ListItem Value="Available" Selected="True">Available</asp:ListItem>
                                                    <asp:ListItem Value="Inactive">Inactive</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </div>

                                    </div>

                                    <!-- Submit Button (Button1) -->
                                    <div class="row g-3 mt-4">
                                        <div class="col-md-8">
                                            <asp:Button ID="Button1" runat="server" Text="Save Category" CssClass="btn btn-primary text-white w-100 py-3 rounded-3 fw-bold shadow-sm" OnClick="Button1_Click" />
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

