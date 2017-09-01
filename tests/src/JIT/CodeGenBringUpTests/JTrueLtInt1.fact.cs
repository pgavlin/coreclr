using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _JTrueLtInt1_JTrueLtInt1_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueLtInt1_JTrueLtInt1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueLtInt1\\JTrueLtInt1.cmd");
        }
    }
}
