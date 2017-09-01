using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Overflow_FloatOvfToInt2_do_FloatOvfToInt2_do_
    {
        [OuterLoop]
        [Fact]
        public void _Overflow_FloatOvfToInt2_do_FloatOvfToInt2_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Overflow\\FloatOvfToInt2_do\\FloatOvfToInt2_do.cmd");
        }
    }
}
