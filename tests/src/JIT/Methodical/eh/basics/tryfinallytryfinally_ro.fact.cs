using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_tryfinallytryfinally_ro_tryfinallytryfinally_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_tryfinallytryfinally_ro_tryfinallytryfinally_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\tryfinallytryfinally_ro\\tryfinallytryfinally_ro.cmd");
        }
    }
}
