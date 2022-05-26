entity full_adder is
	port( a,b,cin : in bit;
		s,cout : out bit);
end entity full_adder;

architecture output of full_adder is
begin
	s<=(a xor b) xor cin;
	cout<= (a and(b or cin)) or (b and cin);
end architecture output;

entity Threebit_adder is
	port(
		X,Y:in bit_vector (2 downto 0);
		Cin:in bit;
		Cout:out bit;
		S:out bit_vector(2	downto 0)
		);
end entity Threebit_adder;
	
architecture add of Threebit_adder is
signal c0,c1:bit;

begin
	add0: entity full_adder(output)
	port map(X(0),Y(0),Cin,S(0),c0);

	add1: entity full_adder(output)
	port map(X(1),Y(1),c0,S(1),c1);

	add2: entity full_adder(output)
	port map(X(2),Y(2),c1,S(2),Cout);

end architecture add;

entity tb is
end entity tb;

architecture tb of tb is
signal Cin,Cout:bit;
signal X,Y,S : bit_vector(2 downto 0);

begin
	adder:entity Threebit_adder(add)
	port map(X,Y,Cin,Cout,S);

	process is
	begin
		X<="101";
		Y<="001";
		wait for 50 ns;
		X<="001";
		Y<="010";
		wait for 50 ns;
	end process;
end architecture tb;
	