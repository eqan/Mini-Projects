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
from tkinter import *

class Game:

    scores = [0, 0]
    def main_game_init(self):
            global root
            root = Tk()
            root.geometry('300x150+530+250')
            bg1 = PhotoImage(file="home.png")
            back = Label(root, image=bg1).place(x=0, y=0)
            instruc = Button(root, text="Instructions", command = self.game_instructions )
            instruc.place(x=115,y=90)
            start = Button(root,padx=15, text="Start!", command=self.main_game )
            start.place(x=118,y=120)
            root.mainloop()

    '''
            *** Starting Functions Start ***
            Function: Functions facilitating the starting point of the program
    '''

    # Game Instrucitons hard coded as they were
    def game_instructions(self):

        root.destroy()
        global root_instruc
        root_instruc = Tk()
        label1 = Label(root_instruc, text="1. At the start, 2 Players will select their preferred profiles").grid(row=1, column=0)
        label2 = Label(root_instruc, text="2. Each profile will bring different dice characteristics").grid(row=2, column=0)
        label3 = Label(root_instruc, text="3. Then the players will be allowed to pick up their preferred dices, if they have X(symbollically represents -1) in their profiles").grid(row=3, column=0)
        label4 = Label(root_instruc, text="4. Players will roll their dices").grid(row=4, column=0)
        label5 = Label(root_instruc, text="5. Then the players will capture each others dices to gather points").grid(row=5, column=0)
        label6 = Label(root_instruc, text="6. Two ways to capture dices").grid(row=6, column=0)
        label7 = Label(root_instruc, text=" 	A. Skill Attack: Player will pick and choose multiple dices to target opponents 1 dice[But the combined have to be equal to the opponents dice]").grid(row=7, column=0)
        label8 = Label(root_instruc, text="  	B. Power Attack: Player will pick one dice[That dice must be bigger or equal to opponents dice]").grid(row=8, column=0)
        label9 = Label(root_instruc, text="7. After every used dice by the player, the dice would be re-rolled").grid(row=9, column=0)
        label10 = Label(root_instruc, text="8. Captured dice of the player becomes unusable").grid(row=10, column=0)
        label11 = Label(root_instruc, text="9. The program continuosly monitors the rolled dice results and thus if a player isnt eligibile for both the powers, It will give the opponent a turn").grid(row=11, column=0)
        label12 = Label(root_instruc, text="10. In the end the results are finalized after all dices are captured and the player with the most points wins!").grid(row=12, column=0)
        escbtn = Button(root_instruc, text="Back", command=self.main_game_transition ).grid()

    def main_game_transition(self):
        root_instruc.destroy()
        self.main_game_init()

    # Select profiles from a file
    def select_profiles(self, user1, user2):
            lists = []
            with open('profiles.txt') as fp:
                    lines = [current_line.strip() for current_line in fp.readlines()]
            for i,line in enumerate(lines):
                    if(i == int(user1) or i == int(user2)):
                            lists.append(list(line.split(" "))) 
            return self.convert_to_integers(lists)



    # Will set the matching values as -1[i.e Discard those values] and return the result
    def discard_matching(self,results):
            temp_results = deepcopy(results)
            for i,item in enumerate(temp_results[0]):
                    index = self.search(temp_results[1], item)
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
    def decide_user_turn(self,results):
            temp_results = results.copy()
            self.discard_matching(temp_results)
            smallest = self.find_smallest(temp_results)
            if(smallest[0] < smallest[1]):
                    return 0
            else:
                    return 1

    # Executes the first_turn
    def first_turn_1(self):
        global root_x,users,temp_x_entry1,temp_x_entry2,a
        users=[['tanya', 4, 6, 12, '-1', '-1'], ['tony', 8, 8, 20, 20, '-1']]
        root_x = Tk()
        root_x.geometry('500x400+200+100')
            
        check_1 = Label(text="Checking X For Player 1....").place(x=180,y=2)
        temp_x_entry1 = Entry(root_x)
        temp_x_entry1.place(x=180,y=62)
        check_Button1 = Button(text="OK",command=self.p1_update)
        check_Button1.place(x=235,y=87)
        for i,current_dice_maximum in enumerate(users[0]):
                if(i!= 0):
                        if(int(current_dice_maximum) == -1):
                                check_confirm = Label(root_x, text='X Value has been found in this profile, Please Enter A Valid Number To Fill!').place(x=60,y=32)
            
        check_2 = Label(text="Checking X For Player 2....").place(x=180,y=200)
        temp_x_entry2 = Entry(root_x)
        temp_x_entry2.place(x=180,y=260)
        check_Button2 = Button(text="OK",command=self.p2_update)
        check_Button2.place(x=235,y=285)
        for i,current_dice_maximum in enumerate(users[1]):
                if(i!= 0):
                        if(int(current_dice_maximum) == -1):
                                check_confirm = Label(root_x, text='X Value has been found in this profile, Please Enter A Valid Number To Fill!').place(x=60,y=230)
        root_x.mainloop()
        return users_up

    def first_turn(self,users):
            
            roll_dices_result = self.turn(self.first_turn_1())
            return ([self.decide_user_turn(roll_dices_result), roll_dices_result])

    # Checks if a player is eligible to get a turn
    def check_if_player_eligible(self,current_user, roll_dices_result):
            total = 0
            opponent_index = int(self.determine_opponent_index(current_user))
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

    def attack_type(self):

            global attack_val
            attack_val=0
            skill = Button(root_select, text='Skill Attack', command=lambda *args: self.makeSomething(1)).place(x=40,y=200)
            attack = Button(root_select, text='Power Attack', command=lambda *args: self.makeSomething(2)).place(x=360,y=200)
            ex = Button(root_select, text='Exit', command=lambda *args: self.ex_to_ms(root_select)).place(x=450, y=350)
            root_select.mainloop()
            return (attack_val)
            

    def capture_dice(self,current_user, users, roll_dices_result):
            global root_select
            root_select = Tk()
            root_select.geometry('500x400+200+100')
            bg = PhotoImage(file= "background.png")
            labelbg = Label(root_select, image= bg).place(x=0, y=0)
            invalid_input = False
            self.show_scores(users,root_select)
            self.print_dices_results(current_user, users, roll_dices_result,root_select)
            if(self.check_if_player_eligible(current_user, roll_dices_result)):
                    while(not(invalid_input)):
                            opt = self.attack_type()
                            if(opt == 1):
                                    invalid_input = True
                                    self.skill_attack(current_user, users, roll_dices_result)
                            elif(opt==2):
                                    invalid_input = True
                                    self.power_attack(current_user, users, roll_dices_result)
                            else:
                                    invalid_input = False
                                    print('[-] Option out of bounds, try again!\n')

            
