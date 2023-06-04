function modalProcess (){
//$(document).ready(function() {
        $(".tabs").click(function(){
        $(".tabs").removeClass("active");
        $(".tabs button").addClass("text-muted");
        $(this).children("button").removeClass("text-muted");
        $(this).addClass("active");
        current_fs = $(".active");
        next_fs = $(this).attr('id');
        next_fs = "#" + next_fs + "1";
        //$("fieldset").removeClass("show");
        //$(next_fs).addClass("show");
        $("fieldset").removeClass("d-block")
        $("fieldset").addClass("d-none")
        $(next_fs).removeClass("d-none")
        $(next_fs).addClass("d-block")
        //$("fieldset").hide();
        //$(next_fs).show();

        });
    //});
};

$(document).ready(function() {
    $("fieldset").find("table").addClass("modalTable");
    $(".modalTable").find("tr").each(function(){
        $(this).find('td:last-child').after('<td><button class="btn btn-primary editRow"><i class="fa fa-pencil-square-o"></i></button>\
			<button class="btn btn-danger deleteRow"><i class="fa fa-trash-o"></i></button></td>')
    });

$("#addRow").click(function(){
    var newRow = "";
    var lastRow = $(".d-block").find("tr").last();
    var clonedRow = $(lastRow).clone();
    $(clonedRow).find("td").each(function(){
        if ($(this).find("*").length){
            if ($(this).children("button").length){
                console.log($(this).html());
                buttonElement = '<td>\
                <button class="btn btn-primary saveRow">Save</button>\
                <button class="btn btn-danger deleteRow">Cancel</button>\
                </td>';
                newRow = newRow + buttonElement;
            }
            else{
            console.log("in loop");
            elements = $(this).html();
            elements = "<td>"  + elements + "</td>";
            newRow = newRow + elements;
            }
        }
        else{
            newRow = newRow + '<td contenteditable="true"></td>';
        }
    });
    newRowHtml = '<tr class="table-danger" style="text-align: center;"> '+ newRow + '</tr>';
    console.log(newRowHtml);
    $(lastRow).after(newRowHtml);
});

$(".btnModal").click(function() {
        $("#exampleModal").modal("show");
        modalProcess();
    });

$("#exampleModal").on("hide.bs.modal", function(){

    $("fieldset").addClass("d-none")
    $(".tabs button").addClass("text-muted");
    $("#tab01").addClass("active");
    $("#tab01").children("button").removeClass("text-muted");
    $("#tab011").removeClass("d-none");
    $("#tab011").addClass("d-block");

})


$(document).on('click',".deleteRow", function() {
	$(this).parents("tr").hide();
});


$(document).on('click',".editRow", function() {
	$(this).parents("tr").each(function(){
        $(this).find("td").each(function(){
            $(this).prop("contenteditable", "true");
        });
        //$(this).find("td:last-child").removeProp("contenteditable");
		//$(this).find('td:last-child').html('');
        $(this).find('td:last-child').html('<td><button class="btn btn-primary saveRow">Save</button>\
			<button class="btn btn-danger deleteRow">Cancel</button>\
			</td>'
		)

	});

});

$(document).on('click',".saveRow", function() {
	$(this).parents("tr").each(function(){
	    $(this).find("td").each(function(){
        $(this).prop("contenteditable", "false");
        });
            	//$(this).find('td:last-child').html('');
        $(this).find("td:last-child").removeProp("contenteditable");
        $(this).find('td:last-child').html(
		'<td>\
		<button class="btn btn-primary editRow"><i class="fa fa-pencil-square-o"></i></button>\
		 <button class="btn btn-danger deleteRow"><i class="fa fa-trash-o"></i></button>\
			</td>');

	});

});


})




