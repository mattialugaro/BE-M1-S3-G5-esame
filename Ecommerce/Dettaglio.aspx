<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dettaglio.aspx.cs" Inherits="Ecommerce.Dettaglio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Dettaglio Prodotto</title>
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
                    <li class="nav-item"><a class="nav-link" runat="server" href="Carrello.aspx">Carrello</a></li>
                </ul>
            </div>
        </div>
    </nav>
    <form id="form1" runat="server">
        <h1 class="text-center">Dettaglio Prodotto</h1>

        <div class="d-flex justify-content-center align-items-center">
            <div class="card mt-5">
                <asp:Image CssClass="card-img-top mx-auto my-2" ID="itemImg" Height="420px" AlternateText="Foto Prodotto" runat="server" />
                <div class="card-body text-center">
                    <h5 id="itemNome" runat="server"></h5>
                    <p id="itemDescrizione" runat="server"></p>
                    <p id="itemPrezzo" runat="server"></p>
                    <asp:Button CssClass="btn btn-success" ID="Add" runat="server" Text="Aggiungi al Carrello" OnClick="Add_Click" />
                </div>
            </div>
        </div>

    </form>
</body>
</html>
