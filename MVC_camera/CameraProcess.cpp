#include "CameraProcess.h"

using namespace CameraProcess;
using namespace std;

void MyClass::initCamera()
{
	if (m_bConnect)
		return;

	int nIndex = 0;
	ULONG i = 0;
	int rt = MV_Usb2Init("MVC-F", &nIndex, &m_CapInfo, &m_hMVC1000);

	if (ResSuccess != rt)
	{
		MV_Usb2Uninit(&m_hMVC1000);
		m_hMVC1000 = NULL;
		return;
	}
	m_bConnect = TRUE;
	m_bMVC1000M = TRUE;

}
void MyClass::startCamera()
{

}