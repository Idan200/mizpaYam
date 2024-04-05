<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signUp.aspx.cs" Inherits="mizpa_Yam_Library.signUp.signUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="signUp.css" rel="stylesheet" />
    <title>הרשמה</title>
</head>
<body>
    
    <center>

        <form class="signUpFile" id="form1" runat="server" action="signUp.aspx" method="post" onsubmit="return CheckAll()">
            <div class="fileInfo">
                <h1>הרשמה</h1>
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
                <button class="submitButton" type="submit" id="usubmit" name="usubmit">המשך</button>
            </div>
        </form>

    </center>
    <script src="signUp.js"></script>
</body>
</html>
