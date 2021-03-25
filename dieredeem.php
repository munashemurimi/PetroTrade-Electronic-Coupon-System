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

	/* if (!isset($_SESSION['views'])) { 
		$_SESSION['views'] = 0;
	}

	$_SESSION['views'] = $_SESSION['views']+1;

	if ($_SESSION['views'] == 4) {
		unset ($_SESSION['StarTym']);
		unset ($_SESSION['Account']);
		session_destroy();
		header("location: home.php");//redirects to another page
		exit();
	} */
	if (isset($_POST['btnSend'])){
	
		$station = $_POST['txtStation'];
		$litres =$_POST['txtLitres'];
		
		$sql="SELECT * FROM fuelstations WHERE ID ='$station'";
		$result=mysqli_query($myConn,$sql);//will execute the query into the database
		
		if(mysqli_num_rows($result)==0){
				echo("<SCRIPT LANGUAGE='JavaScript'>
					window.alert('Your station code is wrong. Re-type and submit again.')
					window.location.href='dieredeem.php'
					</SCRIPT>");
				exit();
		}else{
			$regdat=date("d:m:Y")." ".date("H:i:s");
			$pro="Diesel";
			$fltLitres= floatval($litres);
			//Check first if stated litres are available at service station
				$row=mysqli_fetch_assoc($result);
				$wrk= $row['Working'];
					if($wrk!='Yes'){
						echo("<SCRIPT LANGUAGE='JavaScript'>
						window.alert('The service station you want to redeem fuel from is not active for redemption. Transection failed.');
						window.location.href='dieredeem.php';
						</SCRIPT>");
						exit();
					}
				$balla= $row['DieBal'];
				$balla=(double)$balla;
				$lit=(double)$litres;
					
				if ($balla < $lit){
				    echo("<SCRIPT LANGUAGE='JavaScript'>
					window.alert('The service station diesel balance is insufficient. Redemption saving failed.');
					window.location.href='dieredeem.php';
					</SCRIPT>");
					exit();
				}
				
			//Check first if stated litres are there also if diesel account exists
				$sql="SELECT * FROM accounts WHERE Account='$acnt' && Product='$pro'";
				$result=mysqli_query($myConn,$sql);//will execute the query into the database
				
				if(mysqli_num_rows($result)==1){
					$row=mysqli_fetch_assoc($result);
					$stat= $row['Status'];
					if($stat!='Active'){
						echo("<SCRIPT LANGUAGE='JavaScript'>
						window.alert('Your diesel account is currently blocked. Contact Total sales team for assistance.');
						window.location.href='dieredeem.php';
						</SCRIPT>");
						exit();
					}
					$balance= $row['Balance'];
					$balance=(double)$balance;
					$lit=(double)$litres;
					IF ($balance < $lit){
				    echo("<SCRIPT LANGUAGE='JavaScript'>
					window.alert('Your diesel fuel balance is insufficient. Redemption saving failed.');
					window.location.href='dieredeem.php';
					</SCRIPT>");
					exit();
					}
					$lftBal=$balance-$lit;
				}else{
					echo("<SCRIPT LANGUAGE='JavaScript'>
					window.alert('You have no any diesel account with total fuel services.')
					window.location.href='home.php'
					</SCRIPT>");
					exit();
				}			
			
			
		
			$sms= "dieRed";
		    $nuh="No";
			mysqli_query($myConn,"UPDATE accounts SET Balance = Balance-'$fltLitres' WHERE Account='$acnt' && Product='$pro'");
			mysqli_query($myConn,"INSERT INTO redemptions(RegDat,Account,Product,Litres,Station) VALUES ('$regdat','$acnt','$pro','$litres','$station')");
			mysqli_query($myConn,"UPDATE fuelstations SET PetBal = PetBal-'$litres' WHERE ID ='$station' ");
			mysqli_query($myConn,"INSERT INTO sms(RegDat,Account,MsgBody,Litres,StatTraAcc,Sent) VALUES ('$regdat','$acnt','$sms','$litres','$station','$nuh')");
			unset ($_SESSION['StarTym']);
			unset ($_SESSION['Account']);
			session_destroy();
			echo("<SCRIPT LANGUAGE='JavaScript'>
				window.alert('Fuel redemption to station code **** is successfuly registered in system.')
				window.location.href='login.php'
				</SCRIPT>");
		}
	}
?>
<!doctype html>
<html class="no-js" lang="">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="x-ua-compatible" content="ie=edge">
        <title>Diesel Redeem</title>
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
		<SCRIPT LANGUAGE='JavaScript'>
			function myfunc(){
				//All fields validator
				if(document.myForm.txtStation.value==""){
					window.alert('Error. You can not submit blank station number.'); 
					return false;
				}
				if(document.myForm.txtLitres.value==""){
					window.alert('Error. You can not submit blank litres volume number.'); 
					return false;
				}
			
			//code below now send the form after validation is complete
			document.getElementsByClassName("subby")[0].click();
			}
		</SCRIPT>
    </head>
    <body >

	<div class="container" style="background-color:rgba(0,0,0,0.8);padding: 5px 25px; margin-top:10px;-moz-border-radius:15px;-webkit-border-radius:15px;height:600px;">
	<h2 style="text-align: center;color: #cc9900;font-weight:bold;font-size:20pt;">Petrotrade Electronic Coupon System Diesel Redemption</h2>
	<hr>
			<div class="col-lg-4">
				<img src="images\logo.png" style="align:center;-moz-border-radius:15px;-webkit-border-radius:15px;"/>
	        </div>
		<form method="POST" action="dieredeem.php" autocomplete="off" name="myForm">
			<div class="col-lg-4">
				<div class="form-group ">
						<h3 style="text-align: center;color:#cc9900;font-size:12pt;">Service Station Code</h3>
                        <input type="number" name="txtStation" size=10 class="form-control">
                </div>
				<div class="form-group ">
						<h3 style="text-align: center;color:#cc9900;font-size:12pt;">Diesel Volume To Redeem</h3>
                        <input type="number" name="txtLitres" size=10 class="form-control">
                </div>
				<input type="button" name="btnRespond" value="Send Customer Response" onClick="myfunc()" class="btn form-control" style="background: green;color: #ffbf00;text-align:center;width:100%;font-size:12pt;">
				<input type="submit" name="btnSend" class="subby" hidden>

				<br><br>
				<input type="submit" name="btnClose" value="Go To Main Menu" class="btn form-control" style="background: green;color: #ffbf00;text-align:center;width:100%;font-size:12pt;">
			</div>
            <div class="col-lg-4">
		
			</div>	
			
		</form>	
	<hr>
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
