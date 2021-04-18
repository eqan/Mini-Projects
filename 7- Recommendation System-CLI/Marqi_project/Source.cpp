#include<iostream>
#include<fstream>
#include<string>
#include<queue>
using namespace std;
ifstream fin;
#define V 6


class project
{
public:
	struct node
	{

		string marqi_name; int marqi_address; int marqi_capacity;   int price_range1;  int price_range2;
		node *next;
	};
	node *head; node *last;
	string final_string[6];
	string *name; int size=6; int adrs, capacity;    /*string *final*/; int menu_select[10]; int bill = 0;
	string select;
	//  read.txt    after rading store data in array after use these array for searching a particular marqi 
	// and for displating complete detail of marqi

	string promo_codes[4] = { "super2020","newdeal","midnight","new2021" };
	int count = 0;
	// use for reading from file
	string mq_nam; int mq_adrs; int mq_cap;   int index = 0;  int rng1, rng2;


	int graph[V][V] =
			{ {  4,  0, 0, 0, 8, 0 },{ 4, 0, 8,  0,  11, 0 },{
			 8,  7, 0, 4,0, 2 },
				{  7, 0, 9, 14, 0, 0},{  0, 9, 0, 10,  0,
				0 },{ 0, 4, 0, 10, 0, 2 } };
	//   constructor
	project()
	{

	


		name = new string[size];
	
		//final = new string[size];
		for (int i = 0; i < size; i++)
		{
			name[i] = "0";
		}


		fin.open("detail.txt");
		if (fin.is_open())
		{

			while (!fin.eof())
			{
				fin >> mq_nam >> mq_adrs >> mq_cap>>rng1>>rng2;
				//cout << mq_nam << " " << mq_adrs << " " << mq_cap << endl;
				buildnode(mq_nam, mq_adrs, mq_cap, rng1, rng2);
				hashing(mq_nam);
			}
			fin.close();
		}
		else
			cout << "Not open" << endl;
	}
	

	//  end constructor

	void buildnode(string a , int b , int c , int d , int e)
	{
		node *newnode;
			newnode = new node;
			
			newnode->marqi_name = a;
			newnode->marqi_address = b;
			newnode->marqi_capacity = c;
			newnode->price_range1 = d;
			newnode->price_range2 = e;
			newnode->next = NULL;
			if (head == NULL)
			{
				head = newnode;
				last = newnode;
			}
			else
			{
				last->next = newnode;
				last = newnode;
			
		}
	}



	//  linear hashing is use in all program
	void hashing(string key)
	{

		for (int i = 0; i < size; i++)
		{
			int sum = 0;
			for (int l = 0; l < 2; l++)
			{
				sum = (key[0] - 97);
			}
			int hv = sum % size;
			if (name[hv] == "0")
			{
				name[hv] = key;
				break;
			}

			else
			{
				int count12 = 0;
				for (int j = 0; j < size; j++)
				{
					int t = (hv + count12) % size;
					if (name[t] == "0")
					{
						name[t] = key;
						break;
					}
					count12++;
				}
				break;
			}

		}



	}
	void searching(string key)
	{


		for (int i = 0; i < size; i++)
		{

			int sum = 0;
			for (int k = 0; k < 2; k++)
			{
				sum = (key[0] - 97);
			}
			int hv = sum % size;
			// first i check if first index of string name match
			// with first index of key
			if (name[hv][0] == key[0])
			{
				for (int m = 0; m<key.length(); m++)
				{

					if (name[hv][m] == key[m])
					{
						count++;
					}


				}
				if (count == key.length())
				{
					cout << "Marqi is presnt " << endl;

					name[hv] = "0";
					count = 0;
				}
				count = 0;
				// after key find make that  name index to zero
				name[hv] = "0";

			}

			else
			{
				int count1 = 0;
				count = 0;
				for (int j = 0; j < size; j++)
				{
					int t = (hv + count1) % size;
					// if first index match with first index of key
					if (name[t][0] == key[0])
					{
						for (int m = 0; m < key.length(); m++)
						{
							// if name index match with key index
							if (name[t][m] == key[m])
							{
								count++;
							}
						}
						// if key match with file 
						//  write that key into file
						if (count == key.length())
						{
							cout << "Marqi is presnt "<< endl;

							name[t] = "0";

						}
						count = 0;
						// after key find make that  name index to zero
						name[t] = "0";
					}
					count1++;
				}

			}

		}

		//return false;
	}
	void promo_codes_fun()
	{
		string promo;   int choicee;
		cout << "Do you want to get discount promo codes : " << endl;
		cout << "----------> enter 1 for avail   <----------" << endl;
		cout << "----------> enter -1 for exit   <----------" << endl;
		cin >> choicee;
		if (choicee == 1)
		{
			cout << "    ------------>      Enter promo codes      <--------------- " << endl;
			cin >> promo;
			if (promo == promo_codes[0])
			{
				bill = bill - 100;
			}
			else if (promo == promo_codes[1])
			{
				bill = bill - 120;
			}
			else if (promo == promo_codes[2])
			{
				bill = bill - 150;
			}
			else if (promo == promo_codes[0])
			{
				bill = bill - 200;
			}
		}
		final_string[1] = bill;

	}

