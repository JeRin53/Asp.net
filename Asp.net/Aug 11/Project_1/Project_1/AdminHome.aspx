<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="Project_1.AdminHome" %>

<!DOCTYPE html>
<html lang="en">

    <head runat="server">
        <meta charset="utf-8">
        <title>Admin Home - Fruitables</title>
        <meta content="width=device-width, initial-scale=1.0" name="viewport">

        <!-- Google Web Fonts -->
        <link rel="preconnect" href="https://fonts.googleapis.com">
        <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
        <link href="https://fonts.googleapis.com/css2?family=Open+Sans:wght@400;600&family=Raleway:wght@600;800&display=swap" rel="stylesheet"> 

        <!-- Icon Font Stylesheet -->
        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.15.4/css/all.css"/>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.4.1/font/bootstrap-icons.css" rel="stylesheet">

        <!-- Customized Bootstrap Stylesheet -->
        <link href="css/bootstrap.min.css" rel="stylesheet">

        <!-- Template Stylesheet -->
        <link href="css/style.css" rel="stylesheet">
    </head>

    <body>
        <form id="form1" runat="server">

            <!-- Navbar start -->
            <div class="container-fluid fixed-top">
                <div class="container px-0">
                    <nav class="navbar navbar-light bg-white navbar-expand-xl">
                        <a href="index.html" class="navbar-brand"><h1 class="text-primary display-6">Fruitables</h1></a>
                        <button class="navbar-toggler py-2 px-3" type="button" data-bs-toggle="collapse" data-bs-target="#navbarCollapse">
                            <span class="fa fa-bars text-primary"></span>
                        </button>
                        <div class="collapse navbar-collapse bg-white" id="navbarCollapse">
                            <div class="navbar-nav mx-auto">
                                <a href="AdminHome.aspx" class="nav-item nav-link active">Admin Home</a>
                                <a href="addcategory.aspx" class="nav-item nav-link">Add Category</a>
                                <a href="EditCategory.aspx" class="nav-item nav-link">Edit Category</a>
                                <a href="addproduct.aspx" class="nav-item nav-link">Add Product</a>
                                <a href="EditProduct.aspx" class="nav-item nav-link">Edit Product</a>
                                <a href="login.aspx" class="nav-item nav-link">Sign Out</a>
                            </div>
                        </div>
                    </nav>
                </div>
            </div>
            <!-- Navbar End -->

            <!-- Single Page Header start -->
            <div class="container-fluid page-header py-5">
                <h1 class="text-center text-white display-6">Admin Control Panel</h1>
                <ol class="breadcrumb justify-content-center mb-0">
                    <li class="breadcrumb-item"><a href="AdminHome.aspx">Home</a></li>
                    <li class="breadcrumb-item active text-white">Admin Home</li>
                </ol>
            </div>
            <!-- Single Page Header End -->

            <!-- Admin Home Content Start -->
            <div class="container-fluid py-5">
                <div class="container py-5">
                    
                    <!-- Quick Action Toolbar -->
                    <div class="card shadow-sm border-0 rounded-3 mb-5 p-4 bg-light">
                        <div class="row align-items-center g-3">
                            <div class="col-md-4">
                                <h5 class="text-dark mb-1"><i class="fas fa-tools text-primary me-2"></i>Admin Catalog Controls</h5>
                                <p class="text-muted mb-0 small">Add or manage store categories and product records</p>
                            </div>
                            <div class="col-md-8 text-md-end d-flex flex-wrap justify-content-md-end gap-2">
                                <!-- Add Category Button (Button1) -->
                                <asp:Button ID="Button1" runat="server" Text="Add Category" CssClass="btn btn-primary text-white py-2 px-3 rounded-pill shadow-sm fw-bold" OnClick="Button1_Click" />
                                
                                <!-- Edit Category Button (Button3) -->
                                <asp:Button ID="Button3" runat="server" Text="Edit Category" CssClass="btn btn-warning text-dark py-2 px-3 rounded-pill shadow-sm fw-bold" OnClick="Button3_Click" />

                                <!-- Add Product Button (Button2) -->
                                <asp:Button ID="Button2" runat="server" Text="Add Product" CssClass="btn btn-secondary text-dark py-2 px-3 rounded-pill shadow-sm fw-bold" OnClick="Button2_Click" />

                                <!-- Edit Product Button (Button4) -->
                                <asp:Button ID="Button4" runat="server" Text="Edit Product" CssClass="btn btn-info text-white py-2 px-3 rounded-pill shadow-sm fw-bold" OnClick="Button4_Click" />
                            </div>
                        </div>
                    </div>

                    <!-- Category Management Grid -->
                    <div class="card shadow-sm border-0 rounded-3 overflow-hidden mb-5">
                        <div class="card-header bg-white py-3 d-flex justify-content-between align-items-center">
                            <h6 class="mb-0 fw-bold text-dark">
                                <i class="fas fa-th-large text-primary me-2"></i>Category Records Grid (dbo.Category_tab)
                            </h6>
                            <a href="EditCategory.aspx" class="btn btn-sm btn-outline-warning rounded-pill px-3 me-2">
                                <i class="fas fa-edit me-1"></i> Edit Categories
                            </a>
                            <a href="addcategory.aspx" class="btn btn-sm btn-outline-primary rounded-pill px-3">
                                <i class="fas fa-plus me-1"></i> Add Category
                            </a>
                        </div>
                        <div class="card-body p-0">
                            <!-- ASP.NET GridView for Categories -->
                            <asp:GridView ID="gvCategories" runat="server" AutoGenerateColumns="False" 
                                CssClass="table table-hover align-middle mb-0" DataKeyNames="Cat_Id">
                                <Columns>
                                    <asp:BoundField DataField="Cat_Id" HeaderText="Cat_Id (PK)" />
                                    <asp:TemplateField HeaderText="Image">
                                        <ItemTemplate>
                                            <asp:Image ID="imgCat" runat="server" ImageUrl='<%# Eval("Cat_Image") %>' CssClass="img-thumbnail rounded" Width="55px" Height="55px" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="Cat_Name" HeaderText="Category Name" ItemStyle-Font-Bold="True" />
                                    <asp:BoundField DataField="Cat_Description" HeaderText="Description" />
                                    <asp:BoundField DataField="Cat_Status" HeaderText="Status" />
                                    <asp:TemplateField HeaderText="Actions" ItemStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:HyperLink ID="hlEditCat" runat="server" 
                                                NavigateUrl="EditCategory.aspx" 
                                                CssClass="btn btn-sm btn-outline-primary rounded-pill me-1">
                                                <i class="fas fa-edit me-1"></i>Edit
                                            </asp:HyperLink>
                                            <asp:LinkButton ID="btnDeleteCat" runat="server" CommandName="DeleteCat" 
                                                CommandArgument='<%# Eval("Cat_Id") %>' 
                                                CssClass="btn btn-sm btn-outline-danger rounded-circle" 
                                                OnClientClick="return confirm('Delete this category?');">
                                                <i class="fas fa-trash"></i>
                                            </asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>

                </div>
            </div>
            <!-- Admin Home Content End -->

        </form>

        <!-- JavaScript Libraries -->
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/js/bootstrap.bundle.min.js"></script>
    </body>
</html>
