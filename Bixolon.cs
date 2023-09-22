using System;
using System.Runtime.InteropServices;

namespace BXLCOM
{
    [ComVisible(true)]
    [Guid("97917DCD-A79C-4DF9-9C88-8B39F1CF5CB0")]
    [ProgId("BXLCOM.Bixolon")]
    public class Bixolon
    {
        // public delegate int BxlCallBackDelegate(int status);
        private static readonly bool Is64Bit;

        static Bixolon()
        {
            Is64Bit = System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE") != "x86";
        }

        public int PrinterOpen(int nInterface, string szPortName, int nBaudRate, int nDataBits, int nParity, int nStopBits, int nFlowControl)
        {
            if (Is64Bit)
                return BXLAPI_x64.PrinterOpen(nInterface, szPortName, nBaudRate, nDataBits, nParity, nStopBits, nFlowControl);
            else
                return BXLAPI_x86.PrinterOpen(nInterface, szPortName, nBaudRate, nDataBits, nParity, nStopBits, nFlowControl);
        }

        public int ConnectSerial(string szPortName, int nBaudRate, int nDataBits, int nParity, int nStopBits, int nFlowControl)
        {
            if (Is64Bit)
                return BXLAPI_x64.ConnectSerial(szPortName, nBaudRate, nDataBits, nParity, nStopBits, nFlowControl);
            else
                return BXLAPI_x86.ConnectSerial(szPortName, nBaudRate, nDataBits, nParity, nStopBits, nFlowControl);
        }

        public int ConnectUsb()
        {
            if (Is64Bit)
                return BXLAPI_x64.ConnectUsb();
            else
                return BXLAPI_x86.ConnectUsb();
        }

        public int ConnectParallel(string szPortName)
        {
            if (Is64Bit)
                return BXLAPI_x64.ConnectParallel(szPortName);
            else
                return BXLAPI_x86.ConnectParallel(szPortName);
        }

        public int ConnectNet(string szIpAddr, int nPortNum)
        {
            if (Is64Bit)
                return BXLAPI_x64.ConnectNet(szIpAddr, nPortNum);
            else
                return BXLAPI_x86.ConnectNet(szIpAddr, nPortNum);
        }

        public int PrinterClose()
        {
            if (Is64Bit)
                return BXLAPI_x64.PrinterClose();
            else
                return BXLAPI_x86.PrinterClose();
        }

        public int InitializePrinter()
        {
            if (Is64Bit)
                return BXLAPI_x64.InitializePrinter();
            else
                return BXLAPI_x86.InitializePrinter();
        }   

        public int GetStat()
        {
            if (Is64Bit)
                return BXLAPI_x64.GetStat();
            else
                return BXLAPI_x86.GetStat();
        }

        public int GetPrinterCurrentStatus()
        {
            if (Is64Bit)
                return BXLAPI_x64.GetPrinterCurrentStatus();
            else
                return BXLAPI_x86.GetPrinterCurrentStatus();
        }

        public int CheckPrinter()
        {
            if (Is64Bit)
                return BXLAPI_x64.CheckPrinter();
            else
                return BXLAPI_x86.CheckPrinter();
        }
        
        public int PrintText(string Data, int Alignment, int Attribute, int TextSize)
        {
            if (Is64Bit)
                return BXLAPI_x64.PrintText(Data, Alignment, Attribute, TextSize);
            else
                return BXLAPI_x86.PrintText(Data, Alignment, Attribute, TextSize);
        }

        public int PrintTextW(string Data, int Alignment, int Attribute, int TextSize, int lCodePage)
        {
            if (Is64Bit)
                return BXLAPI_x64.PrintTextW(Data, Alignment, Attribute, TextSize, lCodePage);
            else
                return BXLAPI_x86.PrintTextW(Data, Alignment, Attribute, TextSize, lCodePage);
        }

        public int PrintTextInImage(string Data, string FontName, bool Italic, bool Bold, bool Underline, int FontSize, int Alignment)
        {
            if (Is64Bit)
                return BXLAPI_x64.PrintTextInImage(Data, FontName, Italic, Bold, Underline, FontSize, Alignment);
            else
                return BXLAPI_x86.PrintTextInImage(Data, FontName, Italic, Bold, Underline, FontSize, Alignment);
        }

