using System;

public interface Document
{
    void Open();
}

public class WordDocument : Document
{
    public void Open() => Console.WriteLine("Opening Word Document");
}
public class PdfDocument : Document
{
    public void Open() => Console.WriteLine("Opening PDF Document");
}
public class ExcelDocument : Document
{
    public void Open() => Console.WriteLine("Opening Excel Document");
}

public abstract class DocumentFactory
{
    public abstract Document CreateDocument();
}

public class WordDocumentFactory : DocumentFactory
{
    public override Document CreateDocument() => new WordDocument();
}
public class PdfDocumentFactory : DocumentFactory
{
    public override Document CreateDocument() => new PdfDocument();
}
public class ExcelDocumentFactory : DocumentFactory
{
    public override Document CreateDocument() => new ExcelDocument();
}

class Program
{
    static void Main()
    {
        Document doc1 = new WordDocumentFactory().CreateDocument();
        doc1.Open();

        Document doc2 = new PdfDocumentFactory().CreateDocument();
        doc2.Open();

        Document doc3 = new ExcelDocumentFactory().CreateDocument();
        doc3.Open();
    }
}
