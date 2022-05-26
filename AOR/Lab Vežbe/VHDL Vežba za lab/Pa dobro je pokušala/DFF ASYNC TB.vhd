entity tb is
    end tb;
    architecture tb of tb is
        signal sres,sset,sq : bit;
        signal sclk : bit :='0';
        signal sd : bit :='0';
    begin
        UUT:entity dff(async)
                   port map(sd,sclk,sres,sset,sq);
        sclk<=not sclk after 1us;
        sd<=not sd after 750ns;
        process is
        begin
            sres <= '1','0' after 500ns;
            sset <= '0','1' after 3 us,'0' after 4us;
            wait for 4us;
        end process;
    end architecture tb;