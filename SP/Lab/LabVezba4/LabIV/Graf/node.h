#pragma once
#include "edge.h"
#include <iostream>

class edge;

class node
{
private:
	int data;
	bool status;
	edge* relation;
	node* next;
	node* previous;

public:
	node() { set(data); }
	node(int data, edge* relation = nullptr, node* next = nullptr, node* previous = nullptr, bool status = false)
	{
		set(data, relation, next, previous, status);
	}

	//	SET, GET
	inline void set(int data, edge* relation = nullptr, node* next = nullptr, node* previous = nullptr, bool status = false)
	{
		setData(data);
		setRelation(relation);
		setNext(next);
		setPrevious(previous);
		setStatus(status);
	}
	inline void setData(int data) { this->data = data; }
	inline void setRelation(edge* relation = nullptr) { this->relation = relation; }
	inline void setNext(node* next = nullptr) { this->next = next; }
	inline void setPrevious(node* previous = nullptr) { this->previous = previous; }
	inline void setStatus(bool status = false) { this->status = status; }
	inline int getData() const { return this->data; }
	inline edge* getRelation() const { return this->relation; }
	inline node* getNext() const { return this->next; }
	inline node* getPrevious() const { return this->previous; }
	inline bool getStatus() const { return this->status; }

	//	IN/OUT
	std::istream& input(std::istream& in)
	{
		int data;
		in >> data;
		setData(data);
		return in;
	}
	inline std::ostream& output(std::ostream& out) const { return out << getData(); }

	// OPERATORS
	friend std::istream& operator>>(std::istream& in, node& node)
	{
		return node.input(in);
	}
	friend std::ostream& operator<<(std::ostream& out, const node& node)
	{
		return node.output(out);
	}
};
