; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
AppName=AccountCentaur
AppVerName=AccountCentaur-Personal Accounting 1.5 
AppPublisher=VitalLogic.net
AppPublisherURL=http://www.vitallogic.net
AppSupportURL=http://www.vitallogic.net
AppUpdatesURL=http://www.vitallogic.net
DefaultDirName={pf}\AccountCentaur
DefaultGroupName=AccountCentaur
LicenseFile=License.txt
InfoBeforeFile= Information.txt
OutputDir=Output
OutputBaseFilename=AccountCentaur-1.5
Compression=lzma
VersionInfoVersion=1.4
AlwaysShowComponentsList=Yes
SolidCompression=yes
WizardImageStretch=True
[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\Admin\Documents\Personal\My Projects\Unconverted\AccountCentaur\AccountCentaur\bin\Release\AccountCentaur.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Admin\Documents\Personal\My Projects\Unconverted\AccountCentaur\AccountCentaur\bin\Release\VJEncryptor.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Admin\Documents\Personal\My Projects\Unconverted\AccountCentaur\AccountCentaur\bin\Debug\AccountCentaur.chm"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Admin\Documents\Personal\My Projects\Unconverted\AccountCentaur\AccountCentaur\bin\Release\YearMonth.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Admin\Documents\Personal\My Projects\Unconverted\AccountCentaur\AccountCentaur\bin\Release\Zedgraph.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Admin\Documents\Personal\My Projects\Unconverted\AccountCentaur\AccountCentaur\bin\Release\System.Data.Sqlite.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Admin\Documents\Personal\My Projects\Unconverted\AccountCentaur\quickcalcform.css"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Admin\Documents\Personal\My Projects\Unconverted\AccountCentaur\quickcalcform.js"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Admin\Documents\Personal\My Projects\Unconverted\AccountCentaur\currconv.html"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Admin\Documents\Personal\My Projects\Unconverted\AccountCentaur\EULA.doc"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Admin\Documents\Personal\My Projects\Pure Projects\Thirdparty\zedgraph_source_v5010_4510.zip"; DestDir: "{app}"; Flags: ignoreversion

; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\AccountCentaur"; Filename: "{app}\AccountCentaur.exe"
Name: "{group}\Help"; Filename: "{app}\AccountCentaur.chm"
Name: "{group}\{cm:UninstallProgram,AccountCentaur}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\AccountCentaur"; Filename: "{app}\AccountCentaur.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\AccountCentaur"; Filename: "{app}\AccountCentaur.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\AccountCentaur.exe"; Description: "{cm:LaunchProgram,AccountCentaur}"; Flags: nowait postinstall skipifsilent

[Code]
function InitializeSetup: Boolean;
begin
if  RegKeyExists(HKEY_LOCAL_MACHINE, 'Software\Microsoft\NET Framework Setup\NDP\v4\Client') = False then
   begin  //.NET FLAG
    MsgBox('AccountCentaur uses .NET framework 4.0 Client profile and it is required to install for a ' +
          ' successful run of AccountCentaur as a user or AccountCentaur Administrator ' +
          ' Please try re installing', mbInformation, MB_OK);
     Result :=False;
  end //.NET FLAG
 else
  begin
    Result := True;
  end;
end;

