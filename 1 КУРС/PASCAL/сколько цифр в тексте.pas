var str,s: string;
    x,local:char;
    i,j,k0,k1,k2,k3,k4,k5,k6,k7,k8,k9: integer;
    f:text;
    begin
    assign(f,'input.txt');
    reset(f);
    while not eof(f) do begin
    readln(f,str);
    s:=s+str;
    end;
    close(f);
    for i:=1 to length(s) do
    begin
        local:=s[i];
        if s[i]='0' then inc(k0);
        if s[i]='1' then inc(k1);
        if s[i]='2' then inc(k2);
        if s[i]='3' then inc(k3);
        if s[i]='4' then inc(k4);
        if s[i]='5' then inc(k5);
        if s[i]='6' then inc(k6);
        if s[i]='7' then inc(k7);
        if s[i]='8' then inc(k8);
        if s[i]='9' then inc(k9);
      
    end;
  
   // assign(f,'output.txt');
    //rewrite(f);
    writeln(k0); writeln(k1); writeln(k2); writeln(k3); writeln(k4);
    writeln(k5); writeln(k6); writeln(k7); writeln(k8); writeln(k9);
   // close(f);
    end.