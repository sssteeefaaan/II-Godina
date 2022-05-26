#pragma once
#include "node.h"

class node;

class edge
{
private:
	node* origin;
	node* destination;
	edge* relation;
	long weight;

public:
	edge(node* origin = nullptr, node* destination = nullptr, edge* relation = nullptr, long weight = 0)
	{
		set(origin, destination, relation, weight);
	}

	//	SET, GET
	inline void set(node* origin = nullptr, node* destination = nullptr, edge* relation = nullptr, long weight = 0)
	{
		setOrigin(origin);
		setDest(destination);
		setRelation(relation);
		setWeight(weight);
	}
	inline void setOrigin(node* origin = nullptr) { this->origin = origin; }
	inline void setDest(node* destination = nullptr) { this->destination = destination; }
	inline void setRelation(edge* relation = nullptr) { this->relation = relation; }
	inline void setWeight(long weight = 0) { this->weight = weight; }
	inline long getWeight() const { return this->weight; }
	inline node* getOrigin() const { return this->origin; }
	inline node* getDestination() const { return this->destination; }
	inline edge* getRelation() const { return this->relation; }

	node* operator+(const node& from)
	{
		if (this->getOrigin() == &from)
			return this->getDestination();
		return nullptr;
	}
	node* operator-(const node& to)
	{
		if (this->getDestination() == &to)
			return this->getOrigin();
		return nullptr;
	}
};