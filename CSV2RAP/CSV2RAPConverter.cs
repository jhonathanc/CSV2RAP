using System;
using System.IO;
using System.Linq;

namespace CSV2RAP
{
    public static class CSV2RAPConverter
    {
        public static void Convert2Rap(String csvFileName, String outputPath, char csvSeparator)
        {

            using (var reader = new StreamReader(csvFileName))
            {
                while (!reader.EndOfStream)
                {
                    var values = reader.ReadLine().Split(csvSeparator);
                    if (values.Length == 2)
                    {
                        using (var outputFile = File.Create(outputPath + "\\" + values[1]))
                        {
                            var byteArray = StringToByteArray(values[0]);
                            for (int i = 0; i < byteArray.Length; i++)
                                outputFile.WriteByte(byteArray[i]);
                            outputFile.Close();
                        }
                    }
                }
            }
        }

        public static void Convert2Rap(Stream csvStream, String outputPath, char csvSeparator)
        {
            using (var reader = new StreamReader(csvStream))
            {
                var values = new string[2];
                var valuesAux = new string[2];
                while (!reader.EndOfStream)
                {
                    valuesAux = reader.ReadLine().Split(csvSeparator);
                    if (values.Length != 0)
                    {
                        //if it's the same game and rap, go next.
                        if ((values[0] == valuesAux[0]) & (values[1] == valuesAux[1]))
                            continue;
                    }
                    values = valuesAux;

                    if (values.Length == 2)
                    {
                        var fileName = outputPath + "\\" + values[1] + ".RAP";
                        var fileNameAux = fileName;
                        uint count = 0;
                        while (File.Exists(fileNameAux))
                        {
                            count++;
                            fileNameAux = fileName + "." + "DUPLICATE" + count;
                        }
                        fileName = fileNameAux;
                        WriteRapFile(values[0], fileName);
                    }
                }
            }
        }

        private static void WriteRapFile(String value, String outputRapFileName)
        {
            using (var outputFile = File.Create(outputRapFileName))
            {
                var byteArray = StringToByteArray(value);
                for (int i = 0; i < byteArray.Length; i++)
                    outputFile.WriteByte(byteArray[i]);
                outputFile.Close();
            }
        }

        private static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
    }
}
