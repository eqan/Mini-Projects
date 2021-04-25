
#include <SFML/Graphics.hpp>
#include <SFML/Audio.hpp>
#include <sstream>
#include <iostream>
#include <conio.h>     
#include <math.h>
#include <string>
#include <fstream>
#include <iostream>
#include <time.h>
#include <stdlib.h>

using namespace std;
using namespace sf;


void GamePlay()
{
	//Creating the window
	RenderWindow window(sf::VideoMode(800, 600), "Word Search:Alpha", sf::Style::Resize | sf::Style::Close);
	window.setVerticalSyncEnabled(true);

	//Settign the framerate limit to 60 FPS
	window.setFramerateLimit(60);

	window.setKeyRepeatEnabled(false);

	//Variable that keeps the game loop running
	bool play = true;

	//Event object holding all events
	Event event;



//Font
Font font;	//Font object
if (font.loadFromFile("Fonts/Serpentine.ttf") == 0) //Safe way to load font
{
	cout << "Font not found";
	return;
}
//Mouse
event.mouseButton.x;
event.mouseButton.y;

//Alphabets
sf::Texture Atex;
sf::Texture Btex;
sf::Texture Ctex;
sf::Texture Dtex;
sf::Texture Etex;
sf::Texture Ftex;
sf::Texture Gtex;
sf::Texture Htex;
sf::Texture Itex;
sf::Texture Jtex;
sf::Texture Ktex;
sf::Texture Ltex;
sf::Texture Mtex;
sf::Texture Ntex;
sf::Texture Otex;
sf::Texture Ptex;
sf::Texture Qtex;
sf::Texture Rtex;
sf::Texture Stex;
sf::Texture Ttex;
sf::Texture Utex;
sf::Texture Vtex;
sf::Texture Wtex;
sf::Texture Xtex;
sf::Texture Ytex;
sf::Texture Ztex;
if (Atex.loadFromFile("Alphabets/A.png") == false)
{
	return;
}
if (Btex.loadFromFile("Alphabets/B.png") == false)
{
	return;
}
if (Ctex.loadFromFile("Alphabets/C.png") == false)
{
	return;
}
if (Dtex.loadFromFile("Alphabets/D.png") == false)
{
	return;
}
if (Etex.loadFromFile("Alphabets/E.png") == false)
{
	return;
}
if (Ftex.loadFromFile("Alphabets/F.png") == false)
{
	return;
}
if (Gtex.loadFromFile("Alphabets/G.png") == false)
{
	return;
}
if (Htex.loadFromFile("Alphabets/H.png") == false)
{
	return;
}
if (Itex.loadFromFile("Alphabets/I.png") == false)
{
	return;
}
if (Jtex.loadFromFile("Alphabets/J.png") == false)
{
	return;
}
if (Ktex.loadFromFile("Alphabets/K.png") == false)
{
	return;
}
if (Ltex.loadFromFile("Alphabets/L.png") == false)
{
	return;
}
if (Mtex.loadFromFile("Alphabets/M.png") == false)
{
	return;
}
if (Ntex.loadFromFile("Alphabets/N.png") == false)
{
	return;
}
if (Otex.loadFromFile("Alphabets/O.png") == false)
{
	return;
}
if (Ptex.loadFromFile("Alphabets/P.png") == false)
{
	return;
}
if (Qtex.loadFromFile("Alphabets/Q.png") == false)
{
	return;
}
if (Rtex.loadFromFile("Alphabets/R.png") == false)
{
	return;
}
if (Stex.loadFromFile("Alphabets/S.png") == false)
{
	return;
}
if (Ttex.loadFromFile("Alphabets/T.png") == false)
{
	return;
}
if (Utex.loadFromFile("Alphabets/U.png") == false)
{
	return;
}
if (Vtex.loadFromFile("Alphabets/V.png") == false)
{
	return;
}
if (Wtex.loadFromFile("Alphabets/W.png") == false)
{
	return;
}
if (Xtex.loadFromFile("Alphabets/X.png") == false)
{
	return;
}
if (Ytex.loadFromFile("Alphabets/Y.png") == false)
{
	return;
}
if (Ztex.loadFromFile("Alphabets/Z.png") == false)
{
	return;
}


sf::RectangleShape A;
A.setSize(sf::Vector2f(20, 20));
A.setTexture(&Atex);
sf::RectangleShape B;
B.setSize(sf::Vector2f(20, 20));
B.setTexture(&Btex);
sf::RectangleShape C;
C.setSize(sf::Vector2f(20, 20));
C.setTexture(&Ctex);
sf::RectangleShape D;
D.setSize(sf::Vector2f(20, 20));
D.setTexture(&Dtex);
sf::RectangleShape E;
E.setSize(sf::Vector2f(20, 20));
E.setTexture(&Etex);
sf::RectangleShape F;
F.setSize(sf::Vector2f(20, 20));
F.setTexture(&Ftex);
sf::RectangleShape G;
G.setSize(sf::Vector2f(20, 20));
G.setTexture(&Gtex);
sf::RectangleShape H;
H.setSize(sf::Vector2f(20, 20));
H.setTexture(&Htex);
sf::RectangleShape I;
I.setSize(sf::Vector2f(20, 20));
I.setTexture(&Itex);
sf::RectangleShape J;
J.setSize(sf::Vector2f(20, 20));
J.setTexture(&Jtex);
sf::RectangleShape K;
K.setSize(sf::Vector2f(20, 20));
K.setTexture(&Ktex);
sf::RectangleShape L;
L.setSize(sf::Vector2f(20, 20));
L.setTexture(&Ltex);
sf::RectangleShape M;
M.setSize(sf::Vector2f(20, 20));
M.setTexture(&Mtex);
sf::RectangleShape N;
N.setSize(sf::Vector2f(20, 20));
N.setTexture(&Ntex);
sf::RectangleShape O;
O.setSize(sf::Vector2f(20, 20));
O.setTexture(&Otex);
sf::RectangleShape P;
P.setSize(sf::Vector2f(20, 20));
P.setTexture(&Ptex);
sf::RectangleShape Q;
Q.setSize(sf::Vector2f(20, 20));
Q.setTexture(&Qtex);
sf::RectangleShape R;
R.setSize(sf::Vector2f(20, 20));
R.setTexture(&Rtex);
sf::RectangleShape S;
S.setSize(sf::Vector2f(20, 20));
S.setTexture(&Stex);
sf::RectangleShape T;
T.setSize(sf::Vector2f(20, 20));
T.setTexture(&Ttex);
sf::RectangleShape U;
U.setSize(sf::Vector2f(20, 20));
U.setTexture(&Utex);
sf::RectangleShape V;
V.setSize(sf::Vector2f(20, 20));
V.setTexture(&Vtex);
sf::RectangleShape W;
W.setSize(sf::Vector2f(20, 20));
W.setTexture(&Wtex);
sf::RectangleShape X;
X.setSize(sf::Vector2f(20, 20));
X.setTexture(&Xtex);
sf::RectangleShape Y;
Y.setSize(sf::Vector2f(20, 20));
Y.setTexture(&Ytex);
sf::RectangleShape Z;
Z.setSize(sf::Vector2f(20, 20));
Z.setTexture(&Ztex);
	
	sf::Vector2i localPosition;
	//Game loop
	while (play == true)
	{

		////EVENTS
		while (window.pollEvent(event))
		{
			if (event.type == sf::Event::Closed)
			{
				exit(0);
			}
			switch (event.type)
			{
			case sf::Event::MouseButtonPressed:
			{
				switch (event.key.code)
				{
				
				}
			}
			case sf::Event::MouseMoved:
				/*cout << sf::Mouse::getPosition(window).x << " " << sf::Mouse::getPosition(window).y << endl;*/
				sf::Mouse::getPosition(window).x;
				sf::Mouse::getPosition(window).y;
				break;
			}
			//LeaderBoard.setColor(sf::Color::White);

			////LOGIC
			ifstream fin;
			int count = 0;
			char arr[10][10];
			string str[100];
			char ch = '*';
			int size = 10;
			int half = size / 2;
			int randomrow = 0;
			int randomcolumn = 0;
			int randomway = 0;
			bool flag = false;
			bool flag1 = true;
			int check = 0;

			fin.open("School.txt");

			if (!fin)
			{
				cout << "Words File Not Opened" << endl;
				std::system("pause");
			}

			while (!fin.eof())
			{
				if (!fin.eof())
				{
					getline(fin, str[count]);
					++count;
				}
			}
			//cout << "Number of Words: " << count << endl;
			fin.close();

			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					arr[i][j] = ch;
				}
			}
			for (int i = 0; i < count; i++)
			{
				cout << str[i] << endl;
			}
			cout << endl;

			srand(time(0));

			while (check != count)
			{
				//RANDOM INDEX
				randomrow = rand() % size;
				randomcolumn = rand() % size;

				if (arr[randomrow][randomcolumn] == ch)
				{
					if (str[check].length() <= size - 1 && str[check].length() >= half)
					{
						randomway = rand() % 4 + 1;
						switch (randomway)
						{
						case 1:
						{
							//up
							flag = false;
							for (int j = randomrow; j < str[check].length() + randomrow; j++)
							{
								if (arr[j][randomcolumn] != ch || str[check].length() + randomrow <= !size)
								{
									flag = true;
									break;
								}
							}
							while (flag == false)
							{
								for (int j = (str[check].length() + randomrow) - 1, n = 0; j >= randomrow; j--, n++)
								{
									arr[j][randomcolumn] = str[check][n];
								}
								flag = true;
								check++;
							}
							break;

						}
						case 2:
						{
							//down
							flag = false;
							for (int j = randomrow; j < str[check].length() + randomrow; j++)
							{
								if (arr[j][randomcolumn] != ch || str[check].length() + randomrow <= !size)
								{
									flag = true;
									break;
								}
							}
							while (flag == false)
							{
								for (int j = randomrow, n = 0; j < str[check].length() + randomrow; j++, n++)
								{
									arr[j][randomcolumn] = str[check][n];
								}
								flag = true;
								check++;
							}
							break;
						}
						case 3:
						{
							//left
							flag1 = false;
							for (int j = randomcolumn; j < str[check].length() + randomcolumn; j++)
							{
								if (arr[randomrow][j] != ch || str[check].length() + randomcolumn >= size)
								{
									flag1 = true;
								}
							}
							while (flag1 == false)
							{
								for (int j = (str[check].length() + randomcolumn) - 1, n = 0; j >= randomcolumn; j--, n++)
								{
									arr[randomrow][j] = str[check][n];
								}
								flag1 = true;
								check++;
							}
							break;
						}
						case 4:
						{
							//right
							flag1 = false;
							for (int j = randomcolumn; j < str[check].length() + randomcolumn; j++)
							{
								if (arr[randomrow][j] != ch || str[check].length() + randomcolumn >= size)
								{
									flag1 = true;
								}
							}
							while (flag1 == false)
							{
								for (int j = randomcolumn, n = 0; j < str[check].length() + randomcolumn; j++, n++)
								{
									arr[randomrow][j] = str[check][n];
								}
								flag1 = true;
								check++;
							}
							break;
						}
						}
					}
					else if (str[check].length() >= 2 && str[check].length() < half)
					{
						randomway = rand() % 4 + 1;
						switch (randomway)
						{
						case 1:
						{
							//up
							flag = false;
							for (int j = randomrow; j < str[check].length() + randomrow; j++)
							{
								if (arr[j][randomcolumn] != ch || str[check].length() + randomrow <= !size)
								{
									flag = true;
									break;
								}
							}
							while (flag == false)
							{
								for (int j = (str[check].length() + randomrow) - 1, n = 0; j >= randomrow; j--, n++)
								{
									arr[j][randomcolumn] = str[check][n];
								}
								flag = true;
								check++;
							}
							break;

						}
						case 2:
						{
							//down
							flag = false;
							for (int j = randomrow; j < str[check].length() + randomrow; j++)
							{
								if (arr[j][randomcolumn] != ch || str[check].length() + randomrow <= !size)
								{
									flag = true;
									break;
								}
							}
							while (flag == false)
							{
								for (int j = randomrow, n = 0; j < str[check].length() + randomrow; j++, n++)
								{
									arr[j][randomcolumn] = str[check][n];
								}
								flag = true;
								check++;
							}
							break;
						}
						case 3:
						{
							//left
							flag1 = false;
							for (int j = randomcolumn; j < str[check].length() + randomcolumn; j++)
							{
								if (arr[randomrow][j] != ch || str[check].length() + randomcolumn >= size)
								{
									flag1 = true;
								}
							}
							while (flag1 == false)
							{
								for (int j = (str[check].length() + randomcolumn) - 1, n = 0; j >= randomcolumn; j--, n++)
								{
									arr[randomrow][j] = str[check][n];
								}
								flag1 = true;
								check++;
							}
							break;
						}
						case 4:
						{
							//right
							flag1 = false;
							for (int j = randomcolumn; j < str[check].length() + randomcolumn; j++)
							{
								if (arr[randomrow][j] != ch || str[check].length() + randomcolumn >= size)
								{
									flag1 = true;
								}
							}
							while (flag1 == false)
							{
								for (int j = randomcolumn, n = 0; j < str[check].length() + randomcolumn; j++, n++)
								{
									arr[randomrow][j] = str[check][n];
								}
								flag1 = true;
								check++;
							}
							break;
						}
						case 5:
						{
							//up right diagonal

						}
						case 6:
						{
							//up left diagonal

						}
						case 7:
						{
							//down right diagonal

						}
						case 8:
						{
							//down left diagonal

						}
						}
					}
				}
			}

			for (int x = 0; x < 10; x++)
			{
				for (int y = 0; y < 10; y++)
				{
					if (arr[x][y] == '*')
					{
						int woo = (rand() % 25) + 1;
						int yoo = 122;
						yoo = yoo - woo;
						int change = static_cast<char>(yoo);
						switch (change)
						{
							case 65:
							{
								window.draw(A);
							}
							case 66:
							{
								window.draw(B);
							}
						}
					}
				}
			}


			
			
			////Rendering
			window.clear();
			//Output Array
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					cout << arr[i][j] << " ";
				}
				cout << endl;
			}

			window.display();
		}
	}

	//Clean up and close the window
	window.close();
	exit(0);
}

