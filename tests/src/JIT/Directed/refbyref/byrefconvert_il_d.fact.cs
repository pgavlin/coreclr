using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _refbyref_byrefconvert_il_d_byrefconvert_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _refbyref_byrefconvert_il_d_byrefconvert_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\refbyref\\byrefconvert_il_d\\byrefconvert_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
