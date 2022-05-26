library ieee;
use ieee.std_logic_1164.all;

entity PIPO is
generic (n:integer:=8);
port(
din:in std_logic_vector (n-1 downto 0);
clk,in_enable: in std_logic;
dout:out std_logic_vecotr(n-1 downto 0));
end entity PIPO;

architecture PIPO of (PIPO) is
signal mem:std_logic_vector (n-1 downto 0):=(others=>'0');
begin
	process (clk,in_enable) is
	begin
		if(in_enable ='1') then
			mem:=din;
		elsif(clk='1') then
			dout<=mem;
			mem:='0' & mem(n-1 downto 1);
		end if;
	end process;
end architecture PIPO;

library ieee;
use ieee.std_logic_1164.all;
use ieee.numeric_std.all;

entity counter is
generic(n : integer :=8);
port(clk,res: in std_logic;
q:out std_logic_vector(n-1 downto 0)
);
end entity counter;

architecture counter of counter is
begin
	process (clk,res) is
	variable count:integer(2**n-1 downto 0);
	begin
		count:=to_integer(unsgined(q));
		if(res='1')) then
			count:=0;
		elsif(clk='1') then
			if(count=2**n-1) then
				count:=0;
			else
				count:=count+1;
			end if;
		end if;
		
		q<=std_logic_vector(to_unsigned(count,n));
	end process;
end architecture counter;

library ieee;
use ieee.std_logic_1164.all;
use ieee.numeric_std.all;

entity kolo is
generic(generic_pattern:std_logic_vector(1 downto 0));
port(
clk,start: in std_logic;
ready:out std_logic;
data:in std_logic_vector(31 downto 0);
count:out std_logic_vector (5 downto 0)
);
end entity kolo;

architecture kolo of kolo is
signal dout:std_logic_vector (31 downto 0);
begin
	reg:entity PIPO(PIPO)
	generic map(32)
	port map(data,clk,start,dout);
	
	process is
	variable pattern:std_logic_vector(31 downto 0);
	variable mask:std_logic_vector(31 downto 0) := (others=>'0');
	variable c:integer range 31 downto 0;
	begin
		wait until start='1';
		
		ready<='0';
		pattern(1 downto 0):=generic_pattern;
		mask(1 downto 0):="11";
		count<=(others=>'0');
		c:=0;
		for i in 31 downto 0 loop
			if((dout and mask)=pattern) then
				c:=c+1;
			end if;
			pattern:=pattern(n-1 downto 1) & '0';
			wait until clk='1';
		end loop;
		
		ready<='1';
		count<=std_logic_vector(to_unsigned(c,n));
	end process;
end architecture kolo;

library ieee;
use ieee.std_logic_1164.all;

entity tb is
generic(generic_pattern:std_logic_vector(1 downto 0):="01");
end entity tb;

architecture tb of tb is
signal data:std_logic_vector(31 downto 0);
signal clk,start,ready:std_logic;
signal count:std_logic_vector(5 downto 0);
begin
	clkGen:process is
	begin
		clk<='0';
		loop
			wait for 50 ns;
			clk<=not clk;
		end loop;
	end process;
	
	uut:entity kolo(kolo)
	generic map(generic_pattern)
	port map(clk,start,ready,data,count);
	
	testBench:process is
	begin
		data<="00010001001001000001000100100100";
		start<='0', '1' after 10 ns;
	wait;
	end process;
end architecture tb;