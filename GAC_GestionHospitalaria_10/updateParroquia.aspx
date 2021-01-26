<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="updateParroquia.aspx.cs" Inherits="GAC_GestionHospitalaria_10.updateParroquia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h2>Actualizar Parroquias </h2>
    </div>
    <div class ="row" >
        <div class="p-1" >
            <div class="input-group" >
                <span class="input-group-addon" id="lbl_id" style="width:200px" >Codigo:</span>
                <asp:TextBox ID="txt_Id_Parroquia" runat="server" placeholder="Ingrese el Código" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
     </div> 
      <div class ="row" >
        <div class="p-1" >
            <div class="input-group" >
                <span class="input-group-addon" id="lbl_Parroquia" style="width:200px" >Parroquia:</span>
                <asp:TextBox ID="txt_Parroquia" runat="server" placeholder="Ingrese la Parroquia" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
     </div> 
     <div class ="row">
        <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_Id_Canton" style="width:200px">Id Canton:</span>
	            <asp:DropDownList ID="ddl_Id_Canton" runat="server" CssClass="form-control"  AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
        </div>
     </div> 
       <div class ="row" >
        <div class="p-1" >
            <div class="input-group" >
                <span class="input-group-addon" id="lbl_Numhabitantes" style="width:200px" >Habitantes:</span>
                <asp:TextBox ID="txt_Numhabitantes" runat="server" placeholder="Ingrese  Numero de Habitantes" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
     </div>
    <div class ="row">
        <div class="p-1">
            <div class="btn-group" role ="group" aria-level =""> 
                <asp:Button ID="btn_Guardar" runat="server" Text="Guadar"  CssClass="btn btn-info" OnClick="btn_Guardar_Click" />
                <asp:Button ID="btn_Salir" runat="server" Text="Salir" CssClass="btn btn-info" OnClick="btn_Salir_Click" />
            </div>
        </div>
    </div>


</asp:Content>
