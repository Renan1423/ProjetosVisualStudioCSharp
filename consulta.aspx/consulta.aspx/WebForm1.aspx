<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="consulta.aspx.WebForm1" %>

<script runat = "server">

    public void Page_Load(){
        String strConexao = "Password=etesp; Persist Security Info = True; User ID = sa; Initial Catalog = Teste; Data Source =" + Environment.MachineName;
        SqlConnection objConexao = new SqlConnection(strConexao);
        String concatena = "";
        String strSQL = "SELECT * FROM contatos";
        SqlCommand objCommand = new SqlCommand (strSQL, objConexao);
        String concatena = "";
        String strSQL = "SELECT * FROM contatos";
        SqlCommand objCommand = new SqlCommand(strSQL, objConexao);
        objConexao.Open();
        dr = objCommand.ExecuteReader();
        concatena = "%";
        while(dr.Read()){
            concatena += (dr[0].ToString()) + ",";
            concatena += (dr[1].ToString()) + ",";
            concatena += (dr[2].ToString()) + ";";
        }
        concatena += "^";
        Label1.Text = concatena;
    }


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp: Label ID = "Label1" runat = "server"></asp:Label>
    </div>
    </form>
</body>
</html>
<form id="form1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
</form>
