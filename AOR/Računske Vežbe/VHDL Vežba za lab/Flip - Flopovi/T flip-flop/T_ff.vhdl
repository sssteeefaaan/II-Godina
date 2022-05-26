entity T_ff is
port(
	clock	:	in bit;
	reset	:	in bit;
	set		:	in bit;
	T		:	in bit;
	Q		:	out bit
);
end T_ff;

architecture asyncRE of T_ff is

	begin
		Q	<=	'0'		when	reset='1'
		else	'1'		when	set='1'
		else	not Q 	when	(clock'event	and	clock='1'	and T='1');

end architecture;--asyncRE

architecture asyncFE of T_ff is

	begin
		Q	<=	'0'		when	reset='1'
		else	'1'		when	set='1'
		else	not Q 	when	(clock'event	and	clock='0'	and T='1');

end architecture;--asyncRE

architecture syncRE of T_ff is

	begin
		Q	<=	Q		when	not (clock'event	and	clock='1')
		else	'0'		when	reset='1'
		else	'1' 	when	set='1'
		else	not Q	when	T='1';

end architecture;--asyncRE

architecture syncFE of T_ff is

	begin
		Q	<=	Q		when	not (clock'event	and	clock='0')
		else	'0'		when	reset='1'
		else	'1' 	when	set='1'
		else	not Q	when	T='1';

end architecture;--asyncRE