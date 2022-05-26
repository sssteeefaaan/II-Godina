---------------------------------------------------------------------
---------------------------------------------------------------------
------------------------------1. NAČIN-------------------------------
---------------------------------------------------------------------
---------------------------------------------------------------------

LIBRARY IEEE;
USE IEEE.STD_LOGIC_1164.ALL;

ENTITY FULL_ADDER IS
PORT(
	A,B,Cin : IN STD_LOGIC;
	S,Cout : OUT STD_LOGIC
);
END FULL_ADDER;

ARCHITECTURE FULL_ADDER_COMP OF FULL_ADDER IS
	BEGIN
		S<= (A XOR B) XOR Cin;
		Cout<= ((A XOR B) AND Cin) OR (A AND B);
END FULL_ADDER_COMP;

-------------------------------------------

LIBRARY IEEE;
USE IEEE.STD_LOGIC_1164.ALL;

ENTITY CARRY_RIP IS
GENERIC(N : NATURAL :=8);
PORT(
		Xin,Yin : IN STD_LOGIC_VECTOR (N-1 DOWNTO 0);
		Cin	: IN STD_LOGIC;
        Cout : OUT STD_LOGIC;
		Sout: OUT STD_LOGIC_VECTOR (N-1 DOWNTO 0)
	);
END ENTITY CARRY_RIP;

ARCHITECTURE CARRY_COMP OF CARRY_RIP IS
	SIGNAL CARRY : STD_LOGIC_VECTOR (N DOWNTO 0);
    SIGNAL SUM : STD_LOGIC_VECTOR (N-1 DOWNTO 0);
BEGIN
	CARRY(0)<=Cin;
	GEN: FOR INDEX IN 0 TO N-1 GENERATE
		BEGIN
          COMP1: ENTITY FULL_ADDER(FULL_ADDER_COMP)
          PORT MAP(Xin(INDEX),Yin(INDEX),CARRY(INDEX),SUM(INDEX),CARRY(INDEX+1));
	END GENERATE;
    Sout<=SUM;
    Cout<=CARRY(N);
END ARCHITECTURE CARRY_COMP;



-----------------------------------------------------------------------
-----------------------------------------------------------------------
--------------------------------2. NACIN-------------------------------
-----------------------------------------------------------------------
-----------------------------------------------------------------------

LIBRARY IEEE;
USE IEEE.STD_LOGIC_1164.ALL;

ENTITY FULL_ADDER IS
PORT(
	A,B,Cin : IN STD_LOGIC;
	S,Cout : OUT STD_LOGIC
);
END FULL_ADDER;

ARCHITECTURE FULL_ADDER_COMP OF FULL_ADDER IS
	BEGIN
		S<= (A XOR B) XOR Cin;
		Cout<= ((A XOR B) AND Cin) OR (A AND B);
END FULL_ADDER_COMP;

-------------------------------------------

LIBRARY IEEE;
USE IEEE.STD_LOGIC_1164.ALL;

ENTITY CARRY_RIP IS
GENERIC(N : NATURAL :=8);
PORT(
		Xin,Yin : IN STD_LOGIC_VECTOR (N-1 DOWNTO 0);
		Cin	: IN STD_LOGIC;
       -- Cout : OUT STD_LOGIC;
		Sout: OUT STD_LOGIC_VECTOR (N DOWNTO 0)
	);
END ENTITY CARRY_RIP;

ARCHITECTURE CARRY_COMP OF CARRY_RIP IS
	SIGNAL CARRY:STD_LOGIC_VECTOR(N-1 DOWNTO 0);
