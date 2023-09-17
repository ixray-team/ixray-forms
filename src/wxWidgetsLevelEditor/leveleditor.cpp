// LevelEditor.cpp : Defines the entry point for the application.
//

//#include "stdafx.h"
#include "main.h"
#include "leveleditor.h"

/*
#include "../ECore/Editor/LogForm.h"
#include "../ECore/Editor/EditMesh.h"

#include "Edit/UI_LevelMain.h"
#include "Edit/UI_LevelTools.h"
*/

IMPLEMENT_APP(LevelEditor);
DECLARE_APP(LevelEditor);

bool LevelEditor::OnInit()
{
    wxInitAllImageHandlers();

    wxBitmap bitmap = wxBITMAP_PNG(IDB_PNG_LEVEL_SPLASH);

    wxSplashScreen* splash = new wxSplashScreen(bitmap,
        wxSPLASH_CENTRE_ON_SCREEN | wxSPLASH_TIMEOUT,
        2000, nullptr, -1, wxDefaultPosition, wxDefaultSize,
        wxBORDER_NONE | wxSTAY_ON_TOP);
    splash->CreateStatusBar(1);
    splash->SetStatusText(wxT("\t\t\t\t\t\t\t\t\t\t\tCore initializing..."), 0);

    //'Core._initialize("level", ELogCallback);
//    CEditableMesh::m_bDraftMeshMode = true;

    splash->SetStatusText(wxT("\t\t\t\t\t\t\t\t\t\t\t\tLoading..."), 0);

    /*
    Tools = xr_new<CLevelTool>();
    UI = xr_new<CLevelMain>();
    UI->RegisterCommands();
    */

    Main* main = new Main(wxT("Level Editor"));
    main->SetIcon(wxIcon(wxT("IDI_ICON1"), wxBITMAP_TYPE_ICO_RESOURCE));
    main->Show(true);

    return true;
}

LevelEditor::~LevelEditor()
{
    /*
   xr_delete(Scene);
   xr_delete(Tools);
   xr_delete(UI);
   */

   //Core._destroy();

   //splash->Destroy();
}