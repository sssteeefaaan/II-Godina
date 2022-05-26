----------Nemam snage ovo da probam
---------- U drugom zivotu maybe
library ieee;
use ieee.std_logic_1164.all;
use ieee.numeric_std.all;

entity counter is
generic(n : integer n:=8);
port(res,clk : in std_logic;
qout: out std_logic_vector (n-1 downto 0));

architecture counter of counter is
begin
	process (clk,res) is
	variable count:integer range 2**n-1 downto 0;
	begin
		count:=to_integer(unsigned(qout));
		if(res='1') then
			count:0;
		elsif(clk='1') then
			if(count=2**n-1) then
				count:=0;
			else
				count:=count+1;
			end if;
		end if;
		qout<=std_logic_vector(to_unsigned(count,n));
	end process;
end architecture counter;

library ieee;
use ieee.std_logic_1164.all;
use ieee.numeric_std.all;

entity memory is
generic(n : integer :=8;
		m : integer :=8);
port(clr,clk,we : std_logic;
addr: in std_logic_vector(n-1 downto 0);	-- 2**n razlicitih adresa
din: in std_logic_vector (m-1 downto 0);	-- svaka adresa cuva m bits
qout: out std_logic_vector (m-1 downto 0)
);
end entity memory;

architecture memory of memory is
begin
	process (clk,clr,we,addr,din) is
	type memorija is array(natural range<>) of std_logic_vector;
	variable store: memorija(2**n-1 downto 0)(m-1 downto 0);
	begin
		if(clr='1') then
			for i in 2**n-1 downto 0 loop
				store(i):=(others=>'0');
			end loop;
		elsif (clk = '1') then
			if(we='1') then
				store(to_integer(unsigned(addr))):=din;
			else
				qout<=store(to_integer(unsigned(addr)));
			end if;
		end if;
	end process;
end architecture memory;

library ieee;
use ieee.std_logic_1164.all;

entity buff is
generic(n : integer:=8);
port(en:in std_logic;
din:in std_logic_vector(n-1 downto 0);
qout : out std_logic_vector(n-1 downto 0)
);
end entity buff;

architecture buff of buff is
begin
	qout<=d when en='1';
end architecture buff;

library ieee;
use ieee.std_logic_1164.all;

entity full_adder is
port(a,b,cin:in std_logic;
	s,cout: out std_logic);
end entity full_adder;
			
architecture full_adder of full_adder is
begin
	cout<=(a and b) or (cin and (a xor b));
	s<=a xor b xor c;
end architecture full_adder;

library ieee;
use ieee.std_logic_1164.all;

entity carry-ripple is
generic(n : integer :=8);
port(	A,B: std_logic_vector (n-1 downto 0);
		S:std_logic_vector (n downto 0)
	);
end entity carry-ripple;

architecture carry-ripple of carry-ripple is
signal carry:std_logic_vector(n downto 0);
begin
	carry(0)<='0';
	kreni: for i in 0 to n-1 generate
	begin
		dev:entity full_adder(full_adder)
		port map(A(i),B(i),carry(i),S(i),carry(i+1));
	end generate;
	S<=carry(n) & S(n-1 downto 0);
end architecture carry-ripple;

library ieee;
use ieee.std_logic_1164.all;
use ieee.natural_std.all;

entity MasterMind is
generic (n : integer :=8);
port(
we,clk,reset: in std_logic
addr : in std_logic_vector (n-1 downto 0);
counterReset,memoryClear,memoryWrite,buffWr1,buffWr2 : out std_logic
);
end entity MasterMind;

architecture MasterMind of MasterMind is
type state is(WriteMem,Read1,Read2,Start);
signal currentState,nextState : state;
signal async1,async2 : std_logic;
begin
	
	stateChange: process (reset,clk) is
	begin
		if(reset='1') then
			currentState<=Start;
		elsif(clk'event and clk='1') then
			buffWr1<=async1;
			buffWr2<=async2;
			currentState<=nextState;
		end if;
	end process stateChange;
	
	stateLogic: process (we,addr,currentState)
	begin
		case currentState is
			when Start =>
				counterReset<='1';
				memoryWrite<='0';
				async1<='0';
				async2<='0';
				if(we='1') then
					memoryClear<='1';
					nextState<=WriteMem;
				elsif (we='0') then
					nextState<=Read1;
				end if;
				
			when WriteMem =>
				memoryClear<='0';
				memoryWrite<='1';
				counterReset<='0';
				if(we='1') then
					nextState<=WriteMem;
				elsif(we='0') then
					nextState<=Start;
				end if;
			
			when Read1 =>
				counterReset<='0';
				async1<='1';
				async2<='0';
				if(we='0') then
					nextState<= Read2;
				elsif(we='1') then
					nextState<=Start;
				end if;
				
			when Read2 =>
				async1<='0';
				async2<='1';
				if(we='0') then
					nextState<=Read1;
				elsif(we='1') then
					nextState<=Start;
				end if;
		end case;
	end process stateLogic;
end architecture MasterMind;



library ieee;
use ieee.std_logic_1164.all;
use ieee.natural_std.all;

entity NewMachina is
generic(n : integer :=8;
		m: integer :=8);
port(we,reset,clk : in std_logic;
din: in std_logic_vector(n-1 downto 0);
qout: out std_logic_vector(n downto 0));
end entity NewMachina;

architecture NewMachina of NewMachina is
signal counterReset,MemoryWrite,MemoryClear,buff1,buff2:std_logic;
signal addr,podaci,op1,op2 :std_logic_vector (n-1 downto 0);
begin

	brojac: entity counter(counter)
	generic map(n)
	port map(clk,mag1);
	
	memorija: entity memory(memory)
	generic map(m,n)
	port map(MemoryClear,clk,MemoryWrite,addr,din,podaci);
	
	buff1: entity buff(buff)
	generic map(n)
	port map(buff1,podaci,op1);
	
	buff2: entity buff(buff)
	generic map(n)
	port map(buff2,podaci,op2);
	
	sabirac:entity carry-ripple(carry-ripple)
	generic map(n)
	port map(op1,op2,qout);
	
	kontrolnaJedinica:entity MasterMind(MasterMind)
	generic map(n)
	port map(we,clk,reset,addr,counterReset,memoryClear,memoryWrite,buff1,buff2);
	
end architecture NewMachina;