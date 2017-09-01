using CoreclrTestLib;
using Xunit;

namespace Interop_StringMarshalling
{
    public class _LPTSTR_LPTSTRTest_LPTSTRTest_
    {
        [OuterLoop]
        [Fact]
        public void _LPTSTR_LPTSTRTest_LPTSTRTest_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\StringMarshalling\\LPTSTR\\LPTSTRTest\\LPTSTRTest.cmd");
        }
    }
}
