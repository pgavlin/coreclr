using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _PREFIX_PrimitiveVT_callconv1_cs_do_callconv1_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _PREFIX_PrimitiveVT_callconv1_cs_do_callconv1_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\PREFIX\\PrimitiveVT\\callconv1_cs_do\\callconv1_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
