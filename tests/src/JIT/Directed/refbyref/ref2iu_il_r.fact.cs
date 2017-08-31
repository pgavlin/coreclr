using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _refbyref_ref2iu_il_r_ref2iu_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _refbyref_ref2iu_il_r_ref2iu_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\refbyref\\ref2iu_il_r\\ref2iu_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
