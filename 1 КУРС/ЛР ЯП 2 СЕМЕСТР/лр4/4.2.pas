//Дан текстовый файл. Напечатать в алфавитном порядке все слова из данного файла, имеющие заданную длину n.

var a: array of string;
      x,i,k,n,l: integer;
      s1,s2: string;
      sym:char;
      f: text;
begin
        readln(n);
        assign(f,'input.txt');
        reset(f);
            l:=2;
            while not eof(f) do
                  begin read(f,sym);
                        s1:=s1+sym;
                  end;
              for i:=1 to length(s1) do
                          begin 
                            if s1[i]=' ' then inc(l);
                          end;
        close(f);
        x:=0;
        setlength(a,l);
        for i:=1 to length(s1) do
            begin 
                if ((((s1[i]<>#10) and (s1[i]<>' ')) and (s1[i]<>'.')) and (s1[i]<>'!')) and (s1[i]<>',') then
                  begin 
                  inc(k);
                  s2:=s2+s1[i];
                  end;
                  if ((((s1[i]=' ') or (s1[i]=#10)) or (s1[i]='.')) or (s1[i]='!')) or (s1[i]=',') then begin 
                  if k=n then begin a[x]:=s2; inc(x) end;
                  k:=0;
                  delete(s2,1,length(s2));
                  end;
          end;
        sort(a);
        for i:=0 to l-1 do begin
          if (a[i]>'') and (a[i]<>#13) then write(a[i],' ');
        end;
end.