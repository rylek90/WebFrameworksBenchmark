var generateNumbers = function (count, max) {
    var result = []

    for (i = 0; i < count; i++) {
        var randomNumber = Math.floor(Math.random() * max);
        result.push(randomNumber);
    }

    return result
};

var isPrime = function (number) {
    if (number === 2 || number === 3) {
        return true;
    }

    if (number%2 === 0 || number % 3 === 0) {
        return false;
    }

    var i = 5;
    var w = 2;

    while (i * i <= number) {
        if (number % i === 0) {
            return false;
        }

        i += w;
        w = 6 - w;
    }

    return true;
};

var defineModel = function (number, isPrime) {
    return {
        number: number,
        isPrime: isPrime
    };
}

module.exports = {

    checkPrimes: function () {
        var numbers = generateNumbers(100, 1000);
        var result = [];
        for (var i = 0; i < 100; i += 1) {
            result.push(defineModel(numbers[i], isPrime(numbers[i])));
        }

        return result;
    }
};