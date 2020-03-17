const buttonsCreateField = document.querySelectorAll('.createField');

for (let i = 0; i < buttonsCreateField.length; i++) {
    buttonsCreateField[i].addEventListener('click', onCreateFieldClick);
}


function deleteField(event) {
    event.preventDefault();
    const target = event.target;
    const deletedItem = target.parentNode.parentNode.parentNode;
    deletedItem.remove();
}

function onCreateFieldClick(e) {
    e.preventDefault();
    let countFields = 0;

    for (let i = 0; i < e.target.parentNode.childNodes.length; i++) {
        const childNode = e.target.parentNode.childNodes[i];
        if (childNode.classList !== undefined && childNode.classList.contains('fieldContainer')) {
            countFields++;
        }
    }

    if (countFields !== 5) {
        createField(e.target);
    }
}

function createField(node,nameField, typeField,fullEdit) {
        const field = document.createElement('div');
        field.className = 'fieldContainer';
            field.innerHTML = `<div class="row">
                                    <div class="col-4">
                                        <label>Название поля</label>
                                    </div>
                                    <div class="col-4">
                                        <label>Тип поля</label>
                                    </div>
                                    <div class="col-4">
                                        <button class="btn btn-danger delete-field 
                                        ${fullEdit == false ? 'd-none' : ''}"
                                        onclick="deleteField(event)">Удалить поле</button>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-4">
                                        <input type="text" name="nameField" class="form-control"
                                               value="${nameField !== undefined ? nameField:''}" placeholder="Название">
                                    </div>
                                    <div class="col-4">
                                        <select name="typeField" ${fullEdit == false ? 'disabled' : ''}>
                                            <option ${typeField === 'Числовой' ? 'selected' :''}>Числовой</option>
                                            <option ${typeField === 'Строковый' ? 'selected' : ''}>Строковый</option>
                                            <option ${typeField === 'Текстовый' ? 'selected' : ''}>Текстовый</option>
                                            <option ${typeField === 'Дата' ? 'selected' : ''}>Дата</option>
                                            <option ${typeField === 'Логический' ? 'selected' : ''}>Логический</option>
                                        </select>
                                    </div>
                                </div>`;
        node.before(field);
}

function getCookie(name) {
    let matches = document.cookie.match(new RegExp(
        "(?:^|; )" + name.replace(/([\.$?*|{}\(\)\[\]\\\/\+^])/g, '\\$1') + "=([^;]*)"
    ));
    return matches ? decodeURIComponent(matches[1]) : undefined;
}

const buttonsDelete = document.querySelectorAll('.deleteCollection');

for (let i = 0; i < buttonsDelete.length; i++) {
    buttonsDelete[i].addEventListener('click', e => {
        document.querySelector('#idCollection').value = e.target.getAttribute("collectionId");
    });
}

const buttonsEdit = document.querySelectorAll('.editCollection');

for (let i = 0; i < buttonsEdit.length; i++) {
    buttonsEdit[i].addEventListener('click', e => {
        document.querySelector('#idCollectionEdit').value = e.target.getAttribute("collectionId");
        let fields = e.target.getAttribute("collectionFields").split(';');

        const buttonCreateFieldEdit = document.querySelector('#createFieldEdit');

        for (let i = 0; i < buttonCreateFieldEdit.parentNode.childNodes.length; i++) {
            const childNode = buttonCreateFieldEdit.parentNode.childNodes[i];
            if (childNode.classList !== undefined && childNode.classList.contains('fieldContainer')) {
                childNode.remove();
                i--;
            }
        }

        document.querySelector('#nameCollectionEdit').value = e.target.getAttribute("collectionName");
        document.querySelector('#descriptionEdit').value = e.target.getAttribute("collectionDescription");

        let countItemsInCollection = e.target.getAttribute("collectionCount");
        console.log(countItemsInCollection);
        fullEdit = true;
        if (countItemsInCollection != 0) {
            fullEdit = false;
        }
        
        for (let i = 0; i < fields.length; i++) {
            let field = fields[i].split(',');
            createField(buttonCreateFieldEdit, field[0], field[1], fullEdit);
        }
    });
}

const nicknameUser = document.querySelector("#nicknameUser");
nicknameUser.value = getCookie("NicknameAutorizeUser");
