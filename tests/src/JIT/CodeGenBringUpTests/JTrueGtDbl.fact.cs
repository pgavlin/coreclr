using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _JTrueGtDbl_JTrueGtDbl_
    {
        [OuterLoop]
        [Fact]
        public void _JTrueGtDbl_JTrueGtDbl_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\JTrueGtDbl\\JTrueGtDbl.cmd");
        }
    }
}
