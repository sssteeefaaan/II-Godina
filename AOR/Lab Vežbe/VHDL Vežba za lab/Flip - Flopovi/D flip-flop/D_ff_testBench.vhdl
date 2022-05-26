entity D_ff_testBench is
end D_ff_testBench;

architecture D_ff_testBench of D_ff_testBench is

signal 		sres	: bit;
signal		sD		: bit;
signal		sQ 		: bit;
signal 		clk 	: bit  :=	'0';
constant	half_T	: time :=	1 ns;
	
begin
	clk <= not clk after	2*half_T;
		
	UUT : entity D_ff (syncFE)
	port map(
		clock	=>	clk,
		reset	=>	sres,
		D		=>	sD,
		Q		=>	sQ);
	
	process is
	begin
		
		sres	<=	'1',
					'0' after 	3*half_T;
		sD		<= 	'1',
					'0' after	5*half_T,
					'1' after	6*half_T,
					'0' after	7*half_T,
					'1' after	9*half_T,
					'0' after	11*half_T;
					
	wait for 13*half_T;
	end process;
end architecture;--D_ff_testBench