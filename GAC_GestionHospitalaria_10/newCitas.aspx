<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="newCitas.aspx.cs" Inherits="GAC_GestionHospitalaria_10.newCitas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2>Ingreso de Citas </h2>
    </div>
    <div class ="row" >
        <div class="p-1" >
            <div class="input-group" >
                <span class="input-group-addon" id="lbl_id" style="width:200px" >Codigo:</span>
                <asp:TextBox ID="txt_Id_Citas" runat="server" placeholder="Ingrese el Código" CssClass="form-control" Width="300px"></asp:TextBox>
            </div>
        </div>
     </div> 
     <div class ="row">
        <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_Id_Paciente" style="width:200px">Id Paciente:</span>
	            <asp:DropDownList ID="ddl_Id_Paciente" runat="server" CssClass="form-control"  AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
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
	            <span class="input-group-addon" id="lbl_Id_Medico" style="width:200px">Id Medico:</span>
	            <asp:DropDownList ID="ddl_Id_Medico" runat="server" CssClass="form-control"  AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
        </div>
     </div>
     <div class ="row">
        <div class="p-1">
            <div class="input-group" style="left: 0px; top: 0px">
                <span class="input-group-addon" id="lbl_Fecha" style="width:200px">Fecha:</span>
                <asp:TextBox ID="txt_Fecha" runat="server" placeholder="Ingrese Fecha " CssClass="form-control" ></asp:TextBox>
                <asp:Calendar ID="Calendar1" runat="server" SelectedDate="07/22/2018 14:50:51" OnSelectionChanged="Calendar1_SelectionChanged" ></asp:Calendar>    
            </div>
        </div>
     </div>   
     <div class ="row">
        <div class="p-1">
            <div class="input-group" style="left: 0px; top: 0px">
                <span class="input-group-addon" id="lbl_Hora" style="width:200px">Hora:</span>
                <asp:TextBox ID="txt_Hora" runat="server" placeholder="Ingrese Hora " CssClass="form-control" ></asp:TextBox>
                
           
                
            </div>
        </div>
     </div>   
     <div class ="row">
        <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_Estado" style="width:200px">Estado:</span>
	            <asp:DropDownList ID="ddl_Estado" runat="server" CssClass="form-control"  AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
        </div>
     </div>
      <div class ="row" >
        <div class="p-1" >
            <div class="input-group" >
                <span class="input-group-addon" id="lbl_Observacion" style="width:200px" >Observacion:</span>
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
