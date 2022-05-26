library ieee;
use ieee.std_logic_1164.all

entity LeadingZeros is
generic(n:integer :=8);
port(
data: in std_logic_vector(n-1 downto 0);
zeros:out integer range 0 to n
);
end LeadingZeros;
 
 architecture behavior of LeadingZeros is
 begin
	 process(data)
		variable count: integer range 0 to n;
		begin
			count:=0;
			for i in data'range loop
				case data(i) is
					when '0' => count:=count + 1;
					when others => exit;
				end case;
			end loop;
			zeros <=count;
	end process;
 end architecture;
 
 ------------------------------------- testBench
 
 entity tb is
 generic(n:integer :=16);
 end tb;
 
 architecture tb of tb is
	signal sdata : std_logic_vector (n-1 down to 0);
	signal szeros : integer range 0 to n;
	
	begin
		n:=5;
		dut:entity LeadingZeros (behavior)
		port map(sdata,szeros)
		generic map(n);
		
		process is
			sdata<=
		end process;
 end architecture;