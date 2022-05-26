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
	void UpdateInfo(T oldinfo, T newinfo)
	{
		LNode<T>* pomo = this->FindNode(oldinfo);
		if (pomo == nullptr)
			cout << "Nema tog elementa!" << endl;
		else {
			if (pomo == head)
				this->head = pomo->GetNext();
			else
			{
				LNode<T>* pomp;
				for (pomp = head; pomp->GetNext() != pomo; pomp = pomp->GetNext());
				if (pomo == tail)
					this->tail = pomp;
				pomp->SetNext(pomo->GetNext());
			}
			InsertNeopadajuci(newinfo);
		}
	}
	void InsertNeopadajuci(T info)
	{
		if (head->GetInfo() >= info)
			AddFirst(info);
		else {
			if (tail->GetInfo() <= info)
				AddLast(info);
			else {
				LNode<T>* pomp, *pom;
				pomp=pom = head;
				while (info > pom->GetInfo())
				{
					pomp = pom;
					pom = pom->GetNext();
				}
				pomp->SetNext(new LNode<T>(info, pomp->GetNext()));
			}
		}
	}
};

