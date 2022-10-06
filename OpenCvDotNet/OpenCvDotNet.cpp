#include "pch.h"

#include "OpenCvDotNet.h"
#include <stdio.h>


using namespace OpenCvDotNet;
using namespace cv;
using namespace std;

typedef unsigned char byte;
//VideoCapture videoCapture("http://192.168.50.130:4747/video");
//VideoCapture videoCapture(0);
VideoCapture videoCapture;
UMat imgSource, imgGray, imgGaussianBlur, imgCanny, imgCannyDisplay, imgDilate, imgErode, imgEqualizeHist, imgOutput, mask;
UMat g, g1, fin_img, imgMode, imgUserMode, imgUserMode_1;
int color;
double output;

void MarshalString(System::String^ s, string& os) {
	using namespace Runtime::InteropServices;
	const char* chars =
		(const char*)(Marshal::StringToHGlobalAnsi(s)).ToPointer();
	os = chars;
	Marshal::FreeHGlobal(IntPtr((void*)chars));
}

bool  MyOpenCvWrapper::startCamera(int IDCamera)
{
	bool status;
	status = videoCapture.open(IDCamera);
	videoCapture.set(CAP_PROP_FRAME_WIDTH, 1024);
	videoCapture.set(CAP_PROP_FRAME_HEIGHT, 768);
	return status;
	/*videoCapture.open("http://192.168.000.002:4747/video");*/
}

bool  MyOpenCvWrapper::startCamera(System::String^ IPCamera)
{
	string path;
	bool status;
	MarshalString(IPCamera, path);
	status = videoCapture.open(path);
	return status;
}

bool MyOpenCvWrapper::checkCamera()
{
	return videoCapture.isOpened();
}

bool  MyOpenCvWrapper::stopCamera()
{
	videoCapture.release();
	return videoCapture.isOpened();
}

int MyOpenCvWrapper::countCamera()
{
	int device_counts = 0;
	for (int i = 0; i < 5; i++)
	{
		if (!videoCapture.open(device_counts++))
			break;
	}
	videoCapture.release();
	return device_counts - 1;
}

struct compareContourAreas
{
	bool operator ()(const vector<cv::Point>& a, const vector<cv::Point>& b)
	{
		Rect ra(boundingRect(a));
		Rect rb(boundingRect(b));
		return (ra.x > rb.x);
	}
};

void MyOpenCvWrapper::getContours(UMat imgErode, UMat img)
{
	vector<vector<cv::Point>>contours;
	vector<Vec4i>hierarchy;
	vector<cv::Point> approx;
	Point2f mid_a, mid_b, mid_c, mid_d;
	double res, res1, P1, P2;
	int t = 0;
	P1 = 1;
	P2 = 1;
	findContours(imgErode, contours, hierarchy, RETR_EXTERNAL, CHAIN_APPROX_SIMPLE);
	sort(contours.begin(), contours.end(), compareContourAreas());

	//drawContours(img, contours, -1, Scalar(255, 0, 255), 2);
	vector<RotatedRect> minRect(contours.size());
	for (size_t i = 0; i < contours.size(); i++)
	{
		minRect[i] = minAreaRect(contours[i]);
	}

	for (int i = 0; i < contours.size(); i++)
	{
		int area = contourArea(contours[i]);
		//cout << area << endl;
		Point2f rect_points[4];
		minRect[i].points(rect_points);

		if (area > 1000)
		{
			t++;
			for (int j = 0; j < 4; j++)
			{
				line(img, rect_points[j], rect_points[(j + 1) % 4], Scalar(0, 255, 0), 2);
				//cout << rect_points[j] << endl;
			}
			mid_a = (rect_points[0] + rect_points[1]) / 2;
			mid_b = (rect_points[1] + rect_points[2]) / 2;
			mid_c = (rect_points[2] + rect_points[3]) / 2;
			mid_d = (rect_points[3] + rect_points[0]) / 2;
			//line(img, mid_a, mid_c, Scalar(0, 255, 255), 1);
			//line(img, mid_b, mid_d, Scalar(0, 255, 255), 1);
			approxPolyDP(Mat(contours[i]), approx, arcLength(Mat(contours[i]), true) * 0.02, true);
			if (approx.size() == 4 && t == 1)//(approx.size() >= 8 && t == 1)
			{
				//cout << approx.size() << endl;
				P1 = (double)norm(mid_a - mid_c) / 9.88;
				P2 = (double)norm(mid_b - mid_d) / 10;
			}
			//cout << approx.size() << endl;
			//double P1 = (double)254.017 / 18.88;
			//double P2 = (double)254.912 / 18.88;
			res = (double)norm(mid_a - mid_c) / P1;
			res1 = (double)norm(mid_b - mid_d) / P2;
			if (res != 9.88 || res1 != 10)
			{
				if (res > res1)
				{
					output = roundf(res * 100) / 100;
				}
				else
				{
					output = roundf(res1 * 100) / 100;
				}
			}
			else
			{
				output = 0;
			}
			//cout << norm(mid_a - mid_c) << endl;
			//cout << norm(mid_b - mid_d) << endl;
			//cout << res << endl;
			//cout << res1 << endl;
			//drawContours(img, contours, i, Scalar(255, 0, 255), 2);
			cv::Point textOrg(mid_b.x - 10, mid_b.y - 5);
			string someText = format(" %.2lf mm", res);
			putText(img, someText, textOrg, FONT_HERSHEY_PLAIN, 1.5, Scalar(0, 0, 255), 2);

			cv::Point textOrg1(mid_a.x - 50, mid_a.y - 10);
			string someText1 = format(" %.2lf mm", res1);
			putText(img, someText1, textOrg1, FONT_HERSHEY_PLAIN, 1.5, Scalar(0, 0, 255), 2);

		}

	}
}

