<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserManagment.aspx.cs" Inherits="Project_1.UserManagment" %>

<!DOCTYPE html>
<html lang="en">

    <head runat="server">
        <meta charset="utf-8">
        <title>User Management - Fruitables Admin</title>
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
        <form id="form1" runat="server">

            <!-- Navbar -->
            <div class="container-fluid fixed-top">
                <div class="container px-0">
                    <nav class="navbar navbar-light bg-white navbar-expand-xl">
                        <a href="AdminHome.aspx" class="navbar-brand"><h1 class="text-primary display-6">Fruitables <span class="badge bg-secondary text-dark fs-6 align-middle">Admin</span></h1></a>
                        <div class="collapse navbar-collapse bg-white">
                            <div class="navbar-nav mx-auto">
                                <a href="AdminHome.aspx" class="nav-item nav-link">Admin Home</a>
                                <a href="AddCategory.aspx" class="nav-item nav-link">Add Category</a>
                                <a href="EditCategory.aspx" class="nav-item nav-link">Edit Category</a>
                                <a href="AddProduct.aspx" class="nav-item nav-link">Add Product</a>
                                <a href="EditProduct.aspx" class="nav-item nav-link">Edit Product</a>
                                <a href="UserManagment.aspx" class="nav-item nav-link active">Users</a>
                                <a href="ViewFeedback.aspx" class="nav-item nav-link">Feedbacks</a>
                                <a href="Login.aspx" class="nav-item nav-link">Sign Out</a>
                            </div>
                        </div>
                    </nav>
                </div>
            </div>

            <!-- Page Header -->
            <div class="container-fluid page-header py-5">
                <h1 class="text-center text-white display-6">User Account Management</h1>
                <ol class="breadcrumb justify-content-center mb-0">
                    <li class="breadcrumb-item"><a href="AdminHome.aspx">Admin Home</a></li>
                    <li class="breadcrumb-item active text-white">Users</li>
                </ol>
            </div>

            <!-- User Management Section -->
            <div class="container-fluid py-5">
                <div class="container py-4">
                    
                    <!-- Top Action Bar -->
                    <div class="d-flex justify-content-between align-items-center mb-4 flex-wrap gap-2">
                        <div>
                            <h4 class="text-dark fw-bold mb-1"><i class="fas fa-users-cog text-primary me-2"></i>Registered Customer Accounts</h4>
                            <p class="text-muted mb-0 small">Manage user access status (Active / Inactive) in dbo.User_tab</p>
                        </div>
                        <div>
                            <a href="AdminHome.aspx" class="btn btn-outline-secondary rounded-pill px-4">
                                <i class="fas fa-arrow-left me-1"></i> Admin Home
                            </a>
                        </div>
                    </div>

                    <!-- Main Grid Card -->
                    <div class="card shadow-sm border-0 rounded-4 overflow-hidden">
                        <div class="card-header bg-white py-3 border-bottom">
                            <h6 class="mb-0 fw-bold text-dark"><i class="fas fa-address-book text-primary me-2"></i>User Records</h6>
                        </div>
                        <div class="card-body p-0">
                            <div class="table-responsive">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
                                    DataKeyNames="User_Id"
                                    OnRowEditing="GridView1_RowEditing"
                                    OnRowUpdating="GridView1_RowUpdating"
                                    OnRowCancelingEdit="GridView1_RowCancelingEdit"
                                    CssClass="table table-hover align-middle mb-0 text-center"
                                    HeaderStyle-CssClass="table-light text-dark fw-bold">
                                    <Columns>
                                        <asp:BoundField DataField="User_Id" HeaderText="User ID" ReadOnly="True" ItemStyle-Font-Bold="True" ItemStyle-Width="70px" />
                                        <asp:BoundField DataField="User_Name" HeaderText="Full Name" ReadOnly="True" ItemStyle-CssClass="fw-bold text-dark text-start ps-3" />
                                        <asp:BoundField DataField="Age" HeaderText="Age" ReadOnly="True" ItemStyle-Width="60px" />
                                        <asp:BoundField DataField="Email" HeaderText="Email Address" ReadOnly="True" ItemStyle-CssClass="text-muted" />
                                        <asp:BoundField DataField="Phone" HeaderText="Phone" ReadOnly="True" />
                                        <asp:BoundField DataField="Address" HeaderText="Address" ReadOnly="True" ItemStyle-CssClass="text-start ps-2" />

                                        <asp:TemplateField HeaderText="Account Status" ItemStyle-Width="180px">
                                            <ItemTemplate>
                                                <%# Eval("User_Status").ToString().Trim() == "Active" ? "<span class='badge bg-success px-3 py-2'>Active</span>" : (Eval("User_Status").ToString().Trim() == "Inactive" ? "<span class='badge bg-danger px-3 py-2'>Inactive</span>" : "<span class='badge bg-secondary px-3 py-2'>" + (string.IsNullOrEmpty(Eval("User_Status").ToString().Trim()) ? "Pending" : Eval("User_Status").ToString()) + "</span>") %>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <div class="p-1">
                                                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                                                        SelectedValue='<%# Bind("User_Status") %>' 
                                                        RepeatDirection="Horizontal" 
                                                        CssClass="d-inline-flex gap-2 text-dark fw-bold">
                                                        <asp:ListItem Value="Active">Active</asp:ListItem>
                                                        <asp:ListItem Value="Inactive">Inactive</asp:ListItem>
                                                    </asp:RadioButtonList>
                                                </div>
                                            </EditItemTemplate>
                                        </asp:TemplateField>

                                        <asp:CommandField ShowEditButton="True" ShowCancelButton="True" HeaderText="Action" 
                                            ControlStyle-CssClass="btn btn-sm btn-outline-primary rounded-pill px-3 m-1" 
                                            ItemStyle-Width="140px" />
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
