using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Overflow_FloatOvfToInt2_ro_FloatOvfToInt2_ro_
    {
        [OuterLoop]
        [Fact]
        public void _Overflow_FloatOvfToInt2_ro_FloatOvfToInt2_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Overflow\\FloatOvfToInt2_ro\\FloatOvfToInt2_ro.cmd");
        }
    }
}
