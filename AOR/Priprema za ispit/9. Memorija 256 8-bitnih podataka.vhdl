library ieee;
use ieee.std_logic_1164.all;
use ieee.numeric_std.all;

entity mem is
port(
		r,w,clk: in bit;
		addr: in std_logic_vector (7 downto 0);
		din: in bit_vector(7 downto 0);
		dout: out bit_vector(7 downto 0)
);
end entity mem;

architecture mem of mem is
begin
	process is
	type bitMat is array(natural range<>) of bit_vector;
	variable store:bitMat (0 to 255)(7 downto 0);
	begin
		for i in 0 to 256 loop
			store(i):=(others=>'0');
		end loop;
		loop
			wait until clk='1';
			if(w='1') then
				store(to_integer(unsigned(addr))):=din;
			elsif (r='1') then
				dout<=store(to_integer(unsigned(addr)));
			end if;
		end loop;
	end process;
end architecture mem;

--------------------------------

library ieee;
use ieee.std_logic_1164.all;
--use ieee.numeric_std.all;

entity tb is
end entity tb;

architecture tb of tb is
signal r,w,clk : bit;
signal addr : std_logic_vector(7 downto 0);
signal din,dout : bit_vector (7 downto 0);

begin
	clk<=not clk after 50 ns;
	
	uut:entity mem(mem)
	port map(r,w,clk,addr,din,dout);
	
	process is
	begin
		r	<=	'0',
				'1' after 60 ns;
		w	<=	'1',
				'0' after 60 ns;
		din	<=	"10101111";
		addr<=	"00000101",
        		"00000001" after 180 ns;
	wait;
	end process;
end architecture tb;