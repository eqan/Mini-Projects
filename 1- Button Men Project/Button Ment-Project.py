'''
	*** Documentation ***
		* This program would be divided into following modules:
			* Starting Functions
			* Points Capturing Functions
			* Ending Functions
			* Utility Functions
'''
from random import randint
from os import system, name 
from sys import maxsize
from copy import deepcopy

scores = [0, 0]

'''
	*** Starting Functions Start ***
	Function: Functions facilitating the starting point of the program
'''

# Game Instrucitons hard coded as they were
def game_instructions():
	clear()
	print('Instruction Manual\n')
	print('1. At the start, 2 Players will select their preferred profiles')
	print('2. Each profile will bring different dice characteristics')
	print('3. Then the players will be allowed to pick up their preferred dices, if they have X(symbollically represents -1) in their profiles')
	print('4. Players will roll their dices')
	print('5. Then the players will capture each others dices to gather points')
	print('6. Two ways to capture dices')
	print(' 	A. Skill Attack: Player will pick and choose multiple dices to target opponents 1 dice[But the combined have to be equal to the opponents dice]')
	print('  	B. Power Attack: Player will pick one dice[That dice must be bigger or equal to opponents dice]')
	print('7. After every used dice by the player, the dice would be re-rolled')
	print('8. Captured dice of the player becomes unusable')
	print('9. The program continuosly monitors the rolled dice results and thus if a player isnt eligibile for both the powers, It will give the opponent a turn')
	print('10. In the end the results are finalized after all dices are captured and the player with the most points wins!\n')

# Select profiles from a file
def select_profiles(user1, user2):
	lists = []
	with open('profiles.txt') as fp:
		lines = [current_line.strip() for current_line in fp.readlines()]
	for i,line in enumerate(lines):
		if(i == int(user1) or i == int(user2)):
			lists.append(list(line.split(" "))) 
	return convert_to_integers(lists)

# Check if a player has an 'X' or -1 in his profile so he can pick and choose his own dice to replace that
# Also bear in mind, one choosen dice value will replace all the X's or -1's of the profile
def check_for_unknown(player):
	found_unknown = False
	updated_maximum = 0
	for i, current_dice_maximum in enumerate(player):
		if(i != 0):
			if(int(current_dice_maximum) == -1 and found_unknown == False):
				print('X Value has been found in this profile, Please Enter A Valid Number To Fill!\n')
				updated_maximum = int(input('Enter A Desired Value: '))
				player[i] = int(updated_maximum)
				found_unknown = True
			elif(int(current_dice_maximum) == -1 and found_unknown == True):
				player[i] = int(updated_maximum)
	return player

# Will set the matching values as -1[i.e Discard those values] and return the result
def discard_matching(results):
	temp_results = deepcopy(results)
	for i,item in enumerate(temp_results[0]):
		index = search(temp_results[1], item)
		if(index[0] == True):
			temp_results[1][index[1]] = -1
			temp_results[0][i] = -1

'''
	** Checks which player to assign the first turn
		* 1st it discards the matching values, by comparing with each other
		* 2nd finds the smallest value for both the players
		* 3rd Compares the values
		* 4th The player who has the smallest value will have the first turn to attack
'''
def decide_user_turn(results):
	temp_results = results.copy()
	discard_matching(temp_results)
	smallest = find_smallest(temp_results)
	if(smallest[0] < smallest[1]):
		return 0
	else:
		return 1

# Executes the first_turn
def first_turn(users):
	print("\nChecking X For Player 1....\n")
	users[0] = check_for_unknown(users[0])
	print("\nChecking X For Player 2....\n")
	users[1] = check_for_unknown(users[1])
	roll_dices_result = turn(users)
	return ([decide_user_turn(roll_dices_result), roll_dices_result])

# Checks if a player is eligible to get a turn
def check_if_player_eligible(current_user, roll_dices_result):
	total = 0
	opponent_index = int(determine_opponent_index(current_user))
	for user_dice in roll_dices_result[current_user]:
		total += user_dice
		for opponent_dice in roll_dices_result[opponent_index]:
			if(user_dice != -1 and opponent_dice != -1):
				if(user_dice >= opponent_dice):
					return True
				elif(total == opponent_dice):
					return True
	return False


'''
	*** Starting Functions End ***
'''


'''
	*** Points Capturing Functions Start ***
	Function: Based on Strategies and also the main core of the program
'''

