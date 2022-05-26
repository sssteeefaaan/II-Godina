library ieee;
use ieee.std_logic_1164.all;

entity full_adder is
port( a,b,cin: in std_logic;
	s,cout: out std_logic);
end entity full_adder;

architecture adder of full_adder is
begin
	s<=(a xor b) xor cin;
	cout<= (a and b) or (c and (a xor b));
end architecture adder;

library ieee;
use ieee.std_logic_1164.all;

entity carry_ripple is
generic (n : integer :=8);
port(
	A,B: in std_logic_vector(n-1 downto 0);
	Cin: in std_logic;
	Cout: out std_logic;
	S: out std_logic_vector(n-1 downto 0)
);
end entity carry_ripple;

architecture cra of carry_ripple is
signal carry : std_logic_vector (n downto 0);
begin
	carry(0)<=Cin;
	kreni: for i in S'right to S'left generate
	begin
		cradder:entity full_adder(adder)
		port map(A(i),B(i),carry(i),S(i),carry(i+1));
	end generate kreni;
	Cout<=carry(n);
end architecture cra;

------------------------------------------------------

library ieee;
use ieee.std_logic_1164.all;


entity tb is
generic(n :integer :=8);
end entity tb;

architecture tb of tb is
signal A,B,S: std_logic_vector(n-1 downto 0);
signal Cin,Cout: std_logic;
begin
	uut:entity carry_ripple(cra)
	generic map (n)
	port map(A,B,Cin,Cout,S);
	
	process is
	begin
		A<="10101010";
		B<="00010111";
		Cin<='1';
		
		wait for 50 ns;
		
		A<="10000110";
		B<="00101011";
		Cin<='1';
		
		wait for 50 ns;
	end process;
end architecture;