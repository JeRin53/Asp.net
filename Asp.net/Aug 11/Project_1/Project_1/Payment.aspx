<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="Project_1.Payment" %>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .payment-card {
            background: #ffffff;
            border-radius: 15px;
            padding: 35px;
            box-shadow: 0 5px 25px rgba(0,0,0,0.08);
            margin-top: 30px;
            margin-bottom: 50px;
        }
        .panel-box {
            background-color: #f8f9fa;
            border-radius: 12px;
            padding: 25px;
            border: 1px solid #e9ecef;
            height: 100%;
        }
        .panel-header {
            border-bottom: 2px solid #81c408;
            padding-bottom: 12px;
            margin-bottom: 20px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Single Page Header start -->
    <div class="container-fluid page-header py-5">
        <h1 class="text-center text-white display-6">Payment & Bank Account</h1>
        <ol class="breadcrumb justify-content-center mb-0">
            <li class="breadcrumb-item"><a href="UserHome.aspx">Home</a></li>
            <li class="breadcrumb-item"><a href="viewbill.aspx">Bill</a></li>
            <li class="breadcrumb-item active text-white">Payment</li>
        </ol>
    </div>
    <!-- Single Page Header End -->

    <!-- Payment Section Start -->
    <div class="container-fluid py-4">
        <div class="container py-3">
            <div class="payment-card">
                
                <div class="row g-4">
                    
                    <!-- PANEL 1: Account Details Form -->
                    <div class="col-lg-6">
                        <asp:Panel ID="Panel1" runat="server" CssClass="panel-box">
                            <div class="panel-header">
                                <h4 class="text-dark fw-bold mb-0">
                                    <i class="fas fa-university text-primary me-2"></i>Account Registration
                                </h4>
                                <small class="text-muted">Register bank account details for transactions</small>
                            </div>

                            <!-- Account Number (TextBox1) -->
                            <div class="mb-3">
                                <label class="form-label fw-bold text-dark">
                                    Account Number <span class="text-danger">*</span>
                                </label>
                                <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="true" OnTextChanged="TextBox1_TextChanged" 
                                    CssClass="form-control py-2" placeholder="e.g. 1001234567"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ControlToValidate="TextBox1" ErrorMessage="Account number is required" 
                                    ForeColor="Red" Display="Dynamic" ValidationGroup="vgAcc"></asp:RequiredFieldValidator>
                                <asp:Label ID="lblAccCheck" runat="server" CssClass="fw-bold d-block mt-1"></asp:Label>
                            </div>

                            <!-- Account Type / Name (TextBox2) -->
                            <div class="mb-3">
                                <label class="form-label fw-bold text-dark">Account Type / Holder Name</label>
                                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control py-2" placeholder="Savings / Current"></asp:TextBox>
                            </div>

                            <!-- Balance Amount (TextBox3) -->
                            <div class="mb-3">
                                <label class="form-label fw-bold text-dark">
                                    Balance Amount (₹) <span class="text-danger">*</span>
                                </label>
                                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control py-2" placeholder="e.g. 5000"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                    ControlToValidate="TextBox3" ErrorMessage="Balance amount is required" 
                                    ForeColor="Red" Display="Dynamic" ValidationGroup="vgAcc"></asp:RequiredFieldValidator>
                            </div>

                            <!-- Insert Button (Button1) -->
                            <div class="mt-4">
                                <asp:Button ID="Button1" runat="server" Text="Save Account Details" 
                                    CssClass="btn btn-primary text-white rounded-pill px-4 py-2 fw-bold shadow-sm w-100" 
                                    ValidationGroup="vgAcc" OnClick="Button1_Click" />
                            </div>

                            <!-- Message Label -->
                            <asp:Label ID="lblAccMsg" runat="server" CssClass="fw-bold d-block mt-3 text-center"></asp:Label>
                        </asp:Panel>
                    </div>

                    <!-- PANEL 2: Payment Form -->
                    <div class="col-lg-6">
                        <asp:Panel ID="Panel2" runat="server" CssClass="panel-box">
                            <div class="panel-header">
                                <h4 class="text-dark fw-bold mb-0">
                                    <i class="fas fa-credit-card text-success me-2"></i>Make Order Payment
                                </h4>
                                <small class="text-muted">Pay order total using your registered account</small>
                            </div>

                            <!-- Payable Amount Display -->
                            <div class="alert alert-light border border-success d-flex justify-content-between align-items-center mb-4 py-3">
                                <span class="fw-bold text-dark fs-5">Amount to Pay:</span>
                                <asp:Label ID="lblPayableAmount" runat="server" CssClass="text-success fw-bold fs-4">₹0.00</asp:Label>
                            </div>

                            <!-- Account Number to Debit (TextBox4) -->
                            <div class="mb-4">
                                <label class="form-label fw-bold text-dark">
                                    Debit Account Number <span class="text-danger">*</span>
                                </label>
                                <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control py-2" placeholder="Enter Account Number to Pay"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                    ControlToValidate="TextBox4" ErrorMessage="Please enter account number for payment" 
                                    ForeColor="Red" Display="Dynamic" ValidationGroup="vgPay"></asp:RequiredFieldValidator>
                            </div>

                            <!-- Pay Now Button (Button2) -->
                            <div class="mt-4">
                                <asp:Button ID="Button2" runat="server" Text="Pay Now →" 
                                    CssClass="btn btn-success text-white rounded-pill px-4 py-3 fw-bold shadow w-100 fs-5" 
                                    ValidationGroup="vgPay" OnClick="Button2_Click" />
                            </div>

                            <!-- Payment Result Message -->
                            <asp:Label ID="lblPayMsg" runat="server" CssClass="fw-bold d-block mt-3 text-center fs-6"></asp:Label>

                            <!-- Continue / Home Link -->
                            <div class="text-center mt-4 pt-3 border-top">
                                <a href="UserHome.aspx" class="btn btn-outline-primary rounded-pill px-4 fw-bold">
                                    <i class="fas fa-home me-2"></i>Return to Home
                                </a>
                            </div>

                        </asp:Panel>
                    </div>

                </div>

            </div>
        </div>
    </div>
    <!-- Payment Section End -->

</asp:Content>
