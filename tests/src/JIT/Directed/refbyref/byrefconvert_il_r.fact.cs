using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _refbyref_byrefconvert_il_r_byrefconvert_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _refbyref_byrefconvert_il_r_byrefconvert_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\refbyref\\byrefconvert_il_r\\byrefconvert_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
