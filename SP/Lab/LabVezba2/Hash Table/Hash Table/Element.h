#pragma once
#include <string>
using namespace std;
class Element
{
//private:
	string *date;
	string *time;
	string *jmbg;
public:
	Element();
	Element(string,string,string);
	~Element();
	Element(const Element&);
	void info();
	inline void setDate(string date)	{ this->date = new string(date); }
	inline void setTime(string time)	{ this->time = new string(time); }
	inline void setJMBG(string jmbg)	{ this->jmbg = new string(jmbg); }
	void del();
	void setNULL();
	bool isNULL();
	inline string getDate()		{ return *date; }
	inline string getTime()		{ return *time; }
	inline string getJMBG()		{ return *jmbg; }
	friend bool operator==(const Element&, const Element&);
	Element& operator=(const Element&);
};

