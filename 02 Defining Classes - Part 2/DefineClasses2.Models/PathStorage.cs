namespace DefineClasses2.Models3D
{
    using System;
    using System.IO;
    using System.Text;

    public static class PathStorage
    {
        private const string outputFilePath = "../../Paths.txt";
        private static bool appendMode;
        private static readonly Encoding enc;

        static PathStorage()
        {
            enc = Encoding.UTF8;
            appendMode = true;
        }

        public static void SavePath(Path path)
        {
            using (StreamWriter writer = new StreamWriter(outputFilePath, appendMode, enc))
            {
                try
                {
                    writer.WriteLine(path.ToString());
                }
                catch
                {
                    throw new ArgumentException("Invalid path!");
                }
                finally
                {
                    writer.Close();
                }
            }
        }
        public static string LoadAllPaths()
        {
            using (StreamReader reader = new StreamReader(outputFilePath, enc))
            {
                try
                {
                    StringBuilder paths = new StringBuilder();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        paths.AppendLine(line);
                    }

                    return paths.ToString();
                }
                catch
                {
                    throw new FileNotFoundException("No path storage found!");
                }
                finally
                {
                    reader.Close();
                }
            }
        }
        public static string LoadPath(int index)
        {
            using (StreamReader reader = new StreamReader(outputFilePath, enc))
            {
                try
                {
                    int linesCount = 0;

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        if (linesCount == index)
                        {
                            return line;
                        }

                        linesCount++;
                    }

                    return "Path not found!";
                }
                catch (FileNotFoundException e)
                {
                    throw e;
                }
                finally
                {
                    reader.Close();
                }
            }
        }
        public static void Clear()
        {
            appendMode = false;

            using (StreamWriter writer = new StreamWriter(outputFilePath, appendMode, enc))
            {
                try
                {
                    writer.Write(string.Empty);
                }
                catch (FileNotFoundException e)
                {
                    throw e;
                }
                finally
                {
                    writer.Close();
                }
            }
        }
        public static void Delete()
        {
            File.Delete(outputFilePath);
        }

    }
}