$("document").ready(function () {
	//var $graduate = true;
	//var $experienced = false;
	//var $interns = false;
	//setPosition();

	//function setPosition() {
	//    if ($graduate) {
	//        $("#graduate .nav-link").each(function () {
	//            console.log("graduate: " + $(this).hasClass("active"));
	//            if ($(this).hasClass("active")) {
	//                $(".vie_techno").html($(this).html());
	//                $("#Position").val($(this).html());
	//            }

	//            $(this).click(function () {
	//                if ($(".vie_techno").length) {
	//                    $(".vie_techno").html($(this).html());
	//                    $("#Position").val($(this).html());
	//                }
	//            });
	//        });
	//    }
	//    else if ($experienced) {
	//        $("#experienced .nav-link").each(function () {
	//            console.log("experienced: " + $(this).hasClass("active"));
	//            if ($(this).hasClass("active")) {
	//                $(".vie_techno").html($(this).html());
	//                $("#Position").val($(this).html());
	//            }

	//            $(this).click(function () {
	//                if ($(".vie_techno").length) {
	//                    $(".vie_techno").html($(this).html());
	//                    $("#Position").val($(this).html());
	//                }
	//            });
	//        });
	//    }
	//    else if ($interns) {
	//        $("#interns .nav-link").each(function () {
	//            console.log("interns: " + $(this).hasClass("active"));
	//            if ($(this).hasClass("active")) {
	//                $(".vie_techno").html($(this).html());
	//                $("#Position").val($(this).html());
	//            }

	//            $(this).click(function () {
	//                if ($(".vie_techno").length) {
	//                    $(".vie_techno").html($(this).html());
	//                    $("#Position").val($(this).html());
	//                }
	//            });
	//        });
	//    }
	//}

	//$("#interns").on('click', function () {
	//    $graduate = true;
	//    $experienced = false;
	//    $interns = false;
	//    setPosition();
	//});

	//$("#experienced").on('click', function () {
	//    $graduate = false;
	//    $experienced = true;
	//    $interns = false;
	//    setPosition();
	//});

	//$("#interns").on('click', function () {
	//    $graduate = false;
	//    $experienced = false;
	//    $interns = true;
	//    setPosition();
	//});
	//$(".tab-content .nav-link").each(function () {
	//		if ($(this).hasClass("active")) {
	//			$(".vie_techno").html($(this).html());
	//			$("#Position").val($(this).html());
	//		}

	//		$(this).click(function () {
	//			if ($(".vie_techno").length) {
	//				$(".vie_techno").html($(this).html());
	//				$("#Position").val($(this).html());
	//			}
	//		});
	//	});
	////});

	//$('#graduate-header').on('click', function () {
	//	console.log('graduate clicked');
	//	$("#graduate .nav-link").each(function () {
	//		console.log("graduate: " + $(this).hasClass("active"));
	//		if ($(this).hasClass("active")) {
	//			$(".vie_techno").html($(this).html());
	//			$("#Position").val($(this).html());
	//		}

	//		$(this).click(function () {
	//			if ($(".vie_techno").length) {
	//				$(".vie_techno").html($(this).html());
	//				$("#Position").val($(this).html());
	//			}
	//		});
	//	});
	//});

	//$("#career-form-submit").click(function () {
	//	$(".graduate-list .nav-link").each(function () {
	//		if ($(this).hasClass("active")) {
	//			$(".vie_techno").html($("#graduate-job-role").val());
	//			$("#Position").val($("#graduate-job-role").val());
	//		}
	//	});
	//});


	//$(".tab-content .nav-link").each(function () {
	//	$(this).click(function () {
	//		if ($(".vie_techno").length) {
	//			$(".vie_techno").html($(this).html());
	//		}
	//	})
	//});

	//$('career_nav .nav-item .nav-link').each(function (index) {
	//	console.log(index);
	//});

	var listItems = $("career_nav li a");
	listItems.each(function (idx, li) {
		console.log($(li));
	});

	$('.image-upload-wrap').bind('dragover', function () {
		$('.image-upload-wrap').addClass('image-dropping');
	});
	$('.image-upload-wrap').bind('dragleave', function () {
		$('.image-upload-wrap').removeClass('image-dropping');
	});
});

function readURL(input) {
	if (input.files && input.files[0]) {

		var reader = new FileReader();

		reader.onload = function (e) {
			$('.image-upload-wrap').hide();

			$('.file-upload-image').attr('src', e.target.result);
			$('.file-upload-content').show();

			$('.image-title').html(input.files[0].name);
		};

		console.log(reader);
		reader.readAsDataURL(input.files[0]);
		console.log(input.files[0]);

	} else {
		removeUpload();
	}
}

function removeUpload() {
	$('.file-upload-input').replaceWith($('.file-upload-input').clone());
	$('.file-upload-content').hide();
	$('.image-upload-wrap').show();
	$('.image-upload-wrap').removeClass('image-dropping');

}