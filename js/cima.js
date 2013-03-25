function f_fecha_actual(){

var nombre_dia = new Array("domingo", "lunes", "martes", "mi&eacute;rcoles", "jueves", "viernes", "s&aacute;bado") 

var nombre_mes = new Array("enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre") 

var de = " de "; 

var hoy_es = new Date(); 
dia_mes = hoy_es.getDate(); 
dia_semana = hoy_es.getDay(); 
mes = hoy_es.getMonth() + 1; 
anyo = hoy_es.getYear(); 

if (anyo < 100) 
{
anyo = "19" + anyo;
}
else if ( (anyo > 100) && (anyo < 999) ) 
{
var cadena_anyo=new String(anyo); 
anyo="20" + cadena_anyo.substring(1,3); 
} 

return (nombre_dia[dia_semana] + ", " + dia_mes + de + nombre_mes[mes - 1] + " de " + anyo) ;

}

function f_llamar_report(nombre){

var pop_up = window.open(nombre,'informe');

}

function f_abre(pagina,alto,ancho,nombre){

var winTop = (screen.height - alto) / 2
var winLeft = (screen.width - ancho) / 2
	
ventana=window.open(pagina, nombre, "height=" + alto + ",width=" + ancho + ",top=" + winTop + ",left=" + winLeft + ",screenX= " + winTop + ",screenY=" + winLeft + ", scrollbars=yes, modal");
//ventana=window.showModalDialog(pagina, nombre, "dialogheight=" + alto + ";dialogwidth=" + ancho + ";center=Yes; help=NO; scroll=Yes");

}

function f_abre_modal(pagina,alto,ancho,nombre){

var winTop = (screen.height - alto) / 2
var winLeft = (screen.width - ancho) / 2
	
ventana=window.open(pagina, nombre, "height=" + alto + ",width=" + ancho + ",top=" + winTop + ",left=" + winLeft + ",screenX= " + winTop + ",screenY=" + winLeft + ", scrollbars=yes, menubar=no, resizable=no, location=no, directories=no, status=no, alwaysRaised=yes, toolbar=no");
//ventana=window.showModalDialog(pagina, nombre,"dialogWidth=" + ancho + ";dialogHeight=" + alto + ";edge=Raised;center=Yes;help=NO;resizable=No;scroll=NO;status=NO')
}

function f_sustitucion_textarea_br(palabra){

var cadena_creciente;

cadena_creciente = '';

for(i=0;i<=palabra.length;i++){

	if (escape(unescape(palabra.charAt(i))) == '%0D'){
		cadena_creciente = cadena_creciente + '<BR>';
	}
	else
	{
		cadena_creciente = cadena_creciente + palabra.charAt(i);
	}
	
}

return cadena_creciente;

}

function printPage() {

if (window.navigator.userAgent.indexOf("MSIE") != -1) {

    var WebBrowser = '<OBJECT ID="WebBrowser1" style="display: none" CLASSID="CLSID:8856F961-340A-11D0-A96B-00C04FD705A2"></OBJECT>';
    document.body.insertAdjacentHTML('beforeEnd', WebBrowser);
    WebBrowser1.ExecWB(7, 1);
    WebBrowser1.outerHTML = "";

} else
    this.print();
}