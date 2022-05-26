---------------------------------------------------------
------------------------- DFF ---------------------------
---------------------------------------------------------

library ieee;
use ieee.std_logic_1164.all;

entity dff is
	port(
		clk,res,d	: in std_logic;
		q			: inout std_logic
	);
end entity dff;

architecture behavior of dff is
	begin
		process (clk,res) is
			begin
				if(res='1') then
					q<='0';
				elsif (clk'event and clk='1') then
					q<=d;
				end if;
		end process;
end architecture behavior;

---------------------------------------------------------
------------------------- SIPO --------------------------
---------------------------------------------------------

library ieee;
use ieee.std_logic_1164.all;

entity sipo is
	generic(n:integer:=8);
	port(
		clk,res,Din	: in std_logic;
		Qout		: inout std_logic_vector (n-1 downto 0)
	);
end entity sipo;

architecture behavior of sipo is
	begin
		gen:for i in Qout'left downto Qout'right generate
              begin
                  gen0:if (i=n-1) generate
                        begin
                            comp0:entity dff(behavior)
                            port map(clk,res,Din,Qout(n-1));
                        else generate
                            compI:entity dff(behavior)
                            port map(clk,res,Qout(i+1),Qout(i));
                  end generate;
		end generate;
end architecture behavior;

---------------------------------------------------------
-------------------- TEST BENCH -------------------------
---------------------------------------------------------

library ieee;
use ieee.std_logic_1164.all;

entity tb is
	generic(n:integer:=8);
end entity tb;

architecture tb of tb is
	signal clk,res	: std_logic:='0';
	signal Din		: std_logic;
	signal Qout		: std_logic_vector (n-1 downto 0);
	
	begin
		clk<=not clk after 50 ns;
		
		dut:entity sipo(behavior)
		generic map(n)
		port map(clk,res,Din,Qout);
		
		process is
			begin
				res<='1';
				wait for 10 ns;
				res<='0';
				Din<='X';
				wait for 100 ns;
				Din<='Z';
				wait for 100 ns;
				Din<='1';
				wait for 100 ns;
				Din<='X';
                wait for 100 ns;
				Din<='Z';
				wait for 800 ns;
		end process;
end architecture tb;

