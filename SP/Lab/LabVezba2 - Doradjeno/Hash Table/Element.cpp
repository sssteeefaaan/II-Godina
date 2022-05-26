#include "Element.h"
#include <iostream>
#include <string>
using namespace std;

Element::Element()
{
	setNULL();
}
Element::Element(string date, string time, string jmbg)
{
	setDate(date);
	setTime(time);
	setJMBG(jmbg);
}
Element::~Element()
{
	del();
}
Element::Element(const Element& original)
{
	setDate(*original.date);
	setTime(*original.time);
	setJMBG(*original.jmbg);
}
void Element::del()
{
	delete date, time, jmbg;
	setNULL();
}
void Element::setNULL()
{
	this->date = this->time = this->jmbg = NULL;
}
bool Element::isNULL()
{
	bool ret = false;
	if (date == NULL)	//s obzirom da se sve odjednom upisuje, dovoljno je samo proveriti da li datum postoji
		ret = true;
	return ret;
}
void Element::info()
{
	cout << "Datum: " << getDate() << "\nVreme: " << getTime() << "\nJMBG: " << getJMBG() << endl;
}
bool operator==(const Element& left, const Element& right)
{
	bool ret = false;
	if (left.date->compare(*right.date) == 0 && left.time->compare(*right.time))
		ret = true;
	return ret;
}
Element& Element::operator=(const Element& original)
{
	if (this != &original)
	{
		del();
		setDate(*original.date);
		setTime(*original.time);
		setJMBG(*original.jmbg);
	}
	return *this;
}
int Element::convert(const string t)
{
	int value = 0;
	for (int i = 0; i < 5; i++)
	{
		if (i != 2)
			value = (value * 10) + ((int)t[i] - 48);
	}
	return value;
}