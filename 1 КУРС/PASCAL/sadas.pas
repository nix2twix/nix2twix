var f: text;
    p: string;
    i: char;
    a,v: integer;
    begin
      
      assign(f,'input.txt');
      reset(f);
      while not eof(f) do begin
        read(f,i);
        p:=p+i;
      end;
      close(f);
      
      writeln(p);
      
    end.