------------------------------------------
----------------- KOLO -------------------
------------------------------------------

library ieee;
use ieee.std_logic_1164.all;

entity circuit is
	port(
			a,b,c	: in std_logic;
			f		: out std_logic
	);
end entity;

architecture funct of circuit is
	begin
		f<=(a xor b) or c;
end architecture;
 
------------------------------------------
----------------- MREZA ------------------
------------------------------------------

library ieee;
use ieee.std_logic_1164.all;

entity network is
	generic (n:integer :=8);
	port(
			A		: in std_logic;
			B,C		: in std_logic_vector (n-1 downto 0);
			F		: out std_logic_vector (n-1 downto 0)
	);
end entity;

architecture behavior of network is
	begin
		compN:entity circuit (funct)
			port map(A,B(n-1),C(n-1),F(n-1));
			
		gen: for i in F'left-1 downto F'right generate
			compI:entity circuit (funct)
				port map(F(i+1),B(i),C(i),F(i));
		end generate;
end architecture;

------------------------------------------
--------------- TEST BENCH ---------------
------------------------------------------

library ieee;
use ieee.std_logic_1164.all;

entity tb is
generic (n : integer :=8);
end tb;

architecture tb of tb is

	signal sA 		: std_logic;
	signal sB,sC,sF	: std_logic_vector (n-1 downto 0);
	
	begin
		dut:entity network(behavior)
			generic map(n)
			port map(sA,sB,sC,sF);
			
		process is
			begin
				sA<='1';
				sB<="11010101";
				sC<="10100100";
				wait for 10ns;
		end process;
end architecture;