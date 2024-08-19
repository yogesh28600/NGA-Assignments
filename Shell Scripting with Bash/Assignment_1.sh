#! /bin/bash
if [ "$#" -ne 2 ]; then
	echo "Usage: $0 directory file name"
	exit 1
fi
directory=$1
file=$2
find_file=$(find "$directory" -type f -name "$file")
if [ -n "$find_file" ];
then
	echo "$find_file"
else
	echo "file not found"
fi



