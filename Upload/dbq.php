<?php
	//This is the Connection PHP

	function TakeAllValues()
	{
		$mysqli = NEW MySQLi ('localhost','root','','download');
		$resultSet = $mysqli->query("SELECT * FROM tracker"); 
		return $resultSet;
	}

?>