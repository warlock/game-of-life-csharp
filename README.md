# game-of-life-csharp
John Conway's Game of Life in Microsoft C#

## Attributes
###Grid
Is a boolean two dimension array


##Main Methods:
###MakeRandomGrid()
Generate a grid with 10x10

###MakeRandomGrid(int x, int y)
Generate a grid with specified size.

###MakingLife()
Change next states in grid.


##Internal Methods and Utils:
###GetNear(int x, int y)
Obtain quantity near life rows.

###GetVal(int x, int y)
Obtain value in row.

###Transform(int x, int y)
Change state with this row.

###GetGridSize()
Returns array with Grid size.


##Debug with Console.Write:
###PaintGrid
Paint with Console the actual Grid.

###CheckLife
Paint between life in the actual Grid.
