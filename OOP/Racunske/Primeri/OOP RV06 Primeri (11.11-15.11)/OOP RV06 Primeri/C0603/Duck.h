#include <iostream>
using namespace std;
#include <math.h>
class Duck
{	
	int id;
	int power;
protected:
	int posX;
	int posY;
	void StepX(int s)
	{
		posX += s;
	}
public:
	static int TotalCount;
	static int ActiveCount;
	Duck(void);
	virtual ~Duck(void);
	void Draw()
	{
		cout<< id << " at " << posX << ", " << posY << endl;
	}
	void Swim()
	{		
		srand(TotalCount % id);
		int s = rand();
		StepX(s);
		Draw();
	}
	void Quack()
	{
		cout << "\nQuack!\n\n";
	}	
};

