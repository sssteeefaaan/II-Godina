#include "HashTable.h"
#include "Element.h"
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
	setTable(original.size);
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
	this->size = 0;
	this->table = NULL;
}
void HashTable::insert(string date,string time,string jmbg)
{
	unsigned int indeks = hash(date, time);
	while (!table[indeks].isNULL())
		indeks=collision(indeks);
	this->table[indeks] = Element(date, time, jmbg);
}
void HashTable::infoFor(string date,string time)
{
	unsigned int indeks = hash(date, time);
	while (!(table[indeks].getDate().compare(date) == 0 && table[indeks].getTime().compare(time) == 0))
		indeks = collision(indeks);
	infoAt(indeks);
}
void HashTable::infoAt(unsigned int indeks)
{
	cout << "Trazeni termin:" << endl;
	table[indeks].info();
	cout << "--------------------" << endl;
}
void HashTable::print()
{
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
	return ret%size;
}
unsigned int HashTable::collision(unsigned int indeks)	//Linearno, da ga ne komplikujem
{
	return (indeks + 1) % this->size;
}