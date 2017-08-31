using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _PREFIX_PrimitiveVT_callconv2_cs_ro_callconv2_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_PrimitiveVT_callconv2_cs_ro_callconv2_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\PrimitiveVT\\callconv2_cs_ro\\callconv2_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
