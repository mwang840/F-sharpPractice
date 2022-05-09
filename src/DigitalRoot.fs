let rec DigitalRoot n =
    if n == 0 then return 0
    else return DigitalRoot n % 10
    n = n/10