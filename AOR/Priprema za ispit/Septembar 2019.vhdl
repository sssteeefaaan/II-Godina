entity parnost is
generic(n:integer :=8);
port(X:bit_vector(n-1 downto 0);
Y:out bit_vector(n downto 0));
end entity parnost;

architecture parnost of parnost is
begin
	process(X) is
	variable count:bit;
	begin
		count:=X(0);
		for i in n-1 downto 1 loop
			count:=count xor X(i);
		end loop;
		Y<=count & X;
		
	end process;
end architecture parnost;

entity full_adder is
port(a,b,cin: in bit;
s,cout: out bit);
end entity full_adder;

architecture full_adder of full_adder is
begin
	s<=(a xor b xor cin);
	cout<=(a and b) or (cin and(a xor b));
end architecture full_adder;

entity carry_ripple is
generic (n : integer :=8);
port(A,B:in bit_vector(n-1 downto 0);
Cin:in bit;
S:out bit_vector(n downto 0));
end entity carry_ripple;

architecture carry_ripple of carry_ripple is
signal carry:bit_vector(n downto 0);
signal sum:bit_vector(n-1 downto 0);
begin
	carry(0)<=Cin;
	gen:for i in A'low to A'high generate
		dev:entity full_adder(full_adder)
		port map(A(i),B(i),carry(i),sum(i),carry(i+1));
	end generate;
	
	S<=carry(n) & sum;
end architecture carry_ripple;

entity kolo is
generic(n: integer :=8);
port(
A,B: in bit_vector(n-1 downto 0);
S: out bit_vector(n downto 0);
Pa,Pb:out bit);
end entity kolo;

architecture kolo of kolo is
signal zlj:bit:='0';
signal tempA,tempB: bit_vector(n downto 0);
begin
	par1:entity parnost(parnost)
	generic map (n)
	port map(A,tempA);
	
	par2:entity parnost(parnost)
	generic map(n)
	port map(B,tempB);
	
	sabirac:entity carry_ripple(carry_ripple)
	generic map(n)
	port map(tempA(n-1 downto 0),tempB(n-1 downto 0),zlj,S);
	
	Pa<=tempA(n);
	Pb<=tempB(n);
	
end architecture kolo;

------------------------------------------------------------------


entity tb is
generic(n:integer:=8);
end entity tb;

architecture tb of tb is
signal A,B:bit_vector(n-1 downto 0);
signal S:bit_vector(n downto 0);
signal Pa,Pb:bit;
begin
	uut:entity kolo(kolo)
	generic map(n)
	port map(A,B,S,Pa,Pb);
	
	process is
	begin
		A<="10010010";
		B<="10000100";
		
		wait for 50 ns;
		
		A<="10110110";
		B<="11010100";
		
		wait for 50 ns;
		
		A<="11010010";
		B<="10010100";
		
		wait for 50 ns;
		
		A<="11110000";
		B<="11001100";
		
		wait for 50 ns;
		
	end process;
end architecture tb;