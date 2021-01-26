<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="updateHospital.aspx.cs" Inherits="GAC_GestionHospitalaria_10.updateHospital" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div>
        <h2>Actualizar  Hospitales </h2>
    </div>
    <div class ="row" >
        <div class="p-1" >
            <div class="input-group" >
                <span class="input-group-addon" id="lbl_id" style="width:200px" >Codigo:</span>
                <asp:TextBox ID="txt_Id_Hospital" runat="server" placeholder="Ingrese el Código" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class ="row">
        <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Nombre" style="width:200px">Nombre:</span>
                <asp:TextBox ID="txt_Nombre" runat="server" placeholder="Ingrese el Nombre" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class ="row">
      <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_Tipo" style="width:200px">Tipo:</span>
	            <asp:DropDownList ID="ddl_Tipo" runat="server" CssClass="form-control"  AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
      </div>
   </div>
    <div class ="row">
    <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_Categoria" style="width:200px">Categoria:</span>
	            <asp:DropDownList ID="ddl_Categorias" runat="server" CssClass="form-control"  AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
    </div>
         </div>
    <div class ="row">
     <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_Area" style="width:200px">Area:</span>
	            <asp:DropDownList ID="ddl_area" runat="server" CssClass="form-control"  AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
    </div>
   </div>
   <div class ="row">
   <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_Provincia" style="width:200px">Provincia:</span>
	            <asp:DropDownList ID="ddl_Provincia" runat="server" CssClass="form-control"  AutoPostBack="True" Width="300px" OnSelectedIndexChanged="ddl_Provincia_SelectedIndexChanged">
	            </asp:DropDownList>
            </div>
    </div>
  </div>
       <div class ="row">
    <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_Canton" style="width:200px">Canton:</span>
	            <asp:DropDownList ID="ddl_Canton" runat="server" CssClass="form-control"  AutoPostBack="True" Width="300px" OnSelectedIndexChanged="ddl_Canton_SelectedIndexChanged">
	            </asp:DropDownList>
            </div>
    </div>
  </div>

    <div class ="row">
     <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_Parroquia" style="width:200px">Parroquia:</span>
	            <asp:DropDownList ID="ddl_Parroquia" runat="server" CssClass="form-control"  AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
    </div>
  </div>
    <div class ="row">
        <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Direccion" style="width:200px">Direccion:</span>
                <asp:TextBox ID="txt_Direccion" runat="server" placeholder="Ingrese la Direccion" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class ="row">
        <div class="p-1">
        <div class="input-group" style="left: 0px; top: 0px">
                <span class="input-group-addon" id="lbl_Fecha_Creacion" style="width:200px">Fecha Creacion:</span>
                <asp:TextBox ID="txt_Fecha_Creacion" runat="server" placeholder="Ingrese Fecha Creacion" CssClass="form-control" ></asp:TextBox>
                <asp:Calendar ID="Calendar1" runat="server" SelectedDate="07/22/2018 14:50:51" OnSelectionChanged="Calendar1_SelectionChanged" ></asp:Calendar>    
        </div>
    </div>
         </div>
    <div class ="row">
        <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Gerente" style="width:200px">Gerente:</span>
                <asp:TextBox ID="txt_Gerente" runat="server" placeholder="Ingrese el Gerente" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
    </div>
     <div class ="row">
        <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Observacion" style="width:200px">Observacion:</span>
                <asp:TextBox ID="txt_Observacion" runat="server" placeholder ="Ingrese la Observacion" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
    </div>
       <div class ="row">
        <div class="p-1">
            <div class="btn-group" role ="group" aria-level =""> 
                <asp:Button ID="btn_Actualizar" runat="server" Text="Actualizar"  CssClass="btn btn-info" OnClick="btn_Actualizar_Click"/>
                <asp:Button ID="btn_Salir" runat="server" Text="Salir" CssClass="btn btn-info" OnClick="btn_Salir_Click"/>
            </div>
        </div>
    </div>
      






</asp:Content>