        public int PrintTextInImageW(string Data, string FontName, bool Italic, bool Bold, bool Underline, int FontSize, int Alignment)
        {
            if (Is64Bit)
                return BXLAPI_x64.PrintTextInImageW(Data, FontName, Italic, Bold, Underline, FontSize, Alignment);
            else
                return BXLAPI_x86.PrintTextInImageW(Data, FontName, Italic, Bold, Underline, FontSize, Alignment);
        }

        public int LineFeed(int nFeed)
        {
            if (Is64Bit)
                return BXLAPI_x64.LineFeed(nFeed);
            else
                return BXLAPI_x86.LineFeed(nFeed);
        }

        public int PrintBitmap(string FileName, int Width, int Alignment, int Level, bool bDithering)
        {
            if (Is64Bit)
                return BXLAPI_x64.PrintBitmap(FileName, Width, Alignment, Level, bDithering);
            else
                return BXLAPI_x86.PrintBitmap(FileName, Width, Alignment, Level, bDithering);
        }

        public int PrintBitmapLZMA(string FileName, int Width, int Alignment, int Level, bool bDithering)
        {
            if (Is64Bit)
                return BXLAPI_x64.PrintBitmapLZMA(FileName, Width, Alignment, Level, bDithering);
            else
                return BXLAPI_x86.PrintBitmapLZMA(FileName, Width, Alignment, Level, bDithering);
        }

        public int GetBitmapBuffer(string FileName, int Width, int Level, bool bDithering, Byte[] pOutBuffer, uint cbBuf, ref uint pcbNeeded)
        {
            if (Is64Bit)
                return BXLAPI_x64.GetPrintBitmapBuf(FileName, Width, Level, bDithering, pOutBuffer, cbBuf, ref pcbNeeded);
            else
                return BXLAPI_x86.GetPrintBitmapBuf(FileName, Width, Level, bDithering, pOutBuffer, cbBuf, ref pcbNeeded);
        }

        public int PrintBarcode(string Data, int Symbology, int Height, int Width, int Alignment, int TextPosition)
        {
            if (Is64Bit)
                return BXLAPI_x64.PrintBarcode(Data, Symbology, Height, Width, Alignment, TextPosition);
            else
                return BXLAPI_x86.PrintBarcode(Data, Symbology, Height, Width, Alignment, TextPosition);
        }

        public int PrintPDF417(string Data, int Type, int ColumnNumber, int RowNumber, int ModuleWidth, int ModuleHeight, int EccLevel, int Alignment)
        {
            if (Is64Bit)
                return BXLAPI_x64.PrintPDF417(Data, Type, ColumnNumber, RowNumber, ModuleWidth, ModuleHeight, EccLevel, Alignment);
            else
                return BXLAPI_x86.PrintPDF417(Data, Type, ColumnNumber, RowNumber, ModuleWidth, ModuleHeight, EccLevel, Alignment);
        }

        public int PrintQRCode(string Data, int Model, int ModuleSize, int EccLevel, int Alignment)
        {
            if (Is64Bit)
                return BXLAPI_x64.PrintQRCode(Data, Model, ModuleSize, EccLevel, Alignment);
            else
                return BXLAPI_x86.PrintQRCode(Data, Model, ModuleSize, EccLevel, Alignment);
        }

        public int PrintQRCodeW(string Data, int Model, int ModuleSize, int EccLevel, int Alignment)
        {
            if (Is64Bit)
                return BXLAPI_x64.PrintQRCodeW(Data, Model, ModuleSize, EccLevel, Alignment);
            else
                return BXLAPI_x86.PrintQRCodeW(Data, Model, ModuleSize, EccLevel, Alignment);
        }

        public int PrintDataMatrix(string Data, int ModuleSize, int Alignment)
        {
            if (Is64Bit)
                return BXLAPI_x64.PrintDataMatrix(Data, ModuleSize, Alignment);
            else
                return BXLAPI_x86.PrintDataMatrix(Data, ModuleSize, Alignment);
        }

        public int PrintGS1DataBar(string Data, int Symbology, int ModuleSize, int Alignment)
        {
            if (Is64Bit)
                return BXLAPI_x64.PrintGS1DataBar(Data, Symbology, ModuleSize, Alignment);
            else
                return BXLAPI_x86.PrintGS1DataBar(Data, Symbology, ModuleSize, Alignment);
        }

