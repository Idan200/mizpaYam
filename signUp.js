function CheckUserName() {
    var usern, usernMsg;
    usern = document.getElementById("uname").value;
    usernMsg = document.getElementById("unameMessage");
    if (usern == "") {
        usernMsg.value = "הכנס שם משתמש";
        return false
    }

    if (usern.length <= 4 || user.legth > 12) {
        usernMsg.value = "בין 4 ל12 תווים";
        return false
    }
    return true
}//end of CheckUserName

function CheckPassword() {
    var userpass, userpassMsg;
    userpass = document.getElementById("upass").value;
    userpassMsg = document.getElementById("upassMessage");
    if (userpass == "") {
        userpassMsg.value = "נא להכניס סיסמה";
        return false
    }

    if (userpass.length < 4 || userpass.length > 10) {
        userpassMsg.value = "בין 3 ל10 תווים";
        return false
    }
    return true
}//end of CheckPassword

//function CheckGrade() {
//    let form = document.forms['form1'];
//    let menu = form.Classes;
//    let options = form.Classes.options;
//    var seletValue = document.getElementByName("uclass");

//    menu.onchange = function () {
//        let optionsValue = this.value;
//        if (optionsValue == document.getElementsByName("Classes").value == "FirstClass1")
//        {
//            seletValue = optionsValue;
//            console.log(seletValue);
//        }
//    }
//}

function CheckAll() {
    var check1 = CheckUserName();
    var check2 = CheckPassword();
    if (check1 && check2 == true)
        return true
    else
        return false
}