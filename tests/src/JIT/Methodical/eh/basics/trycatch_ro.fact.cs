using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_trycatch_ro_trycatch_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_trycatch_ro_trycatch_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\trycatch_ro\\trycatch_ro.cmd");
        }
    }
}
