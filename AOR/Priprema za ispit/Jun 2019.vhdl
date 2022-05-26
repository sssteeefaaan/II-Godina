entity comp is
port(x1,x2: in bit;
e:out bit);
end entity comp;

architecture comp of comp is
begin
	e<=not(x1 xor x2);
end architecture comp;

entity andOr is
generic(n:integer:=8;
tip:bit:='1');
port(x: in bit_vector (n-1 downto 0);
y:out bit);
end entity andOr;

architecture andOr of andOr is
begin
	process is
	variable yand:bit :='1';
	variable yor:bit:='0';
	begin
    	wait on x;
		for i in n-1 downto 0 loop
			yand:=yand and x(i);
			yor:=yor or x(i);
		end loop;
		if(tip='1')then
			y<=yand;
		else
			y<=yor;
		end if;
	end process;
end architecture andOr;

entity nComp is
generic(n : integer :=8);
port(A,B:in bit_vector (n-1 downto 0);
E: out bit);
end entity nComp;

architecture nComp of nComp is
signal eq:bit_vector (n-1 downto 0);
begin
	kreni:for i in n-1 downto 0 generate
	begin
		compI:entity comp(comp)
		port map(A(i),B(i),eq(i));
		
	end generate kreni;
	
	izlaz:entity andOr(andOr)
    generic map(n, '1')
    port map(eq,E);
    
end architecture nComp;

entity pinTester is
generic (n : integer :=8);
port (PIN,INPUT : in bit_vector (n-1 downto 0);
clk:in bit;
tst:out bit);
end entity pinTester;

architecture pinTester of pinTester is
signal tester:bit;
begin
	
	nComparator:entity nComp(nComp)
	generic map (n)
	port map(PIN,INPUT,tester);
	
	process is
	begin
    	wait until clk='1';
		tst<=tester;
	end process;
	
end architecture pinTester;

architecture nCompMyWay of nComp is
begin
	process is
    variable index: integer range n-1 downto 0;
	begin
    	wait on A,B;
        index:=0;
        
    	petlja:for i in n-1 downto 0 loop
        	if(A(i) xor B(i)) then
            	index:=i;
                exit petlja;
            end if;
        end loop petlja;
       
        G<=(A(index) and (not B(index)));
        L<=(not A(index)) and B(index);
		E<=not(A(index) xor B(index));
	end process;
end architecture nCompMyWay;

-----------------------------------------------------------------------

entity tb is
generic(n:integer :=8);
end entity tb;

architecture tb of tb is
signal Pin,Input:bit_vector(n-1 downto 0);
signal right,clk:bit;
begin

	process is
    begin
    	clk<='0';
    	loop
        	wait for 50 ns;
            clk<=not clk;
        end loop;
    end process;
    
	uut:entity pinTester(pinTester)
	generic map(n)
	port map(Pin,Input,clk,right);
	
	process is
	begin
	
		Pin<="11100011";
		Input<="11100011";
		
		wait for 60 ns;
		
		Pin<="00100000";
		Input<="00000000";
		
		wait for 60 ns;
		
		Pin<="00000000";
		Input<="00010000";
		
		wait for 60 ns;
		
	end process;
end architecture tb;