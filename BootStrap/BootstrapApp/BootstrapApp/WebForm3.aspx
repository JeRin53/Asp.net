<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm3.aspx.vb" Inherits="BootstrapApp.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css">
  <script src="https://cdn.jsdelivr.net/npm/jquery@3.7.1/dist/jquery.slim.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>



</head>
<body class="bg-warning">
    <form id="form1" runat="server">
        <div class="card mx-auto mt-5" style="width:400px">
            <div class="card-body">
                <h4 class="card-title">Jerin Joejoe</h4>
                <p class="card-text">Hello bro</p>
                <a class="btn btn-primary" href="#">See Profile</a>
            </div>
            <img class="card-img-bottom" src="College2.jpg" alt="Card Image" style="width:100%">
        </div>

    <div class="text-center mt-3">

    <div class="btn-group btn-group-lg">
        <button type="button" class="btn btn-primary">Apple</button>
        <button type="button" class="btn btn-primary">Samsung</button>

        <div class="btn-group">
            <button type="button"
                    class="btn btn-primary dropdown-toggle"
                    data-toggle="dropdown">
                Sony
            </button>

            <div class="dropdown-menu bg-primary">
                <a class="dropdown-item text-white" href="#">Food</a>
                <a class="dropdown-item text-white" href="#">Tablet</a>
            </div>
        </div>
    </div>

</div>
    </form>
</body>
</html>
