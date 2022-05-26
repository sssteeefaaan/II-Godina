library ieee;
use ieee.std_logic_1164.all;

entity reg is
generic (n:integer:=8);
port(clk,wr:in bit;
	din:in std_logic_vector (n-1 downto 0);
	q:out std_logic);
end entity reg;

architecture PISO of reg is
begin
	process is
	variable store : std_logic_vector(n-1 downto 0);
	begin
        wait until wr='1';
        store:=din;
        for i in n-1 downto 0 loop
        	wait until clk='1';
            q<=store(i);
       	end loop;
        wait until clk='1';
        q<='Z';
	end process;
end architecture PISO;

-------------------------------------------------

library ieee;
use ieee.std_logic_1164.all;

entity tb is
generic (n: integer :=8);
end entity tb;

architecture tb of tb is

signal clk,wr : bit;
signal din: std_logic_vector (n-1 downto 0);
signal q:std_logic;

begin
	clk<=not clk after 50 ns;
	
	uut:entity reg(PISO)
	generic map(n)
	port map(clk,wr,din,q);
	
	process is
	begin
		din	<=	"10010111";
		wr	<=	'1',
				'0' after 10 ns;
        wait for 1 us;
		din	<=	"01010101";
		wr	<=	'1',
				'0' after 10 ns;
        wait for 1 us;
		din	<=	"11100101";
		wr	<=	'1',
				'0' after 10 ns;
        wait for 1 us;
		din	<=	"10110010";
		wr	<=	'1',
				'0' after 10 ns;
	wait for 1 us;
	end process;
end architecture tb;