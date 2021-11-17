using System.Reflection;

namespace Core.Browser.SignaturePrinters
{
    public interface IPrinter
    {
        bool CheckIsPrintable(MemberInfo info);

        string Print(MemberInfo info);
    }
}