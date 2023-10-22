var arrT:array [1..50000] of integer;
    arrN:array [1..50000] of integer;
    arrZ:array [1..50000] of string;
    N,T,x,y,i,sum1,sum2,mint,memy,numit,k,chetchikM,chetchikP: integer;
    z: string;
    fin,fout:text;
    begin
    sum1:=0; sum2:=0; mint:=maxInt; memy:=0; chetchikM:=0;
    assign(fin,'input.txt');
    reset(fin);
    read(fin,N,T);
    for i:=1 to N do
    begin
    read(fin,x,y,z); //массив с вр. на 1 задачу + число задач
    arrT[i]:=x;
    arrN[i]:=y;
    arrZ[i]:=z;
    if (z= ' M') and (x<mint) then 
                              begin 
                              mint:=x; 
                              memy:=y;
                              numit:=i;
                              end;
    if z=' P' then
              begin inc(chetchikP);
                    if T>x*y then
                    begin
                    sum1:=sum1+y;
                    T:=T-x*y;
                    end;
                    if (T<x*y) and (T>x) then 
                    begin
                    T:=T-x;
                    inc(sum1);
                    end;
    end; end;
    if T>mint then
        repeat
        dec(memy);
        T:=T-mint;
        inc(sum2);
        until (T<mint) or (memy=0);
            arrT[numit]:=0;
            arrN[numit]:=0;
            arrZ[numit]:=' 0';
            mint:=maxInt; 
            inc(chetchikM);
    repeat
    for i:=1 to N do
    begin
              if (T>arrT[i]) and (arrZ[i]=' M') then
                   begin
                   if (arrT[i]>0) and (arrT[i]<mint) then
                              begin //нашли след минимум
                              mint:=arrT[i]; 
                              memy:=arrN[i];
                              end;
                   end; end;
           if mint<>maxInt then begin
            arrT[numit]:=0;
                              repeat
                              inc(sum2);
                              dec(memy);
                              T:=T-mint;
                              until (T<mint) or (memy=0); 
                              inc(chetchikM); end;
     until chetchikM=N-chetchikP;
    close(fin);
    
    assign(fout,'output.txt');
    rewrite(fout);
    write(fout,sum1,' ',sum2);
    close(fout);
    
                        writeln(sum1, ' ',sum2, ' ', T);
    end.
    
    