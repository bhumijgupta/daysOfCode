<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Form example</title>
    <style>
        table {
            width: 50%;
            display: block;
            margin: 0 auto;
        }

        td {
            width: 50%;
        }

        input[type="submit"] {
            margin: 5px auto;
            display: block;
            width: 100%;
            padding: 5px;
        }

        h1 {
            text-align: center;
        }
    </style>
</head>

<body>
    <h1>Fill out the form</h1>
    <form action="submit.php" method="POST">
        <table>
            <tr>
                <td><label for="name">Name</label></td>
                <td><input type="text" name="name" required></td>
            </tr>
            <tr>
                <td><label for="email">Email</label></td>
                <td><input type="email" name="email" required></td>
            </tr>
            <tr>
                <td colspan="2"><input type="submit" value="Submit" name="submit"></td>
            </tr>
        </table>
    </form>
</body>

</html>