<?php
    $name = $email = "";
    if($_SERVER["REQUEST_METHOD"] == "POST"){
        $name = sanitize($_POST["name"]);
        // $name = $_POST["name"];
        $email = sanitize($_POST["email"]);
    }

    function sanitize($data){
        $data = htmlspecialchars(stripslashes(trim($data)));
        return $data; 
    }

    echo "Welcome $name, your email is $email";
?>