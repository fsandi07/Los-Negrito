$(document).ready(function () {
	$("#texto1").blur(function () {
		$(this).css("background-color", "#FFFFCC");
	});

	$("#texto2").blur(function () {
		$(this).hide("slow");
	});
});

$(function calcula () {
	//Operaciones matemáticas
	$('#txtmonto2').onblur(function (e) {
		e.preventDefault();
		//Almaceno los valores de los inputs
		var primerValor = $('#txtmonto1').val();
		var segundoValor = $('#txtmonto2').val()

		//Almacena el valor de la opción seleccionada
		var opcionSeleccionada = $('input:radio[name=operacion]:checked').val();

		//Condiciona para que acepte solo números usando las expresiones regulares
		if (primerValor.match(/^[0-9]+$/) && segundoValor.match(/^[0-9]+$/)) {
			//Suma
			
				var resultado = parseFloat(primerValor) + parseFloat(segundoValor);
			

		} else {
			alert("Ingrese números en los campos");
		}
		//Muestro el resultado
		$('#txttotalmonto').text(resultado);
	});
});