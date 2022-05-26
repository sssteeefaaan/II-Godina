#pragma once
#include "TemplateMatrix.h"

template <class T, int n>
class SquareTemplateMatrix 
	: public TemplateMatrix<T, n, n>
{
public:
	SquareTemplateMatrix(void)
	{
	}
	~SquareTemplateMatrix(void)
	{
	}
};