        public int PrintCompositeSymbology(string Data1d, int Symbol1d, string Data2d, int Symbol2d, int ModuleSize, int Alignment)
        {
            if (Is64Bit)
                return BXLAPI_x64.PrintCompositeSymbology(Data1d, Symbol1d, Data2d, Symbol2d, ModuleSize, Alignment);
            else
                return BXLAPI_x86.PrintCompositeSymbology(Data1d, Symbol1d, Data2d, Symbol2d, ModuleSize, Alignment);
        }

        public int SetCharacterSet(int Value)
        {
            if (Is64Bit)
                return BXLAPI_x64.SetCharacterSet(Value);
            else
                return BXLAPI_x86.SetCharacterSet(Value);
        }

        public int SetInterChrSet(int Value)
        {
            if (Is64Bit)
                return BXLAPI_x64.SetInterChrSet(Value);
            else
                return BXLAPI_x86.SetInterChrSet(Value);
        }

        public int GetCharacterSet()
        {
            if (Is64Bit)
                return BXLAPI_x64.GetCharacterSet();
            else
                return BXLAPI_x86.GetCharacterSet();
        }

        public int GetInterChrSet()
        {
            if (Is64Bit)
                return BXLAPI_x64.GetInterChrSet();
            else
                return BXLAPI_x86.GetInterChrSet();
        }

        public int SetUpsideDown(int mode)
        {
            if (Is64Bit)
                return BXLAPI_x64.SetUpsideDown(mode);
            else
                return BXLAPI_x86.SetUpsideDown(mode);
        }

        public int SetLeftMargin(int margin)
        {
            if (Is64Bit)
                return BXLAPI_x64.SetLeftMargin(margin);
            else
                return BXLAPI_x86.SetLeftMargin(margin);
        }

        public int SetPrintWidth(int width)
        {
            if (Is64Bit)
                return BXLAPI_x64.SetPrintWidth(width);
            else
                return BXLAPI_x86.SetPrintWidth(width);
        }

        public int CutPaper()
        {
            if (Is64Bit)
                return BXLAPI_x64.CutPaper();
            else
                return BXLAPI_x86.CutPaper();
        }

        public int DirectIO(Byte[] Data, uint uiWrite, ref Byte pRequest, ref uint uiRead)
        {
            if (Is64Bit)
                return BXLAPI_x64.DirectIO(Data, uiWrite, ref pRequest, ref uiRead);
            else
                return BXLAPI_x86.DirectIO(Data, uiWrite, ref pRequest, ref uiRead);
        }

        public int WriteBuff(Byte[] pBuffer, int nNumberOfBytesToWrite, ref int lWritten)
        {
            if (Is64Bit)
                return BXLAPI_x64.WriteBuff(pBuffer, nNumberOfBytesToWrite, ref lWritten);
            else
                return BXLAPI_x86.WriteBuff(pBuffer, nNumberOfBytesToWrite, ref lWritten);
        }

        public int ReadBuff(Byte[] pBuffer, int nNumberOfBytesToWrite, ref int lReaded)
        {
            if (Is64Bit)
                return BXLAPI_x64.ReadBuff(pBuffer, nNumberOfBytesToWrite, ref lReaded);
            else
                return BXLAPI_x86.ReadBuff(pBuffer, nNumberOfBytesToWrite, ref lReaded);
        }

        public int GetPrinterFirmwareVersion(Byte[] pBuffer, ref int bufferInBytes)
        {
            if (Is64Bit)
                return BXLAPI_x64.GetPrinterFirmwareVersion(pBuffer, ref bufferInBytes);
            else
                return BXLAPI_x86.GetPrinterFirmwareVersion(pBuffer, ref bufferInBytes);
        }

        public int getprinterModelName(Byte[] pBuffer, ref int bufferInBytes)
        {
            if (Is64Bit)
                return BXLAPI_x64.GetPrinterModelName(pBuffer, ref bufferInBytes);
            else
                return BXLAPI_x86.GetPrinterModelName(pBuffer, ref bufferInBytes);
        }

