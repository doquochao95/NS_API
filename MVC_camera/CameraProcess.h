#pragma once

#include <afxwin.h>         // MFC core and standard components
#include <afxext.h>         // MFC extensions
#include <afxdisp.h>        // MFC Automation classes
#include <afxdtctl.h>		// MFC support for Internet Explorer 4 Common Controls

#include <MVCAPI.h>

namespace CameraProcess {
	class MyClass
	{
	public:
		
		BOOL m_bMVC1000M;//
		HANDLE m_hMVC1000;//
		struct CapInfoStruct m_CapInfo; //
		BOOL m_bConnect;//

		void initCamera();
		void startCamera();

	private:

	};
}