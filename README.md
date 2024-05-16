# FeexRanks
Rank system to your server, creates a new table rank to store all players points, you can receive points by killing players/zombies/mega zombies, totally configurable,
also you can receive Uconomy balance when ranking up and group permissions rewards.

Requirements:
- Mysql
- Uconomy (Optional)

# Building

*Windows*: The project uses dotnet 4.8, consider installing into your machine, you need visual studio, simple open the solution file open the Build section and hit the build button (ctrl + shift + b) or you can do into powershell the command dotnet build -c Debug if you have installed dotnet 4.8.

*Linux*: Unfortunately versions lower than 6 of dotnet do not have support for linux, the best thing you can do is install dotnet 6 or the lowest possible version on your distro and try to compile in dotnet 6 using the command dotnet build -c Debug, this can cause problems within rocket loader.

FTM License.