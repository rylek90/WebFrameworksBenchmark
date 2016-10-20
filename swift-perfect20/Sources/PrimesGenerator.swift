import Foundation

class PrimesGenerator {

    func find() -> [String: Any] {
        var primes = [Int]()
        
        var i = 2
        while (primes.count < 100) {
            var isPrime = true
            
            for prime in primes {
                if (i % prime == 0) {
                    isPrime = false
                    break
                }
            }
            
            if isPrime {
                primes.append(i)
            }
            
            i += 1
        }
        
        var result = [String: Any]()
        result["primes"] = primes
        return result
    }
    
    func random() -> [String: Bool] {
        let numbers = generateNumbers(count: 100, max: 1000000)
        var result = [String: Bool]()

        for i in 0...99 {
            let key = String(numbers[i])
            result[key] = isPrime(number: numbers[i])
        }
        
        return result
    }
    
    private func generateNumbers(count: Int, max: Int) -> [Int] {
        var result = [Int]()
        
        for _ in 0...count {
            let randomNumber = Int(arc4random_uniform(UInt32(max)))
            result.append(randomNumber)
        }
        
        return result
    }
    
    private func isPrime(number: Int) -> Bool {
        if (number == 2 || number == 3) {
            return true;
        }
        
        if (number % 2 == 0 || number % 3 == 0) {
            return false;
        }
        
        var i = 5
        var w = 2
        
        while (i * i <= number) {
            if (number % i == 0) {
                return false
            }
            
            i += w
            w = 6 - w
        }
        
        return true
    };
}
