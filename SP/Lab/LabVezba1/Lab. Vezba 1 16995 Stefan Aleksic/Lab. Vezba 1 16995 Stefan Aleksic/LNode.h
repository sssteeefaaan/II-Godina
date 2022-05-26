#pragma once

template<class T>
class LNode
{
private:
	T info;
	LNode* next;
public:
	LNode()
	{
		this->next = nullptr;
	}
	LNode(T in)
	{
		this->info = in;
		this->next = nullptr;
	}
	LNode(T in, LNode* nx)
	{
		this->info = in;
		this->next = nx;
	}
	~LNode() {};
	LNode(const LNode& org)
	{
		this->info = org.info;
		this->next = org.next;
	}
	inline T GetInfo() { return this->info; }
	inline LNode* GetNext() { return this->next; }
	inline void SetNext(LNode* next) { this->next = next; }
	inline void SetInfo(T in) { this->info = in; }
	inline bool Eql(T in) { return in == info; }
};

