# Use official .net SDK image to build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory
WORKDIR /src

# Copy the project files
COPY hello-api/hello-api.csproj ./hello-api/

# Restore the dependencies
WORKDIR /src/hello-api
RUN dotnet restore

# Copy the rest of the source code
WORKDIR /src
COPY hello-api/. ./hello-api/

# Build the application
WORKDIR /src/hello-api
RUN dotnet publish -c Release -o out

# Use the official .net runtime image to run the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 as runtime

# Set the working directory
WORKDIR /app

# Copy the built application from the build stage
COPY --from=build /src/out .

# Expose the port the app runs on
EXPOSE 8080

# Set the entry point for the application
ENTRYPOINT ["dotnet", "hello-api.dll"]