        public int TransactionStart()
        {
            if (Is64Bit)
                return BXLAPI_x64.TransactionStart();
            else
                return BXLAPI_x86.TransactionStart();
        }

        public int TransactionEnd(bool SendCompletedCheck, int Timeout)
        {
            if (Is64Bit)
                return BXLAPI_x64.TransactionEnd(SendCompletedCheck, Timeout);
            else
                return BXLAPI_x86.TransactionEnd(SendCompletedCheck, Timeout);
        }


        public int ClearScreen()
        {
            if (Is64Bit)
                return BXLAPI_x64.ClearScreen();
            else
                return BXLAPI_x86.ClearScreen();
        }

        public int ClearLine(int line)
        {
            if (Is64Bit)
                return BXLAPI_x64.ClearLine(line);
            else
                return BXLAPI_x86.ClearLine(line);
        }

        public int DisplayString(string Data)
        {
            if (Is64Bit)
                return BXLAPI_x64.DisplayString(Data);
            else
                return BXLAPI_x86.DisplayString(Data);
        }

        public int DisplayStringW(string Data, int codepage)
        {
            if (Is64Bit)
                return BXLAPI_x64.DisplayStringW(Data, codepage);
            else
                return BXLAPI_x86.DisplayStringW(Data, codepage);
        }

        public int DisplayStringAtLine(int line, string Data)
        {
            if (Is64Bit)
                return BXLAPI_x64.DisplayStringAtLine(line, Data);
            else
                return BXLAPI_x86.DisplayStringAtLine(line, Data);
        }

        public int DisplayStringAtLineW(int line, string Data, int codepage)
        {
            if (Is64Bit)
                return BXLAPI_x64.DisplayStringAtLineW(line, Data, codepage);
            else
                return BXLAPI_x86.DisplayStringAtLineW(line, Data, codepage);
        }

        public int DisplayImage(int index, int x, int y)
        {
            if (Is64Bit)
                return BXLAPI_x64.DisplayImage(index, x, y);
            else
                return BXLAPI_x86.DisplayImage(index, x, y);
        }

        public int StoreImageFile(string fileName, int index)
        {
            if (Is64Bit)
                return BXLAPI_x64.StoreImageFile(fileName, index);
            else
                return BXLAPI_x86.StoreImageFile(fileName, index);
        }

        public int SetInternationalCharacterset(int characterSet)
        {
            if (Is64Bit)
                return BXLAPI_x64.SetInternationalCharacterset(characterSet);
            else
                return BXLAPI_x86.SetInternationalCharacterset(characterSet);
        }

        public int OpenDrawer(int pinNumber)
        {
            if (Is64Bit)
                return BXLAPI_x64.OpenDrawer(pinNumber);
            else
                return BXLAPI_x86.OpenDrawer(pinNumber);
        }

        public int SetPagemode(long pageMode)
        {
            if (Is64Bit)
                return BXLAPI_x64.SetPagemode(pageMode);
            else
                return BXLAPI_x86.SetPagemode(unchecked((int)pageMode));
        }

        public int SetPagemodePrintArea(int x, int y, int width, int height)
        {
            if (Is64Bit)
                return BXLAPI_x64.SetPagemodePrintArea(x, y, width, height);
            else
                return BXLAPI_x86.SetPagemodePrintArea(x, y, width, height);
        }

        public int SetPagemodeDirection(int direction)
        {
            if (Is64Bit)
                return BXLAPI_x64.SetPagemodeDirection(direction);
            else
                return BXLAPI_x86.SetPagemodeDirection(direction);
        }

        public int SetPagemodePosition(int x, int y)
        {
            if (Is64Bit)
                return BXLAPI_x64.SetPagemodePosition(x, y);
            else
                return BXLAPI_x86.SetPagemodePosition(x, y);
        }

        /* public int BidiSetCallBack(BxlCallBackDelegate status)
        {
            if (Is64Bit)
                return BXLAPI_x64.BidiSetCallBack(status);
            else
                return BXLAPI_x86.BidiSetCallBack(status);
        } */

        public int BidiCancelCallBack()
        {
            if (Is64Bit)
                return BXLAPI_x64.BidiCancelCallBack();
            else
                return BXLAPI_x86.BidiCancelCallBack();
        }

