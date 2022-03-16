#pragma once

using namespace System;
using namespace System::Drawing;
using namespace System::Drawing::Imaging;
using namespace System::IO;

#include <opencv2/imgcodecs.hpp>
#include <opencv2/highgui.hpp>
#include <opencv2/imgproc.hpp>

namespace OpenCvDotNet {
	public ref class MyOpenCvWrapper
	{
	public:
		void startCamera();
		void stopCamera();
		bool checkCamera();
		double needleLength();
		void getNeedleLength(int gaussianBlurKsize, int threshold1, int threshold2, double width, double height);
		void captureCam();
		Bitmap^ displaySrc();
		Bitmap^ displayCanny();
		Bitmap^ MatToBitmap(cv::UMat image);
		void getColor(int LowR, int LowG, int LowB, int HighR, int HighG, int HighB);
		int Color();
	private:
		void getContours(cv::UMat imgDilate, cv::UMat img);
		
	};
}
