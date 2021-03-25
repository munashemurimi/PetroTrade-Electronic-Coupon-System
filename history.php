<?php
   #Call Db Connection
   include('dbconnect.php');
   session_start();
   $starTym= $_SESSION['StarTym'];
   $acnt= $_SESSION['Account'];
	//If page accessed without log in
	if(empty($_SESSION['StarTym'])){
		header("location: login.php");//redirects to another page
	}  
	if(isset($_POST['btnClose'])){
		header("location: home.php");//redirects to another page
	}
	
?>
<!doctype html>
<html class="no-js" lang="">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="x-ua-compatible" content="ie=edge">
        <title>Inndex</title>
        <meta name="description" content="">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <!-- Google Fonts -->
        <link href='https://fonts.googleapis.com/css?family=Lato:400,700,400italic,300' rel='stylesheet' type='text/css'>

		<!-- all css here -->
		
		<!-- bootstrap v3.3.6 css -->       
        <link href="css/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
        <!-- Animated text css -->
		<link rel="stylesheet" href="css/animated.css">
		<!-- owl.carousel css -->
        <link rel="stylesheet" href="css/owl.carousel.css">
        <link rel="stylesheet" href="css/owl.transitions.css">
		<!-- font-awesome css -->
        <link rel="stylesheet" href="css/font-awesome.min.css">
        <!-- animate css -->
        <link rel="stylesheet" href="css/animate.css">
        <link href="css/jquery-ui.css" rel="stylesheet" />
        <link href="css/style.css" rel="stylesheet" />
		<!-- style css -->
		<link rel="stylesheet" href="style.css">
		<!-- responsive css -->
        <link rel="stylesheet" href="css/responsive.css">
		<!-- modernizr css -->
        <script src="js/vendor/modernizr-2.8.3.min.js"></script>
		<style>
			body{
			background:url("images/bck.jpg");
			background-size: cover;
		
	    }
		</style>
		
    </head>
    <body >

	
	<div class="container" style="background-color:rgba(0,0,0,0.8);padding: 5px 25px; margin-top:10px;-moz-border-radius:15px;-webkit-border-radius:15px;height:900px;">
			<h2 style="text-align: center;color: #cc9900;font-weight:bold;font-size:20pt;" >Customer Transaction History</h2>
			<form method="POST" action="transferpet.php" autocomplete="off" name="myForm">
			<input type="submit" name="btnClose" value="Go To Main Menu" class="btn form-control pull-right" style="background: green;color: #ffbf00;text-align:center;width:20%;font-size:12pt;">
            </form>
			<hr>
			
			<label style="color:white;">All Fuel Purchases</label>
			<table class="table table-bordered table-hover table-condensed" style="border-radius: 5px;width:100%;">
				<tr style="color:white;background-color:rgba(0,0,0,0.7);">
					<th><label style="color:white;">Purchase Date</label></th>
					<th><label style="color:white;">Receipt Number</label></th>
					<th><label style="color:white;">Fuel Type</label></th>
					<th><label style="color:white;">Purchased Litres</label></th>
					<th><label style="color:white;">Total Cost $</label></th>
				</tr>
				<?php
		        //$pro="Petrol";
				//$sql="SELECT * FROM fuelsales WHERE Account='$acnt' && Product='$pro'";
				$sql="SELECT * FROM fuelsales WHERE Account='$acnt'";
				$result=mysqli_query($myConn,$sql);
					if (mysqli_num_rows($result)>0){
					while ($row = mysqli_fetch_array($result))	
					{
				?>
				<tr class="infor"  style="font-size:10pt;color:black;background-color:#ffeb99;">				 
					<td><?php echo$row['Dat'];?></td>
					<td><?php echo$row['RecNum'];?></td>
					<td><?php echo$row['Fuel'];?></td>
					<td><?php echo$row['Litres'];?></td>
					<td><?php echo$row['Cost'];?></td>
				</tr>
		
				<?php
				}			   
				}
				mysqli_free_result($result);
				?>
			</table>			
			<hr>
			<label style="color:white;">All Fuel Receivals</label>
			<table class="table table-bordered table-hover table-condensed" style="border-radius: 5px;width:100%;">
				<tr style="color:white;background-color:rgba(0,0,0,0.7);">
					<th><label style="color:white;">Receival Date</label></th>
					<th><label style="color:white;">Sender Number</label></th>
					<th><label style="color:white;">Fuel Type</label></th>
					<th><label style="color:white;">Received Litres</label></th>
				</tr>
				<?php
		        //$pro="Petrol";
				//$sql="SELECT * FROM fuelsales WHERE Account='$acnt' && Product='$pro'";
				$acnt2=substr_replace($acnt,'',0,1);
				$sql="SELECT * FROM transfers WHERE Recepient='$acnt2'";
				$result=mysqli_query($myConn,$sql);
					if (mysqli_num_rows($result)>0){
					while ($row = mysqli_fetch_array($result))	
					{
				?>
				<tr class="infor"  style="font-size:10pt;color:black;background-color:#ffeb99;">				 
					<td><?php echo$row['RegDat'];?></td>
					<td><?php echo$row['Account'];?></td>
					<td><?php echo$row['Product'];?></td>
					<td><?php echo$row['Litres'];?></td>
				</tr>
		
				<?php
				}			   
				}
				mysqli_free_result($result);
				?>
			</table>			
			<hr>
		    <label style="color:white;">All Fuel Sent</label>
			<table class="table table-bordered table-hover table-condensed" style="border-radius: 5px;width:100%;">
				<tr style="color:white;background-color:rgba(0,0,0,0.7);">
					<th><label style="color:white;">Sending Date</label></th>
					<th><label style="color:white;">Recpient Number</label></th>
					<th><label style="color:white;">Fuel Type</label></th>
					<th><label style="color:white;">Received Litres</label></th>
				</tr>
				<?php
		        //$pro="Petrol";
				//$sql="SELECT * FROM fuelsales WHERE Account='$acnt' && Product='$pro'";
				$acnt2=substr_replace($acnt,'',0,1);
				$sql="SELECT * FROM transfers WHERE Account='$acnt'";
				$result=mysqli_query($myConn,$sql);
					if (mysqli_num_rows($result)>0){
					while ($row = mysqli_fetch_array($result))	
					{
				?>
				<tr class="infor"  style="font-size:10pt;color:black;background-color:#ffeb99;">				 
					<td><?php echo$row['RegDat'];?></td>
					<td><?php echo$row['Recepient'];?></td>
					<td><?php echo$row['Product'];?></td>
					<td><?php echo$row['Litres'];?></td>
				</tr>
		
				<?php
				}			   
				}
				mysqli_free_result($result);
				?>
			</table>	
			<hr>
		    <label style="color:white;">All Fuel Redemptions</label>
			<table class="table table-bordered table-hover table-condensed" style="border-radius: 5px;width:100%;">
				<tr style="color:white;background-color:rgba(0,0,0,0.7);">
					<th><label style="color:white;">Redemption Date</label></th>
					<th><label style="color:white;">Fuel Type</label></th>
					<th><label style="color:white;">Received Litres</label></th>
					<th><label style="color:white;">Service Station Code</label></th>
				</tr>
				<?php
		        //$pro="Petrol";
				//$sql="SELECT * FROM fuelsales WHERE Account='$acnt' && Product='$pro'";
				$sql="SELECT * FROM redemptions WHERE Account='$acnt'";
				$result=mysqli_query($myConn,$sql);
					if (mysqli_num_rows($result)>0){
					while ($row = mysqli_fetch_array($result))	
					{
				?>
				<tr class="infor"  style="font-size:10pt;color:black;background-color:#ffeb99;">				 
					<td><?php echo$row['RegDat'];?></td>
					<td><?php echo$row['Product'];?></td>
					<td><?php echo$row['Litres'];?></td>
					<td><?php echo$row['Station'];?></td>
				</tr>
		
				<?php
				}			   
				}
				mysqli_free_result($result);
				?>
			</table>			
	</div>

            
		<!-- all js here -->
		<!-- jquery latest version -->
        <script src="js/vendor/jquery-1.12.4.min.js"></script>
		<!-- bootstrap js -->
        <script src="js/bootstrap.min.js"></script>
        <!-- Google Map js -->
        <script type="text/javascript" src="js/jquery-2.1.4.min.js"></script>
        <script src="js/jquery-ui.js"></script>		<!-- owl.carousel js -->
        <script src="js/owl.carousel.min.js"></script>
        <!-- easing js -->
        <script src="js/easing.js"></script>
        <!-- jquery.appear js -->
        <script src="js/jquery.appear.js"></script>
        <!-- animated js -->
        <script src="js/animated.js"></script>
        <!-- Mixitup js -->
        <script src="js/jquery.mixitup.min.js"></script>
        <!-- wow js -->
        <script src="js/wow.min.js"></script>
        <!-- counter js -->
        <script src="js/jquery.counterup.min.js"></script>
        <script src="js/waypoints.js"></script>
		<!-- plugins js -->
        <script src="js/plugins.js"></script>
		<!-- main js -->
        <script src="js/main.js"></script>
        <!-- Calendar -->
        <!-- //Calendar -->
    </body>	
	
</html>			