BEGIN
	GEN: FOR INDEX IN 0 TO N-1 GENERATE
		BEGIN
        	COND1: IF (INDEX=0) GENERATE
            	BEGIN
                	COMP0:ENTITY FULL_ADDER(FULL_ADDER_COMP)
                    PORT MAP(Xin(INDEX),Yin(INDEX),Cin,Sout(INDEX),CARRY(INDEX));
                    
                    ELSE GENERATE
                    	COMPI: ENTITY FULL_ADDER(FULL_ADDER_COMP)
            			PORT MAP(Xin(INDEX),Yin(INDEX),CARRY(INDEX-1),Sout(INDEX),CARRY(INDEX));
            END GENERATE;
	END GENERATE;
    Sout(N)<=CARRY(N-1);
END ARCHITECTURE CARRY_COMP;


--------------------------------------------------------------------
--------------------------------------------------------------------
------------------------3. NAČIN, BEZ IF----------------------------
--------------------------------------------------------------------
--------------------------------------------------------------------

LIBRARY IEEE;
USE IEEE.STD_LOGIC_1164.ALL;

ENTITY FULL_ADDER IS
PORT(
	A,B,Cin : IN STD_LOGIC;
	S,Cout : OUT STD_LOGIC
);
END FULL_ADDER;

ARCHITECTURE FULL_ADDER_COMP OF FULL_ADDER IS
	BEGIN
		S<= (A XOR B) XOR Cin;
		Cout<= ((A XOR B) AND Cin) OR (A AND B);
END FULL_ADDER_COMP;

-------------------------------------------

LIBRARY IEEE;
USE IEEE.STD_LOGIC_1164.ALL;

ENTITY CARRY_RIP IS
GENERIC(N : NATURAL :=8);
PORT(
		Xin,Yin : IN STD_LOGIC_VECTOR (N-1 DOWNTO 0);
		Cin	: IN STD_LOGIC;
       -- Cout : OUT STD_LOGIC;
		Sout: OUT STD_LOGIC_VECTOR (N DOWNTO 0)
	);
END ENTITY CARRY_RIP;

ARCHITECTURE CARRY_COMP OF CARRY_RIP IS
	SIGNAL CARRY:STD_LOGIC_VECTOR(N-1 DOWNTO 0);
BEGIN
	
	COMP0: ENTITY FULL_ADDER(FULL_ADDER_COMP)
	PORT MAP(Xin(0),Yin(0),Cin,Sout(0),CARRY(0));
	
	GEN: FOR INDEX IN 1 TO N-1 GENERATE
		BEGIN
            COMPI: ENTITY FULL_ADDER(FULL_ADDER_COMP)
			PORT MAP(Xin(INDEX),Yin(INDEX),CARRY(INDEX-1),Sout(INDEX),CARRY(INDEX));
	END GENERATE;
    Sout(N)<=CARRY(N-1);
END ARCHITECTURE CARRY_COMP;

--------------------------------------------------------------
--------------------------------------------------------------
-----------------------TESTBENCH------------------------------
--------------------------------------------------------------
--------------------------------------------------------------

LIBRARY IEEE;
USE IEEE.STD_LOGIC_1164.ALL;

ENTITY TB IS
GENERIC (N: INTEGER :=8);
END ENTITY TB;

ARCHITECTURE TB OF TB IS
	SIGNAL SXin,SYin : STD_LOGIC_VECTOR (N-1 DOWNTO 0);
    SIGNAL SCin : STD_LOGIC;
    SIGNAL SSout:STD_LOGIC_VECTOR (N DOWNTO 0);
    
BEGIN
	DUT: ENTITY CARRY_RIP (CARRY_COMP)
    GENERIC MAP(N)
    PORT MAP(SXin,SYin,SCin,SSout);
    
	PROCESS IS
    BEGIN
    SXin<="01010101";
    SYin<="00100101";
    SCin<='1';
    WAIT FOR 10 NS;
    SXin<="00111001";
    SYin<="01111111";
    SCin<='0';
    WAIT FOR 10 NS;
    SXin<="00010001";
    SYin<="00110011";
    SCin<='1';
    WAIT FOR 10 NS;
    END PROCESS;
END ARCHITECTURE;