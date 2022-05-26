---------------------------------------------------------
------------------------- DFF ---------------------------
---------------------------------------------------------

library ieee;
use ieee.std_logic_1164.all;

entity dff is
	port(
			clk,res,d 	: in std_logic;
			q			: out std_logic
		);
end entity dff;

architecture behavior of dff is
	begin
		q<='0' when (res='1')
        else d when (clk'event and clk='1');
end architecture behavior;

---------------------------------------------------------
------------------------ BUFFER -------------------------
---------------------------------------------------------

library ieee;
use ieee.std_logic_1164.all;

entity threeState is
	port(
			x,en	: in std_logic;
			y		: out std_logic
		);
end entity threeState;

architecture behavior of threeState is
	begin
		y<=x when (en='1')
		else 'Z';
end architecture behavior;

---------------------------------------------------------
-------------------------- REG --------------------------
---------------------------------------------------------

library ieee;
use ieee.std_logic_1164.all;

entity regThreeState is
	generic(n: integer :=8);
	port(
		clk,res,en	: in std_logic;
		Xin			: in std_logic_vector(n-1 downto 0);
		Yout		: out std_logic_vector(n-1  downto 0)
	);
end entity regThreeState;

architecture behavior of regThreeState is
	signal wire:std_logic_vector(n-1 downto 0);
	begin
		gen: for i in Xin'left downto Xin'right generate
			begin
				dff:entity dff(behavior)
				port map(clk,res,Xin(i),wire(i));
				
				threeState:entity threeState(behavior)
				port map(wire(i),en,Yout(i));
		end generate;
end architecture behavior;

---------------------------------------------------------
----------------------- TEST BENCH ----------------------
---------------------------------------------------------

library ieee;
use ieee.std_logic_1164.all;

entity tb is
	generic(n:integer :=8);
end entity tb;

architecture tb of tb is
	signal clk,res,en	: std_logic :='1';
	signal Xin,Yout		: std_logic_vector (n-1 downto 0)
	begin
		clk<=not clk after 20ns;
		
		dut:entity regThreeState(behavior)
		generic map (n)
		port map (clk,res,en,Xin,Yout);
		
		process is
			begin
				Xin<="10101100";
				en<='0';
				wait for 75 ns;
                res<='0';
				en<='1';
				wait for 50 ns;
				Xin<="10000011";
				en<='0';
				wait for 50 ns;
				en<='1';
				wait for 50 ns;
		end process;
end architecture tb;