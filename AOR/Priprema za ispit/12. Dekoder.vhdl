library ieee;
use ieee.std_logic_1164.all;
use ieee.numeric_std.all;

entity decoder is
generic (n : integer:=4);
port(
	en:in std_logic;
	x:in std_logic_vector(n-1 downto 0);
	y:out std_logic_vector(0 to 2**n-1)
);
end entity decoder;

architecture decoder of decoder is
begin
	process (en,x) is
	variable ycp:std_logic_vector(0 to 2**n-1);
	begin
		ycp:=(others=>'1');
		if(en='1') then
			ycp(to_integer(unsigned(x))):='0';
		end if;
		y<=ycp;
	end process;
end architecture decoder;


------------------------------------------

library ieee;
use ieee.std_logic_1164.all;

entity tb is
generic (n :integer :=4);
end entity tb;

architecture tb of tb is
signal en : std_logic;
signal x:std_logic_vector(n-1 downto 0);
signal y:std_logic_vector(0 to 2**n-1);

begin
	uut:entity decoder(decoder)
	generic map(n)
	port map(en,x,y);
	
	process is
	begin
		en<='0', '1' after 10 ns, '0' after 100 ns;
		x<="0000";
        
        wait for 100 ns;
        en<='1', '0' after 100 ns;
		x<="0001";
        
        wait for 100 ns;
        en<='1', '0' after 100 ns;
		x<="0010";
        
        wait for 100 ns;
        en<='1', '0' after 100 ns;
		x<="0011";
        
        wait for 100 ns;
        en<='1', '0' after 100 ns;
		x<="0100";
        
        wait for 100 ns;
        en<='1', '0' after 100 ns;
		x<="0101";
        
        wait for 100 ns;
        en<='1', '0' after 100 ns;
		x<="0111";
        
        wait for 100 ns;
        en<='1', '0' after 100 ns;
		x<="1000";
        
        wait for 100 ns;
        en<='1', '0' after 100 ns;
		x<="1001";
        
        wait for 100 ns;
        en<='1', '0' after 100 ns;
		x<="1010";
        
        wait for 100 ns;
        en<='1', '0' after 100 ns;
		x<="1011";
        
        wait for 100 ns;
        en<='1', '0' after 100 ns;
		x<="1100";
        
        wait for 100 ns;
        en<='1', '0' after 100 ns;
		x<="1101";
        
        wait for 100 ns;
        en<='1', '0' after 100 ns;
		x<="1110";
        
        wait for 100 ns;
        en<='1', '0' after 100 ns;
		x<="1111";
        
	wait;
	end process;
end architecture tb;