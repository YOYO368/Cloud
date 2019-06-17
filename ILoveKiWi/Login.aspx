<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ILoveKiWi.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <fieldset style="background-color:lavender">
           <legend style="height: 54px">Login</legend>
           <table>
               <tr>
                   <td style="width: 268px; height: 30px">
                       <asp:Label ID="Label1" runat="server" Text="User ID :"></asp:Label>
                   </td>
                   <td style="width: 400px;height: 30px">
                       <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td style="width: 268px">&nbsp;</td>
               </tr>
               <tr>
                   <td style="width: 268px; height: 30px">
                       <asp:Label ID="Label2" runat="server" Text="Password :"></asp:Label>
                   </td>
                   <td style="width: 400px; height: 30px">
                       <asp:TextBox ID="txtUserPasswd" runat="server"></asp:TextBox>
                   </td>
               </tr>
                <tr>
                   <td style="width: 268px"></td>
               </tr>
               <tr>
                   <td style="width: 268px"></td>
                   <td style="width: 400px">
                       <asp:Button ID="btnLogin" runat="server" Text="Login" Width="298px" />
                   </td>
                   <td></td>
               </tr>
               <tr>
                   <td style="width: 268px"></td>
               </tr>
           </table>
       </fieldset>
    </form>
</asp:Content>