bool MyOpenCvWrapper::getNeedleLength(int gaussianBlurKsize, int threshold1, int threshold2, double width, double height)
{
	videoCapture.read(imgSource);
	if (imgSource.empty())
	{
		return false;
	}
	else
	{
		//resize(imgSource, imgSource, cv::Size(imgSource.size().width * width / 100, imgSource.size().height * height / 100), INTER_LINEAR);
		//resize(imgSource, imgSource, cv::Size(), width / 100, height / 100, INTER_LINEAR);
		resize(imgSource, imgSource, cv::Size(imgSource.size().width * 50 / 100, imgSource.size().height * 50 / 100), INTER_LINEAR);
		
		//imgOutput = imgSource;
		imgSource = imgSource(Range(15, imgSource.rows - 100), Range(0, imgSource.cols));
		imgSource.copyTo(imgOutput);
		imgSource.copyTo(imgCannyDisplay);

		cvtColor(imgOutput, imgGray, COLOR_RGB2GRAY);
		//equalizeHist(imgGray, imgEqualizeHist);
		GaussianBlur(imgGray, imgGaussianBlur, cv::Size(gaussianBlurKsize, gaussianBlurKsize), 0);

		Canny(imgGaussianBlur, imgCanny, threshold1, threshold2);
		Mat kernel = getStructuringElement(MORPH_RECT, cv::Size(3, 3));
		dilate(imgCanny, imgDilate, kernel);
		erode(imgDilate, imgErode, kernel);
		getContours(imgErode, imgOutput);
		return true;
	}
}

Bitmap^ MyOpenCvWrapper::MatToBitmap(UMat image, double width, double height)
{
	resize(image, image, cv::Size(), width / 100, height / 100, INTER_LINEAR);
	Mat img = image.getMat(ACCESS_READ);
	if (img.data == nullptr)
		return nullptr;
	if (img.type() != CV_8UC3 && img.type() != CV_8UC4 && img.type() != CV_8UC1)
	{
		throw gcnew NotSupportedException("Only images of type CV_8UC3, CV_8UC4, CV_8UC1 are supported for conversion to Bitmap");
	}

	//create the bitmap and get the pointer to the data
	Bitmap^ bmpimg = gcnew Bitmap(img.cols, img.rows, PixelFormat::Format24bppRgb);
	BitmapData^ data;

	if (img.type() == CV_8UC3)
		data = bmpimg->LockBits(System::Drawing::Rectangle(0, 0, img.cols, img.rows), ImageLockMode::WriteOnly, PixelFormat::Format24bppRgb);
	else if (img.type() == CV_8UC4)
		data = bmpimg->LockBits(System::Drawing::Rectangle(0, 0, img.cols, img.rows), ImageLockMode::WriteOnly, PixelFormat::Format32bppRgb);
	else if (img.type() == CV_8UC1)
		data = bmpimg->LockBits(System::Drawing::Rectangle(0, 0, img.cols, img.rows), ImageLockMode::WriteOnly, PixelFormat::Format8bppIndexed);

	byte* dstData = reinterpret_cast<byte*>(data->Scan0.ToPointer());

	unsigned char* srcData = img.data;

	for (int row = 0; row < data->Height; ++row)
	{
		memcpy(reinterpret_cast<void*>(&dstData[row * data->Stride]), reinterpret_cast<void*>(&srcData[row * img.step]), img.cols * img.channels());
	}

	bmpimg->UnlockBits(data);
	delete(data);
	img.release();
	return bmpimg;
}

void MyOpenCvWrapper::getColor(int LowR, int LowG, int LowB, int HighR, int HighG, int HighB)
{
	vector<vector<cv::Point>>imgColor;
	vector<Vec4i>hierarchy;
	//inRange(videoFrame, Scalar(50, 90, 130), Scalar(80, 100, 145), mask);
	inRange(imgOutput, Scalar(LowB, LowG, LowR), Scalar(HighB, HighG, HighR), mask);
	//inRange(videoFrame, Scalar(50, 90, 130), Scalar(80, 110, 150), mask);
	dilate(mask, mask, getStructuringElement(MORPH_RECT, cv::Size(3, 3)));
	erode(mask, mask, getStructuringElement(MORPH_RECT, cv::Size(3, 3)));
	findContours(mask, imgColor, hierarchy, RETR_EXTERNAL, CHAIN_APPROX_SIMPLE);
	if (imgColor.size() > 5)
		color = 1;
	else
		color = 0;
	drawContours(imgOutput, imgColor, -1, Scalar(255, 0, 255), 2);
}

