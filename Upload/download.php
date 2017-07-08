<?php
	include 'dbq.php';


	$resultSet = TakeAllValues();
	//If results true then show the results.
	if ($resultSet->num_rows !=0){
		while ($rows = $resultSet->fetch_assoc())
		{
			$imagelink = $rows['imageLink'];
			$name = $rows ['name'];
			$downloadlink = $rows['downloadlink'];
			$date = $rows['uploadDate'];
			//The interface start
			echo "
				<html>
					<head>
						<meta charset='UTF-8'>
						<title>Download Page</title>
						<style>
							td 
							{
								border-style:solid;
								border-width: 1px;
							}
							.subHeading 
							{
								font-size: 12px;
							}
						</style>
					</head>
					<body>
						<div border='1'>
							<table align='center'>
								<tr>
									<td width='50px' height='50'><img src='$imagelink' alt='$name' width = '50px'/></td>
									<td width='600px' height='50'>$name <br/> <i><span class='subHeading'>Upload date: $date</span></i></td>
									<td width='50px' height='50'><a href='$downloadlink'>Download</a></td>
								</tr>
								<tr height='1px'>
								</tr>
							</table></div>
							
					</body>
				</html>
				";
			//The interface end
				
		}
	}else{
		echo "No results.";
	}
?>