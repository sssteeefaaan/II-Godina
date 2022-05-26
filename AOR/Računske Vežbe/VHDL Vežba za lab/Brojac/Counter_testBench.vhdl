entity Counter_testBench is
end Counter_testBench;

architecture Counter_testBench of Counter_testBench is

	signal clk			: bit	:=	'0';
	signal sQ0,sQ1,sQ0	: bit;
	constant T_half		: time	:=	1ns;
	
	begin
		uut: entity three_bit_counter (arch)
		port map(clk,sQ0,sQ1,sQ2);
		
		clk	<=	not clk after 2*T_half;
		
		process is
		begin
			reset	<=	'1',
						'0' after T_half;
			
		wait for 30*T_half;
		end process;
end architecture;--Counter_testBench