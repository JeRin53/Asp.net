<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewFeedback.aspx.cs" Inherits="Project_1.ViewFeedback" %>

<!DOCTYPE html>
<html lang="en">

    <head runat="server">
        <meta charset="utf-8">
        <title>Customer Feedbacks - Fruitables Admin</title>
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
                                <a href="UserManagment.aspx" class="nav-item nav-link">Users</a>
                                <a href="ViewFeedback.aspx" class="nav-item nav-link active">Feedbacks</a>
                                <a href="Login.aspx" class="nav-item nav-link">Sign Out</a>
                            </div>
                        </div>
                    </nav>
                </div>
            </div>

            <!-- Page Header -->
            <div class="container-fluid page-header py-5">
                <h1 class="text-center text-white display-6">Customer Inquiries & Feedback</h1>
                <ol class="breadcrumb justify-content-center mb-0">
                    <li class="breadcrumb-item"><a href="AdminHome.aspx">Admin Home</a></li>
                    <li class="breadcrumb-item active text-white">Feedbacks</li>
                </ol>
            </div>

            <!-- Feedback Management Section -->
            <div class="container-fluid py-5">
                <div class="container py-4">
                    
                    <!-- Top Action Bar -->
                    <div class="d-flex justify-content-between align-items-center mb-4 flex-wrap gap-2">
                        <div>
                            <h4 class="text-dark fw-bold mb-1"><i class="fas fa-comments text-primary me-2"></i>Active Customer Feedbacks</h4>
                            <p class="text-muted mb-0 small">Select a feedback to draft and send an email reply directly to the customer</p>
                        </div>
                        <div>
                            <a href="AdminHome.aspx" class="btn btn-outline-secondary rounded-pill px-4">
                                <i class="fas fa-arrow-left me-1"></i> Admin Home
                            </a>
                        </div>
                    </div>

                    <!-- Status Label -->
                    <asp:Label ID="Label1" runat="server" CssClass="d-block mb-3 fw-bold text-center"></asp:Label>

                    <div class="row g-4">
                        
                        <!-- Grid Column -->
                        <div class="col-lg-7">
                            <div class="card shadow-sm border-0 rounded-4 overflow-hidden h-100">
                                <div class="card-header bg-white py-3 border-bottom d-flex justify-content-between align-items-center">
                                    <h6 class="mb-0 fw-bold text-dark"><i class="fas fa-inbox text-primary me-2"></i>Pending Feedbacks (Feed_Status = 1)</h6>
                                </div>
                                <div class="card-body p-0">
                                    <div class="table-responsive">
                                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                            DataKeyNames="Email,Feed_Id" 
                                            OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                                            CssClass="table table-hover align-middle mb-0 text-center"
                                            HeaderStyle-CssClass="table-light text-dark fw-bold"
                                            EmptyDataText="No pending customer feedbacks.">
                                            <Columns>
                                                <asp:BoundField DataField="Prod_Id" HeaderText="Prod ID" ItemStyle-Width="70px" />
                                                <asp:BoundField DataField="User_Name" HeaderText="Customer" ItemStyle-Font-Bold="True" ItemStyle-CssClass="text-start ps-2" />
                                                <asp:BoundField DataField="Email" HeaderText="Email" ItemStyle-CssClass="text-muted small" />
                                                <asp:BoundField DataField="Feed_Msg" HeaderText="Message" ItemStyle-CssClass="text-start ps-2 small" />
                                                <asp:BoundField DataField="Feed_Date" HeaderText="Date" DataFormatString="{0:yyyy-MM-dd}" ItemStyle-Width="90px" ItemStyle-CssClass="small" />
                                                <asp:CommandField HeaderText="Action" SelectText="Reply ✉" ShowSelectButton="True" 
                                                    ControlStyle-CssClass="btn btn-sm btn-primary text-white rounded-pill px-3 fw-bold" 
                                                    ItemStyle-Width="100px" />
                                            </Columns>
                                        </asp:GridView>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- Reply Panel Column -->
                        <div class="col-lg-5">
                            <asp:Panel ID="Panel1" runat="server" Visible="False">
                                <div class="card shadow-sm border-0 rounded-4 overflow-hidden">
                                    <div class="auth-card-header" style="background: linear-gradient(135deg, #81c408 0%, #45595b 100%);">
                                        <h5 class="text-white mb-1"><i class="fas fa-paper-plane me-2"></i>Send Email Reply</h5>
                                        <p class="text-white-50 mb-0 small">Reply will be emailed directly to customer</p>
                                    </div>
                                    <div class="card-body p-4">
                                        
                                        <!-- Recipient Email (TextBox1) -->
                                        <div class="mb-3">
                                            <label for="TextBox1" class="form-label fw-bold text-dark">
                                                Customer Email:
                                            </label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-envelope input-icon"></i>
                                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control py-2" placeholder="Recipient Email" ReadOnly="True"></asp:TextBox>
                                            </div>
                                        </div>

                                        <!-- Subject (TextBox3) -->
                                        <div class="mb-3">
                                            <label for="TextBox3" class="form-label fw-bold text-dark">
                                                Subject <span class="text-danger">*</span>
                                            </label>
                                            <div class="input-icon-group">
                                                <i class="fas fa-heading input-icon"></i>
                                                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control py-2" placeholder="e.g. Reply to your query on Fruitables"></asp:TextBox>
                                            </div>
                                        </div>

                                        <!-- Message Body (TextBox2) -->
                                        <div class="mb-4">
                                            <label for="TextBox2" class="form-label fw-bold text-dark">
                                                Reply Message <span class="text-danger">*</span>
                                            </label>
                                            <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Rows="5" CssClass="form-control" placeholder="Write your response message to the customer..."></asp:TextBox>
                                        </div>

                                        <!-- Submit Button (Button1) -->
                                        <div class="d-grid">
                                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send Reply Email" CssClass="btn btn-primary text-white py-3 rounded-pill fw-bold shadow-sm" />
                                        </div>

                                    </div>
                                </div>
                            </asp:Panel>
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
