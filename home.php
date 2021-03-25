<?php
    include('dbconnect.php');
    session_start();
	$starTym= $_SESSION['StarTym'];
	$acnt= $_SESSION['Account'];	
		
	//If page accessed without log in
	if(empty($_SESSION['StarTym'])){
		header("location: login.php");//redirects to another page
	}  
	if(isset($_POST['lgout'])){
		unset ($_SESSION['StarTym']);
		session_destroy();
		header("location: login.php");//redirects to home page
	}
	if(isset($_POST['btnSend'])){
		
		if($_POST['txtResponse']=='1'){header("location: petredeem.php");}
		if($_POST['txtResponse']=='2'){header("location: dieredeem.php");}
		if($_POST['txtResponse']=='3'){header("location: transferpet.php");}
		if($_POST['txtResponse']=='4'){header("location: transferdie.php");}
		//if($_POST['txtResponse']=='9'){header("location: history.php");}
	}
	if (isset($_POST['btnPinSend'])){
		if (empty($_POST['txtOldPin']) || empty($_POST['txtNewPin']) || empty($_POST['txtNewPin2'])){
			echo("<SCRIPT LANGUAGE='JavaScript'>
				window.alert('Your pin changing failed. Please fill in all the fields and try again.')
				window.location.href='home.php'
				</SCRIPT>");
			exit(); 
		}
		
		$oldpin = mysql_real_escape_string($_POST['txtOldPin']);
		$newpin =mysql_real_escape_string($_POST['txtNewPin']);
		$newpin2 =mysql_real_escape_string($_POST['txtNewPin2']);
		
		if (strlen($newpin)!=4){
			echo("<SCRIPT LANGUAGE='JavaScript'>
				window.alert('Your pin changing failed. Pin must be a four digit number. E.g 4565.')
				window.location.href='home.php'
				</SCRIPT>");
			exit(); 
		}
		if (!is_numeric($newpin)){
			echo("<SCRIPT LANGUAGE='JavaScript'>
				window.alert('Your pin changing failed. Letters are not allowed. Pin must be a four digit number. E.g 4565.')
				window.location.href='home.php'
				</SCRIPT>");
			exit(); 
		}
		if ($newpin!=$newpin2){
			echo("<SCRIPT LANGUAGE='JavaScript'>
				window.alert('Your pin changing failed. New pin was wrongly confirmed. Please try again.')
				window.location.href='home.php'
				</SCRIPT>");
			exit(); 
		 }
		
		$sql="SELECT * FROM accounts WHERE Account ='$acnt'AND Pin='$oldpin'";
		$result=mysqli_query($myConn,$sql);//will execute the query into the database
		//$categ=$categ1." ".$typ;
		if (mysqli_num_rows($result)>0){
				mysqli_query($myConn,"UPDATE accounts SET Pin='$newpin' WHERE Account ='$acnt'");
				echo("<SCRIPT LANGUAGE='JavaScript'>
					window.alert('Your new pin is successfully saved in system.')
					window.location.href='home.php'
					</SCRIPT>");
				exit();
		}else{
			echo("<SCRIPT LANGUAGE='JavaScript'>
			window.alert('You provided wrong current pin number. Try again with the correct one.')
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
		<SCRIPT LANGUAGE='JavaScript'>
			function myfunc(){
				//All fields validator
				if(document.myForm.txtResponse.value==""){
					window.alert('Response submission failed. You can not submit black response.'); 
					return false;
				}
			    if(document.myForm.txtResponse.value==5){
					document.getElementById("subbyPetBal").click();
					document.getElementById("resp").value="";
					return false;
				}
			    if(document.myForm.txtResponse.value==6){
					document.getElementById("subbyDieBal").click();
					document.getElementById("resp").value="";
					return false;
				}
				if(document.myForm.txtResponse.value==7){
					document.getElementById("subbyPrice").click();
					document.getElementById("resp").value="";
					return false;
				}
				if(document.myForm.txtResponse.value==8){
					document.getElementById("subbyPin").click();
					document.getElementById("resp").value="";
					return false;
				}
				if(document.myForm.txtResponse.value==9){
					document.getElementById("resp").value="";
					window.location.href='history.php'
					return false;
				}
			
			//code below now send the form after validation is complete
			document.getElementsByClassName("subby")[0].click();
			}
		</SCRIPT>
    </head>
    <body >
	<!-- Pet Bal Modal HTML -->
	<div id="myModPetbal" class="modal fade">
		<div class="modal-dialog" style="margin-top:30px;">
			<div class="modal-content">
				<div class="modal-header">
					<img src="images\logo.png" style="-moz-border-radius:15px;-webkit-border-radius:15px;height:125px;"/><label style="font-size:20pt;">Petrol Balance Enquiry</label>
				</div>
				<form method="POST" action="home.php" autocomplete="off">
				<div class="modal-body">
				<?php
					$pro="Petrol";
					$sql="SELECT * FROM accounts WHERE Account='$acnt' && Product='$pro'";
					$result=mysqli_query($myConn,$sql);//will execute the query into the database
				    if(mysqli_num_rows($result)==1){
					$row=mysqli_fetch_assoc($result);
					$bal= $row['Balance'];
					$bal="Your petrol balance is ".$bal." litres.";
				    }else{
						$bal="You have no any petrol account at Total.";
					}
					mysqli_free_result($result);
				?>
			    <label><?php echo $bal;?></label>
				</div>
				<div class="modal-footer" style="background-color:green;">
					<button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
				</div>
				</form>
			</div>
		</div>
	</div>
	<!-- Die Bal Modal HTML -->
	<div id="myModDiebal" class="modal fade">
		<div class="modal-dialog" style="margin-top:30px;">
			<div class="modal-content">
				<div class="modal-header">
					<img src="images\logo.png" style="-moz-border-radius:15px;-webkit-border-radius:15px;height:125px;"/><label style="font-size:20pt;">Diesel Balance Enquiry</label>
				</div>
				<form method="POST" action="home.php" autocomplete="off">
				<div class="modal-body">
				<?php
					$pro="Diesel";
					$sql="SELECT * FROM accounts WHERE Account='$acnt' && Product='$pro'";
					$result=mysqli_query($myConn,$sql);//will execute the query into the database
				    if(mysqli_num_rows($result)==1){
					$row=mysqli_fetch_assoc($result);
					$bal= $row['Balance'];
					$bal="Your diesel balance is ".$bal." litres.";
				    }else{
						$bal="You have no any diesel account at Total.";
					}
					mysqli_free_result($result);
				?>
			    <label><?php echo $bal;?></label>
				</div>
				<div class="modal-footer" style="background-color:green;">
					<button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
				</div>
				</form>
			</div>
		</div>
	</div>
		<!-- Modal HTML Pin Change -->
	<div id="myModPin" class="modal fade">
		<div class="modal-dialog" style="margin-top:30px;">
			<div class="modal-content">
				<div class="modal-header">
					<img src="images\logo.png" style="-moz-border-radius:15px;-webkit-border-radius:15px;height:125px;"/><label style="font-size:20pt;">Customer Pin Change</label>
				</div>
				<form method="POST" action="home.php" autocomplete="off">
				<div class="modal-body">
					<input type="password" class="form-control" name="txtOldPin" placeholder="type your current pin here"><br>
					<input type="password" class="form-control" name="txtNewPin" placeholder="type your new pin here as a 4 digit number"><br>
					<input type="password" class="form-control" name="txtNewPin2" placeholder="confirm your new pin here"><br>
				</div>
				<div class="modal-footer" style="background-color:green;" >
					<button name="btnPinSend" class="btn btn-default" type="submit">Submit</button>
					<button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
				</div>
				</form>
			</div>
		</div>
	</div>
	<!-- Modal HTML For Prices -->
	<div id="myModPrice" class="modal fade">
		<div class="modal-dialog" style="margin-top:30px;">
			<div class="modal-content">
				<div class="modal-header">
					<img src="images\logo.png" style="-moz-border-radius:15px;-webkit-border-radius:15px;height:125px;"/><label style="font-size:20pt;text-align:center;">Our Fuel Prices</label>
				</div>
				
				<table class="table table-striped table-bordered table-hover table-condensed" style="border-radius: 5px;width:100%;">
			<tr style="color:white;background-color:rgba(0,0,0,0.7);">
				<th><label style="color:white;">Petrol Cost Per Litre $</label></th>
				<th><label style="color:white;">Diesel Cost Per Litre $</label></th>
			</tr>
			<?php
	 
		    $sql="SELECT * FROM tblone"; 
	  
	        $result=mysqli_query($myConn,$sql);
				if (mysqli_num_rows($result)>0){
				while ($row = mysqli_fetch_array($result))	
				{
			?>
			<tr class="infor" style="font-size:10pt;">				 
				<td><?php echo$row['PetCost'];?></td>
				<td><?php echo$row['DieCost'];?></td>
	        </tr>
	
		<?php
		}			   
		}
	  mysqli_free_result($result);
	?>
		</table>
				
				<div class="modal-footer" style="background-color:green;" >
					<button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
				</div>
				
			</div>
		</div>
	</div>
	
	<div class="container" style="background-color:rgba(0,0,0,0.8);padding: 5px 25px; margin-top:30px;-moz-border-radius:15px;-webkit-border-radius:15px;height:600px;">
	<h2 style="text-align: center;color: #cc9900;font-weight:bold;font-size:20pt;">Petrotrade Electronic Coupon System</h2>
	<hr>
			<div class="col-lg-4">
				<img src="images\logo.png" style="align:center;-moz-border-radius:15px;-webkit-border-radius:15px;"/>
	        </div>
		<form method="POST" action="home.php" autocomplete="off" name="myForm">
			<div class="col-lg-4">
				<div class="form-group ">
				
                        <label style="font-weight:bold;font-size:12pt;">1. Fuel Redemption - Petrol</label><br><br>
						<label style="font-weight:bold;font-size:12pt;">2. Fuel Redemption - Diesel</label><br><br>
						<label style="font-weight:bold;font-size:12pt;">3. Fuel Transfer - Petrol</label><br><br>
						<label style="font-weight:bold;font-size:12pt;">4. Fuel Transfer - Diesel</label><br><br>
						<label style="font-weight:bold;font-size:12pt;">5. Fuel Balance Check - Petrol</label><br><br>
						<label style="font-weight:bold;font-size:12pt;">6. Fuel Balance Check - Diesel</label><br><br>
						<label style="font-weight:bold;font-size:12pt;">7. Fuel Pricing</label><br><br>
						<label style="font-weight:bold;font-size:12pt;">8. Fuel Account Pin Change</label><br><br>
						<label style="font-weight:bold;font-size:12pt;">9. Fuel Account Transaction History</label><br><br>
						<br>
						<h3 style="text-align: left;color:#cc9900;font-size:12pt;">Reply with selection</h3>
                        <input type="number" id="resp" name="txtResponse" class="form-control">
                        </div>
				<button hidden type="button" style="width: 180px;" a href="#myModPetbal" data-toggle="modal" id="subbyPetBal">View Our Prices</button>
				<button hidden type="button" style="width: 180px;" a href="#myModDiebal" data-toggle="modal" id="subbyDieBal">View Our Prices</button>
				<button hidden type="button" style="width: 180px;" a href="#myModPrice" data-toggle="modal" id="subbyPrice">View Our Prices</button>
				<button hidden type="button" style="width: 180px;" a href="#myModPin" data-toggle="modal" id="subbyPin">View Our Prices</button>
				<input type="button" name="btnRespond" value="Send Customer Response" onClick="myfunc()" class="btn form-control" style="background: green;color: #ffbf00;text-align:center;width:100%;font-size:12pt;">
				<input type="submit" name="btnSend" class="subby" hidden>

				<br><br>
				<input type="submit" name="lgout" value="Cancel Customer Session" class="btn form-control" style="background: green;color: #ffbf00;text-align:center;width:100%;font-size:12pt;">
			</div>
            <div class="col-lg-4">
		
			</div>	
		</form>	
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
