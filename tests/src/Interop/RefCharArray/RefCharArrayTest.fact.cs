using CoreclrTestLib;
using Xunit;

namespace Interop_RefCharArray
{
    class _RefCharArrayTest_RefCharArrayTest_
    {
        [OuterLoop]
        [Fact]
        public void _RefCharArrayTest_RefCharArrayTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\RefCharArray\\RefCharArrayTest\\RefCharArrayTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