        public int PaperEject(int option)
        {
            if (Is64Bit)
                return BXLAPI_x64.PaperEject(option);
            else
                return BXLAPI_x86.PaperEject(option);
        }

        public int GetPresenterStatus()
        {
            if (Is64Bit)
                return BXLAPI_x64.GetPresenterStatus();
            else
                return BXLAPI_x86.GetPresenterStatus();
        }

        public int SetPresenterLoop(bool enable)
        {
            if (Is64Bit)
                return BXLAPI_x64.SetPresenterLoop(enable);
            else
                return BXLAPI_x86.SetPresenterLoop(enable);
        }

        public int DownloadPrinterFirmware(string fileName)
        {
            if (Is64Bit)
                return BXLAPI_x64.DownloadPrinterFirmware(fileName);
            else
                return BXLAPI_x86.DownloadPrinterFirmware(fileName);
        }

        public int DownloadPrinterFirmwareW(string fileName)
        {
            if (Is64Bit)
                return BXLAPI_x64.DownloadPrinterFirmwareW(fileName);
            else
                return BXLAPI_x86.DownloadPrinterFirmwareW(fileName);
        }        
    }

    class BXLAPI_x86
    {
        [DllImport("BXLPAPI.dll")]
        public static extern int PrinterOpen(int nInterface, [MarshalAs(UnmanagedType.LPStr)]string szPortName, int nBaudRate, int nDataBits, int nParity, int nStopBits, int nFlowControl);

        [DllImport("BXLPAPI.dll")]
        public static extern int ConnectSerial( [MarshalAs(UnmanagedType.LPStr)]string szPortName, int nBaudRate, int nDataBits, int nParity, int nStopBits, int nFlowControl);

        [DllImport("BXLPAPI.dll")]
        public static extern int ConnectUsb();

        [DllImport("BXLPAPI.dll")]
        public static extern int ConnectParallel([MarshalAs(UnmanagedType.LPStr)]string szPortName);

        [DllImport("BXLPAPI.dll")]
        public static extern int ConnectNet([MarshalAs(UnmanagedType.LPStr)]string szIpAddr, int nPortNum);

        [DllImport("BXLPAPI.dll")]
        public static extern int PrinterClose();

        [DllImport("BXLPAPI.dll")]
        public static extern int InitializePrinter();

        [DllImport("BXLPAPI.dll")]
        public static extern int GetStat();

        [DllImport("BXLPAPI.dll")]
        public static extern int GetPrinterCurrentStatus();

        [DllImport("BXLPAPI.dll")]
        public static extern int CheckPrinter();

        [DllImport("BXLPAPI.dll")]
        public static extern int PrintText([MarshalAs(UnmanagedType.LPStr)]string Data, int Alignment, int Attribute, int TextSize);

        [DllImport("BXLPAPI.dll")]
        public static extern int PrintTextW([MarshalAs(UnmanagedType.LPWStr)]string Data, int Alignment, int Attribute, int TextSize, int lCodePage);

        [DllImport("BXLPAPI.dll")]
        public static extern int PrintTextInImage([MarshalAs(UnmanagedType.LPStr)]string Data, [MarshalAs(UnmanagedType.LPStr)]string FontName, bool Italic, bool Bold, bool Underline, int FontSize, int Alignment);

        [DllImport("BXLPAPI.dll")]
        public static extern int PrintTextInImageW([MarshalAs(UnmanagedType.LPWStr)]string Data, [MarshalAs(UnmanagedType.LPWStr)]string FontName, bool Italic, bool Bold, bool Underline, int FontSize, int Alignment);

        [DllImport("BXLPAPI.dll")]
        public static extern int LineFeed(int nFeed);

        [DllImport("BXLPAPI.dll")]
        public static extern int PrintBitmap([MarshalAs(UnmanagedType.LPStr)]string fileName, int Width, int Alignment, int Level, bool bDithering);
        
        [DllImport("BXLPAPI.dll")]
        public static extern int PrintBitmapW([MarshalAs(UnmanagedType.LPWStr)]string fileName, int Width, int Alignment, int Level, bool bDithering);
        
        [DllImport("BXLPAPI.dll")]
        public static extern int PrintBitmapLZMA([MarshalAs(UnmanagedType.LPStr)]string fileName, int Width, int Alignment, int Level, bool bDithering);

