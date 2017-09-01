using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DblRoots_DblRoots_
    {
        [OuterLoop]
        [Fact]
        public void _DblRoots_DblRoots_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblRoots\\DblRoots.cmd");
        }
    }
}
