using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _nonvirtualcall_valuetype_d_valuetype_d_
    {
        [OuterLoop]
        [Fact]
        public void _nonvirtualcall_valuetype_d_valuetype_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\nonvirtualcall\\valuetype_d\\valuetype_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
