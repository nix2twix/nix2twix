var arr: array [1..5,1..10] of integer;
    k,s: integer;
    begin
//внеш цикл строки (s)
    for s:=1 to 5 do
      begin
        
         for k:=1 to 10 do
         begin
         arr[s,k]:=random(21)-10;  
         write(arr[s,k]:4);
         end;
         
         writeln;
         
       end;
       
    end.