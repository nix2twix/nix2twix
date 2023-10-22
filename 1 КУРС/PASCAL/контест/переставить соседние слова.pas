var s,s1,s2: string;
    i:integer;
    f: text;
  begin
    
    assign(f,'input.txt');
    reset(f);
    while not eof(f) do
    	begin
        readln(f,s);
		s:=s+' ';
        	while s <> '' do
            	begin 
                s1:=copy(s,1,pos(' ',s));
                delete(s,1,pos(' ',s));
                s2:=copy(s,1,pos(' ',s));
                delete(s,1,pos(' ',s));
                write(s2,s1);
                end;
        end;
    close(f);
  end.