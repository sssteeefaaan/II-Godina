#pragma once
#include <iostream>
#include "DSException.h"

class minHeap
{
	//	ATTRIBUTES
//private:
	int* array;
	int numbOfLevels;
	long maxElements;
	long taken;

	//	BASE
public:
	minHeap(int numbOfLevels=1,long taken=0,int* array=nullptr)
	{
		set(numbOfLevels,taken,array);
	}
	minHeap(const minHeap& original)
	{
		if (this != &original)
			this->set(original.getLevels(), original.getTaken(), original.getArray());
	}
	minHeap& operator=(const minHeap& rightOp)
	{
		if (this != &rightOp)
		{
			this->del();
			this->set(rightOp.getLevels(), rightOp.getTaken(), rightOp.getArray());
		}
		return *this;
	}
	virtual ~minHeap()
	{
		if (this != nullptr)
			this->del();
	}

	//	SET, GET, DEL
	void set(int numbOfLevels, long taken, int* array)
	{
		this->array = new int[this->maxElements = (1 << (this->numbOfLevels = numbOfLevels)) - 1];
		this->taken = taken;
		if (array != nullptr)
			for (long index = 0; index < maxElements; index++)
				this->array[index] = array[index];
		else
			for (long i = 0; i < maxElements; i++)
				this->array[i] = 0;
	}
	void setAtIndex(long index, int element)
	{
		if (index > getMax())
			throw new DSException((char*)"Index out of bounds!");
		else
			this->array[index] = element;
	}
	inline int getLevels() const { return this->numbOfLevels; }
	inline long getMax() const { return this->maxElements; }
	inline long getTaken() const { return this->taken; }
	inline int* getArray() const { return this->array; }
	int getAtIndex(long index) const
	{
		if (index > getMax())
			throw new DSException((char*)"Index out of bounds!");
		else
			return this->array[index];
	}
	void del()
	{
		if (this->array != nullptr)
			delete[] this->array;
	}

	//	FUNCTIONALITY
	void insert(int element)
	{
		if (getTaken() == getMax())
			throw new DSException((char*)"Can't add more elements! Heap is full!");
		else
		{
			long index = taken++;
			while (index > 0 && getAtIndex(index >> 1) > element)
				setAtIndex(index, getAtIndex(index >>= 1));
			setAtIndex(index, element);
		}
	}
	int popRoot()
	{
		if (getTaken() == 0)
			throw new DSException((char*)"Root is empty!");
		int ret = getAtIndex(0);
		int max = getAtIndex(getTaken()-1);
		long minOffspring, index = 0;
		while ((minOffspring = (index << 1) + 1) < getTaken() - 1)
		{
			if (minOffspring + 1 < getTaken() - 1)
				if (getAtIndex(minOffspring + 1) < getAtIndex(minOffspring))
					minOffspring++;
			if (max <= getAtIndex(minOffspring))
				break;
			setAtIndex(index, getAtIndex(minOffspring));
			index = minOffspring;
		}
		setAtIndex(index, max);
		this->taken--;
		return ret;
	}
	minHeap* Mirrored() const
	{
		if (getTaken() != getMax())
			throw new DSException((char*)"Can't make a mirrored copy!");
		else {
			int* array = new int[getMax()];
			copyMirrored(array);
			return new minHeap(getLevels(), getTaken(), array);
		}
	}
	void copyMirrored(int* inArray) const
	{
		for (int level = 0; level < getLevels(); level++)
		{
			long inIndex = (1 << level) - 1;
			long bound = (1 << (level + 1)) - 1;
			long fromIndex = bound - 1;
			while (inIndex < bound)
				inArray[inIndex++] = getAtIndex(fromIndex--);
		}
	}

	//	IN/OUT
	std::ostream& details(std::ostream& out)
	{
		out << "Heap has " << getTaken();
		out << "\\" << getMax();
		out << " elements and " << getLevels();
		out << " levels." << std::endl;
		return out;
	}
	std::ostream& widthFirst(std::ostream& out)
	{
		if (getTaken() == 0)
			throw new DSException((char*)"Head is empty!");
		else {
			details(out);
			out << "Elements shown in width first mode:" << std::endl << "-------------------" << std::endl;
			for (int level = 0; level < getLevels(); level++)
			{
				out << "Level " << (level + 1) << std::endl;
				out << "--------------------" << std::endl;
				long index = (1 << level) - 2;
				long bound = (1 << (level + 1)) - 1;
				while (++index < bound)
					if (index < getTaken())
						out << (index + 1) << ". " << getAtIndex(index) << std::endl;
				out << "--------------------" << std::endl;
			}
			return out;
		}
	}
	std::ostream& depthFirst(std::ostream& out)
	{
		if (getTaken() == 0)
			throw new DSException((char*)"Head is empty!");
		else {
			details(out);
			out << "Elements shown in depth first preorder mode:" << std::endl;
			preorder(0, out);
			return out;
		}
	}
	std::ostream& preorder(long index, std::ostream& out)
	{
		if (index < getTaken())
		{
			out << getAtIndex(index) << std::endl;
			if ((index << 1) + 1 < getTaken())
			{
				out << "Left offspring of index (" << (index + 1) << ")" << std::endl;
				preorder((index << 1) + 1, out);
			}
			if ((index + 1) << 1 < getTaken())
			{
				out << "Right offspring of index (" << (index + 1) << ")" << std::endl;
				preorder((index + 1) << 1, out);
			}
		}
		return out;
	}

	//	TEST
	static void test(int levels)
	{
		minHeap* TreeNo1 = new minHeap(levels);

		for (int level = 0; level < levels; level++)
		{
			long index = (1 << level) - 2;
			long bound = (1 << (level + 1)) - 1;
			while (++index < bound)
				TreeNo1->insert((int)(index + 1));
		}

		TreeNo1->depthFirst(std::cout);

		minHeap* TreeNo2 = TreeNo1->Mirrored();
		minHeap* TreeNo3 = TreeNo2->Mirrored();

		std::cout << TreeNo2->popRoot() << std::endl;
		std::cout << TreeNo2->popRoot() << std::endl;
		std::cout << TreeNo2->popRoot() << std::endl;

		TreeNo2->widthFirst(std::cout);
		TreeNo3->widthFirst(std::cout);

		delete TreeNo1, TreeNo2, TreeNo3;
	}
};

