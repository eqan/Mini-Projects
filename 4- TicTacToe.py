# Considering there is not a jagged array
''' Also
needed to experiment with multi line comment :) '''
# Still has some bugs but ah well kam sikh liya bs ki kran hon, baad wich kr lawan ge thek
from os import system, name 
matrix = [[-1]*3, [-1]*3, [-1]*3]

def clear(): 
    if name == 'nt': 
        _ = system('cls') 
    else: 
        _ = system('clear')

def systemPause(): 
    if name == 'nt': 
        _ = system('pause') 

def leftdiagonal(player):
	conditionCount = 0
	for i in range(len(matrix)):
		if(matrix[i][i] == player):
			conditionCount+=1
		else:
			conditionCount-=1
	if((conditionCount+1) >= len(matrix)):
		return True
	else:
		return False

def rightdiagonal(player):
	conditionCount = 0
	i = len(matrix) - 1
	while(i >= 0):
		if(matrix[i][i] == player):
			conditionCount+=1
		else:
			conditionCount-=1
		i -=1 
	if((conditionCount+1) >= len(matrix)):
		return True
	else:
		return False

def allrows(player):
	conditionCount = 0
	for i in range(len(matrix)):
		for j in range(len(matrix[i])):
			if(matrix[i][j] == player):
				conditionCount+=1
			elif((conditionCount+1) >= len(matrix) and (j+1) == len(matrix[i])): 
				return True
			else:
				conditionCount-=1
	return False

def allcolumns(player):
	conditionCount = 0
	for i in range(len(matrix)):
		for j in range(len(matrix[i])):
			if(matrix[i][j] == player):
				conditionCount+=1
			elif((conditionCount+1) >= len(matrix) and (j+1) == len(matrix[i])): #! Problem Here
				return True
			else:
				conditionCount-=1
	return False
	
def checkifgamewon(wincondition, player):
	if(wincondition == True):
		print("player " + str(player) +  " won the game")
		systemPause()

def rulescheck(player):
	checkifgamewon(leftdiagonal(player), player)
	checkifgamewon(rightdiagonal(player), player)
	checkifgamewon(allrows(player), player)
	checkifgamewon(allcolumns(player), player)

def insertInMatrix(row=0, column=0, player=0, totalturns=0):
	if(row >= len(matrix) or column >= len(matrix[0])):
		print("Please enter a valid input!")
		userInput(player, totalturns)
	try:
		if(matrix[row][column] == -1):
			matrix[row][column] = player
		else:
			print("This is already filled!")
			userInput(player, totalturns)
		if(totalturns >= 4):
			rulescheck(player)
	except IndexError as e:
		print(e)
	except Exception as e:
		print(e)
	return True

def userInput(player, totalturns):
	print("Turns: ", totalturns)
	print("Current Player: ", player)
	row = int(input("Enter row index: "))
	column = int(input("Enter column index: "))
	insertInMatrix(row, column, player, totalturns)

def displaygame():
	for row in matrix:
		print(row)

def main():
	current_player = 0
	totalturns =  len(matrix) * len(matrix[0])
	current_turns = 0
	while(current_turns != totalturns):
		displaygame()
		userInput(current_player, current_turns)
		if(current_player == 0):
			current_player = 1
		elif(current_player == 1):
			current_player = 0
		current_turns +=1
		clear()
	print("game has been drawn")

main()