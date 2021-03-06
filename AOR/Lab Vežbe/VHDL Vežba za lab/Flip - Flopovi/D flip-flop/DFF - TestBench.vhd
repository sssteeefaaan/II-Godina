entity testBench is
    end entity testBench;
    architecture testBench of testBench is
    
        signal sd,ares,aset,sq : bit;
        signal clk : bit :='0';
        constant Tclk: time := 500 ps;
    begin
        uut: entity dff(syncRE)
        port map(clock=>clk,d=>sd,reset=>ares,set=>aset,q=>sq);
    
        clk<=not clk after 2*Tclk;
    
        process is
            begin
                sd<='0','1' after 300 ps,'0' after 600 ps,'1' after 1100 ps,'0' after 1450 ps,'1' after 2 ns;
                ares<='1','0' after Tclk;
                aset<='0','1' after 4*Tclk;
                wait for 5*Tclk;
        end process;
    end architecture; -- testBench