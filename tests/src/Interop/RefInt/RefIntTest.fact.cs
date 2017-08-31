using CoreclrTestLib;
using Xunit;

namespace Interop_RefInt
{
    class _RefIntTest_RefIntTest_
    {
        [OuterLoop]
        [Fact]
        public void _RefIntTest_RefIntTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\RefInt\\RefIntTest\\RefIntTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
