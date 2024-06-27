#include <stdio.h>
#include <string.h>
#include <stdlib.h>



/*
	--STRING TO INT--
*/
// Method 1: using loops
char* a = "9873";
int int_a = 0;

for(int i = 0; a[i] != '\0'; i++) {
	int_a = int_a * 10 + (a[i] - 48);
	// Why 48? For e.g. ASCII value of character ‘5’ is 53, so 53 – 48 = 5
}

//Method 2: using atoi()
char* a = "9873";
int int_a = atoi(a);



// ...gonna add more if I'll encounter such situations
