#!/bin/bash
# Iterate through all the '*.mkv' files
for file_name in *.m4a; do
    # If there are no results, it returns '*.mkv'
    if [ "$file_name" == '*.m4a' ]; then
        continue
    fi 
    
    # Make sure we aren't re-converting every file...
    base_name="${file_name%.*}"
    echo $file_name
    if [ ! -f "$base_name.ogg" ]; then
        ffmpeg -i "$file_name" "$base_name.ogg" 
    else
        echo "Already converted: $file_name"
    fi
done