int MyOpenCvWrapper::Color()
{
	return color;
}

double MyOpenCvWrapper::needleLength()
{
	return output;
}

void MyOpenCvWrapper::captureCam()
{
	UMat image;
	videoCapture.read(image);
	imshow("Image Window", image);
}

void MyOpenCvWrapper::Display_Mode(char mode, int brightness, float contrast, bool onoffDetect)
{
	vector<UMat> rgbChannels(3), channels;

	if (onoffDetect)
		split(imgOutput, rgbChannels);
	else
		split(imgSource, rgbChannels);

	g = UMat::zeros(imgSource.size(), CV_8UC1);

	switch (mode)
	{
	case 'R':
		channels.push_back(g);
		channels.push_back(g);
		channels.push_back(rgbChannels[2]);
		merge(channels, imgMode);
		break;
	case 'G':
		channels.push_back(g);
		channels.push_back(rgbChannels[1]);
		channels.push_back(g);
		merge(channels, imgMode);
		break;
	case 'B':
		channels.push_back(rgbChannels[0]);
		channels.push_back(g);
		channels.push_back(g);
		merge(channels, imgMode);
		break;
	case 'N':
		if (onoffDetect)
			imgMode = imgOutput;
		else
			imgMode = imgSource;
		break;
	}
	imgMode.convertTo(fin_img, -1, contrast, brightness);
}

void MyOpenCvWrapper::User_Display_Mode(char mode, int brightness, float contrast, int user_brightness, float user_contrast)
{
	vector<UMat> rgbChannels(3), rgbChannels_1(3), channels, channels_1;
	split(imgOutput, rgbChannels);
	split(imgSource, rgbChannels_1);
	g = UMat::zeros(imgOutput.size(), CV_8UC1);
	g1 = UMat::zeros(imgSource.size(), CV_8UC1);

	switch (mode)
	{
	case 'R':
		channels.push_back(g);
		channels.push_back(g);
		channels.push_back(rgbChannels[2]);
		merge(channels, imgUserMode);

		channels_1.push_back(g1);
		channels_1.push_back(g1);
		channels_1.push_back(rgbChannels_1[2]);
		merge(channels_1, imgUserMode_1);
		break;
	case 'G':
		channels.push_back(g);
		channels.push_back(rgbChannels[1]);
		channels.push_back(g);
		merge(channels, imgUserMode);

		channels_1.push_back(g1);
		channels_1.push_back(rgbChannels_1[1]);
		channels_1.push_back(g1);
		merge(channels_1, imgUserMode_1);
		break;
	case 'B':
		channels.push_back(rgbChannels[0]);
		channels.push_back(g);
		channels.push_back(g);
		merge(channels, imgUserMode);

		channels_1.push_back(rgbChannels_1[0]);
		channels_1.push_back(g1);
		channels_1.push_back(g1);
		merge(channels_1, imgUserMode_1);
		break;
	case 'N':
		imgUserMode = imgOutput;
		imgUserMode_1 = imgSource;
		break;
	}

	imgUserMode.convertTo(fin_img, -1, contrast, brightness);
	imgUserMode_1.convertTo(imgSource, -1, contrast, brightness);

	fin_img.convertTo(fin_img, -1, user_contrast, user_brightness);
	imgSource.convertTo(imgSource, -1, user_contrast, user_brightness);
}

Bitmap^ MyOpenCvWrapper::displaySrc(double width, double height)
{
	//resize(imgSource, imgSource, cv::Size(), width / 100, height / 100, INTER_LINEAR);
	return MatToBitmap(imgSource, width, height);
}

Bitmap^ MyOpenCvWrapper::displayDst(double width, double height)
{
	//resize(fin_img, fin_img, cv::Size(), width / 100, height / 100, INTER_LINEAR);
	return MatToBitmap(fin_img, width, height);
}

Bitmap^ MyOpenCvWrapper::displayCanny(int gaussianBlurKsize, int threshold1, int threshold2, double width, double height)
{
	//resize(imgCannyDisplay, imgCannyDisplay, cv::Size(), width / 100, height / 100, INTER_LINEAR);
	/*cvtColor(imgCannyDisplay, imgCannyDisplay, COLOR_RGB2GRAY);
	GaussianBlur(imgCannyDisplay, imgCannyDisplay, cv::Size(gaussianBlurKsize, gaussianBlurKsize), 0);
	Canny(imgCannyDisplay, imgCannyDisplay, threshold1, threshold2);*/

	return MatToBitmap(imgCanny, width, height);
}