entity counter is
generic (n: integer :=16);
port(
clk,res:in bit;
q:out integer range n-1 downto 0
);
end entity counter;

entity counter is
generic (n : integer := 16);
port(	clk,res:in bit;
		q:out integer range 0 to n-1	);
end entity counter;

architecture count of counter is
begin
	process is
	variable c_q:integer range 0 to n-1;
	begin
      loop
      	loop
        	wait until clk='1' or res='1';
            exit when res='1';
            if(c_q=15)then
            	c_q:=0;
            else
                c_q:=c_q+1;
            end if;
			q<=c_q;
        end loop;
		c_q:=0;
		q<=c_q;
        wait until res='0';
      end loop;
	end process;
end architecture count;

----------------------------------------------------

architecture countProsto of counter is
begin
	process (clk,res) is
	variable v_q:integer range n-1 downto 0;
	begin
		if(res='1') then
			v_q:=0;
			elsif(clk='1') then
				v_q:=(v_q+1)mod n;
		end if;
	end process;
end architecture countProsto;

---------------------------------------------------

entity tb is tb
generic(n:integer :=16)
end entity tb;

architecture tb of tb is
signal clk,res:bit;
signal q:integer range n-1 downto 0;

begin
	clk<=not clk after 50 ns;
	
	uut:entity counter(count)
	generic map(n)
	port map(clk,res,q);
	
	process is
	begin
		res<='0', '1' after 10 ns;
		wait;
	end process;
end architecture tb;