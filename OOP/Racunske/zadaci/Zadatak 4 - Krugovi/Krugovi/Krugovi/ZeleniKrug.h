#pragma once
#include "ObojeniKrug.h"

class ZeleniKrug : public ObojeniKrug
{
public:
	ZeleniKrug(void);
	ZeleniKrug(double polup) : ObojeniKrug(0, 200, 0, polup)
	{
	}
	void operator+=(int zel)
	{
		G += zel;
		if (G > 255) G = 255;
	}
	virtual ~ZeleniKrug(void);
};
