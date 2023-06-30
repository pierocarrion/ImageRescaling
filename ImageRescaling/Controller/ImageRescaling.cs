using Emgu.CV;
using Emgu.CV.Cuda;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using ImageRescaling.Common.CustomProcesses;
using System.Drawing;

namespace ImageRescaling.Controller
{
    public static class ImageRescaling
    {
        public static void ResizeImageGPU(string imagePath, int newWidth, int newHeight)
        {
            try
            {
                if (!File.Exists(imagePath)) throw new Exception("Image doesn´t exists");
                
                string directory = Path.GetDirectoryName(imagePath);
                
                string extension = Path.GetExtension(imagePath);
                string rescaledImageName = $"{Guid.NewGuid()}-rescaled{extension}";
                string absolutePath = Path.Combine(directory, rescaledImageName);
                
                Image<Bgr, byte> inputImage = new Image<Bgr, byte>(imagePath);

                using (GpuMat gpuImage = new GpuMat())
                using (GpuMat resizedGpuImage = new GpuMat())
                {
                    gpuImage.Upload(inputImage);
                    CudaInvoke.Resize(gpuImage, resizedGpuImage, new Size(newWidth, newHeight), 0, 0, Inter.Linear);
                    Image<Bgr, byte> resizedImage = new Image<Bgr, byte>(newWidth, newHeight);
                    resizedGpuImage.Download(resizedImage);
                    
                    resizedImage.Save(absolutePath);
                }
                CustomProcesses.OpenFolder("explorer.exe", directory);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}