using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _JTrueLtFP_JTrueLtFP_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueLtFP_JTrueLtFP_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueLtFP\\JTrueLtFP.cmd");
        }
    }
}
