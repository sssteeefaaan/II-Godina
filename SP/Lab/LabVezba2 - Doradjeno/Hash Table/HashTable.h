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
	unsigned int filled;
	static const unsigned int Prime = 0x01000193;
	static const unsigned int Seed = 0x811C9DC5;
public:
	HashTable();
	HashTable(unsigned int);
	HashTable(const HashTable&);
	~HashTable();
	void print();
	void insert(string, string, string);
	void infoFor(string, string);
	inline unsigned int getSize() { return this->size; }
private:
	void del();
	void setNULL();
	bool correctHours(const string);
	inline void setTable(unsigned int size,unsigned int filled=0) { this->table = new Element[this->size = size]; this->filled = filled; }
	void infoAt(unsigned int);
	unsigned int hash(string,string);
	unsigned int collision(unsigned int,unsigned int*);
};

