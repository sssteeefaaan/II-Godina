entity dff is
port(
d,clk,res : in bit;
q:out bit
);
end entity dff;

architecture dff of dff is
begin
	process (res,clk)
	begin
		if(res='1') then
			q<='0';
		elsif(clk='1') then
			q<=d;
		end if;
	end process;
end architecture dff;

library ieee;
use ieee.std_logic_1164.all;

entity TSB is
port(x: in bit;
	c: in bit;
	y: out std_logic);
end entity TSB;

architecture TSB of TSB is
begin
	y<='Z' when c='1'
	else x;
end architecture TSB;

library ieee;
use ieee.std_logic_1164.all;

entity reg is
generic(n:integer:=8);
port (Din: in bit_vector(n-1 downto 0);
	res,clk,c: in bit;
	Q: out std_logic_vector(n-1 downto 0));
end entity reg;

architecture reg of reg is
begin
	kreni: for i in Q'range generate
	variable zicka:bit;
	begin
		devDFF:entity dff(dff)
		port map(Din(i),clk,res,zicka);
		
		devTSB:entity TSB(TSB)
		port map(zicka,c,Q(i));
	end generate;
end architecture reg;

-----------------------------------

library ieee;
use ieee.std_logic_1164.all;

entity tb is
generic (n:integer :=8);
end entity tb;

architecture tb of tb is
signal Din:bit_vector (n-1 downto 0);
signal Q:std_logic_vector(n-1 downto 0);
signal res,clk,c:bit(n-1 downto 0);
begin
	clk<=not clk after 50 ns;
	
	uut:entity reg(reg)
	generic map(n)
	port map(Din,res,clk,c,Q);
	
	process is
	begin
		res<='0' , '1' after 10 ns;
		Din<="10101011";
		c<='0' , '1' after 120 ns;
	wait for 200 ns;
	end process;
end architecture tb;