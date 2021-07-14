<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AddPuntoCarga.aspx.cs" Inherits="RegistroEstacionesWeb.AddPuntoCarga" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="bg-light">
        <div class="col-xl-3">
            <asp:Label ID="MensajeLbl" CssClass="Text-success H1" runat="server"></asp:Label>
        </div>
        <div class="container col-sm-4 bg-dark pt-3">
            <div class="card-header bg-info text-white pt-2 text-center">
                Ingresar Punto de Carga
            </div>

            <div class="form-group">
                <label class="control-labe text-warning pt-2" for="idTxt">ID del Punto de Carga</label>
                <asp:TextBox ID="idTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:CustomValidator ID="idCV" runat="server" ErrorMessage="CustomValidator" ValidateEmptyText="true"
                    CssClass="text-danger" ControlToValidate="idTxt" OnServerValidate="idCV_ServerValidate"></asp:CustomValidator>
            </div>
            <div class="form-group">
                <label class="control-label text-warning pt-2" for="tipoRbl">Tipo</label>
                <asp:RadioButtonList ID="tipoRbl" runat="server" CssClass="form-control">
                    <asp:ListItem Value="1" Selected="True" Text="Carga Lenta"></asp:ListItem>
                    <asp:ListItem Value="2" Text="Carga semi rápida"></asp:ListItem>
                    <asp:ListItem Value="3" Text="Carga rápida"></asp:ListItem>
                    <asp:ListItem Value="4" Text="Carga super rápida"></asp:ListItem>
                    <asp:ListItem Value="5" Text="Carga ultra rápida"></asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <div class="form-group">
                <label class="control-label text-warning pt-2" for="capacidadTxt">Capacidad Máxima de Vehículos</label>
                <asp:TextBox ID="capacidadTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:CustomValidator ID="capacidadCV" runat="server" ErrorMessage="CustomValidator" ValidateEmptyText="true"
                    CssClass="text-danger" ControlToValidate="capacidadTxt" OnServerValidate="capacidadCV_ServerValidate"></asp:CustomValidator>
            </div>
            <div class="form-group">
                <label class="control-label text-warning pt-2" for="vidaUtilTxt">Fecha en que deber ser remplazado</label>
                <asp:TextBox ID="vidaUtilTxt" runat="server" CssClass="form-control" type="Date"></asp:TextBox>
                <asp:CustomValidator ID="vidaUtilCV" runat="server" ErrorMessage="CustomValidator" ValidateEmptyText="true"
                    CssClass="text-danger" ControlToValidate="vidaUtilTxt" OnServerValidate="vidaUtilCV_ServerValidate"></asp:CustomValidator>

            </div>
             <div class="container-fluid h-100 pb-3">
                <div class="row w-100 align-items-center">
                <asp:Button ID="RegistrarBtn" runat="server" Text="Registrar Punto Carga" CssClass="btn btn-outline-success btn-lg btn-block" OnClick="RegistrarBtn_Click" />
            <div>
            </div>
</div></div>
        </div>
    </div>

</asp:Content>
