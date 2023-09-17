//---------------------------------------------------------------------------
#ifndef main_h
#define main_h

#include <wx/wx.h>
#include <wx/aui/aui.h>

class Main : public wxFrame
{
public:
    Main(const wxString& title);
    ~Main();

private:
    wxAuiManager m_mgr;
};

#endif main_h