---------------------------------
---------- ANDCircuit -----------
---------------------------------

library ieee;
use ieee.std_logic_1164.all;

entity andcircuit is
	port(
			a,b	: in std_logic;
			f		: out std_logic
	);
end entity andcircuit;

architecture behavior of andcircuit is
	begin
		f<=a and b;
end architecture behavior;

-------------------------------
---------- ORCircuit ----------
-------------------------------

library ieee;
use ieee.std_logic_1164.all;

entity orcircuit is
	port(
			a,b	: in std_logic;
			f	: out std_logic
	);
end entity orcircuit;

architecture behavior of orcircuit is
	begin
		f<=a or b;
end architecture behavior;

-------------------------------
---------- NETWORK ------------
-------------------------------

library ieee;
use ieee.std_logic_1164.all;

entity network is
	generic(n:integer :=8);
	port (
			Ain,Bin	: in std_logic_vector(n-1 downto 0);
			Cin		: in std_logic;
			Fout	: out std_logic_vector(n-1 downto 0)
	);
end entity network;

architecture behavior of network is
	begin
		gen:for i in Fout'right to Fout'left generate
			signal wire : std_logic_vector(n-1 downto 0);
			begin
				ANDcompI:entity andcircuit(behavior)
					port map(Ain(i),Bin(i),wire(i));
				ORgen:if (i=wire'right) generate
					begin
						ORcomp0:entity orcircuit(behavior)
						port map(wire(i),Cin,Fout(i));
					else generate
						ORcompI:entity orcircuit(behavior)
						port map(wire(i),Fout(i-1),Fout(i));
				end generate;
		end generate;
end architecture behavior;

-----------------------------------
----------- TEST BENCH ------------
-----------------------------------

library ieee;
use ieee.std_logic_1164.all;

entity tb is
	generic (n:integer:=8);
end entity tb;

architecture tb of tb is
	signal sA,sB,sF	: std_logic_vector(n-1 downto 0);
	signal sC		: std_logic;
	begin
		dut:entity network(behavior)
		generic map(n)
		port map(sA,sB,sC,sF);
		
		process is
			begin
				sA<="00000000";
				sB<="00000000";
				sC<='0';
				wait for 10 ns;
				sA<="00000000";
				sB<="00000000";
				sC<='1';
				wait for 10 ns;
				sA<="11111111";
				sB<="00000000";
				sC<='0';
				wait for 10 ns;
				sA<="11111111";
				sB<="11111111";
				sC<='0';
                wait for 10 ns;
				sA<="10101010";
				sB<="11011011";
				sC<='0';
				wait for 10 ns;
				sA<="10101010";
				sB<="11011011";
				sC<='1';
				wait for 10 ns;
		end process;
end architecture;