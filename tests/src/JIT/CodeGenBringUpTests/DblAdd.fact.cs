using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DblAdd_DblAdd_
    {
        [OuterLoop]
        [Fact]
        public void _DblAdd_DblAdd_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblAdd\\DblAdd.cmd");
        }
    }
}