void Bonus_Game()
{
	//Creating the window
	sf::RenderWindow window(sf::VideoMode(800, 600), "Bonus Game");

	//Settign the framerate limit to 60 FPS
	window.setFramerateLimit(60);

	window.setKeyRepeatEnabled(false);

	//Variable that keeps the game loop running
	bool play = true;

	//Event object holding all events
	sf::Event event;

	//Font
	sf::Font font;	//Font object
	if (font.loadFromFile("Fonts/Serpentine.ttf") == 0) //Safe way to load font
	{
		return;
	}

	//Images
	sf::Texture tex_pad; //Pad image/texutre
	sf::Texture tex_ball; //Ball texture
	sf::Texture tex_background; //Background texture

								//Load the 3 textures
	if (tex_pad.loadFromFile("Data/pad.png") == false)
	{
		return;
	}

	if (tex_ball.loadFromFile("Data/ball.png") == false)
	{
		return;
	}

	if (tex_background.loadFromFile("Data/background.png") == false)
	{
		return;
	}

	//Sounds
	sf::SoundBuffer buff_hit; //Hit sound

							  //Load the sound
	if (buff_hit.loadFromFile("Data/hit.wav") == false)
	{
		return;
	}
	sf::Sound hit;
	hit.setBuffer(buff_hit);
	//States
	bool up = false;
	bool down = false;

	//Variables
	int yVelocityPad1 = 0; //Y velocity of pad1
	int xVelocityBall = -3; //X velocity of the ball
	int yVelocityBall = -3; //Y velocity of the ball
	int yVelocityPad2 = 0;
	int Pad1Score = 0;
	int Pad2Score = 0;
	int i = 3, j = -3;

	//////////Shapes
	//Background
	sf::RectangleShape background;
	background.setSize(sf::Vector2f(800, 600));
	background.setPosition(0, 0);
	background.setTexture(&tex_background);

	//Pad1
	sf::RectangleShape pad1;
	pad1.setSize(sf::Vector2f(50, 100));
	pad1.setPosition(50, 200);
	pad1.setTexture(&tex_pad);

	//Pad2
	sf::RectangleShape pad2;
	pad2.setSize(sf::Vector2f(50, 100));
	pad2.setPosition(700, 200);
	pad2.setTexture(&tex_pad);

	//Ball
	sf::RectangleShape ball;
	ball.setSize(sf::Vector2f(5, 5));
	ball.setPosition(400, 200);
	ball.setTexture(&tex_ball);

	//Score
	sf::Text Score;
	Score.setFont(font);
	Score.setPosition(400, 10);
	Score.setString("0 : 0");
	Score.setCharacterSize(30);
	Score.setFillColor(sf::Color::Red);

	//Game loop
	while (play == true)
	{
		//EVENTS
		while (window.pollEvent(event))
		{
			//Event type is window closed
			if (event.type == sf::Event::Closed)
			{
				//Set play to false in order to stop the game loop
				play = false;
			}

			//Key pressed
			if (event.type == sf::Event::KeyPressed && event.key.code == sf::Keyboard::Up)
			{
				up = true;
			}

			if (event.type == sf::Event::KeyPressed && event.key.code == sf::Keyboard::Down)
			{
				down = true;
			}

			//Key released
			if (event.type == sf::Event::KeyReleased && event.key.code == sf::Keyboard::Up)
			{
				up = false;
			}

			if (event.type == sf::Event::KeyReleased && event.key.code == sf::Keyboard::Down)
			{
				down = false;
			}
		}

		////////////LOGIC
		////Pad1
		//Check states
		if (up == true)
		{
			yVelocityPad1 = -5;
		}

		if (down == true)
		{
			yVelocityPad1 = 5;
		}

		if (up == true && down == true)
		{
			yVelocityPad1 = 0;
		}

		if (up == false && down == false)
		{
			yVelocityPad1 = 0;
		}

		//Move pad1
		pad1.move(0, yVelocityPad1);
		if (pad1.getPosition().y < 0)
		{
			pad1.move(0, -yVelocityPad1);
		}
		if (pad1.getPosition().y > 500)
		{
			pad1.move(0, -yVelocityPad1);
		}
		//Move Ball
		ball.move(xVelocityBall, yVelocityBall);
		if (ball.getPosition().y < 0)
		{
			yVelocityBall = -yVelocityBall;
		}
		if (ball.getPosition().y > 595)
		{
			yVelocityBall = -yVelocityBall;
		}
		if (ball.getPosition().x < 0)
		{
			Pad2Score++;
			ball.setPosition(400, 300);
		}
		if (ball.getPosition().x > 795)
		{
			Pad1Score++;
			ball.setPosition(400, 300);
		}
		if (ball.getGlobalBounds().intersects(pad1.getGlobalBounds()) == true)
		{
			xVelocityBall = -xVelocityBall;
			yVelocityBall = -yVelocityBall;
			hit.play();
		}
		//Pad2
		if (ball.getPosition().y < pad2.getPosition().y)
		{
			yVelocityPad2 = -3;
		}
		if (ball.getPosition().y > pad2.getPosition().y)
		{
			yVelocityPad2 = 3;
		}
		if (ball.getGlobalBounds().intersects(pad2.getGlobalBounds()) == true)
		{
			xVelocityBall = -xVelocityBall;
			yVelocityBall = -yVelocityBall;
			hit.play();

		}

		pad2.move(0, yVelocityPad2);

		//RENDERING
		window.clear();

		//Drawing the shapes
		window.draw(background);
		window.draw(pad1);
		window.draw(pad2);
		window.draw(ball);
		//Score
		std::stringstream text;
		text << Pad1Score << " : " << Pad2Score;
		Score.setString(text.str());
		window.draw(Score);
		window.display();
	}
	///////////

	//Clean up and close the window
	window.close();

	system("pause>0");
	}

