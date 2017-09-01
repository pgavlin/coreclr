using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _inlining_dev10_bug719093_variancesmall_variancesmall_
    {
        [OuterLoop]
        [Fact]
        public void _inlining_dev10_bug719093_variancesmall_variancesmall_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\inlining\\dev10_bug719093\\variancesmall\\variancesmall.cmd");
        }
    }
}
