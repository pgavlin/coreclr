using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_tryfinally_ro_tryfinally_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryfinally_ro_tryfinally_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfinally_ro\\tryfinally_ro.cmd");
        }
    }
}
