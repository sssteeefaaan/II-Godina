entity T_ff_testBench is
end T_ff_testBench;

architecture T_ff_testBench of T_ff_testBench is

	signal 		sres	:	bit;
	signal		sset	:	bit;
	signal		sT		:	bit;
	signal		sQ 		:	bit;
	signal 		sclock 	:	bit 	:=	'0';
	constant	half_T	:	time	:=	1 ns;
	
	begin
		sclock	<=	not	sclock	after	2*half_T;
		
		UUT	:	entity	T_ff	(syncRE)
			port map(
					clock	=>	sclock,
					reset	=>	sres,
					set	=>	sset,
					T	=>	sT,
					Q	=>	sQ	);
		
		process is
		begin
			
			sres	<=	'1',
						'0'	after 3*half_T;
			sT		<=	'0',
						'1'	after	half_T,
						'0'	after	3*half_T,
						'1' after	5*half_T,
						'0'	after	7*half_T,
						'1'	after	8*half_T;
			wait for 13*half_T;
			
		end process;
	
end architecture;