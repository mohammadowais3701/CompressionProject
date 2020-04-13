using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;
using System.Windows.Forms;
namespace Bcompression
{
  sealed  class Archiving
    {
        public void Compressfolder(FileInfo FileToCompress,ListBox list)
        {
            using (FileStream originalfile = FileToCompress.OpenRead())
            {
                if ((File.GetAttributes(FileToCompress.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden & FileToCompress.Extension != ".gz")
                {
                    using (FileStream compressedFileStream=File.Create(FileToCompress.FullName+".gz"))
                    {
                        using (GZipStream compressionStream=new GZipStream(compressedFileStream,CompressionMode.Compress))
                        {
                            originalfile.CopyTo(compressionStream);
                            list.Items.Add("Compressed " + FileToCompress.Name + " from " + FileToCompress.Length + " to " + compressedFileStream.Length);

                        }
                        
                    }

                }
            }


        }
        public void Extract(FileInfo FileToDecompress) {
            using (FileStream originalstream=FileToDecompress.OpenRead())
            {
                string currentfilename = FileToDecompress.FullName;
                string newfilename = currentfilename.Remove(currentfilename.Length - FileToDecompress.Extension.Length);
                using (FileStream DecompressedFileStream=File.Create(newfilename))
                {
                    using (GZipStream Decompressionstream=new GZipStream(originalstream,CompressionMode.Decompress))
                    {
                        if (FileToDecompress.Extension==".gz")
                        Decompressionstream.CopyTo(DecompressedFileStream); 
                    }
                }
            }
        
        }
    }
}
