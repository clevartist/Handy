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

		// ITERATE THROUGH EACH ROW
		for(int row = 0; row < nums.GetLength(0); row++) {
			for(int column = 0; column < nums.GetLength(1); column++) {
				Console.Write("Row " + row + ", Column " + column + " -> " + nums[row, column] + "\n");
			}
		}


		
		// ITERATE THROUGH A COLUMN
		for(int i = 0; i < nums.GetLength(1); i++) {
			Console.WriteLine(nums[i, 0]);
		}

		//ITERATE THROUGH EACH COLUMN
		for(int column = 0; column < nums.GetLength(1); column++) {
			for(int row = 0; row.GetLength(0); row++) {
				Console.Write("Row " + row + ", Column " + column + " -> " + nums[row, column] + "\n");
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
