<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="logIn.aspx.cs" Inherits="mizpa_Yam_Library.logIn.logIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="logIn.css" rel="stylesheet" />
    <title>התחברות</title>
</head>
<body>
    

    <center>

    <form class="logInFile" id="form1" runat="server" action="logIn.aspx" method="post">
        <div class="fileInfo">
            <h1>התחברות</h1>
            <input class="info" type="text" id="uname" name="uname" placeholder="שם משתמש" />
            <br />
            <input class="msg" type="text" id="unameMessage" name="unameMessage" value="" />
            <br />
            <br />
            <input class="info" type="password" id="upass" name="upass" placeholder="סיסמה" />
            <br />
            <input class="msg" type="text" id="upassMessage" name="upassMessage" value="" />
            <br />
            <br />
            <button class="submitButton" type="submit" id="usubmit" name="usubmit">התחבר</button>
        </div>
    </form>

</center>

</body>
</html>
