const buttonsDeleteUser = document.querySelectorAll('.deleteUser');

for (let i = 0; i < buttonsDeleteUser.length; i++) {
    buttonsDeleteUser[i].addEventListener('click', e => {
        document.querySelector('#deleteUserForm').action = "/Users/Delete?idUser=" + e.target.getAttribute('idUser');
    });
}

const buttonsSetAdmin = document.querySelectorAll('.setAdmin');

for (let i = 0; i < buttonsSetAdmin.length; i++) {
    buttonsSetAdmin[i].addEventListener('click', e => {
        document.querySelector('#setAdminForm').action = "/Users/AppointAdministrator?idUser=" + e.target.getAttribute('idUser');
    });
}

$(document).ready(function () {
    $('#usersTable').DataTable({
        "language": {
            "lengthMenu": "Display _MENU_ records per page",
            "zeroRecords": "Nothing found - sorry",
            "info": "Showing page _PAGE_ of _PAGES_",
            "infoEmpty": "No records available",
            "infoFiltered": "(filtered from _MAX_ total records)"
        }
    });
});
