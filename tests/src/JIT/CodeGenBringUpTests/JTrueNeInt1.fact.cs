using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _JTrueNeInt1_JTrueNeInt1_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueNeInt1_JTrueNeInt1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueNeInt1\\JTrueNeInt1.cmd");
        }
    }
}
