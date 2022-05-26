entity 3_bit_counter is
port(
	clock	: in bit;
	reset	: in bit;
	Q0		: out bit;
	Q1		: out bit;
	Q2		: out bit);
end 3_bit_counter;

architecture arch of 3_bit_counter is
begin
  bit_vector'(Q2,Q1,Q0)	<= 	"000" 	when 	reset='1'
	else	(Q2,Q1,Q0)	<=	(Q2,Q1,Q0);
  					Q0	<=	not Q0 	when	(clock'event and clock='1' and reset='0');
					Q1	<=	not Q1 	when	( Q0'event and Q0='0' and reset='0');
					Q2	<=	not	Q2	when	( Q1'event and Q1='0' and reset='0');
						
end architecture;--arch