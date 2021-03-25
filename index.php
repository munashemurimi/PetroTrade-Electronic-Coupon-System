<?php

?>
<!DOCTYPE html>
<html>
<head>
	<title>Inline layout</title>
	<link rel="stylesheet" type="text/css" href="mystyle.css">	
    <SCRIPT LANGUAGE='JavaScript'>
		function myfunc(){
			
	
		}
    </SCRIPT>
	<style>
		body{
		background:url("images/bck.jpg");
		background-size: cover;
		}
		.container{
		width:1300px; 		
		background-color:rgba(0,0,0,0.8);
		margin:0 auto;
		height:640px;
		margin-top:10px;
		padding:25px;
		}
		.resp{
		-moz-border-radius:15px;
		-webkit-border-radius:15px;	
		margin-left:20px;
		}
	</style>
</head>
<body>
	<h3 style="color:#ffcccc;font-size:9pt;margin-left:60px;">Total Fuel Sales, Transfers and Redemption Main Menu</h3>
	<hr>
    <div class="container">
		<form method="POST" action="home.php" autocomplete="off" name="myForm">
			<div style="color:white;">
				<label>1. Fuel Redemption - Petrol</label><br>
				<label>2. Fuel Redemption - Diesel</label><br>
				<label>3. Fuel Transfer - Petrol</label><br>
				<label>4. Fuel Transfer - Diesel</label><br>
				<label>5. Fuel Balance Check - Petrol</label><br>
				<label>6. Fuel Balance Check - Diesel</label><br>
				<label>7. Fuel Pricing</label><br>
				<label>8. Fuel Account Pin Change</label><br>
			</div>
				<label>9.Fuel Account Transection History</label><br>
				<h3 style="color:#ffcccc;font-size:9pt;margin-left:60px;">Reply with selection</h3>
				<input type="number" class="resp" name="txtResponse">
		</form>	
	</div>
</body>

</html>