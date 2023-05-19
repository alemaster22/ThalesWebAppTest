var dataTable;
let url;

function allowOnlyNumbers(event) {
    let keyCode = event.which ? event.which : event.keyCode;
    if (keyCode < 48 || keyCode > 57) {
        event.preventDefault();
    }
}


function cargarDatatable(id) {

    if (!$.fn.DataTable.isDataTable('#tblemployes')) {

        populateTable(id);

    } else {
        $('#tblemployes').DataTable().destroy();
        $('#tblemployes').empty();
        populateTable(id);        
    }
}

function populateTable(id)
{
    if (id == 0 || id == "") {
        url = "/Employee/GetAll";        
    }
    else
    {
        url = "/Employee/GetById/" + id;        
    }

    dataTable = $("#tblemployes").DataTable({
        "bFilter": false,
        "ajax": {
            "url": url,
            "type": "GET",
            "datatype": "json",
        },
        "columns": [
            { "data": "id", "width": "10%" },
            { "data": "employee_name", "width": "20%" },
            { "data": "employee_salary", "width": "20%" },
            { "data": "employee_anual_salary", "width": "20%" },
            { "data": "employee_age", "width": "10%" },
            { "data": "profile_image", "width": "20%" }
        ],
        "language": {
            "emptyTable": "No Records"
        },
        "width": "100%"
    });
}


