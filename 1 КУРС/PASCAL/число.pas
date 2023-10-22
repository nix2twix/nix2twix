var str: string;
    x:char;
    i,j,k0,k1,k2,k3,k4,k5,k6,k7,k8,k9: integer;
    f:text;
    begin
    assign(f,'input.txt');
    reset(f);
    readln(f,str);
    close(f);
  
    for i:=1 to length(str) do
    begin
        
        if str[i]='0' then inc(k0);
        if str[i]='1' then inc(k1);
        if str[i]='2' then inc(k2);
        if str[i]='3' then inc(k3);
        if str[i]='4' then inc(k4);
        if str[i]='5' then inc(k5);
        if str[i]='6' then inc(k6);
        if str[i]='7' then inc(k7);
        if str[i]='8' then inc(k8);
        if str[i]='9' then inc(k9);
      
    end;
  
   // assign(f,'output.txt');
    //rewrite(f);
    writeln(k0); writeln(k1); writeln(k2); writeln(k3); writeln(k4);
    writeln(k5); writeln(k6); writeln(k7); writeln(k8); writeln(k9);
   // close(f);
    end.