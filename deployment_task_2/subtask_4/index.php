<?php
// index.php — homepage
$serverTime = date('Y-m-d H:i:s');
$phpVersion = phpversion();
$visitorName = $_GET['name'] ?? 'Guest';
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>PHP Demo App</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <div class="card">
        <h1>Hello, <?= htmlspecialchars($visitorName) ?></h1>
        <p>This is a PHP 8.x app running on Azure App Service.</p>
        <ul>
            <li><strong>Server time:</strong> <?= htmlspecialchars($serverTime) ?></li>
            <li><strong>PHP version:</strong> <?= htmlspecialchars($phpVersion) ?></li>
        </ul>
        <p><a href="?name=Azure">Try ?name=Azure in the URL</a></p>
        <p><a href="error.php">Trigger a test error</a> (for Application Insights)</p>
    </div>
</body>
</html>
