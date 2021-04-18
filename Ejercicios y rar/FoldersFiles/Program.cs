using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldersFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //PATH RELATIVOS...
            //string pathArchivoRelativo = ConfigurationManager.AppSettings["archivoRelativo"];
            //using (StreamReader str = new StreamReader(pathArchivoRelativo))
            //{
            //    Console.WriteLine(str.ReadToEnd());
            //}

            //string currentDirectory = Directory.GetCurrentDirectory();

            //Console.WriteLine(currentDirectory);

            //return;

            //PARAMETRIZACIÓN...
            string pathArchivo = ConfigurationManager.AppSettings["PathArchivo"].ToString();
            int nro = int.Parse(ConfigurationManager.AppSettings["Numero"].ToString());

            string sourceDir = ConfigurationManager.AppSettings["PathBase"].ToString();
            string backupDir = ConfigurationManager.AppSettings["backupDir"].ToString();

            try
            {
                //Ejemplo de cómo obtener todos los archivos de un directorio...
                //string[] picList = Directory.GetFiles(sourceDir, "*.");
                //string[] txtList = Directory.GetFiles(sourceDir, "*.pdf");

                //Recorro cada uno de los socios...
                string fecha = DateTime.Now.ToString("MMyyyy");
                string folderBase = sourceDir + "\\" + fecha;
                //string pathcombinado = Path.Combine("", "", "");

                //Validar si existe un directorio
                if (!Directory.Exists(folderBase))
                {
                    Console.WriteLine("El directorio a procesar no existe. Saludos!");
                    return;
                }

                //string pathArchivoRelativo = "pepe.txt";
                //using (StreamReader str = new StreamReader(pathArchivoRelativo))
                //{
                //    Console.WriteLine(str.ReadToEnd());
                //}

                //Recorro cada uno de los directorios
                ProcesarDirectorio(backupDir, fecha, folderBase);

                Console.ReadKey();
            }
            catch (FileNotFoundException fnfException)
            {
                Console.WriteLine(fnfException.StackTrace);
                Console.WriteLine(fnfException.Message);
            }
            catch (DirectoryNotFoundException dirNotFound)
            {
                Console.WriteLine(dirNotFound.Message);
            }
            catch (Exception generica)
            {
                Console.WriteLine(generica.Message);
            }
            finally
            {
                //Liberador de recursos...
                Console.WriteLine("El proceso ejecutó...");
            }
        }

        private static void ProcesarDirectorio(string backupDir, string fecha, string folderBase)
        {
            foreach (FileInfo archivo in new DirectoryInfo(folderBase).GetFiles())
            {
                try
                {
                    Console.WriteLine("Nombre: " + archivo.FullName + " tamaño: " + archivo.Length);

                    //Convierto a pdf
                    string newFile = ConvertDocToPdf(folderBase, archivo);

                    string socio = archivo.Name.Split('-')[0];

                    string fileDestino = backupDir + "\\" + socio;

                    //Verifico nombre de cada socio
                    if (!Directory.Exists(fileDestino))
                    {
                        Directory.CreateDirectory(fileDestino);
                    }
                    //Genero la fecha del día
                    string fileDestinoMensual = fileDestino + "\\" + fecha;

                    if (!Directory.Exists(fileDestinoMensual))
                    {
                        Directory.CreateDirectory(fileDestinoMensual);
                        File.Copy(folderBase + "\\" + newFile, fileDestinoMensual + "\\" + newFile);
                    }
                    else
                    {
                        //Si existe borro lo que hay y agrego lo nuevo
                        foreach (FileInfo f in new DirectoryInfo(fileDestinoMensual).GetFiles())
                        {
                            f.Delete();
                        }
                        //Borro el directorio..
                        Directory.Delete(fileDestinoMensual);

                        File.Copy(folderBase + "\\" + newFile, fileDestinoMensual + "\\" + newFile);
                    }
                }
                catch (Exception mensaje)
                {
                    Console.WriteLine(mensaje.Message);
                }
            }
        }

        private static string ConvertDocToPdf(string folderBase, FileInfo archivo)
        {
            Document doc = new Document();// folderBase + "\\" + archivo);
            doc.LoadFromFile(folderBase + "\\" + archivo.Name);
            // Save as PDF
            string newFile = archivo.Name.Replace(".doc", ".pdf");

            doc.SaveToFile(folderBase + "\\" + newFile, FileFormat.PDF);

            return newFile;
        }
    }
}