# Acts as basic user interface to allow users to select their attacks, and also displays score card etc
def capture_dice(current_user, users, roll_dices_result):
	invalid_input = False
	show_scores(users)
	print_dices_results(current_user, users, roll_dices_result)
	if(check_if_player_eligible(current_user, roll_dices_result)):
		while(not(invalid_input)):
			opt = int(input('Select: 1) Skill Attack 2) Power Attack\nInput: '))
			if(opt == 1):
				invalid_input = True
				skill_attack(current_user, users, roll_dices_result)
			elif(opt==2):
				invalid_input = True
				power_attack(current_user, users, roll_dices_result)
			else:
				invalid_input = False
				print('[-] Option out of bounds, try again!\n')


#	Skill Attack: Player will pick and choose multiple dices to target opponents 1 dice[But the combined have to be equal to the opponents dice
def skill_attack(current_user, users, roll_dices_result):
	i = 0
	opponent_index = int(determine_opponent_index(current_user))
	user_selected_dices = []
	user_selected_indexes = []
	opponent_targeted_index = int(input(f'Input Opponent Dice Index To Target: '))
	size = int(input(f'Input Number Of Dices To Select: '))
	user_selected_index = int(input(f'Input Your Dice Index To Attack: '))
	if(user_selected_index>=0 and user_selected_index < len(roll_dices_result[current_user]) and i < size):
		while(user_selected_index>=-1 and user_selected_index < len(roll_dices_result[current_user]) and i < size):
			check_if_exist = search(user_selected_indexes, user_selected_index)
			results = [roll_dices_result[current_user][user_selected_index], roll_dices_result[opponent_index][opponent_targeted_index]]
			if(results[0] != -1 and results[1] != -1 and (not(check_if_exist[0]))):
				user_selected_indexes.append(user_selected_index)
				user_selected_dices.append(roll_dices_result[current_user][user_selected_index])
				i += 1
				if(i < size):
					user_selected_index = int(input(f'Input Your Dice Index To Attack: '))
			else:
				print('[-] This dice index, is unusable\n')
				user_selected_index = int(input(f'Input Your Dice Index To Attack: '))
	else:
		print('[-] Invalid Input, Please Try Again!\n')
	total = add_list_elements(user_selected_dices)
	if(total != roll_dices_result[opponent_index][opponent_targeted_index]):
		print('[-] The Combination didnt match any of the opponents dices, Please try again!\n')
		skill_attack(current_user, users, roll_dices_result)
	else:
		scores[current_user] += roll_dices_result[opponent_index][opponent_targeted_index]
		roll_dices_result[opponent_index][opponent_targeted_index] = -1
		for index in user_selected_indexes:
			roll_dices_result[current_user][index] = roll_dice(users[current_user][index+1])

def execute_power_attack(current_user, opponent, users, roll_dices_result):
	opponent_targeted_index = int(input(f'Input Opponent Dice Index To Target: '))
	user_selected_index = int(input(f'Input Your Dice Index To Attack: '))
	if(user_selected_index>=0 and opponent_targeted_index >= 0 and user_selected_index < len(roll_dices_result[current_user]) and opponent_targeted_index < len(roll_dices_result[opponent])):
		results = [roll_dices_result[current_user][user_selected_index], roll_dices_result[opponent][opponent_targeted_index]]
		if(results[0] != -1 and results[1] != -1):
			if(results[0] >= results[1]):
				roll_dices_result[current_user][user_selected_index] = roll_dice(users[current_user][user_selected_index+1])
				scores[current_user] += (results[1])
				roll_dices_result[opponent][opponent_targeted_index] = -1
				return True
			else:
				print(f'[-] Current Dice[{results[0]}] is not bigger than or equal to Opponent Dice[{results[1]}]')
				return False
		else:
			print('[-] This dice index, is unusable')
			return False
	else:
		print('[-] One of the dice index was out of bounds, Please try again')
		return False

#	Power Attack: Player will pick one dice[That dice must be bigger or equal to opponents dice
def power_attack(current_user, users, roll_dices_result):
	opponent_index = int(determine_opponent_index(current_user))
	is_excecuted = False
	while(not(is_excecuted)):
		is_excecuted = execute_power_attack(current_user, opponent_index, users, roll_dices_result)

'''
	*** Points Capturing Functions End ***
'''


'''
	*** Ending Functions Start ***
	Function: Handles the Ending part of the program like finalizing marks, confirming if the game ends or not
'''

# Finalizes scores by dividing the leftovers dices of the player by 2 and adding them into the final score card
def finalize_scores(roll_dices_result):
	for i, result in enumerate(roll_dices_result):
		for dice in result:
			if(i == 0):
				if(dice != -1):
					scores[0] += (dice/2)
			elif(i == 1):
				if(dice != -1):
					scores[1] += (dice/2)


