using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__relctor_recurse__relctor_recurse_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__relctor_recurse__relctor_recurse_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_relctor_recurse\\_relctor_recurse.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
