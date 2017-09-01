using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DblAvg2_DblAvg2_
    {
        [OuterLoop]
        [Fact]
        public void _DblAvg2_DblAvg2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblAvg2\\DblAvg2.cmd");
        }
    }
}
