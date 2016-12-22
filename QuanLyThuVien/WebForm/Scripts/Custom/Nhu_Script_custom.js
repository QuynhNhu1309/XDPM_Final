
function createTable_MuonSach() {


    var $j = jQuery.noConflict();
    var id_dau_sach = $j("#id_dau_sach").val();
    var check_so_luong_muon = $j('#' + id_dau_sach).val();
    var so_luong_muon = $j("#so_luong").val();
    if (so_luong_muon > check_so_luong_muon) {
        //document.getElementById("error").innerHTML = "Số lượng sách chỉ còn";
        alert("Số lượng sách hiện tại chỉ còn " + check_so_luong_muon);
    }
    else {
        var table = document.getElementById("table_create_phieu_muon");
        var row = table.insertRow(1);
        var cell1 = row.insertCell(0);

        var cell2 = row.insertCell(1);
        var cell3 = row.insertCell(2);
        var cell4 = row.insertCell(3);
        //var cell4 = row.insertCell(3);
        //var cell5 = row.insertCell(4);
        var ten_dau_sach = $j("#id_dau_sach option:selected").text();
        //alert(so_luong_muon);
        // alert(id_dau_sach);
        //alert(check_so_luong_muon);
        //alert(ten_dau_sach);

        //console.log(so_luong_muon);
        console.log(check_so_luong_muon);
        //if (so_luong_muon > check_so_luong_muon) {
        //    //document.getElementById("error").innerHTML = "Số lượng sách chỉ còn";
        //    alert("check");
        //}
        //if (so_luong_muon < check_so_luong_muon) {
        //    //document.getElementById("error").innerHTML = "Số lượng sách chỉ còn";
        //    alert("check1");
        //}
        cell1.innerHTML = so_luong_muon;
        cell2.innerHTML = ten_dau_sach;
        cell3.innerHTML = so_luong_muon;
        //var removeRow = document.createElement("BUTTON");
        cell4.innerHTML = '<button class="btn btn-danger btn-xs my-xs-btn" type="button" id="' + id_dau_sach + '" onClick="myDeleteFunction()" >'
        + ' Xóa </button>';
    }
   
   
    
}

function myDeleteFunction() {
    document.getElementById("table_create_phieu_muon").deleteRow(1);
}


function Process_Them_PM()
{
    
    var arr = new Array();
    var $j = jQuery.noConflict();
    for (var r = 1, n = document.getElementById('table_create_phieu_muon').rows.length; r < n; r++) {
       
        for (var c = 0, m = document.getElementById('table_create_phieu_muon').rows[r].cells.length; c < m; c++) {
            
            tmp = document.getElementById('table_create_phieu_muon').rows[r].cells[c].innerHTML;
            if (c % 3 == 0 && c > 1)
            {
                tmp1 = document.getElementById('table_create_phieu_muon').rows[r].cells[c].innerHTML;
                tmp = tmp1.substring(66, 68);
                if(tmp.search('"'))
                {
                    tmp = tmp.substring(0, 1);
                }
                //tmp = document.getElementsByClassName("btn").button.id;
                //tmp = $j('#table_create_phieu_muon').closest('tr').find('td').eq(3).children('button').attr('id');
                //tmp = tmp1.attr("id");
                //tmp = $j('#table_create_phieu_muon').closest('tr').closest('td').find('button').attr('id');
            }
            arr.push(tmp);
            
           
         }
    }

   

    arr.push($j('#ngay_muon').val());
    arr.push($j('#ngay_tra').val());
    arr.push($j('#id_doc_gia').val());

    //var ngay_muon = $j('#ngay_muon').val();
    //var ngay_tra = $j('#ngay_tra').val();
    //var id_doc_gia = $j('#id_doc_gia').val();
    //var id_dau_sach;
    //var so_luong_muon;
    //var ten_dau_sach;
    
    var list = [];

    var obj = {
        list : arr,
    };

    

    jQuery.ajax({
        url: '/MuonSach/Create',
        type: 'POST',
        data: JSON.stringify(obj),
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            //console.log(JSON.stringify(arr));
            console.log(data);
        },
        error: function () {
            //alert("error");
            console.log(JSON.stringify(obj));
        }
    });


   
}