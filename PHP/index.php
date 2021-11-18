<?php
    $montant=0;$resultat=0;
    if (isset($_GET['montant'])){
    $montant=$_GET['montant'];
    $client = new SoapClient('http://localhost:8686/BanqueService?wsdl');
    $param=new stdClass();
    $param->montant=$montant;
    $rep=$client->__soapCall("ConversionEuroToDH",array($param));
    $resultat=$rep->return;
    }
?>
<html>
    <body>
        <form action="index.php">
        Montant :<input type="text" name="montant" value="<?php echo($montant)?>">
        <input type="submit" value="OK">
        </form>
        <?php echo($montant)?> en Euro est égale à <?php echo($resultat)?> en DH
    </body>
</html>