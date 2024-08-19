#! /bin/bash
while true;
do
	echo '---------------Even or Odd---------------'
	echo 'Enter a number or 0 to exit'
	read n
	if [ $n -eq  0 ];
then
	exit 1
fi
if [ `expr $n % 2` -eq  0 ];
then
	echo $n 'is Even'
else
	echo $n 'is Odd'
fi
done
