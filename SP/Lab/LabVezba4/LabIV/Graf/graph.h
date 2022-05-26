#pragma once
#include "edge.h"
#include "node.h"
#include <queue>
#include <list>


class graph
{
private:
	node* start;
	node* end;
	int nodes;
	
public:
	graph(node* start = nullptr, node* end = nullptr, int nodes = 0) { set(start, end, nodes); }
	~graph()
	{
		if (this != nullptr)
			del();
	}

	//	SET, GET, DEL
	inline void set(node* start = nullptr, node* end = nullptr, int nodes = 0)
	{
		setStart(start);
		setEnd(end);
		setNum(nodes);
	}
	inline void setStart(node* start = nullptr) { this->start = start; }
	inline void setEnd(node* end = nullptr) { this->end = end; }
	inline void setNum(int nodes = 0) { this->nodes = nodes; }
	inline node* getStart() const { return this->start; }
	inline node* getEnd() const { return this->end; }
	inline int getNum() const { return this->nodes; }
	inline void del() { delAllNodes(); }

	//	NODE FUNTIONS
	node* findNode(int data);
	bool addNode(int data);
	bool delNode(int data);
	void delAllNodes();

	//	EDGE FUNCTIONS
	edge* findEdge(int fromData, int toData);
	bool addEdge(int fromData, int toData);
	bool delEdge(int fromData, int toData);
	void delEdgesToNode(node* node);
	void delEdgesFromNode(node* node);
	void delAllEdges(node* node);

	//	TRAVEL FUNTIONS
	std::ostream& breadthFirst(int data, std::ostream& out = std::cout);
	std::ostream& depthFirst(int data, std::ostream& out = std::cout);
	void resetFlags(std::list<node*>& readList);
	void resetAllFlags()
	{
		node* temp = getStart();
		while (temp != nullptr)
		{
			temp->setStatus();
			temp = temp->getNext();
		}
	}

	//	IN/OUT
	std::istream& input(std::istream& in);
	std::ostream& output(std::ostream& out);

	//	OPERATORS
	friend std::istream& operator>>(std::istream& in, graph& graph)
	{
		return graph.input(in);
	}
	friend std::ostream& operator<<(std::ostream& out, graph& graph)
	{
		return graph.output(out);
	}

	//	FUNTIONALITY
	int getUndirected();
	int getShortestRoute(int A, int B);
	int findRoute(node* start, node* end, int& lenght, std::list<node*>& readList);
};

//	NODE FUNTIONS
node* graph::findNode(int data)
{
	node* temp = start;
	while (temp != nullptr && temp->getData() != data)
		temp = temp->getNext();
	return temp;
}

bool graph::addNode(int data)
{
	node* add = new node(data);
	if (getStart() == nullptr)
	{
		setStart(add);
		setEnd(add);
	}
	else
	{
		getEnd()->setNext(add);
		add->setPrevious(getEnd());
		setEnd(add);
	}
	setNum(getNum() + 1);
	return true;
}

bool graph::delNode(int data)
{
	if (getStart() == nullptr)
		return false;
	node* tempN;
	if (getStart()->getData() == data)
	{
		tempN = getStart();
		delAllEdges(tempN);
		setStart(tempN->getNext());
	}
	else
	{
		if (getEnd()->getData() == data)
		{
			tempN = getEnd();
			delAllEdges(tempN);
			setEnd(tempN->getPrevious());
			getEnd()->setNext(nullptr);
		}
		else
		{
			tempN = getStart()->getNext();
			while (tempN != nullptr && tempN->getData() != data)
				tempN = tempN->getNext();
			if (tempN == nullptr)
				return false;
			node* prv = tempN->getPrevious();
			node* nxt = tempN->getNext();
			prv->setNext(tempN->getNext());
			nxt->setPrevious(prv);
			delAllEdges(tempN);
		}
	}
	delete tempN;
	setNum(getNum() - 1);
	return true;
}
void graph::delAllNodes()
{
	node* temp = getStart();
	while (temp != nullptr)
	{
		node* temp2 = temp->getNext();
		delEdgesFromNode(temp);
		delete temp;
		temp = temp2;
	}
	setStart(nullptr);
	setEnd(nullptr);
	setNum(0);
}

//	EDGE FUNCTIONS

edge* graph::findEdge(int fromData, int toData)
{
	node* nodeA = findNode(fromData);
	node* nodeB = findNode(toData);
	if (nodeA == nullptr || nodeB == nullptr)
		return nullptr;
	edge* temp = nodeA->getRelation();
	while (temp != nullptr && temp->getDestination() != nodeB)
		temp = temp->getRelation();
	return temp;
}

bool graph::addEdge(int fromData, int toData)
{
	node* nodeA = findNode(fromData);
	node* nodeB = findNode(toData);
	if (nodeA == nullptr || nodeB == nullptr)
		return false;
	edge* temp = new edge(nodeA, nodeB, nodeA->getRelation());
	nodeA->setRelation(temp);
	return true;
}

