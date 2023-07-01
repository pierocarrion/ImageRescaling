
# Console Image Rescaling with EMGU and CUDA

This is a console application written in C# using .NET 7 that demonstrates how to perform image rescaling using EMGU and CUDA. The application takes an input image and rescales it to a specified width and height using both the CPU-based EMGU library and the GPU-based CUDA library.

## Prerequisites

-   .NET 7 SDK: Make sure you have the .NET 7 SDK installed on your machine. You can download it from the official .NET website ([https://dotnet.microsoft.com/download/dotnet/7.0](https://dotnet.microsoft.com/download/dotnet/7.0)).
-   EMGU Libraries: Install the EMGU libraries by following the instructions on their official website ([https://www.emgu.com/wiki/index.php/Main_Page](https://www.emgu.com/wiki/index.php/Main_Page)).
-   CUDA Toolkit: If you want to utilize GPU acceleration with CUDA, ensure that you have the CUDA Toolkit installed. You can download it from NVIDIA's official website ([https://developer.nvidia.com/cuda-downloads](https://developer.nvidia.com/cuda-downloads)).

## Getting Started

1.  Clone the repository to your local machine: `git clone https://github.com/your-username/repo-name.git`
2.  Open the project in your favorite C# development environment (Visual Studio, Visual Studio Code, etc.).
3.  Build the solution to restore NuGet packages and compile the project.

## Usage

1.  Prepare your input image: Place the image you want to rescale in the project directory.
2.  Run the application from the command line: `dotnet run --project ImageRescaling.csproj`
3.  The application will prompt you for the input image filename, target width, and target height.
4.  Choose the desired rescaling method: Enter `1` to use EMGU or `2` to use CUDA for the rescaling operation.
5.  The application will perform the rescaling operation and save the output image in the project directory.
6.  Open the project directory to view the rescaled image.

## Example

arduinoCopy code

`$ dotnet run --project ImageRescaling.csproj
Enter the input image filename: input.jpg
Enter the target width: 800
Enter the target height: 600

Rescaling image using EMGU...
Rescaling completed successfully.

Rescaled image saved as output_emgu.jpg.` 

## Contributing

Contributions are welcome! If you find any issues or want to enhance the application, feel free to open an issue or submit a pull request.

## Acknowledgements

-   EMGU Team: Thanks to the EMGU team for providing the powerful image processing library.
-   NVIDIA: Thanks to NVIDIA for developing CUDA and enabling GPU acceleration in various applications.

## Contact

If you have any questions or suggestions, feel free to contact me at [your-email@example.com](mailto:your-email@example.com).

Enjoy image rescaling with EMGU and CUDA!
