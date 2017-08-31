using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _refbyref_byref2iu_il_d_byref2iu_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _refbyref_byref2iu_il_d_byref2iu_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\refbyref\\byref2iu_il_d\\byref2iu_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
