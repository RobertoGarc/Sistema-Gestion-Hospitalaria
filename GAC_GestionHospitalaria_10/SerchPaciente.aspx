﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SerchPaciente.aspx.cs" Inherits="GAC_GestionHospitalaria_10.SerchPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <div>
            <h2> Administrar Pacientes </h2>
            <p>&nbsp;</p>
        </div>
       <div>
           <table style="width:100%;">
               <tr>
                   <td style="width: 60px; height: 68px;"></td>
                    <td style="height: 68px">

                        <div class="input-group">
                            <span class="input-group-btn">
                                <asp:LinkButton ID="lb_Buscar" runat="server" CssClass="btn btn-info" Text="Buscar" OnClick="lb_Buscar_Click"  ><span class="glyphicon glyphicon-search"></span>&nbspBuscar</asp:LinkButton>
                            </span>                 
                              <asp:TextBox ID="txt_Criterio" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                   </td>
               </tr>
               <tr>
                   <td style="width: 60px">&nbsp;</td>
                    <td> </td>
               </tr>
              
                <tr>
                   <td style="width: 60px">&nbsp;</td>
                   <td>
                       <asp:UpdatePanel ID="udp_Pacientes" runat="server">
                           <ContentTemplate>
                               <asp:GridView ID="gv_Pacientes" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_Pacientes_RowCommand" CellPadding="4" ForeColor="#333333" GridLines="None" >
                                   <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                   <Columns>
                                       <asp:BoundField DataField="Id_paciente" HeaderText="Id_Paciente" />
                                       <asp:BoundField DataField="Cedula" HeaderText="Cedula" />
                                       <asp:BoundField DataField="Nombre1" HeaderText="Nombre Primario" />
                                       <asp:BoundField DataField="Nombre2" HeaderText="Nombre Secundario" />
                                       <asp:BoundField DataField="Apellido1" HeaderText="Apellido Primario" />
                                       <asp:BoundField DataField="Apellido2" HeaderText="Apellido Secundario" />
                                       <asp:BoundField DataField="TipoSangre" HeaderText="TipoSangre" />
                                       <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha Nacimiento" />
                                       <asp:BoundField DataField="Sexo" HeaderText="Sexo" />
                                       <asp:BoundField DataField="Condicion" HeaderText="Condicion" />
                                       <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                                       <asp:BoundField DataField="FamliarContacto" HeaderText="FamiliarContacto" />
                                       <asp:BoundField DataField="TelefonoP" HeaderText="TelefonoP" />
                                       <asp:BoundField DataField="Email" HeaderText="Email" />
                                       <asp:BoundField DataField="TelefonoC" HeaderText="TelefonoC" />
                                       <asp:BoundField DataField="Parentesco" HeaderText="Parentesco" />
                                       <asp:ButtonField CommandName="Actualizar" HeaderText="Actualizar" Text="Actualizar" />
                                       <asp:ButtonField CommandName="Eliminar" HeaderText="Eliminar" Text="Eliminar" />
                                   </Columns>
                                   <EditRowStyle BackColor="#999999" />
                                   <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                   <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                   <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                   <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                   <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                   <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                   <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                   <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                   <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                               </asp:GridView>
                           </ContentTemplate>
                           <Triggers>
                               <asp:AsyncPostBackTrigger ControlID="lb_Buscar" EventName="Click" />
                           </Triggers>
                       </asp:UpdatePanel>
                    </td>
               </tr>
                <tr>
                   <td style="width: 60px; height: 20px;"></td>
                   <td style="height: 20px">
                          <div class ="row">
                             <div class="p-1">
                                    <div class="btn-group" role ="group" aria-level =""> 
                                            <asp:Button ID="btn_Nuevo" runat="server" Text="Nuevo" CssClass="btn btn-info" OnClick="btn_Nuevo_Click"/>
                                            <asp:Button ID="btn_Salir" runat="server" Text="Salir" CssClass="btn btn-info" OnClick="btn_Salir_Click" />
                                    </div>
                             </div>
                          </div>
                   </td>
               </tr>
           </table>
      </div>





</asp:Content>