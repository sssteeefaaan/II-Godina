entity dff is
port (d,res,clk : in bit;
q:out bit);
end entity dff;

architecture async of dff is
begin
	werk:process(clk,res) is
		begin
			if(res='1') then
				q<='0';
			elsif (clk'event and clk='1') then
				q<=d;
			end if;
		end process werk;
end architecture async;

architecture sync of dff is
begin
	q<= q when not (clk'event and clk='1')
	else '0' when res='1'
	else d;
end architecture sync;

------------------------------------------------------------------------

entity tb is
end entity tb;

architecture tb of tb is

signal d,q,res	:	bit;
signal clk		:	bit	:='0';

begin

	clk<=not clk after 50 ns;	-- perioda je 100ns;
	uut:entity dff(sync)
	port map(d,res,clk,q);
	
	werk: process is
	begin
		res	<=	'1',
				'0' after 10 ns;
		d	<=	'1',
				'0' after 20 ns,
				'1' after 60 ns,
				'0' after 90 ns,
				'1' after 120 ns,
				'0' after 160 ns;
        
	wait for 200 ns;
	end process werk;
end architecture tb;