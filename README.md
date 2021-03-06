# Sisyphus 

## About
Sisyphus is a Software Project of computer engineering students from the OTH Amberg-Weiden. The software purpose is to give math students a good introduction to various linear algebra subjects, such as linear and affine transformations, fractals.

Sisyphus lets students create exercise books with different kind of exercises. Exercises give the students the possibility to enter different kind of parameters, to calculate resulting vectors, affine transformations, fractals or other results. Each type of exercise gives different instructions to the learning student to follow. 

Sisyphus is written in C# and uses Windows Forms. Our familiarity with this technology and restricted time, made it the best choice for us. Furthermore we were advised to develop something from the ground up.

A good part of the project consists of documentation. A primary aim of the project was for us to become more familiar with software development processes.

## Technical Documentation
Most documents of Sisyphus such as [exercise drafts](https://github.com/Softwareprojekt/Sisyphus/tree/dev/_source/_analysis/GUI), [requirement specification](https://github.com/Softwareprojekt/Sisyphus/blob/dev/_source/_analysis/Anforderungen(XYZ)_Sisyphus.docx), [coding conventions](https://github.com/Softwareprojekt/Sisyphus/blob/dev/_organisation/_process/CodingGuideline.docx), system analysis, [test cases](https://github.com/Softwareprojekt/Sisyphus/tree/dev/_source/_analysis/Test%20Cases) are only available in German. 

### Architecture Overview
Class diagrams for the project were created using Visual Studio 2012. Those can be found either in the system analysis document or can be opened in Visual Studio below ClassDiagrams.

In Sisyphus the Model View Controller pattern is used. The program code is located at 
[_source/_code/_cs/SoftwareProjekt](https://github.com/Softwareprojekt/Sisyphus/tree/dev/_source/_code/_cs/SoftwareProjekt).


### Run
Sisyphus can be built and run with Visual Studio 2011 or higher. The whole project uses one Visual Studio project file, which can be found below ./_wsp/_vs/Root.sln

Sisyphus is also compatible with Mono under Windows. Under Linux and Mac it can be compiled, but the executable does not work correctly, mostly due to a DllNotFound exception (Gdi32.dll issue).

### Current State
Active development phase stopped. Many exersices are fully implemented. Sisyphus has some weakenesses, but overall it works.

## License
[GPL2](http://www.gnu.org/licenses/old-licenses/gpl-2.0.html)
