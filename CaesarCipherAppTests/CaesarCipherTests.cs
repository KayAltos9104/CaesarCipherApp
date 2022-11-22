using CaesarCipher;
namespace CaesarCipherAppTests;
[TestClass]
public class CaesarCipherTests
{
    [TestMethod]
    public void EncodeText_EncodedString()
    {
        // arrange

        string input = "съешь же ещЄ этих м€гких французских булок, да выпей чаю.";
        int key = 3;
        string expected = "фэзы€ йз зьи ахлш пвЄнлш чугрщцкфнлш дцосн, жг еютзм ъгб.";

        // act

        string actual = Coder.Encode(input, key);
        
        // assert

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecodeText_DecodedString()
    {
        // arrange

        string input = "фэзы€ йз зьи ахлш пвЄнлш чугрщцкфнлш дцосн, жг еютзм ъгб.";
        int key = 3;
        string expected = "съешь же ещЄ этих м€гких французских булок, да выпей чаю.";

        // act

        string actual = Coder.Decode(input, key);

        // assert

        Assert.AreEqual(expected, actual);
    }
}