using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _divrem_div_negSignedMod_negSignedMod_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_negSignedMod_negSignedMod_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\negSignedMod\\negSignedMod.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
