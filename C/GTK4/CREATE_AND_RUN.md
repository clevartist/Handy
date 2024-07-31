<h2>Step 0:</h2>
<h4>Create a file</h4>
<p>(ex: <code>hello-world-gtk.c</code>)</p>

<h2>Step 1:</h2> 
<h4>Compile program</h4>
<p>- First, just in case, make sure the file is truly in the directory:</p>
<p>use -> <code>ls</code></p>
<p>- Next, compile:</p>
<code>gcc hello-world-gtk.c -o hello-world-gtk `pkg-config --cflags --libs gtk4`</code>
<p>- To run without the large command window left behind, add <code>-mwindows</code> at the end of the compiling line:</p>
<code>gcc hello-world-gtk.c -o hello-world-gtk `pkg-config --cflags --libs gtk4` -mwindows</code>

<h2>Step 2: </h2>
<h4>Run program</h4>
<code>./hello-world-gtk</code>
