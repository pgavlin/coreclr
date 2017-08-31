using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _PREFIX_PrimitiveVT_callconv1_cs_d_callconv1_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_PrimitiveVT_callconv1_cs_d_callconv1_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\PrimitiveVT\\callconv1_cs_d\\callconv1_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
