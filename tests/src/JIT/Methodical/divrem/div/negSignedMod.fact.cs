using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _divrem_div_negSignedMod_negSignedMod_
    {
        [OuterLoop]
        [Fact]
        public void _divrem_div_negSignedMod_negSignedMod_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\divrem\\div\\negSignedMod\\negSignedMod.cmd");
        }
    }
}
