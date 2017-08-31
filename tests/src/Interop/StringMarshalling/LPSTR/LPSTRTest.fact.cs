using CoreclrTestLib;
using Xunit;

namespace Interop_StringMarshalling
{
    class _LPSTR_LPSTRTest_LPSTRTest_
    {
        [Fact]
        public void _LPSTR_LPSTRTest_LPSTRTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\StringMarshalling\\LPSTR\\LPSTRTest\\LPSTRTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
