#!/bin/bash

filename=$1
num_of_lines=$(wc -l < "$filename")
echo "Number of lines: $num_of_lines"
