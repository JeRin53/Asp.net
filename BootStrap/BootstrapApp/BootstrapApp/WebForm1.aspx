<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="BootstrapApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.7.1/dist/jquery.slim.min.js"></script>
     <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
                <p>Use the contextual classes to provide "meaning through colors":</p>
                  <p class="text-muted">This text is muted.</p>
                  <p class="text-primary">This text is important.</p>
                  <p class="text-success">This text indicates success.</p>
                  <p class="text-info">This text represents some information.</p>
                <button type="button" class="btn btn-primary active">Active</button>
                <button type="button" class="btn btn-primary disabled">Disabled</button>

                <button class="btn btn-primary">
                    <span class="spinner-border spinner-border-sm"></span>
                    Loading..
                </button>

                <button class="btn btn-primary" disabled>
                    <span class="spinner-grow spinner-grow-sm"></span>Loading..
                </button>
            </div>
        </div>
    </form>
</body>
</html>
