entity D_ff is
port(
	clock	: in bit;
	reset	: in bit;
	D		: in bit;
	Q		: out bit
);
end D_ff;

architecture syncFE of D_ff is
begin
	process (clock) is
	begin					--nije potrebno da se proverava clock'event
		if(clock='0')		--jer se process nece PONOVO izvrsiti,
		then				--dok se ne desi clock'event, jer se nalazi
			if(reset='1')	--u sensitivity listi
			then Q	<=	'0';
			else
				Q	<=	D;
			end if;
		end if;
	--wait on clock;
	end process;
end architecture;