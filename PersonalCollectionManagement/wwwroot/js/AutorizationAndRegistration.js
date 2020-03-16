const autorizationLink = document.querySelector('.nav-item.autorization');
const registrationLink = document.querySelector('.nav-item.registration');
const userNicknameLink = document.querySelector('.nav-item.userNickname');
const userNicknameText = document.querySelector('#userNickname');
const buttonExitContainer = document.querySelector('.nav-item.buttonContainer');
const buttonExit = document.querySelector('#exit');

async function Autorization(email, password) {
    const response = await fetch("/api/account", {
        method: "PUT",
        headers: { "Accept": "application/json", "Content-Type": "application/json" },
        body: JSON.stringify({
            email: email,
            password: password
        })
    });
    if (response.ok === true) {
        console.log("Пользователь залогинен");
        $(".close.autorization").click();
        LoadMenu();
    }
}

async function Registration(userNickname, userEmail, userPassword) {
    const response = await fetch("/api/account", {
        method: "POST",
        headers: { "Accept": "application/json", "Content-Type": "application/json" },
        body: JSON.stringify({
            nickname: userNickname,
            email: userEmail,
            password: userPassword
        })
    });
    if (response.ok === true) {
        console.log("Пользователь зарегистрирован");
        $(".close.registration").click();
        LoadMenu();
    }
}

function getCookie(name) {
    let matches = document.cookie.match(new RegExp(
        "(?:^|; )" + name.replace(/([\.$?*|{}\(\)\[\]\\\/\+^])/g, '\\$1') + "=([^;]*)"
    ));
    return matches ? decodeURIComponent(matches[1]) : undefined;
}

function setCookie(name, value, options = {}) {
    options = {
        path: '/',
        ...options
    };
    if (options.expires instanceof Date) {
        options.expires = options.expires.toUTCString();
    }

    let updatedCookie = encodeURIComponent(name) + "=" + encodeURIComponent(value);

    for (let optionKey in options) {
        updatedCookie += "; " + optionKey;
        let optionValue = options[optionKey];
        if (optionValue !== true) {
            updatedCookie += "=" + optionValue;
        }
    }

    document.cookie = updatedCookie;
}
// Пример использования:
//setCookie('user', 'John', { secure: true, 'max-age': 3600 });

function deleteCookie(name) {
    setCookie(name, "", {
        'max-age': -1
    })
}


function LoadMenu() {
    const nameUser = getCookie("NicknameAutorizeUser");

    if (nameUser !== undefined) {
        autorizationLink.style.display = 'none';
        registrationLink.style.display = 'none';
        userNicknameLink.style.display = 'block';
        buttonExitContainer.style.display = 'block';
        userNicknameText.textContent = nameUser;
    }
    else {
        autorizationLink.style.display = 'block';
        registrationLink.style.display = 'block';
        userNicknameLink.style.display = 'none';
        buttonExitContainer.style.display = 'none';
        userNicknameText.textContent = '';
    }
}

document.forms["loginForm"].addEventListener("submit", e => {
    e.preventDefault();
    const form = document.forms["loginForm"];
    const email = form.elements["email"].value;
    const password = form.elements["password"].value;

    Autorization(email, password);
});

document.forms["registerForm"].addEventListener("submit", e => {
    e.preventDefault();
    const form = document.forms["registerForm"];
    const nickname = form.elements["nickname"].value;
    const email = form.elements["email"].value;
    const password = form.elements["password"].value;

    Registration(nickname, email, password);
});

buttonExit.addEventListener("click", () => {
    deleteCookie("NicknameAutorizeUser");
    window.location.href = "/Home/Index";
});

LoadMenu();



