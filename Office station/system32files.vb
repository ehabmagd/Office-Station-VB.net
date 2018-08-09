﻿Imports System.IO

Public Class system32files

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "acctres.dll" Then
            Label1.Text = "(Microsoft Internet Account Manager Resources)"
            RichTextBox1.Text = "Needed to open Outlook Express. If you do not want users to be able to use Outlook Express, it is an easy way to delete this file."
        End If
        If ComboBox1.Text = "aclui.dll" Then
            Label1.Text = "(Security Descriptor Editor)"
            RichTextBox1.Text = "Needed to enable Registry Editor."
        End If
        If ComboBox1.Text = "ACTIVEDS.DLL" Then Label1.Text = " (ADs Router Layer DLL) " : RichTextBox1.Text = "Needed to open the Event viewer and Services Viewer"
        If ComboBox1.Text = "actxprxy.dll" Then Label1.Text = "(ActiveX Interface Marshaling Library)" : RichTextBox1.Text = "Essential to Internet Explorer. This DLL keeps track on Active X modules"
        If ComboBox1.Text = "ADVAPI32.DLL" Then Label1.Text = " (Advanced Windows 32 Base API)" : RichTextBox1.Text = "Needed to boot to Windows. Provides access to the fundamental resources available to a Windows system. Included are things like file systems, devices, processes and threads, access to the Windows registry, and error handling."
        If ComboBox1.Text = "ADVPACK.DLL " Then Label1.Text = "(Advpack Library)" : RichTextBox1.Text = "Needed by Microsoft Update. This DLL builds up the Windows Update menu and accesses the updates list in the registry."
        If ComboBox1.Text = "apphelp.dll" Then Label1.Text = "(Application Compatibility Client Library)" : RichTextBox1.Text = "This DLL came with service pack 3 and it enables the Microsoft management console to work."
        If ComboBox1.Text = "ASYCFILT.DLL" Then Label1.Text = "(OLE)" : RichTextBox1.Text = "Allows applications to communicate between each other using Object Linking and Embedding (OLE)"
        If ComboBox1.Text = "ATL.DLL" Then Label1.Text = "(ATL Module for Windows XP (Unicode)" : RichTextBox1.Text = "Needed by Microsoft Update. Also needed to open Event and Services Viewers. And needed by Outlook Express. Without this file Outlook Express will not open. You will receive this message when you click on the Outlook Express shortcut: Outlook Express could not be started because MSOE.DLL could not be found. Outlook Express may not be installed correctly."
        If ComboBox1.Text = "ATTRIB.EXE" Then Label1.Text = "(Attribute Utility)" : RichTextBox1.Text = "Displays or changes file attributes (read-only, archive, hidden, or system)."
        If ComboBox1.Text = "AUDIOSRV.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "AUTHZ.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "AUTOCHK.EXE " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "avifil32.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "BASESRV.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "BATMETER.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "bootvid.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "BROWSELC.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "BROWSEUI.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "CABINET.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "cabview.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "CDM.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "certcli.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "CFGMGR32.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "CHKDSK.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "clb.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "CLUSAPI.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "CMD.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "COMCTL32.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "COMDLG32.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "corpol.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "CRYPT32.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "CRYPTDLL.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "cryptsvc.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "CRYPTUI.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "CSRSRV.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "CSRSS.EXE " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "d3d8thk.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "d3d9.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "DBGHELP.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "DCIMAN32.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "ddraw.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "ddrawex.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "desk.cpl" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "devenum.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "devmgmt.msc " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "devmgr.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "DHCPCSVC.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "dinput.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "dmocx.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "DNSAPI.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "DolbyHph.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "dpcdll.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "dsound.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "dssenh.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "duser.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "dxtmsft.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "dxtrans.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "ELS.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "ESENT.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "EVENTLOG.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "EVENTVWR.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "eventvwr.msc" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "filemgmt.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "fmifs.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "FNTCACHE.DAT" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "fontext.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "framebuf.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "GDI32.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "GRPCONV.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "hal.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "hccoin.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "hid.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "html.iec" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "icmp.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "ieframe.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "ieframe.dll.mui" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "iepeers.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "iertutil.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "ieui.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "ifsutil.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "IMAGEHLP.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "imgutil.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "imm32.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "inetcomm.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "inetres.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSOERT2.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSHTML.TLB" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "inetcpl.cpl " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "inetcplc.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "IPHLPAPI.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "iuengine.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "JSCRIPT.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "kbdus.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "kdcom.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "kernel32.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "ksproxy.ax" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "ksuser.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "l3codeca.acm" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "l3codecp.acm" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "LegitCheckControl.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "licdll.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "LOGONUI.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "LSASRV.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "LSASS.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "LZ32.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "mcicda.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MFC42.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "mfc42u.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MFPLAT.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MLANG.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MMC.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "mmcbase.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "mmcndmgr.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "mpg4dmod.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MPR.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MPRAPI.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "msrating.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "rasapi32.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "rasdlg.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "rasman.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSACM32.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSACM32.DRV" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSASN1.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "msconfig.exe" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSCTFIME.IME" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "msdmo.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "msdxm.ocx" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "msftedit.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSGINA.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "mshtml.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSHTML.TLB" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSHTMLED.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "mshtmler.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSI.DLL " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "msident.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "msidle.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "msidntld.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSIEXEC.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "msihnd.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSIMG32.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "msisip.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "msls31.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSOEACCT.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSOERT2.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSPAINT.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSPATCHA.DLL " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSPRIVS.DLL " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "msrating.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "rasman.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "rasdlg.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "rasapi32.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "msrating.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MPRAPI.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSV1_0.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSVBVM60.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSVCP60.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "msvcp71.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "msvcr71.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSVCRT.DLL " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "msvfw32.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSWSOCK.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSXML3.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "MSXML3R.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "muweb.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "mydocs.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "NCOBJAPI.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "NDDEAPI.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "NETAPI32.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "newdev.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "normaliz.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "NOTEPAD.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "NTDLL.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "NTDSAPI.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "NTOSKRNL.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "nv4_disp.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "nvcod.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "nvcpl.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "nvdisp.nvu" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "nvshell.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "nvudisp.exe" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "occache.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "ODBC32.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "ODBCINT.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "OLE32.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "oleacc.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "oleaccrc.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "OLEAUT32.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "oledlg.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "olepro32.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "OLETHK32.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "PDBoot.exe " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "pidgen.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "pngfilt.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "POWRPROF.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "PROFMAP.DLL " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "PSAPI.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "qasf.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "qdvd.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "qmgr.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "rasdlg.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "rasman.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "REGAPI.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "REGSVR32.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "riched20.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "riched32.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "RPCRT4.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "RPCSS.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "RSAENH.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "rshx32.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "RTUTILS.DLL " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "RUNDLL32.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "RUNONCE.EXE " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "SAMLIB.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "SAMSRV.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "SC.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "SCESRV.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "SCHANNEL.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "SECUR32.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "sendmail.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "services.exe" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "services.msc" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "SETUPAPI.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "SFC.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "SFC_OS.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "sfcfiles.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "SHDOCLC.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "SHDOCVW.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "SHELL32.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "shellstyle.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "SHFOLDER.DLL " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "shgina.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "shimgvw.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "SHLWAPI.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "shsvcs.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "SHUTDOWN.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "SMSS.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "SNAPAPI.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "SNDVOL32.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "stdole2.tlb" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "stdole32.tlb" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "storprop.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "SVCHOST.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "SXS.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "sysdm.cpl" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "syssetup.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "TAPI32.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "TASKMGR.EXE " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "themeui.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "timedate.cpl" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "ULIB.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "umpnpmgr.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "untfs.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "url.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "urlmon.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "usbui.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "user32.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "userenv.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "USERINIT.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "usp10.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "UXTHEME.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "vbscript.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "vdmdbg.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "VERSION.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WATCHDOG.SYS" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WDMAUD.DRV" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "webcheck.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WIN32K.SYS" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WINHTTP.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WININET.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WINLOGON.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WINMM.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WINSCARD.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WINSPOOL.DRV " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WINSRV.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WINSTA.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WINTRUST.DLL " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WLDAP32.DLL " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WLNOTIFY.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "wmadmod.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "wmadmoe.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WMASF.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WMI.DLL " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "wmnetmgr.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WMP.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "wmpdxm.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "wmpeffects.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WMPLOC.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "wmpps.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "wmpshell.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WMVCORE.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WMVDECOD.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "wpa.dbl" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WS2_32.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WS2HELP.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WSHTCPIP.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WSOCK32.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WTSAPI32.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "wuaucpl.cpl " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "wuapi.dll.mui" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WUAUCLT.EXE" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "wuauclt1.exe" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "wuaucpl.cpl " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "wuaucpl.cpl.mui" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "wuaueng.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "wuaueng.dll.mui " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WUAUENG1.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "wuauserv.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WUCLTUI.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "wucltui.dll.mui " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "wupdmgr.exe" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WUPS.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "wups2.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "WUWEB.DLL" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "xmllite.dll" Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "xpsp1res.dll " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "XPSP2RES.DLL " Then Label1.Text = " " : RichTextBox1.Text = ""
        If ComboBox1.Text = "zipfldr.dll" Then Label1.Text = " " : RichTextBox1.Text = ""

    End Sub

    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Label2.Text = ComboBox1.Items.Count - 1 & ": عدد الملفات الاصلية"
        Dim path As String = "C:\Windows\System32\"
        Dim fileCount1 As Integer = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).Length
        Label3.Text = fileCount1 & ": الملفات الجهاز"



        'Dim fileCount2 As Integer = Directory.GetFiles(Path, "*.*", SearchOption.TopDirectory).Length
        'Dim fileCount As Integer = Directory.GetFiles(Path, "*.xml", SearchOption.AllDirectories).Length
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Dim s As String = "C:\Windows\System32\"

        Dim d As New System.IO.DirectoryInfo(s)

        Dim intFolders, intFiles As Integer

        intFolders = d.GetDirectories.GetUpperBound(0) + 1

        intFiles = d.GetFiles.GetUpperBound(0) + 1

        MsgBox("This directory (" & s & ") has " & intFolders.ToString & " folders and " & intFiles.ToString & " files.")
    End Sub
End Class