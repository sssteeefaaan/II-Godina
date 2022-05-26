library ieee;
use ieee.std_logic_1164.all;
use ieee.std_logic_unsigned.all;

entity Memorija is
port (
		we,clk : in std_logic;
    	addr,data : in std_logic_vector (7 downto 0);
      	q : out std_logic_vector (7 downto 0);
        rammemory :  out std_logic_vector);
end Memorija;

architecture Behavioral of Memorija is

type ram_mem_type is array (255 downto 0) of std_logic_vector(7 downto 0);
signal rammem : ram_mem_type;
begin
process(clk)
  variable addrtemp: integer range 255 downto 0;
  begin
    if(clk'event and clk='0') then
      addrtemp := conv_integer(addr);
      if(we='1') then
        rammem(addrtemp) <= data;
      end if;
      addrOut<=addrtemp;
      q<= rammem(addrtemp);
	end if;

end process;

end architecture Behavioral;

----------------------------- testbench

library ieee;
use ieee.std_logic_1164.all;
use ieee.std_logic_unsigned.all;

entity tb is
end tb;

architecture tb of tb is

signal swe,sclk: std_logic :='1';
signal saddr,sdata,sq : std_logic_vector (7 downto 0);
signal saddrout : integer range 255 downto 0;

begin
	dut: entity Memorija (Behavioral)
    port map(swe,sclk,saddr,sdata,sq, saddrout);
    
    sclk<=not sclk after 50ns;
    process is
    begin
      saddr<="11111111";
      sdata<="00000011";
      wait for 75ns;
      sdata<="00000111";
      wait for 100ns;
    end process;
end architecture;