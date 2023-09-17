// wxEditors.cpp : Defines the entry point for the application.crt
//
#include <wx/aui/aui.h>
#include <wx/collpane.h>
#include <wx/toolbar.h>
#include <wx/aui/auibar.h>

#include "leveleditor.h"
#include "main.h"

Main::Main(const wxString& title)
    : wxFrame(nullptr, wxID_ANY, title, wxDefaultPosition, wxSize(1920, 1024))
{
    Centre();

    wxMenuBar* menuBar = new wxMenuBar;

    wxMenu* fileMenu = new wxMenu;
    wxMenu* openRecent = new wxMenu;
    fileMenu->Append(wxID_ANY, wxT("&Clear"));
    fileMenu->Append(wxID_ANY, wxT("&Open"));
    fileMenu->Append(wxID_ANY, wxT("&Save"));
    fileMenu->Append(wxID_ANY, wxT("&Save As..."));
    fileMenu->AppendSeparator();
    fileMenu->Append(wxID_ANY, wxT("&Open Selection..."));
    fileMenu->Append(wxID_ANY, wxT("&Save Selection..."));
    fileMenu->AppendSeparator();
    fileMenu->Append(wxID_ANY, wxT("&Make Pack..."));
    fileMenu->AppendSubMenu(openRecent, wxT("&Open Recent"));
    fileMenu->AppendSeparator();
    fileMenu->Append(wxID_ANY, wxT("&Quit"));

    wxMenu* sceneMenu = new wxMenu();
    sceneMenu->Append(wxID_ANY, wxT("&Options"));
    sceneMenu->AppendSeparator();
    sceneMenu->Append(wxID_ANY, wxT("&Validate"));
    sceneMenu->AppendSeparator();
    sceneMenu->Append(wxID_ANY, wxT("&Summary Info"));
    sceneMenu->Append(wxID_ANY, wxT("&Highlight Texture"));
    sceneMenu->AppendSeparator();
    sceneMenu->Append(wxID_ANY, wxT("&Clear Debug Draw"));
    sceneMenu->AppendSeparator();
    sceneMenu->Append(wxID_ANY, wxT("&Export Entire Scene As Object"));
    sceneMenu->Append(wxID_ANY, wxT("&Export Selection As Object"));
    sceneMenu->AppendSeparator();
    sceneMenu->Append(wxID_ANY, wxT("&Light Anim Editor"));
    sceneMenu->Append(wxID_ANY, wxT("&Object List"));
    sceneMenu->Append(wxID_ANY, wxT("&Preferences"));
  
    wxMenu* compileMenu = new wxMenu();
    compileMenu->Append(wxID_ANY, wxT("&Build"));
    compileMenu->AppendSeparator();
    compileMenu->Append(wxID_ANY, wxT("&Make Game"));
    compileMenu->Append(wxID_ANY, wxT("&Make Details"));
    compileMenu->Append(wxID_ANY, wxT("&Make HOM"));
    compileMenu->Append(wxID_ANY, wxT("&Make Sound Occluder"));
    compileMenu->Append(wxID_ANY, wxT("&Make AI-Map"));
    compileMenu->AppendSeparator();
    compileMenu->Append(wxID_ANY, wxT("&Import Error List"));
    compileMenu->Append(wxID_ANY, wxT("&Export Error List"));
    compileMenu->Append(wxID_ANY, wxT("&Clear Error List"));

    wxMenu* imagesMenu = new wxMenu();
    imagesMenu->Append(wxID_ANY, wxT("&Image Editor"));
    imagesMenu->AppendSeparator();
    imagesMenu->Append(wxID_ANY, wxT("&Reload Textures"));
    imagesMenu->Append(wxID_ANY, wxT("&Synchronize Textures"));
    imagesMenu->Append(wxID_ANY, wxT("&Check New Textures"));
    imagesMenu->AppendSeparator();
    imagesMenu->Append(wxID_ANY, wxT("&Edit minimap"));
    imagesMenu->Append(wxID_ANY, wxT("&SyncTHM"));

    wxMenu* soundMenu = new wxMenu();
    soundMenu->Append(wxID_ANY, wxT("&Sound Editor"));
    soundMenu->AppendSeparator();
    soundMenu->Append(wxID_ANY, wxT("&Synchronize Sounds"));
    soundMenu->AppendSeparator();
    soundMenu->Append(wxID_ANY, wxT("&Refresh Environment Library"));
    soundMenu->Append(wxID_ANY, wxT("&Refresh Environment Geometry"));

    wxMenu* toolsMenu = new wxMenu();

    wxMenu* editMenu = new wxMenu();
    editMenu->Append(wxID_ANY, wxT("Cut"));
    editMenu->Append(wxID_ANY, wxT("Copy"));
    editMenu->Append(wxID_ANY, wxT("Paste"));
    editMenu->Append(wxID_ANY, wxT("Delete"));
    toolsMenu->AppendSubMenu(editMenu, wxT("Edit"));

    wxMenu* selectionMenu = new wxMenu();
    selectionMenu->Append(wxID_ANY, wxT("Invert"));
    selectionMenu->Append(wxID_ANY, wxT("Select All"));
    selectionMenu->Append(wxID_ANY, wxT("Unselect All"));
    toolsMenu->AppendSubMenu(selectionMenu, wxT("Selection"));

    wxMenu* visibilityMenu = new wxMenu();
    visibilityMenu->Append(wxID_ANY, wxT("Hide Selected"));
    visibilityMenu->Append(wxID_ANY, wxT("Hide Unselected"));
    visibilityMenu->Append(wxID_ANY, wxT("Hide All"));
    visibilityMenu->AppendSeparator();
    visibilityMenu->Append(wxID_ANY, wxT("Unhide All"));

    toolsMenu->AppendSubMenu(visibilityMenu, wxT("Visibility"));
    toolsMenu->AppendSeparator();
    toolsMenu->Append(wxID_ANY, wxT("Properties"));
    toolsMenu->Append(wxID_ANY, wxT("Multi Rename"));

    wxMenu* optionsMenu = new wxMenu();
    wxMenu* renderMenu = new wxMenu();
    wxMenu* qualityMenu = new wxMenu();
    wxMenu* fillModeMenu = new wxMenu();
    wxMenu* shadeModeMenu = new wxMenu();
    wxMenu* weatherMenu = new wxMenu();
    wxMenu* deviceMenu = new wxMenu();
    wxMenu* timeFactor = new wxMenu();

    optionsMenu->AppendSubMenu(renderMenu, wxT("Render"));
    renderMenu->AppendSubMenu(qualityMenu, wxT("Quality"));
    qualityMenu->AppendRadioItem(wxID_ANY, wxT("25%"));
    qualityMenu->AppendRadioItem(wxID_ANY, wxT("50%"));
    qualityMenu->AppendRadioItem(wxID_ANY, wxT("75%"));
    qualityMenu->AppendRadioItem(wxID_ANY, wxT("100%"));
    qualityMenu->AppendRadioItem(wxID_ANY, wxT("125%"));
    qualityMenu->AppendRadioItem(wxID_ANY, wxT("150%"));
    qualityMenu->AppendRadioItem(wxID_ANY, wxT("175%"));
    qualityMenu->AppendRadioItem(wxID_ANY, wxT("200%"));
    fillModeMenu->AppendRadioItem(wxID_ANY, wxT("Point"));
    fillModeMenu->AppendRadioItem(wxID_ANY, wxT("Wireframe"));
    fillModeMenu->AppendRadioItem(wxID_ANY, wxT("Solid"));
    shadeModeMenu->AppendRadioItem(wxID_ANY, wxT("Flat"));
    shadeModeMenu->AppendRadioItem(wxID_ANY, wxT("Gouraud"));
    renderMenu->AppendSubMenu(fillModeMenu, wxT("Fill Mode"));
    renderMenu->AppendSubMenu(shadeModeMenu, wxT("Shade Mode"));
    renderMenu->AppendCheckItem(wxID_ANY, wxT("Edged Faces"));
    renderMenu->AppendSeparator();
    renderMenu->AppendCheckItem(wxID_ANY, wxT("HW Filter"));
    renderMenu->AppendSeparator();
    renderMenu->AppendCheckItem(wxID_ANY, wxT("Linear Filter"));
    renderMenu->AppendCheckItem(wxID_ANY, wxT("Textures"));
    optionsMenu->AppendCheckItem(wxID_ANY, wxT("Draw Safe Rec"));
    optionsMenu->AppendCheckItem(wxID_ANY, wxT("Draw Grid"));
    optionsMenu->AppendSeparator();
    optionsMenu->AppendSubMenu(weatherMenu, wxT("Weather"));
    weatherMenu->AppendRadioItem(wxID_ANY, wxT("None"));
    weatherMenu->AppendSeparator();
    weatherMenu->Append(wxID_ANY, wxT("Reload"));
    weatherMenu->AppendSeparator();
    weatherMenu->Append(wxID_ANY, wxT("Properties"));
    optionsMenu->AppendCheckItem(wxID_ANY, wxT("Fog"));
    optionsMenu->AppendSeparator();
    optionsMenu->AppendCheckItem(wxID_ANY, wxT("Mute Sounds"));
    optionsMenu->AppendCheckItem(wxID_ANY, wxT("Light Scene"));
    optionsMenu->AppendCheckItem(wxID_ANY, wxT("Real Time"));
    optionsMenu->AppendSubMenu(deviceMenu, wxT("Device"));
    deviceMenu->AppendSubMenu(timeFactor, wxT("Time Factor"));
    timeFactor->AppendRadioItem(wxID_ANY, wxT("0.05"));
    timeFactor->AppendRadioItem(wxID_ANY, wxT("0.1"));
    timeFactor->AppendRadioItem(wxID_ANY, wxT("0.2"));
    timeFactor->AppendRadioItem(wxID_ANY, wxT("0.3"));
    timeFactor->AppendRadioItem(wxID_ANY, wxT("0.5"));
    timeFactor->AppendRadioItem(wxID_ANY, wxT("1"));
    timeFactor->AppendRadioItem(wxID_ANY, wxT("3"));
    timeFactor->AppendRadioItem(wxID_ANY, wxT("5"));
    timeFactor->AppendRadioItem(wxID_ANY, wxT("10"));

    wxMenu* macroMenu = new wxMenu();
    wxMenu* macroOne = new wxMenu();
    wxMenu* macroTwo = new wxMenu();
    wxMenu* macroThree = new wxMenu();
    wxMenu* macroFour = new wxMenu();
    wxMenu* macroFive = new wxMenu();
    wxMenu* macroSix = new wxMenu();
    wxMenu* macroSeven = new wxMenu();
    wxMenu* macroEight = new wxMenu();

    macroMenu->AppendSubMenu(macroOne, wxT("1: Empty"));
    macroOne->Append(wxID_ANY, wxT("Execute"));
    macroOne->Append(wxID_ANY, wxT("Assign"));
    macroOne->Append(wxID_ANY, wxT("Clear"));

    macroMenu->AppendSubMenu(macroTwo, wxT("2: Empty"));
    macroTwo->Append(wxID_ANY, wxT("Execute"));
    macroTwo->Append(wxID_ANY, wxT("Assign"));
    macroTwo->Append(wxID_ANY, wxT("Clear"));

    macroMenu->AppendSubMenu(macroThree, wxT("3: Empty"));
    macroThree->Append(wxID_ANY, wxT("Execute"));
    macroThree->Append(wxID_ANY, wxT("Assign"));
    macroThree->Append(wxID_ANY, wxT("Clear"));

    macroMenu->AppendSubMenu(macroFour, wxT("4: Empty"));
    macroFour->Append(wxID_ANY, wxT("Execute"));
    macroFour->Append(wxID_ANY, wxT("Assign"));
    macroFour->Append(wxID_ANY, wxT("Clear"));

    macroMenu->AppendSubMenu(macroFive, wxT("5: Empty"));
    macroFive->Append(wxID_ANY, wxT("Execute"));
    macroFive->Append(wxID_ANY, wxT("Assign"));
    macroFive->Append(wxID_ANY, wxT("Clear"));

    macroMenu->AppendSubMenu(macroSix, wxT("6: Empty"));
    macroSix->Append(wxID_ANY, wxT("Execute"));
    macroSix->Append(wxID_ANY, wxT("Assign"));
    macroSix->Append(wxID_ANY, wxT("Clear"));

    macroMenu->AppendSubMenu(macroSeven, wxT("7: Empty"));
    macroSeven->Append(wxID_ANY, wxT("Execute"));
    macroSeven->Append(wxID_ANY, wxT("Assign"));
    macroSeven->Append(wxID_ANY, wxT("Clear"));

    macroMenu->AppendSubMenu(macroEight, wxT("8: Empty"));
    macroEight->Append(wxID_ANY, wxT("Execute"));
    macroEight->Append(wxID_ANY, wxT("Assign"));
    macroEight->Append(wxID_ANY, wxT("Clear"));

    macroMenu->Append(wxID_ANY, wxT("Edit Command List"));
    macroMenu->AppendCheckItem(wxID_ANY, wxT("Log Commands"));

    menuBar->Append(fileMenu, wxT("&File"));
    menuBar->Append(sceneMenu, wxT("&Scene"));
    menuBar->Append(compileMenu, wxT("&Compile"));
    menuBar->Append(imagesMenu, wxT("&Images"));
    menuBar->Append(soundMenu, wxT("&Sounds"));
    menuBar->Append(toolsMenu, wxT("&Tools"));
    menuBar->Append(optionsMenu, wxT("&Options"));
    menuBar->Append(macroMenu, wxT("&Macro"));

    SetMenuBar(menuBar);

    // notify wxAUI which frame to use
    m_mgr.SetManagedWindow(this);

    wxPanel* editPanel = new wxPanel(this, wxID_ANY, wxDefaultPosition, 
        wxSize(220, 1024), wxTAB_TRAVERSAL);

    wxPanel* toolbarPanel = new wxPanel(this, wxID_ANY, wxDefaultPosition, 
        wxSize(155, 1024), wxTAB_TRAVERSAL);

    wxToolBar* toolBar = new wxToolBar(toolbarPanel, wxID_ANY, wxDefaultPosition, 
        wxSize(155, 400), wxTB_HORIZONTAL | wxTB_FLAT | wxTB_NODIVIDER, wxT(""));

    wxBoxSizer* vbox = new wxBoxSizer(wxVERTICAL);
    wxBoxSizer* hbox = new wxBoxSizer(wxHORIZONTAL);

    wxBitmap undo = wxBITMAP_PNG(IDB_PNG_UNDO);
    wxBitmap redo = wxBITMAP_PNG(IDB_PNG_REDO);
    wxBitmap select = wxBITMAP_PNG(IDB_PNG_SELECT);
    wxBitmap add = wxBITMAP_PNG(IDB_PNG_ADD);
    wxBitmap move = wxBITMAP_PNG(IDB_PNG_MOVE);
    wxBitmap rotate = wxBITMAP_PNG(IDB_PNG_ROTATE);
    wxBitmap scale = wxBITMAP_PNG(IDB_PNG_SCALE);
    wxBitmap restrictX = wxBITMAP_PNG(IDB_PNG_RESTRICTX);
    wxBitmap restrictY = wxBITMAP_PNG(IDB_PNG_RESTRICTY);
    wxBitmap restrictZ = wxBITMAP_PNG(IDB_PNG_RESTRICTZ);
    wxBitmap restrictZX = wxBITMAP_PNG(IDB_PNG_RESTRICTZX);
    wxBitmap csToggle = wxBITMAP_PNG(IDB_PNG_PARENTCSTOGGLE);
    wxBitmap nuScale = wxBITMAP_PNG(IDB_PNG_NUSCALE);
    wxBitmap gSnap = wxBITMAP_PNG(IDB_PNG_GSNAP);
    wxBitmap oSnap = wxBITMAP_PNG(IDB_PNG_OSNAP);
    wxBitmap oSnapToToggle = wxBITMAP_PNG(IDB_PNG_OSNAP_TOGGLE);
    wxBitmap nSnap = wxBITMAP_PNG(IDB_PNG_NORMAL_SNAP);
    wxBitmap vSnap = wxBITMAP_PNG(IDB_PNG_VERTEX_SNAP);
    wxBitmap aSnap = wxBITMAP_PNG(IDB_PNG_ANGLE_SNAP);
    wxBitmap mSnap = wxBITMAP_PNG(IDB_PNG_MOVING_SNAP);
    wxBitmap zoom = wxBITMAP_PNG(IDB_PNG_ZOOM);
    wxBitmap zoomSelected = wxBITMAP_PNG(IDB_PNG_ZOOM_SELECT);
    wxBitmap frontView = wxBITMAP_PNG(IDB_PNG_FRONT_VIEW);
    wxBitmap backView = wxBITMAP_PNG(IDB_PNG_BACK_VIEW);
    wxBitmap leftView = wxBITMAP_PNG(IDB_PNG_LEFT_VIEW);
    wxBitmap rightView = wxBITMAP_PNG(IDB_PNG_RIGHT_VIEW);
    wxBitmap topView = wxBITMAP_PNG(IDB_PNG_TOP_VIEW);
    wxBitmap resetView = wxBITMAP_PNG(IDB_PNG_RESET_VIEW);
    wxBitmap zoomExtends = wxBITMAP_PNG(IDB_PNG_ZOOM_EXTENDS);
    wxBitmap zoomExtendsSel = wxBITMAP_PNG(IDB_PNG_ZOOM_EXTENDSSEL);
    wxBitmap zoomExtendsSelF = wxBITMAP_PNG(IDB_PNG_ZESA);

    toolBar->AddTool(wxID_ANY, wxT("Undo"), undo, wxT("Undo"));
    toolBar->AddTool(wxID_ANY, wxT("Redo"), redo, wxT("Redo"));
    toolBar->AddTool(wxID_ANY, wxT("Select"), select, wxT("Select"));
    toolBar->AddTool(wxID_ANY, wxT("Add"), add, wxT("Add"));
    toolBar->AddTool(wxID_ANY, wxT("Move"), move, wxT("Move"));
    toolBar->AddTool(wxID_ANY, wxT("Rotate"), rotate,  wxT("Rotate"));
    toolBar->AddTool(wxID_ANY, wxT("Scale"), scale, wxT("Uniform Scale"));
    toolBar->AddTool(wxID_ANY, wxT("RestrictX"), restrictX, wxT("Restrict to X"));
    toolBar->AddTool(wxID_ANY, wxT("RestrictY"), restrictY, wxT("Restrict to Y"));
    toolBar->AddTool(wxID_ANY, wxT("RestrictZ"), restrictZ, wxT("Restrict to Z"));
    toolBar->AddTool(wxID_ANY, wxT("RestrictZX"), restrictZX, wxT("Restrict to ZX"));
    toolBar->AddTool(wxID_ANY, wxT("ParentCSToggle"), csToggle, wxT("Parent CS Toggle"));
    toolBar->AddTool(wxID_ANY, wxT("nuScale"), nuScale, wxT("Non-Uniform Scale"));
    toolBar->AddTool(wxID_ANY, wxT("GSnap"), gSnap, wxT("Grid Snap Toggle"));
    toolBar->AddTool(wxID_ANY, wxT("OSnap"), oSnap, wxT("Object Snap Toggle (O)"));
    toolBar->AddTool(wxID_ANY, wxT("NSnap"), nSnap, wxT("Normal Alignment"));
    toolBar->AddTool(wxID_ANY, wxT("VSnap"), vSnap, wxT("Vertex Snap"));
    toolBar->AddTool(wxID_ANY, wxT("ASnap"), aSnap, wxT("Angle Snap Toggle"));
    toolBar->AddTool(wxID_ANY, wxT("MSnap"), mSnap, wxT("Moving Snap Toggle"));
    toolBar->AddTool(wxID_ANY, wxT("ZoomExtent"), zoom, wxT("Zoom Extent"));
    toolBar->AddTool(wxID_ANY, wxT("ZoomESelection"), zoomSelected, wxT("Zoom Extents Selected"));
    toolBar->AddTool(wxID_ANY, wxT("frontView"), frontView, wxT("Front View"));
    toolBar->AddTool(wxID_ANY, wxT("backView"), backView, wxT("Back View"));
    toolBar->AddTool(wxID_ANY, wxT("leftView"), leftView, wxT("Left View"));
    toolBar->AddTool(wxID_ANY, wxT("rightView"), rightView, wxT("Right View"));
    toolBar->AddTool(wxID_ANY, wxT("topView"), topView, wxT("Top View"));
    toolBar->AddTool(wxID_ANY, wxT("bottomView"), backView, wxT("Bottom View"));
    toolBar->AddTool(wxID_ANY, wxT("resetView"), resetView, wxT("Reset View"));
    toolBar->AddTool(wxID_ANY, wxT("zoomExtends"), zoomExtends, wxT("Zoom Extends"));
    toolBar->AddTool(wxID_ANY, wxT("zoomExtendsSel"), zoomExtendsSel, wxT("Zoom Extends Selected"));
    toolBar->AddTool(wxID_ANY, wxT("zoomExtendsSelF"), zoomExtendsSelF, wxT("Zoom Extends Selected (?)"));
    toolBar->Realize();

    toolBar->SetRows(8);

    vbox->Add(toolBar, 1, wxEXPAND | wxALL);

    wxButton* simulateButton = new wxButton(toolbarPanel, wxID_ANY, wxT("Simulate"), wxDefaultPosition, wxSize(150, 20), 0);
    wxButton* useSimPosButton = new wxButton(toolbarPanel, wxID_ANY, wxT("Use Simulate Positions"), wxDefaultPosition, wxSize(150, 20), 0);
    wxButton* logButton = new wxButton(toolbarPanel, wxID_ANY, wxT("Log"), wxDefaultPosition, wxSize(150, 20), 0);
    wxButton* statButton = new wxButton(toolbarPanel, wxID_ANY, wxT("Stat"), wxDefaultPosition, wxSize(150, 20), 0);
    wxButton* breakButton = new wxButton(toolbarPanel, wxID_ANY, wxT("Break"), wxDefaultPosition, wxSize(150, 20), 0);

    vbox->Add(simulateButton, 0, wxALL | wxALIGN_TOP);
    vbox->Add(useSimPosButton, 0, wxALL | wxALIGN_TOP);
    vbox->Add(logButton, 0, wxALL | wxALIGN_TOP);
    vbox->Add(statButton, 0, wxALL | wxALIGN_TOP);
    vbox->Add(breakButton, 0, wxALL | wxALIGN_TOP);

    toolbarPanel->SetSizer(vbox);

    wxStaticBox* editModeBox = new wxStaticBox(editPanel, wxID_ANY, wxT("Edit Mode"), 
        wxDefaultPosition, wxSize(220, 800));

    wxCheckBox* object = new wxCheckBox(editModeBox, wxID_ANY, wxT("Object"), wxPoint(20, 20));
    wxCheckBox* light = new wxCheckBox(editModeBox, wxID_ANY, wxT("Light"), wxPoint(20, 20));
    wxCheckBox* soundSource = new wxCheckBox(editModeBox, wxID_ANY, wxT("Sound Source"), wxPoint(20, 20));
    wxCheckBox* soundEnv = new wxCheckBox(editModeBox, wxID_ANY, wxT("Sound Env"), wxPoint(20, 20));
    wxCheckBox* glow = new wxCheckBox(editModeBox, wxID_ANY, wxT("Glow"), wxPoint(20, 20));
    wxCheckBox* shape = new wxCheckBox(editModeBox, wxID_ANY, wxT("Shape"), wxPoint(20, 20));
    wxCheckBox* SpawnElement = new wxCheckBox(editModeBox, wxID_ANY, wxT("Spawn Element"), wxPoint(20, 20));
    wxCheckBox* wayPoints = new wxCheckBox(editModeBox, wxID_ANY, wxT("Way Points"), wxPoint(20, 20));
    wxCheckBox* sector = new wxCheckBox(editModeBox, wxID_ANY, wxT("Sector"), wxPoint(20, 20));
    wxCheckBox* portal = new wxCheckBox(editModeBox, wxID_ANY, wxT("Portal"), wxPoint(20, 20));
    wxCheckBox* group = new wxCheckBox(editModeBox, wxID_ANY, wxT("Group"), wxPoint(20, 20));
    wxCheckBox* staticParticles = new wxCheckBox(editModeBox, wxID_ANY, wxT("Static Particles"), wxPoint(20, 20));
    wxCheckBox* detailObjects = new wxCheckBox(editModeBox, wxID_ANY, wxT("Detail Objects"), wxPoint(20, 20));
    wxCheckBox* aiMap = new wxCheckBox(editModeBox, wxID_ANY, wxT("AI Map"), wxPoint(20, 20));
    wxCheckBox* wallmarks = new wxCheckBox(editModeBox, wxID_ANY, wxT("Wallmarks"), wxPoint(20, 20));
    wxCheckBox* fogVolumes = new wxCheckBox(editModeBox, wxID_ANY, wxT("Fog Volumes"), wxPoint(20, 20));

    wxSizer* editSizer = new wxGridSizer(2, 1, 1);

    editSizer->Add(object);
    editSizer->Add(light);
    editSizer->Add(soundSource);
    editSizer->Add(soundEnv);
    editSizer->Add(glow);
    editSizer->Add(shape);
    editSizer->Add(SpawnElement);
    editSizer->Add(wayPoints);
    editSizer->Add(sector);
    editSizer->Add(portal);
    editSizer->Add(group);
    editSizer->Add(staticParticles);
    editSizer->Add(detailObjects);
    editSizer->Add(aiMap);
    editSizer->Add(wallmarks);
    editSizer->Add(fogVolumes);

    editPanel->SetSizer(editSizer);

    // add the panes to the manager
    m_mgr.AddPane(editPanel, wxRIGHT, wxT("Edit Mode"));
    m_mgr.AddPane(toolbarPanel, wxLEFT, wxT("Toolbar"));

    // tell the manager to "commit" all the changes just made
    m_mgr.Update();

    wxStatusBar* StatusBar = new wxStatusBar(this);
    StatusBar->SetFieldsCount(1);
    StatusBar->SetStatusText("Field 1", 0);

    int Style[] = { wxSB_SUNKEN };
    StatusBar->SetStatusStyles(1, Style);
    SetStatusBar(StatusBar);
}

Main::~Main()
{
    m_mgr.UnInit();
}
