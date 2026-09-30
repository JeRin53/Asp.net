<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditCategory.aspx.cs" Inherits="Project_1.EditCategory" %>

<!DOCTYPE html>
<html lang="en">

    <head runat="server">
        <meta charset="utf-8">
        <title>Edit Categories - Fruitables Admin</title>
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
                        <a href="AdminHome.aspx" class="navbar-brand"><h1 class="text-primary display-6">Fruitables <span class="badge bg-secondary text-dark fs-6 align-middle">Admin</span></h1></a>
                        <div class="collapse navbar-collapse bg-white">
                            <div class="navbar-nav mx-auto">
                                <a href="AdminHome.aspx" class="nav-item nav-link">Admin Home</a>
                                <a href="AddCategory.aspx" class="nav-item nav-link">Add Category</a>
                                <a href="EditCategory.aspx" class="nav-item nav-link active">Edit Category</a>
                                <a href="AddProduct.aspx" class="nav-item nav-link">Add Product</a>
                                <a href="EditProduct.aspx" class="nav-item nav-link">Edit Product</a>
                                <a href="UserManagment.aspx" class="nav-item nav-link">Users</a>
                                <a href="ViewFeedback.aspx" class="nav-item nav-link">Feedbacks</a>
                                <a href="Login.aspx" class="nav-item nav-link">Sign Out</a>
                            </div>
                        </div>
                    </nav>
                </div>
            </div>

            <!-- Page Header -->
            <div class="container-fluid page-header py-5">
                <h1 class="text-center text-white display-6">Manage Categories</h1>
                <ol class="breadcrumb justify-content-center mb-0">
                    <li class="breadcrumb-item"><a href="AdminHome.aspx">Admin Home</a></li>
                    <li class="breadcrumb-item active text-white">Edit Categories</li>
                </ol>
            </div>

            <!-- Category Management Section -->
            <div class="container-fluid py-5">
                <div class="container py-4">
                    
                    <!-- Top Action Bar -->
                    <div class="d-flex justify-content-between align-items-center mb-4 flex-wrap gap-2">
                        <div>
                            <h4 class="text-dark fw-bold mb-1"><i class="fas fa-edit text-primary me-2"></i>Category Records</h4>
                            <p class="text-muted mb-0 small">Update category details or remove categories from store catalog</p>
                        </div>
                        <div class="d-flex gap-2">
                            <a href="AddCategory.aspx" class="btn btn-primary text-white rounded-pill px-4 fw-bold">
                                <i class="fas fa-plus me-1"></i> Add New Category
                            </a>
                            <a href="AdminHome.aspx" class="btn btn-outline-secondary rounded-pill px-4">
                                <i class="fas fa-arrow-left me-1"></i> Admin Home
                            </a>
                        </div>
                    </div>

                    <!-- Status Label -->
                    <asp:Label ID="Label1" runat="server" CssClass="d-block mb-3 fw-bold text-center"></asp:Label>

                    <!-- Main Grid Card -->
                    <div class="card shadow-sm border-0 rounded-4 overflow-hidden">
                        <div class="card-header bg-white py-3 border-bottom">
                            <h6 class="mb-0 fw-bold text-dark"><i class="fas fa-list text-primary me-2"></i>All Categories (dbo.Category_tab)</h6>
                        </div>
                        <div class="card-body p-0">
                            <div class="table-responsive">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                    DataKeyNames="Cat_Id" 
                                    OnRowEditing="GridView1_RowEditing" 
                                    OnRowCancelingEdit="GridView1_RowCancelingEdit" 
                                    OnRowUpdating="GridView1_RowUpdating" 
                                    OnRowDeleting="GridView1_RowDeleting"
                                    CssClass="table table-hover align-middle mb-0 text-center"
                                    HeaderStyle-CssClass="table-light text-dark fw-bold">
                                    <Columns>
                                        <asp:BoundField DataField="Cat_Id" HeaderText="ID" ReadOnly="True" ItemStyle-Width="60px" ItemStyle-Font-Bold="True" />
                                        
                                        <asp:TemplateField HeaderText="Image" ItemStyle-Width="120px">
                                            <ItemTemplate>
                                                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Cat_Image") %>' CssClass="img-thumbnail rounded shadow-sm" Width="65px" Height="65px" />
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <div class="p-2">
                                                    <small class="text-muted d-block mb-1">New Image:</small>
                                                    <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control form-control-sm" />
                                                </div>
                                            </EditItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Category Name" ItemStyle-Width="200px">
                                            <ItemTemplate>
                                                <span class="fw-bold text-dark fs-6"><asp:Label ID="Label1" runat="server" Text='<%# Eval("Cat_Name") %>'></asp:Label></span>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("Cat_Name") %>' CssClass="form-control form-control-sm"></asp:TextBox>
                                            </EditItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Description">
                                            <ItemTemplate>
                                                <span class="text-muted text-start d-block"><asp:Label ID="Label2" runat="server" Text='<%# Eval("Cat_Description") %>'></asp:Label></span>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Eval("Cat_Description") %>' TextMode="MultiLine" Rows="2" CssClass="form-control form-control-sm"></asp:TextBox>
                                            </EditItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Status" ItemStyle-Width="120px">
                                            <ItemTemplate>
                                                <%# Eval("Cat_Status").ToString() == "Available" ? "<span class='badge bg-success px-3 py-2'>Available</span>" : "<span class='badge bg-secondary px-3 py-2'>Inactive</span>" %>
                                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("Cat_Status") %>' Visible="false"></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-select form-select-sm" SelectedValue='<%# Eval("Cat_Status") %>'>
                                                    <asp:ListItem Value="Available">Available</asp:ListItem>
                                                    <asp:ListItem Value="Inactive">Inactive</asp:ListItem>
                                                </asp:DropDownList>
                                            </EditItemTemplate>
                                        </asp:TemplateField>

                                        <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" HeaderText="Actions" 
                                            ControlStyle-CssClass="btn btn-sm btn-outline-primary rounded-pill px-3 m-1" 
                                            ItemStyle-Width="180px" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>

                </div>
            </div>

        </form>

        <!-- JavaScript Libraries -->
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/js/bootstrap.bundle.min.js"></script>
    </body>
</html>
