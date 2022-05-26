#pragma once
#include "PacmanObject.h"
#include <fstream>
using namespace std;

class Lavirint
{
	PacmanObject*** elementi;
	int vrste;
	int kolone;
	int mojPacmanX;
	int mojPacmanY;
	void init();
	void clear();
public:
	Lavirint(void);

	virtual ~Lavirint(void);

	void Ucitaj(char* imeFajla)
	{
		ifstream uldat(imeFajla);
		if (!uldat.good())
			return;

		this->clear();
		uldat >> this->kolone;
		this->vrste = this->kolone;
		this->init();

		for (int i = 0; i < vrste; i++)
		{
			for (int j = 0; j < kolone; j++)
			{
				char simbol;
				uldat >> simbol;
				PacmanObject* p = new PacmanObject(i, j, simbol);
				if (simbol == 'C')
				{
					mojPacmanX = i;
					mojPacmanY = j; 					
				}
				
				elementi[i][j] = p;
			}
		}
		uldat.close();
	}

	void Stampaj()
	{
		cout << endl;
		for (int i = 0; i < vrste; i++)
		{
			for (int j = 0; j < kolone; j++)
			{ 
				elementi[i][j]->Prikazi();
			}
			cout << endl;
		}
		cout << endl;
	}

	void MovePacman(char command)
	{
		
		int nextx = mojPacmanX;
		int nexty = mojPacmanY;

		if (command == 'w')
			nextx--;
		else if (command == 'a')
			nexty--;
		else if (command == 's')
			nextx++;
		else if (command == 'd')
			nexty++;
		else 
			return;

		if (nextx < 0 || nextx >= kolone)
			return;
		if (nexty < 0 || nexty >= vrste)
			return;

		// check destination
		char destinationReplacemt = this->elementi[nextx][nexty]->VratiZamenu();

		if (destinationReplacemt == '0')
			return;
				
		this->elementi[mojPacmanX][mojPacmanY]->Postavi(destinationReplacemt);
		mojPacmanX = nextx;
		mojPacmanY = nexty;
		this->elementi[mojPacmanX][mojPacmanY]->Postavi('C');

	}
};