bool graph::delEdge(int fromData, int toData)
{
	edge* tempE = findEdge(fromData, toData);
	node* tempN = findNode(fromData);
	if (tempE == nullptr || tempN == nullptr)
		return false;
	if (tempE == tempN->getRelation())
		tempN->setRelation(tempE->getRelation());
	else
	{
		edge* tempE2 = tempN->getRelation();
		while (tempE2->getRelation() != tempE)
			tempE2 = tempE2->getRelation();
		tempE2->setRelation(tempE->getRelation());
	}
	delete tempE;
	return true;
}
void graph::delAllEdges(node* forDel)
{
	delEdgesFromNode(forDel);
	delEdgesToNode(forDel);
}
void graph::delEdgesFromNode(node* forDel)
{
	edge* temp = forDel->getRelation();
	while (temp != nullptr)
	{
		edge* temp2 = temp->getRelation();
		delete temp;
		temp = temp2;
	}
	forDel->setRelation(nullptr);
}
void graph::delEdgesToNode(node* forDel)
{
	node *tempN = getStart();
	while (tempN != nullptr)
	{
		if (tempN != forDel)
		{
			edge* tempE = tempN->getRelation();
			edge* tempForDel = nullptr;
			edge* tempPrev = nullptr;
			while (tempE != nullptr)
			{
				if (tempE->getDestination() == forDel)
				{
					if (tempPrev != nullptr)
						tempPrev->setRelation(tempE->getRelation());
					else
						tempN->setRelation(tempE->getRelation());
					tempForDel = tempE;
					tempE = tempE->getRelation();
					delete tempForDel;
				}
				else
				{
					tempPrev = tempE;
					tempE = tempE->getRelation();
				}
			}
		}
		tempN = tempN->getNext();
	}
}
//	TRAVEL FUNTIONS

std::ostream& graph::breadthFirst(int data, std::ostream& out)
{
	std::queue<node*> sideArray;
	std::list <node*> readList;
	node* temp = findNode(data);
	if (temp == nullptr)
		return out << "Empty" << std::endl;
	sideArray.push(temp);
	while (!sideArray.empty())
	{
		temp = sideArray.front();
		sideArray.pop();
		readList.push_front(temp);
		if (!temp->getStatus())
		{
			out << *temp << std::endl;
			temp->setStatus(true);
		}
		edge* tempE = temp->getRelation();
		while (tempE != nullptr)
		{
			if (!tempE->getDestination()->getStatus())
				sideArray.push(tempE->getDestination());
			tempE = tempE->getRelation();
		}
	}
	resetFlags(readList);

	return out;
}

std::ostream& graph::depthFirst(int data, std::ostream& out)
{
	return out;
}
void graph::resetFlags(std::list<node*>& readList)
{
	for (node* temp : readList)
		temp->setStatus(false);
	readList.clear();
}

//	IN/OUT

std::istream& graph::input(std::istream& in)
{
	return in;
}

std::ostream& graph::output(std::ostream& out)
{
	node* tempN = getStart();
	while (tempN != nullptr)
	{
		out << tempN->getData();
		edge* tempE = tempN->getRelation();
		while (tempE != nullptr)
		{
			out << " -> " << tempE->getDestination()->getData();
			tempE = tempE->getRelation();
		}
		out << "\r\n";
		tempN = tempN->getNext();
	}
	out << "Graph has: " << getUndirected() << " undirected relations.\n";
	return out;
}

//	FUNTIONALITY
int graph::getUndirected()
{
	int ret = 0;
	node* tempN = getStart();
	std::list<node*> sideArray;
	while (tempN != nullptr)
	{
		edge* tempE = tempN->getRelation();
		while (tempE != nullptr)
		{
			node* tempN2 = tempE->getDestination();
			if (!tempN2->getStatus())
			{
				edge* tempE2 = tempN2->getRelation();
				while (tempE2 != nullptr)
				{
					if (tempN == tempE2->getDestination())
						ret++;
					tempE2 = tempE2->getRelation();
				}
			}
			tempE = tempE->getRelation();
		}
		tempN->setStatus(true);
		sideArray.push_back(tempN);
		tempN = tempN->getNext();
	}
	resetFlags(sideArray);
	return ret;
}
int graph::getShortestRoute(int A, int B)
{
	node* start = findNode(A);
	node* end = findNode(B);
	if (start == nullptr || end == nullptr)
		return 0;
	int size = 0;
	std::list<node*> readList;
	std::cout << "The path from " << *start << " to " << *end << ":" << std::endl;
	if (findRoute(start, end, size, readList) == 0)
		std::cout << " Doesn't exist! They aren't in a relation!" << std::endl;
	else
	{
		std::cout << " <- " << *start << std::endl;
		std::cout << "It's lenght (number of edges between) is: " << size << std::endl;
	}
	resetFlags(readList);
	return size;
}
int graph::findRoute(node* start, node* end, int& lenght,std::list<node*>& readList)
{
	if (start == end)
	{
		std::cout << *start;
		lenght++;
		return 1;
	}
	int ret = 0;
	bool test = false;
	if (!start->getStatus())
	{
		start->setStatus(true);
		readList.push_back(start);
		edge* temp = start->getRelation();
		while (temp != nullptr && ret == 0)
		{
			if (temp->getDestination() == end)
			{
				std::cout << *temp->getDestination();
				lenght++;
				test = true;
				ret = 1;
			}
			else
				temp = temp->getRelation();
		}
		temp = start->getRelation();
		while (temp != nullptr && ret == 0)
		{
			start = temp->getDestination();
			ret += findRoute(start, end, lenght, readList);
			temp = temp->getRelation();
		}
		if (ret != 0 && !test)
		{
			std::cout << " <- " << *start;
			lenght++;
		}
	}
	return ret;
}