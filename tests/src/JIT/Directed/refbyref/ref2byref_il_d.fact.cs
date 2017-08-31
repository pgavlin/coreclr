using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _refbyref_ref2byref_il_d_ref2byref_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _refbyref_ref2byref_il_d_ref2byref_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\refbyref\\ref2byref_il_d\\ref2byref_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
