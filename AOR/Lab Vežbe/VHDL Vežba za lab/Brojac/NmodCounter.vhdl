entity counterModN is
	generic (n : natural range 1 to 1024 :=8);
	port
	(
	clk,we,ce	: in bit;
	d_in		: in natural range 0 to 1023;
	q_out		: out natural range 0 to 1023
	);
end entity counterModN;

architecture arch of counterModN is

begin

	process is
		variable pom	: natural range 0 to 1024;
	begin
	
		if(we='1') then
			pom:=d_in;
		elsif (clk'event and clk='1') then
			if(ce='1') then
				pom:=(pom+1) mod n;
			end if;
		end if;
		
		q_out<=pom;
        
	wait on clk,we;
	end process;
	
end architecture;

entity tb is
	generic(tN : natural range 1 to 1024 := 6);
end entity tb;

architecture tb of tb is
	signal s_clk 	: bit := '0';
	signal s_ce,s_we	: bit;
	signal s_din, s_qout	: natural range 0 to 1024;

begin
	dut:entity counterModN (arch)
    generic map(n=>tN)
	port map(s_clk,s_we,s_ce,s_din,s_qout);
	
	s_clk<=not s_clk after 50ns;
    
	process is
    	begin
		s_we<='1';
        		s_din<=3;
		wait for 15 ns;
       		s_we<='0';
		s_ce<='1';
		wait for 300 ns;
		s_we<='1';
		s_din<=5;
        		wait for 15 ns;
        		s_we<='0';
       		s_ce<='0';
        		wait for 150 ns;
        		s_ce<='1';
		wait for 500 ns;
		
	end process;
end architecture;--tb