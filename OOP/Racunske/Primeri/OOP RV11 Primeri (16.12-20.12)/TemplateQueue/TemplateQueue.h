#pragma once

template <class Type, int k>
class TemplateStack
{
	Type queue[k];
	int nextEmpty;
public:

	TemplateStack(void)
	{
		nextEmpty = 0;
	}

	virtual ~TemplateStack(void)
	{
	}	

	Type remove()
	{
		if (nextEmpty > 0)
		{
			nextEmpty--;
			return queue[nextEmpty];
		}
		
		return *(new Type);
	}

	void add(const Type &newItem)
	{
		if (nextEmpty < k)
		{
			queue[nextEmpty] = newItem;
			nextEmpty++;
		}
	}

	void sort()
	{
		for (int i = 0; i < k - 1; i++)
			for(int j = i + 1; j < k; j++)
			{
				if (queue[i] > queue[j])
				{
					Type tmp = queue[i];
					queue[i] = queue[j];
					queue[j] = tmp;
				}
			}
	}

	bool is_empty()
	{
		return nextEmpty == 0;
	}

	bool is_full()
	{
		return nextEmpty == k;
	}

	Type& operator[] (int i)
	{
		return queue[i];
	}


};

