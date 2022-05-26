entity dff is
    port (d : in bit;
    clk : in bit;
    res : in bit;
    set : in bit;
    q : out bit
    );
  end dff;
  architecture async of dff is 
  begin
      q<='0' when res='1'
      else '1' when set='1'
      else d when clk'event and clk='1';
      
  end architecture async;
  architecture sync of dff is
  begin
      q<=q when (not clk'event) or clk='0'
      else '0' when res='1'
      else '1' when set='1'
      else d when clk'event and clk='1';
  end architecture sync;