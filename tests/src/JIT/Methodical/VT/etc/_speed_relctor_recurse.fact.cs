using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__speed_relctor_recurse__speed_relctor_recurse_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__speed_relctor_recurse__speed_relctor_recurse_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_speed_relctor_recurse\\_speed_relctor_recurse.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
