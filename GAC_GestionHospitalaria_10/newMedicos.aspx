<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="newMedicos.aspx.cs" Inherits="GAC_GestionHospitalaria_10.newMedico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <div>
        <h2>Ingreso de Medicos </h2>
    </div>
    <div class ="row" >
        <div class="p-1" >
            <div class="input-group" >
                <span class="input-group-addon" id="lbl_id" style="width:200px" >Codigo:</span>
                <asp:TextBox ID="txt_Id_Medico" runat="server" placeholder="Ingrese el Código" CssClass="form-control" Width="300px" Enabled="False" ></asp:TextBox>
            </div>
        </div>
    </div>
     <div class ="row" >
        <div class="p-1" >
            <div class="input-group" >
                <span class="input-group-addon" id="lbl_Cedula" style="width:200px" >Cedula:</span>
                <asp:TextBox ID="txt_Cedula" runat="server" placeholder="Ingrese la Cedula" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
    </div>
     <div class ="row" >
        <div class="p-1" >
            <div class="input-group" >
                <span class="input-group-addon" id="lbl_Nombres" style="width:200px" >Nombres:</span>
                <asp:TextBox ID="txt_Nombres" runat="server" placeholder="Ingrese los Nombres" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
    </div>
     <div class ="row" >
        <div class="p-1" >
            <div class="input-group" >
                <span class="input-group-addon" id="lbl_Apellidos" style="width:200px" >Apellidos:</span>
                <asp:TextBox ID="txt_Apellidos" runat="server" placeholder="Ingrese los Apellidos" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
    </div>
     <div class ="row">
        <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_Id_Hospital" style="width:200px">Id Hospital:</span>
	            <asp:DropDownList ID="ddl_Id_Hospital" runat="server" CssClass="form-control"  AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
        </div>
     </div>
     <div class ="row">
        <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_Cargo" style="width:200px">Cargo:</span>
	            <asp:DropDownList ID="ddl_Cargo" runat="server" CssClass="form-control"  AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
        </div>
     </div>
     <div class ="row">
        <div class="p-1">
            <div class="input-group" style="left: 0px; top: 0px">
                <span class="input-group-addon" id="lbl_FechaN" style="width:200px">Fecha Nacimiento:</span>
                <asp:TextBox ID="txt_FechaN" runat="server" placeholder="Ingrese Fecha Nacimiento" CssClass="form-control" ></asp:TextBox>
                <asp:Calendar ID="Calendar1" runat="server" SelectedDate="07/22/2018 14:50:51" OnSelectionChanged="Calendar1_SelectionChanged" ></asp:Calendar>    
            </div>
        </div>
     </div>
   <div class ="row">
      <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_Sexo" style="width:200px">Sexo:</span>
	            <asp:DropDownList ID="ddl_Sexo" runat="server" CssClass="form-control"  AutoPostBack="True" Width="300px">
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
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Telefono" style="width:200px">Telefono:</span>
                <asp:TextBox ID="txt_Telefono" runat="server" placeholder="Ingrese el Telefono" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class ="row">
        <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Email" style="width:200px">Email:</span>
                <asp:TextBox ID="txt_Email" runat="server" placeholder="Ingrese el Email" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class ="row">
        <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Login" style="width:200px">Login:</span>
                <asp:TextBox ID="txt_Login" runat="server" placeholder="Ingrese el Login" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class ="row">
        <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Password" style="width:200px">Password:</span>
                <asp:TextBox ID="txt_Password" runat="server" placeholder="Ingrese el Password" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class ="row">
        <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Observacion" style="width:200px">Observacion:</span>
                <asp:TextBox ID="txt_Observacion" runat="server" placeholder="Ingrese la Observacion" CssClass="form-control" Width="300px"></asp:TextBox>
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
