#pragma once
#include <string>
#include <iostream>
using namespace std;
#include "Element.h"
class HashTable
{
//private:
	Element *table;
	unsigned int size;
	static const unsigned int Prime = 0x01000193;
	static const unsigned int Seed = 0x811C9DC5;
public:
	HashTable();
	HashTable(unsigned int);
	HashTable(const HashTable&);
	~HashTable();
	void del();
	void setNULL();
	inline void setTable(unsigned int size) { this->table = new Element[this->size = size]; }
	inline unsigned int getSize() { return this->size; }
	void insert(string,string,string);
	void infoFor(string, string);
	void infoAt(unsigned int);
	void print();
	unsigned int hash(string,string);
	unsigned int collision(unsigned int);
};

