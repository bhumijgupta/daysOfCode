<!DOCTYPE html>
<html>
<body>
<hr/> 

<?php
$x = "hello";
echo "global value: $x<br>";
function changer(){
    $x = "blah";
    echo "local value: $x<br>";
}
changer();
echo "global value after function: $x<br><br>";

function staticTest(){
    static $y = 0;
    $y++;
    echo "$y<br>";
}
staticTest();
staticTest();
staticTest();

$txt = "hello";
print "<h2> $txt </h2>";

$y=10;
var_dump($y);
echo "<br>";
$y=13.66;
var_dump($y);
echo "<br>";
$cars = array("Volvo","BMW","Toyota");
var_dump($cars);
echo "<br><br>";

class car{
    function car(){
        $this->model = "2019";
    }
}

$maruti = new car();
echo "object car model: $maruti->model<br><br>";

define("cons", "Constant here", true);
echo cons;
echo "<br><br>";

$x = 5;
$y = 10;
$z = 10;
$w = 12;
echo "<h3>Spaceship operator</h3>";
echo $x <=> $y;
echo "<br>";
echo $y <=> $z;
echo "<br>";
echo $w <=> $z;
echo "<br><br>";

$cars = array("Volvo","BMW","Toyota");
foreach ($cars as $car) {
    echo "$car <br>";
}
?>



</body>
</html>