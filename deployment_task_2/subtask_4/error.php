<?php
// error.php: deliberately throws an exception
// Useful for testing Application Insights' Failures/exception tracking after deployment
throw new Exception("This is a deliberate test error for Application Insights.");
