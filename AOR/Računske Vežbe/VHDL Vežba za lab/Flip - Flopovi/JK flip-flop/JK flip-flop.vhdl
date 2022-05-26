entity JK_ff is
	port(
		clock	: in bit;
		reset	: in bit;
		set		: in bit;
		J		: in bit;
		K		: in bit;
		Q		: out bit
	);
end JK_ff;
	
architecture asyncRE of JK_ff is

	begin
		Q	<=		'0'		when 	((clock'event 	and		clock='1'	and		J='0'	and 	K='1')	or		reset='1')
			else	'1' 	when 	((clock'event 	and 	clock='1'	and		J='1'	and		K='0')	or		set='1')
			else	not Q	when 	(clock'event	and		clock='1'	and		J='1'	and		K='1');
			
end architecture;

architecture asyncFE of JK_ff is

	begin
		Q	<=		'0'		when 	((clock'event 	and		clock='0'	and		J='0'	and 	K='1')	or		reset='1')
			else	'1' 	when 	((clock'event 	and 	clock='0'	and		J='1'	and		K='0')	or		set='1')
			else	not Q	when 	(clock'event	and		clock='0'	and		J='1'	and		K='1');
			
end architecture;

architecture syncRE of JK_ff is

	begin
		Q	<=		'0'		when 	(clock'event 	and		clock='1'	and		((J='0'	and		K='1')	or		reset='1'))
			else	'1' 	when 	(clock'event 	and 	clock='1'	and		((J='1'	and		K='0')	or		set='1'))
			else	not Q	 when 	(clock'event	and		clock='1'	and		J='1'	and		K='1');
			
end architecture;

architecture syncFE of JK_ff is

	begin
		Q	<=		'0'		when 	(clock'event 	and		clock='0'	and		((J='0'	and		K='1')	or		reset='1'))
			else	'1' 	when 	(clock'event 	and 	clock='0'	and		((J='1'	and		K='0')	or		set='1'))
			else	not Q	when 	(clock'event	and		clock='0'	and		J='1'	and		K='1');
			
end architecture;