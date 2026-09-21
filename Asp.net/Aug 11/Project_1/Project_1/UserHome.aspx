<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UserHome.aspx.cs" Inherits="Project_1.UserHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            

            <!-- Hero Carousel Start -->
            <div class="container-fluid py-5 mb-5 hero-header">
                <div class="container py-5">
                    <div class="row g-5 align-items-center">
                        <div class="col-md-12 col-lg-7">
                            <h4 class="mb-3 text-secondary">100% Organic Foods</h4>
                            <h1 class="mb-5 display-3 text-primary">Organic Veggies & Fruits Foods</h1>
                        </div>
                        <div class="col-md-12 col-lg-5">
                            <div id="carouselId" class="carousel slide position-relative shadow rounded" data-bs-ride="carousel">
                                <div class="carousel-inner" role="listbox">
                                    <div class="carousel-item active rounded">
                                        <img src="img/hero-img-1.png" class="img-fluid w-100 h-100 bg-secondary rounded" alt="First slide" style="max-height: 350px; object-fit: cover;">
                                        <div class="carousel-caption d-none d-md-block">
                                            <span class="btn px-4 py-2 text-white bg-primary rounded">Fresh Fruits</span>
                                        </div>
                                    </div>
                                    <div class="carousel-item rounded">
                                        <img src="img/hero-img-2.jpg" class="img-fluid w-100 h-100 rounded" alt="Second slide" style="max-height: 350px; object-fit: cover;">
                                        <div class="carousel-caption d-none d-md-block">
                                            <span class="btn px-4 py-2 text-white bg-secondary rounded">Organic Vegetables</span>
                                        </div>
                                    </div>
                                </div>
                                <button class="carousel-control-prev" type="button" data-bs-target="#carouselId" data-bs-slide="prev">
                                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                                    <span class="visually-hidden">Previous</span>
                                </button>
                                <button class="carousel-control-next" type="button" data-bs-target="#carouselId" data-bs-slide="next">
                                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                                    <span class="visually-hidden">Next</span>
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Hero Carousel End -->

            <!-- Categories Section Start -->
            <div class="container-fluid py-5">
                <div class="container py-5">
                    <div class="text-center mx-auto mb-5" style="max-width: 700px;">
                        <h1 class="display-4 text-primary">Shop By Category</h1>
                        <p class="text-muted">Select a category below to explore our fresh organic products</p>
                    </div>

                    <!-- Categories DataList -->
                    <div class="d-flex justify-content-center">
                        <asp:DataList ID="dlCategories" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" CellPadding="15" CssClass="auto-style1">
                            <ItemTemplate>
                                <div class="card border-0 shadow-sm rounded-3 text-center p-3 m-2" style="width: 320px; transition: 0.3s; background: #fff;">
                                    <div class="overflow-hidden rounded mb-3 text-center">
                                        <asp:ImageButton ID="imgBtnCategory" runat="server" 
                                            ImageUrl='<%# Eval("Cat_Image") %>' 
                                            CommandArgument='<%# Eval("Cat_Id") %>' 
                                            OnCommand="imgBtnCategory_Command"
                                            CssClass="img-fluid rounded" 
                                            Style="height: 200px; width: 100%; object-fit: cover;" 
                                            AlternateText='<%# Eval("Cat_Name") %>' />
                                    </div>
                                    <h4 class="text-dark fw-bold mb-2">
                                        <asp:Label ID="lblCatName" runat="server" Text='<%# Eval("Cat_Name") %>'></asp:Label>
                                    </h4>
                                    <p class="text-muted small mb-0 text-truncate" style="max-height: 40px;">
                                        <asp:Label ID="lblCatDesc" runat="server" Text='<%# Eval("Cat_Description") %>'></asp:Label>
                                    </p>
                                </div>
                            </ItemTemplate>
                        </asp:DataList>
                    </div>

                </div>
            </div>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            margin-right: 0px;
        }
    </style>
</asp:Content>

