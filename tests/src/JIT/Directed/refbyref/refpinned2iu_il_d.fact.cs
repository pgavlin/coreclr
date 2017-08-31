using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _refbyref_refpinned2iu_il_d_refpinned2iu_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _refbyref_refpinned2iu_il_d_refpinned2iu_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\refbyref\\refpinned2iu_il_d\\refpinned2iu_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