        [DllImport("BXLPAPI.dll")]
        public static extern int PrintBitmapLZMAW([MarshalAs(UnmanagedType.LPWStr)]string fileName, int Width, int Alignment, int Level, bool bDithering);

        [DllImport("BXLPAPI.dll")]
        public static extern int GetPrintBitmapBuf([MarshalAs(UnmanagedType.LPStr)]string FileName, int Width, int Level, bool bDithering, Byte[] pOutBuffer, uint cbBuf, ref uint pcbNeeded);

        [DllImport("BXLPAPI.dll")]
        public static extern int PrintBarcode([MarshalAs(UnmanagedType.LPStr)]string Data, int Symbology, int Height, int Width, int Alignment, int TextPosition);

        [DllImport("BXLPAPI.dll")]
        public static extern int PrintPDF417([MarshalAs(UnmanagedType.LPStr)]string Data, int Type, int ColumnNumber, int RowNumber, int ModuleWidth, int ModuleHeight, int EccLevel, int Alignment);

        [DllImport("BXLPAPI.dll")]
        public static extern int PrintQRCode([MarshalAs(UnmanagedType.LPStr)]string Data, int Model, int ModuleSize, int EccLevel, int Alignment);

        [DllImport("BXLPAPI.dll")]
        public static extern int PrintQRCodeW([MarshalAs(UnmanagedType.LPWStr)]string Data, int Model, int ModuleSize, int EccLevel, int Alignment);

        [DllImport("BXLPAPI.dll")]
        public static extern int PrintDataMatrix([MarshalAs(UnmanagedType.LPStr)]string Data, int ModuleSize, int Alignment);

        [DllImport("BXLPAPI.dll")]
        public static extern int PrintGS1DataBar([MarshalAs(UnmanagedType.LPStr)]string Data, int Symbology, int ModuleSize, int Alignment);

        [DllImport("BXLPAPI.dll")]
        public static extern int PrintCompositeSymbology([MarshalAs(UnmanagedType.LPStr)]string Data1d, int Symbol1d, [MarshalAs(UnmanagedType.LPWStr)]string Data2d, int Symbol2d, int ModuleSize, int Alignment);

        [DllImport("BXLPAPI.dll")]
        public static extern int SetCharacterSet(int Value);

        [DllImport("BXLPAPI.dll")]
        public static extern int SetInterChrSet(int Value);

        [DllImport("BXLPAPI.dll")]
        public static extern int GetCharacterSet();

        [DllImport("BXLPAPI.dll")]
        public static extern int GetInterChrSet();	

        [DllImport("BXLPAPI.dll")]
        public static extern int SetUpsideDown(int mode);

        [DllImport("BXLPAPI.dll")]
        public static extern int SetLeftMargin(int margin);

        [DllImport("BXLPAPI.dll")]
        public static extern int SetPrintWidth(int width);

        [DllImport("BXLPAPI.dll")]
        public static extern int CutPaper();

        [DllImport("BXLPAPI.dll")]
        public static extern int DirectIO(Byte[] Data, uint uiWrite, ref Byte pRequest, ref uint uiRead);

        [DllImport("BXLPAPI.dll")]
        public static extern int WriteBuff(Byte[] pBuffer, int nNumberOfBytesToWrite, ref int lWritten);

        [DllImport("BXLPAPI.dll")]
        public static extern int ReadBuff(Byte[] pBuffer, int nNumberOfBytesToWrite, ref int lReaded);

        [DllImport("BXLPAPI.dll")]
        public static extern int GetPrinterFirmwareVersion(Byte[] pBuffer, ref int bufferInBytes);

        [DllImport("BXLPAPI.dll")]
        public static extern int TransactionStart();

        [DllImport("BXLPAPI.dll")]
        public static extern int TransactionEnd(bool SendCompletedCheck, int Timeout);

        [DllImport("BXLPAPI.dll")]
        public static extern int ClearScreen();

        [DllImport("BXLPAPI.dll")]
        public static extern int ClearLine(int line);

        [DllImport("BXLPAPI.dll")]
        public static extern int DisplayString([MarshalAs(UnmanagedType.LPStr)]string Data);

