var   corteg: (integer,integer,string);
      arrP:array of (integer,integer,string);
      arrM:array of (integer,integer,string);
      x,y,i,k,j,kP,kM,n,t:integer;
      z:string;
      f1:text;
    begin
      assign(f1,'input.txt');
      reset(f1);
      readln(f1,n,t);
      writeln('N=', n,', T=',t);
      setlength(arrP,n); setlength(arrM,n);
        for i:=0 to n-1 do
            begin 
            read(f1,x,y);
            readln(f1,z);
            corteg:=(x,y,z);
            if z=' P' then begin arrP[i]:=corteg;
                                 arrM[i]:=(0,0,' 0'); 
                                 end
            
            else begin arrM[i]:=corteg; 
                       arrP[i]:=(0,0,' 0'); 
                       end;
            end;
      close(f1);
      sort(arrP);
      sort(arrM);
      writeln(arrP);
      writeln(arrM);
      for i:=0 to n-1 do
          begin 
          if (arrP[i][0]<>0) and (t>0) then
                 begin 
                 for j:=1 to arrP[i][1] do
                    begin
                 if t<arrP[i][0] then break
                 else begin
                 t:=t-arrP[i][0];
                 inc(kP);
                 end;
                 end;
          end; end;
      for i:=0 to n-1 do
          begin 
          if (arrM[i][0]<>0) and (t>0) then
                 begin 
                 for j:=1 to arrM[i][1] do
                    begin
                 if t<arrM[i][0] then break
                 else begin
                 t:=t-arrM[i][0];
                 inc(kM);
                 end;
                 end;
          end; end;
      writeln(kp,' ',km);
      {assign(f1,'output.txt');
      rewrite(f1);
      write(f1,arr);
      close(f1);}
    end.