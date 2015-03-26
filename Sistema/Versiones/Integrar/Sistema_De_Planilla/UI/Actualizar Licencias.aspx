<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="Actualizar Licencias.aspx.cs" Inherits="UI.Actualizar_Licencias" %>


<asp:Content ID="Conten1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .style5
        {
            text-align:center;
            width: 463px;
        }
        .style9
        {
        padding-bottom: 10px;
        width: 200px;
        text-align: right;
    }
        .style10
        {
            text-align: left;
            width: 463px;
        }
        
         #TextArea1
    {
        width: 360px;
    }
        
         .style14
    {
        width: 200px;
    }
        
         </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalIzquierdo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

     <h4 style="margin-top:10px;"> Ingrese los datos del trabajador </h4>
    <table style="width:100%; margin-top:20px; margin-top:10px;">
   
    <tr>
        <td class="style9">
                Cedula:</td>
        <td class="style10">
            <asp:TextBox ID="txtCed" runat="server" style="float: left; margin-left:10px;" 
                Width="139px"></asp:TextBox>
                <asp:Button ID="btConsultarLic" runat="server" Text="Cosnultar" 
                    onclick="btConsultarLic_Click" />
            <br />
            </td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
                &nbsp;</td>
        <td class="style10">
                <asp:Label ID="lblConfirm" runat="server" Text="Label" Visible="False" ForeColor="green"></asp:Label>
        </td>
        <td class="style8">
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
                Tipo de Licencia:</td>
        <td class="style10">
         <asp:DropDownList ID="DropTipo_Lic" runat="server" 
                    style="float: left; margin-left:10px;" Width="143px">
                <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                <asp:ListItem Text="A1" Value="A1"></asp:ListItem>
                <asp:ListItem Text="A2" Value="A2"></asp:ListItem>
                <asp:ListItem Text="A3" Value="A3"></asp:ListItem>
                <asp:ListItem Text="A4" Value="A4"></asp:ListItem>
                <asp:ListItem Text="B1" Value="B1"></asp:ListItem>
                <asp:ListItem Text="B2" Value="B2"></asp:ListItem>
                <asp:ListItem Text="B3" Value="B3"></asp:ListItem>
                <asp:ListItem Text="B4" Value="B4"></asp:ListItem>
                <asp:ListItem Text="C1" Value="C1"></asp:ListItem>
                <asp:ListItem Text="C2" Value="C2"></asp:ListItem>
                <asp:ListItem Text="D1" Value="D1"></asp:ListItem>
                <asp:ListItem Text="D2" Value="D2"></asp:ListItem>
                <asp:ListItem Text="D3" Value="D3"></asp:ListItem>
                <asp:ListItem Text="E1" Value="E1"></asp:ListItem>
                <asp:ListItem Text="E2" Value="E2"></asp:ListItem>
                </asp:DropDownList>
                &nbsp;</td>
        <td class="style8">
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
               Fecha de Vencimiento de Cedula:
               </td>
        <td class="style10">

                <asp:ScriptManager ID="ScriptManager1" runat="server" />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
             <ContentTemplate>
             <asp:DropDownList id="drpCalMonth" Runat="Server" OnSelectedIndexChanged="Set_CalendarVen" AutoPostBack="true" style="margin-left:10px; margin-bottom:10px;" Width="143px"></asp:DropDownList>
             <asp:DropDownList id="drpCalYear" Runat="Server" OnSelectedIndexChanged="Set_CalendarVen" AutoPostBack="true" style="margin-left:10px; margin-bottom:10px;" Width="143px"></asp:DropDownList> 
                 <br />
              <asp:Label ID="lblVen_Ced" runat="server" Text=""></asp:Label>
            <asp:Calendar ID="calven_ced" runat="server" BackColor="White" ondayrender="Calendar1_DayRender"
                    BorderColor="White" Font-Names="Verdana" Font-Size="9pt" 
                    ForeColor="Black" Height="190px" Width="350px" 
                            onselectionchanged="CalVen_Ced_SelectionChanged" BorderWidth="1px" 
                            NextPrevFormat="FullMonth" FirstDayOfWeek="Monday" 
                     ShowGridLines="True" >
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle 
                        VerticalAlign="Bottom" Font-Bold="True" Font-Size="8pt" 
                        ForeColor="#333333" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" 
                        Font-Bold="True" BorderWidth="4px" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
               </ContentTemplate>
            </asp:UpdatePanel>
               </td>
    </tr>
    <tr>
        <td class="style9">
                &nbsp;</td>
        <td class="style10">
                &nbsp;</td>
        <td class="style8">
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
                Tipo de Licencia:</td>
        <td class="style10">
         <asp:DropDownList ID="DropDownList5" runat="server" 
                    style="float: left; margin-left:10px;" Width="143px">
                <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                <asp:ListItem Text="A1" Value="A1"></asp:ListItem>
                <asp:ListItem Text="A2" Value="A2"></asp:ListItem>
                <asp:ListItem Text="A3" Value="A3"></asp:ListItem>
                <asp:ListItem Text="A4" Value="A4"></asp:ListItem>
                <asp:ListItem Text="B1" Value="B1"></asp:ListItem>
                <asp:ListItem Text="B2" Value="B2"></asp:ListItem>
                <asp:ListItem Text="B3" Value="B3"></asp:ListItem>
                <asp:ListItem Text="B4" Value="B4"></asp:ListItem>
                <asp:ListItem Text="C1" Value="C1"></asp:ListItem>
                <asp:ListItem Text="C2" Value="C2"></asp:ListItem>
                <asp:ListItem Text="D1" Value="D1"></asp:ListItem>
                <asp:ListItem Text="D2" Value="D2"></asp:ListItem>
                <asp:ListItem Text="D3" Value="D3"></asp:ListItem>
                <asp:ListItem Text="E1" Value="E1"></asp:ListItem>
                <asp:ListItem Text="E2" Value="E2"></asp:ListItem>
                </asp:DropDownList>
                &nbsp;</td>
        <td class="style8">
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
               Fecha de Vencimiento de Cedula:
               </td>
        <td class="style10">

            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
             <ContentTemplate>
             <asp:DropDownList id="drpCalMonth2" Runat="Server" OnSelectedIndexChanged="Set_CalendarVen" AutoPostBack="true" style="margin-left:10px; margin-bottom:10px;" Width="143px"></asp:DropDownList>
             <asp:DropDownList id="drpCalYear2" Runat="Server" OnSelectedIndexChanged="Set_CalendarVen" AutoPostBack="true" style="margin-left:10px; margin-bottom:10px;" Width="143px"></asp:DropDownList> 
                 <br />
              <asp:Label ID="lblven_ced2" runat="server" Text=""></asp:Label>
            <asp:Calendar ID="calven_ced2" runat="server" BackColor="White" ondayrender="Calendar1_DayRender"
                    BorderColor="White" Font-Names="Verdana" Font-Size="9pt" 
                    ForeColor="Black" Height="190px" Width="350px" 
                            onselectionchanged="CalVen_Ced2_SelectionChanged" BorderWidth="1px" 
                            NextPrevFormat="FullMonth" FirstDayOfWeek="Monday" 
                     ShowGridLines="True" >
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle 
                        VerticalAlign="Bottom" Font-Bold="True" Font-Size="8pt" 
                        ForeColor="#333333" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" 
                        Font-Bold="True" BorderWidth="4px" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
               </ContentTemplate>
            </asp:UpdatePanel>
               </td>
    </tr>
    <tr>
        <td class="style9">
                &nbsp;</td>
        <td class="style10">
                &nbsp;</td>
        <td class="style8">
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
                Tipo de Licencia:</td>
        <td class="style10">
         <asp:DropDownList ID="DropDownList6" runat="server" 
                    style="float: left; margin-left:10px;" Width="143px">
                <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                <asp:ListItem Text="A1" Value="A1"></asp:ListItem>
                <asp:ListItem Text="A2" Value="A2"></asp:ListItem>
                <asp:ListItem Text="A3" Value="A3"></asp:ListItem>
                <asp:ListItem Text="A4" Value="A4"></asp:ListItem>
                <asp:ListItem Text="B1" Value="B1"></asp:ListItem>
                <asp:ListItem Text="B2" Value="B2"></asp:ListItem>
                <asp:ListItem Text="B3" Value="B3"></asp:ListItem>
                <asp:ListItem Text="B4" Value="B4"></asp:ListItem>
                <asp:ListItem Text="C1" Value="C1"></asp:ListItem>
                <asp:ListItem Text="C2" Value="C2"></asp:ListItem>
                <asp:ListItem Text="D1" Value="D1"></asp:ListItem>
                <asp:ListItem Text="D2" Value="D2"></asp:ListItem>
                <asp:ListItem Text="D3" Value="D3"></asp:ListItem>
                <asp:ListItem Text="E1" Value="E1"></asp:ListItem>
                <asp:ListItem Text="E2" Value="E2"></asp:ListItem>
                </asp:DropDownList>
                &nbsp;</td>
        <td class="style8">
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
               Fecha de Vencimiento de Cedula:
               </td>
        <td class="style10">

            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
             <ContentTemplate>
             <asp:DropDownList id="drpCalMonth3" Runat="Server" OnSelectedIndexChanged="Set_CalendarVen" AutoPostBack="true" style="margin-left:10px; margin-bottom:10px;" Width="143px"></asp:DropDownList>
             <asp:DropDownList id="drpCalYear3" Runat="Server" OnSelectedIndexChanged="Set_CalendarVen" AutoPostBack="true" style="margin-left:10px; margin-bottom:10px;" Width="143px"></asp:DropDownList> 
                 <br />
              <asp:Label ID="lblven_ced3" runat="server" Text=""></asp:Label>
            <asp:Calendar ID="calven_ced3" runat="server" BackColor="White" ondayrender="Calendar1_DayRender"
                    BorderColor="White" Font-Names="Verdana" Font-Size="9pt" 
                    ForeColor="Black" Height="190px" Width="350px" 
                            onselectionchanged="CalVen_Ced3_SelectionChanged" BorderWidth="1px" 
                            NextPrevFormat="FullMonth" FirstDayOfWeek="Monday" 
                     ShowGridLines="True" >
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle 
                        VerticalAlign="Bottom" Font-Bold="True" Font-Size="8pt" 
                        ForeColor="#333333" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" 
                        Font-Bold="True" BorderWidth="4px" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
               </ContentTemplate>
            </asp:UpdatePanel>
               </td>
    </tr>
    <tr>
        <td class="style9">
                &nbsp;</td>
        <td class="style10">
                &nbsp;</td>
        <td class="style8">
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style14">
                &nbsp;</td>
        <td class="style5">
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" 
                    style="margin-left:auto; margin-right:auto;" onclick="btnAgregar_Click"/>
        </td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style14">
                &nbsp;</td>
        <td class="style5">
                &nbsp;</td>
        <td>
                &nbsp;</td>
    </tr>
</table>

</asp:Content>
