#pragma once
#include <iostream>
#include "DSException.h"

class node
{
	//	ATTRIBUTES
//private:
	int element;
	node* left;
	node* right;

	//	BASE
public:
	node(int element = 0, node* left = nullptr, node* right = nullptr)
	{
		set(element, left, right);
	}
	node(const node& original)
	{
		if (this != &original)
			set(original.getElement(), original.getLeft(), original.getRight());
	}
	node& operator=(const node& rightOp)
	{
		if (this != &rightOp)
		{
			this->del();
			this->set(rightOp.getElement(), rightOp.getLeft(), rightOp.getRight());
		}
		return *this;
	}
	virtual ~node()
	{
		if (this != nullptr)
			this->del();
	}

	//	SET, GET, DEL
	void set(int element, node* left, node* right)
	{
		setElement(element);
		setLeft(left);
		setRight(right);
	}
	void setElement(int element) { this->element = element; }
	void setLeft(node* left) { this->left = left; }
	void setRight(node* right) { this->right = right; }
	inline int getElement() const { return this->element; }
	inline node* getLeft() const { return this->left; }
	inline node* getRight() const { return this->right; }
	void del(){}

	//	COMPARE
	bool lessThan(int element) const { return getElement() < element; }
	bool equalTo(int element) const { return getElement() == element; }
	bool greaterThan(int element) const { return getElement() > element; }

	// IN/OUT
	std::ostream& show(std::ostream& out) const
	{
		out << getElement() << std::endl;
		return out;
	}
	friend std::ostream& operator<<(std::ostream& out, const node& node)
	{
		return node.show(out);
	}
};

