using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _nonvirtualcall_valuetype_r_valuetype_r_
    {
        [OuterLoop]
        [Fact]
        public void _nonvirtualcall_valuetype_r_valuetype_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\nonvirtualcall\\valuetype_r\\valuetype_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
