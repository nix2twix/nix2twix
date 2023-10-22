{Cтрока S1 называется анаграммой строки S2, если она получается из S2 перестановкой символов. 
Даны строки S1 и S2. Напишите программу, которая проверяет, является ли S1 анаграммой S2.}
var s1,s2: string;
    mem: char;
    i,j,k: integer;
    f:text;
    begin
    assign(f,'input.txt');
    reset(f);
    readln(s1);
    readln(s2);
    close(f);
    
    assign(f,'output.txt');
    rewrite(f);
    if s1<>s2 then begin
    for i:=1 to length(max(s2,s1)) do
        begin 
            for j:=1 to length(max(s2,s1)) do
                begin 
            if s1[i]=s2[j] then begin inc(k); s1[i]:='0'; end;
        end; end;
    if s1='0'*length(s1) then write('YES')
    else write('NO');
    end
    else write('NO');
    close(f);
    end.