        [DllImport("BXLPAPI.dll")]
        public static extern int DisplayStringW([MarshalAs(UnmanagedType.LPWStr)]string Data, int codepage);

        [DllImport("BXLPAPI.dll")]
        public static extern int DisplayStringAtLine(int line, [MarshalAs(UnmanagedType.LPStr)]string Data);

        [DllImport("BXLPAPI.dll")]
        public static extern int DisplayStringAtLineW(int line, [MarshalAs(UnmanagedType.LPWStr)]string Data, int codepage);

        [DllImport("BXLPAPI.dll")]
        public static extern int DisplayImage(int index, int x, int y);

        [DllImport("BXLPAPI.dll")]
        public static extern int StoreImageFile([MarshalAs(UnmanagedType.LPStr)]string fileName, int index);

        [DllImport("BXLPAPI.dll")]
        public static extern int SetInternationalCharacterset(int characterSet);

        [DllImport("BXLPAPI.dll")]
        public static extern int OpenDrawer(int pinNumber);

        [DllImport("BXLPAPI.dll")]
        public static extern int SetPagemode(int pageMode);

        [DllImport("BXLPAPI.dll")]
        public static extern int SetPagemodePrintArea(int x, int y, int width, int height);

        [DllImport("BXLPAPI.dll")]
        public static extern int SetPagemodeDirection(int direction);

        [DllImport("BXLPAPI.dll")]
        public static extern int SetPagemodePosition(int x, int y);

        [DllImport("BXLPAPI.dll")]
        public static extern int BidiCancelCallBack();

        // [DllImport("BXLPAPI.dll")]
        // public static extern int BidiSetCallBack(BXLAPI.BxlCallBackDelegate status);

        [DllImport("BXLPAPI.dll")]
        public static extern int PaperEject(int option);

        [DllImport("BXLPAPI.dll")]
        public static extern int GetPresenterStatus();
        
        [DllImport("BXLPAPI.dll")]
        public static extern int SetPresenterLoop(bool enable);

        [DllImport("BXLPAPI.dll")]
        public static extern int DownloadPrinterFirmware([MarshalAs(UnmanagedType.LPStr)]string fileName);

        [DllImport("BXLPAPI.dll")]
        public static extern int DownloadPrinterFirmwareW([MarshalAs(UnmanagedType.LPWStr)]string fileName);

        [DllImport("BXLPAPI.dll")]
        public static extern int GetPrinterModelName(Byte[] pBuffer, ref int bufferInBytes);
    }

