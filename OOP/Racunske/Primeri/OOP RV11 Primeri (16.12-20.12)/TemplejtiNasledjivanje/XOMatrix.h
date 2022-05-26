#pragma once
#include "SquareTemplateMatrix.h"
#include "MyPoint.h"

class XOMatrix 
	: public SquareTemplateMatrix<MyPoint, 3>
{
public:
	XOMatrix(void);
	virtual ~XOMatrix(void);
};

