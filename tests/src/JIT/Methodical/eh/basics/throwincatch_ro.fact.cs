using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_basics_throwincatch_ro_throwincatch_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwincatch_ro_throwincatch_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\basics\\throwincatch_ro\\throwincatch_ro.cmd");
        }
    }
}
