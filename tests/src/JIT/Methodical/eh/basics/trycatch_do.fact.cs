using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_trycatch_do_trycatch_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_trycatch_do_trycatch_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\trycatch_do\\trycatch_do.cmd");
        }
    }
}
