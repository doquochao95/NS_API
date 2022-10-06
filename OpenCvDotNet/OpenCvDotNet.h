#pragma once

using namespace System;
using namespace System::Drawing;
using namespace System::Drawing::Imaging;
using namespace System::IO;

#include <string>
#include <iostream>
#include <opencv2/imgcodecs.hpp>
#include <opencv2/highgui.hpp>
#include <opencv2/imgproc.hpp>

namespace OpenCvDotNet {
	public ref class MyOpenCvWrapper
	{
	public:
		bool startCamera(int IDCamera);
		bool startCamera(System::String^ IPCamera);
		bool stopCamera();
		bool checkCamera();
		int countCamera();
		double needleLength();
		bool getNeedleLength(int gaussianBlurKsize, int threshold1, int threshold2, double width, double height);
		void captureCam();
		void Display_Mode(char mode, int brightness, float contrast, bool onoffDetect);
		void User_Display_Mode(char mode, int brightness, float contrast, int user_brightness, float user_contrast);
		Bitmap^ displaySrc(double width, double height);
		Bitmap^ displayDst(double width, double height);
		Bitmap^ displayCanny(int gaussianBlurKsize, int threshold1, int threshold2, double width, double height);
		Bitmap^ MatToBitmap(cv::UMat image , double width, double height);
		void getColor(int LowR, int LowG, int LowB, int HighR, int HighG, int HighB);
		int Color();
	private:
		void getContours(cv::UMat imgDilate, cv::UMat img);
		
	};
}
