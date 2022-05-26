entity JKff is
  port (
    clock   : in bit;
    J       : in bit;
    K       : in bit;
    ares    : in bit;
    aset    : in bit
  ) ;
end entity JKff;

architecture asyncRE of JKff is
begin
    process (clock,ares,aset)is
    begin
        if(ares='1')
            then q<='0';
            elsif (aset='1')
            then q<='1';
            elsif(clock'event and clock='1')
                then 
                with bit_vector'(J,K) select
                q   <=  q       when    "00",
                        0       when    "01",
                        1       when    "10",
                        not q   when    "11";
        end if;
    end process;
end architecture ; -- asyncRE

architecture asyncFE of JKff is
    begin
    process (clock,ares,aset)is
    begin
        if(ares='1')
            then q<='0';
            elsif (aset='1')
            then q<='1';
            elsif(clock'event and clock='0')
                then 
                with bit_vector'(J,K) select
                q   <=  q       when    "00",
                        0       when    "01",
                        1       when    "10",
                        not q   when    "11";
        end if;
    end process;
end architecture ; -- asyncFE

architecture syncRE of JKff is
begin
    process (clock) is
    begin
        if (clock'event and clock='1')
            then 
            with bit_vector'(J,K) select
            q   <=  q       when    "00",
                    0       when    "01",
                    1       when    "10",
                    not q   when    "11";
            elsif (ares='1')
                then q<='0';
            elsif (aset='1')
                then q<='1';
        end if;
    end process;
end architecture ; -- syncRE

architecture syncFE of JKff is
begin
    process (clock) is
    begin
        if (clock'event and clock='0')
            then 
            with bit_vector'(J,K) select
            q   <=  q       when    "00",
                    0       when    "01",
                    1       when    "10",
                    not q   when    "11";
            elsif (ares='1')
                then q<='0';
            elsif (aset='1')
                then q<='1';
        end if;
    end process;
end architecture ; -- syncFE