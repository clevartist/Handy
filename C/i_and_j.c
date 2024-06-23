#include <stdio.h>

/*
======================================================================
CASE 1:

for loop in which `i` waits for `j` to do its job in order to continue

Ex:  i is at position 0 while j goes through 1, 2, 3 and so on till 
the end of the array. When j finished, i goes to the position 1 and j 
goes through 2, 3, 4 and so on...
======================================================================
*/

int main() {

    int arr[] = {1, 2, 3, 4, 5};
    int size = sizeof(arr) / sizeof(arr[0]);

  
    for (int i = 0; i < size - 1; i++) {
      
        for (int j = i + 1; j < size; j++) {
          
            printf("i = %d, j = %d, arr[i] = %d, arr[j] = %d\n", i, j, arr[i], arr[j]);
          
        }
      
    }

    return 0;
}

/*
======================================================================
CASE 2:

`i` and `j` iterate through the array together
======================================================================
*/

int main() {
    int arr[] = {1, 2, 3, 4, 5};
    int size = sizeof(arr) / sizeof(arr[0]);

    for (int i = 0, j = 1; j < size; i++, j++) {

		
        printf("i = %d, j = %d, arr[i] = %d, arr[j] = %d\n", i, j, arr[i], arr[j]);
      
    }

    return 0;
}
