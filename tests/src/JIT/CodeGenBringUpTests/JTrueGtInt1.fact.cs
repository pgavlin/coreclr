using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _JTrueGtInt1_JTrueGtInt1_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueGtInt1_JTrueGtInt1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueGtInt1\\JTrueGtInt1.cmd");
        }
    }
}
