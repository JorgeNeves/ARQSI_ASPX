<?php
//header("Content-Type: application/soap+xml; charset=utf-8");

// Pull in the NuSOAP code
require_once('nusoap.php');
// Create the server instance
$server = new soap_server;
// Initialize WSDL support
$server->configureWSDL( 'servicename', 'urn:servicename', '', 'document');
$server->soap_defencoding="utf-8";
$in = array('x'=>'xsd:int');
$out = array('Pass' => 'xsd:float');
// registar serviço
$server->register("custo",
$in,// parâmetros de entrada
$out,// parâmetross de saída
'urn:servicename', // namespace
$server->wsdl->endpoint .'#'. "custo", // soapaction
'document', // style
'literal', // use
'N/A' // documentation
);

// Use the request to (try to) invoke the service
$HTTP_RAW_POST_DATA = isset($HTTP_RAW_POST_DATA) ? $HTTP_RAW_POST_DATA : '';
$server->service($HTTP_RAW_POST_DATA);

// Define the method as a PHP function
function custo($x) {
    $result=$x*0.67;
    return array('Pass'=>$result);
}
// Use the request to (try to) invoke the service

?>
