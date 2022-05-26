#pragma once
#include"LNode.h"
#include<iostream>
using namespace std;

template <class T>
class List
{
private:
	LNode<T>* head;
	LNode<T>* tail;
public:
	List()
	{
		head = tail = nullptr;
	}
	List(T in)
	{
		head = tail = new LNode<T>(in);
	}
	~List() {};
	void AddFirst(T in)
	{
		this->head = new LNode<T>(in, head);
		if (this->tail == nullptr)
			this->tail = this->head;
	}
	void AddLast(T in)
	{
		if (this->head == nullptr)
			this->head = this->tail = new LNode<T>(in);
		else {
			this->tail->SetNext(new LNode<T>(in));
			this->tail = this->tail->GetNext();
		}
	}
	T DelFirst()
	{
		T p;
		if (this->head == nullptr)
			cout<< "Lista je prazna"<<endl;
		else {
			p = head->GetInfo();
			if (head == tail)
				head = tail = nullptr;
			else
				head = head->GetNext();
		}
		return p;
	}
	T DelLast()
	{
		T p;
		if (tail == nullptr)
			cout<< "Lista je prazna"<<endl;
		else {
			p = this->tail->GetInfo();
			if (head == tail)
				head = tail = nullptr;
			else {
				LNode<T>* pom = head;
				for (pom = head; pom->GetNext() != tail; pom = pom->GetNext());
				this->tail = pom;
				this->tail->SetNext(nullptr);
			}
		}
		return p;
	}
	LNode<T>* FindNode(T in)
	{
		if (head == nullptr)
			return nullptr;
		LNode<T>* pom = head;
		while (pom->GetInfo() != in && pom->GetNext() != nullptr)
			pom = pom->GetNext();
		if (pom->GetInfo() == in)
			return pom;
		else
			return nullptr;
	}
	inline LNode<T>* GetNext(LNode<T>* Node)
	{return Node->GetNext();}
	inline LNode<T>* GetHead() { return this->head; }
	inline LNode<T>* GetTail() { return this->tail; }
	void PrintAll()
	{
		LNode<T> *current= this->head;
		if (current == nullptr)
			cout << "Lista je prazna" << endl;
		else
		{
			while (current != nullptr)
			{
				cout << current->GetInfo() << endl;
				current = current->GetNext();
			}
		}
		delete current;
	}
	bool InList(T in)
	{
		bool r = false;
		LNode<T>* current = head;
		while (!r && current != nullptr)
		{
			if (current->GetInfo() == in)
				r = true;
			current = current->GetNext();
		}
		return r;
	}
	LNode<T>* FindPrevious(LNode<T>* current)
	{
		if (head == current)
			return nullptr;
		else {
			LNode<T>* pom;
			LNode<T>* pomp = head;
			for (pom = head; pom != current; pom = pom->GetNext())
				pomp = pom;
			return pomp;
		}
	}
	void UpdateInfo(T oldinfo, T newinfo)
	{
		LNode<T>* pom = this->FindNode(oldinfo);
		if (pom == nullptr)
			cout << "Nema tog elementa." << endl;
		else
		{
			Delete(pom);
		}
		InsertInfo(newinfo);
	}
	void Delete(LNode<T>* node)
	{
		if (node == head)
			DelFirst();
		else
		{
			if (node == tail)
				DelLast();
			else {
				this->FindPrevious(node)->SetNext(node->GetNext());
				delete node;
			}
		}
	}
	void InsertInfo(T info)
	{
		if (info <= head->GetInfo())
			AddFirst(info);
		else {
			if (info >= tail->GetInfo())
				AddLast(info);
			else
			{
				LNode<T>* pom=head;
				while (pom->GetInfo() < info)
					pom = pom->GetNext();
				FindPrevious(pom)->SetNext(new LNode<T>(info, pom));
			}
		}
	} 
};

