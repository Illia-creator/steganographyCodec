﻿using SteganographyCodec.Codec.Codec.IncodeLogics;
using SteganographyCodec.Domain;
using SteganographyCodec.Domain.Enteties.Files;

namespace SteganographyCodec.Codec.Files
{
    public static class IncodeFileProcess
    {
        public static string startPath = BusClass.value;

        public static void Incoding()
        {
            StartFile startFile = new StartFile(startPath);
            string value = startFile.GetDataFromFile();

            string result = GroupIncodeLogic.IncodeString(value);

            IncodeFile incodeFile = new IncodeFile();
            incodeFile.WriteDataInFile(result);
        }
    }
}