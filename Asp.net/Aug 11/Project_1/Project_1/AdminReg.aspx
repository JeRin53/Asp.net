<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminReg.aspx.cs" Inherits="Project_1.AdminReg" %>

<!DOCTYPE html>
<html lang="en">

    <head runat="server">
        <meta charset="utf-8">
        <title>Admin Registration - Fruitables</title>
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
                                <a href="index.html" class="nav-item nav-link">Home</a>
                                <a href="shop.html" class="nav-item nav-link">Shop</a>
                                <a href="cart.html" class="nav-item nav-link">Shop Cart</a>
                                <a href="chackout.html" class="nav-item nav-link">Checkout</a>
                                <a href="contact.html" class="nav-item nav-link">Contact</a>
                            </div>
                        </div>
                    </nav>
                </div>
            </div>
            <!-- Navbar End -->

            <!-- Single Page Header start -->
            <div class="container-fluid page-header py-5">
                <h1 class="text-center text-white display-6">Admin Registration</h1>
                <ol class="breadcrumb justify-content-center mb-0">
                    <li class="breadcrumb-item"><a href="index.html">Home</a></li>
                    <li class="breadcrumb-item active text-white">Admin Register</li>
                </ol>
            </div>
            <!-- Single Page Header End -->

            <!-- Registration Section Start -->
            <div class="container-fluid py-5">
                <div class="container py-5">
                    <div class="row justify-content-center">
                        <div class="col-lg-8 col-md-10">
                            <div class="auth-card">
                                <div class="auth-card-header" style="background: linear-gradient(135deg, #45595b 0%, #2c3e50 100%);">
                                    <div class="mb-2">
                                        <i class="fas fa-user-shield fa-3x text-secondary"></i>
                                    </div>
                                    <h3 class="text-white mb-1">Register Administrator</h3>
                                    <p class="text-white-50 mb-0">Create new admin credentials for Fruitables Management</p>
                                </div>
                                <div class="auth-card-body p-4 p-md-5">

                                    <!-- Status / Message Label (Label1) -->
                                    <asp:Label ID="Label1" runat="server" CssClass="d-block mb-4 fw-bold text-center"></asp:Label>

                                    <!-- Section 1: Admin Profile Details (dbo.Admin_tab) -->
                                    <h5 class="text-dark border-bottom pb-2 mb-4">
                                        <i class="fas fa-id-badge text-secondary me-2"></i>Admin Info (dbo.Admin_tab)
                                    </h5>

                                    <div class="row g-3 mb-4">
                                        
                                        <!-- Email (TextBox1) -> dbo.Admin_tab.Email -->
                                        <div class="col-md-6">
                                            <label for="TextBox1" class="form-label fw-bold text-dark">
                                                Email Address <span class="text-danger">*</span>
                                            </label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-envelope input-icon"></i>
                                                <asp:TextBox ID="TextBox1" runat="server" TextMode="Email" CssClass="form-control py-3" placeholder="admin@fruitables.com"></asp:TextBox>
                                            </div>
                                        </div>

                                        <!-- Name (TextBox2) -> dbo.Admin_tab.Name -->
                                        <div class="col-md-6">
                                            <label for="TextBox2" class="form-label fw-bold text-dark">
                                                Administrator Name <span class="text-danger">*</span>
                                            </label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-user-tie input-icon"></i>
                                                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control py-3" placeholder="Enter Full Name"></asp:TextBox>
                                            </div>
                                        </div>

                                    </div>

                                    <!-- Section 2: Account Login Credentials (dbo.Login_tab) -->
                                    <h5 class="text-dark border-bottom pb-2 mb-4 mt-4">
                                        <i class="fas fa-lock text-secondary me-2"></i>Login Credentials (dbo.Login_tab)
                                    </h5>

                                    <div class="row g-3 mb-4">
                                        
                                        <!-- Username (TextBox3) -> dbo.Login_tab.Username -->
                                        <div class="col-12">
                                            <label for="TextBox3" class="form-label fw-bold text-dark">
                                                Admin Username <span class="text-danger">*</span>
                                            </label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-user-circle input-icon"></i>
                                                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control py-3" placeholder="Choose Admin Username"></asp:TextBox>
                                            </div>
                                        </div>

                                        <!-- Password (TextBox4) -> dbo.Login_tab.Password -->
                                        <div class="col-md-12">
                                            <label for="TextBox4" class="form-label fw-bold text-dark">
                                                Admin Password <span class="text-danger">*</span>
                                            </label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-key input-icon"></i>
                                                <asp:TextBox ID="TextBox4" runat="server" TextMode="Password" CssClass="form-control py-3" placeholder="Enter secure password"></asp:TextBox>
                                            </div>
                                        </div>

                                    </div>

                                    <!-- Action Button (Button1) -->
                                    <div class="row g-3 mb-4">
                                        <div class="col-12">
                                            <asp:Button ID="Button1" runat="server" Text="Register Admin" CssClass="btn btn-secondary text-dark w-100 py-3 rounded-3 fw-bold shadow-sm" OnClick="Button1_Click" />
                                        </div>
                                    </div>

                                    <!-- Links -->
                                    <div class="text-center pt-3 border-top">
                                        <p class="text-muted mb-0">Already have an admin account? <a href="login.aspx" class="text-primary fw-bold">Sign In Here</a></p>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Registration Section End -->

        </form>

        <!-- JavaScript Libraries -->
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/js/bootstrap.bundle.min.js"></script>
    </body>
</html>

