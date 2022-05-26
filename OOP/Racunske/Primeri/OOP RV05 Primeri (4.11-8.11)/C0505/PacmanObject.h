#pragma once
#include <iostream>
using namespace std;

class PacmanObject
{
protected:
	int x;
	int y;
	char vrednost;
public:
	PacmanObject(void);
	PacmanObject(int koordX, int koordY, char simbol)
	{
		x = koordX;
		y = koordY;
		vrednost = simbol;
	}

	virtual ~PacmanObject(void);
	void Prikazi()
	{
		cout << vrednost << " ";
	}

	virtual void Postavi(char v)
	{
		this->vrednost = v;
	}

	char VratiZamenu()
	{
		if (vrednost == ' '
			|| vrednost == 'C'
			|| vrednost == '.'
			|| vrednost == '*')
		{
			return ' ';
		}

		if (vrednost == 'D')
			return '*';

		return '0';		
	};

	int GetX()
	{
		return x;
	}

	int GetY()
	{
		return y;
	}
};

