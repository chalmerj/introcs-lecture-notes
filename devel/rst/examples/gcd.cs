using System;

class Euclid {

    /* snip-Euclid-begin */
    public static int GreatestCommonDivisorEuclid(int a, int b) {
	if (b == 0) {
	    Console.WriteLine("gcd({0}, {1}) = {0}", a, b);
	    return a;
	} else {
	    Console.WriteLine("gcd({0}, {1}) = gcd({1}, {0} mod {1} = gcd({1}, {2})", a, b, b, a, b, b, a % b);
	    return GreatestCommonDivisorEuclid(b, a % b);
	}
    }
    /* snip-Euclid-end */

    public static void Main(string[] args) {
	if (args.Length < 2) {
	    Console.WriteLine("usage: Euclid a b");
	    return;
	}
	int a = int.Parse(args[0]);
	int b = int.Parse(args[1]);
	Console.WriteLine("gcd({0}, {1}) = {2}", a, b, GreatestCommonDivisorEuclid(a, b));
    }
    
}