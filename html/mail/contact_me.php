<?php
// Check for empty fields
if(empty($_POST['name'])  		||
   empty($_POST['email']) 		||
   empty($_POST['phone']) 		||
   empty($_POST['message'])	||
   !filter_var($_POST['email'],FILTER_VALIDATE_EMAIL))
   {
	echo "No arguments Provided!";
	//return false;
   }
	
$name = $_POST['name'];
$email_address = $_POST['email'];
$phone = $_POST['phone'];
$message = $_POST['message'];
	
// Create the email and send the message
//$to = 'quangdutran809@gmail.com'; // Add your email address inbetween the '' replacing yourname@yourdomain.com - This is where the form will send a message to.
//$email_subject = "Website Contact Form:  $name";
//$email_body = "You have received a new message from your website contact form.\n\n"."Here are the details:\n\nName: $name\n\nEmail: $email_address\n\nPhone: $phone\n\nMessage:\n$message";
//$headers = "From: quangdutran809@gmail.com\n"; // This is the email address the generated message will be from. We recommend using something like noreply@yourdomain.com.
//$headers .= "Reply-To: $email_address";	
//mail($to,$email_subject,$email_body,$headers);

$server = 'tqdu-PC\SQLEXPRESS';
$link = mssql_connect($server, 'sa', '123456');

if (!$link || !mssql_select_db('WebDatabase', $link)) {
    die('Unable to connect or select database!');
	//return false;
} 

$sql = "INSERT INTO WebDatabase.dbo.Contact (name,email,phone,message) VALUES ('du','qdu@gmail.com','12324421','msdsa');"
mssql_query($sql);
//if(!mssql_query($sql)) { return false;}

return true;			
?>