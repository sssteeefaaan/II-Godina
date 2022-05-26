#include "HashTable.h"
#include "Element.h"
#include <exception>
using std::exception;
#include <iostream>
#include <string>
using namespace std;

HashTable::HashTable()
{
	setNULL();
}
HashTable::HashTable(unsigned int size)
{
	setTable(size);
}
HashTable::HashTable(const HashTable& original)
{
	setTable(original.size,original.filled);
	for (unsigned int i = 0; i < original.size; i++)
		this->table[i] = original.table[i];
}
HashTable::~HashTable()
{
	del();
}
void HashTable::del()
{
	delete[] table;
	setNULL();
}
void HashTable::setNULL()
{
	this->size = this->filled=0;
	this->table = NULL;
}
bool HashTable::correctHours(string time)
{
	bool ret = true;
	int timeInt = Element::convert(time);
	if (timeInt<1000 || timeInt>1750)
		ret = false;
	return ret;
}
void HashTable::insert(string date,string time,string jmbg)
{
	if (this->size == this->filled)
		throw new exception("Table is full!");
	else {
		if (!correctHours(time))
			throw new exception("Pogresno unet termin!");
		else {
			unsigned int indeks = hash(date, time), * col = new unsigned int(1);
			while (!(table[indeks].isNULL() || (table[indeks].getDate().compare(date) == 0 && table[indeks].getTime().compare(time) == 0)))
				indeks = collision(indeks, col);
			delete col;
			if (table[indeks].isNULL())
			{
				this->table[indeks] = Element(date, time, jmbg);
				this->filled++;
			}
			else
				throw new exception("Termin je zauzet!");
		}
	}
}
void HashTable::infoFor(string date,string time)
{
	if (!correctHours(time))
		throw new exception("Pogresno unet termin!");
	if (this->filled == 0)
		throw new exception("Nema nijedan zakazan termin!");
	unsigned int indeks = hash(date, time), * col = new unsigned int(1);
	bool found = false;
	while (!(table[indeks].isNULL() || found))
	{
		if (table[indeks].getDate().compare(date) == 0 && table[indeks].getTime().compare(time) == 0)
			found = true;
		else
			indeks = collision(indeks, col);
	}
	delete col;
	if (found)
		infoAt(indeks);
	else
		cout << date<<" u "<<time<<" termin je slobodan!" << endl;
}
void HashTable::infoAt(unsigned int indeks)
{
	cout << "Trazeni termin:" << endl;
	table[indeks].info();
	cout << "--------------------" << endl;
}
void HashTable::print()
{
	cout << "Popunjeno je " << filled << " od mogucih " << size << " termina."<<endl;
	cout << "--------------------" << endl;
	cout << "--------------------" << endl;
	for (unsigned int i = 0; i < this->size; i++)
	{
		cout << (i + 1) << ". Termin:"<<endl;
		if (!table[i].isNULL())
			table[i].info();
		else
			cout << "PRAZNO" << endl;
		cout << "--------------------" << endl;
	}
}
unsigned int HashTable::hash(string date, string time)	//Istrazivao sam hash funkcije i mislim da je ova medju boljima [http://create.stephan-brumme.com/fnv-hash/]
{
	unsigned int ret = Seed;
	string hash = date + time;
	int i = 0;
	while(hash[i]!=0)
		ret = (hash[i++] ^ ret) * Prime;
	return ret%this->size;
}
unsigned int HashTable::collision(unsigned int indeks,unsigned int *it)	//Kvadratno trazenje
{
	return (indeks + (*it)*((*it)++))%this->size;
}