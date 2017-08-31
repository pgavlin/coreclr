using CoreclrTestLib;
using Xunit;

namespace Interop_StringMarshalling
{
    class _LPTSTR_LPTSTRTest_LPTSTRTest_
    {
        [OuterLoop]
        [Fact]
        public void _LPTSTR_LPTSTRTest_LPTSTRTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\StringMarshalling\\LPTSTR\\LPTSTRTest\\LPTSTRTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
