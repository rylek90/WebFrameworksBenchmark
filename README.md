# **Web Frameworks Benchmark** #

A set of selected web frameworks benchmark based upon generating prime numbers. 

## Endpoints ##

| Route          | Description                                                    |
|----------------|----------------------------------------------------------------|
| /primes/find   | Finds first 100 prime numbers and return them as JSON array    |
| /primes/random | Generates 100 numbers up to 1,000,000 and determines primality | 

## Listening ports ##

| Application  | Port |
|--------------|------|
| ASP.NET Core | 5000 |
| Node.JS      | 8000 |
| Perfect 2.0  | 8181 |

## Run method ##

### ASP.NET Core ###

```
cd aspnetcore-benchmark/
dotnet restore
dotnet run
```

### Node.js ###
```
cd nodejs-benchmark/
npm install
node index.js --production
```

### Perfect 2.0 ###
```
cd swift-perfect20
swift build
.build/debug/PerfectTemplate
```



