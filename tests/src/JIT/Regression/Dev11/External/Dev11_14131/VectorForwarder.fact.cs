using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_External_Dev11_14131_VectorForwarder_VectorForwarder_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_External_Dev11_14131_VectorForwarder_VectorForwarder_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\External\\Dev11_14131\\VectorForwarder\\VectorForwarder.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
