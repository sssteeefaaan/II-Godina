entity dff is
    port (
      clock : in bit;
      d:in bit;
      reset: in bit;
      set: in bit;
      q:out bit
    ) ;
  end entity;
  
  architecture asyncRE of dff is
  begin
      process (reset,set,clock) is
      begin
             if (reset='1')
              then q<='0';
          elsif (set='1')
                 then q<='1';
          elsif (clock'event and clock='1')
              then q<=d;
          else q<=q;
          end if;
      end process;
  end architecture;
  
  architecture asyncFE of dff is
  begin
          process (reset,set,clock) is
      begin
             if (reset='1')
              then q<='0';
          elsif (set='1')
                 then q<='1';
          elsif (clock'event and clock='0')
              then q<=d;
          else q<=q;
          end if;
      end process;
  end architecture;
  
  architecture syncRE of dff is
  begin
      process (clock) is
      begin
        if (clock'event and clock='1') then
            if (reset='1') 
                then q<='0';
            elsif (set='1') 
                then q<='1';
            else 
                q<=d;
            end if;
        end if;
      end process;
  end architecture;
  
  architecture syncFE of dff is
  begin
      process (clock) is
      begin
        if (clock'event and clock='0') 
            then
              if (reset='1') 
                    then q<='0';
                elsif (set='1') 
                    then q<='1';
                else
                      q<=d;
                end if;
        end if;
      end process;
  end architecture;