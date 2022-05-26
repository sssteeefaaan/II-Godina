library ieee;
use ieee.std_logic_1164.all;

entity nule is
generic(n : integer :=8);
port (
wr:in bit;
zeros: out integer range 0 to n;
din: in std_logic_vector(n-1 downto 0)
);
end entity nule;

architecture nule of nule is
begin
	process is
	variable z: integer range 0 to n;
	begin
		wait on wr;
		if(wr='1') then
			z:=0;
			while din(din'left - z)='0' loop
			z:=z+1;
			end loop;
		end if;
		zeros<=z;
	end process;
end architecture nule;

----------------------------------
library ieee;
use ieee.std_logic_1164.all;

entity tb is
generic (n:integer :=8);
end entity tb;

architecture tb of tb is
signal wr:bit;
signal zeros:integer range 0 to n;
signal din:std_logic_vector(n-1 downto 0);

begin
	uut:entity nule(nule)
	generic map (n)
	port map(wr,zeros,din);
	
	process is
	begin
		din<="00001111";
		wr<='1','0' after 10 ns;
		
		wait for 100 ns;
		
		din<="01010101";
		wr<='1', '0' after 10 ns;
		
		wait for 100 ns;
		
		din<="11010101";
		wr<='1', '0' after 10 ns;
	wait;
	end process;
end architecture tb;