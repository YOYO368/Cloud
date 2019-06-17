<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ILoveKiWi.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <fieldset>
        <br />
        <legend> Register </legend>
        <br />
        <table style="width: 100%">
            <tr>
                <td style="width: 150px;height:30px">
                    <asp:Label ID="Label_UserID" runat="server" AssociatedControlID="txtUserID" Text="User ID : "></asp:Label>
                </td>
                <td style="width: 300px">
                    <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
                </td>
                <td style="width: 600px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 150px;height:30px">
                    <asp:Label ID="Label_Passwd" runat="server" AssociatedControlID="txtUserPasswd" Text="User Passwd :"></asp:Label>
                </td>
                <td style="width: 300px">
                    <asp:TextBox ID="txtUserPasswd" runat="server"></asp:TextBox>
                </td>
                <td style="width: 600px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 150px;height:30px">
                    <asp:Label ID="Label_ConfirmPasswd" runat="server" AssociatedControlID="txtConfirmPasswd" Text="Confirm Passwd : "></asp:Label>
                </td>
                <td style="width: 300px">
                    <asp:TextBox ID="txtConfirmPasswd" runat="server"></asp:TextBox>
                </td>
                <td style="width: 600px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 150px; height: 30px">
                    <asp:Label ID="Label_UserName" runat="server" AssociatedControlID="txtUserName" Text="User Name : "></asp:Label>
                </td>
                <td style="width: 300px">
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </td>
                <td style="width: 600px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 150px; height: 30px">
                    <asp:Label ID="Label_UserEmail" runat="server" AssociatedControlID="txtUserEmail" Text="User Email : "></asp:Label>
                </td>
                <td style="width: 300px">
                    <asp:TextBox ID="txtUserEmail" runat="server"></asp:TextBox>
                </td>
                <td style="width: 600px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 150px; height: 30px">
                    <asp:Label ID="Label_UserMobile" runat="server" AssociatedControlID="txtUserMobile" Text="User Mobile : "></asp:Label>
                </td>
                <td style="width: 300px">
                    <asp:TextBox ID="txtUserMobile" runat="server"></asp:TextBox>
                </td>
                <td style="width: 600px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 150px">&nbsp;</td>
                <td style="width: 300px; text-align: right">
                    <asp:Button type="button" ID="Button_Register" runat="server" Text="Register" OnClick="Button_Register_Click" Height="40px" Width="200px" />
                </td>
                <td>
                    <asp:Button type="reset" ID="Button_Reset" runat="server" Text="Reset" Height="40px" Width="200px" OnClick="Button_Reset_Click"/>
                </td>
            </tr>
        </table>
    </fieldset>
    </form>
</asp:Content>
