Step 0:
Create a file (ex: `hello-world-gtk.c`)

Step 1: 
Compile program
- First, just in case, make sure the file is truly in the directory:
use -> `ls`
- Next, compile:
```
gcc hello-world-gtk.c -o hello-world-gtk `pkg-config --cflags --libs gtk4`
```

Step 2: 
Run program
```
./hello-world-gtk
```
