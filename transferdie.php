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
	if (isset($_POST['btnSend'])){
		
		$recepient = $_POST['txtRecepient'];
		if ($acnt==$recepient){
				echo("<SCRIPT LANGUAGE='JavaScript'>
					window.alert('You can not not send fuel to yourself. Transection failed.');
					window.location.href='home.php';
					</SCRIPT>");
				exit();
		}
		$litres =$_POST['txtLitres'];
		$pro="Diesel";
		$fltLitres= floatval($litres);
		//Check first if stated litres are there also if diesel account exists
			$sql="SELECT * FROM accounts WHERE Account='$acnt' && Product='$pro'";
			$result=mysqli_query($myConn,$sql);//will execute the query into the database
				
				if(mysqli_num_rows($result)==1){
					$row=mysqli_fetch_assoc($result);
					$stat= $row['Status'];
					if($stat!='Active'){
						echo("<SCRIPT LANGUAGE='JavaScript'>
						window.alert('Your Diesel account is currently blocked. Contact Total sales team for assistance.');
						window.location.href='home.php';
						</SCRIPT>");
						exit();
					}
					$balance= $row['Balance'];
					$balance=(double)$balance;
					$lit=(double)$litres;
					IF ($balance < $lit){
				    echo("<SCRIPT LANGUAGE='JavaScript'>
					window.alert('Your Diesel fuel balance is insufficient. Transfer transection failed.');
					window.location.href='transferdie.php';
					</SCRIPT>");
					exit();
					}
					$lftBal=$balance-$lit;
					//now look if the recepient already exists
					$sql="SELECT * FROM accounts WHERE Account ='$recepient'";
					$result=mysqli_query($myConn,$sql);//will execute the query into the database
					if(mysqli_num_rows($result)==0){
							//random pin here
							$randm=rand(1000,9999);	
							$alias="No Name";
							$recPetBal=$litres;
							$nuh="No";
							//CUSTOMER DOESNT EXIT
								$nuh="No";
								$stat="Active";
								$regdat=date("d/m/Y");
								$mont=date("m");
								$yrrr=date("Y");
								$zer="0";
								$sms= "dieTra";
								mysqli_query($myConn,"UPDATE accounts SET Balance ='$lftBal' WHERE Account='$acnt' && Product='$pro'");
								mysqli_query($myConn,"INSERT INTO accounts(Dat,Account,Alias,Product,Balance,Pin,Status,Mont,Yrrr,Transection,Recepient,Litres,Tym) VALUES ('$regdat','$recepient','$alias','$pro','$recPetBal','$randm','$stat','$mont','$yrrr','$zer','$zer','$zer','$zer')");
								mysqli_query($myConn,"INSERT INTO transfers(RegDat,Account,Recepient,Product,Litres) VALUES ('$regdat','$acnt',$recepient,'$pro','$litres')");
								$regdat=date("d:m:Y")." ".date("H:i:s");
								mysqli_query($myConn,"INSERT INTO sms(RegDat,Account,MsgBody,Litres,StatTraAcc,Sent) VALUES ('$regdat','$acnt','$sms','$litres','$recepient','$nuh')");
								$sms= "RecDie";
								mysqli_query($myConn,"INSERT INTO sms(RegDat,Account,MsgBody,Litres,StatTraAcc,Sent) VALUES ('$regdat','$recepient','$sms','$litres','$acnt','$randm')");

								unset ($_SESSION['StarTym']);
								unset ($_SESSION['Account']);
								session_destroy();
								echo("<SCRIPT LANGUAGE='JavaScript'>
									window.alert('Fuel transfer is successfuly registered in system.')
									window.location.href='login.php'
									</SCRIPT>");
								exit();
							
					}else{
						$sql="SELECT * FROM accounts WHERE Account='$recepient' && Product='$pro'";
						$result=mysqli_query($myConn,$sql);//will execute the query into the database
						if (mysqli_num_rows($result)==1){
							$row=mysqli_fetch_assoc($result);
							$stat= $row['Status'];
							if($stat!='Active'){
								echo("<SCRIPT LANGUAGE='JavaScript'>
								window.alert('The recepient Diesel account is currently blocked. Contact Total sales team for assistance.');
								window.location.href='home.php';
								</SCRIPT>");
								exit();
							}
							$randm=$row['Pin'];
							$alias=$row['Alias'];
							
							$balance2= $row['Balance'];
							$balance2=(double)$balance2;
							$lit2=(double)$litres;
							
							$recPetBal=$balance2 + $lit2;
							//CUSTOMER EXITS AND HAVE PRODUCT ACCOUNT
									$nuh="No";
									$stat="Active";
									$regdat=date("d/m/Y");
									$mont=date("m");
									$yrrr=date("Y");
									$zer="0";
									$sms= "dieTra";
									mysqli_query($myConn,"UPDATE accounts SET Balance ='$lftBal' WHERE Account='$acnt' && Product='$pro'");
									mysqli_query($myConn,"UPDATE accounts SET Balance ='$recPetBal' WHERE Account='$recepient' && Product='$pro'");
									mysqli_query($myConn,"INSERT INTO transfers(RegDat,Account,Recepient,Product,Litres) VALUES ('$regdat','$acnt',$recepient,'$pro','$litres')");
									$regdat=date("d:m:Y")." ".date("H:i:s");
									mysqli_query($myConn,"INSERT INTO sms(RegDat,Account,MsgBody,Litres,StatTraAcc,Sent) VALUES ('$regdat','$acnt','$sms','$litres','$recepient','$nuh')");
									$sms= "Received Diesel";
									mysqli_query($myConn,"INSERT INTO sms(RegDat,Account,MsgBody,Litres,StatTraAcc,Sent) VALUES ('$regdat','$recepient','$sms','$litres','$acnt','$nuh')");

									unset ($_SESSION['StarTym']);
									unset ($_SESSION['Account']);
									session_destroy();
									echo("<SCRIPT LANGUAGE='JavaScript'>
										window.alert('Fuel transfer is successfuly registered in system.')
										window.location.href='login.php'
										</SCRIPT>");
									exit();
						}else{
							$sql="SELECT * FROM accounts WHERE Account='$recepient'";
							$result=mysqli_query($myConn,$sql);//will execute the query into the database
							if (mysqli_num_rows($result)==1){
								$row=mysqli_fetch_assoc($result);
								$randm=$row['Pin'];
								$alias=$row['Alias'];
								$recPetBal=$litres;
								//CUSTOMER EXITS BUT HAVE NO PRODUCT ACCOUNT
									$nuh="No";
									$stat="Active";
									$regdat=date("d/m/Y");
									
									$mont=date("m");
									$yrrr=date("Y");
									$zer="0";
									$sms= "dieTra";
									mysqli_query($myConn,"UPDATE accounts SET Balance ='$lftBal' WHERE Account='$acnt' && Product='$pro'");
									mysqli_query($myConn,"INSERT INTO transfers(RegDat,Account,Recepient,Product,Litres) VALUES ('$regdat','$acnt',$recepient,'$pro','$litres')");
									mysqli_query($myConn,"INSERT INTO accounts(Dat,Account,Alias,Product,Balance,Pin,Status,Mont,Yrrr,Transection,Recepient,Litres,Tym) VALUES ('$regdat','$recepient','$alias','$pro','$recPetBal','$randm','$stat','$mont','$yrrr','$zer','$zer','$zer','$zer')");
									
									$regdat=date("d:m:Y")." ".date("H:i:s");
									mysqli_query($myConn,"INSERT INTO sms(RegDat,Account,MsgBody,Litres,StatTraAcc,Sent) VALUES ('$regdat','$acnt','$sms','$litres','$recepient','$nuh')");
									$sms= "Received Diesel";
								    mysqli_query($myConn,"INSERT INTO sms(RegDat,Account,MsgBody,Litres,StatTraAcc,Sent) VALUES ('$regdat','$recepient','$sms','$litres','$acnt','$nuh')");

									unset ($_SESSION['StarTym']);
									unset ($_SESSION['Account']);
									session_destroy();
									echo("<SCRIPT LANGUAGE='JavaScript'>
										window.alert('Fuel transfer is successfuly registered in system.')
										window.location.href='login.php'
										</SCRIPT>");
									exit();
							}
						}
					}
				}else{
					//Sender fuel account not found
					echo("<SCRIPT LANGUAGE='JavaScript'>
					window.alert('You have no any Diesel account with total fuel services.')
					window.location.href='home.php'
					</SCRIPT>");
					exit();
				}
	
		
	}
?>
<!doctype html>
<html class="no-js" lang="">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="x-ua-compatible" content="ie=edge">
        <title>Petrol Transfer</title>
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
				if(document.myForm.txtRecepient.value==""){
					window.alert('Error. You can not submit blank recepient phone number.'); 
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
		<h2 style="text-align: center;color: #cc9900;font-weight:bold;font-size:20pt;">Diesel Transfers</h2>
	<hr>
			<div class="col-lg-4">
				<img src="images\logo.png" style="align:center;-moz-border-radius:15px;-webkit-border-radius:15px;"/>
	        </div>
		<form method="POST" action="transferdie.php" autocomplete="off" name="myForm">
			<div class="col-lg-4">
				<div class="form-group ">
						<h3 style="text-align: center;color:#cc9900;font-size:12pt;">Phone Number To Receive Diesel</h3>
                        <input type="number" name="txtRecepient" size=10 class="form-control">
                </div>
				<div class="form-group ">
						<h3 style="text-align: center;color:#cc9900;font-size:12pt;">Diesel Volume In Litres</h3>
                        <input type="number" name="txtLitres" size=10 class="form-control">
                </div>
				<input type="button" name="btnRespond" value="Send Customer Response" onclick="myfunc()" class="btn form-control" style="background: green;color: #ffbf00;text-align:center;width:100%;font-size:12pt;">
				<input type="submit" name="btnSend" class="subby" hidden>

				<br><br>
				<input type="submit" name="btnClose" value="Go To Main Menu" class="btn form-control" style="background: green;color: #ffbf00;text-align:center;width:100%;font-size:12pt;">
			</div>
            <div class="col-lg-4">
		
			</div>	
			
		</form>	
	<hr>
	</div>

	<div class="Container" style="background-color:black;padding: 150px 25px;margin-top:100px;" >
		<div class="col-lg-4">
		<label style="color:red;">Total Fuel Company.All rights reserved.</label>
		</div>
	  
		<div class="col-lg-4">
		
		</div>
		<div class="col-lg-4">
		</div>
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
