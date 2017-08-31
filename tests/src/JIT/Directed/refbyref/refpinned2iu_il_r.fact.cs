using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _refbyref_refpinned2iu_il_r_refpinned2iu_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _refbyref_refpinned2iu_il_r_refpinned2iu_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\refbyref\\refpinned2iu_il_r\\refpinned2iu_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
