#include "pch.h"

#include "OpenCvDotNet.h"

using namespace OpenCvDotNet;
using namespace cv;
using namespace std;

typedef unsigned char byte;
//VideoCapture videoCapture("http://192.168.50.130:4747/video");
VideoCapture videoCapture(0);
UMat videoFrame, videoFrame1, videoFrame2, videoFrame3, videoFrame4, videoFrame5, videoFrame6;
UMat mask;
int th1, th2, color;
UMat imgGray, imgBlur, imgCanny, imgDilate, imgErode;
double output;

struct compareContourAreas
{
    bool operator ()(const vector<cv::Point>& a, const vector<cv::Point>& b)
    {
        Rect ra(boundingRect(a));
        Rect rb(boundingRect(b));
        return (ra.x > rb.x);
    }
};

void MyOpenCvWrapper::getContours(UMat imgDilate, UMat img)
{
    vector<vector<cv::Point>>contours;
    vector<Vec4i>hierarchy;
    vector<cv::Point> approx;
    Point2f mid_a, mid_b, mid_c, mid_d;
    double res, res1, P1, P2;
    int t = 0;
    P1 = 1;
    P2 = 1;
    findContours(imgDilate, contours, hierarchy, RETR_EXTERNAL, CHAIN_APPROX_SIMPLE);
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
            if (approx.size() >= 8 && t == 1)
            {
                //cout << approx.size() << endl;
                P1 = (double)norm(mid_a - mid_c) / 18.88;
                P2 = (double)norm(mid_b - mid_d) / 18.88;
            }
            //cout << approx.size() << endl;
            //double P1 = (double)254.017 / 18.88;
            //double P2 = (double)254.912 / 18.88;
            res = (double)norm(mid_a - mid_c) / P1;
            res1 = (double)norm(mid_b - mid_d) / P2;
            if (res != 18.88 || res1 != 18.88)
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
            cv::Point textOrg(mid_b.x - 10, mid_b.y - 10);
            string someText = format(" %.2lf mm", res);
            putText(img, someText, textOrg, FONT_HERSHEY_PLAIN, 1.5, Scalar(0, 0, 255), 2);

            cv::Point textOrg1(mid_a.x - 50, mid_a.y - 10);
            string someText1 = format(" %.2lf mm", res1);
            putText(img, someText1, textOrg1, FONT_HERSHEY_PLAIN, 1.5, Scalar(0, 0, 255), 2);

        }

    }
}

void MyOpenCvWrapper::Image()
{
    string path = "/Users/MyPC/Desktop/testopencv/test8.png";
    //string path = "/Users/MyPC/Desktop/testopencv/test.png";
    Mat img;// = imread(path);
    videoCapture.read(img);
    UMat test = img.getUMat(ACCESS_READ);
    cvtColor(test, imgGray, COLOR_BGR2GRAY);
    GaussianBlur(imgGray, imgBlur, cv::Size(3, 3), 3, 0);
    //bilateralFilter(imgGray, imgBlur, 1, 10, 0);
    //adaptiveThreshold(imgGray, imgBlur, 255, ADAPTIVE_THRESH_GAUSSIAN_C, THRESH_BINARY, 3, 2);
    //threshold(imgGray, imgBlur, ADAPTIVE_THRESH_MEAN_C, 255, THRESH_BINARY);
    Canny(imgBlur, imgCanny, th1, th2);
    Mat kernel = getStructuringElement(MORPH_RECT, cv::Size(3, 3));
    dilate(imgCanny, imgDilate, kernel);
    erode(imgDilate, imgErode, kernel);
    getContours(imgErode, test);
     
    imshow("Image", test);
}

void MyOpenCvWrapper::ApplyFilter1() 
{
    videoCapture.read(videoFrame);
    resize(videoFrame, videoFrame, cv::Size(videoFrame.size().width * 60 / 100, videoFrame.size().height * 60 / 100), INTER_LINEAR);

    //inRange(videoFrame, Scalar(lowB, lowG, lowR), Scalar(highB, highG, highR), mask);
    
    cvtColor(videoFrame, videoFrame1, COLOR_RGB2GRAY); 
    equalizeHist(videoFrame1, videoFrame6);
    GaussianBlur(videoFrame6, videoFrame2, cv::Size(5, 5), 0);
    
    //threshold(videoFrame1, videoFrame2, 50, 255, THRESH_BINARY);
    Canny(videoFrame2, videoFrame3, th1, th2);
    Mat kernel = getStructuringElement(MORPH_RECT, cv::Size(3, 3));
    dilate(videoFrame3, videoFrame4, kernel);
    erode(videoFrame4, videoFrame5, kernel);    
    getContours(videoFrame5, videoFrame);        
}

Bitmap^ MyOpenCvWrapper::MatToBitmap(UMat image)
{
    Mat img = image.getMat(ACCESS_READ);
    if (img.data == nullptr)
        return nullptr;
    if (img.type() != CV_8UC3 && img.type() != CV_8UC4 && img.type() != CV_8UC1)
    {
        throw gcnew NotSupportedException("Only images of type CV_8UC3 are supported for conversion to Bitmap");
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

void MyOpenCvWrapper::getColor()
{
    vector<vector<cv::Point>>imgColor;
    vector<Vec4i>hierarchy;    
    //inRange(videoFrame, Scalar(50, 90, 130), Scalar(80, 100, 145), mask);
    inRange(videoFrame, Scalar(50, 90, 130), Scalar(80, 110, 150), mask);
    dilate(mask, mask, getStructuringElement(MORPH_RECT, cv::Size(3, 3)));
    erode(mask, mask, getStructuringElement(MORPH_RECT, cv::Size(3, 3)));
    findContours(mask, imgColor, hierarchy, RETR_EXTERNAL, CHAIN_APPROX_SIMPLE);
    if (imgColor.size() > 5)
        color = 1;
    else
        color = 0;
    drawContours(videoFrame, imgColor, -1, Scalar(255, 0, 255), 2);
}

int MyOpenCvWrapper::Color()
{
    return color;
}

double MyOpenCvWrapper::ApplyFilter()
{    
    return output;
}

void MyOpenCvWrapper::trackbar(int threshold1, int threshold2)
{
    th1 = threshold1;
    th2 = threshold2;    
}

void MyOpenCvWrapper::captureCam()
{
    UMat image;
    videoCapture.read(image);
    imshow("Image Window", image);
}

Bitmap^ MyOpenCvWrapper::displaySrc()
{
    return MatToBitmap(videoFrame);
}

Bitmap^ MyOpenCvWrapper::display()
{    
    return MatToBitmap(videoFrame3);
}