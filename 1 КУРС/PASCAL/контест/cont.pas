  var s1,z: string; 
      sym,z1: char;
      q,i,x,k,j,n,l,ar,f: integer;
      
      begin
      
      readln(n,l); //n - число операций, l - длина строки
      readln(sym);
      ar:=1;
      for i:=1 to n do begin
                         readln(z);
                         if ar<>-1 then begin for j:=1 to length(z) do
                                              begin 
                                                z1:=z[j];
                                                if z1<>sym then begin    
                                                                        if i>1 then begin //цикл проверки на уникальность
                                                                        for x:=1 to length(s1) do begin
                                                                                          if ((z[x]<>s1[x]) and (s1[x]<>' ')) and (z[x]<>sym) then 
                                                                                                        begin 
                                                                                                        ar:=-1; 
                                                                                                        k:=i; 
                                                                                                        break; 
                                                                                                        end;
                                                                                                        end; 
  
                                                                        end; 
                                                                        if ar=-1 then break;
                                                                        if length(s1)<j then setlength(s1,j);
                                                                        if s1[j]=' ' then begin
                                                                                          s1[j]:=z[j];
                                                                                          k:=i;
                                                                                          end;
                                                                        
                                                                        end;
                                                                  
                        if ar=-1 then break;                      
                        if length(s1)=l then begin for f:=1 to length(s1) do
                            begin 
                            if s1[f] <> ' ' then inc(q);
                            end;
                         if q=length(s1) then break;
                           end; 
                           
                           q:=0; 
                           
                           end; end;
                         
                         end;
                  
      writeln(k*ar);
      end.