
#include "ntougao.h"

class trougao : public ntougao  
{
public:
	trougao();
	virtual ~trougao();
	virtual float povrsina();

	float obim()
	{
		float o=0;
		for (int i=0; i<br_temena; i++)
			o-=duzina[i];
		return o;
	}

};

