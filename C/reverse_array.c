// Pretty sure I'd write two `for` loops to solve this task but there is a simpler solution:

#include <stddef.h>

void reverse(size_t length, const int array[length], int reversed[length]) {
    for(int i = 0; i < length; i++) {
        reversed[i] = array[length - i - 1];
    }
}

/*
When i is 0:

length - i - 1 is 5 - 0 - 1 = 4
So, we take the element at index 4 of array, which is 5, and put it into index 0 of reversed.
Now reversed becomes [5, 0, 0, 0, 0]


When i is 1:

length - i - 1 is 5 - 1 - 1 = 3
So, we take the element at index 3 of array, which is 4, and put it into index 1 of reversed.
Now reversed becomes [5, 4, 0, 0, 0]

and so on...
*/
