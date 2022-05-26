#include "Polje.h"
#include "NeotkrivenoPolje.h"

Polje::Polje(void)
{
	velicina = 0;
	matrica = 0;
}

Polje::~Polje(void)
{
	if (matrica == 0)
		return;

	this->ObrisiMatricu();
}

void Polje::ObrisiMatricu()
{
	if (matrica == 0)
		return;

	for (int i = 0; i < velicina; i++)
	{
		for (int j = 0; j < velicina; j++)
		{
			delete matrica[i][j];
		}
	}

	for (int i = 0; i < this->velicina; i++)
		delete[] matrica[i];

	delete[] matrica;
}

void Polje::UcitajIzFajla(char* imeFajla)
{
	ifstream mojfajlsima( imeFajla );
	
	if (!mojfajlsima.good())
		return;
	

	//cout << uldat.tellg() << endl;

	mojfajlsima >> this->velicina;

	//cout << uldat.tellg() << endl;;

	matrica = new OsnovniObjekat**[this->velicina];
	for (int i = 0; i < velicina; i++)
	{
		matrica[i] = new OsnovniObjekat*[this->velicina];
	}

	for (int i = 0; i < velicina; i++)
		for (int j = 0; j < velicina; j++)
		{
			int pom = 0;
			if (!mojfajlsima.eof())
				mojfajlsima >> pom;
			matrica[i][j] = new NeotkrivenoPolje(pom);

			//cout << uldat.tellg() << endl;
		}

	for (int i = 0; i < velicina; i++)
		for (int j = 0; j < velicina; j++)
		{
			int okolneMine = 0;
			okolneMine += DaLiJeMina(i-1, j-1) + DaLiJeMina(i-1, j) + DaLiJeMina(i-1, j+1);
			okolneMine += DaLiJeMina(i, j-1) + DaLiJeMina(i, j+1);
			okolneMine += DaLiJeMina(i+1, j-1) + DaLiJeMina(i+1, j) + DaLiJeMina(i+1, j+1);
			
			matrica[i][j]->PostaviBrojOkolnihMina(okolneMine);
		}
	mojfajlsima.close();
}

int Polje:: DaLiJeMina(int x, int y)
{
	return (x >= 0 && y >= 0 && x < velicina && y < velicina) 
		? matrica[x][y]->DaLiJeMina() : 0;
}

void Polje::StampajOtkrivenoPolje()
{
	if (matrica == 0)
		return;

	for (int i = 0; i < velicina; i++)
	{
		for (int j = 0; j < velicina; j++)
		{
			int okolneMine = matrica[i][j]->VratiBrojOkolnihMina();
			if (matrica[i][j]->DaLiJeMina())
				cout << "X";
			else if ( okolneMine == 0)
				cout << " ";
			else cout << okolneMine;
		}
		cout << endl;
	}
}


void Polje::Stampaj()
{
	if (matrica == 0)
		return;

	for (int i = 0; i < velicina; i++)
	{
		for (int j = 0; j < velicina; j++)
		{
			matrica[i][j]->Print();
		}
		cout << endl;
	}
}

int Polje::IzvrsiOperaciju(int x, int y, int op, int minecheck)
{	
	if ( x < 0 || x > this->velicina -1 
		|| y < 0 || y > this->velicina -1)
	{		
		return 1;
	}

	if (minecheck 
		&& (matrica[x][y]->DaLiJeMina())
		)
		return 1;
		
	OsnovniObjekat* replacement = this->matrica[x][y]->IzvrsiOperaciju(op);
	if (replacement == 0)
		return 1;

	delete this->matrica[x][y];
	this->matrica[x][y] = replacement;
	//cout << typeid(*replacement) << endl;
	
	if (typeid(*replacement) == typeid(Eksplozija)
		|| BrojNeotkrivenihPolja() == 0)
		return 2; //kraj igre
	
	if(op == 1)
		ProslediOperaciju(x, y);
	return 0;
	
}

void Polje ::ProslediOperaciju(int x, int y)
{
	int op = 1;
	if (matrica[x][y]->VratiBrojOkolnihMina() == 0)
	{
		IzvrsiOperaciju(x-1, y, op, 1);
		IzvrsiOperaciju(x-1, y-1, op, 1);
		IzvrsiOperaciju(x-1, y+1, op, 1);
		IzvrsiOperaciju(x+1, y, op, 1);
		IzvrsiOperaciju(x+1, y-1, op, 1);
		IzvrsiOperaciju(x+1, y+1, op, 1);
		IzvrsiOperaciju(x, y-1, op, 1);
		IzvrsiOperaciju(x, y+1, op, 1);
	}
}

int Polje::BrojNeotkrivenihPolja()
{
	int s = 0;
	for (int i = 0; i < velicina; i++)
	{
		for (int j = 0; j < velicina; j++)
		{
			if (typeid(*matrica[i][j]) == typeid(NeotkrivenoPolje)) 
				s++;
		}
	}
	return s;
}