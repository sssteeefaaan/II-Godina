LIBRARY 	ieee;
USE ieee.std_logic_1164.ALL;

entity SR_ff is
port(
	clock	: in bit;
	reset	: in bit;
	set		: in bit;
	S		: in bit;
	R		: in bit;
	Q		: out std_logic
	);
end SR_ff;

architecture asyncRE of SR_ff is

	begin
	
		Q	<=	Q	when	(clock'event and clock='1'	and		S='0' and R='0')
		else	'0'	when	(clock'event and clock='1'	and		S='0' and R='1')	or	reset='1'
		else	'1'	when	(clock'event and clock='1'	and		S='1' and R='0')	or	set='1'
		else	'X'	when	(clock'event and clock='1'	and		S='1' and R='1');
		
end architecture;--asyncRE

architecture asyncFE of SR_ff is

	begin
	
		Q	<=	Q	when	(clock'event and clock='0'	and		S='0' and R='0')
		else	'0'	when	(clock'event and clock='0'	and		S='0' and R='1')	or	reset='1'
		else	'1'	when	(clock'event and clock='0'	and		S='1' and R='0')	or	set='1'
		else	'X'	when	(clock'event and clock='0'	and		S='1' and R='1');
		
end architecture;--asyncFE

architecture asyncProcRE of SR_ff is
	begin
		process (clock,reset,set) is
			begin
				
				if	(reset='1')
					then	Q	<=	'0';
					
				elsif (set='1')
					then	Q	<=	'0';
					
				else	(clock'event and clock='1')
					then	if		(S='0' and R='0')
								then	Q	<=	Q;
							
							elsif	(S='0' and R='1')
								then	Q	<=	'0';
							
							elsif	(S='1' and R='0')
								then	Q	<=	'1';
							
							else	(S='1' and R='1')
								then	Q	<=	'x';
							
							end if;
				end if;
				
		end process;
end architecture;--asyncProcRE

architecture asyncProcFE of SR_ff is
	begin
		process (clock,reset,set) is
			begin
				
				if	(reset='1')
					then	Q	<=	'0';
					
				elsif (set='1')
					then	Q	<=	'0';
					
				else	(clock'event and clock='0')
					then	if		(S='0' and R='0')
								then	Q	<=	Q;
							
							elsif	(S='0' and R='1')
								then	Q	<=	'0';
							
							elsif	(S='1' and R='0')
								then	Q	<=	'1';
							
							else	(S='1' and R='1')
								then	Q	<=	'x';
							
							end if;
				end if;
				
		end process;
end architecture;--asyncProcFE