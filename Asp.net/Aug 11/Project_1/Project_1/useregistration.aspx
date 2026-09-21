<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="useregistration.aspx.cs" Inherits="Project_1.WebForm2" %>

<!DOCTYPE html>
<html lang="en">

    <head runat="server">
        <meta charset="utf-8">
        <title>User Registration - Fruitables</title>
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
                <h1 class="text-center text-white display-6">User Registration</h1>
                <ol class="breadcrumb justify-content-center mb-0">
                    <li class="breadcrumb-item"><a href="index.html">Home</a></li>
                    <li class="breadcrumb-item active text-white">Register</li>
                </ol>
            </div>
            <!-- Single Page Header End -->

            <!-- Registration Section Start -->
            <div class="container-fluid py-5">
                <div class="container py-5">
                    <div class="row justify-content-center">
                        <div class="col-lg-8 col-md-10">
                            <div class="auth-card">
                                <div class="auth-card-header">
                                    <div class="mb-2">
                                        <i class="fas fa-user-plus fa-3x"></i>
                                    </div>
                                    <h3 class="text-white mb-1">Create User Account</h3>
                                    <p class="text-white-50 mb-0">Fill in your details to register</p>
                                </div>
                                <div class="auth-card-body p-4 p-md-5">

                                    <!-- Status / Message Label (Label1) -->
                                    <asp:Label ID="Label1" runat="server" CssClass="d-block mb-4 fw-bold text-center"></asp:Label>

                                    <!-- Section 1: User Profile Information (dbo.User_tab) -->
                                    <h5 class="text-primary border-bottom pb-2 mb-4">
                                        <i class="fas fa-id-card me-2"></i>Personal Details
                                    </h5>

                                    <div class="row g-3 mb-4">
                                        
                                        <!-- User_Name (TextBox1) -->
                                        <div class="col-md-6">
                                            <label for="TextBox1" class="form-label fw-bold text-dark">
                                                Full Name (User_Name) <span class="text-danger">*</span>
                                            </label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-user input-icon"></i>
                                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control py-3" placeholder="Enter Full Name"></asp:TextBox>
                                            </div>
                                        </div>

                                        <!-- Age (TextBox2) -->
                                        <div class="col-md-6">
                                            <label for="TextBox2" class="form-label fw-bold text-dark">
                                                Age <span class="text-danger">*</span>
                                            </label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-birthday-cake input-icon"></i>
                                                <asp:TextBox ID="TextBox2" runat="server" TextMode="Number" CssClass="form-control py-3" placeholder="Enter Age"></asp:TextBox>
                                            </div>
                                        </div>

                                        <!-- Email (TextBox3) -->
                                        <div class="col-md-6">
                                            <label for="TextBox3" class="form-label fw-bold text-dark">
                                                Email Address <span class="text-danger">*</span>
                                            </label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-envelope input-icon"></i>
                                                <asp:TextBox ID="TextBox3" runat="server" TextMode="Email" CssClass="form-control py-3" placeholder="user@example.com"></asp:TextBox>
                                            </div>
                                        </div>

                                        <!-- Phone (TextBox4) -->
                                        <div class="col-md-6">
                                            <label for="TextBox4" class="form-label fw-bold text-dark">
                                                Phone Number <span class="text-danger">*</span>
                                            </label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-phone input-icon"></i>
                                                <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control py-3" placeholder="+1 555-0199"></asp:TextBox>
                                            </div>
                                        </div>

                                        <!-- Address (TextBox5) -->
                                        <div class="col-12">
                                            <label for="TextBox5" class="form-label fw-bold text-dark">
                                                Address <span class="text-danger">*</span>
                                            </label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-map-marker-alt input-icon" style="top: 25px;"></i>
                                                <asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control py-2 ps-5" placeholder="Enter Full Residential Address"></asp:TextBox>
                                            </div>
                                        </div>

                                    </div>

                                    <!-- Section 2: Account Login Credentials (dbo.Login_tab) -->
                                    <h5 class="text-primary border-bottom pb-2 mb-4 mt-4">
                                        <i class="fas fa-lock me-2"></i>Login Credentials
                                    </h5>

                                    <div class="row g-3 mb-4">
                                        
                                        <!-- Username (TextBox6) -->
                                        <div class="col-12">
                                            <label for="TextBox6" class="form-label fw-bold text-dark">
                                                Account Username <span class="text-danger">*</span>
                                            </label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-user-circle input-icon"></i>
                                                <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control py-3" placeholder="Choose a username"></asp:TextBox>
                                            </div>
                                        </div>

                                        <!-- Password (TextBox8) -->
                                        <div class="col-md-12">
                                            <label for="TextBox8" class="form-label fw-bold text-dark">
                                                Password <span class="text-danger">*</span>
                                            </label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-key input-icon"></i>
                                                <asp:TextBox ID="TextBox8" runat="server" TextMode="Password" CssClass="form-control py-3" placeholder="Create a strong password"></asp:TextBox>
                                            </div>
                                        </div>

                                    </div>

                                    <!-- Action Button (Button1) -->
                                    <div class="row g-3 mb-4">
                                        <div class="col-12">
                                            <asp:Button ID="Button1" runat="server" Text="Complete Registration" CssClass="btn btn-primary text-white w-100 py-3 rounded-3 fw-bold shadow-sm" OnClick="Button1_Click" />
                                        </div>
                                    </div>

                                    <!-- Links -->
                                    <div class="text-center pt-3 border-top">
                                        <p class="text-muted mb-0">Already registered? <a href="login.aspx" class="text-primary fw-bold">Sign In Here</a></p>
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
