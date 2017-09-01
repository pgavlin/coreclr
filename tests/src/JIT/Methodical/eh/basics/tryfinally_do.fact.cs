using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_tryfinally_do_tryfinally_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryfinally_do_tryfinally_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfinally_do\\tryfinally_do.cmd");
        }
    }
}
