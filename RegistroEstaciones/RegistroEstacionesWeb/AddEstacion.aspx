<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AddEstacion.aspx.cs" Inherits="RegistroEstacionesWeb.AddEstacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg-light">
        
        <div class="container col-sm-4 bg-dark pt-3">
            <div class="card-header bg-info text-white pt-2 text-center">
                Ingresar Estación de Servicio
            </div>
            <div class="form-group">
                <label class="control-label text-warning pt-4" for="idTxt">ID de la Estación</label>
                <asp:TextBox ID="idTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:CustomValidator ID="idCV" runat="server" ErrorMessage="CustomValidator" ValidateEmptyText="true"
                    CssClass="text-danger" ControlToValidate="idTxt" OnServerValidate="idCV_ServerValidate"></asp:CustomValidator>
            </div>
            <div class="form-group">
                <label class="control-label text-warning pt-2" for="direccionTxt">Dirección de la estación</label>
                <asp:TextBox ID="direccionTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:CustomValidator ID="direccionCV" runat="server" ErrorMessage="CustomValidator"
                    ValidateEmptyText="true" CssClass="text-danger" ControlToValidate="direccionTxt"
                    OnServerValidate="direccionCV_ServerValidate"></asp:CustomValidator>
            </div>
            <div class="form-group">
                <label class="control-label text-warning pt-2" for="capacidadTxt">Capacidad maxima de Puntos de Carga</label>
                <asp:TextBox ID="capacidadTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:CustomValidator ID="capacidadCV" runat="server" ErrorMessage="CustomValidator"
                    ValidateEmptyText="true" CssClass="text-danger" ControlToValidate="capacidadTxt"
                    OnServerValidate="capacidadCV_ServerValidate"></asp:CustomValidator>
            </div>
            <div class="form-group">
                <label class="control-label text-warning pt-2" for="regionTxt">Región</label>
                <br />
                <asp:DropDownList ID="regionDdl" runat="server" CssClass="dropdown-toggle"></asp:DropDownList>
                <asp:CustomValidator ID="regionCV" runat="server" ErrorMessage="CustomValidator"
                    CssClass="text-danger" ControlToValidate="regionDdl"
                    OnServerValidate="regionCV_ServerValidate"></asp:CustomValidator>
            </div>
            <br />
            <div class="form-group col-xl-5">
                <label class="control-label text-warning pt-2" for="horarioTxt">Horario de atención</label>
                <div class="">
                    <label class="text-warning pt-2" for="apreturaTxt">Apertura</label>
                    <asp:TextBox ID="aperturaTxt" runat="server" type="Time" placeholder="Ej: 08:00" CssClass="dropdown-toggle"></asp:TextBox>
                    <asp:CustomValidator ID="aperturaCV" runat="server" ErrorMessage="CustomValidator"
                        CssClass="text-danger" ControlToValidate="aperturaTxt" ValidateEmptyText="true"
                        OnServerValidate="aperturaCV_ServerValidate"></asp:CustomValidator>
                </div>
                <div class="">
                    <label class="control-label text-warning pt-2" for="cierreTxt">Cierre</label>
                    <asp:TextBox ID="cierreTxt" runat="server" type="Time" placeholder="Ej: 20:00" CssClass="dropdown-toggle"></asp:TextBox>
                    <asp:CustomValidator ID="cierreCV" runat="server" ErrorMessage="CustomValidator"
                        CssClass="text-danger" ControlToValidate="cierreTxt" ValidateEmptyText="true"
                        OnServerValidate="cierreCV_ServerValidate"></asp:CustomValidator>
                </div>
            </div>
            <div>
                <asp:Button ID="RegistrarBtn" runat="server" Text="Registrar Estación" CssClass="btn btn-success" OnClick="RegistrarBtn_Click" />
            </div>
            <div class="col-xl-3">
            <asp:Label ID="MensajeLbl" CssClass="Text-success H1" runat="server"></asp:Label>
        </div>
        </div>
        </div>
</asp:Content>
