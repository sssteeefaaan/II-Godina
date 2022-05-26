entity mem is
port(	
		addr: in integer range 0 to 63;
		r,w : in bit;
		din:in real;
		dout: out real
	);
end entity mem;

architecture behaviour of mem is
begin
	process is
	type values is array(integer range 0 to 63) of real;
	variable store : values; 
	begin
		for i in 0 to 63 loop
			store(i):=0.0;
		end loop;
		loop
			wait on r,w,din,addr;
			if(r='1')
				dout<=store(addr);
			elsif (w='1')
				store(addr):=din;
			end if;
		end loop;
	end process;
end architecture behaviour;

------------------------------------------------------

entity tb is
end entity tb;

architecture tb of tb is
signal r,w : bit;
signal addr: integer range 0 to 63;
signal din,dout: real;

begin
	uut:entity mem(behaviour)
	port(addr,r,w,din,dout);
	
	process is
	begin
		r	<=	'0',
				'1' after 30 ns;
		addr<=	5;
		w	<=	'1',
				'0' after 30 ns;
		din	<=	4.5;
	wait;
	end process;
end architecture tb;