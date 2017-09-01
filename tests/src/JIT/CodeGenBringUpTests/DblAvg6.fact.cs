using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DblAvg6_DblAvg6_
    {
        [OuterLoop]
        [Fact]
        public void _DblAvg6_DblAvg6_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblAvg6\\DblAvg6.cmd");
        }
    }
}
