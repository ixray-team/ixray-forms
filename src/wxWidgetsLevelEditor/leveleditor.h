#ifndef leveleditor_h
#define leveleditor_h

#include <wx/wx.h>
#include <wx/frame.h>
#include <wx/splash.h>

class LevelEditor : public wxApp
{
public:
    virtual bool OnInit();
    ~LevelEditor();
};

#endif
