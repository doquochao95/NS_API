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
		double ApplyFilter();
		void ApplyFilter1();
		void trackbar(int threshold1, int threshold2);
		void captureCam();
		Bitmap^ displaySrc();
		Bitmap^ display();
		Bitmap^ MatToBitmap(cv::UMat image);
		void Image();
		void getColor();
		int Color();
	private:
		void getContours(cv::UMat imgDilate, cv::UMat img);
		
	};
}
