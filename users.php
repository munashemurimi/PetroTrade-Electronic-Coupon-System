<?php
    //Call Db Connection
	include('dbconnect.php');
	session_start();
		$ec= $_SESSION['Ec'];
		$alias= $_SESSION['alias'];
		$phone= $_SESSION['phone'];
		$_SESSION['RequestID']="";
		$_SESSION['Search']="Off";
		
		$_SESSION['StaffEc']="";
		$_SESSION['StaffNam']="";
		$_SESSION['StaffCell']="";
		$_SESSION['StaffRyts']="";
		$_SESSION['StaffPswd']="";
	
		$_SESSION['Num']="";
		$_SESSION['Details']="";
		$btnUpd="disabled";
		$btnDel="disabled";
		$btnCrea="enabled";
		
	//If page accessed without log in
	if(empty($_SESSION['Ec'])){
		header("location: login.php");//redirects to another page
	}  

	//Logout
	if(isset($_POST['lgout'])){
	session_destroy();
	unset ($_SESSION['RequestID']);
	unset ($_SESSION['StaffEc']);
	unset ($_SESSION['StaffCell']);
	unset ($_SESSION['StaffNam']);
	unset ($_SESSION['StaffPswd']);
	
	
	unset ($_SESSION['Ec']);
	unset ($_SESSION['alias']);
	unset ($_SESSION['ryts']);
	unset ($_SESSION['phone']);
	header("location: login.php");//redirects to another page
	}
    //Report One Code
	if(isset($_POST['btnRep1'])){
	$_SESSION['ReportTitle']="New Online ICT Employee Requests Report";
	$_SESSION['ReportCriteria']="Applied For";
	$_SESSION['PrntForm']="users.php";
	echo "<meta http-equiv=refresh content=\"0; URL=report.php\">";
	exit();
	}
	
	//Report tWO Code
	if(isset($_POST['btnRep2'])){
	$_SESSION['ReportTitle']="Approved Online ICT Employee Requests Report";
	$_SESSION['ReportCriteria']="Approved";
	$_SESSION['PrntForm']="users.php";
	echo "<meta http-equiv=refresh content=\"0; URL=report.php\">";
	exit();
	}
	
	    //Report THERRE Code
	if(isset($_POST['btnRep3'])){
	$_SESSION['ReportTitle']="On Purchasing Online ICT Employee Requests Report";
	$_SESSION['ReportCriteria']="On Purchasing";
	$_SESSION['PrntForm']="users.php";
	echo "<meta http-equiv=refresh content=\"0; URL=report.php\">";
	exit();
	}
	
	    //Report fOUR Code
	if(isset($_POST['btnRep4'])){
	$_SESSION['ReportTitle']="Allocated ICT Employee Requests Report";
	$_SESSION['ReportCriteria']="Allocated";
	$_SESSION['PrntForm']="users.php";
	echo "<meta http-equiv=refresh content=\"0; URL=report.php\">";
	exit();
	}
	
	//Search Code
	if(isset($_POST['btnModSearcht'])){
		    $sechID=$_POST['txtSearcKeyt'];
			//check if its there and assign new values to session variables if found
	        $query="SELECT * FROM users WHERE Ec='$sechID'";
				
			$result=mysqli_query($myConn,$query) or die(mysqli_error($myConn));
			if (mysqli_num_rows($result)>0){
				while ($row = mysqli_fetch_array($result))	{
					$_SESSION['Search']="On";
					$_SESSION['StaffEc']=$sechID;
					$_SESSION['StaffNam']=$row['Alias'];
					$_SESSION['StaffCell']=$row['Phone'];
					$_SESSION['StaffRyts']=$row['AccLevel'];
					$_SESSION['StaffPswd']=$row['Pswd'];
					$btnUpd="enabled";
					$btnDel="enabled";
					$btnCrea="disabled";
					
		        }
				mysqli_free_result($result);
			}else{
				echo("<SCRIPT LANGUAGE='JavaScript'>
                    window.alert('There is no any employee in system matching the provided ec.')
                    </SCRIPT>");
                echo "<meta http-equiv=refresh content=\"0; URL=users.php\">";
				exit();
			}
	}
 
	 //Submit Or Insert Code
	if(isset($_POST['btnInsert'])){
		//Take posts first
		$staffEc=$_POST['txtStaffEc'];
		$staffNam=$_POST['txtStaffNam'];
		$staffCell=$_POST['txtStaffCell'];
		$staffRyts=$_POST['cmbStaffRyts'];
		$pswd=$_POST['txtPswd'];
		
		//Check for next request id
			$query="SELECT * FROM users WHERE Ec='$staffEc'";
				
			$result=mysqli_query($myConn,$query) or die(mysqli_error($myConn));
			if (mysqli_num_rows($result)>0){
				echo("<SCRIPT LANGUAGE='JavaScript'>
				window.alert('Saving failed. The provided Ec Number is in use by another employee.')
				</SCRIPT>");
				echo "<meta http-equiv=refresh content=\"0; URL=users.php\">";
				exit();
		    }
				
			mysqli_free_result($result);
		//Now save into dbase 
		mysqli_query($myConn,"INSERT INTO users  VALUES('$staffEc','$staffNam','$staffCell','$staffRyts','$pswd')");
		echo("<SCRIPT LANGUAGE='JavaScript'>
            window.alert('The new system user is successfully saved in system.')
            </SCRIPT>");
        echo "<meta http-equiv=refresh content=\"0; URL=users.php\">";
		exit();
	}
	//Button Update Code
	if(isset($_POST['btnUpdate'])){
		//Take posts first
		$staffEc=$_POST['txtStaffEc'];
		$staffNam=$_POST['txtStaffNam'];
		$staffCell=$_POST['txtStaffCell'];
		$staffRyts=$_POST['cmbStaffRyts'];
		$pswd=$_POST['txtPswd'];
		$reqId=$_POST['txtID'];
	
				mysqli_query($myConn,"UPDATE users SET Alias = '$staffNam',Phone= '$staffCell',AccLevel= '$staffRyts',Pswd= '$pswd' WHERE Ec = '$reqId'");
				echo("<SCRIPT LANGUAGE='JavaScript'>
				window.alert('The user record is successfully updated in system database.')
				</SCRIPT>");
				echo "<meta http-equiv=refresh content=\"0; URL=users.php\">";
			exit();	
	}
	//Button Delete Code
	if(isset($_POST['btnDelete'])){
		$reqId=$_POST['txtID'];
			mysqli_query($myConn,"DELETE FROM users WHERE Ec='$reqId'");
			echo("<SCRIPT LANGUAGE='JavaScript'>
			window.alert('The employee or user is successfully deleted from system database.')
			</SCRIPT>");
			echo "<meta http-equiv=refresh content=\"0; URL=users.php\">";
			exit();	
			
	}
?>
<!doctype html>
<html class="no-js" lang="">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="x-ua-compatible" content="ie=edge">
        <title>System Admin</title>
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
		</style>
			<SCRIPT LANGUAGE='JavaScript'>
			function myfunc(){
					//Regex Expressions
				var IDalphanumeric=/^[-0-9a-zA-Z]+$/;
				var ricc= /^[0-9]+$/ ;
				var alphaspaces=/^[ a-zA-Z]+$/;
				var phon=/^\d{10}$/;
				var whitespaces=/[^a-z|^A-Z|^\s]/;
				var letters=/^[a-zA-Z]+$/;
				//All fields validator
				if(document.myForm.txtStaffEc.value=="" && document.myForm.txtStaffNam.value=="" && document.myForm.txtStaffCell.value=="" && document.myForm.cmbStaffRyts.value=="" && document.myForm.txtPswd.value=="" && document.myForm.txtCnPswd.value=="" ){
					window.alert('Submission failed. You can not submit black details.'); 
					return false;
				}
				//Ec Validator
				if(document.myForm.txtStaffEc.value==""){
					window.alert('Submission failed. Fill in the missing ec number.'); 
					return false;
				}
				//Staff Name Validator
				if(document.myForm.txtStaffNam.value==""){
					window.alert('Submission failed. Fill in the missing staff name.'); 			
					return false;
				}
				
				if (document.myForm.txtStaffNam.value.match(alphaspaces)){}
				else{
					window.alert('Submission failed. Staff name must contain letters only.'); 
					return false;
				}
				//Cell Number Validator
				if(document.myForm.txtStaffCell.value==""){
					window.alert('Submission failed. Fill in the missing staff cell phone number.'); 
					return false;
				}
				if (document.myForm.txtStaffCell.value.length!==10){
				window.alert('Submission failed. Staff cell phone number length is invalid.'); 
				return false;
				}
					var str = document.myForm.txtStaffCell.value;
					var n=str.startsWith("07");
				if (n==false){
				window.alert('Submission failed. Invalid next staff cell phone. Zimbabwean Phone numbers start with 07.'); 
				return false;
				}
				//Ryts 
				if(document.myForm.cmbStaffRyts.value==""){
					window.alert('Submission failed. Select the user access rights before proceeding.'); 
					return false;
				}
				//Pswd 
				if(document.myForm.txtPswd.value==""){
					window.alert('Submission failed. Fill in the missing user login password before proceeding.'); 
					return false;
				}
				//Cn-Pswd 
				if(document.myForm.txtCnPswd.value==""){
					window.alert('Submission failed. Fill in the missing confirmation password before proceeding.'); 
					return false;
				}
				//Compare
				if(document.myForm.txtPswd.value!==document.myForm.txtCnPswd.value){
					window.alert('Submission failed. Password is not correctly confirmed.'); 
					return false;
				}
			    //code below now send the form after validation is complete
			    document.getElementsByClassName("subby")[0].click();
			}
			
			function btnUpdtFunc(){
					//Regex Expressions
				var IDalphanumeric=/^[-0-9a-zA-Z]+$/;
				var ricc= /^[0-9]+$/ ;
				var alphaspaces=/^[ a-zA-Z]+$/;
				var phon=/^\d{10}$/;
				var whitespaces=/[^a-z|^A-Z|^\s]/;
				var letters=/^[a-zA-Z]+$/;
				//All fields validator
				if(document.myForm.txtStaffEc.value=="" && document.myForm.txtStaffNam.value=="" && document.myForm.txtStaffCell.value=="" && document.myForm.cmbStaffRyts.value=="" && document.myForm.txtPswd.value=="" && document.myForm.txtCnPswd.value=="" ){
					window.alert('Updating failed. You can not submit black details.'); 
					return false;
				}
				//Ec Validator
				if(document.myForm.txtStaffEc.value==""){
					window.alert('Updating failed. Fill in the missing ec number.'); 
					return false;
				}
				//Staff Name Validator
				if(document.myForm.txtStaffNam.value==""){
					window.alert('Updating failed. Fill in the missing staff name.'); 			
					return false;
				}
				
				if (document.myForm.txtStaffNam.value.match(alphaspaces)){}
				else{
					window.alert('Updating failed. Staff name must contain letters only.'); 
					return false;
				}
				//Cell Number Validator
				if(document.myForm.txtStaffCell.value==""){
					window.alert('Updating failed. Fill in the missing staff cell phone number.'); 
					return false;
				}
				if (document.myForm.txtStaffCell.value.length!==10){
				window.alert('Updating failed. Staff cell phone number length is invalid.'); 
				return false;
				}
					var str = document.myForm.txtStaffCell.value;
					var n=str.startsWith("07");
				if (n==false){
				window.alert('Updating failed. Invalid next staff cell phone. Zimbabwean Phone numbers start with 07.'); 
				return false;
				}
				//Ryts 
				if(document.myForm.cmbStaffRyts.value==""){
					window.alert('Updating failed. Select the user access rights before proceeding.'); 
					return false;
				}
				//Pswd 
				if(document.myForm.txtPswd.value==""){
					window.alert('Updating failed. Fill in the missing user login password before proceeding.'); 
					return false;
				}
				//Cn-Pswd 
				if(document.myForm.txtCnPswd.value==""){
					window.alert('Updating failed. Fill in the missing confirmation password before proceeding.'); 
					return false;
				}
				//Compare
				if(document.myForm.txtPswd.value!==document.myForm.txtCnPswd.value){
					window.alert('Updating failed. Password is not correctly confirmed.'); 
					return false;
				}
			//code below now send the form after validation is complete
			document.getElementsByClassName("subbyUpdt")[0].click();
			}
		</SCRIPT>
		
    </head>
    <body >
		<!-- Modal HTML -->
	<div id="myModal" class="modal fade">
		<div class="modal-dialog" style="margin-top:30px;">
			<div class="modal-content">
				<div class="modal-header">
					<img style="height:100px;width:50%;align:center;" src="images\logo.png"  />
				</div>
				<form method="POST" action="users.php" autocomplete="off" name="modForm">
				<div class="modal-body">
					    <input type="text" class="form-control" name="txtSearcKeyt" placeholder="Employee Ec Number"><br>
				</div>
				<div class="modal-footer" style="background-color:orange;" >
					<button name="btnModSearcht" class="btn btn-default" type="submit">Search</button>
					<button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
				</div>
				</form>
			</div>
		</div>
	</div>
	<!-- Modal HTML With take reason result-->
	<div id="myModal2" class="modal fade">
		<div class="modal-dialog" style="margin-top:30px;">
			<div class="modal-content">
				<div class="modal-header">
					<img style="height:100px;width:50%;align:center;" src="images\logo.png"  />
					<label>Clieck the button correcsponding the report request type</label>
				</div>
				<form method="POST" action="users.php" autocomplete="off" name="modForm">
				<div class="modal-body">					
                <button name="btnRep1" class="btn btn-default" type="submit" >New Requests</button>
				<button name="btnRep2" class="btn btn-default" type="submit" >Approved </button>
				<button name="btnRep3" class="btn btn-default" type="submit" >On Purchase </button>
				<button name="btnRep4" class="btn btn-default" type="submit" >Allocated </button>
				</div>
				<div class="modal-footer" style="background-color:orange;" >
					<button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
				</div>
				</form>
			</div>
		</div>
	</div>
	
	
	<div class="Container" style="background-color:orange;padding:10px 5px; margin-top:0px;" >

    </div>
	<div class="Container" style="background-color:white;padding:2px 5px;" >
		
    </div>
	<div class="container" style="background-color:white;padding: 5px 25px; margin-top:60px;-moz-border-radius:15px;-webkit-border-radius:15px;">
	<h2 style="text-align: center;color:black;font-weight:bold;">ICT Staff Online Purchases Requisitions System Administration</h2>
	<hr>
			<div class="col-lg-4">
				<img src="images\logo.png" style="align:center;-moz-border-radius:15px;-webkit-border-radius:15px;"/>
				<table class="table table-striped  table-hover table-condensed" style="border-radius: 5px;">
					<tr >
						<th><label style="color:orange;">Logged In Staff Name</label></th>
						<td><label><?php echo $alias;?></label></td> 
					</tr>
					<tr >
						<th><label style="color:orange;">Your EC Number</label></th>  
						<td><label><?php echo $ec;?></label></td>
					</tr>
					<tr >
						<th><label style="color:orange;">Your Cell Number</label></th>  
						<td><label><?php echo $phone;?></label></td>
					</tr>
				</table>
	        </div>
		<form method="POST" action="users.php" autocomplete="off" name="myForm">
			<div class="col-lg-4">
				
				<label style="color:white;">.</label>
					    <div class="form-group">
							<div class="input-group">
								<span class="input-group-addon" id="basic-addon3">Ec Number<label style="color:white;">................</label></span>
								<input name="txtStaffEc" maxlength="10" value="<?php echo $_SESSION['StaffEc'];?>"  type="text" class="form-control" id="basic-url" aria-describedby="basic-addon3">						
							</div>
						</div>
					    <div class="form-group">
							<div class="input-group">
								<span class="input-group-addon" id="basic-addon3">Staff Name<label style="color:white;">................</label></span>
								<input name="txtStaffNam" maxlength="30" value="<?php echo $_SESSION['StaffNam'];?>"  type="text" class="form-control" id="basic-url" aria-describedby="basic-addon3">						
							</div>
						</div>
						  <div class="form-group">
							<div class="input-group">
								<span class="input-group-addon" id="basic-addon3">Cellphone Number</span>
								<input name="txtStaffCell" maxlength="10" value="<?php echo $_SESSION['StaffCell'];?>" type="number" class="form-control" id="basic-url" aria-describedby="basic-addon3">						
							</div>
						</div>
						<div class="p-2">
							<input type="button" <?php echo $btnCrea;?> value="Save Employee" onclick="myfunc()" class="btn form-control" style="background:black;color:#fff;text-align:center;width:40%;">
							<input style="left:28%;" class="subby" type="submit" name="btnInsert" hidden>
			
							<input type="button" value="Search Employee" a href="#myModal" data-toggle="modal" class="btnMod" style="background:black;color:#fff;text-align:center;width:58%;height:34px;">
						
							<br><br>
							<input type="submit" name="btnDelete" <?php echo $btnDel;?> value="Delete Employee" class="btn form-control" style="background:black;color:#fff;text-align:center;width:40%;">
							<input type="button" value="Update Employee Record" <?php echo $btnUpd;?>  onclick="btnUpdtFunc()"  class="btn form-control" style="background:black;color:#fff;text-align:center;width:58%;">
							<input style="left:28%;" class="subbyUpdt" type="submit" name="btnUpdate" hidden>
						</div>
			
			</div>
            <div class="col-lg-4">
				
					    <label style="color:white;">.</label>
				   <div class="form-group">
							<div class="input-group">
								<span class="input-group-addon" id="basic-addon3">Acces Level<label style="color:white;">.............</label></span>
							    <select name="cmbStaffRyts" class="form-control" style="background:white;color:black;">
									<option value="<?php echo $_SESSION['StaffRyts'];?>"><?php echo $_SESSION['StaffRyts'];?></option>
									<option value="I.T">I.T</option>
									<option value="CEO Approval">CEO Approval</option>
									<option value="Stocks">Stocks</option>
									<option value="System Admin">System Admin</option>
								</select><br>					
							</div>
					</div>
					<div class="form-group">
							<div class="input-group">
								<span class="input-group-addon" id="basic-addon3">Login Password<label style="color:white;">.....</label></span>
								<input name="txtPswd" maxlength="10" value="<?php echo $_SESSION['StaffPswd'];?>"  type="password" class="form-control" id="basic-url" aria-describedby="basic-addon3">						
							</div>
					</div>
					<div class="form-group">
							<div class="input-group">
								<span class="input-group-addon" id="basic-addon3">Confirm Password</span>
								<input name="txtCnPswd" maxlength="10" value="<?php echo $_SESSION['StaffPswd'];?>" type="password" class="form-control" id="basic-url" aria-describedby="basic-addon3">						
							</div>
					</div>
						<input type="submit" name="btnClear" value="Clear Form" class="btn form-control" style="background:black;color:#fff;text-align:center;width:40%;">
						<input type="submit" name="lgout" value="Logout Of System" class="btn form-control" style="background:black;color:#fff;text-align:center;width:58%;">
						<br><br>
						<input type="button" value="View System Reports" a href="#myModal2" data-toggle="modal" class="btnMod" style="background:black;color:#fff;text-align:center;width:100%;height:34px;">

						
						<input name="txtID" hidden  value="<?php echo $_SESSION['StaffEc'];?>">						

		
			</div>	
		</form>	
		
		<hr>
	</div>
	
	<div class="Container" style="background-color:black;padding: 50px 25px;margin-top:100px;" >
		<div class="col-lg-4">
		<label style="color:orange;">Ministry Of ICT @2018.All rights reserved.</label>
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