#	Skill Attack: Player will pick and choose multiple dices to target opponents 1 dice[But the combined have to be equal to the opponents dice
    def skill_attack(self,current_user, users, roll_dices_result):
            i = 0
            opponent_index = int(self.determine_opponent_index(current_user))
            user_selected_dices = []
            user_selected_indexes = []
            opponent_targeted_index = int(self.select_dice(current_user, current_user, users, roll_dices_result))
            size = int(self.select_No_of_dice(current_user, users, roll_dices_result))
            user_selected_index = int(self.select_dice(current_user, not(current_user), users, roll_dices_result))
            if(user_selected_index>=0 and user_selected_index < len(roll_dices_result[current_user]) and i < size):
                    while(user_selected_index>=-1 and user_selected_index < len(roll_dices_result[current_user]) and i < size):
                            check_if_exist = self.search(user_selected_indexes, user_selected_index)
                            results = [roll_dices_result[current_user][user_selected_index], roll_dices_result[opponent_index][opponent_targeted_index]]
                            if(results[0] != -1 and results[1] != -1 and (not(check_if_exist[0]))):
                                    user_selected_indexes.append(user_selected_index)
                                    user_selected_dices.append(roll_dices_result[current_user][user_selected_index])
                                    i += 1
                                    if(i < size):
                                            user_selected_index = int(self.select_dice(current_user, not(current_user), users, roll_dices_result))
                            else:
                                    print('[-] This dice index, is unusable\n')
                                    user_selected_index = int(self.select_dice(current_user, not(current_user), users, roll_dices_result))
            else:
                    print('[-] Invalid Input, Please Try Again!\n')
            total = self.add_list_elements(user_selected_dices)
            if(total != roll_dices_result[opponent_index][opponent_targeted_index]):
                    print('[-] The Combination didnt match any of the opponents dices, Please try again!\n')
                    self.capture_dice(current_user, users, roll_dices_result)
            else:
                    self.scores[current_user] += roll_dices_result[opponent_index][opponent_targeted_index]
                    roll_dices_result[opponent_index][opponent_targeted_index] = -1
                    for index in user_selected_indexes:
                            if users[current_user][index+1] != -1:
                                    roll_dices_result[current_user][index] = self.roll_dice(users[current_user][index+1])

    def execute_power_attack(self,current_user, opponent, users, roll_dices_result):
            opponent_targeted_index = int(self.select_dice(current_user, current_user, users, roll_dices_result))
            user_selected_index = int(self.select_dice(current_user,not(current_user), users, roll_dices_result))
            if(user_selected_index>=0 and opponent_targeted_index >= 0 and user_selected_index < len(roll_dices_result[current_user]) and opponent_targeted_index < len(roll_dices_result[opponent])):
                    results = [roll_dices_result[current_user][user_selected_index], roll_dices_result[opponent][opponent_targeted_index]]
                    if(results[0] != -1 and results[1] != -1):
                            if(results[0] >= results[1]):
                                    roll_dices_result[current_user][user_selected_index] = self.roll_dice(users[current_user][user_selected_index+1])
                                    self.scores[current_user] += (results[1])
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
    def power_attack(self,current_user, users, roll_dices_result):
            opponent_index = int(self.determine_opponent_index(current_user))
            is_excecuted = False
            while(not(is_excecuted)):
                    is_excecuted = self.execute_power_attack(current_user, opponent_index, users, roll_dices_result)

    '''
            *** Points Capturing Functions End ***
    '''


    '''
            *** Ending Functions Start ***
            Function: Handles the Ending part of the program like finalizing marks, confirming if the game ends or not
    '''

    # Finalizes scores by dividing the leftovers dices of the player by 2 and adding them into the final score card
    def finalize_scores(self,roll_dices_result):
            for i, result in enumerate(roll_dices_result):
                    for dice in result:
                            if(i == 0):
                                    if(dice != -1):
                                            self.scores[0] += (dice/2)
                            elif(i == 1):
                                    if(dice != -1):
                                            self.scores[1] += (dice/2)


    # Checks if a player's dices have all been used up
    def check_if_game_end(self,roll_dices_result):
            total = 0
            for user_dice in roll_dices_result:
                    if(user_dice == -1):
                            total +=1
            if(total == len(roll_dices_result)):
                    return True
            else:
                    return False

    # Declares the winner
    def declare_game_winner(self,users, roll_dices_result):
            self.finalize_scores(roll_dices_result)
            #show_scores(users)
            global root_end
            root_end = Tk()
            root_end.geometry('500x400+200+100')
            if(self.scores[0] > self.scores[1]):
                    self.store_high_scores(users[0][0], self.scores[0])
                    lab= Label(root_end, text=f'[+] Player1[{users[0][0]}] has won the game!').place(x=180,y=100)
            else:
                    self.store_high_scores(users[1][0], self.scores[1])
                    lab= Label(root_end, text=f'[+] Player2[{users[1][0]}] has won the game!').place(x=180,y=100)
            ex = Button(root_end, text='Exit', command=lambda *args: self.ex_to_ms(root_end)).place(x=180, y=200)
            root_end.mainloop()
    '''
            *** Ending Functions End ***
    '''

    '''
            *** Utility Functions Start ***
            Function: Generic Functions Designed to facilitate the End User[For Visuals] and For Developer[To Avoid Repitive Tasks]
    '''
    def ex_to_ms(self,root_temp):
            root_temp.destroy()
            self.main_game_init()

    def p1_update(self):
            global a
            a=int(temp_x_entry1.get())
            for i,current_dice_maximum in enumerate(users[0]):
                    if(i!= 0):
                            if(int(current_dice_maximum) == -1):
                                    check_confirm = Label(root_x, text='X Value has been found in this profile, Please Enter A Valid Number To Fill!').place(x=60,y=32)
                                    users[0][i]=a
            
            return a
    def p2_update(self):
            global b,users_up
            b=int(temp_x_entry2.get())
            for i,current_dice_maximum in enumerate(users[1]):
                    if(i!= 0):
                            if(int(current_dice_maximum) == -1):
                                    check_confirm = Label(root_x, text='X Value has been found in this profile, Please Enter A Valid Number To Fill!').place(x=60,y=32)
                                    users[1][i]=b
                                    users_up=[i for i in users]
            
            root_x.destroy()
            return b

    def makeSomething(self,arg):
            global attack_val
            attack_val = arg
            root_select.destroy()

    # Shows Score Board Of The Two Players
    def show_scores(self,users,root):
            usernames = [users[0][0], users[1][0]]
            payer1= Label(root, text=f'Player1[{usernames[0]}]: {self.scores[0]} | Player2[{usernames[1]}]: {self.scores[1]}').place(x=140, y=300)
    # Clears the console Screen
    def clear(): 
        if name == 'nt': 
            _ = system('cls') 
        else: 
            _ = system('clear')

    # Convert the string integers back into normal integers and returns the results
    def convert_to_integers(self,raw_data):
            for i, sub_list in enumerate(raw_data):
                    for j, s in enumerate(sub_list):
                            if s.isdigit():
                                    raw_data[i][j] = int(s)
            return raw_data

    # Returns the smallest value from a list
    def return_smallest(self,result):
            smallest = maxsize
            for number in result:
                    if(number != -1 and number < smallest):
                            smallest = number
            return smallest

    # Searches the list for the item, returns the index also if found
    def search(self,lst, item):
            for i in range(len(lst)):
                    if (lst[i] == item and lst[i] != -1):
                            return [True, i]
            return [False, -1]

    # Prints the stored dices result
    def print_dices_results(self,current_user, users, roll_dices_result,root):
            usernames = [users[0][0], users[1][0]]
            for i, result in enumerate(roll_dices_result):
                    if(i == current_user):
                            label1= Label(root, text=f'Current User[{usernames[i]}]: {result}').place(x=150,y=40)
                    else:
                            label2= Label(root, text=f'Opponent User[{usernames[i]}]: {result}').place(x=150,y=60)


    # Adds all the list elements
    def add_list_elements(self,lst):
            total = 0
            for number in lst:
                    total += number
            return total

    # Returns Two Random Lists of integers	
    # Consider them as two lists containing rolled dices for each player
    def turn(self,users):
            return [self.roll_dices(users[0]), self.roll_dices(users[1])]

    # Determines the opponents index by using the current user
    def determine_opponent_index(self,current_user):
            if(current_user == 0):
                    return 1
            return 0

    def select_No_of_dice(self,current_user, users, roll_dices_result):
            global dice_val, root_skill
            root_skill = Tk()
            bg = PhotoImage(file= "background.png")
            labelbg = Label(root_skill, image= bg).place(x=0, y=0)
            root_skill.geometry('500x400+200+100')
            dice_val= -1
            D0 = Label(root_skill, text="Select Number of Dice to Attack:").place(x=180,y=10)
            self.print_dices_results(current_user, users, roll_dices_result,root_skill)
            D1 = Button(root_skill, text='1', command=lambda *args: self.choose_Dice(1) ).place(x=200,y=90)
            D2 = Button(root_skill, text='2', command=lambda *args: self.choose_Dice(2) ).place(x=230,y=90)
            D3 = Button(root_skill, text='3', command=lambda *args: self.choose_Dice(3) ).place(x=260,y=90)
            D4 = Button(root_skill, text='4', command=lambda *args: self.choose_Dice(4) ).place(x=290,y=90)
            D5 = Button(root_skill, text='5', command=lambda *args: self.choose_Dice(5) ).place(x=320,y=90)
            ex = Button(root_skill, text='Exit', command=lambda *args: self.ex_to_ms(root_skill)).place(x=450, y=350)
            root_skill.mainloop()
            return dice_val

    def select_dice(self,current_user, opponent_user, users, roll_dices_result):
            global dice_val, root_skill
            root_skill = Tk()
            bg = PhotoImage(file= "background.png")
            labelbg = Label(root_skill, image= bg).place(x=0, y=0)
            root_skill.geometry('500x400+200+100')
            dice_val= -1
            if current_user == opponent_user:
                    D0 = Label(root_skill, text="Select Opponent's Dice to Target:").place(x=160,y=10)
                    D1 = Button(root_skill, text=f'{roll_dices_result[not(current_user)][0]}', padx=7, pady=5, command=lambda *args: self.choose_Dice(0) ).place(x=160,y=90)
                    D2 = Button(root_skill, text=f'{roll_dices_result[not(current_user)][1]}', padx=7, pady=5, command=lambda *args: self.choose_Dice(1) ).place(x=200,y=90)
                    D3 = Button(root_skill, text=f'{roll_dices_result[not(current_user)][2]}', padx=7, pady=5, command=lambda *args: self.choose_Dice(2) ).place(x=240,y=90)
                    D4 = Button(root_skill, text=f'{roll_dices_result[not(current_user)][3]}', padx=7, pady=5, command=lambda *args: self.choose_Dice(3) ).place(x=280,y=90)
                    D5 = Button(root_skill, text=f'{roll_dices_result[not(current_user)][4]}', padx=7, pady=5, command=lambda *args: self.choose_Dice(4) ).place(x=320,y=90)
                    label1= Label(root_skill, text=f'Current User[{users[current_user][0]}]: {roll_dices_result[current_user]}').place(x=160,y=300)
            if current_user != opponent_user:
                    D0 = Label(root_skill, text="Select Your Dice to Attack:").place(x=160,y=10)
                    D1 = Button(root_skill, text=f'{roll_dices_result[current_user][0]}', padx=5, pady=5, command=lambda *args: self.choose_Dice(0) ).place(x=160,y=90)
                    D2 = Button(root_skill, text=f'{roll_dices_result[current_user][1]}', padx=7, pady=5, command=lambda *args: self.choose_Dice(1) ).place(x=200,y=90)
                    D3 = Button(root_skill, text=f'{roll_dices_result[current_user][2]}', padx=7, pady=5, command=lambda *args: self.choose_Dice(2) ).place(x=240,y=90)
                    D4 = Button(root_skill, text=f'{roll_dices_result[current_user][3]}', padx=7, pady=5, command=lambda *args: self.choose_Dice(3) ).place(x=280,y=90)
                    D5 = Button(root_skill, text=f'{roll_dices_result[current_user][4]}', padx=7, pady=5, command=lambda *args: self.choose_Dice(4) ).place(x=320,y=90)
                    label2= Label(root_skill, text=f'Opponent User[{users[not(current_user)][0]}]: {roll_dices_result[not(current_user)]}').place(x=160,y=300)
            ex = Button(root_skill, text='Exit', command=lambda *args: self.ex_to_ms(root_skill)).place(x=450, y=350)
            root_skill.mainloop()
            return dice_val
    # Return random rolled dices for a player
    def roll_dices(self,player):
            roll_dices_result = []
            for i, current_dice_maximum in enumerate(player):
                    if(i != 0 and int(current_dice_maximum) != -1 and player != None):
                            roll_dices_result.append(self.roll_dice(current_dice_maximum))
            return roll_dices_result

    # Roll a single dice
    def roll_dice(self,max_size):
            return randint(1,int(max_size))

    # Return the smallest numbers in a pair, each number represnting its own player
    def find_smallest(self,results):
            smallest = [-1, -1]
            smallest[0] = self.return_smallest(results[0])
            smallest[1] = self.return_smallest(results[1])
            return smallest

    # Displays profiles from png files
    def show_profiles(self):
        global root_prof
        root_prof =Tk()
        global profs
        profs = [-1,-1]
        tanya_img = PhotoImage(file="tanya.png")
        tony_img = PhotoImage(file="tony.png") 
        bauer_img = PhotoImage(file="bauer.png")
        kublai_img = PhotoImage(file="kublai.png") 
        instruc = Label(root_prof, text="Select Two Players to Play with").grid()
        instruc1 = Button(root_prof, image=tanya_img, command=lambda *args: self.choose_profile(0)).grid(row=0, column=1)
        instruc2 = Button(root_prof, image=tony_img, command=lambda *args: self.choose_profile(1) ).grid(row=0, column=2)
        instruc3 = Button(root_prof, image=bauer_img, command=lambda *args: self.choose_profile(2) ).grid(row=2, column=1)
        instruc4 = Button(root_prof, image=kublai_img, command=lambda *args: self.choose_profile(3) ).grid(row=2, column=2)
        
        root_prof.mainloop()
    def choose_Dice(self,x):
            global dice_val
            dice_val=x
            root_skill.destroy()


    # Stores the highscores in a file
    def store_high_scores(self,username, highscore):
            with open('results.txt', 'a') as fp:
                    fp.write(username + " " + str(highscore) + '\n')

    def choose_profile(self,x):
        if profs[0] == -1:
            profs[0] = x
        elif profs[1] == -1:
            profs[1] = x
        if profs[0] != -1 and profs[1] != -1:
            root_prof.destroy()

    '''
            *** Utility Functions End ***
    '''

    def main_game(self):
            game_end = False
            root.destroy()
            self.show_profiles()
            p1 = profs[0]
            p2 = profs[1]
            users = self.select_profiles(p1, p2)
            raw_result = self.first_turn(users)
            current_user = raw_result[0]
            roll_dices_result = raw_result[1]
            while(not(game_end)):
                    self.capture_dice(current_user, users, roll_dices_result)
                    current_user = self.determine_opponent_index(current_user)
                    game_end = self.check_if_game_end(roll_dices_result[current_user])
            self.declare_game_winner(users, roll_dices_result)

	
        
main = Game()
main.main_game_init()
