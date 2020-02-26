#!/usr/bin/python

#read map and get size
mazeData = open("MazeMap.txt","r")
sizeArgs = mazeData.read(5)
sizeRow = int(sizeArgs[0:2])
sizeCol = int(sizeArgs[3:5])
print("Detected Maze of size:", sizeRow, "x", sizeCol)

#input maze data into 2d array
maze = [[]]
startPosR=0
startPosC=0
endPosR=0
endPosC=0
for row in range(0,sizeRow+1):
	rowAr = []
	for col in range(0,sizeCol+1):
		rowAr.insert(col,mazeData.read(1))
		#check if start/end position
		if(rowAr[col]=="S"):
			startPosR=row
			startPosC=col
			print("Found start position at:",startPosR,"x",startPosC)
		if(rowAr[col]=="E"):
			endPosR=row
			endPosC=col
			print("Found end position at:",endPosR,"x",endPosC)
	maze.insert(row,rowAr)
mazeData.close()

#print out data read
def printMaze():
	for row in maze:
		rowStr = ""
		for col in row:
			rowStr+=col
		print(rowStr)

#actually solve maze
def Solve(row,col):
	#V,^,<,>
	check=[0,0,0,0]
	#check if start position
	if(row==startPosR and col==startPosC):
		check[1]=1
		Solve(row+1,col)
	#check if maze is solved
	if(maze[row][col]=="E"):
		isSolved = 1
		print("Solution found at.",row,",",col)
		return
	#check surroundings
	if(row<sizeRow):
		if(maze[row+1][col]!="-" and maze[row+1][col]!="E"):
			check[0]=1 #V
	if(row>0):
		if(maze[row-1][col]!="-" and maze[row-1][col]!="E"):
			check[1]=1 #^
	if(col>0):
		if(maze[row][col-1]!="-" and maze[row][col-1]!="E"):
			check[2]=1 #<
	if(col<sizeCol):
		if(maze[row][col+1]!="-" and maze[row][col+1]!="E"):
			check[3]=1 #>
	#attempt to move
	if(check[0]==0): #move down
		maze[row][col]="v"
		Solve(row+1,col)
	if(check[1]==0): #move up
		maze[row][col]="^"
		Solve(row-1,col)		
	if(check[2]==0): #move left 
		maze[row][col]="<"		
		Solve(row,col-1)
	if(check[3]==0): #move right
		maze[row][col]=">"
		Solve(row,col+1)
	#check if cornered
	if(check[0]+check[1]+check[2]+check[3]>=3):
		return
		maze[row][col]="x"
	
#do solve
print("Read maze...")
printMaze()
Solve(startPosR,startPosC)
printMaze()