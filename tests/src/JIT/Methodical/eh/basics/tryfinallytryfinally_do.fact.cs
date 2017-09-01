using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_tryfinallytryfinally_do_tryfinallytryfinally_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryfinallytryfinally_do_tryfinallytryfinally_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfinallytryfinally_do\\tryfinallytryfinally_do.cmd");
        }
    }
}
