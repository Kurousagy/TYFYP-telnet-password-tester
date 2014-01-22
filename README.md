Massive telnet password tester for routers.
============================
Commercial name: TYFYP (Thank you for your password), to the honor of ADTRAN telnet banner motd welcome message.

Please use it ONLY in LAN IPs. This is a very rudimentary program only for investigation purposes.

## REQUIREMENTS:
- Windows.
- .NET Framework v4.5

## HOW TO USE:
- Open TYFYP.exe or complile it in Visual Studio.
- Select a .txt file with IPs list you want to try. 
- Write a default telnet username, password and enable password.
- Click "Run". 

## WHAT IT WILL DO:
- Check IP by IP telnet username and password. 
- If there is a connection, it will try enable password. 
- You will see green lines in case of successful connection, red lines if not.
- Clear red lines means there wasn't telnet service listening (or your network connection fails).

## Future improvements:
- Be able to read telnet user, password and enable password directly from IP list txt. This will allow to try multiples password for each IP.
- Make it multi-threading.
