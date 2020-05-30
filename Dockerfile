FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

RUN mkdir /app
RUN mkdir /app/runtimes

WORKDIR /app

CMD dotnet restore
CMD dotnet build --configuration Release --no-restore -o ./artifacts


COPY artifacts/*.dll /app/
COPY artifacts/*.json /app/

CMD dotnet DotNetCore.DevOps.Practise.dll