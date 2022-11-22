using CaesarCipher;
namespace CaesarCipherAppTests;
[TestClass]
public class CaesarCipherTests
{
    [TestMethod]
    public void EncodeText_EncodedString()
    {
        // arrange

        string input = "����� �� ��� ���� ������ ����������� �����, �� ����� ���.";
        int key = 3;
        string expected = "����� �� ��� ���� ����� ����������� �����, �� ����� ���.";

        // act

        string actual = Coder.Encode(input, key);
        
        // assert

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DecodeText_DecodedString()
    {
        // arrange

        string input = "����� �� ��� ���� ����� ����������� �����, �� ����� ���.";
        int key = 3;
        string expected = "����� �� ��� ���� ������ ����������� �����, �� ����� ���.";

        // act

        string actual = Coder.Decode(input, key);

        // assert

        Assert.AreEqual(expected, actual);
    }
}