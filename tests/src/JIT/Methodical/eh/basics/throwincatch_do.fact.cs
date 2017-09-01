using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_throwincatch_do_throwincatch_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwincatch_do_throwincatch_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwincatch_do\\throwincatch_do.cmd");
        }
    }
}
