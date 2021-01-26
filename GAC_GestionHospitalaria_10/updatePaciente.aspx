<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="updatePaciente.aspx.cs" Inherits="GAC_GestionHospitalaria_10.updatePaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h2> Actualizar  Pacientes </h2>
    </div>
    <div class ="row" >
        <div class="p-1" >
            <div class="input-group" >
                <span class="input-group-addon" id="lbl_id" style="width:200px" >Codigo:</span>
                <asp:TextBox ID="txt_Id_Paciente" runat="server" placeholder="Ingrese el Código" CssClass="form-control" Width="300px"></asp:TextBox>
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
                <span class="input-group-addon" id="lbl_Nombre1" style="width:200px" >Nombre Primario:</span>
                <asp:TextBox ID="txt_Nombre1" runat="server" placeholder="Ingrese el Nombre Primario" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
    </div>
     <div class ="row" >
        <div class="p-1" >
            <div class="input-group" >
                <span class="input-group-addon" id="lbl_Nombre2" style="width:200px" >Nombre Secundario:</span>
                <asp:TextBox ID="txt_Nombre2" runat="server" placeholder="Ingrese el Nombre Secundario" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
    </div>
     <div class ="row" >
        <div class="p-1" >
            <div class="input-group" >
                <span class="input-group-addon" id="lbl_Apellido1" style="width:200px" >Apellido Primario:</span>
                <asp:TextBox ID="txt_Apellido1" runat="server" placeholder="Ingrese el Apellido Primario" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
    </div>
     <div class ="row" >
        <div class="p-1" >
            <div class="input-group" >
                <span class="input-group-addon" id="lbl_Apellido2" style="width:200px" >Apellido Secundario:</span>
                <asp:TextBox ID="txt_Apellido2" runat="server" placeholder="Ingrese el Apellido Secundario" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
    </div>
      <div class ="row">
        <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_TipoSangre" style="width:200px">Tipo Sangre:</span>
	            <asp:DropDownList ID="ddl_TipoSangre" runat="server" CssClass="form-control"  AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
        </div>
     </div>
     <div class ="row">
        <div class="p-1">
            <div class="input-group" style="left: 0px; top: 0px">
                <span class="input-group-addon" id="lbl_Fecha_Creacion" style="width:200px">Fecha Creacion:</span>
                <asp:TextBox ID="txt_Fecha_Nacimiento" runat="server" placeholder="Ingrese Fecha Nacimiento" CssClass="form-control" ></asp:TextBox>
                <asp:Calendar ID="Calendar1" runat="server" SelectedDate="07/22/2018 14:50:51" OnSelectionChanged="Calendar1_SelectionChanged"  ></asp:Calendar>    
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
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_Condicion" style="width:200px">Condicion:</span>
	            <asp:DropDownList ID="ddl_Condicion" runat="server" CssClass="form-control"  AutoPostBack="True" Width="300px">
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
                <span class="input-group-addon" id="lbl_Telefonop" style="width:200px">Telefono:</span>
                <asp:TextBox ID="txt_Telefonop" runat="server" placeholder="Ingrese el Telefono" CssClass="form-control" Width="300px"></asp:TextBox>
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
                <span class="input-group-addon" id="lbl_FamiliarContacto" style="width:200px">Contacto Familiar:</span>
                <asp:TextBox ID="txt_FamiliarContacto" runat="server" placeholder="Ingrese el Contacto Familiar" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class ="row">
        <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_TelefonoC" style="width:200px">Telefono C:</span>
                <asp:TextBox ID="txt_TelefonoC" runat="server" placeholder="Ingrese el Telefono C" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class ="row">
      <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_Parentescos" style="width:200px">Parentesco:</span>
	            <asp:DropDownList ID="ddl_Parentescos" runat="server" CssClass="form-control"  AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
      </div>
   </div>  
    <div class ="row">
        <div class="p-1">
            <div class="btn-group" role ="group" aria-level =""> 
                <asp:Button ID="btn_Guardar" runat="server" Text="Guadar"  CssClass="btn btn-info" OnClick="btn_Guardar_Click"  />
                <asp:Button ID="btn_Salir" runat="server" Text="Salir" CssClass="btn btn-info" OnClick="btn_Salir_Click"  />
            </div>
        </div>
    </div> 

</asp:Content>
