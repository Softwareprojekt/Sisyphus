# Sisyphus 

## About
Sisyphus is a Software Project of computer engineering students from the OTH Amberg-Weiden. The software purpose is to give math students a good introduction to various linear algebra subjects, such as linear and affine transformations, fractals.

Sisyphus lets students create exercise books with different kind of exercises. Exercises give the students the possibility to enter different kind of parameters, to calculate resulting vectors, affine transformations, fractals or other results. Each type of exercise gives different instructions to the learning student to follow. 

Sisyphus is written in C sharp and uses Windows Forms as graphical interface. Our familiarity with this technology and restricted time, made us choose it. Furthermore we were advised to develop something from the ground up.

A good part of the project consists of documentation. In fact a primary aim of the project was for the developing students to become more familiar with software development processes.

## Technical Documentation
Most documents of Sisyphus such as [exercise drafts](https://github.com/Softwareprojekt/Sisyphus/tree/dev/_source/_analysis/GUI), [requirement specification](https://github.com/Softwareprojekt/Sisyphus/blob/dev/_source/_analysis/Anforderungen(XYZ)_Sisyphus.docx), [coding conventions](https://github.com/Softwareprojekt/Sisyphus/blob/dev/_organisation/_process/CodingGuideline.docx), system analysis, [test cases](https://github.com/Softwareprojekt/Sisyphus/tree/dev/_source/_analysis/Test%20Cases) are only available in German. 

### Architecture Overview
Class diagrams for the project were created using Visual Studio 2012. Those can be found either in the system analysis document or can be opened in Visual Studio below ClassDiagrams.

In Sisyphus the Model View Controller pattern is used. The program code is located at 
https://github.com/Softwareprojekt/Sisyphus/tree/dev/_source/_code/_cs/SoftwareProjekt.


### Run
You can use Visual Studio 2012 or higher to built and run the Sisyphus executable for Windows.
The whole project uses one Visual Studio project file (Root.sln), which can be found below ./_wsp/_vs/Root.sln

Currently the application is not Mono compatible. 

## License
[GPL2](http://www.gnu.org/licenses/old-licenses/gpl-2.0.html)
