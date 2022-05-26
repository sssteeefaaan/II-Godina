library ieee;
use ieee.std_logic_1164.all;
use ieee.numeric_std.all;

entity reg is
generic (n: integer:=8);
port (clk, res, wr, ce, dir : in bit;
din:in std_logic_vector (n-1 downto 0);
q:out std_logic_vector (n-1 downto 0));
end entity reg;

architecture brojacicaMawa of reg is
begin
	process (clk,res,wr,ce,dir)
	variable store:integer range 0 to (2**n - 1);
	begin
		if(res='1') then
			q<=(others=>'0');
		elsif(wr='1') then
			store:=to_integer(unsigned(din));
		elsif(clk='1') then
			if(ce='1') then
				if(dir='0') then
					if(store=2**n-1) then
						store:=0;
					else 
						store:=store+1;
					end if;
				else
					if(store=0) then
						store:=2**n-1;
					else 
						store:=store-1;
					end if;
				end if;
			end if;
			q<=std_logic_vector(to_unsigned(store,n));
		end if;
	end process;
end architecture brojacicaMawa;


--------------------------------------------------------------------

library ieee;
use ieee.std_logic_1164.all;
use ieee.numeric_std.all;

entity tb is
generic (n:integer :=8);
end entity tb;

architecture tb of tb is
signal clk, res, wr, ce, dir : bit;
signal din, q: std_logic_vector(n-1 downto 0);

begin
	clk<=not clk after 50 ns;
	
	uut:entity reg(brojacicaMawa)
	generic map(n)
	port map(clk, res, wr, ce, dir, din, q);
	
	process is
	begin
		res<='1', '0' after 10 ns;
		wr<='0', '1' after 20 ns, '0' after 30 ns;
		din<="00001111";
		ce<='1','0' after 3 us;
		dir<='0', '1' after 1 us;
	wait;
	end process;
	
end architecture tb;