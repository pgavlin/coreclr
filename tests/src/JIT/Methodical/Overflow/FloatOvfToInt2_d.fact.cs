using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Overflow_FloatOvfToInt2_d_FloatOvfToInt2_d_
    {
        [OuterLoop]
        [Fact]
        public void _Overflow_FloatOvfToInt2_d_FloatOvfToInt2_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Overflow\\FloatOvfToInt2_d\\FloatOvfToInt2_d.cmd");
        }
    }
}
