<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UserFeedback.aspx.cs" Inherits="Project_1.UserFeedback" %>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .feedback-card {
            background: #ffffff;
            border-radius: 15px;
            padding: 35px;
            box-shadow: 0 5px 25px rgba(0,0,0,0.08);
            margin-top: 30px;
            margin-bottom: 50px;
        }
        .section-header {
            border-bottom: 2px solid #81c408;
            padding-bottom: 12px;
            margin-bottom: 25px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Single Page Header start -->
    <div class="container-fluid page-header py-5">
        <h1 class="text-center text-white display-6">Product Feedback</h1>
        <ol class="breadcrumb justify-content-center mb-0">
            <li class="breadcrumb-item"><a href="UserHome.aspx">Home</a></li>
            <li class="breadcrumb-item active text-white">Feedback</li>
        </ol>
    </div>
    <!-- Single Page Header End -->

    <!-- Feedback Section Start -->
    <div class="container-fluid py-4">
        <div class="container py-3">
            <div class="feedback-card">
                
                <div class="row g-4">
                    
                    <!-- Left Column: Submit Feedback Form -->
                    <div class="col-lg-5">
                        <div class="p-4 bg-light rounded-4 border">
                            <div class="section-header">
                                <h4 class="text-dark fw-bold mb-0">
                                    <i class="fas fa-comment-dots text-primary me-2"></i>Send Feedback
                                </h4>
                                <small class="text-muted">Tell us about your experience with our products</small>
                            </div>

                            <!-- Product ID (TextBox1) -->
                            <div class="mb-3">
                                <label class="form-label fw-bold text-dark">
                                    Product ID <span class="text-danger">*</span>
                                </label>
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control py-2" placeholder="e.g. 1"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ControlToValidate="TextBox1" ErrorMessage="Product ID is required" 
                                    ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>

                            <!-- Feedback Message (TextBox2) -->
                            <div class="mb-3">
                                <label class="form-label fw-bold text-dark">
                                    Feedback Message <span class="text-danger">*</span>
                                </label>
                                <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Rows="4" 
                                    CssClass="form-control py-2" placeholder="Write your feedback, questions, or comments here..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                    ControlToValidate="TextBox2" ErrorMessage="Feedback message is required" 
                                    ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>

                            <!-- Submit Button (Button1) -->
                            <div class="mt-4">
                                <asp:Button ID="Button1" runat="server" Text="Submit Feedback" 
                                    CssClass="btn btn-primary text-white rounded-pill px-4 py-2 fw-bold shadow-sm w-100" 
                                    OnClick="Button1_Click" />
                            </div>

                            <!-- Message Label (Label1) -->
                            <asp:Label ID="Label1" runat="server" CssClass="fw-bold d-block mt-3 text-center"></asp:Label>
                        </div>
                    </div>

                    <!-- Right Column: User Feedback History -->
                    <div class="col-lg-7">
                        <div class="p-4 bg-white rounded-4 border">
                            <div class="section-header d-flex justify-content-between align-items-center flex-wrap gap-2">
                                <div>
                                    <h4 class="text-dark fw-bold mb-0">
                                        <i class="fas fa-history text-success me-2"></i>My Previous Feedbacks
                                    </h4>
                                    <small class="text-muted">Showing your active (pending) & completed (replied) feedback</small>
                                </div>
                                <div>
                                    <a href="ViewAllProducts.aspx" class="btn btn-sm btn-outline-primary rounded-pill">
                                        <i class="fas fa-box-open me-1"></i>Find Products
                                    </a>
                                </div>
                            </div>

                            <div class="table-responsive">
                                <asp:GridView ID="gvUserFeedback" runat="server" AutoGenerateColumns="False" 
                                    CssClass="table table-hover table-bordered align-middle text-center mb-0 bg-white"
                                    HeaderStyle-CssClass="table-light text-dark fw-bold"
                                    EmptyDataText="You have not submitted any feedbacks yet. Submit your first feedback using the form on the left.">
                                    <Columns>
                                        <%-- Product Name / ID --%>
                                        <asp:BoundField DataField="Prod_Name" HeaderText="Product" NullDisplayText="General" ItemStyle-Font-Bold="True" ItemStyle-CssClass="text-dark" />

                                        <%-- Feedback Message --%>
                                        <asp:BoundField DataField="Feed_Msg" HeaderText="My Feedback" ItemStyle-CssClass="text-start ps-3" />

                                        <%-- Date --%>
                                        <asp:BoundField DataField="Feed_Date" HeaderText="Date" DataFormatString="{0:yyyy-MM-dd}" ItemStyle-Width="105px" />

                                        <%-- Feedback Status (Active vs Completed) --%>
                                        <asp:TemplateField HeaderText="Status" ItemStyle-Width="110px">
                                            <ItemTemplate>
                                                <%# Eval("Feed_Status").ToString() == "0" ? "<span class='badge bg-success px-2 py-1 text-white'><i class='fas fa-check-circle me-1'></i>Completed</span>" : "<span class='badge bg-warning px-2 py-1 text-dark'><i class='fas fa-clock me-1'></i>Active</span>" %>
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <%-- Admin Reply Message --%>
                                        <asp:TemplateField HeaderText="Admin Response">
                                            <ItemTemplate>
                                                <%# Eval("Feed_Status").ToString() == "0" && !string.IsNullOrWhiteSpace(Eval("Reply_Msg").ToString()) ? "<div class='text-start p-2 bg-light rounded border border-success'><strong class='text-success d-block'><i class='fas fa-reply me-1'></i>Admin:</strong> " + Eval("Reply_Msg") + "</div>" : "<span class='text-muted small fst-italic'><i class='fas fa-hourglass-half me-1 text-warning'></i>Awaiting reply</span>" %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>

                </div>

            </div>
        </div>
    </div>
    <!-- Feedback Section End -->

</asp:Content>
