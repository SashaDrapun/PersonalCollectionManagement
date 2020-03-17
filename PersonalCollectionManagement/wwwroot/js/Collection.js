const checkboxes = document.querySelectorAll('input[type=checkBox]');

for (let i = 0; i < checkboxes.length; i++) {
    checkboxes[i].addEventListener('change', (event) => {
        const target = event.target;
        const checked = event.target.checked;
        target.previousElementSibling.value = checked ? 'on' : 'off';
    });
}

const buttonsDeleteItems = document.querySelectorAll('.deleteItem');

for (let i = 0; i < buttonsDeleteItems.length; i++) {
    buttonsDeleteItems[i].addEventListener('click', e => {
        document.querySelector('#idItemDelete').value = e.target.getAttribute('idItem');
    });
}

const buttonsEditItem = document.querySelectorAll('.editItem');

for (let i = 0; i < buttonsEditItem.length; i++) {
    buttonsEditItem[i].addEventListener('click', e => {
        document.querySelector("#itemName").value = e.target.getAttribute('nameItem');
        document.querySelector("#idItemEdit").value = e.target.getAttribute('idItem');
        const inputsContainers = document.querySelectorAll('.inputContainer');
        const values = e.target.getAttribute('valuesItem').split(',');
        for (let j = 0; j < values.length; j++) {
            if (inputsContainers[j].firstElementChild.classList.contains('d-none')) {
                if (values[j] == 'on') {
                    inputsContainers[j].firstElementChild.value = 'on';
                    inputsContainers[j].firstElementChild.nextElementSibling.checked = true;
                }
            }
            else {
                inputsContainers[j].firstElementChild.value = values[j];
            }
        }
    });
}