var n,i,j: integer;
begin
  readln(n); //порядок матрицы
  for i:=1 to (n div 2) do //верхняя половина
    begin
    for j:=1 to n do //j - номер ячейки
    begin
    if (j<i) or (j>(n-i+1)) then write(0:2)
    else write (1:2);
    end;
    writeln (' ');
    end;
    for i:=(n div 2) to n do
    begin
    for j:=1 to n do
    begin
    if i=(n div 2) then continue;
    if (j>i) or (j<(n-i+1)) then write(0:2)
    else write (1:2);
    end;
    if i<>(n div 2) then writeln(' ');
    end;
end.