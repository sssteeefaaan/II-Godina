#pragma once
#include "node.h"
#include <queue>

class binaryTree
{
	//	ATTRIBUTES
//private:
	node* root;
	long numbOfElements;
	long numbOfNodes;

	//	BASE
public:
	binaryTree(long numbOfElements = 0, node* root = nullptr)
	{
		set(numbOfElements, root);
	}
	binaryTree(const binaryTree& original)
	{
		if (this != &original)
			set(original.getElements(), original.getRoot());
	}
	binaryTree& operator=(const binaryTree& rightOp)
	{
		if (this != &rightOp)
		{
			this->del();
			this->set(rightOp.getElements(), rightOp.getRoot());
		}
		return *this;
	}
	virtual ~binaryTree()
	{
		if (this != nullptr)
			this->del();
	}

	//	SET, COPY, GET, DEL
	void set(long numbOfElements, node* root)
	{
		this->numbOfElements = numbOfElements;
		this->root = copyRoot(root);
	}
	node* copyRoot(node* rootOriginal)
	{
		if (rootOriginal != nullptr)
			return new node(rootOriginal->getElement(), copyLeft(rootOriginal->getLeft()), copyRight(rootOriginal->getRight()));
		else
			return new node();
	}
	node* copyLeft(node* left)
	{
		if (left != nullptr)
			return new node(left->getElement(), copyLeft(left->getLeft()), copyRight(left->getRight()));
		else
			return left;
	}
	node* copyRight(node* right)
	{
		if (right != nullptr)
			return new node(right->getElement(), copyLeft(right->getLeft()), copyRight(right->getRight()));
		else
			return right;
	}
	inline long getElements() const { return this->numbOfElements; }
	inline node* getRoot() const { return this->root; }
	long getDepth(node* treeNode)
	{
		if (treeNode == nullptr)
			return 0;
		else
		{
			long leftDepth = getDepth(treeNode->getLeft());
			long rightDepth = getDepth(treeNode->getRight());

			return ((leftDepth > rightDepth) ? leftDepth : rightDepth) + 1;
		}
	}
	void del()
	{
		if (this != nullptr)
			delTree(this->root);
	}
	void delTree(node* treeNode)
	{
		if (treeNode != nullptr)
		{
			delTree(treeNode->getLeft());
			delTree(treeNode->getRight());
			delete treeNode;
		}
	}
	void delLeaves()
	{
		if(getElements() == 0)
			throw new DSException((char*)"The tree contains no elements");
		else {
			if (getElements() == 1)
				throw new DSException((char*)"Can't delete root!");
			else
				delNull(getRoot(),nullptr);
		}
	}
	void delNull(node* treeNode, node* parentNode)
	{
		if (treeNode != nullptr) {
			if (treeNode->getLeft() == nullptr && treeNode->getRight() == nullptr && parentNode!=nullptr)
			{
				if (parentNode->getLeft() == treeNode)
					parentNode->setLeft(nullptr);
				else
					parentNode->setRight(nullptr);
				delete treeNode;
				this->numbOfElements--;
			}
			else
			{
				delNull(treeNode->getLeft(), treeNode);
				delNull(treeNode->getRight(), treeNode);
			}
		}
	}
	
	//	MANIPULATE
	void insert(int element)
	{
		if (this->numbOfElements == 0)
			this->root->setElement(element);

		else {
			node* treeNode = getRoot();
			node* parentNode = nullptr;
			node*importNode = new node(element);

			while (treeNode != nullptr)
			{
				parentNode = treeNode;
				if (treeNode->greaterThan(element))
					treeNode = treeNode->getLeft();
				else
					treeNode = treeNode->getRight();
			}

			if (parentNode->greaterThan(element))
				parentNode->setLeft(importNode);
			else
				parentNode->setRight(importNode);
		}
		this->numbOfElements++;
	}
	node* findElement(int element)
	{
		if (getElements() == 0)
			throw new DSException((char*)"Couldn't find the element, because the Tree contains no elements!");
		node* treeNode = getRoot();
		bool check;
		while (treeNode != nullptr)
		{
			if (check=treeNode->equalTo(element))
			{
				break;
			}
			else {
				if (treeNode->greaterThan(element))
					treeNode = treeNode->getLeft();
				else
					treeNode = treeNode->getRight();
			}
		}
		if (check)
		{
			std::cout << "Element found! Here it is: ";
			return treeNode;
		}
		else {
			std::cout << "Couldn't find the element :( here's the root element instead: ";
			return getRoot();
		}
	}

	//	IN/OUT
	std::ostream& widthFirst(std::ostream& out)
	{
		if (getRoot() == nullptr)
			throw new DSException((char*)"The ordered binary tree is empty!");
		else
		{
			out << "------------------------------" << std::endl;
			out << "Ordered binary tree of " << getElements();
			out << " elements with depth (" << getDepth(getRoot());
			out << ") shown in width first mode : " << std::endl << std::endl;
			long index = 1;
			std::queue <node*> sideArray;
			node* treeNode = root;
			sideArray.push(treeNode);
			while (!sideArray.empty())
			{
				treeNode = sideArray.front();
				sideArray.pop();
				out << index++ << ". ";
				treeNode->show(out);
				if (treeNode->getLeft() != nullptr)
					sideArray.push(treeNode->getLeft());
				if (treeNode->getRight() != nullptr)
					sideArray.push(treeNode->getRight());
			}
			out << "------------------------------" << std::endl;
		}
		return out;
	}
	std::ostream& depthFirst(std::ostream& out)
	{
		if (getRoot() == nullptr)
			throw new DSException((char*)"The ordered binary tree is empty!");
		else
		{
			out << "------------------------------" << std::endl;
			out << "Ordered binary tree of " << getElements();
			out << " elements with depth (" << getDepth(getRoot());
			out << ") shown in depth first post order mode : " << std::endl << std::endl;
			postOrder(out, getRoot());
			out << "------------------------------" << std::endl;
		}
		return out;
	}
	std::ostream& postOrder(std::ostream& out, node* treeNode)
	{
		if (treeNode != nullptr)
		{
			postOrder(out, treeNode->getLeft());
			postOrder(out, treeNode->getRight());
			treeNode->show(out);
		}
		return out;
	}

	//	TEST
	static void test(long numbOfElements, int elementOne, int elementTwo)
	{
		binaryTree* bTreeNo1 = new binaryTree();
		for (long i = 0; i < (numbOfElements >> 1); i++)
		{
			bTreeNo1->insert(i + (numbOfElements >> 1) + 1);
			bTreeNo1->insert(i + 1);
		}
		bTreeNo1->insert(numbOfElements);

		std::cout << "Tree No. 1" << std::endl;
		bTreeNo1->depthFirst(std::cout);

		std::cout << "Tree No. 1 after delition of its leaves:" << std::endl;
		bTreeNo1->delLeaves();
		bTreeNo1->widthFirst(std::cout);

		binaryTree* bTreeNo2 = new binaryTree();
		*bTreeNo2 = *bTreeNo1;

		std::cout << "Tree No. 2" << std::endl;
		bTreeNo2->widthFirst(std::cout);

		std::cout << "Searching for the element ("<< elementOne <<") in binary tree no. 1..."<< std::endl;
		std::cout << *(bTreeNo1->findElement(elementOne));
		std::cout << "Searching for the element (" << elementTwo << ") in binary tree no. 2..." << std::endl;
		std::cout << *(bTreeNo2->findElement(elementTwo));

		delete bTreeNo1, bTreeNo2;
	}
};

