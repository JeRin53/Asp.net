<%@ Page Title="Register - Fruitables" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registeration.aspx.cs" Inherits="Project_1.Registeration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Single Page Header start -->
    <div class="container-fluid page-header py-5">
        <h1 class="text-center text-white display-6">Account Registration</h1>
        <ol class="breadcrumb justify-content-center mb-0">
            <li class="breadcrumb-item"><a href="UserHome.aspx">Home</a></li>
            <li class="breadcrumb-item active text-white">Register</li>
        </ol>
    </div>
    <!-- Single Page Header End -->

    <div class="container-fluid py-5">
        <div class="container py-5">
            <div class="row justify-content-center g-4">
                <div class="col-md-5">
                    <div class="card h-100 shadow border-0 rounded-4 text-center p-4 p-lg-5">
                        <div class="mb-4">
                            <i class="fas fa-user fa-4x text-primary"></i>
                        </div>
                        <h3 class="text-dark fw-bold mb-3">User Registration</h3>
                        <p class="text-muted mb-4">Create a customer account to browse fresh organic vegetables and fruits, add to cart, and order online.</p>
                        <a href="UserRegisteration.aspx" class="btn btn-primary text-white rounded-pill py-3 px-4 fw-bold mt-auto">
                            Register as Customer →
                        </a>
                    </div>
                </div>
                <div class="col-md-5">
                    <div class="card h-100 shadow border-0 rounded-4 text-center p-4 p-lg-5">
                        <div class="mb-4">
                            <i class="fas fa-user-shield fa-4x text-secondary"></i>
                        </div>
                        <h3 class="text-dark fw-bold mb-3">Admin Registration</h3>
                        <p class="text-muted mb-4">Create an administrator account to manage store categories, products, user accounts, and customer feedback.</p>
                        <a href="AdminReg.aspx" class="btn btn-secondary text-dark rounded-pill py-3 px-4 fw-bold mt-auto">
                            Register as Admin →
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
