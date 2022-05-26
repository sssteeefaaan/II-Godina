entity reg is
port(clk,res: in bit;
q:out bit_vector(3 downto 0)
);
end entity reg;

architecture brojac of reg is
begin
	process (clk,res) is
	variable test: bit;
	variable v_q : bit_vector(3 downto 0);
	begin
		if(res='1') then
			v_q:=(others=>'0');
			test:='0';
            
			elsif(clk='1') then
				test:=not test;
				if(test='1') then
					case v_q is
						when "0000" => v_q:="0001";
						when "0001" => v_q:="0010";
						when "0010" => v_q:="0011";
						when "0011" => v_q:="0100";
						when "0100" => v_q:="0101";
						when "0101" => v_q:="0110";
						when "0110" => v_q:="0111";
						when "0111" => v_q:="1000";
						when "1000" => v_q:="1001";
						when others => v_q:="0000";
					end case;
				end if;
		end if;
		q<=v_q;
	end process;
end architecture brojac;

------------------------------------------

entity tb is
end entity tb;

architecture tb of tb is
signal clk,res:bit;
signal q:bit_vector (3 downto 0);
begin

	uut:entity reg(brojac)
	port map(clk,res,q);
	
	process is
	begin
		res	<=	'1',
				'0' after 10 ns;
       wait;
	end process;
    
    clk	<=	not clk after 50 ns;
    
end architecture tb;