void Credit()
{
	cout << "Made by Eqan Ahmad, Hamza Iqbal, and Ahmad Asif"<<endl;
}

void Instruction()
{
cout << "1. Move the words diagonally, Horizontally or vertically to match the answers" << endl;
cout << "2. You have limited amount of time so select the difficulty as per your choice" << endl;
cout << "Enter any key to return to main menu" << endl;
std::system("pause>0");
}

void Leader()
{
    cout << "Player Position  Score" << endl;
	cout << "Hamza    1st       7" << endl;
	cout << "Eqan     2nd       4" << endl;
	cout << "Ahmad    3rd       2" << endl;
}
void exit()
{
	system("pause>0");
}


void main()
{
	
	//Creating the window
	RenderWindow window(sf::VideoMode(800, 600), "Word Search:Alpha",sf::Style::Resize | sf::Style::Close);
	window.setVerticalSyncEnabled(true);

	//Settign the framerate limit to 60 FPS
	window.setFramerateLimit(60);

	window.setKeyRepeatEnabled(false);

	//Variable that keeps the game loop running
	bool play = true;

	//Event object holding all events
	Event event;

	//Font
	Font font;	//Font object
	if (font.loadFromFile("Fonts/Serpentine.ttf") == 0) //Safe way to load font
	{
	cout << "Font not found";
		return ;
	}
	//Mouse
	event.mouseButton.x;
	event.mouseButton.y;

	//Title
	sf::Text Title;
	Title.setFont(font);
	Title.setPosition(260, 150);
	Title.setCharacterSize(30);
	Title.setString("Word Search:Alpha");
	Title.setFillColor(sf::Color::White);
	//Start
	sf::Text Start;
	Start.setFont(font);
	Start.setPosition(395, 220);
	Start.setCharacterSize(20);
	Start.setString("Start");
	Start.setFillColor(sf::Color::White);
	//Instructions
	sf::Text Instructions;
	Instructions.setFont(font);
	Instructions.setPosition(350, 270);
	Instructions.setCharacterSize(20);
	Instructions.setString("Instructions");
	Instructions.setFillColor(sf::Color::White);
	//Credits
	sf::Text Credits;
	Credits.setFont(font);
	Credits.setPosition(390, 320);
	Credits.setCharacterSize(20);
	Credits.setString("Credits");
	Credits.setFillColor(sf::Color::White);
	//LeaderBoard
	sf::Text LeaderBoard;
	LeaderBoard.setFont(font);
	LeaderBoard.setPosition(350, 370);
	LeaderBoard.setCharacterSize(20);
	LeaderBoard.setString("LeaderBoard");
	LeaderBoard.setFillColor(sf::Color::White);
	//Bonus Game
	sf::Text BonusGame;
	BonusGame.setFont(font);
	BonusGame.setPosition(350, 420);
	BonusGame.setCharacterSize(20);
	BonusGame.setString("Bonus Game");
	BonusGame.setFillColor(sf::Color::White);
	//Exit
	sf::Text Exit;
	Exit.setFont(font);
	Exit.setPosition(405, 470);
	Exit.setCharacterSize(20);
	Exit.setString("Exit");
	Exit.setFillColor(sf::Color::White);
	//Images
	
		//////////Shapes
	//Background
	Texture MenuBackground;
	if (MenuBackground.loadFromFile("Images/Matrix2.png") == 0)
	{
		cout << "Texture not found";
		return ;
	}

	IntRect rectSprite(800, 0, 800, 600);
	Sprite Matrix(MenuBackground,rectSprite);
	Clock MatrixClock;
	//Music
	sf::Music Intro;
	if (Intro.openFromFile("Sounds/Intro.ogg") == 0) 
	{
	cout << "Sound not found";
		return;
	}
	Music Menu;
	if (Menu.openFromFile("Sounds/Menu.ogg") == 0)
	{
		cout << "Music Not found";
		return;
	}
	sf::SoundBuffer OptionSelect; //Hit sound

							  //Load the sound
	if (OptionSelect.loadFromFile("Sounds/Option Select.wav") == false)
	{
		return;
	}
	sf::Sound Select;
	Select.setBuffer(OptionSelect);
	Clock IntroTime;
	
	
	Intro.play();
	sf::Vector2i localPosition;
	//Game loop
	while (play == true)
	{

		////EVENTS
		while (window.pollEvent(event))
		{
			if (event.type == sf::Event::Closed)
			{
				play = false;
				exit(0);
			}
			if (MatrixClock.getElapsedTime().asSeconds() > 0.1f)
			{
				if (rectSprite.left == 1600)
				{
					rectSprite.left = 0;
				}
				else
				{
					rectSprite.left += 800;
				}
				Matrix.setTextureRect(rectSprite);
				MatrixClock.restart();
			}

			if (IntroTime.getElapsedTime().asSeconds() > 82.0f)
			{
				Intro.stop();
				Menu.setLoop(true);
				Menu.play();
				IntroTime.restart();
			}

			
			switch (event.type)
			{	
			case sf::Event::MouseButtonPressed:
			{
				switch (event.key.code)
				{
				case sf::Mouse::Left:
					localPosition = sf::Mouse::getPosition(window);
					if (localPosition.x > 392 && localPosition.x < 466 && localPosition.y > 222 && localPosition.y<244)
					{	//Start
					    Select.play();
						GamePlay();

						break;
					}
					if (localPosition.x > 349 && localPosition.x < 506 && localPosition.y > 273 && localPosition.y<297)
					{
						//Instructions
						Select.play();
						Instruction();
						break;
					}
					if (localPosition.x > 392 && localPosition.x < 484 && localPosition.y > 324 && localPosition.y<347)
					{
						//credits
						Select.play();
						Credit();
						break;
					}
					if (localPosition.x > 350 && localPosition.x < 507 && localPosition.y > 373 && localPosition.y<393)
					{
						//LeaderBoard
						Select.play();
						Leader();
						break;
					}
					if (localPosition.x > 343 && localPosition.x < 501 && localPosition.y > 437 && localPosition.y<434)
					{
						//BonusGame
						Select.play();
						Bonus_Game();
						break;
					}
					if (localPosition.x > 401 && localPosition.x < 456 && localPosition.y > 483 && localPosition.y<484)
					{
						//exit
						Select.play();
						break;
					}
				}
				break;
			}
			case sf::Event::MouseMoved:	
				/*cout << sf::Mouse::getPosition(window).x << " " << sf::Mouse::getPosition(window).y << endl;*/
				sf::Mouse::getPosition(window).x; 
				sf::Mouse::getPosition(window).y;
				break;
				}
			//LeaderBoard.setColor(sf::Color::White);
			
		////LOGIC

		////Rendering
		window.clear();
		//Menu
		window.draw(Matrix);
		window.draw(Title);
		window.draw(Start);
		window.draw(Instructions);
		window.draw(Credits);
		window.draw(LeaderBoard);
		window.draw(BonusGame);
		window.draw(Exit);
		window.display();
	}
	}
	
	//Clean up and close the window
	window.close();
	std::system("pause>0");
}
