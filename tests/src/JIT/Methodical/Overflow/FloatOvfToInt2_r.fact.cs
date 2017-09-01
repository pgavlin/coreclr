using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Overflow_FloatOvfToInt2_r_FloatOvfToInt2_r_
    {
        [OuterLoop]
        [Fact]
        public void _Overflow_FloatOvfToInt2_r_FloatOvfToInt2_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Overflow\\FloatOvfToInt2_r\\FloatOvfToInt2_r.cmd");
        }
    }
}
