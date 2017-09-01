using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_tryfinallytrycatch_do_tryfinallytrycatch_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryfinallytrycatch_do_tryfinallytrycatch_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfinallytrycatch_do\\tryfinallytrycatch_do.cmd");
        }
    }
}
