using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _PREFIX_PrimitiveVT_callconv1_cs_ro_callconv1_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_PrimitiveVT_callconv1_cs_ro_callconv1_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\PrimitiveVT\\callconv1_cs_ro\\callconv1_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
