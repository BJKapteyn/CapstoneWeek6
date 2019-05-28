let pass = () => document.getElementById("pass");
let rePass = () => document.getElementById("rePass");

let passError = document.getElementById("passError");
let submit = document.getElementById("submit");

submit.addEventListener('click', function (event) {
    debugger;
    if (pass().value != rePass().value) {
        event.preventDefault();
        passError.innerText = "Passwords didn't match";
        setTimeout(function () { passError.innerText = ""; }, 2000);
    }
});
