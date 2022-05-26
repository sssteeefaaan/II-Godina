library ieee;
use ieee.std_logic_1164.all;

entity mux is
generic (n: integer :=8);
port(

a, b : in std_logic_vector (n downto 0);
x:in std_logic_vector (1 downto 0);
y:out std_logic_vector (n downto 0)

);
end entity mux;

architecture exclusive of mux is
begin
	werk: process (a, b, x) is
	begin
		if(x="00") then 
        	y<= (others=>'0');
			elsif(x="01") then
            	y<=a;
			elsif(x="10") then
            	y<=b;
			elsif (x="11") then
				y<= (others=>'Z');
		end if;
	end process werk;
end architecture exclusive;

---------------------------------------------------------------

library ieee;
use ieee.std_logic_1164.all;

entity tb is
generic (n: integer :=8);
end entity tb;

architecture tb of tb is

signal a,b,y	:	std_logic_vector (n downto 0);
signal x		:	std_logic_vector (1 downto 0);

begin
	uut:entity mux(exclusive)
	generic map(n)
	port map(a,b,x,y);
	
	werk: process is
	begin
		a	<=	"101000111";
		b	<=	"100001001";
		
		x	<=	"00",
        "11" after 50 ns,
        "01" after 100 ns,
        "10" after 150 ns;
        
	wait for 200 ns;
	end process werk;
end architecture tb;