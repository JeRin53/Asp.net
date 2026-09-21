<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project_1.WebForm1" %>

<!DOCTYPE html>
<html lang="en">

    <head runat="server">
        <meta charset="utf-8">
        <title>Login - Fruitables</title>
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
                <h1 class="text-center text-white display-6">Account Login</h1>
                <ol class="breadcrumb justify-content-center mb-0">
                    <li class="breadcrumb-item"><a href="index.html">Home</a></li>
                    <li class="breadcrumb-item active text-white">Login</li>
                </ol>
            </div>
            <!-- Single Page Header End -->

            <!-- Login Section Start -->
            <div class="container-fluid py-5">
                <div class="container py-5">
                    <div class="row justify-content-center">
                        <div class="col-lg-6 col-md-8">
                            <div class="auth-card">
                                <div class="auth-card-header">
                                    <div class="mb-2">
                                        <i class="fas fa-lock fa-3x"></i>
                                    </div>
                                    <h3 class="text-white mb-1">Welcome Back</h3>
                                    <p class="text-white-50 mb-0">Sign in to your Fruitables account</p>
                                </div>
                                <div class="auth-card-body">
                                    
                                    <!-- Error / Status Label (Label3) -->
                                    <asp:Label ID="Label3" runat="server" ForeColor="Red" CssClass="d-block mb-3 fw-bold text-center"></asp:Label>

                                    <!-- Username Field (TextBox1) -->
                                    <div class="mb-4">
                                        <label for="TextBox1" class="form-label fw-bold text-dark">
                                            <i class="fas fa-user text-primary me-1"></i> Username
                                        </label>
                                        <div class="input-icon-group">
                                            <i class="fas fa-user input-icon"></i>
                                            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control py-3" placeholder="Enter your username"></asp:TextBox>
                                        </div>
                                    </div>

                                    <!-- Password Field (TextBox2) -->
                                    <div class="mb-4">
                                        <label for="TextBox2" class="form-label fw-bold text-dark">
                                            <i class="fas fa-key text-primary me-1"></i> Password
                                        </label>
                                        <div class="input-icon-group mt-2">
                                            <i class="fas fa-lock input-icon"></i>
                                            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" CssClass="form-control py-3" placeholder="Enter your password"></asp:TextBox>
                                        </div>
                                    </div>

                                    <!-- Submit Button (Button1) -->
                                    <div class="d-grid mb-4">
                                        <asp:Button ID="Button1" runat="server" Text="Sign In" CssClass="btn btn-primary text-white py-3 rounded-3 fw-bold shadow-sm" OnClick="Button1_Click" />
                                    </div>

                                    <!-- Registration Links -->
                                    <div class="text-center pt-2 border-top">
                                        <p class="text-muted mb-2">Don't have an account yet?</p>
                                        <div class="d-flex justify-content-center gap-3">
                                            <a href="useregistration.aspx" class="btn btn-outline-primary btn-sm px-3 rounded-pill">
                                                <i class="fas fa-user me-1"></i> Register as User
                                            </a>
                                            <a href="admin-register.html" class="btn btn-outline-secondary btn-sm px-3 rounded-pill">
                                                <i class="fas fa-user-shield me-1"></i> Register as Admin
                                            </a>
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Login Section End -->

        </form>

        <!-- JavaScript Libraries -->
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/js/bootstrap.bundle.min.js"></script>
    </body>
</html>
