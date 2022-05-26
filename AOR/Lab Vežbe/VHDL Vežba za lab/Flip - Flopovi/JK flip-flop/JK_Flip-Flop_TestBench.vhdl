entity JK_ff_testBench is
end JK_ff_testBench;

architecture JK_ff_testBench of JK_ff_testBench is

	signal 		sres	:	bit;
	signal		sset	:	bit;
	signal		sJ		:	bit;
	signal		sK		:	bit;
	signal		sQ 		:	bit;
	signal 		sclock 	:	bit 	:=	'0';
	constant	half_T	:	time	:=	1 ns;
	
	begin
		sclock	<=	not	sclock	after	2*half_T;
		
		UUT	:	entity	JK_ff	(asyncRE)
			port map(
					clock	=>	sclock,
					reset	=>	sres,
					set	=>	sset,
					J	=>	sJ,
					K	=>	sK,
					Q	=>	sQ	);
		
		process is
		begin
			
			sres	<=	'1',
						'0'	after half_T;
			sJ		<=	'0',
						'1'	after	half_T,
						'0'	after	3*half_T,
						'1' after	5*half_T,
						'0'	after	7*half_T,
						'1'	after	8*half_T;
			sK		<=	'0',
						'1'	after	3*half_T,
						'0'	after	4*half_T,
						'1' after	5*half_T,
						'0'	after	7*half_T,
						'1'	after	9*half_T;
			wait for 12*half_T;
			
		end process;
	
end architecture;