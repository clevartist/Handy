using System;

class Matrix {
	static void Main() {
		int[,] nums = {
			{1,2,3},
			{4,5,6},
			{7,8,9}
		};

		
		// ITERATE THROUGH A ROW
		for(int i = 0; i < nums.GetLength(1); i++) {
			Console.Write(nums[0, i] + " ");
			/*
			nums[0, i]
			0 -> row's index
			i -> column's index
			*/
		}

		
		// ITERATE THROUGH A COLUMN
		for(int i = 0; i < nums.GetLength(1); i++) {
			Console.WriteLine(nums[i, 0]);
		}

		
		// ITERATE THROUGH EVERYTHING
		for(int i = 0; i < nums.GetLength(0); i++) {
			for(int j = 0; j < nums.GetLength(1); j++) {
				Console.Write(nums[i, j] + " ");
			}
		}

		
		// ITERATE ON DIAGONAL (TOP LEFT -> BOTTOM RIGHT)
		for (int i = 0; i < nums.GetLength(0); i++) {
            		Console.WriteLine(nums[i, i]);
        	}

		
		// ITERATE ON DIAGONAL (TOP RIGHT -> BOTTOM LEFT)
		int rows = nums.GetLength(0);
        	int columns = nums.GetLength(1);
        
        	for (int i = 0; i < rows; i++) {
			Console.WriteLine(nums[i, columns - 1 - i]);
		}
	}
}
