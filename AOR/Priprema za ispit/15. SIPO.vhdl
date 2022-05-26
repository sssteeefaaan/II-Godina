library ieee;
use ieee.std_logic_1164.all;

entity dff is
port(res,clk,din : in std_logic;
q:out std_logic);
end entity dff;

architecture dff of dff is
begin
	q<='0' when res='1'
	else din when clk'event and clk='1';
end architecture dff;

library ieee;
use ieee.std_logic_1164.all;

entity SIPO is
generic(n : integer :=8);
port (clk,res,Din: in std_logic;
Q:out std_logic_vector(n-1 downto 0));
end entity SIPO;

architecture SIPO of SIPO is
signal qTemp : std_logic_vector (n-1 downto 0);
begin
	qTemp<=Q;
	kreni: for i in qTemp'range generate
	begin
		uslov0: if(i=qTemp'left) generate
		begin
			regLeft:entity dff(dff)
			port map(res,clk,din,Q(i));
		end generate uslov0;
        
        uslov: if (i/=qTemp'left) generate
		begin
			reg:entity dff(dff)
			port map(res,clk,qTemp(i+1),Q(i));
            
		end generate uslov;
	end generate kreni;
end architecture SIPO;

----------------------------------------

library ieee;
use ieee.std_logic_1164.all;

entity tb is
generic (n:integer :=8);
end entity tb;

architecture tb of tb is
signal Q: std_logic_vector(n-1 downto 0);
signal res,clk,Din: std_logic;
begin
	clockGen:process
    begin
    	clk<='0';
        loop
        wait for 50 ns;
        clk<=not clk;
        end loop;
    end process clockGen; -- Guess what, it will never end mu ha ha ha ha!
    
	uut:entity SIPO(SIPO)
	generic map(n)
	port map(clk,res,Din,Q);
	
	process is
	begin
		res<='1' , '0' after 10 ns;
		Din<='1','0' after 260 ns, '1' after 620 ns, '0' after 880 ns;
	wait;
	end process;
end architecture tb;