# Checks if a player's dices have all been used up
def check_if_game_end(roll_dices_result):
	total = 0
	for user_dice in roll_dices_result:
		if(user_dice == -1):
			total +=1
	if(total == len(roll_dices_result)):
		return True
	else:
		return False

# Declares the winner
def declare_game_winner(users, roll_dices_result):
	finalize_scores(roll_dices_result)
	show_scores(users)
	if(scores[0] > scores[1]):
		store_high_scores(users[0][0], scores[0])
		print(f'[+] Player1[{users[0][0]}] has won the game!\n')
	else:
		store_high_scores(users[1][0], scores[1])
		print(f'[+] Player2[{users[1][0]}] has won the game!\n')

'''
	*** Ending Functions End ***
'''

'''
	*** Utility Functions Start ***
	Function: Generic Functions Designed to facilitate the End User[For Visuals] and For Developer[To Avoid Repitive Tasks]
'''

# Shows Score Board Of The Two Players
def show_scores(users):
	usernames = [users[0][0], users[1][0]]
	print(f'Player1[{usernames[0]}]: {scores[0]} | Player2[{usernames[1]}]: {scores[1]}\n')

# Clears the console Screen
def clear(): 
    if name == 'nt': 
        _ = system('cls') 
    else: 
        _ = system('clear')

# Convert the string integers back into normal integers and returns the results
def convert_to_integers(raw_data):
	for i, sub_list in enumerate(raw_data):
		for j, s in enumerate(sub_list):
			if s.isdigit():
				raw_data[i][j] = int(s)
	return raw_data

# Returns the smallest value from a list
def return_smallest(result):
	smallest = maxsize
	for number in result:
		if(number != -1 and number < smallest):
			smallest = number
	return smallest

# Searches the list for the item, returns the index also if found
def search(lst, item):
	for i in range(len(lst)):
		if (lst[i] == item and lst[i] != -1):
			return [True, i]
	return [False, -1]

# Prints the stored dices result
def print_dices_results(current_user, users, roll_dices_result):
	usernames = [users[0][0], users[1][0]]
	for i, result in enumerate(roll_dices_result):
		if(i == current_user):
			print(f'Current User[{usernames[i]}]: {result}')
		else:
			print(f'Opponent User[{usernames[i]}]: {result}')
	print('\n')

# Adds all the list elements
def add_list_elements(lst):
	total = 0
	for number in lst:
		total += number
	return total

# Returns Two Random Lists of integers	
# Consider them as two lists containing rolled dices for each player
def turn(users):
	return [roll_dices(users[0]), roll_dices(users[1])]

# Determines the opponents index by using the current user
def determine_opponent_index(current_user):
	if(current_user == 0):
		return 1
	return 0
	
# Return random rolled dices for a player
def roll_dices(player):
	roll_dices_result = []
	for i, current_dice_maximum in enumerate(player):
		if(i != 0 and int(current_dice_maximum) != -1 and player != None):
			roll_dices_result.append(roll_dice(current_dice_maximum))
	return roll_dices_result

# Roll a single dice
def roll_dice(max_size):
	return randint(1, int(max_size))

# Return the smallest numbers in a pair, each number represnting its own player
def find_smallest(results):
	smallest = [-1, -1]
	smallest[0] = return_smallest(results[0])
	smallest[1] = return_smallest(results[1])
	return smallest

# Displays profiles from a text file
def show_profiles():
	with open('profiles.txt') as fp:
		for i, current_line in enumerate(fp.readlines()):
				print(f'{i} : {current_line.strip()}')
		print('\n')	 

# Stores the highscores in a file
def store_high_scores(username, highscore):
	with open('highscores.txt', 'a') as fp:
		fp.write(username + " " + str(highscore) + '\n')

'''
	*** Utility Functions End ***
'''

def main_game():
	game_instructions()
	game_end = False
	show_profiles()
	p1 = int(input('Player 1, Select Profile: '))
	p2 = int(input('Player 2, Select Profile: '))
	users = select_profiles(p1, p2)
	raw_result = first_turn(users)
	current_user = raw_result[0]
	roll_dices_result = raw_result[1]
	while(not(game_end)):
		clear()
		capture_dice(current_user, users, roll_dices_result)
		current_user = determine_opponent_index(current_user)
		game_end = check_if_game_end(roll_dices_result[current_user])
	declare_game_winner(users, roll_dices_result)
	
main_game()
