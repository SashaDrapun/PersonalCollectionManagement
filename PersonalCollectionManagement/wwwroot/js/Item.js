function getCookie(name) {
    let matches = document.cookie.match(new RegExp(
        "(?:^|; )" + name.replace(/([\.$?*|{}\(\)\[\]\\\/\+^])/g, '\\$1') + "=([^;]*)"
    ));
    return matches ? decodeURIComponent(matches[1]) : undefined;
}

const hubConnection = new signalR.HubConnectionBuilder()
    .withUrl("/item")
    .build();

const containerCountLikes = document.querySelector('#countLikes');
let countLikes = document.querySelector('#countLikes').textContent;
let countComments = document.querySelector('#countComments').textContent;

async function CreateLike(nickname, idItem) {
    const response = await fetch("/api/like/", {
        method: "POST",
        headers: { "Accept": "application/json", "Content-Type": "application/json" },
        body: JSON.stringify({
            NicknameUser: nickname,
            IdItem: parseInt(idItem)
        })
    });
    if (response.ok === true) {
        containerCountLikes.textContent = ++countLikes;
        document.querySelector('.like').src = '/img/LikePressed.png';
        document.querySelector('#isUserLike').textContent = 'True';
    }
}

async function AddComment(nickname, idItem, text) {
    const response = await fetch("/api/comment/", {
        method: "POST",
        headers: { "Accept": "application/json", "Content-Type": "application/json" },
        body: JSON.stringify({
            NicknameUser: nickname,
            IdItem: parseInt(idItem),
            Text: text
        })
    });
    if (response.ok === true) {
        const comment = await response.json();
        document.querySelector('#countComments').textContent = ++countComments;
        console.log(comment.dateTime);
        hubConnection.invoke("Send", comment.text, comment.user.nickname, comment.itemId, comment.dateTime);
    }
}

async function DeleteLike(nickname) {
    const response = await fetch("/api/like/" + nickname, {
        method: "DELETE",
        headers: { "Accept": "application/json" }
    });
    if (response.ok) {
        containerCountLikes.textContent = --countLikes;
        document.querySelector('.like').src = '/img/Like.png';
        document.querySelector('#isUserLike').textContent = 'False';
    }
}

document.querySelector('.like').addEventListener('click', () => {
    const nicknameAutorizeUser = getCookie('NicknameAutorizeUser');
    if (nicknameAutorizeUser != undefined) {
        let isUserLike = document.querySelector('#isUserLike').textContent === 'False' ? false : true;
        if (isUserLike) {
            DeleteLike(nicknameAutorizeUser);
        }
        else {
            const idItem = document.querySelector('#idItem').textContent;
            CreateLike(nicknameAutorizeUser, idItem);
        }
    }
    else {
        console.log('Показать модальное окно');
    }
});

document.forms["commentForm"].addEventListener("submit", e => {
    e.preventDefault();
    const nicknameAutorizeUser = getCookie('NicknameAutorizeUser');
    if (nicknameAutorizeUser != undefined) {
        const form = document.forms["commentForm"];
        const text = form.elements["text"].value;
        const idItem = document.querySelector('#idItem').textContent;
        AddComment(nicknameAutorizeUser, idItem, text);
    }
});



hubConnection.on('Send', function (message, userNickname, idItem, dateTime) {
    if (idItem == document.querySelector('#idItem').textContent) {
        const comment = document.createElement('div');
        comment.innerHTML = `<div class="modal-dialog" role="document">
        <div class="modal-content text-white bg-dark">
            <div class="modal-header">
                <h5 class="modal-title">${userNickname}</h5>
                <p>${dateTime}</p>
            </div>
            <div class="modal-body">
                <div class="container-fluid">
                    <span>${message}</span>
                </div>
            </div>
        </div>
    </div>`;
        document.querySelector('#formCommentModal').appendChild(comment);
    }   
});

hubConnection.start();