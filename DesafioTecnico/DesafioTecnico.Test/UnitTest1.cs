namespace DesafioTecnico.Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Simplificar_caso_1()
    {
        Desafio desafio = new Desafio();
        string result = desafio.Simplificar("4/6");

        Assert.AreEqual("2/3", result);
    }

    [TestMethod]
    public void Simplificar_caso_2()
    {
        Desafio desafio = new Desafio();
        string result = desafio.Simplificar("10/11");

        Assert.AreEqual("10/11", result);
    }

    [TestMethod]
    public void Simplificar_caso_3()
    {
        Desafio desafio = new Desafio();
        string result = desafio.Simplificar("100/400");

        Assert.AreEqual("1/4", result);
    }

    [TestMethod]
    public void ValidarNombre_caso_1()
    {
        Desafio desafio = new Desafio();
        bool result = desafio.ValidoNombre("E. Poe");

        Assert.IsTrue(result);
    }


    [TestMethod]
    public void ValidarNombre_caso_2()
    {
        Desafio desafio = new Desafio();
        bool result = desafio.ValidoNombre("E. A. Poe");

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ValidarNombre_caso_3()
    {
        Desafio desafio = new Desafio();
        bool result = desafio.ValidoNombre("Edgard A. Poe");

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ValidarNombre_caso_4()
    {
        Desafio desafio = new Desafio();
        bool result = desafio.ValidoNombre("Edgard");

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void ValidarNombre_caso_5()
    {
        Desafio desafio = new Desafio();
        bool result = desafio.ValidoNombre("e. Poe");

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void ValidarNombre_caso_6()
    {
        Desafio desafio = new Desafio();
        bool result = desafio.ValidoNombre("E Poe");

        Assert.IsFalse(result);
    }
    [TestMethod]
    public void ValidarNombre_caso_7()
    {
        Desafio desafio = new Desafio();
        bool result = desafio.ValidoNombre("E. Allan Poe");

        Assert.IsFalse(result);
    }
    [TestMethod]
    public void ValidarNombre_caso_8()
    {
        Desafio desafio = new Desafio();
        bool result = desafio.ValidoNombre("E. Allan P.");

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void ValidarNombre_caso_9()
    {
        Desafio desafio = new Desafio();
        bool result = desafio.ValidoNombre("Edg. Allan Poe");

        Assert.IsFalse(result);
    }
}
