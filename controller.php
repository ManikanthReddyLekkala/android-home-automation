<?php
if ( file_get_contents('test.txt') == '00001' )
{
	file_put_contents('test.txt', '00000');
}
if ( $_GET['get'] == 1 && ctype_digit(file_get_contents('test.txt')) )
{
	$led1 = substr(file_get_contents('test.txt'),0,1);
	$led2 = substr(file_get_contents('test.txt'),1,1);
	$led3 = substr(file_get_contents('test.txt'),2,1);
	$led4 = substr(file_get_contents('test.txt'),3,1);
	$xit  = substr(file_get_contents('test.txt'),4,1);

	if ( $_GET['led1'] == 1 )
	{
		if ( substr(file_get_contents('test.txt'),0,1) == 1 )
		{
			$led1 = 0;
		}
		else
		{
			$led1 = 1;
		}
	}
	else if ( $_GET['led2'] == 1 )
	{
		if ( substr(file_get_contents('test.txt'),1,1) == 1 )
		{
			$led2= 0;
		}
		else
		{
			$led2 = 1;
		}
	}
	else if ( $_GET['led3'] == 1 )
	{
		if ( substr(file_get_contents('test.txt'),2,1) == 1 )
		{
			$led3 = 0;
		}
		else
		{
			$led3 = 1;
		}
	}
	else if ( $_GET['led4'] == 1 )
	{
		if ( substr(file_get_contents('test.txt'),3,1) == 1 )
		{
			$led4 = 0;
		}
		else
		{
			$led4 = 1;
		}
	}
	else if ( $_GET['xit'] == 1 )
	{
		if ( substr(file_get_contents('test.txt'),4,1) == 1 )
		{
			$xit = 1;
		}
		else
		{
			$xit = 0;
		}
		
	}
	$combined = $led1 . $led2 . $led3 . $led4 . $xit;
	file_put_contents('test.txt', $combined);
}
echo '
<html>
	<head>
		<title>LED Controller</title>
	</head>
<body>';

if ( !ctype_digit(file_get_contents('test.txt')) )
{
	echo '<span style="color: #ff0000">Text file contents not an integer.</span>';
}

echo '
<div style="width: 100%; height: 100%;">

<a href="controller.php?led1=1&get=1" style="text-decoration: none; color: #000000;">
	<img src="red.png" border="0">
</a><br>
<a href="controller.php?led2=1&get=1" style="text-decoration: none; color: #000000;">
	<img src="green.png" border="0">
</a><br>
<a href="controller.php?led3=1&get=1" style="text-decoration: none; color: #000000;">
	<img src="blue.png" border="0">
</a><br>
<a href="controller.php?led4=1&get=1" style="text-decoration: none; color: #000000;">
	<img src="blue.png" border="0">
</a>


</div>

</body>
</html>';
?>