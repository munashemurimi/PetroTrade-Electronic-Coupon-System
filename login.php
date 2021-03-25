<?php
    include('../petrotrade/dbconnect.php');
    if (isset($_POST['btnLogin'])){
	
	$phone = $_POST['txtPhone'];
    $pin =$_POST['txtPin'];
	
	$sql="SELECT * FROM accounts WHERE Account ='$phone'AND Pin='$pin'";
    $result=mysqli_query($myConn,$sql);//will execute the query into the database
	
    if(mysqli_num_rows($result)==0){
			echo("<SCRIPT LANGUAGE='JavaScript'>
				window.alert('Login details are wrong. Your session can not be started.')
				window.location.href='home.php'
				</SCRIPT>");
			exit();
	}else{
	    session_start();
		$_SESSION['StarTym'] = date("H:i:s");
		$_SESSION['Account'] = $phone;
		mysqli_free_result($result);
		header("location: home.php");//redirects to another page
	}
} 
?>
<!doctype html>
<html class="no-js" lang="">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="x-ua-compatible" content="ie=edge">
        <title>Mobile Login</title>
        <meta name="description" content="">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <!-- Google Fonts -->
        <link href='https://fonts.googleapis.com/css?family=Lato:400,700,400italic,300' rel='stylesheet' type='text/css'>

		<!-- all css here -->
		
		<!-- bootstrap v3.3.6 css -->       
        <link href="../petrotrade/css/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
        <!-- Animated text css -->
		<link rel="stylesheet" href="../petrotrade/css/animated.css">
		<!-- owl.carousel css -->
        <link rel="stylesheet" href="../petrotrade/css/owl.carousel.css">
        <link rel="stylesheet" href="../petrotrade/css/owl.transitions.css">
		<!-- font-awesome css -->
        <link rel="stylesheet" href="../petrotrade/css/font-awesome.min.css">
        <!-- animate css -->
        <link rel="stylesheet" href="../petrotrade/css/animate.css">
        <link href="../petrotrade/css/jquery-ui.css" rel="stylesheet" />
        <link href="../petrotrade/css/style.css" rel="stylesheet" />
		<!-- style css -->
		<link rel="stylesheet" href="../petrotrade/style.css">
		<!-- responsive css -->
        <link rel="stylesheet" href="../petrotrade/css/responsive.css">
		<!-- modernizr css -->
        <script src="../petrotrade/js/vendor/modernizr-2.8.3.min.js"></script>
		<style>
			body{
			background:url(../petrotrade/images/bck.jpg);
			background-size: cover;
		
	    }
		</style>
		<SCRIPT LANGUAGE='JavaScript'>
			function myfunc(){
				//Phone field validator
				if(document.myForm.txtPhone.value==""){
					window.alert('Error. You can not submit blank phone number.'); 
					return false;
				}
				//Pin field validator
				if(document.myForm.txtPin.value==""){
					window.alert('Error. You can not submit blank pin number.'); 
					return false;
				}
			//code below now send the form after validation is complete
			document.getElementsByClassName("subby")[0].click();
			}
		</SCRIPT>
    </head>
    <body >

	<div class="container" style="background-color:rgba(0,0,0,0.8);padding: 5px 25px; margin-top:200px;-moz-border-radius:15px;-webkit-border-radius:15px;height:400px;">
	<h2 style="text-align: center;color: #cc9900;font-weight:bold;font-size:12pt;">Petrotrade Electronic Coupon System</h2>
	<hr>
			<div class="col-lg-4">
				<img src="../petrotrade/images/logo.png" style="align:center;-moz-border-radius:15px;-webkit-border-radius:15px;"/>	        </div>
		<form method="POST" action="login.php" autocomplete="off" name="myForm">
			<div class="col-lg-4">
				<div class="form-group ">
						<h3 style="text-align: center;color:#cc9900;font-size:9pt;">Enter Mobile Number</h3>
                        <input type="number" style="text-align:center;font-weight:bold;font-size:20pt;" name="txtPhone" maxlength=10 class="form-control">
                </div>
				<div class="form-group ">
						<h3 style="text-align: center;color:#cc9900;font-size:9pt;">Enter Account Password</h3>
                        <input type="password" style="text-align:center;font-weight:bold;font-size:36pt;" name="txtPin" maxlength=4 class="form-control">
                </div>
				<input type="button" name="btnRespond" value="Start Customer Session" onClick="myfunc()" class="btn form-control" style="background: green;color: #ffbf00;text-align:center;width:100%;font-size:12pt;">
				<input type="submit" class="subby" name="btnLogin" hidden>

				<br><br>
				<input type="submit" name="btnClose" value="Cancel Customer Session" class="btn form-control" style="background: green;color: #ffbf00;text-align:center;width:100%;font-size:12pt;">
			</div>
            <div class="col-lg-4">			</div>	
			
		</form>	
	
	</div>


	  <!--zvang ends-->
            
		<!-- all js here -->
		<!-- jquery latest version -->
        <script src="../petrotrade/js/vendor/jquery-1.12.4.min.js"></script>
		<!-- bootstrap js -->
        <script src="../petrotrade/js/bootstrap.min.js"></script>
        <!-- Google Map js -->
        <script type="text/javascript" src="../petrotrade/js/jquery-2.1.4.min.js"></script>
        <script src="../petrotrade/js/jquery-ui.js"></script>		<!-- owl.carousel js -->
        <script src="../petrotrade/js/owl.carousel.min.js"></script>
        <!-- easing js -->
        <script src="../petrotrade/js/easing.js"></script>
        <!-- jquery.appear js -->
        <script src="../petrotrade/js/jquery.appear.js"></script>
        <!-- animated js -->
        <script src="../petrotrade/js/animated.js"></script>
        <!-- Mixitup js -->
        <script src="../petrotrade/js/jquery.mixitup.min.js"></script>
        <!-- wow js -->
        <script src="../petrotrade/js/wow.min.js"></script>
        <!-- counter js -->
        <script src="../petrotrade/js/jquery.counterup.min.js"></script>
        <script src="../petrotrade/js/waypoints.js"></script>
		<!-- plugins js -->
        <script src="../petrotrade/js/plugins.js"></script>
		<!-- main js -->
        <script src="../petrotrade/js/main.js"></script>
        <!-- Calendar -->
        <!-- //Calendar -->
    </body>	
	
</html>			
