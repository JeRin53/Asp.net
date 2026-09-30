<%@ Page Title="Home - Fruitables" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UserHome.aspx.cs" Inherits="Project_1.UserHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style>
    /* ================= HERO ================= */
    .hero-section {
        padding: 80px 0;
        background: linear-gradient(135deg, #f8fff2, #ffffff);
    }

    .hero-small-title {
        color: #7ab800;
        font-size: 18px;
        font-weight: 600;
    }

    .hero-title {
        font-size: 55px;
        font-weight: 700;
        line-height: 1.15;
        color: #263238;
        margin-top: 18px;
    }

    .hero-title span {
        display: block;
        color: #7ab800;
    }

    .hero-text {
        color: #777;
        font-size: 17px;
        line-height: 1.8;
        margin: 25px 0;
        max-width: 550px;
    }

    .hero-buttons {
        display: flex;
        gap: 15px;
    }

    .hero-btn {
        padding: 13px 28px;
        border-radius: 30px;
        font-weight: 600;
        background: #7ab800;
        border: none;
    }

    .hero-btn:hover {
        background: #639900;
    }

    .hero-login-btn {
        padding: 13px 28px;
        border-radius: 30px;
        font-weight: 600;
    }

    /* ================= CAROUSEL ================= */
    .hero-carousel {
        border-radius: 25px;
        overflow: hidden;
        box-shadow: 0 15px 40px rgba(0,0,0,.15);
    }

    .hero-carousel img {
        height: 400px;
        object-fit: cover;
    }

    .hero-carousel .carousel-caption {
        bottom: 25px;
    }

    .hero-carousel .carousel-caption span {
        background: #7ab800;
        padding: 10px 25px;
        border-radius: 30px;
        font-weight: 600;
    }

    /* ================= FEATURES ================= */
    .features-section {
        padding: 50px 0;
        background: #ffffff;
    }

    .feature-card {
        text-align: center;
        padding: 30px 20px;
        border-radius: 15px;
        background: #f8faf5;
        transition: .3s;
        height: 100%;
    }

    .feature-card:hover {
        transform: translateY(-8px);
        box-shadow: 0 10px 30px rgba(0,0,0,.08);
    }

    .feature-icon {
        width: 65px;
        height: 65px;
        line-height: 65px;
        margin: auto;
        margin-bottom: 15px;
        border-radius: 50%;
        background: #eaf7d7;
        color: #7ab800;
        font-size: 25px;
    }

    .feature-card h5 {
        font-weight: 700;
        color: #333;
    }

    .feature-card p {
        color: #888;
        margin-bottom: 0;
    }

    /* ================= CATEGORY ================= */
    .category-section {
        padding: 80px 0;
        background: #f9faf7;
    }

    .section-heading {
        text-align: center;
        margin-bottom: 50px;
    }

    .section-heading span {
        color: #7ab800;
        font-size: 14px;
        font-weight: 700;
        letter-spacing: 2px;
    }

    .section-heading h2 {
        font-size: 42px;
        margin-top: 10px;
        color: #263238;
        font-weight: 700;
    }

    .section-heading h2 strong {
        color: #7ab800;
    }

    .section-heading p {
        color: #777;
        font-size: 16px;
    }

    /* ================= CATEGORY CARD ================= */
    .category-card {
        width: 330px;
        background: white;
        border-radius: 20px;
        overflow: hidden;
        margin: 12px;
        box-shadow: 0 8px 30px rgba(0,0,0,.07);
        transition: .3s;
    }

    .category-card:hover {
        transform: translateY(-10px);
        box-shadow: 0 18px 40px rgba(0,0,0,.12);
    }

    .category-image {
        height: 220px;
        overflow: hidden;
        position: relative;
    }

    .category-image img {
        width: 100%;
        height: 100%;
        object-fit: cover;
        transition: .5s;
    }

    .category-card:hover .category-image img {
        transform: scale(1.08);
    }

    .category-overlay {
        position: absolute;
        left: 0;
        right: 0;
        bottom: -60px;
        background: rgba(122,184,0,.92);
        color: white;
        text-align: center;
        padding: 15px;
        transition: .3s;
    }

    .category-card:hover .category-overlay {
        bottom: 0;
    }

    .category-details {
        padding: 22px;
        text-align: center;
    }

    .category-details h4 {
        font-weight: 700;
        color: #333;
        margin-bottom: 10px;
    }

    .category-details p {
        color: #888;
        font-size: 14px;
        height: 42px;
        overflow: hidden;
    }

    .view-products-btn {
        display: inline-block;
        margin-top: 10px;
        color: #7ab800;
        font-weight: 600;
        text-decoration: none;
    }

    .view-products-btn:hover {
        color: #568600;
    }

    /* ================= LOGIN BANNER ================= */
    .login-banner {
        padding: 70px 0;
        background: linear-gradient(135deg, #7ab800, #5d9200);
    }

    .login-banner-content {
        display: flex;
        justify-content: space-between;
        align-items: center;
        gap: 30px;
    }

    .login-banner-content span {
        color: #e7f6c9;
        font-size: 13px;
        font-weight: 700;
        letter-spacing: 2px;
    }

    .login-banner-content h2 {
        color: white;
        font-size: 38px;
        margin: 8px 0;
    }

    .login-banner-content p {
        color: #eaf7d7;
        margin: 0;
    }

    .login-banner-btn {
        padding: 13px 30px;
        border-radius: 30px;
        font-weight: 600;
        white-space: nowrap;
    }

    /* ================= MOBILE ================= */
    @media(max-width: 768px) {
        .hero-title {
            font-size: 40px;
        }

        .hero-carousel img {
            height: 300px;
        }

        .category-card {
            width: 290px;
        }

        .login-banner-content {
            flex-direction: column;
            text-align: center;
        }
    }
</style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- ================= HERO SECTION ================= -->
    <section class="hero-section">
        <div class="container">
            <div class="row align-items-center g-5">

                <!-- LEFT CONTENT -->
                <div class="col-lg-6">
                    <span class="hero-small-title">
                        <i class="fas fa-leaf me-2"></i> 100% Organic Foods
                    </span>

                    <h1 class="hero-title">
                        Fresh & Organic
                        <span>Fruits & Vegetables</span>
                    </h1>

                    <p class="hero-text">
                        Discover fresh, healthy and organic fruits and vegetables
                        delivered straight to your doorstep.
                    </p>

                    <div class="hero-buttons">
                        <a href="#categories" class="btn btn-primary hero-btn">
                            <i class="fas fa-shopping-basket me-2"></i>
                            Shop Now
                        </a>

                        <a href="Login.aspx" class="btn btn-outline-primary hero-login-btn">
                            <i class="fas fa-sign-in-alt me-2"></i>
                            Login
                        </a>
                    </div>
                </div>

                <!-- RIGHT CAROUSEL -->
                <div class="col-lg-6">
                    <div id="carouselId"
                         class="carousel slide hero-carousel"
                         data-bs-ride="carousel">

                        <div class="carousel-inner">
                            <div class="carousel-item active">
                                <img src="img/hero-img-1.png"
                                     class="d-block w-100"
                                     alt="Fresh Fruits">
                                <div class="carousel-caption">
                                    <span>Fresh Fruits</span>
                                </div>
                            </div>

                            <div class="carousel-item">
                                <img src="img/hero-img-2.jpg"
                                     class="d-block w-100"
                                     alt="Organic Vegetables">
                                <div class="carousel-caption">
                                    <span>Organic Vegetables</span>
                                </div>
                            </div>
                        </div>

                        <button class="carousel-control-prev"
                                type="button"
                                data-bs-target="#carouselId"
                                data-bs-slide="prev">
                            <span class="carousel-control-prev-icon"></span>
                        </button>

                        <button class="carousel-control-next"
                                type="button"
                                data-bs-target="#carouselId"
                                data-bs-slide="next">
                            <span class="carousel-control-next-icon"></span>
                        </button>
                    </div>
                </div>

            </div>
        </div>
    </section>

    <!-- ================= FEATURES ================= -->
    <section class="features-section">
        <div class="container">
            <div class="row g-4">

                <div class="col-md-3">
                    <div class="feature-card">
                        <div class="feature-icon">
                            <i class="fas fa-truck"></i>
                        </div>
                        <h5>Free Delivery</h5>
                        <p>Free delivery on selected orders</p>
                    </div>
                </div>

                <div class="col-md-3">
                    <div class="feature-card">
                        <div class="feature-icon">
                            <i class="fas fa-leaf"></i>
                        </div>
                        <h5>100% Organic</h5>
                        <p>Fresh and naturally grown products</p>
                    </div>
                </div>

                <div class="col-md-3">
                    <div class="feature-card">
                        <div class="feature-icon">
                            <i class="fas fa-shield-alt"></i>
                        </div>
                        <h5>Secure Payment</h5>
                        <p>Safe and secure payment options</p>
                    </div>
                </div>

                <div class="col-md-3">
                    <div class="feature-card">
                        <div class="feature-icon">
                            <i class="fas fa-headset"></i>
                        </div>
                        <h5>24/7 Support</h5>
                        <p>We're always here to help</p>
                    </div>
                </div>

            </div>
        </div>
    </section>

    <!-- ================= CATEGORY SECTION ================= -->
    <section id="categories" class="category-section">
        <div class="container">

            <div class="section-heading">
                <span>EXPLORE OUR PRODUCTS</span>
                <h2>Shop By <strong>Category</strong></h2>
                <p>Choose a category and discover our collection of fresh organic products.</p>
            </div>

            <div class="d-flex justify-content-center">
                <asp:DataList ID="dlCategories"
                    runat="server"
                    RepeatColumns="3"
                    RepeatDirection="Horizontal"
                    CellPadding="10"
                    CssClass="category-list">

                    <ItemTemplate>
                        <div class="category-card">

                            <!-- CLICKABLE IMAGE -->
                            <asp:LinkButton
                                ID="btnCategory"
                                runat="server"
                                CommandArgument='<%# Eval("Cat_Id") %>'
                                OnCommand="imgBtnCategory_Command"
                                CssClass="category-image-link">

                                <div class="category-image">
                                    <asp:Image
                                        ID="imgCategory"
                                        runat="server"
                                        ImageUrl='<%# Eval("Cat_Image") %>'
                                        AlternateText='<%# Eval("Cat_Name") %>' />

                                    <div class="category-overlay">
                                        <span>
                                            View Products
                                            <i class="fas fa-arrow-right ms-2"></i>
                                        </span>
                                    </div>
                                </div>
                            </asp:LinkButton>

                            <!-- CATEGORY DETAILS -->
                            <div class="category-details">
                                <h4>
                                    <asp:Label
                                        ID="lblCatName"
                                        runat="server"
                                        Text='<%# Eval("Cat_Name") %>'>
                                    </asp:Label>
                                </h4>

                                <p>
                                    <asp:Label
                                        ID="lblCatDesc"
                                        runat="server"
                                        Text='<%# Eval("Cat_Description") %>'>
                                    </asp:Label>
                                </p>

                                <asp:LinkButton
                                    ID="btnViewProducts"
                                    runat="server"
                                    CommandArgument='<%# Eval("Cat_Id") %>'
                                    OnCommand="imgBtnCategory_Command"
                                    CssClass="view-products-btn">
                                    Explore
                                    <i class="fas fa-arrow-right ms-2"></i>
                                </asp:LinkButton>
                            </div>

                        </div>
                    </ItemTemplate>
                </asp:DataList>
            </div>

        </div>
    </section>

    <!-- ================= LOGIN CTA ================= -->
    <section class="login-banner">
        <div class="container">
            <div class="login-banner-content">
                <div>
                    <span>READY TO SHOP?</span>
                    <h2>Login to start shopping</h2>
                    <p>Create your account and enjoy a seamless shopping experience.</p>
                </div>

                <a href="Login.aspx" class="btn btn-light login-banner-btn">
                    <i class="fas fa-sign-in-alt me-2"></i>
                    Login Now
                </a>
            </div>
        </div>
    </section>

</asp:Content>