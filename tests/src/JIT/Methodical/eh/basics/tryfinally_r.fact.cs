using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_tryfinally_r_tryfinally_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryfinally_r_tryfinally_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfinally_r\\tryfinally_r.cmd");
        }
    }
}
