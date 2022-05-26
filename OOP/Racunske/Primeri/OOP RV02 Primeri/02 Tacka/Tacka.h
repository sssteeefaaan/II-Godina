

class Tacka
{
private:
	float x;
	float y;
public:
	void postaviNa( float novoX, float novoY );
	void pomeriZa( float deltaX, float deltaY );
	float rastojanje( const Tacka& t );
	float uzmiX()
	{
		return x;
	}
	inline float uzmiY();
};

float Tacka::uzmiY()	
{
	return y;
}