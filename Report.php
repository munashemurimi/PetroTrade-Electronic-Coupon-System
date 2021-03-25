<?php
//Call Db Connection
	include('dbconnect.php');
	session_start();
	$titl= $_SESSION['ReportTitle'];
	$crit= $_SESSION['ReportCriteria'];
	$prntFrm=$_SESSION['PrntForm'];
	//If page accessed without log in
/* 	if(empty($_SESSION['Ec'])){
		header("location: login.php");//redirects to another page
	}  
	 */
?>
<!doctype html>
<html class="no-js" lang="">
    <head>
	    <title>ICT Report Printouts</title>
        <meta charset="utf-8">
        <meta http-equiv="x-ua-compatible" content="ie=edge">
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
			background:url("images/bg3.jpg");
			background-size: cover;
		
	    }
		<!--Faded Picture-->
		img {
			opacity: 0.5;
		filter: alpha(opacity=100); /* For IE8 and earlier */
		}
		</style>
    </head>
    <body >
	<div class="Container" style="background-color:orange;padding:10px 5px; margin-top:0px;" >
    </div>
	<div class="Container" style="background-color:white;padding:2px 5px;" >
		
    </div>
	<div class="container" style="background-color:white;padding: 5px 25px; margin-top:60px;-moz-border-radius:15px;-webkit-border-radius:15px 15px 0px 0px;">
		<h2 style="text-align: center;color:black;font-weight:bold;font-family:Times New Roman;"><?php echo $titl; ?></h2>
		<hr>
		<img src="images\logo.png" style="align:center;-moz-border-radius:15px;-webkit-border-radius:15px;height:6%;width:10%;"/>
		<input type="button" onClick="window.print()" value="Print The Report" style="background-color:orange;"/>
		<input type="button" onClick="window.location.href='<?php echo $prntFrm; ?>'" value="Back To Parent Form" style="background-color:orange;"/>
	</div>		
	
	<div class="container" style="background-color:rgba(0,0,0,0.7);padding: 25px 25px;-moz-border-radius:15px;-webkit-border-radius:0px 0px 15px 15px ;">
		<table class="table table-striped table-bordered table-hover table-condensed" style="border-radius: 5px;">
		<tr style="color:orange;background-color:Black;font-size:11pt;font-weight:bold;">
			<th>Request ID</th>
			<th>Reg Date</th>
			<th>Requested Asset Name</th>
			<th>Priority</th>
			<th>Requested Number Of Assets</th>
		</tr>
		<!--<tr class="danger" style="font-size:10pt;">-->
	<?php
		   $sql="SELECT * FROM requests WHERE State ='$crit'"; 
	  
	 
	   $result=mysqli_query($myConn,$sql);
				if (mysqli_num_rows($result)>0){
				while ($row = mysqli_fetch_array($result))	
				{	
					
	?>
			<tr class="warning" style="font-size:10pt;">				 
				<td><?php echo$row['RequestID'];?></td>
				<td><?php echo$row['RegDat'];?></td>
				<td><?php echo$row['Asset'];?></td>
				<td><?php echo$row['Priority'];?></td>
				<td><?php echo$row['Num'];?></td>
	        </tr>
	
	<?php
		}			   
		}
	?>
	</table>
	</div>

	  
	  <!--zvang ends-->
            
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
