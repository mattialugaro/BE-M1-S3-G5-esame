<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="Ecommerce.Carrello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Carrello</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous" />
</head>
<body>
    <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark">
        <div class="container">
            <a class="navbar-brand" runat="server" href="Default.aspx">EpiArredo</a>
            <button type="button" class="navbar-toggler" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" title="Attiva/Disattiva spostamento" aria-controls="navbarSupportedContent"
                aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse d-sm-inline-flex justify-content-between">
                <ul class="navbar-nav flex-grow-1">
                    <li class="nav-item"><a class="nav-link" runat="server" href="Default.aspx">Home</a></li>
                    <li class="nav-item"><a class="nav-link" runat="server" href="Carrello.aspx"><strong>Carrello</strong></a></li>
                </ul>
            </div>
        </div>
    </nav>

    <form id="form1" runat="server">
        <div>

            <div class="container">
                <h1 class="text-center">Carrello</h1>
                <div id="carrelloLista" runat="server" class="row row-cols-2 gy-3 mt-5">                    
                </div>

                <asp:Button ID="SvuotaCarrello" CssClass="btn btn-warning mt-5 text-center" runat="server" Text="Svuota Carrello" OnClick="SvuotaCarrello_Click" />
            </div>

        </div>
    </form>
</body>
</html>
