using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _PREFIX_PrimitiveVT_callconv2_cs_r_callconv2_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_PrimitiveVT_callconv2_cs_r_callconv2_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\PrimitiveVT\\callconv2_cs_r\\callconv2_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