	void menu_selection()
	{
		int choic;
		int i = 1;
		cout << endl;
		cout << " --------------->  Kindly select your menu  <-------------------- " << endl;  cout << endl;

		cout << " --------------->  Menu <-------------------- " << endl;  cout << endl;
		cout << "      ITEM NAME    " << "         " << "       Price    " << endl;
		fin.open("menu.txt");
		if (fin.is_open())
		{
			while (!fin.eof())
			{
				fin >> mq_nam >> mq_adrs;
				menu_select[i] = mq_adrs;
				cout << "  (" << i << " )   " << mq_nam << "                    " << "  " << mq_adrs << "       " << endl;
				i++;

			}
			fin.close();
		}
		bill = 0;
		cout << "Bill is : " << bill << endl;
		cout << "  -------> Select your menu  <------------- " << endl;
		cout << "   -------->  enter -1 for exit from menu <--------  " << endl; cout << endl;

		cout << " Enter your choice " << endl;
		do
		{
			cin >> choic;
			int l = choic;
			bill = bill + menu_select[l];
			cout << "Bill is : " << bill << endl;

		} while (choic != -1);
		final_string[1] = bill;
	}
	void detail_of_marqi()
	{
		node *temp = head;
		cout << "Name of marqi " << "     " << "  address" << "      Capacity " << "                range "<<endl;
		while (temp != NULL)
		{
			cout << "  " << temp->marqi_name << "            street " << temp->marqi_address << "       " << temp->marqi_capacity << "                         " << temp->price_range1 << "-" << temp->price_range2 << endl;
			temp = temp->next;
		}
		cout << "which marqi do you want to select : "<<endl;
		cout << " Enter marqi name : ";
		cin >> select;
		menu_selection();
		cout << "Bill is : " << bill << endl;
	}

	void price_range()
	{
		node *temp = head;
		int range;
		cout << "Enter your price range : ";
		cin >> range;
		cout << "Name of marqi " << "     " << "  address" << "      Capacity "  << "       Range    "<< endl;
		while (temp != NULL)
		{
			if (range >= temp->price_range1 && range <= temp->price_range2)
			{
				cout << "  " << temp->marqi_name << "            street " << temp->marqi_address << "       " << temp->marqi_capacity << "          " << temp->price_range1 << "-" << temp->price_range2 << endl;
			}
			temp = temp->next;
		}
	}


	void per_head()
	{
		int guest;
		cout << "ENTER your total guest : ";
		cin >> guest;
		cout << " Your total bill is : " << guest*bill<<endl;
		cout << "  Per Head bill Calculation : " << bill << endl;
	}





	int minDistance(int dist[], bool sptSet[])
	{
		int min = INT_MAX, min_index;

		for (int v = 0; v < V; v++)
			if (sptSet[v] == false && dist[v] <= min)
				min = dist[v], min_index = v;

		return min_index;
	}

	void printSolution(int dist[], int n)
	{
		cout << "   Marqi               Distance from Source\n";
		for (int i = 0; i < V; i++)
			cout << "---->  "<<i << "        --------->        " << dist[i] << endl;
	}


	void dijkstra(int graph[V][V], int src)
	{
		int dist[V];

		bool sptSet[V];
		for (int i = 0; i < V; i++)
			dist[i] = INT_MAX, sptSet[i] = false;

		dist[src] = 0;

		for (int count = 0; count < V - 1; count++)
		{
			int u = minDistance(dist, sptSet);

			sptSet[u] = true;

			for (int v = 0; v < V; v++)


				if (!sptSet[v] && graph[u][v] && dist[u] != INT_MAX && dist[u]
					+ graph[u][v] < dist[v])
					dist[v] = dist[u] + graph[u][v];
		}

		printSolution(dist, V);
	}

	

	

};
int main()
{
	string choice;
	project obj;
	cout << "enter 1 for searching a marquee : " << endl;
	cout << "enter 2 for detail of all marquee : " << endl;
	cout << "Enter 3 for applying promo codes : " << endl;
	cout << "enter 4 for checking bill : " << endl;
	cout << "enter 5 for price range filter : " << endl;
	cout << "enter 6 for per head bill calculation : " << endl;
	cout << "enter 7 for location base search : " << endl;
	do {
		cin >> choice;
		if (choice == "1")
		{
			string partic;
			cout << "ENTER name of a particular marquee : ";
			cin >> partic;
			obj.searching(partic);

		}
		else if (choice == "2")
		{
			obj.detail_of_marqi();
		}
		else if (choice == "3")
		{

			cout << "  ------------>   BILL  IS  <------------" << endl;
			cout << obj.bill << endl;


			obj.promo_codes_fun();

			cout << "  ------------>  AFTER Aplying PROMO CODE BILL  IS  <------------" << endl;
			cout << obj.bill << endl;
		}
		else if (choice == "4")
		{
			cout << "  ------------>   BILL  IS  <------------" << endl;
			cout << obj.bill << endl;
		}
		else if (choice == "5")
		{
			obj.price_range();
		}
		else if (choice == "6")
		{
			obj.per_head();
		}
		else if (choice == "7")
		{
			int z;
			cout << "enter source Marqi : ";
			cin >> z;
			obj.dijkstra(obj.graph, z);
		}


		else
			cout << "  ------------>   you enter wrong choice   <---------" << endl;
	} while (choice != "-1");
	cout << endl;
	cout << "   ---------->   your   data is   <------------ " << endl;
	cout << "   ---------->   Marqi you selecct  : " <<obj.select<< endl;
	cout << " ---------- > your bill is : " << obj.bill << endl;
	system("pause");

}