    class BXLAPI_x64
    {
        [DllImport("BXLPAPI_x64.dll")]
        public static extern int PrinterOpen(int nInterface, [MarshalAs(UnmanagedType.LPStr)]string szPortName, int nBaudRate, int nDataBits, int nParity, int nStopBits, int nFlowControl);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int ConnectSerial([MarshalAs(UnmanagedType.LPStr)]string szPortName, int nBaudRate, int nDataBits, int nParity, int nStopBits, int nFlowControl);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int ConnectUsb();

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int ConnectParallel([MarshalAs(UnmanagedType.LPStr)]string szPortName);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int ConnectNet([MarshalAs(UnmanagedType.LPStr)]string szIpAddr, int nPortNum);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int PrinterClose();

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int InitializePrinter();

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int GetStat();

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int GetPrinterCurrentStatus();

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int CheckPrinter();

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int PrintText([MarshalAs(UnmanagedType.LPStr)]string Data, int Alignment, int Attribute, int TextSize);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int PrintTextW([MarshalAs(UnmanagedType.LPWStr)]string Data, int Alignment, int Attribute, int TextSize, int lCodePage);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int PrintTextInImage([MarshalAs(UnmanagedType.LPStr)]string Data, [MarshalAs(UnmanagedType.LPStr)]string FontName, bool Italic, bool Bold, bool Underline, int FontSize, int Alignment);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int PrintTextInImageW([MarshalAs(UnmanagedType.LPWStr)]string Data, [MarshalAs(UnmanagedType.LPWStr)]string FontName, bool Italic, bool Bold, bool Underline, int FontSize, int Alignment);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int LineFeed(int nFeed);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int PrintBitmap([MarshalAs(UnmanagedType.LPStr)]string fileName, int Width, int Alignment, int Level, bool bDithering);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int PrintBitmapW([MarshalAs(UnmanagedType.LPWStr)]string fileName, int Width, int Alignment, int Level, bool bDithering);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int PrintBitmapLZMA([MarshalAs(UnmanagedType.LPStr)]string fileName, int Width, int Alignment, int Level, bool bDithering);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int PrintBitmapLZMAW([MarshalAs(UnmanagedType.LPWStr)]string fileName, int Width, int Alignment, int Level, bool bDithering);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int GetPrintBitmapBuf([MarshalAs(UnmanagedType.LPStr)]string FileName, int Width,  int Level, bool bDithering, Byte[] pOutBuffer, uint cbBuf, ref uint pcbNeeded);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int PrintBarcode([MarshalAs(UnmanagedType.LPStr)]string Data, int Symbology, int Height, int Width, int Alignment, int TextPosition);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int PrintPDF417([MarshalAs(UnmanagedType.LPStr)]string Data, int Type, int ColumnNumber, int RowNumber, int ModuleWidth, int ModuleHeight, int EccLevel, int Alignment);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int PrintQRCode([MarshalAs(UnmanagedType.LPStr)]string Data, int Model, int ModuleSize, int EccLevel, int Alignment);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int PrintQRCodeW([MarshalAs(UnmanagedType.LPWStr)]string Data, int Model, int ModuleSize, int EccLevel, int Alignment);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int PrintDataMatrix([MarshalAs(UnmanagedType.LPStr)]string Data, int ModuleSize, int Alignment);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int PrintGS1DataBar([MarshalAs(UnmanagedType.LPStr)]string Data, int Symbology, int ModuleSize, int Alignment);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int PrintCompositeSymbology([MarshalAs(UnmanagedType.LPWStr)]string Data1d, int Symbol1d, [MarshalAs(UnmanagedType.LPWStr)]string Data2d, int Symbol2d, int ModuleSize, int Alignment);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int SetCharacterSet(int Value);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int SetInterChrSet(int Value);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int GetCharacterSet();

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int GetInterChrSet();

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int SetUpsideDown(int mode);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int SetLeftMargin(int margin);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int SetPrintWidth(int width);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int CutPaper();

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int DirectIO(Byte[] Data, uint uiWrite, ref Byte pRequest, ref uint uiRead);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int WriteBuff(Byte[] pBuffer, int nNumberOfBytesToWrite, ref int lWritten);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int ReadBuff(Byte[] pBuffer, int nNumberOfBytesToWrite, ref int lReaded);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int GetPrinterFirmwareVersion(Byte[] pBuffer, ref int bufferInBytes);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int TransactionStart();

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int TransactionEnd(bool SendCompletedCheck, int Timeout);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int ClearScreen();

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int ClearLine(int line);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int DisplayString([MarshalAs(UnmanagedType.LPStr)]string Data);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int DisplayStringW([MarshalAs(UnmanagedType.LPWStr)]string Data, int codepage);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int DisplayStringAtLine(int line, [MarshalAs(UnmanagedType.LPStr)]string Data);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int DisplayStringAtLineW(int line, [MarshalAs(UnmanagedType.LPWStr)]string Data, int codepage);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int DisplayImage(int index, int x, int y);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int StoreImageFile([MarshalAs(UnmanagedType.LPStr)]string fileName, int index);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int SetInternationalCharacterset(int characterSet);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int OpenDrawer(int pinNumber);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int SetPagemode(long pageMode);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int SetPagemodePrintArea(int x, int y, int width, int height);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int SetPagemodeDirection(int direction);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int SetPagemodePosition(int x, int y);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int BidiCancelCallBack();

        // [DllImport("BXLPAPI_x64.dll")]
        // public static extern int BidiSetCallBack(BXLAPI.BxlCallBackDelegate status);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int PaperEject(int option);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int GetPresenterStatus();

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int SetPresenterLoop(bool enable);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int DownloadPrinterFirmware([MarshalAs(UnmanagedType.LPStr)]string fileName);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int DownloadPrinterFirmwareW([MarshalAs(UnmanagedType.LPWStr)]string fileName);

        [DllImport("BXLPAPI_x64.dll")]
        public static extern int GetPrinterModelName(Byte[] pBuffer, ref int bufferInBytes);
    }
}
