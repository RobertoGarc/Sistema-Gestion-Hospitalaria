﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SerchCanton.aspx.cs" Inherits="GAC_GestionHospitalaria_10.SerchCanton" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div>
            <h2> Administrar Canton </h2>
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
                       <asp:UpdatePanel ID="udp_Canton" runat="server">
                           <ContentTemplate>
                               <asp:GridView ID="gv_Canton" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_Canton_RowCommand" CellPadding="4" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px"  >
                                   <AlternatingRowStyle BackColor="White" />
                                   <Columns>
                                       <asp:BoundField DataField="Id_canton" HeaderText="Id_Canton" />
                                       <asp:BoundField DataField="Id_provincia" HeaderText="Id_Provincia" />
                                       <asp:BoundField DataField="Canton" HeaderText="Canton" />
                                       <asp:ButtonField CommandName="Actualizar" HeaderText="Actualizar" Text="Actualizar" />
                                       <asp:ButtonField CommandName="Eliminar" HeaderText="Eliminar" Text="Eliminar" />
                                   </Columns>
                                   <FooterStyle BackColor="#CCCC99" />
                                   <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                   <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                   <RowStyle BackColor="#F7F7DE" />
                                   <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                   <SortedAscendingCellStyle BackColor="#FBFBF2" />
                                   <SortedAscendingHeaderStyle BackColor="#848384" />
                                   <SortedDescendingCellStyle BackColor="#EAEAD3" />
                                   <SortedDescendingHeaderStyle BackColor="#575357" />
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